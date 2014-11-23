<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="uc" TagName="LoaiSP"  Src="~/SanPhamChung.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:590px">
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược OVATA</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP1" MaLoaiSP="TD001" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược NASULIN</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP2" MaLoaiSP="TD002" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược CERY</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP3" MaLoaiSP="TD003" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược BILAND</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP4" MaLoaiSP="TD004" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược SECCO</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP5" MaLoaiSP="TD005" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược NAVA</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP6" MaLoaiSP="TD006" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Thảo Dược DAMI</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP7" MaLoaiSP="TD007" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Rượu SECCO</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP8" MaLoaiSP="RT001" MaSP="" />
        </div>
        <div style="background-image: url('images/circles-green.jpg'); background-repeat: repeat; font-size: large; text-align: center;" class="separator_color"><strong style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: 700">Nhung Hươu Newzeland</strong></div>
        <div>
            <uc:LoaiSP runat="server" ID="LoaiSP9" MaLoaiSP="NH001" MaSP="" />
        </div>
    </div>
</asp:Content>

