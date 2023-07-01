<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPermisos.aspx.vb" Inherits="Seguridad_wfPermisos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .auto-style1 {
            height: 20px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="90%">Permisos</td>
            <td width="5%" align="center">&nbsp;<br />
              </td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                    Height="950px" Width="100%">
                    <asp:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
                        <HeaderTemplate>Permisos Usuarios Mundiales</HeaderTemplate>
                        <ContentTemplate>
                            <br />
                            <table cellpadding="0" cellspacing="0" style="width: 100%"><tr><td bgcolor="#CCCCCC"><asp:ImageButton ID="ImageButton7" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" /><asp:ImageButton ID="ImageButton8" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" /></td></tr><tr><td>&nbsp;</td></tr><tr><td><asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><table cellpadding="0" cellspacing="0" class="style1"><tr><td>Usuarios: <asp:DropDownList ID="DropDownList1" runat="server" Width="300px"></asp:DropDownList><asp:Button ID="Button1" runat="server" Text="Mostrar Permisos" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006699" /></td></tr><tr><td class="auto-style1"></td></tr><tr><td>&#160;</td></tr><tr><td><asp:Panel ID="Panel4" runat="server" Height="769px" ScrollBars="Vertical" 
                                Width="100%"><asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small" Width="100%"><Columns><asp:BoundField DataField="idmenu" HeaderText="Id menu" /><asp:BoundField DataField="nombreMenu" HeaderText="Nombre Menu" /><asp:BoundField DataField="idSubmenu" HeaderText="Id Submenu" /><asp:BoundField DataField="nombreSubmenu" HeaderText="Nombre Submenu" /><asp:TemplateField HeaderText="Tiene Acceso?"><ItemTemplate><asp:CheckBox ID="CheckBox2" runat="server" /></ItemTemplate><ItemStyle HorizontalAlign="Center" /></asp:TemplateField></Columns><FooterStyle BackColor="White" ForeColor="#000066" /><HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" /><RowStyle ForeColor="#000066" /><SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" /><SortedAscendingCellStyle BackColor="#F1F1F1" /><SortedAscendingHeaderStyle BackColor="#007DBB" /><SortedDescendingCellStyle BackColor="#CAC9C9" /><SortedDescendingHeaderStyle BackColor="#00547E" /></asp:GridView></asp:Panel></td></tr></table></ContentTemplate></asp:UpdatePanel></td></tr></table></ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                        <HeaderTemplate>Permisos Usuarios De Paises(Empresas)</HeaderTemplate>
                        <ContentTemplate><table cellpadding="0" cellspacing="0" class="style1"><tr><td>&nbsp;</td></tr><tr><td bgcolor="#CCCCCC"><asp:ImageButton ID="ImageButton9" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" /><asp:ImageButton ID="ImageButton10" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" /></td></tr><tr><td><asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate><table cellpadding="0" cellspacing="0" class="style1"><tr><td>&#160;</td></tr><tr><td>Usuarios: <asp:DropDownList 
                                    ID="DropDownList3" runat="server" Width="350px"></asp:DropDownList><asp:Button 
                                    ID="Button2" runat="server" Text="Mostrar Permisos" /></td></tr><tr><td>&#160;</td></tr><tr><td>&#160;</td></tr><tr><td><asp:Panel ID="Panel3" runat="server" Height="769px" ScrollBars="Vertical"><asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small" Width="100%"><Columns><asp:BoundField DataField="idmenu" HeaderText="Id menu" /><asp:BoundField DataField="nombreMenu" HeaderText="Nombre Menu" /><asp:BoundField DataField="idSubmenu" HeaderText="Id Submenu" /><asp:BoundField DataField="nombreSubmenu" HeaderText="Nombre Submenu" /><asp:TemplateField HeaderText="Tiene Acceso?"><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server" /></ItemTemplate><ItemStyle HorizontalAlign="Center" /></asp:TemplateField></Columns><FooterStyle BackColor="White" ForeColor="#000066" /><HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" /><RowStyle ForeColor="#000066" /><SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" /><SortedAscendingCellStyle BackColor="#F1F1F1" /><SortedAscendingHeaderStyle BackColor="#007DBB" /><SortedDescendingCellStyle BackColor="#CAC9C9" /><SortedDescendingHeaderStyle BackColor="#00547E" /></asp:GridView></asp:Panel></td></tr></table></ContentTemplate></asp:UpdatePanel></td></tr></table></ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="Usuarios Sucursales">
                        <ContentTemplate><br /><table cellpadding="0" cellspacing="0" class="style1" style="width: 100%"><tr><td>&nbsp;</td></tr><tr><td bgcolor="#CCCCCC"><asp:ImageButton ID="ImageButton11" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" /><asp:ImageButton ID="ImageButton12" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" /></td></tr><tr><td>&nbsp;</td></tr><tr><td align="right">&nbsp;</td></tr><tr><td><table cellpadding="0" cellspacing="0" class="style1"><tr><td valign="top"><asp:Panel ID="Panel6" runat="server" Height="690px" ScrollBars="Both"><table cellpadding="0" cellspacing="0" class="style1"><tr><td align="center" 
                                                                    style="color: #FFFFFF; font-weight: 700; background-color: #339933">Usuarios</td></tr></table><asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                            CellPadding="3"><Columns><asp:CommandField SelectText="Ver" ShowSelectButton="True" /><asp:BoundField DataField="idUsuario" HeaderText="Id Usuario" /><asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Usuario" /><asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" /><asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" /></Columns><FooterStyle BackColor="White" ForeColor="#000066" /><HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" /><RowStyle ForeColor="#000066" /><SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" /><SortedAscendingCellStyle BackColor="#F1F1F1" /><SortedAscendingHeaderStyle BackColor="#007DBB" /><SortedDescendingCellStyle BackColor="#CAC9C9" /><SortedDescendingHeaderStyle BackColor="#00547E" /></asp:GridView></asp:Panel></td><td valign="top"><asp:Panel ID="Panel5" runat="server" Height="690px" ScrollBars="Vertical"><table cellpadding="0" cellspacing="0" class="style1"><tr><td align="center" 
                                                                    style="color: #FFFFFF; font-weight: 700; background-color: #339933">Opciones</td></tr></table><table class="style1"><tr><td>Id:</td><td><asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox></td></tr><tr><td>Usuario:</td><td><asp:TextBox ID="TextBox2" runat="server" Width="350px"></asp:TextBox></td></tr><tr><td colspan="2"><asp:CheckBox ID="CheckBox4" runat="server" Text="Sube Consignación?" /></td></tr><tr><td colspan="2"><asp:CheckBox ID="CheckBox5" runat="server" Text="Sube Tarjetas De Crédito?" /></td></tr><tr><td colspan="2"><asp:CheckBox ID="CheckBox6" runat="server" Text="Maneja Fechas Facturacion?" /></td></tr><tr><td>&#160;</td><td>&#160;</td></tr><tr><td colspan="2"><asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                        CellPadding="3" style="font-size: small"><Columns><asp:BoundField DataField="idmenu" HeaderText="Id menu" /><asp:BoundField DataField="nombreMenu" HeaderText="Nombre Menu" /><asp:BoundField DataField="idSubmenu" HeaderText="Id Submenu" /><asp:BoundField DataField="nombreSubmenu" HeaderText="Nombre Submenu" /><asp:TemplateField HeaderText="Tiene Acceso?"><ItemTemplate><asp:CheckBox ID="CheckBox3" runat="server" /></ItemTemplate><ItemStyle HorizontalAlign="Center" /></asp:TemplateField></Columns><FooterStyle BackColor="White" ForeColor="#000066" /><HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" /><PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" /><RowStyle ForeColor="#000066" /><SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" /><SortedAscendingCellStyle BackColor="#F1F1F1" /><SortedAscendingHeaderStyle BackColor="#007DBB" /><SortedDescendingCellStyle BackColor="#CAC9C9" /><SortedDescendingHeaderStyle BackColor="#00547E" /></asp:GridView></td></tr></table><br /></asp:Panel></td></tr><tr><td>&nbsp;</td><td>&nbsp;</td></tr></table></td></tr></table></ContentTemplate>
                    </asp:TabPanel>
                </asp:TabContainer>
            </td>
        </tr>
        </table>
</asp:Content>

