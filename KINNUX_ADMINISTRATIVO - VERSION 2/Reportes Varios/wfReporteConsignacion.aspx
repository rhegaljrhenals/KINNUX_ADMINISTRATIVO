<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteConsignacion.aspx.vb" Inherits="Reportes_Varios_wfReporteConsignacion" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style12
        {
            color: #000066;
        }
        .botonform
        {
            font-weight: 700;
            font-family: "Courier New", Courier, monospace;
            color: #FFFFFF;
            background-color: #006699;
        }
        .style13
        {
            width: 100%;
        }
        .auto-style1 {
            width: 166px;
        }
        .auto-style2 {
            width: 183px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Buscar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar Excell" 
                Width="40px" ID="ImageButton6"></asp:ImageButton>
                      </td>

            <td width="90%">Consulta De Consignaciones</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 80%; font-family: 'Courier New', Courier, monospace">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td class="style12">
                                    Numero Consignacion:</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="250px" ReadOnly="True" 
                                        CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    Id Consignacion:</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    Numero Consignación:</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="250px" 
                                        CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    Fecha Consignación:</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    valor Consignación:</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" 
                                        style="text-align: right" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    valor Utilizado:</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" 
                                        style="text-align: right" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    Numero De Cuenta:</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="250px" 
                                        CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">
                                    Banco:</td>
                                <td>
                                    <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="50px" 
                                        CssClass="campver"></asp:TextBox>
                                    <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" Width="250px" 
                                        CssClass="campver"></asp:TextBox>
                                    <asp:LinkButton ID="LinkButton2" runat="server">Ver Imagen Consignación</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2" 
                                    style="color: #FFFFFF; text-align: center; background-color: #006600">
                                    Relacion De Afiliados De Esta Consignación</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel2" runat="server" Height="152px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: small" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="idCodigo" HeaderText="Codigo" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
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
                                <td colspan="2" 
                                    style="color: #FFFFFF; text-align: center; background-color: #006600">
                                    Remisiones Utilizadas a Esta Consignación</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel3" runat="server" Height="229px" ScrollBars="Both" 
                                        Width="100%">
                                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: small">
                                            <Columns>
                                                <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remision #" />
                                                <asp:BoundField DataField="fechaEncFacturaPro" 
                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="tipoEncFacturaPro" HeaderText="Tipo Factura" 
                                                    Visible="False" />
                                                <asp:BoundField DataField="valorCoEncFacturaPro" HeaderText="Valor" />
                                                <asp:BoundField DataField="puntosEncfacturaPro" HeaderText="Punto" 
                                                    Visible="False" />
                                                <asp:BoundField DataField="valorEfectivoEncFacturaPro" HeaderText="Efectivo" />
                                                <asp:BoundField DataField="valorCruceEncfacturaPro" HeaderText="Cruce" />
                                                <asp:BoundField DataField="valorHotelEncFacturaPro" HeaderText="Abono Hotel" />
                                                <asp:BoundField DataField="valorConsigEncfacturaPro" 
                                                    HeaderText="Consignacion" />
                                                <asp:BoundField DataField="valorUsEncFacturaPro" HeaderText="Tarjeta" />
                                                <asp:BoundField DataField="valorAbonoEncFacturaPun" HeaderText="Apartados" />
                                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" />
                                                <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Usuario" />
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
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel5" runat="server" Height="288px" ScrollBars="Both">
                                        <iframe id="frame" runat ="server" height="300"></iframe>


                                        <asp:Image ID="Image1" runat="server" Width="100%" />
                                    </asp:Panel>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="2">
                                    <%--<asp:Panel ID="Panel1" runat="server" Height="288px" ScrollBars="Both" Width="100%">
                                        <iframe id="frame" runat ="server" height="200" Width="100%" src="http://www.knxplus.com/punto/consignaciones/153145.pdf">
                                        </iframe>
                                    </asp:Panel>--%>
                                </td>
                            </tr>

                        </table>
                    </asp:View>
                    <br />
                    <asp:View ID="View2" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style13">
                            <tr>
                                <td class="auto-style2">
                                    Numero De Consignacion:</td>
                                <td>
                                    <asp:TextBox ID="TextBox12" runat="server" style="margin-left: 0px" 
                                        Width="200px" CssClass="campver"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    <label>
                                    <asp:Button ID="Button2" runat="server" Height="30px" style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" Text="Buscar" Width="124px" />
                                    </label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    Fecha Inicial:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="TextBox10" runat="server" CssClass="campver"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox10_CalendarExtender" runat="server" 
                                        Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                                        TargetControlID="TextBox10">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton4" runat="server" Height="20px" 
                                        ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    Fecha Final:</td>
                                <td>
                                    <asp:TextBox ID="TextBox11" runat="server" CssClass="campver"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox11_CalendarExtender" runat="server" 
                                        Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton5" 
                                        TargetControlID="TextBox11">
                </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="20px" 
                                        ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    <label>
                                    <asp:Button ID="Button1" runat="server" Height="30px" style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" Text="Buscar" Width="124px" />
                                    </label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Panel ID="Panel4" runat="server" Height="334px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                                <asp:BoundField DataField="idConsignacion" HeaderText="Id Consignacion" />
                                                <asp:BoundField DataField="numeroConsignacion" 
                                                    HeaderText="Numero Consignacion" />
                                                <asp:BoundField DataField="fechaConsignacion" DataFormatString="{0:yyyy/MM/dd}" 
                                                    HeaderText="Fecha" />
                                                <asp:BoundField DataField="valorConsignacion" DataFormatString="{0:N2}" 
                                                    HeaderText="Valor">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorUtilizadoConsignacion" 
                                                    DataFormatString="{0:N2}" HeaderText="Valor Utilizado">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="numeroCuenta" HeaderText="Numero Cuenta" />
                                                <asp:BoundField DataField="nombreBanco" HeaderText="Banco" />
                                                <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
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
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
        </table>
</asp:Content>

