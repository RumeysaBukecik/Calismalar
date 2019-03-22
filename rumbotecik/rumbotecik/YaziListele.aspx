<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YaziListele.aspx.cs" Inherits="rumbotecik.YaziListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bloglist {
            background-color: #f3f3f3;
            position: relative;
            display: block;
            padding: 15px 20px;
        }

            .bloglist > .resim {
                width: 30%;
                position: relative;
                float: left;
            }

            .bloglist > .icerik {
                width: 70%;
                position: relative;
                float: left;
            }

            .bloglist > .resim > img {
                height: 300px;
                width: 100%;
                object-fit: cover;
            }

        .h1YaziBaslik {
            display: block;
            text-transform: uppercase;
            text-align: center;
        }

        .pİcerik {
            padding: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="container">
                <div class="bloglist">
                    <div class="resim">
                        <img src='<%# Eval("BlogGorselUrl") %>' />
                    </div>
                    <div class="icerik">
                        <h1 class="h1YaziBaslik"><%# Eval("BlogBaslik") %></h1>
                        <p class="pİcerik"><%# Eval("Blogİcerik") %></p>
                    </div>
                    <div class="clearfix" style="margin-bottom: 10px;"></div>
                </div>
                <div class="clearfix" style="margin-bottom: 10px;"></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
