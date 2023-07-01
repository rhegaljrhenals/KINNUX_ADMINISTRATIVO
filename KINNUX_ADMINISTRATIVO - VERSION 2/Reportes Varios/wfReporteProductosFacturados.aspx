<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteProductosFacturados.aspx.vb" Inherits="Reportes_Varios_wfReporteProductosFacturados" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">

        .style4
        {
            width: 100%;
        }
        .style6
        {
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
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
      
      </td>

      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton6"></asp:ImageButton>
      
      </td>

            <td width="90%">Productos Facturados</td>
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
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style4">
                    <tr>
                        <td class="style6">
                            Fecha Inicial:</td>
                        <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                    TargetControlID="TextBox1">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton4" runat="server" Height="22px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="22px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            Fecha Final:</td>
                        <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton5" 
                    TargetControlID="TextBox2">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton5" runat="server" Height="22px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="22px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            Empresas:</td>
                        <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    Width="200px">
                </asp:DropDownList>
                        &nbsp;Sucursales:
                <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6" colspan="3">
                            <table class="style4">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="Panel2" runat="server" Width="100%" Height="400px" ScrollBars="Both">

                
                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3">
                    <Columns>
                        <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                        <asp:BoundField DataField="idproducto" HeaderText="Referencia" />
                        <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                        <asp:BoundField DataField="base" HeaderText="Base">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="promocion" HeaderText="Promocion">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="basepro" HeaderText="Base + Promocion">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="obsequuio" HeaderText="Obsequio">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="total" HeaderText="Total Factura">
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
                                    <td valign="top">
                                        <%--<div style="padding:5px;border:1px solid gray;border-radius:5px">
                                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>     
                                        </div>--%>
                                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" ShowFooter="True" Width="70%">
                        <Columns>
                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Right" 
                            Font-Bold="True" />
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
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        
        
    </table>
</asp:Content>

