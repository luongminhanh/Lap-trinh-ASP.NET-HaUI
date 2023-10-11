using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class TinhTong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b, sum;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            sum = a + b;
            txtSoC.Text = sum.ToString();
        }
    }
}