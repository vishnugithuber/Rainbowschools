﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using businesslibrary;
using dallibray;

namespace phase2_schoolproject
{
    public partial class showclasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<classes> products = new List<classes>();
            products = b.GetProducts();

            GridView1.DataSource = products;
            GridView1.DataBind();


        }
    }
}