<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConfigurarPromociones.aspx.vb" Inherits="Basicos_wfProducto" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
        }
        .style20
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
                                        ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />

              </td>
          <td width="5%" align="center">
                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="40px" />

              </td>
                          <td width="90%">Configurar Promociones</td>
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
                <table class="style20">
                    <tr>
                        <td valign="top">
                            <table class="style20">
                                <tr>
                                    <td>
                                        Fecha Inicial:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox14" runat="server" CssClass="campver"></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox14_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton12" 
                                                    TargetControlID="TextBox14">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton12" runat="server" Height="20px" 
                                                    ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="10px" 
                                                    CssClass="campver" BackColor="#CCCCCC" Visible="False"></asp:TextBox>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Fecha Final:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox15" runat="server" CssClass="campver"></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox15_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton13" 
                                                    TargetControlID="TextBox15">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton13" runat="server" Height="20px" 
                                                    ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Tipo De Promocion:</td>
                                    <td>
                                                <asp:DropDownList ID="DropDownList28" runat="server" AutoPostBack="True" 
                                                    CssClass="campver">
                                                    <asp:ListItem Value="N">Seleccione El Tipo De Promocion</asp:ListItem>
                                                    <asp:ListItem Value="P">Promocion Para El Pais</asp:ListItem>
                                                    <asp:ListItem Value="S">Promocion Para Sucursal</asp:ListItem>
                                                    <asp:ListItem Value="E">Promocion Para El Evento</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:Label ID="Label24" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                                            <asp:Label ID="Label22" runat="server" Text="Pais:"></asp:Label>
                                                        </td>
                                    <td>
                                                <asp:DropDownList ID="DropDownList26" runat="server" CssClass="campver" 
                                                    Width="300px" AutoPostBack="True" TabIndex="1">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label25" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                                        </td>
                                </tr>
                                <tr>
                                    <td>
                                                            <asp:Label ID="Label23" runat="server" Text="Sucursal:"></asp:Label>
                                                        </td>
                                    <td>
                                                <asp:DropDownList ID="DropDownList27" runat="server" CssClass="campver" 
                                                    Width="300px" TabIndex="2">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label26" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                                        </td>
                                </tr>
                                <tr>
                                    <td>
                                                            <asp:Label ID="Label28" runat="server" Text="Evento:"></asp:Label>
                                                        </td>
                                    <td>
                                                <asp:DropDownList ID="DropDownList25" runat="server" CssClass="campver" 
                                                    Width="300px" TabIndex="3">
                                                </asp:DropDownList>
                                                <asp:Label ID="Label20" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                                        </td>
                                </tr>
                                <tr>
                                    <td>
                                        Es Paquete De Inicio?:</td>
                                    <td>
                                                <asp:DropDownList ID="DropDownList29" runat="server" CssClass="campver" 
                                                    TabIndex="4">
                                                    <asp:ListItem Value="s">Si</asp:ListItem>
                                                    <asp:ListItem Value="n">No</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        No De Productps Base:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox17" runat="server" CssClass="campver" Width="50px" 
                                                    TabIndex="5"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox17_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox17">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label27" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        No De Productos En Promocion:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox16" runat="server" CssClass="campver" Width="50px" 
                                                    TabIndex="6"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox16_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox16">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label21" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        No Productos En Obsequios:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox19" runat="server" CssClass="campver" Width="50px" 
                                                    TabIndex="6"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox19_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox19">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label31" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        No De STS:</td>
                                    <td>
                                                <asp:TextBox ID="TextBox18" runat="server" CssClass="campver" Width="50px" 
                                                    TabIndex="7"></asp:TextBox>
                                                <asp:Label ID="Label30" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Califica Promocion:<asp:Label ID="Label17" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                    <td style="margin-left: 80px">
                                                <asp:DropDownList ID="DropDownList30" runat="server" CssClass="campver" 
                                                    TabIndex="8">
                                                    <asp:ListItem Value="s">Si</asp:ListItem>
                                                    <asp:ListItem Value="n">No</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Nombre Promocion:</td>
                                    <td style="margin-left: 80px">
                                                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                                    Width="250px" CssClass="campver" TabIndex="9"></asp:TextBox>
                                                </td>
                                </tr>
                                <tr>
                                    <td>
                                        Valor Promocion:</td>
                                    <td style="margin-left: 80px">
                                                <asp:TextBox ID="TextBox2" runat="server" 
                                                    CssClass="campver" TabIndex="10"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" 
                                                    TargetControlID="TextBox2">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label18" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Pertenece a Ciclos:<asp:Label ID="Label1" runat="server" style="color: #FF0000" 
                                                    Text="* Requerido"></asp:Label>
                                            </td>
                                    <td style="margin-left: 80px">
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="campver" 
                                                    TabIndex="8">
                                                    <asp:ListItem Value="n">No</asp:ListItem>
                                                    <asp:ListItem Value="s">Si</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                </tr>
                                <tr>
                                    <td>
                                        Estado:</td>
                                    <td style="margin-left: 80px">
                                                <asp:DropDownList ID="DropDownList24" runat="server" Width="250px" 
                                                    CssClass="campver">
                                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                                    <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td valign="top">
                                                <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
                                                    Text="Seleccionar Todos" TabIndex="11" />
                                            <br />
                                                <asp:Label ID="Label29" runat="server" style="color: #FF0000" 
                                                    Text="* Debe seleccionar los productos...!"></asp:Label>
                                                <asp:Panel ID="Panel2" runat="server" Height="448px" ScrollBars="Vertical" 
                                                    Width="500px" BorderColor="Silver" BorderStyle="Solid" 
                                BorderWidth="1px">
                                                    <table class="style20">
                                                        <tr>
                                                            <td>
                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" TabIndex="12">
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Seleccione">
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idProducto" HeaderText="Id" />
                                                                        <asp:BoundField DataField="nombreProducto" HeaderText="Nombre Producto" />
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
            <td class="style14" align="left" colspan="2">
                                    <table class="style20" __designer:mapid="344">
                                        <tr __designer:mapid="35b">
                                            <td __designer:mapid="35c">
                                                <asp:Panel ID="Panel1" runat="server" Height="300px" ScrollBars="Vertical">
                                                    <asp:GridView ID="GridView2" runat="server" 
    AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
    BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idpromocionts" HeaderText="Id" />
                                                            <asp:BoundField DataField="nombrepromocionts" HeaderText="Nombre Promocion" />
                                                            <asp:BoundField DataField="tipopromocion" HeaderText="Tipo De Promocion" />
                                                            <asp:BoundField DataField="fechaipromocionts" DataFormatString="{0:yyyy/MM/dd}" 
                                                                HeaderText="Fecha Inicial" />
                                                            <asp:BoundField DataField="fechafpromocionts" DataFormatString="{0:yyyy/MM/dd}" 
                                                                HeaderText="Fecha Final" />
                                                            <asp:BoundField DataField="nombreEvento" HeaderText="Evento" />
                                                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                            <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" />
                                                            <asp:BoundField DataField="valorpromocionts" DataFormatString="{0:N0}" 
                                                                HeaderText="Valor Promocion">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="nbasepromocionts" 
                                                                HeaderText="No Productos Base" >
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="nprodpromocionts" DataFormatString="{0:N0}" 
                                                                HeaderText="No Productos En Promocion">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                                                            <asp:BoundField DataField="vigente" HeaderText="Vigencia" />
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
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

