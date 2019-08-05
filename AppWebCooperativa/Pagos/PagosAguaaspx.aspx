<%@ Page Title="" Language="C#" MasterPageFile="~/Pagos/MasterPagePagos.master" AutoEventWireup="true" CodeFile="PagosAguaaspx.aspx.cs" Inherits="Pagos_PagosAguaaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">
    <p>
        <br />
        valor por metro cubico: 0.45 ctvs.<table style="width: 100%">
            <tr>
                <td colspan="2">Consultar deuda de EMSABA</td>
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
                    <asp:Label ID="LabelDeudaA" runat="server" Text="__________________________________________"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Cancelar deuda" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="LabelResultado" runat="server" Text="____________________________________"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

