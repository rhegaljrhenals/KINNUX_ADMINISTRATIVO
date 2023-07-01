<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfDespachos.aspx.vb" Inherits="Bodega_Principal_wfDespachos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style14
        {
            color: #000066;
        }
        .style17
        {
            width: 100%;
        }
        .style18
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

                                    <asp:ImageButton runat="server" 
                    ImageUrl="~/Imagenes/buscar.png" Height="40px" ToolTip="Buscar pedido" 
                    Width="40px" ID="ImageButton17"></asp:ImageButton>

                <br />
              </td>
            <td width="5%" align="center">
                &nbsp;</td>
                          <td width="90%">Despachos</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style17">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView2" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                            <tr>
                                <td>
                                    <table class="style17">
                                        <tr>
                                            <td class="style18">
                                                Id Pedido:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server" style="text-align: right" 
                                                    Width="80px"></asp:TextBox>
                                                <asp:ImageButton ID="ImageButton9" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar pedido" Width="30px" />
                                                <asp:Label ID="Label2" runat="server" 
                                                    style="color: #FF0000; font-size: x-small"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style18">
                                                Fecha Pedido:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox6" runat="server" Height="22px" ReadOnly="True"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style18">
                                                Empresa(Pais):</td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Panel ID="Panel11" runat="server" Height="192px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: small" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                <asp:BoundField DataField="nombreproducto" HeaderText="Nombres Producto" />
                                                <asp:BoundField DataField="cantDetPedProductoBod" HeaderText="Cantidad">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorDetPedProductoBod" HeaderText="Valor">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="subtotalDetPedProductoBod" HeaderText="Subtotal">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="cantEntregaDetPedProductoBod" 
                                                    HeaderText="Cantidad Despachada">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="resta" HeaderText="Cantidad Faltante">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Existencias" HeaderText="Existencias En Bodega">
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
                            <tr>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Total Cantidad:</td>
                                <td>
                                    <asp:TextBox ID="TextBox12" runat="server" CssClass="style23" ReadOnly="True" 
                                        style="text-align: right"></asp:TextBox>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Subtotal:</td>
                                <td>
                                    <asp:TextBox ID="TextBox13" runat="server" CssClass="style23" ReadOnly="True" 
                                        style="text-align: right"></asp:TextBox>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <table class="style17">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                                    <tr>
                                                        <td class="style14">
                                                            Fecha Despacho:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox14" runat="server" Enabled="False"></asp:TextBox>
                                                            <asp:CalendarExtender ID="TextBox14_CalendarExtender" runat="server" 
                                                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton10" 
                                                                TargetControlID="TextBox14">
                                                            </asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" 
                                                                ImageUrl="~/Imagenes/calendario.png" />
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style14">
                                                            Número De Guia:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style14">
                                                            Dirección De Envío:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox19" runat="server" Width="250px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style14" colspan="4">
                                                            <table class="style17">
                                                                <tr>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="center" 
                                                                        style="color: #FFFFFF; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699">
                                                                        Detalle Del Despacho</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" 
                                                                        style="color: #FFFFFF; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #CCCCCC">
                                                                        <asp:ImageButton ID="ImageButton11" runat="server" Height="40px" 
                                                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />
                                                                        <asp:ImageButton ID="ImageButton13" runat="server" Height="40px" 
                                                                            ImageUrl="~/Imagenes/verif.png" ToolTip="Verificar Despacho" Width="40px" />
                                                                        <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" 
                                                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Despacho" Width="40px" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" 
                                                                        style="color: #FFFFFF; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #FFFFFF">
                                                                        <asp:Panel ID="panelError" runat="server" BorderColor="Red" 
                                                                            BorderStyle="Groove" BorderWidth="1px" Height="120px">
                                                                            <asp:Image ID="Image2" runat="server" Height="30px" 
                                                                                ImageUrl="~/Imagenes/Error 2.png" />
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
                                                                    <td>
                                                                        <asp:Panel ID="Panel13" runat="server" BackColor="#FFFFCC" 
                                                                            DefaultButton="ImageButton14" Height="57px">
                                                                            <table cellpadding="0" cellspacing="0" class="style1" style="width: 650px">
                                                                                <tr>
                                                                                    <td>
                                                                                        Productos<asp:Label ID="Label17" runat="server" style="color: #FF0000" 
                                                                                            ToolTip="Debe Seleccionar El Producto">*</asp:Label>
                                                                                    </td>
                                                                                    <td align="center">
                                                                                        Cajas<asp:Label ID="Label18" runat="server" style="color: #FF0000" 
                                                                                            ToolTip="Valor Invalido">*</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        Unidades x Cajas<asp:Label ID="Label19" runat="server" style="color: #FF0000" 
                                                                                            ToolTip="Valor Invalido">*</asp:Label>
                                                                                    </td>
                                                                                    <td align="center" rowspan="3">
                                                                                        <asp:ImageButton ID="ImageButton16" runat="server" Height="30px" 
                                                                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="30px" />
                                                                                        <asp:ImageButton ID="ImageButton14" runat="server" Height="30px" 
                                                                                            ImageUrl="~/Imagenes/Check Mark.png" ToolTip="Agregar Item" Width="30px" />
                                                                                        <asp:ImageButton ID="ImageButton15" runat="server" Height="30px" 
                                                                                            ImageUrl="~/Imagenes/xkill.png" ToolTip="Eliminar Item" Width="30px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:DropDownList ID="DropDownList3" runat="server" Width="300px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td align="center">
                                                                                        <asp:TextBox ID="TextBox27" runat="server" style="text-align: right" 
                                                                                            Width="80px"></asp:TextBox>
                                                                                        <asp:FilteredTextBoxExtender ID="TextBox27_FilteredTextBoxExtender" 
                                                                                            runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox27">
                                                                                        </asp:FilteredTextBoxExtender>
                                                                                    </td>
                                                                                    <td align="center">
                                                                                        <asp:TextBox ID="TextBox28" runat="server" style="text-align: right" 
                                                                                            Width="80px"></asp:TextBox>
                                                                                        <asp:FilteredTextBoxExtender ID="TextBox28_FilteredTextBoxExtender" 
                                                                                            runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox28">
                                                                                        </asp:FilteredTextBoxExtender>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td colspan="3">
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </table>
                                                                        </asp:Panel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Panel ID="Panel16" runat="server" Height="300px" ScrollBars="Vertical">
                                                                            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                CellPadding="3" style="font-size: small" Width="100%">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="Numero" HeaderText="#" />
                                                                                    <asp:BoundField DataField="idproducto" HeaderText="Id" />
                                                                                    <asp:BoundField DataField="nombreProducto" HeaderText="Productos" />
                                                                                    <asp:BoundField DataField="cajas" HeaderText="Cajas">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:BoundField>
                                                                                    <asp:BoundField DataField="unidades" HeaderText="Unidades x Cajas">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:BoundField>
                                                                                    <asp:BoundField DataField="tc" HeaderText="Total Cantidad">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:BoundField>
                                                                                    <asp:BoundField DataField="precio" HeaderText="Precio">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:BoundField>
                                                                                    <asp:BoundField DataField="subtotal" HeaderText="Subtotal">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:BoundField>
                                                                                    <asp:CommandField HeaderText="Seleccione" SelectText="Seleccione" 
                                                                                        ShowSelectButton="True">
                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                    </asp:CommandField>
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
                                                        <td class="style14" colspan="4">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style14" colspan="4">
                                                            Total Cantidad:<asp:TextBox ID="TextBox29" runat="server" ReadOnly="True" 
                                                                style="text-align: right"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox30" runat="server" Width="0px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table class="style17">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Width="100%" ScrollBars="Vertical" Height="500px">
                                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" style="font-size: small" Width="100%">
                                        <Columns>
                                            <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                            <asp:BoundField DataField="idEncPedProductoBod" HeaderText="Id Pedido" />
                                            <asp:BoundField DataField="fechaEncPedProductoBod" 
                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                            <asp:BoundField DataField="idEmpresa" HeaderText="Id Empresa" />
                                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                            <asp:BoundField DataField="procesadoEncPedProductoBod" HeaderText="Procesado" />
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
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
    </table>
</asp:Content>

