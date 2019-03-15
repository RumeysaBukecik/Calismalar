<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="navUstControl.ascx.cs" Inherits="Asp_Net.navUstControl" %>
<ul class="ustNavUl">
    <li><asp:HyperLink ID="LinkAnasayfa" runat="server" NavigateUrl="~/default.aspx">Anasayfa</asp:HyperLink></li>
    <li><asp:HyperLink ID="LinkSinema" runat="server" NavigateUrl="~/Sinema.aspx">Sinema</asp:HyperLink></li>
    <li><asp:HyperLink ID="LinkSalon" runat="server" NavigateUrl="~/Salon.aspx">Salon</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/iletisim.aspx">İletişim</asp:HyperLink></li>    
</ul>