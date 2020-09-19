﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TLWebForm.DataAccess;
using TLWebForm.DataAccess.Models;

namespace TLWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NhanVienAccess service = new NhanVienAccess();
            DataTable list = service.GetAllNhanVien();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TodoListDb_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}