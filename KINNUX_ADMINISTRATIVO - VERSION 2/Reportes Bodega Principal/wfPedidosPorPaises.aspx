<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPedidosPorPaises.aspx.vb" Inherits="Reportes_wfPedidos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
        .style5
        {
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
                <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                    ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar" Width="40px" />
              </td>
            <td width="5%" align="center">

                <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                    ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                    Width="40px" />

                <br />
              </td>
                          <td width="90%">Reportes De Pedidos Por Paises</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style2" style="width: 100%">
        <tr>
            <td>
                                <asp:Label ID="Label5" runat="server" style="color: #000066"></asp:Label>
                            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                                <table class="style4">
                                    <tr>
                                        <td class="style5">
                                            Fecha Inicial:</td>
                                        <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                                        Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton9" 
                                        TargetControlID="TextBox1">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton9" runat="server" Height="30px" 
                                        ImageUrl="~/images/calendario_imagen.png" ToolTip="Buscar" 
                    Width="30px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            Fecha Final:</td>
                                        <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                        Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton10" 
                                        TargetControlID="TextBox2">
                                    </asp:CalendarExtender>
                                    <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" 
                                        ImageUrl="~/images/calendario_imagen.png" ToolTip="Buscar" 
                    Width="30px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            Empresa(Pais):</td>
                                        <td>
                                            <asp:DropDownList ID="DropDownList1" runat="server" Width="350px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                        Text="Confirmados" />
                                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                        Text="No Confirmados" />
                                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                        Text="En Procesos" />
                                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                                        Text="Anulados" />
                                            <asp:RadioButton ID="RadioButton7" runat="server" GroupName="1" 
                                        Text="Activos" />
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
            <td align="left" colspan="2">
                <asp:Panel ID="Panel5" runat="server">
                    <table class="style4">
                        <tr>
                            <td align="center" 
                                style="font-family: 'Courier New', Courier, monospace; color: #FFFFFF; background-color: #009999">
                                Encabezado Pedidos</td>
                            <td align="center" 
                                style="font-family: 'Courier New', Courier, monospace; color: #FFFFFF; background-color: #009999">
                                Detalle Pedidos</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Panel4" runat="server" Height="600px" ScrollBars="Both" 
                                    Width="600px">
                                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" 
                                        style="font-size: small; font-family: 'Courier New', Courier, monospace;">
                                        <Columns>
                                            <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                            <asp:BoundField DataField="idEncPedProductoBod" HeaderText="Id Pedido" />
                                            <asp:BoundField DataField="fechaEncPedProductoBod" 
                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                            <asp:BoundField DataField="idEmpresa" HeaderText="Id Empresa" />
                                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                            <asp:BoundField DataField="confirEncPedProductoBod" HeaderText="Confirmado" />
                                            <asp:BoundField DataField="estadoEncPedProductoBod" HeaderText="Estado" />
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
                                <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="idEncPedProductoBod" HeaderText="Pedido #" />
                                        <asp:BoundField DataField="nombreProducto" HeaderText="Productos" />
                                        <asp:BoundField DataField="cantDetPedProductoBod" HeaderText="Cantidad Pedida">
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cantEntregaDetPedProductoBod" 
                                            HeaderText="Cantidad Entrega">
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="valorDetPedProductoBod" HeaderText="Valor">
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="subtotalDetPedProductoBod" HeaderText="Subtotal">
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
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style4">
                    <tr>
                        <td style="width: 600px">
                            &nbsp;</td>
                        <td style="width: 10px" valign="top">
                            &nbsp;</td>
                        <td valign="top">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td colspan="2">
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
</asp:Content>

