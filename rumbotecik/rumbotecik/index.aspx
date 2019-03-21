<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="rumbotecik.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="Oturum">
        <span>
            <asp:HyperLink ID="YeniKayit" runat="server" NavigateUrl="~/KullaniciKayit.aspx">Yeni Kayıt</asp:HyperLink>
        </span>
        <span>
            <asp:HyperLink ID="Giris" runat="server" NavigateUrl="~/Login.aspx">Giriş</asp:HyperLink>
        </span>
                </div>
</asp:Content>

