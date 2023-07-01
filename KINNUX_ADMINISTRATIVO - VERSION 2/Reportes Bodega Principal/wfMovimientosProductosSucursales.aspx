<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfMovimientosProductosSucursales.aspx.vb" Inherits="Reportes_Bodega_Principal_wfMovimientosProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            color: #006699;
        }
        .style3
        {
            color: #006699;
            height: 17px;
        }
        .style4
        {
            color: #006699;
            height: 19px;
        }
        .style5
        {
            height: 19px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">&nbsp;<asp:ImageButton ID="ImageButton7" 
                  runat="server" Height="40px" 
                                                    ImageUrl="~/Imagenes/buscar.png" 
                  ToolTip="Mostrar" Width="40px" />
                <br />
              </td>
                          <td width="90%">Movimientos De Productos Sucursales</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                        <table class="style1" __designer:mapid="8c4">
                            <tr __designer:mapid="8c5">
                                <td __designer:mapid="8c6">
                                    <table class="style1" __designer:mapid="8c7">
                                        <tr __designer:mapid="8ce">
                                            <td class="style2" __designer:mapid="8cf">
                                                Fecha Inicial:</td>
                                            <td __designer:mapid="8d0">
                                                <asp:DropDownList ID="DropDownList1" runat="server">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList2" runat="server">
                                                    <asp:ListItem Value="00">Mes</asp:ListItem>
                                                    <asp:ListItem Value="01">Enero</asp:ListItem>
                                                    <asp:ListItem Value="02">Febrero</asp:ListItem>
                                                    <asp:ListItem Value="03">Marzo</asp:ListItem>
                                                    <asp:ListItem Value="04">Abril</asp:ListItem>
                                                    <asp:ListItem Value="05">Mayo</asp:ListItem>
                                                    <asp:ListItem Value="06">Junio</asp:ListItem>
                                                    <asp:ListItem Value="07">Julio</asp:ListItem>
                                                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                                                    <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                                                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList3" runat="server">
                                                    <asp:ListItem>Dia</asp:ListItem>
                                                    <asp:ListItem>01</asp:ListItem>
                                                    <asp:ListItem>02</asp:ListItem>
                                                    <asp:ListItem>03</asp:ListItem>
                                                    <asp:ListItem>04</asp:ListItem>
                                                    <asp:ListItem>05</asp:ListItem>
                                                    <asp:ListItem>06</asp:ListItem>
                                                    <asp:ListItem>07</asp:ListItem>
                                                    <asp:ListItem>08</asp:ListItem>
                                                    <asp:ListItem>09</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:Label ID="Label4" runat="server" ForeColor="Red" 
                                                    style="font-family: 'Courier New', Courier, monospace"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="902">
                                            <td class="style2" __designer:mapid="903">
                                                Fecha Final:</td>
                                            <td __designer:mapid="904">
                                                <asp:DropDownList ID="DropDownList4" runat="server">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList5" runat="server">
                                                    <asp:ListItem Value="00">Mes</asp:ListItem>
                                                    <asp:ListItem Value="01">Enero</asp:ListItem>
                                                    <asp:ListItem Value="02">Febrero</asp:ListItem>
                                                    <asp:ListItem Value="03">Marzo</asp:ListItem>
                                                    <asp:ListItem Value="04">Abril</asp:ListItem>
                                                    <asp:ListItem Value="05">Mayo</asp:ListItem>
                                                    <asp:ListItem Value="06">Junio</asp:ListItem>
                                                    <asp:ListItem Value="07">Julio</asp:ListItem>
                                                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                                                    <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                                                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList6" runat="server">
                                                    <asp:ListItem>Dia</asp:ListItem>
                                                    <asp:ListItem>01</asp:ListItem>
                                                    <asp:ListItem>02</asp:ListItem>
                                                    <asp:ListItem>03</asp:ListItem>
                                                    <asp:ListItem>04</asp:ListItem>
                                                    <asp:ListItem>05</asp:ListItem>
                                                    <asp:ListItem>06</asp:ListItem>
                                                    <asp:ListItem>07</asp:ListItem>
                                                    <asp:ListItem>08</asp:ListItem>
                                                    <asp:ListItem>09</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:Label ID="Label5" runat="server" ForeColor="Red" 
                                                    style="font-family: 'Courier New', Courier, monospace"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="936">
                                            <td class="style4" __designer:mapid="937">
                                                </td>
                                            <td __designer:mapid="938" align="right" class="style5">
                                                </td>
                                        </tr>
                                        <tr __designer:mapid="939">
                                            <td class="style2" __designer:mapid="93a">
                                                Empresas:</td>
                                            <td __designer:mapid="93b">
                                                <asp:DropDownList ID="DropDownList7" runat="server" Width="300px" 
                                                    AutoPostBack="True">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label6" runat="server" ForeColor="Red" 
                                                    style="font-family: 'Courier New', Courier, monospace"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="939">
                                            <td class="style2" __designer:mapid="93a">
                                                Sucursales:</td>
                                            <td __designer:mapid="93b">
                                                <asp:DropDownList ID="DropDownList8" runat="server" Width="300px">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label7" runat="server" ForeColor="Red" 
                                                    style="font-family: 'Courier New', Courier, monospace"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="939">
                                            <td class="style2" __designer:mapid="93a">
                                                &nbsp;</td>
                                            <td __designer:mapid="93b">
                                                &nbsp;</td>
                                        </tr>
                                        <tr __designer:mapid="939">
                                            <td class="style2" __designer:mapid="93a" colspan="2">
                                                <table class="style1">
                                                    <tr>
                                                        <td style="width: 400px" valign="top">
                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" Width="400px">
                                                                    <Columns>
                                                                        <asp:CommandField SelectText="Mostrar" ShowSelectButton="True" />
                                                                        <asp:BoundField DataField="idproducto" HeaderText="Id Producto" />
                                                                        <asp:BoundField DataField="nombreProducto" HeaderText="Productos" />
                                                                        <asp:BoundField DataField="cantBodPuntoProducto" HeaderText="Cantidad">
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
                                                            </td>
                                                        <td valign="top">
                                                            <asp:Panel ID="Panel6" runat="server">
                                                                <table class="style1">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Menu ID="Menu1" runat="server" BackColor="#006699" 
                                                                                DynamicHorizontalOffset="2" Font-Names="Courier New" Font-Size="0.8em" 
                                                                                ForeColor="#000066" Orientation="Horizontal" StaticSubMenuIndent="10px" 
                                                                                style="background-color: #FFFFCC; color: #FFFFFF; font-size: medium; font-weight: 700; font-family: 'Courier New', Courier, monospace; text-align: center;" 
                                                                                Width="100%">
                                                                                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                                                                                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                                                                <DynamicMenuStyle BackColor="#B5C7DE" />
                                                                                <DynamicSelectedStyle BackColor="#507CD1" />
                                                                                <Items>
                                                                                    <asp:MenuItem Text="Entradas" Value="Entradas"></asp:MenuItem>
                                                                                    <asp:MenuItem Text="Salidas" Value="Salidas"></asp:MenuItem>
                                                                                    <asp:MenuItem Text="Resumen" Value="Resumen"></asp:MenuItem>
                                                                                </Items>
                                                                                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                                                                                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                                                                <StaticSelectedStyle BackColor="#507CD1" />
                                                                            </asp:Menu>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:MultiView ID="MultiView1" runat="server">
                                                                                <asp:View ID="View2" runat="server">
                                                                                    <asp:Panel ID="Panel3" runat="server" Height="600px" ScrollBars="Vertical">
                                                                                        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                            CellPadding="3" ShowFooter="True">
                                                                                            <Columns>
                                                                                                <asp:BoundField DataField="idEncDesProductoPunto" HeaderText="Id Despacho" />
                                                                                                <asp:BoundField DataField="fechaEncDesProductoPunto" 
                                                                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                                                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                                                                <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" />
                                                                                                <asp:BoundField DataField="idEncPedProductoPais" HeaderText="Pedido #" />
                                                                                                <asp:BoundField DataField="guiaEncDesProductoPunto" HeaderText="Guia #" />
                                                                                                <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                                                                                <asp:BoundField DataField="cantEnvDetDesProductoPunto" 
                                                                                                    HeaderText="Cantidad Enviada" />
                                                                                                <asp:BoundField DataField="cantRecDetDesProductoPunto" 
                                                                                                    HeaderText="Cantidad Recibida" />
                                                                                                <asp:BoundField DataField="cantPenDetDesProductoPunto" 
                                                                                                    HeaderText="Cantidad Pendiente" />
                                                                                            </Columns>
                                                                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                                                                HorizontalAlign="Right" />
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
                                                                                </asp:View>
                                                                                <asp:View ID="View3" runat="server">
                                                                                    <asp:Panel ID="Panel4" runat="server" Height="600px" ScrollBars="Both">
                                                                                        <table class="style1">
                                                                                            <tr>
                                                                                                <td align="center" 
                                                                                                    style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #009999">
                                                                                                    Remisiones</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                                                                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                        CellPadding="3" ShowFooter="True">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField DataField="idEncfacturapro" HeaderText="Remision #" />
                                                                                                            <asp:BoundField DataField="fechaencfacturapro" 
                                                                                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                                                                            <asp:BoundField DataField="nombreproducto" HeaderText="Producto" />
                                                                                                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad">
                                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                                            </asp:BoundField>
                                                                                                        </Columns>
                                                                                                        <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                                                                            HorizontalAlign="Right" />
                                                                                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                                                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                                                        <RowStyle ForeColor="#000066" />
                                                                                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                                                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                                                                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                                                                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                                                                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                                                                    </asp:GridView>
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td align="center" 
                                                                                                    style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #009999">
                                                                                                    Despachos a Paises</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                                                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                        CellPadding="3" ShowFooter="True">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField DataField="idEncDesProductoPaisPais" HeaderText="Id Despacho" />
                                                                                                            <asp:BoundField DataField="fechaEncDesProductoPaisPais" 
                                                                                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                                                                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa Que Envia" />
                                                                                                            <asp:BoundField DataField="nombreempresaRecibe" 
                                                                                                                HeaderText="Empresa Que Recibe" />
                                                                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Nombre Producto" />
                                                                                                            <asp:BoundField DataField="cantEnvDetDesProductoPaisPais" 
                                                                                                                HeaderText="Cantidad Enviada">
                                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField DataField="cantRecDetDesProductoPaisPais" 
                                                                                                                HeaderText="Cantidad Recibida">
                                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField DataField="cantPenDetDesProductoPaisPais" 
                                                                                                                HeaderText="Cantidad Pendiente">
                                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                                            </asp:BoundField>
                                                                                                        </Columns>
                                                                                                        <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                                                                            HorizontalAlign="Right" />
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
                                                                                        <br />
                                                                                    </asp:Panel>
                                                                                </asp:View>
                                                                                <asp:View ID="View4" runat="server">
                                                                                </asp:View>
                                                                                <br />
                                                                            </asp:MultiView>
                                                                        </td>
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
                                                </table>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="939">
                                            <td class="style2" __designer:mapid="93a">
                                                &nbsp;</td>
                                            <td __designer:mapid="93b" align="right">
                                                &nbsp;</td>
                                        </tr>
                                        </table>
                                </td>
                            </tr>
                            <tr __designer:mapid="9ac">
                                <td __designer:mapid="9ad">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
        </tr>
        </table>
</asp:Content>

