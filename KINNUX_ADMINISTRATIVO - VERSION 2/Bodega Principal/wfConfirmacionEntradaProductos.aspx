<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConfirmacionEntradaProductos.aspx.vb" Inherits="Bodega_Principal_wfConfirmacionEntradaProductos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style13
        {
            font-family: "Courier New", Courier, monospace;
            font-weight: bold;
            color: #0000FF;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
            height: 35px;
            width: 38px;
        }
            
        .style17
        {
            color: #0000FF;
            font-weight: bold;
        }
        .style18
        {
            height: 16px;
        }
        .style19
        {
            width: 100%;
        }
        .style21
        {
            font-family: "Courier New", Courier, monospace;
            color: #005FAE;
        }
        .auto-style2 {
            width: 10px;
        }
        .auto-style4 {
            height: 18px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            width: 95px;
        }
        .auto-style7 {
            height: 18px;
            width: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/rayo.png" Height="40px" 
                    ToolTip="Detalle Entrada" Width="40px" ID="ImageButton16"></asp:ImageButton>
              </td>
            <td width="5%" align="center">
                <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" Height="40px" 
                    ToolTip="Consultar Entradas" Width="40px" ID="ImageButton17">
                </asp:ImageButton>
                                </td>
            <td width="5%" align="center">

                                    


                                    &nbsp;</td>
                          <td width="90%">Confirmar Entradas</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style19">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView3" runat="server">
                    <asp:View ID="View4" runat="server">
                        <table class="style19">
                            <tr>
                                <td class="auto-style6">Id Entrada:</td>
                                <td>
                                    <asp:Label ID="Label18" runat="server" BackColor="#CCCCCC" Width="100px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Fecha:</td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" Width="100px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Proveedor:</td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" BackColor="#CCCCCC" Width="70px"></asp:Label>
                                    <asp:Label ID="Label9" runat="server" BackColor="#CCCCCC" Width="250px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Valor:</td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" BackColor="#CCCCCC" style="text-align: right" Width="150px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Numero Guia:</td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" BackColor="#CCCCCC" Width="200px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Procesado:</td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" BackColor="#CCCCCC" Width="100px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Confirmado:</td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" BackColor="#CCCCCC" Width="100px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style4" colspan="2">
                                    <table class="style19">
                                        <tr>
                                            <td valign="top">
                                                <asp:Panel ID="Panel2" runat="server" Height="300px" ScrollBars="Vertical">
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="font-size: small" Width="100%">
                                                        <Columns>
                                                            <asp:BoundField DataField="idDetEntProductoBod" HeaderText="#" />
                                                            <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Nombres Productos" />
                                                            <asp:BoundField DataField="ncajasDetEntproductoBod" HeaderText="N° Cajas">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="cantDetEntProductoBod" HeaderText="Unidades x Cajas">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="valorDetEntProductoBod" HeaderText="Valor">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="subtotalDetEntProductoBod" HeaderText="Subtotal">
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
                                            <td>&nbsp;</td>
                                            <td>
                                                <asp:Panel ID="Panel4" runat="server" Height="300px" ScrollBars="Vertical">
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="font-size: small" Width="100%">
                                                        <Columns>
                                                            <asp:BoundField DataField="idCajaEntProductoBod" HeaderText="#" />
                                                            <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Nombres Productos" />
                                                            <asp:BoundField DataField="conseCajaEntProductoBod" HeaderText="N° Caja" />
                                                            <asp:BoundField DataField="cantCajaEntProductoBod" HeaderText="Unidad x Caja">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Cant Recibida">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox2" runat="server" style="text-align: right" Width="50px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox2" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Cant. Faltante">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox3" runat="server" style="text-align: right" Width="50px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox3" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Cant. Mal Estado">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox4" runat="server" style="text-align: right" Width="50px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox4_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox4" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Confirmar">
                                                                <ItemTemplate>
                                                                    <asp:CheckBox ID="CheckBox1" runat="server" />
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
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            
                        </table>
                        <br />



                        <table class="style19">
                            
                            <tr>
                                <td bgcolor="#CCCCCC" colspan="4">
                                    <asp:ImageButton ID="ImageButton15" runat="server" Height="50px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Entrada" Width="50px" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Panel ID="panelError" runat="server" BorderColor="Red" 
                                        BorderStyle="Groove" BorderWidth="1px" Height="120px">
                                        <img alt="" class="style13" src="../Imagenes/xkill.png" />
                                        <asp:Label ID="Label14" runat="server" style="color: #FF0000">Errores Encontrados</asp:Label>
                                        <br />
                                        <asp:Label ID="Label15" runat="server" style="color: #FF0000"></asp:Label>
                                        <br />
                                        <br />
                                        <br />
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        <br />
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <table class="style19">
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                        <tr>
                                            <td class="style18">
                                                <asp:Label ID="Label17" runat="server" 
                                                    style="color: #0000FF; font-size: small; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style18">
                                                <asp:Panel ID="Panel6" runat="server" Height="400px" ScrollBars="Vertical">
                                                    <table class="style19" style="width: 100%">
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small" Width="100%">
                                                                    <Columns>
                                                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                                                        <asp:BoundField DataField="idEncEntProductoBod" HeaderText="Id Entrada" />
                                                                        <asp:BoundField DataField="fechaEncEntProductoBod" 
                                                                            DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                                        <asp:BoundField DataField="idProveedor" HeaderText="Id Proveedor" />
                                                                        <asp:BoundField DataField="nombreProveedor" HeaderText="Nombre Proveedor" />
                                                                        <asp:BoundField DataField="valorEncProductoBod" HeaderText="Valor">
                                                                        <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="guiaEncEntProductoBod" HeaderText="# Guia" />
                                                                        <asp:BoundField DataField="procesaEncEntProductoBod" HeaderText="Procesado" />
                                                                        <asp:BoundField DataField="confirEncEntProductoBod" HeaderText="Confirmado" />
                                                                        <asp:BoundField DataField="estadoEncEntProductoBod" HeaderText="Estado" />
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
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
    </table>
</asp:Content>

