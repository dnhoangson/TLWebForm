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
                table.Append("<tr>");
                table.Append("<td>huythang</th>");
                table.Append("<td>huythang</th>");
                table.Append("<td>ffasdf</th>");
                table.Append(" </tr>");
                placeholder.Controls.Add(new Literal { Text = table.ToString() });
            }
        }
    }
}