<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfMuestraDetalleFactura.aspx.vb" Inherits="Reportes_Varios_wfMuestraDetalleFacturaO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


                .style1
        {
            width: 100%;
        }
        
        .style13
    {
        color: #0000FF;
        font-weight: bold;
        border-left-color: #A0A0A0;
        border-right-color: #C0C0C0;
        border-top-color: #A0A0A0;
        border-bottom-color: #C0C0C0;
    }
        

    
        .style12
        {
            width: 138px;
            height: 133px;
        }
        .style14
        {
            color: #000066;
            width: 319px;
        }
        .style15
        {
            width: 319px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="border: thin solid #CCCCCC">
    
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="width: 30%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                <span class="style13">Detalle Remisión</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></td>
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
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style14">
                            Remision Numero:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td style="color: #000066">
                            &nbsp;</td>
                        <td style="color: #000066">
                            Fecha:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Afiliado:</td>
                        <td colspan="4">
                            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Empresa:</td>
                        <td colspan="4">
                            <asp:TextBox ID="TextBox31" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Sucursal:</td>
                        <td colspan="4">
                            <asp:TextBox ID="TextBox32" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Tipo Factura:</td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                        <td style="color: #000066">
                            &nbsp;</td>
                        <td style="color: #000066">
                            Puntos:</td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Usuario:</td>
                        <td>
                            <asp:TextBox ID="TextBox30" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                        <td style="color: #000066">
                            &nbsp;</td>
                        <td style="color: #000066">
                            estado:</td>
                        <td>
                            <asp:TextBox ID="TextBox33" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="300px" ScrollBars="Vertical">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="4" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Detalle Factura</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Productos</td>
                                        <td>
                                            Papelerias</td>
                                        <td>
                                            Obsequios</td>
                                        <td>
                                            Promociones</td>
                                    </tr>
                                    <tr>
                                        <td valign="top">
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small">
                                                <Columns>
                                                    <asp:BoundField DataField="idProducto" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="nombreproducto" HeaderText="Descripción" />
                                                    <asp:BoundField DataField="cantidadDetFacturaPro" HeaderText="Can">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
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
                                        <td valign="top">
                                            &nbsp;</td>
                                        <td valign="top">
                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small">
                                                <Columns>
                                                    <asp:BoundField DataField="idProducto" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="nombreproducto" HeaderText="Descripción" />
                                                    <asp:BoundField DataField="cantidadDetFacturaPro" HeaderText="Can">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
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
                                        <td valign="top">
                                            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small">
                                                <Columns>
                                                    <asp:BoundField DataField="idProducto" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="nombreproducto" HeaderText="Descripción" />
                                                    <asp:BoundField DataField="cantidadDetFacturaPro" HeaderText="Can">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
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
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td align="right">
                            Total Remisión:
                            <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True" 
                                style="text-align: right"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Panel ID="Panel4" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="167px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Forma De Pago</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Efectivo:<asp:Label ID="Label2" runat="server" Text="[]"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox11" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Cruce De Comisiones:<asp:Label ID="Label3" runat="server" Text="[]"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Abono Hotel:<asp:Label ID="Label4" runat="server" Text="[]"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Consignación:<asp:Label ID="Label5" runat="server" Text="[]"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Tarjeta De Credito:<asp:Label ID="Label6" runat="server" Text="[]"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox15" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td style="width: 30px">
                            &nbsp;</td>
                        <td style="width: 30px">
                            &nbsp;</td>
                        <td valign="top">
                            <asp:Panel ID="Panel5" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="167px" ScrollBars="Vertical" Width="419px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Datos De Las Consignaciones</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small" Width="100%">
                                                <Columns>
                                                    <asp:BoundField DataField="idFacturaConsig" HeaderText="#">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="idConsignacion" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="numeroConsignacion" HeaderText="Número Consigancion">
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="valorConsignacion" HeaderText="Valor">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="valorUtilizadoConsignacion" 
                                                        HeaderText="valor Utilizado" />
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
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Panel ID="Panel6" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="108px" Width="500px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Apartados</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Recibo 1:</td>
                                        <td>
                                            <asp:TextBox ID="TextBox21" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="50px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox24" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="100px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox27" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="120px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Recibo 2:</td>
                                        <td>
                                            <asp:TextBox ID="TextBox22" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="50px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox25" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="100px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox28" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="120px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Recibo 3:</td>
                                        <td>
                                            <asp:TextBox ID="TextBox23" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="50px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox26" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="100px"></asp:TextBox>
                                            <asp:TextBox ID="TextBox29" runat="server" ReadOnly="True" 
                                                style="text-align: right" Width="120px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
