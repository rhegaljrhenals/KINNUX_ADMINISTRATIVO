<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfProducto.aspx.vb" Inherits="Basicos_wfProducto" %>

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
    .auto-style2 {
        color: #006699;
        width: 121px;
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

                                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Consultar" 
                    Width="40px" ID="ImageButton11"></asp:ImageButton>

              </td>
                          <td width="90%">Productos</td>
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
                                            <td class="auto-style2">
                                                Id:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox7" style="margin-left: 0px" runat="server" ReadOnly="True" Width="50px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">Nombre Producto:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="250px" CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label17" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Puntos:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" CssClass="campver"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox2">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label18" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">Token:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox14" runat="server" style="margin-left: 0px" CssClass="campver"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox14_FilteredTextBoxExtender" runat="server" BehaviorID="TextBox14_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="TextBox14" />
                                                <asp:Label ID="Label23" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Linea Producto:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList24" runat="server" Width="250px" style="margin-left: 0px" CssClass="campver">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label19" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Panel ID="Panel4" runat="server" Height="600px" ScrollBars="Vertical">
                                                    <asp:Label ID="Label20" runat="server" style="color: #FF0000"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="Label21" runat="server" style="color: #FF0000"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="Label22" runat="server" style="color: #FF0000"></asp:Label>
                                                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" style="font-size: small" Width="100%">
                                                        <Columns>
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="codigopais" HeaderText="Id Pais" />
                                                            <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                                                            <asp:TemplateField HeaderText="Precio Pais">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox9" runat="server" style="text-align: right" 
                                                                        Width="100px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox9_FilteredTextBoxExtender" 
                                                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox9">
                                                                    </asp:FilteredTextBoxExtender>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Right" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Precio Local">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox10" runat="server" style="text-align: right" 
                                                                        Width="100px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox10_FilteredTextBoxExtender" 
                                                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox10">
                                                                    </asp:FilteredTextBoxExtender>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Precio Personalizado">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox12" runat="server" style="text-align: right" 
                                                                        Width="100px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox12_FilteredTextBoxExtender" 
                                                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox12">
                                                                    </asp:FilteredTextBoxExtender>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Right" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Precio Elite">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox13" runat="server" style="text-align: right"></asp:TextBox>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Stock">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox11" runat="server" style="text-align: right" 
                                                                        Width="80px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox11_FilteredTextBoxExtender" 
                                                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox11">
                                                                    </asp:FilteredTextBoxExtender>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
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
                    <asp:View ID="View2" runat="server">
                        <asp:Panel ID="Panel3" runat="server" Height="600px" ScrollBars="Vertical">
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" style="font-size: small" Width="100%">
                                <Columns>
                                    <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" ButtonType="Button">
                                    <ControlStyle CssClass="botones" />
                                    <ItemStyle Width="100px" />
                                    </asp:CommandField>
                                    <asp:BoundField DataField="idProducto" HeaderText="Id">
                                    <ItemStyle Width="100px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nombreProducto" HeaderText="Nombre Producto" />
                                    <asp:BoundField DataField="puntosproducto" HeaderText="Puntos" />
                                    <asp:BoundField DataField="idlinea" HeaderText="Linea" />
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

