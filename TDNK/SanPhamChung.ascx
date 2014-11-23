<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamChung.ascx.cs" Inherits="SanPhamChung" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<asp:DataList ID="DataListSanPham" runat="server" RepeatDirection="Horizontal">
    <ItemTemplate>
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="imgMinhHoa" runat="server" ImageUrl='<%# string.Format( "~/images/sanpham/{0}.jpg", Eval("MaSP"))%>'/>
                </td>
            </tr>
            <tr style="overflow: hidden">
                <td>
                    <asp:Label ID="lblTenSp" runat="server" Text='<%# Eval("TenSP") %>'></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMoTa" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblGia" runat="server" Text='<%# Eval("GiaSP") %>'></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnMuaHang" runat="server" Text="Button" />
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>

