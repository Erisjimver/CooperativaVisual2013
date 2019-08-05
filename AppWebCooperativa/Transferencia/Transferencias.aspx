<%@ Page Title="" Language="C#" MasterPageFile="~/Transferencia/MasterPageTransferencia.master" AutoEventWireup="true" CodeFile="Transferencias.aspx.cs" Inherits="Transferencia_Transferencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">
    <h1 style="text-align: center">Transferencias</h1>
    <table align="left" style="width: 100%; float: left; border: 1px solid #00FF00">
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 263px; height: 44px">Ingrese numero de cedula:</td>
            <td style="height: 44px">
                <asp:TextBox ID="TextBoxCedula" runat="server" Width="182px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px; height: 44px">Saldo actual: </td>
            <td style="height: 44px">
                <asp:Label ID="LabelSaldo" runat="server" Text="......................................"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 44px">
                <center><asp:Button ID="Button1" runat="server" Text="Consultar saldo" OnClick="Button1_Click" /></center>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Ingrese cuenta de origen</td>
            <td>
                <asp:TextBox ID="TextBoxCorigen" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Ingrese cuenta de destino:</td>
            <td>
                <asp:TextBox ID="TextBoxCdestino" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 263px">Ingrese el monto:</td>
            <td>
                <asp:TextBox ID="TextBoxNmonto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
               <center> 
                   <br />
                   <asp:Button ID="Button2" runat="server" Text="Generar transaccion" OnClick="Button2_Click" /></center>
            </td>
        </tr>
        <tr>
            <td colspan="2">
               <center> <asp:Label ID="LabelResultado" runat="server" style="text-align: center" Text="________________________________"></asp:Label></center>
            </td>
        </tr>
    </table>
</asp:Content>

