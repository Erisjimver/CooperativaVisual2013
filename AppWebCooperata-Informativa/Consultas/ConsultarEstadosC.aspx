<%@ Page Title="" Language="C#" MasterPageFile="~/Consultas/MasterPageConsultas.master" AutoEventWireup="true" CodeFile="ConsultarEstadosC.aspx.cs" Inherits="Consultas_ConsultarEstadosC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" Runat="Server">

     <div>
        <div style="text-align: center">
            <br />
            <table style="width: 100%">
                <tr>
                    <td colspan="2">CONSULTAR ESTADOS DE CUENTA<br />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left; width: 352px; height: 33px;">
                        <asp:Label ID="Label2" runat="server" Text="INGRESE NUMERO DE MEDIDOR: "></asp:Label>
                    </td>
                    <td style="height: 33px">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="202px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="1">Emsaba</asp:ListItem>
                            <asp:ListItem>Cnel</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 352px; text-align: left">
                        <asp:Label ID="Label1" runat="server" Text="INGRESE NUMERO DE MEDIDOR: "></asp:Label>
                    </td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBoxNMedidor" runat="server" Width="202px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar estado" />
                        <br />
                        <br />
                        <asp:Label ID="LabelError" runat="server" Text="----------------------------------------------------"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="570px">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
            <br />
        </div>
        <br />

    </div>

</asp:Content>

