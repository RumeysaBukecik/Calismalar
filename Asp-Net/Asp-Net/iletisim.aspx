<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="Asp_Net.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body{
            background-color:#ffd800;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="img_sections">
        <img src="IMG/iletisim.jpg" alt="İletişim Görseli" />
    </section>
    <input id="ad" type="text" />
    <input id="email" type="email" />
    <textarea id="mesaj"></textarea>
    <button type="submit">Gönder</button>
</asp:Content>
