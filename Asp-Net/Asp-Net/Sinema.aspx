<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sinema.aspx.cs" Inherits="Asp_Net.Sinema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="filmler_section">
        <asp:DataList ID="DataList_Filmler" runat="server" OnCancelCommand="DataList_Filmler_CancelCommand" OnDeleteCommand="DataList_Filmler_DeleteCommand" OnEditCommand="DataList_Filmler_EditCommand" OnUpdateCommand="DataList_Filmler_UpdateCommand">
            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("FilmID") %></td>
                    <td><%# Eval("FilmAdi") %></td>
                    <td><%# Eval("FilmKisaBilgi") %></td>
                    <td><%# Eval("FilmFragmanLink") %></td>
                    <td>
                        <asp:LinkButton ID="btn_Guncelle" runat="server" CommandName="Edit">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="btn_Sil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("FilmID") %>'>Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <EditItemTemplate>
                <tr>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_ID" runat="server" readonly="true" Text='<%# Eval("FilmID") %>'></asp:TextBox></td> <%--readonly id'yi editleyemesin diye--%>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_FilmAdi" runat="server" Text='<%# Eval("FilmAdi") %>'></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_FilmKisaBilgi" runat="server" Text='<%# Eval("FilmKisaBilgi") %>'></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_FilmFragmanLink" runat="server" Text='<%# Eval("FilmFragmanLink") %>'></asp:TextBox></td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update" CommandArgument='<%# Eval("FilmID") %>'>Kaydet</asp:LinkButton></td>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Cancel">İptal</asp:LinkButton></td>
                </tr>
            </EditItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
    </section>
    <section class="film_kaydet_section">
        <asp:TextBox ID="txt_FilmAd" runat="server" placeholder="Film Adı"></asp:TextBox>
        <asp:TextBox ID="txt_FilmFragman" runat="server" placeholder="Film Fragman"></asp:TextBox>
        <asp:TextBox ID="txt_FilmKisaBilgi" runat="server" placeholder="Film Kısa Bilgi"></asp:TextBox>
        <asp:Button ID="btn_FilmKaydet" runat="server" Text="Film Kaydet" OnClick="btn_FilmKaydet_Click"></asp:Button>
    </section>
</asp:Content>
