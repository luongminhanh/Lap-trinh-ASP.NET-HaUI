using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class Request2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbKetQua.Text = "Username: " + Request.Form["txtUsername"]
                + "<br/>Password: " + Request.Form["txtPassword"];
        }
    }
}