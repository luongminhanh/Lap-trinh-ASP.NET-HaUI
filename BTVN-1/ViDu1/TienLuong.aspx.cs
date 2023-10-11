using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dlChucVu.Items.Add("Phó phòng");
                dlChucVu.Items.Add("Trưởng phòng");
                dlChucVu.Items.Add("Nhân viên");
            }
        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            if (dlChucVu.SelectedItem.Selected)
            {
                string chucVu = dlChucVu.SelectedValue;                
                Response.Redirect("TienLuong2.aspx?chucVu=" + chucVu + 
                    "&NgayCong=" + txtNgayCong.Text + "&MaNV=" + txtMa.Text
                    + "&BacLuong= "+ txtBacLuong.Text);
            }       
            
        }
    }
}