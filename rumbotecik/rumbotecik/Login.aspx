<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="rumbotecik.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .kullanici_giris{
            text-align:center;
            background-color:bisque;
        }
        .kullanici_kayit input{
            display:block;
            text-align:center;
            clear:both;
            margin:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="kullanici_giris">
        <asp:TextBox ID="txt_KullaniciEposta" runat="server" placeholder="E-posta: "></asp:TextBox>
        <asp:TextBox ID="txt_KullaniciParola" runat="server" placeholder="Parola: "></asp:TextBox>
        <asp:Button ID="btn_KaullaniciGiris" runat="server" Text="Oturum Aç" OnClick="btn_KaullaniciGiris_Click" />
    </section>
</asp:Content>
