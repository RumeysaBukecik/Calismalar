<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BlogYaz.aspx.cs" Inherits="rumbotecik.BlogYaz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txt_Baslik" runat="server" placeholder="Baslik: "></asp:TextBox>
    <asp:TextBox ID="txt_İcerik" runat="server" placeholder="İcerik: "></asp:TextBox>
    <asp:FileUpload ID="input_FotoUploadBlogYaz" runat="server" />
    <asp:Button ID="btn_BlogYaz" runat="server" Text="Blog Yazısı Yaz" OnClick="btn_BlogYaz_Click" />
</asp:Content>
