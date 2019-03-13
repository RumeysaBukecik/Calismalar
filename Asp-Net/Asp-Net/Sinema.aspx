<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sinema.aspx.cs" Inherits="Asp_Net.Sinema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="filmler_section">
        <asp:DataList ID="DataList_Filmler" runat="server">
            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("FilmID") %></td>
                    <td><%# Eval("FilmAdi") %></td>
                    <td><%# Eval("FilmKisaBilgi") %></td>
                    <td><%# Eval("FilmFragmanLink") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
    </section>
    <section class="film_kaydet_section">
        <input id="txt_FilmAd" type="text" placeholder="Film Adı" />
        <input id="txt_FilmFragman" type="text" placeholder="Film Fragmanı" />
        <input id="txt_FilmOzet" type="text" placeholder="Film Özeti" />
        <button id="btn_Filmkaydet">Film Kaydet</button>
    </section>
</asp:Content>
