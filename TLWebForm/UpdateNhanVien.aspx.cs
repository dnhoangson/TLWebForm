using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLWebForm.DataAccess;

namespace TLWebForm
{
    public partial class UpdateNhanVien : System.Web.UI.Page
    {
        private NhanVienAccess service = new NhanVienAccess();
        private string id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loadBtn_Click(object sender, EventArgs e)
        {
            id = idTxtBox.Text;
            DataSet nv = service.GetNhanVienById(id);
            fullNameTxtBox.Text = nv.Tables[0].Rows[1].ToString();
            emailTxtBox.Text = nv.Tables[0].Rows[2].ToString();
            passwordTxtBox.Text = nv.Tables[0].Rows[3].ToString();
            string isMan = nv.Tables[0].Rows[5].ToString();
            if(isMan == "true")
            {
                
            }
        }
    }
}