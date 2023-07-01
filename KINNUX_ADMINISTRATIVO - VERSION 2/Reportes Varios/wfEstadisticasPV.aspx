<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfEstadisticasPV.aspx.vb" Inherits="Reportes_Varios_wfReporteProductosFacturados" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style4
        {
            width: 100%;
        }
        .style5
        {
            color: #000066;
        }
        
        .estiloCabecerasMeses
        {
                    align="center"; 
                    colspan="2";
                    color: #FFFFFF; 
                    font-size: medium; 
                    font-weight: 700; 
                    font-family: 'Courier New', Courier, monospace; 
                    background-color: #009999
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
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            &nbsp;</td>

      <td>
      
            &nbsp;</td>

            <td width="90%">Estadisticas PV</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style4">
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label5" runat="server" 
                    style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style5">
                Seleccione Año:
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
                </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style5" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style5" colspan="2">
                <asp:Panel ID="Panel13" runat="server" Height="350px">
                    <table class="style4">
                        <tr>
                            <td align="left" colspan="2" class="estiloCabecerasMeses">
                                Puntos Anuales</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView36" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" 
                                    BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="mes" HeaderText="Meses" />
                                        <asp:BoundField DataField="cantidad" HeaderText="Total Puntos" 
                                            DataFormatString="{0:N0}">
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
                                <br />
                            </td>
                            <td valign="top">
                                <asp:Chart ID="Chart17" runat="server" Palette="SeaGreen" Width="0px" 
                                    EnableViewState="True">
                                    <series>
                                        <asp:Series Name="Series1">
                                        </asp:Series>
                                    </series>
                                    <chartareas>
                                        <asp:ChartArea Name="ChartArea1">
                                        </asp:ChartArea>
                                    </chartareas>
                                </asp:Chart>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5" colspan="2">
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
                <asp:Panel ID="Panel11" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                    BorderWidth="1px" Height="650px">
                    <table class="style4">
                        <tr>
                            <td class="estiloCabecerasMeses" colspan="8">
                                Puntos Por Empresa(Paises)</td>
                        </tr>
                        <tr>
                            <td colspan="8">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="estiloCabecerasMeses">
                                Enero</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Febrero</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Marzo</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Abril</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView12" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView13" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView14" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView15" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
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
                            <td class="estiloCabecerasMeses">
                                Mayo</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Junio</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Julio</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Agosto</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView16" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView17" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView18" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView19" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="estiloCabecerasMeses">
                                Septiembre</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Octubre</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Noviembre</td>
                            <td>
                                &nbsp;</td>
                            <td class="estiloCabecerasMeses">
                                Diciembre</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView20" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView21" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView22" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                            <td valign="top">
                                <asp:GridView ID="GridView23" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                        <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel12" runat="server" Height="500px" BorderColor="#CCCCCC" 
                    BorderStyle="Solid" BorderWidth="1px">
                    <table class="style4">
                        <tr>
                            <td class="estiloCabecerasMeses">
                                Puntos Por Sucursales</td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Button ID="Button2" runat="server" Text="Enero" Width="100px" />
                                <asp:Button ID="Button3" runat="server" Text="Febrero" Width="100px" />
                                <asp:Button ID="Button4" runat="server" Text="Marzo" Width="100px" />
                                <asp:Button ID="Button5" runat="server" Text="Abril" Width="100px" />
                                <asp:Button ID="Button6" runat="server" Text="Mayo" Width="100px" />
                                <asp:Button ID="Button7" runat="server" Text="Junio" Width="100px" />
                                <br />
                                <asp:Button ID="Button8" runat="server" Text="Julio" Width="100px" />
                                <asp:Button ID="Button9" runat="server" Text="Agosto" Width="100px" />
                                <asp:Button ID="Button10" runat="server" Text="Septiembre" Width="100px" />
                                <asp:Button ID="Button11" runat="server" Text="Octubre" Width="100px" />
                                <asp:Button ID="Button12" runat="server" Text="Noviembre" Width="100px" />
                                <asp:Button ID="Button13" runat="server" Text="Diciembre" Width="100px" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table class="style4">
                        <tr>
                            <td>
                                <asp:MultiView ID="MultiView1" runat="server">
                                    <asp:View ID="View1" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td align="left" colspan="2" class="estiloCabecerasMeses">
                                                    Enero</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView24" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart5" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View2" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Febrero</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView25" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart6" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View3" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Marzo</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView26" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart7" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View4" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Abril</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView27" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart8" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View5" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Mayo</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView28" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart9" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View6" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Junio</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView29" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart10" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View7" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Julio</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView30" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart11" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View8" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Agosto</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView31" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart12" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View9" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Septiembre</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView32" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart13" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View10" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Octubre</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView33" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart14" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View11" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Noviembre</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView34" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart15" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <asp:View ID="View12" runat="server">
                                        <table class="style4">
                                            <tr>
                                                <td class="estiloCabecerasMeses" colspan="2">
                                                    Diciembre</td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                    <asp:GridView ID="GridView35" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="puntos" HeaderText="Total Puntos">
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
                                                    <asp:Chart ID="Chart16" runat="server" Palette="SeaGreen" Width="800px" 
                                                        EnableViewState="True">
                                                        <series>
                                                            <asp:Series Name="Series1">
                                                            </asp:Series>
                                                        </series>
                                                        <chartareas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                            </asp:ChartArea>
                                                        </chartareas>
                                                    </asp:Chart>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </asp:View>
                                    <br />
                                </asp:MultiView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="1px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <br />
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
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

