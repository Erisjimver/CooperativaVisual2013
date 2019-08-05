<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCooperativa.master" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMenu" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPrincipal" Runat="Server">

    <h1 class="auto-style1">&nbsp;</h1>
    <h1 class="auto-style1">Bienvenidos</h1>
    <p class="auto-style1">
        <asp:Image ID="Image1" runat="server" Height="390px" ImageUrl="~/Imagenes/PrincipalImg.jpg" Width="560px" />
    </p>
</asp:Content>

