﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tutorial.Services;

namespace Tutorial
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Services.Login.CreateUser();
            Services.Login.ReadUser();
            //Services.Login.UpdateUser(1);
            //Services.Login.DeleteUser(1);
        }
    }
}