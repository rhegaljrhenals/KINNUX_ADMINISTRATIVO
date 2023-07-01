<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfpaginasPersonales.aspx.vb" Inherits="Reportes_Varios_wfpaginasPersonales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
                          &nbsp;</td>
      <td>
      
            &nbsp;</td>

            <td width="90%">Páginas Personales</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Button ID="Button1" runat="server" Height="30px" 
                    style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339933" 
                    Text="Contactos" Width="150px" />
                <asp:Button ID="Button2" runat="server" Height="30px" 
                    style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339933" 
                    Text="Pedidos" Width="150px" />
                <asp:Button ID="Button3" runat="server" Height="30px" 
                    style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339933" 
                    Text="Testimonios" Width="150px" />
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table class="style1" style="border: thin solid #C0C0C0">
                            <tr>
                                <td colspan="2" style="background-color: #CCCCCC">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Consultar" Width="40px" />
                                </td>
                                <td colspan="2" style="background-color: #CCCCCC">
                                    <asp:Label ID="Label11" runat="server" 
                                        style="color: #000080; font-size: x-large; font-weight: 700; font-family: 'Courier New', Courier, monospace" 
                                        Text="Contactos"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="Label4" runat="server" 
                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                                        GroupName="1" Text="Por Codigo" />
                                </td>
                                <td colspan="2">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                                        GroupName="1" Text="Todos Los Registros" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Panel ID="Panel1" runat="server" Height="500px" ScrollBars="Both">
                                        <table class="style1">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" 
                                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
                                                            <asp:BoundField DataField="nombreContacto" HeaderText="Contacto" />
                                                            <asp:BoundField DataField="mailContacto" HeaderText="Email Contacto" />
                                                            <asp:BoundField DataField="paisContacto" HeaderText="Pais Contacto" />
                                                            <asp:BoundField DataField="mensajeContacto" HeaderText="Mensaje" />
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
                                        <br />
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table class="style1" style="border: thin solid #C0C0C0">
                            <tr>
                                <td colspan="4" style="background-color: #CCCCCC">
                                    <asp:ImageButton ID="ImageButton3" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Consultar" Width="40px" />
                                </td>
                                <td colspan="2" style="background-color: #CCCCCC">
                                    <asp:Label ID="Label17" runat="server" 
                                        style="color: #000080; font-size: x-large; font-weight: 700; font-family: 'Courier New', Courier, monospace" 
                                        Text="Pedidos"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <asp:Label ID="Label18" runat="server" 
                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton6" runat="server" AutoPostBack="True" 
                                        GroupName="1" Text="Por Codigo" />
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                                <td colspan="3">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    <asp:RadioButton ID="RadioButton7" runat="server" AutoPostBack="True" 
                                        GroupName="1" Text="Todos Los Pedidos" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Panel ID="Panel4" runat="server" Height="300px" ScrollBars="Both" 
                                        Width="500px">
                                        <table class="style1">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label19" runat="server" 
                                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="id" HeaderText="Id" />
                                                            <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
                                                            <asp:BoundField DataField="nombreContacto" HeaderText="Contacto" />
                                                            <asp:BoundField DataField="mailEncPedidoWeb" HeaderText="Email Contacto" />
                                                            <asp:BoundField DataField="direccionEncPedidoWeb" HeaderText="Direccion" />
                                                            <asp:BoundField DataField="telefonoEncPedidoWeb" HeaderText="Telefono" />
                                                            <asp:BoundField DataField="paisEncPedidoWeb" HeaderText="Pais" />
                                                            <asp:BoundField DataField="dptoEncPedidoWeb" HeaderText="Ciudad" />
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
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td colspan="2" style="width: 100px">
                                    &nbsp;</td>
                                <td valign="top">
                                    <asp:Panel ID="Panel5" runat="server" Height="300px" ScrollBars="Both" 
                                        Width="500px">
                                        <table class="style1">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label20" runat="server" 
                                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" Width="100%">
                                                        <Columns>
                                                            <asp:BoundField DataField="nombreproducto" HeaderText="Producto" />
                                                            <asp:BoundField DataField="cantidadproducto" HeaderText="Cantidad" />
                                                            <asp:BoundField DataField="precio" HeaderText="Precio" />
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
                                        <br />
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <table class="style1" style="border: thin solid #C0C0C0">
                            <tr>
                                <td style="background-color: #CCCCCC">
                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Consultar" Width="40px" />
                                </td>
                                <td colspan="2" style="background-color: #CCCCCC">
                                    <asp:Label ID="Label12" runat="server" 
                                        style="color: #000080; font-size: x-large; font-weight: 700; font-family: 'Courier New', Courier, monospace" 
                                        Text="Testimonios"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Label ID="Label6" runat="server" 
                                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2" colspan="2">
                                    <asp:RadioButton ID="RadioButton8" runat="server" GroupName="1" 
                                        Text="Activos" />
                                    <asp:RadioButton ID="RadioButton9" runat="server" GroupName="1" 
                                        Text="Pendientes" />
                                    <asp:RadioButton ID="RadioButton10" runat="server" GroupName="1" 
                                        Text="Rechazados" />
                                    <asp:RadioButton ID="RadioButton11" runat="server" GroupName="1" Text="Todos" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <table class="style1">
                                        <tr>
                                            <td valign="top">
                                                <asp:Panel ID="Panel2" runat="server" Height="301px" ScrollBars="Both" 
                                                    Width="500px">
                                                    <table class="style1">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label7" runat="server" 
                                                                    style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3">
                                                                    <Columns>
                                                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                                                        <asp:BoundField DataField="idtestimonio" HeaderText="Id" />
                                                                        <asp:BoundField DataField="cuerpoTestimonio" HeaderText="Testimonio" />
                                                                        <asp:BoundField DataField="nombreEstado" HeaderText="Estado" />
                                                                        <asp:BoundField DataField="nombre" HeaderText="Quien Subuió El Testimonio" />
                                                                        <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
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
                                                    <br />
                                                </asp:Panel>
                                            </td>
                                            <td valign="top">
                                                <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                    BorderWidth="1px" Height="450px" Width="310px">
                                                    <table class="style1">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label13" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label9" runat="server" Text="Testimonio"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox ID="TextBox4" runat="server" Height="50px" TextMode="MultiLine" 
                                                                    Width="280px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table class="style1">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label10" runat="server" Text="Imagen:"></asp:Label>
                                                                        </td>
                                                                        <td align="center">
                                                                            <asp:Image ID="Image1" runat="server" BorderColor="#000066" BorderStyle="Solid" 
                                                                                BorderWidth="1px" Height="100px" Width="100px" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Estado:</td>
                                                                        <td>
                                                                            <asp:Label ID="Label14" runat="server"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label15" runat="server" Text="Nombre:"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox>
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
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="3" 
                                                                    Text="Activar" />
                                                                &nbsp;<asp:RadioButton ID="RadioButton4" runat="server" GroupName="3" 
                                                                    Text="Rechazar" />
                                                                &nbsp;<asp:RadioButton ID="RadioButton5" runat="server" GroupName="3" 
                                                                    Text="Anular" />
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <asp:Button ID="Button4" runat="server" Height="30px" 
                                                                    style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339933" 
                                                                    Text="Grabar" Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label16" runat="server" 
                                                                    style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None" ReadOnly="True" 
                                                                    Width="1px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

