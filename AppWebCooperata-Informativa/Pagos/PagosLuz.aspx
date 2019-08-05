<%@ Page Title="" Language="C#" MasterPageFile="~/Pagos/MasterPagePagos.master" AutoEventWireup="true" CodeFile="PagosLuz.aspx.cs" Inherits="Pagos_PagosLuz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">
    <p>
        valor por kwh 0.30 ctvs.<br />
        <table style="width: 100%">
            <tr>
                <td colspan="2">Consultar deuda de CNEL</td>
            </tr>
            <tr>
                <td style="width: 242px; height: 34px">Numero de medidor:</td>
                <td style="height: 34px">
                    <asp:TextBox ID="TextBoxMedidor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 34px">
                    <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 34px">
                    <asp:Label ID="LabelDeudaA" runat="server" Text="____________________________________"></asp:Label>
                </td>
            </tr>
            </table>
    </p>
</asp:Content>

