<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfCompras.aspx.vb" Inherits="Reportes_Varios_wfCompras" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="../StylesKINNUX/styleafilia.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        

    
        .style16
        {
            color: #000066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">

                <br />
              </td>
                          <td width="90%">Compras</td>
            </tr>
          </table></td>
      </tr>
    </table>
    
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
    <div align="center">
    
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="width: 70%; font-family: 'Courier New', Courier, monospace;">
            <tr>
                <td align="left">
                    <asp:Label ID="Label1" runat="server" style="color: #0000FF"></asp:Label>
                </td>
                <td align="right">
                    <asp:Label ID="Label7" runat="server" style="color: #0000FF"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="Panel1" runat="server" Height="387px" ScrollBars="Vertical">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                            CellPadding="3" CssClass="Grid" style="font-size: small">
                            <Columns>
                                <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                <asp:BoundField DataField="idencfacturapro" HeaderText="Remisión Numero">
                                <HeaderStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="fechaencfacturapro" 
                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" />
                                <asp:BoundField DataField="tipoEncFacturaPro" HeaderText="Tipo Factura" />
                                <asp:BoundField DataField="puntosEncfacturaPro" HeaderText="Puntos">
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="valorCoEncFacturaPro" HeaderText="Valor">
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="estadoEncfacturaPro" HeaderText="Estado" />
                                <asp:BoundField DataField="ano" HeaderText="Año" />
                                <asp:BoundField DataField="mes" HeaderText="Mes" />
                                <asp:BoundField DataField="paqueteEncFacturaPro" HeaderText="Id Paquete" />
                                <asp:BoundField DataField="nombrePaquete" HeaderText="Nombre Paquete" />
                                <asp:BoundField DataField="numtsEncFacturaPro" HeaderText="No Ts">
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="stsEncFacturaPro" HeaderText="Es Super TS" />
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
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left" colspan="2">
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="width: 20%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td align="center" colspan="2" 
                style="color: #FFFFFF; background-color: #006699">
                Detalle Remisión</td>
        </tr>
        <tr>
            <td align="left" style="width: 450px">
                <table cellpadding="0" cellspacing="0" class="style1" style="width: 450px">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Remision numero:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Fecha:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Puntos:</td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                        </td>
                        <td style="color: #003366">
                            No De Ts:</td>
                        <td>
                            <asp:TextBox ID="TextBox40" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Afiliado:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Empresa:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox31" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Sucursal:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox32" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Tipo De Factura:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Usuario:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox30" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Estado:</td>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox33" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    </table>
            </td>
            <td align="left" valign="top">
                <asp:Panel ID="Panel13" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                    BorderWidth="1px" Height="231px">
                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                        <tr>
                            <td align="right" colspan="2" style="color: #FFFFFF; background-color: #339933">
                                Detalle Comision Patrocinador</td>
                        </tr>
                        <tr>
                            <td class="style16">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style16">
                                Patrocinador:</td>
                            <td>
                                <asp:TextBox ID="TextBox34" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                                <asp:TextBox ID="TextBox35" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style16">
                                Estado Comision:</td>
                            <td>
                                <asp:TextBox ID="TextBox36" runat="server" ReadOnly="True"></asp:TextBox>
                                &nbsp;Valor Comision:
                                <asp:TextBox ID="TextBox37" runat="server" ReadOnly="True" 
                                    style="text-align: right" Width="70px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style16">
                                Fecha Pago:</td>
                            <td>
                                <asp:TextBox ID="TextBox38" runat="server" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style16">
                                Usuario Que Pagó:</td>
                            <td>
                                <asp:TextBox ID="TextBox39" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style16" colspan="2">
                                <asp:Panel ID="Panel14" runat="server" Height="98px" ScrollBars="Vertical">
                                    <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" Width="100%">
                                        <Columns>
                                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="# Remision" />
                                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                            <asp:BoundField DataField="puntosEncFacturaPro" HeaderText="Puntos">
                                            <ItemStyle HorizontalAlign="Right" />
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
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td class="style16">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                            <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="250px" ScrollBars="Vertical">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Detalle Factura</td>
                                    </tr>
                                    <tr>
                                        <td valign="top">
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small" Width="100%">
                                                <Columns>
                                                    <asp:BoundField DataField="idProducto" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="nombreproducto" HeaderText="Nombre Producto" />
                                                    <asp:BoundField DataField="cantidadDetFacturaPro" HeaderText="Cantidad">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="valorDetFacturaPro" DataFormatString="{0:N0}" 
                                                        HeaderText="Valor" />
                                                    <asp:BoundField DataField="subtotalDetFacturaPro" DataFormatString="{0:N0}" 
                                                        HeaderText="Subtotal" Visible="False">
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="promoDetFacturaPro" HeaderText="Tipo" />
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
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td colspan="7" align="right">
                            Total Remisión:
                            <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True" 
                                style="text-align: right"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15" colspan="7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style15" colspan="3" valign="top">
                            <asp:Panel ID="Panel4" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="208px" Width="450px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Forma De Pago</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="style16">Efectivo:</span><asp:Label ID="Label2" runat="server" 
                                                Text="[]" CssClass="style16"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox11" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="style16">Cruce De Comisiones:</span><asp:Label ID="Label3" 
                                                runat="server" Text="[]" CssClass="style16"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="style16">Abono Hotel:</span><asp:Label ID="Label4" runat="server" 
                                                Text="[]" CssClass="style16"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="style16">Consignación:</span><asp:Label ID="Label5" runat="server" 
                                                Text="[]" CssClass="style16"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="style16">Tarjeta De Credito:</span><asp:Label ID="Label6" 
                                                runat="server" Text="[]" CssClass="style16"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox15" runat="server" ReadOnly="True" 
                                                style="text-align: right"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td class="style15" valign="top">
                            &nbsp;</td>
                        <td class="style15" colspan="3" valign="top">
                            <asp:Panel ID="Panel5" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="208px" ScrollBars="Vertical" Width="500px">
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
                                            <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" style="font-size: small" Width="100%">
                                                <Columns>
                                                    <asp:BoundField DataField="idtarjeta" HeaderText="Id">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="aprobacionTarjetaCre" HeaderText="# Aprobación">
                                                    <ItemStyle Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="valorUsdTarjetaCre" HeaderText="Valor Us">
                                                    <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="valorDolarTarjetaCre" HeaderText="Valor Dolar">
                                                    <ItemStyle HorizontalAlign="Right" Width="80px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="titularTarjetaCre" HeaderText="Titular Tarjeta">
                                                    <ItemStyle HorizontalAlign="Left" Width="50px" />
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
                        <td class="style15" colspan="7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style15" colspan="3" valign="top">
                            <asp:Panel ID="Panel6" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Height="167px" Width="450px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Apartados</td>
                                    </tr>
                                    <tr>
                                        <td class="style16">
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
                                        <td class="style16">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style16">
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
                                        <td class="style16">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style16">
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
                        <td class="style15" valign="top">
                            &nbsp;</td>
                        <td class="style15" colspan="3" valign="top">
                            <asp:Panel ID="Panel12" runat="server" BorderColor="#CCCCCC" 
                                BorderStyle="Solid" BorderWidth="1px" Height="167px" ScrollBars="Both" 
                                Width="500px">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" colspan="2" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Datos Tarjetas de Crédito</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            &nbsp;</td>
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
                        <td colspan="3">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td align="right">
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
                </td>
            </tr>
            </table>
    
    </div>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    
    </form>
</body>
</html>
