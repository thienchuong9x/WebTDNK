using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SanPhamChung : System.Web.UI.UserControl
{
    public string MaLoaiSP { get; set; }
    public string MaSP { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataListSanPham.DataSource = SqlLoaiSanPham.LoadSanPham(MaLoaiSP);
            DataListSanPham.DataBind();
        }
    }
}