<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPedidoProductoSinProcesar.aspx.vb" Inherits="Reportes_Bodega_Principal_wfPedidoProductoSinProcesar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="2" class="style1">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="ImageButton6" runat="server" Height="50px" 
                ImageUrl="~/Imagenes/buscar.png" ToolTip="Mostrar Reporte" 
                Width="50px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Panel ID="Panel1" runat="server" Height="56px" Width="258px">
                <table cellpadding="2" class="style1">
                    <tr>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                Text="Solicitados" />
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                Text="Procesados" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                Text="Anulados" />
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" Text="Todos" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
        </td>
        <td valign="top">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
                                                    <asp:GridView ID="GridView11" 
                runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" 
                style="font-size: x-small" Width="100%">
                                                        <Columns>
                                                            <asp:BoundField DataField="idEncabezadopedido" HeaderText="Id" />
                                                            <asp:BoundField DataField="consecutivopedido" HeaderText="Numero Pedido" />
                                                            <asp:BoundField DataField="idproveedor" HeaderText="Id Proveedor" />
                                                            <asp:BoundField DataField="NombreProveedor" HeaderText="Proveedor" />
                                                            <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                                            <asp:BoundField DataField="NombrePais" HeaderText="Pais" />
                                                            <asp:BoundField DataField="fechaEncabezadoPedido" HeaderText="Fecha" />
                                                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                                                        </Columns>
                                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                        <RowStyle ForeColor="#000066" />
                                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                    </asp:GridView>
                                                </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

