<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPreciosPaginasPersonales.aspx.vb" Inherits="Basicos_wfPreciosPaginasPersonales" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
        }
        .style16
        {
            color: #000066;
        }
        .style19
        {
            height: 13px;
        }
        .style20
        {
            width: 100%;
        }
        .style21
        {
            color: #006699;
        }
        .auto-style5 {
            height: 27px;
        }
        .auto-style6 {
            color: #006699;
            width: 158px;
            height: 27px;
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
                                        ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />

              </td>
          <td width="5%" align="center">
                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="40px" />

              </td>
          <td width="5%" align="center">

                                                    &nbsp;</td>
                          <td width="90%">Precios Productos Páginas Personales</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="2" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td class="style14">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14" align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                            <tr>
                                <td colspan="2">
                                    <table class="style20">
                                        <tr>
                                            <td class="auto-style6">
                                                Nombre Producto:</td>
                                            <td class="auto-style5">
                                                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                                    Width="450px"></asp:TextBox>
                                                <asp:Label ID="Label17" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">Precio Colombia:</td>
                                            <td class="auto-style5">
                                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox8_FilteredTextBoxExtender" runat="server" BehaviorID="TextBox8_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="TextBox8" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">Precio Bolivia:</td>
                                            <td class="auto-style5">
                                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox9_FilteredTextBoxExtender" runat="server" BehaviorID="TextBox9_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="TextBox9" />
                                                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Visible="False" Width="50px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Panel ID="Panel4" runat="server" Height="600px" ScrollBars="Vertical">
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%">
                                                        <Columns>
                                                            <asp:CommandField ButtonType="Button" SelectText="Ver Detalle" ShowSelectButton="True">
                                                            <ControlStyle CssClass="botones" />
                                                            <ItemStyle HorizontalAlign="Center" />
                                                            </asp:CommandField>
                                                            <asp:BoundField DataField="idproducto" HeaderText="Id Producto" />
                                                            <asp:BoundField DataField="nombre" HeaderText="Nombre Producto" />
                                                            <asp:BoundField DataField="preciocop" DataFormatString="{0:N0}" HeaderText="Precio Colombia" NullDisplayText="0">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="preciousd" DataFormatString="{0:N0}" HeaderText="Precio Bolivia" NullDisplayText="0">
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
                    </asp:View>
                </asp:MultiView>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                                                                    &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

