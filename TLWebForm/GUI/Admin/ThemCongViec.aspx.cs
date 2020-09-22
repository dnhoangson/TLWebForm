using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TLWebForm.GUI.Admin
{
    public partial class ThemCongViec : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["QLSV"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from SVIEN",con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        table.Append("<tr class='column-title'>");
                        table.Append("<th>" + rd[0] + "</th>");
                        table.Append("<th>" + rd[1] + "</th>");
                        table.Append("<th>" + rd[2] + "</th>");
                        table.Append(" </tr>");
                    }
                }
                placeholder.Controls.Add(new Literal { Text = table.ToString() });
                rd.Close();
            }
        }
    }
}