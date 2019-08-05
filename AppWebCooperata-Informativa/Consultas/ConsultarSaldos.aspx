<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MasterPageConsultas.master" AutoEventWireup="true" CodeFile="ConsultarSaldos.aspx.cs" Inherits="Consultas_ConsultarSaldos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">

     <div>
        <div style="text-align: center">
            <br />
            <table style="width: 100%">
                <tr>
                    <td colspan="2">CONSULTAR SALDOS
                        <br />
            </td>
                </tr>
                <tr>
                    <td style="width: 266px; text-align: left">
                        <asp:Label ID="Label2" runat="server" Text="NUMERO DE CEDULA:"></asp:Label>
                    </td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBoxCedula" runat="server" Width="270px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 266px; text-align: left">
                        <asp:Label ID="Label1" runat="server" Text="SALDO ACTUAL:"></asp:Label>
                    </td>
                    <td style="text-align: left">
                        <asp:Label ID="LabelSaldo" runat="server" Text="_______________________"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: left">
        <center>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar saldo" /></center> 
                    </td>
                </tr>
            </table>
            <br />
        </div>
         <br />

    </div>

</asp:Content>

