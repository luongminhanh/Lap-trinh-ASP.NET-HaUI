using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViDu1
{
    public partial class ListBox_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstKhu_dl.Items.Add("Vịnh Hạ Long");
                lstKhu_dl.Items.Add("Phong Nha Kẻ Bàng");
                lstKhu_dl.Items.Add("Mũi Né");
                lstKhu_dl.Items.Add("Nha Trang");
            }
        }

        protected void btnChon_click(object sender, EventArgs e)
        {
            lbDia_Diem.Text = "";
            if (lstKhu_dl.SelectedItem.Selected)
            {
                lbDia_Diem.Text = "Địa điểm bạn đã chọn là: " + lstKhu_dl.SelectedValue;
            }
        }
    }
}