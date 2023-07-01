<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfcuadreCaja.aspx.vb" Inherits="Herramientas_wfcuadreCaja" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
        

        .style14
        {
            height: 18px;
        }
        .style15
        {
            width: 100%;
        }
        .style16
        {
            width: 129px;
            color: #006699;
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
                    Height="40px" ToolTip="Buscar" Width="40px" ID="ImageButton1"></asp:ImageButton>

                </td>
                            <td width="90%">Cuadre De Caja</td>

            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style4" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <table class="style15">
                    <tr>
                        <td class="style16">
                            Fecha Inicial:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList12" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList13" runat="server" Width="150px">
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
                            <asp:DropDownList ID="DropDownList14" runat="server">
                                <asp:ListItem Value="00">Dia</asp:ListItem>
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

                            <asp:Label ID="Label4" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Fecha Final:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList15" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList16" runat="server" Width="150px">
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
                            <asp:DropDownList ID="DropDownList17" runat="server">
                                <asp:ListItem Value="00">Dia</asp:ListItem>
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

                            <asp:Label ID="Label5" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

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
                            Empresa(Pais):</td>
                        <td>
                            <asp:DropDownList ID="DropDownList18" runat="server" Width="300px" 
                            AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:Label ID="Label6" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Sucursales:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
                                    </asp:DropDownList>
                                <asp:Label ID="Label7" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td class="style14" valign="top">
                            <br />

                        </td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
                    ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px" 
                    style="font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace; color: #FFFFFF">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem Text="Facturacion" Value="Facturacion"></asp:MenuItem>
                        <asp:MenuItem Text="Comisiones Inicio Rapido" Value="Comisiones Inicio Rapido">
                        </asp:MenuItem>
                        <asp:MenuItem Text="Comisiones De Inscripcion" 
                            Value="Comisiones De Inscripcion"></asp:MenuItem>
                        <asp:MenuItem Text="Comisiones Mensuales" Value="Comisiones Mensuales">
                        </asp:MenuItem>
                        <asp:MenuItem Text="Comisiones Binarias" Value="Comisiones Binarias">
                        </asp:MenuItem>
                        <asp:MenuItem Text="Productos Facturados" Value="Productos Facturados">
                        </asp:MenuItem>
                        <asp:MenuItem Text="Resumen" Value="Resumen"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" 
                style="border-left-style: solid; border-left-width: 1px; border-right: 1px solid #A0A0A0; border-top-style: solid; border-top-width: 1px; border-bottom: 1px solid #A0A0A0">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <asp:Panel ID="Panel1" runat="server" Height="600px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton8" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Remisiones</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-size: small">
                                <Columns>
                                    <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                    <asp:BoundField DataField="fechaEncFacturaPro" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                    <asp:BoundField DataField="valorCoEncFacturaPro" DataFormatString="{0:N2}" 
                                        HeaderText="Valor">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="puntosEncfacturaPro" HeaderText="Puntos" >
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="estadoEncFacturaPro" HeaderText="Estado" />
                                    <asp:BoundField DataField="valorEfectivoEncFacturaPro" HeaderText="Efectivo">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorCruceEncFacturaPro" HeaderText="Cruce">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorHotelEncFacturaPro" HeaderText="Hotel">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorConsigEncFacturaPro" HeaderText="Consignacion">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorUsEncFacturaPro" HeaderText="Tarjeta">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorAbonoEncFacturaPun" HeaderText="Apartados">
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
                        </asp:Panel>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <asp:Panel ID="Panel2" runat="server" Height="600px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton9" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Comisiones De Inicio Rápido</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-weight: 700;">
                                <Columns>
                                    <asp:BoundField DataField="idComisionIr" HeaderText="Id Comision" />
                                    <asp:BoundField DataField="quiencobro" HeaderText="Quien Cobró?" />
                                    <asp:BoundField DataField="valorComisionIr" DataFormatString="{0:N2}" 
                                        HeaderText="Valor">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fechaPagoComisionIr" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago" />
                                    <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                                    <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                    <asp:BoundField DataField="fechaEncFacturaPro" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remision" />
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
                        <asp:Panel ID="Panel3" runat="server" Height="600px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Comisiones Bonos De Inscripción</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-weight: 700;">
                                <Columns>
                                    <asp:BoundField DataField="idComisionkit" HeaderText="Id Comision" />
                                    <asp:BoundField DataField="quiencobro" HeaderText="Quien Cobró?" />
                                    <asp:BoundField DataField="valorComisionKit" DataFormatString="{0:N2}" 
                                        HeaderText="Valor">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fechaPagoComisionKit" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago" />
                                    <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                                    <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                    <asp:BoundField DataField="fechaEncFacturaPro" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remision" />
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
                    <asp:View ID="View4" runat="server">
                        <asp:Panel ID="Panel4" runat="server" Height="400px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton11" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Resumen</td>
                                </tr>
                            </table>
                            <table class="style4">
                                <tr>
                                    <td align="center" 
                                        style="width: 300px; color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006666;">
                                        Resumen Caja</td>
                                    <td align="center" 
                                        style="width: 300px; color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006666;">
                                        Resumen Formas de Pago</td>
                                    <td align="center" 
                                        style="width: 300px; color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006666;">
                                        Total Puntos</td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-weight: 700;" Width="300px" ShowFooter="True">
                                            <Columns>
                                                <asp:BoundField DataField="nombreitem" HeaderText="Conceptos" />
                                                <asp:BoundField DataField="total" HeaderText="Totales">
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
                                    <td align="left" valign="top">
                                        <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" ShowFooter="True" style="font-weight: 700;" Width="300px">
                                            <Columns>
                                                <asp:BoundField DataField="nombreconcepto" HeaderText="Conceptos" />
                                                <asp:BoundField DataField="total" HeaderText="Totales">
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
                                    <td align="center" valign="top">
                                        <asp:Label ID="Label8" runat="server" 
                                            style="color: #146295; font-size: large; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <asp:Panel ID="Panel5" runat="server" Height="500px">
                            <table class="style15">
                                <tr>
                                    <td style="background-color: #CCCCCC">
                                        <asp:ImageButton ID="ImageButton12" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table class="style15">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" Width="70%">
                                                        <Columns>
                                                            <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad">
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
                                            </tr>
                                            <tr>
                                                <td>
                                                    Kit De Afiliacion</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" Width="70%">
                                                        <Columns>
                                                            <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad">
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
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                    </asp:View>
                    <asp:View ID="View6" runat="server">
                        <asp:Panel ID="Panel6" runat="server" Height="600px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton13" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Comisiones Mensuales</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-weight: 700;">
                                <Columns>
                                    <asp:BoundField DataField="idComision" HeaderText="Id Comision" />
                                    <asp:BoundField DataField="Nombres" HeaderText="Afiliado" />
                                    <asp:BoundField DataField="total" DataFormatString="{0:N2}" HeaderText="Total">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fechapagocomision" DataFormatString="{0:yyyy/MM/dd}" 
                                        HeaderText="Fecha Pago" />
                                    <asp:BoundField DataField="mes" HeaderText="Mes pago" />
                                    <asp:BoundField DataField="anocomision" HeaderText="Año" />
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
                    <asp:View ID="View7" runat="server">
                        <asp:Panel ID="Panel7" runat="server" Height="600px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        <asp:ImageButton ID="ImageButton14" runat="server" Height="30px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="30px" />
                                    </td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Comisiones Binarias</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-weight: 700;">
                                <Columns>
                                    <asp:BoundField DataField="idbbinario" HeaderText="Id Comision" />
                                    <asp:BoundField DataField="Nombres" HeaderText="Afiliado" />
                                    <asp:BoundField DataField="valorbbinario" DataFormatString="{0:N2}" 
                                        HeaderText="Valor">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fechainibbinario" DataFormatString="{0:yyyy/MM/dd}" 
                                        HeaderText="Fecha Inicial" />
                                    <asp:BoundField DataField="fechafinbbinario" DataFormatString="{0:yyyy/MM/dd}" 
                                        HeaderText="Fecha Final" />
                                    <asp:BoundField DataField="mes" HeaderText="Mes Comision" />
                                    <asp:BoundField DataField="ano" HeaderText="Año Comision" />
                                    <asp:BoundField DataField="fechapagobbinario" DataFormatString="{0:yyyy/MM/dd}" 
                                        HeaderText="Fecha Pago" />
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
                    <br />
                    <br />
                </asp:MultiView>
            </td>
            <td>
                &nbsp;</td>
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
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

