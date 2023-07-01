<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteFacturacion.aspx.vb" Inherits="Reportes_Varios_wfReporteFacturacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style13
        {
            width: 100%;
        }
        .auto-style1 {
            width: 116px;
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

                                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                    Width="40px" ID="ImageButton1"></asp:ImageButton>

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
                            <asp:DropDownList ID="DropDownList12" runat="server" style="margin-left: 0px">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList13" runat="server" Width="150px" style="margin-left: 0px">
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
                            <asp:DropDownList ID="DropDownList14" runat="server" style="margin-left: 0px">
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
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Fecha Final:</td>
                    <td>
                            <asp:DropDownList ID="DropDownList15" runat="server" style="margin-left: 0px">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList16" runat="server" Width="150px" style="margin-left: 0px">
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
                            <asp:DropDownList ID="DropDownList17" runat="server" style="margin-left: 0px">
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
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Panel ID="Panel6" runat="server" Height="600px" ScrollBars="Both" 
                            Width="100%">
                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" ShowFooter="True" style="font-size: small">
                                <Columns>
                                    <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                    <asp:BoundField DataField="fechaEncFacturaPro" 
                            DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                    <asp:BoundField DataField="afiliado" HeaderText="Nombres" />
                                    <asp:BoundField DataField="puntosencfacturapro" 
                            DataFormatString="{0:N2}" HeaderText="Puntos">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorCoEncFacturaPro" 
                            HeaderText="Valor USD">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valormlencfacturapro" HeaderText="Valor ML">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
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
                                    <asp:BoundField DataField="nombreempresa" HeaderText="Empresa" />
                                    <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                    <asp:BoundField DataField="nombretipopaquete" HeaderText="Tipo Factura" />
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

