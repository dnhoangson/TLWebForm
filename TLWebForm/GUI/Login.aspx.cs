﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLWebForm.DataAccess;

namespace TLWebForm.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string em = email.Value;
            string pw = password.Value;

            NhanVienAccess service = new NhanVienAccess();
            bool test = service.Login(em, pw);


        }
    }
}