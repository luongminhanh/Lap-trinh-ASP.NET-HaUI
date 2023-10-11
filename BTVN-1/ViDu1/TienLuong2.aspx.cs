using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class TienLuong2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMa.Text = Request.QueryString["MaNV"].ToString();
            txtNgayCong.Text = Request.QueryString["NgayCong"].ToString();
            string chucVu = Request.QueryString["chucVu"];
            int phuCap = 0;
            if (chucVu == "Trưởng phòng") phuCap = 500000;
            if (chucVu == "Phó phòng") phuCap = 300000;
            if (chucVu == "Nhân viên") phuCap = 100000;
            int ngayCong = int.Parse(txtNgayCong.Text);
            int nctl = ngayCong < 25 ? ngayCong : (ngayCong - 25) * 2 + 25;
            int bacLuong = int.Parse(Request.QueryString["BacLuong"].ToString());
            int tienLinh = bacLuong * 650000 * nctl + phuCap;
            txtTienLinh.Text = tienLinh.ToString();
        }
    }
}