<%@ Page Title="" Language="C#" MasterPageFile="~/Transferencia/MasterPageTransferencia.master" AutoEventWireup="true" CodeFile="Retiro.aspx.cs" Inherits="Transferencia_Retiro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="RETIROS"></asp:Label>
&nbsp;MAXIMOS DE $ 200</td>
        </tr>
        <tr>
            <td style="width: 299px">
                <asp:Label ID="Label2" runat="server" style="text-align: left" Text="NUMERO DE CUENTA: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBoxNCuenta" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="ButtonConsultar" runat="server" OnClick="ButtonConsultar_Click" Text="consultar saldo" />
            </td>
        </tr>
        <tr>
            <td style="width: 299px">
                <asp:Label ID="Label3" runat="server" Text="Saldo actual: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="Labelresultado" runat="server" Text="-----------------------------------"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 299px">
                <asp:Label ID="Label5" runat="server" style="text-align: left" Text="RETIRO RAPIDO:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>60</asp:ListItem>
                    <asp:ListItem>80</asp:ListItem>
                    <asp:ListItem>100</asp:ListItem>
                    <asp:ListItem>120</asp:ListItem>
                    <asp:ListItem>140</asp:ListItem>
                    <asp:ListItem>160</asp:ListItem>
                    <asp:ListItem>180</asp:ListItem>
                    <asp:ListItem>200</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <asp:Button ID="ButtonRetirar" runat="server" OnClick="ButtonRetirar_Click" Text="Retirar" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Labelr" runat="server" style="text-align: left" Text="----------------------------------------------"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

