<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteDeFacturacion.aspx.vb" Inherits="Reportes_Varios_wfReporteFacturacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style13
        {
            width: 100%;
        }
        .auto-style1 {
            width: 134px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">

                                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Mostrar" 
                    Width="40px" ID="ImageButton9"></asp:ImageButton>

                <br />
              </td>
              <td width="5%" align="center">

                <br />
              </td>


                          <td width="90%">Reporte De Facturación</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="width: 100%; font-family: 'Courier New', Courier, monospace;">
    <tr>
        <td align="left" colspan="2">
            <asp:Label ID="Label5" runat="server" style="color: #FF0000"></asp:Label>
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
            <table class="style13">
                <tr>
                    <td class="auto-style1">
                        Fecha Inicial:</td>
                    <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="campver"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" Format="yyyy/MM/dd" PopupButtonID="ImageButton10" TargetControlID="TextBox1" />
                            <asp:ImageButton ID="ImageButton10" runat="server" Height="22px" ImageUrl="~/images/calendar.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Fecha Final:</td>
                    <td>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="campver"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" Format="yyyy/MM/dd" PopupButtonID="ImageButton11" TargetControlID="TextBox2" />
                            <asp:ImageButton ID="ImageButton11" runat="server" Height="22px" ImageUrl="~/images/calendar.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Empresas:</td>
                    <td>
                            <asp:DropDownList ID="DropDownList18" runat="server" Width="300px" 
                            AutoPostBack="True" style="margin-left: 0px">
                            </asp:DropDownList>
                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                            Text="Incluir Sucursales" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Sucursales:"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Panel ID="Panel5" runat="server" Width="300px">
                                    &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Width="300px" 
                                        style="margin-left: 0px">
                                    </asp:DropDownList>
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                Text="Activas" Visible="False" />
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                Text="Anuladas" Visible="False" />
                            <br />
                            <br />
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="2" 
                                Text="Paquetes" Visible="False" />
                            &nbsp;<asp:RadioButton ID="RadioButton4" runat="server" GroupName="2" 
                                Text="Ciclos" Visible="False" />
                        </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="left" colspan="2">
            <table class="style13">
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button5" runat="server" Text="Reporte De Facturacion" Width="200px" />
                        <asp:Button ID="Button6" runat="server" Text="Productos Facturados" Width="200px" />
                        <asp:Button ID="Button7" runat="server" Text="Productos Por Usuarios" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View1" runat="server">
                                <table class="style13">
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" Width="40px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="Panel6" runat="server" Height="400px" ScrollBars="Both" Width="100%">
                                                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowFooter="True" style="font-size: small">
                                                    <Columns>
                                                        <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                                        <asp:BoundField DataField="fechaEncFacturaPro" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                        <asp:BoundField DataField="afiliado" HeaderText="Nombres" />
                                                        <asp:BoundField DataField="puntosencfacturapro" DataFormatString="{0:N2}" HeaderText="Puntos">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorCoEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Valor USD">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valormlencfacturapro" DataFormatString="{0:N0}" HeaderText="Valor ML">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorEfectivoEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Efectivo">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorCruceEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Cruce">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorHotelEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Hotel">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorConsigEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Consignacion">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorUsEncFacturaPro" DataFormatString="{0:N0}" HeaderText="Tarjeta">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="valorAbonoEncFacturaPun" DataFormatString="{0:N0}" HeaderText="Apartados">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="nombreempresa" HeaderText="Empresa" />
                                                        <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                        <asp:BoundField DataField="nombretipopaquete" HeaderText="Tipo Factura" />
                                                    </Columns>
                                                    <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                </table>
                            </asp:View>
                            <asp:View ID="View2" runat="server">

                                <table class="style13">
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" Width="40px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="Panel7" runat="server" Height="400px" ScrollBars="Both" Width="100%">
                                                <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowFooter="True" style="font-size: small">
                                                    <Columns>
                                                        <asp:BoundField DataField="referenciaproducto" HeaderText="Referencia" />
                                                        <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                                        <asp:BoundField DataField="cantidad" DataFormatString="{0:N0}" HeaderText="Cantidad">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                    </Columns>
                                                    <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                </table>

                            </asp:View>
                            <asp:View ID="View3" runat="server">

                                <table class="style13">
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" Width="40px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Both" Width="100%">
                                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowFooter="True" style="font-size: small">
                                                    <Columns>
                                                        <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Usuario" />
                                                        <asp:BoundField DataField="referenciaproducto" HeaderText="Referencia" />
                                                        <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                                        <asp:BoundField DataField="cantidad" DataFormatString="{0:N0}" HeaderText="Cantidad">
                                                        <ItemStyle HorizontalAlign="Right" />
                                                        </asp:BoundField>
                                                    </Columns>
                                                    <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                </table>

                            </asp:View>
                        </asp:MultiView>
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    <tr>
        <td align="left" colspan="2">
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

