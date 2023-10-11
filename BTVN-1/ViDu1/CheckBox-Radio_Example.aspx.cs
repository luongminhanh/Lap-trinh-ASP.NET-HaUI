using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class CheckBox_Radio_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rblThu_Nhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbThu_Nhap.Text = rblThu_Nhap.SelectedItem.Text;
        }
    }
}