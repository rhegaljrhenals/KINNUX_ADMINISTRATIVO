<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfEstadisticasGenerales.aspx.vb" Inherits="Reportes_Varios_wfReporteProductosFacturados" %>

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
    .style7
    {
        background-color: #006699;
    }
    .style8
    {
        font-family: "Courier New", Courier, monospace;
        font-weight: bold;
        font-size: small;
        color: #FFFFFF;
        background-color: #006699;
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
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton6"></asp:ImageButton>
      
      </td>

            <td width="90%">Estadisticas Generales</td>
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
                Fecha Inicial:</td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                    TargetControlID="TextBox1">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton4" runat="server" Height="30px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="30px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style5">
                Fecha Final:</td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton5" 
                    TargetControlID="TextBox2">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton5" runat="server" Height="30px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="30px" />
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
                Empresas:</td>
            <td align="left">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    Width="350px">
                </asp:DropDownList>
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                    Text="Incluir Sucursales" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style5" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table cellpadding="0" cellspacing="0" class="style4">
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Sucursales:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Panel ID="Panel2" runat="server">
                                        <asp:DropDownList ID="DropDownList2" runat="server" Width="350px">
                                        </asp:DropDownList>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5">
                &nbsp;</td>
            <td align="left">
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
                <asp:Panel ID="Panel3" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                    BorderWidth="1px" Height="377px">
                    <table cellpadding="0" cellspacing="0" class="style4">
                        <tr>
                            <td class="style7">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" 
                                    ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                    Width="40px" />
                            </td>
                            <td class="style7">
                                &nbsp;</td>
                            <td class="style8">
                                Productos Facturados</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:Panel ID="Panel7" runat="server" Height="300px" ScrollBars="Vertical">
                                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" Width="100%">
                                        <Columns>
                                            <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" 
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
                                </asp:Panel>
                                <br />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td align="right" valign="top" widht=384>
                                <asp:Chart ID="Chart1" runat="server" Palette="Excel" Width="600px">
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
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
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
            <td align="left" valign="top" colspan="2">
                <asp:Panel ID="Panel4" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                    BorderWidth="1px" Height="377px">
                    <table cellpadding="0" cellspacing="0" class="style4">
                        <tr>
                            <td class="style7">
                                <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                                    ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                    Width="40px" />
                            </td>
                            <td class="style7">
                                &nbsp;</td>
                            <td class="style8">
                                Tipos De Facturación</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" Width="100%">
                                    <Columns>
                                        <asp:BoundField DataField="tipoencfacturapro" HeaderText="Tipo De Factura" />
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
                            <td>
                                &nbsp;</td>
                            <td align="right" valign="top">
                                <asp:Chart ID="Chart2" runat="server" Palette="Excel" Width="384px">
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
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
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
                <asp:Panel ID="Panel5" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                    BorderWidth="1px" Height="399px">
                    <table cellpadding="0" cellspacing="0" class="style4">
                        <tr>
                            <td class="style7">
                                <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                                    ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                    Width="40px" />
                            </td>
                            <td class="style7">
                                &nbsp;</td>
                            <td class="style8">
                                Paquetes Facturados</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:Panel ID="Panel6" runat="server" Height="323px" ScrollBars="Vertical">
                                    <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" Width="100%">
                                        <Columns>
                                            <asp:BoundField DataField="nombrePaquete" HeaderText="Paquetes" />
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
                                </asp:Panel>
                                <br />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td align="right" valign="top">
                                <asp:Chart ID="Chart3" runat="server" Palette="Excel" Width="384px">
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
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
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
            <td align="center" colspan="2">
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

