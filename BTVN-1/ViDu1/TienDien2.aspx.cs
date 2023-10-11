using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class TienDien2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a, b, tong, tien;
            a = int.Parse(Request.Form["txtCu"]);
            b = int.Parse(Request.Form["txtMoi"]);
            tong = b - a;
            if (tong < 100) tien = tong * 2000;
            else if (tong <= 150) tien = 200000 + 2500 * (100 - tong);
            else if (tong <= 200) tien = 200000 + 2500 * 50 + (200 - tong);
            else tien = 200000 + 2500 * 50 + 2800 * 50 + 3500 * (tong - 200);
            txtTien.Text = "Tổng tiền phải trả là: " + tien.ToString();
        }
    }
}