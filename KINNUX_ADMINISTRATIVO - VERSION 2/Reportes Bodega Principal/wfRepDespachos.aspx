<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfRepDespachos.aspx.vb" Inherits="Reportes_Bodega_Principal_wfRepentradasDeProductos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style20
        {
            height: 15px;
        }
        .style21
        {
            width: 100%;
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

                                    


                                    &nbsp;</td>
                          <td width="90%">Reportes De Despachos De Productos</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style20" colspan="2">
                <table class="style21">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Fecha Inicial:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton9" 
                                TargetControlID="TextBox1">
                            </asp:CalendarExtender>
                <asp:ImageButton runat="server" ImageUrl="~/images/calendario_imagen.png" Height="30px" 
                    ToolTip="Calendario" Width="30px" ID="ImageButton9"></asp:ImageButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Fecha Final:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton10" 
                                TargetControlID="TextBox2">
                            </asp:CalendarExtender>
                <asp:ImageButton runat="server" ImageUrl="~/images/calendario_imagen.png" Height="30px" 
                    ToolTip="Calendario" Width="30px" ID="ImageButton10"></asp:ImageButton>
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
                                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                Text="Confirmados" />
                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="No Confirmados" />
                                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                Text="Anulados" />
                                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                Text="Activos" />
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
                            <asp:Label ID="Label6" runat="server" 
                                Text="A Que Empresa Se Le Envio El Despacho?:"></asp:Label>
                        </td>
                        <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                                </asp:DropDownList>
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
            <td align="left" colspan="2">
                <table class="style21">
                    <tr>
                        <td>
                            <asp:Panel ID="Panel3" runat="server" Height="300px" ScrollBars="Both" 
                                Width="500px">
                                <table class="style21">
                                    <tr>
                                        <td align="center" 
                                            style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339966">
                                            Encabezado</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3">
                                                <Columns>
                                                    <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                                    <asp:BoundField DataField="idEncDesProductoPais" HeaderText="Id" />
                                                    <asp:BoundField DataField="fechaEncDesProductoPais" 
                                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                    <asp:BoundField DataField="idEncPedProductoBod" HeaderText="Pedido No" />
                                                    <asp:BoundField DataField="nombreEmpresa" 
                                                        HeaderText="Empresa a Quien Se Envio" />
                                                    <asp:BoundField DataField="confirEncDesProductoPais" HeaderText="Confirmado" />
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
                        <td>
                            &nbsp;</td>
                        <td valign="top">
                            <asp:Panel ID="Panel4" runat="server" Height="300px" ScrollBars="Both" 
                                Width="500px">
                                <table class="style21">
                                    <tr>
                                        <td align="center" 
                                            style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #339966">
                                            Detalle</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3">
                                                <Columns>
                                                    <asp:BoundField DataField="idproducto" HeaderText="Id Producto" />
                                                    <asp:BoundField DataField="nombreproducto" HeaderText="Nombre Producto" />
                                                    <asp:BoundField DataField="cantdetDesProductoPais" HeaderText="Cantidad" />
                                                    <asp:BoundField DataField="valorDetDesProductoPais" HeaderText="Valor" />
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
                        <td>
                            &nbsp;</td>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                </asp:UpdatePanel>
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

