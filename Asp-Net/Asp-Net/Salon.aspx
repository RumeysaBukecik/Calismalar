<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Salon.aspx.cs" Inherits="Asp_Net.Salon1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="filmler_section">
        <asp:DataList ID="DataList_Salonlar" runat="server" OnCancelCommand="DataList_Salonlar_CancelCommand" OnDeleteCommand="DataList_Salonlar_DeleteCommand" OnEditCommand="DataList_Salonlar_EditCommand" OnUpdateCommand="DataList_Salonlar_UpdateCommand">
            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("SalonID") %></td>
                    <td><%# Eval("SalonAdi") %></td>
                    <td><%# Eval("SalonTest") %></td>
                    <td>
                        <asp:LinkButton ID="btn_Guncelle" runat="server" CommandName="Edit">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="btn_Sil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("SalonID") %>'>Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <EditItemTemplate>
                <tr>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_ID" runat="server" ReadOnly="true" Text='<%# Eval("SalonID") %>'>Ne işe yarıyor acep?</asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_SalonAdi" runat="server" Text='<%# Eval("SalonAdi") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_SalonTest" runat="server" Text='<%# Eval("SalonTest") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:LinkButton ID="Link_Kaydet" runat="server" CommandName="Update" CommandArgument='<%# Eval("SalonID") %>'>Kaydet</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="Link_İptal" runat="server" CommandName="Cancel">İptal</asp:LinkButton>
                    </td>
                </tr>
            </EditItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>
    </section>
    <section class="salon_kaydet_section">
        <asp:TextBox ID="txt_SalonAd" runat="server" placeholder="Salon Adı"></asp:TextBox>
        <asp:TextBox ID="txt_SalonTest" runat="server" placeholder="Salon Test"></asp:TextBox>
        <asp:Button ID="btn_SalonKaydet" runat="server" Text="Salon Kaydet" OnClick="btn_SalonKaydet_Click"></asp:Button>
    </section>
</asp:Content>
