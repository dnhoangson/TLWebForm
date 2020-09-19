﻿using Dapper;
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

        public DataSet GetNhanVienById(string id)
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from NhanVien where id = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void InsertNhanVien(string fullName, string email, string password, bool isManager)
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"insert into NhanVien(FullName, Email, Password, AvatarPath, IsManager)" +
                                "values (@FullName, @Email, @Password, NULL, @IsManager)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    //cmd.Parameters.AddWithValue("@AvatarPath", avatarPath);
                    cmd.Parameters.AddWithValue("@IsManager", isManager);
                    //System.Diagnostics.Debug.WriteLine(query);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataSet GetNhanVienLatest()
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from NhanVien where id = (select max(id) from NhanVien)";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void UpdateNhanVien(string id, string fullName, string email, string password, bool isManager)
        {
            string connectionString = DataAccess.Internal.DataAccess.GetConnectionString("TodoListDb");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"declare @fullName varchar(256), @email varchar(100), @password varchar(100), @isManager bit " +
                                "update NhanVien " +
                                "set FullName = ISNULL(@fullName, FullName), " +
                                "Email = ISNULL(@email, Email), " +
                                "Password = ISNULL(@password, Password), " +
                                "IsManager = @isManager " +
                                "where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    //cmd.Parameters.AddWithValue("@AvatarPath", avatarPath);
                    cmd.Parameters.AddWithValue("@IsManager", isManager);
                    //System.Diagnostics.Debug.WriteLine(query);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}