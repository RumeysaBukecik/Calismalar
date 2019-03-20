﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KullaniciKayit.aspx.cs" Inherits="rumbotecik.KullaniciKayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="kullanici_giris">
        <asp:TextBox ID="txt_KullaniciAdSoyad" runat="server" placeholder="Kullanıcı Ad Soyad: "></asp:TextBox>
        <input type="date" id="input_KullaniciDogumTarihi" runat="server" value="1990.01.01" />
        
        <asp:TextBox ID="txt_KullaniciEposta" runat="server" placeholder="E-posta: "></asp:TextBox>
        <asp:TextBox ID="txt_KullaniciParola" runat="server" placeholder="Parola: "></asp:TextBox>
        <asp:FileUpload ID="input_FotoUpload" runat="server" />
        <asp:Button ID="btn_KaullaniciKaydet" runat="server" Text="Kullanici Kaydet" OnClick="btn_KaullaniciKaydet_Click" />
    </section>
</asp:Content>
