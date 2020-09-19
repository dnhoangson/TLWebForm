using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TLWebForm.DataAccess.Models;

namespace TLWebForm.DataAccess
{
    public class NhanVienAccess
    {
        public DataTable GetAllNhanVien()
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];

                //List<NhanVien> rows = connection.Query<NhanVien>("ListAll").ToList();
                //return rows;
            }
        }

        public DataTable GetNhanVienById(string id)
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from NhanVien where id = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }

        public void InsertNhanVien(string fullName, string email, string password, string avatarPath, bool isManager)
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"insert into NhanVien(FullName, Email, Password, AvatarPath, IsManager)" +
                                "values (@FullName, @Email, @Password, @AvatarPath, @IsManager)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@AvatarPath", avatarPath);
                cmd.Parameters.AddWithValue("@IsManager", isManager);
                System.Diagnostics.Debug.WriteLine(query);
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}