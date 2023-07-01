<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfProductosFacturadosPorUsuarios.aspx.vb" Inherits="Reportes_Varios_wfReporteProductosFacturados" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

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
                Width="40px" ID="ImageButton6" Visible="False"></asp:ImageButton>
      
      </td>

            <td width="90%">Productos Facturados Por Usuarios</td>
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
                Usuarios:</td>
            <td align="left">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
                </asp:DropDownList>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="675px" ScrollBars="Vertical">
                    <table cellpadding="0" cellspacing="0" class="style4">
                        <tr>
                            <td align="center" 
                                
                                style="font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #CCCCCC">
                                <asp:Label ID="Label4" runat="server" style="color: #000000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
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
                        <FooterStyle BackColor="#339933" ForeColor="White" HorizontalAlign="Right" />
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

