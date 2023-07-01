<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfOpciones.aspx.vb" Inherits="Seguridad_wfOpciones"  ValidateRequest=false %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            color: #FFFFFF;
            background-color: #006699;
        }
        .auto-style1 {
            height: 31px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="5" cellspacing="0" width="100%">
        <tr>
            <td class="titleseccion">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="90%">
                            Opciones Principales</td>
                        <td align="center" width="5%">
                            &nbsp;<br />
                        </td>
                    </tr>
                </table>
            </td>
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
            <td align="center" colspan="2">
                <asp:Button ID="Button5" runat="server" Text="Administrativo" Width="120px" style="margin-left: 0px" />
                <asp:Button ID="Button6" runat="server" Text="Pais" Width="120px" style="margin-left: 0px" />
                <asp:Button ID="Button7" runat="server" Text="Punto" Width="120px" style="margin-left: 0px" />
                <asp:TextBox ID="TextBox6" runat="server" Visible="False" Width="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                        <table class="style1" __designer:mapid="7ba">
                            <tr __designer:mapid="7bb">
                                <td align="center" colspan="2" __designer:mapid="7bc">
                                    <asp:Label ID="Label5" runat="server" 
                                        style="color: #005FAE; font-size: x-large; font-weight: 700"></asp:Label>
                                </td>
                            </tr>
                            <tr __designer:mapid="7bb">
                                <td align="right" colspan="2" __designer:mapid="7bc">
                                    &nbsp;</td>
                            </tr>
                            <tr __designer:mapid="7bd">
                                <td __designer:mapid="7be">
                                    Opciones Principales:<asp:DropDownList ID="DropDownList1" runat="server" 
                                        style="margin-left: 0px" Width="300px">
                                    </asp:DropDownList>
                                    <asp:Button ID="Button8" runat="server" Text="Mostrar" Width="100px" />
                                </td>
                                <td __designer:mapid="7c1">
                                    &nbsp;</td>
                            </tr>
                            <tr __designer:mapid="7c2">
                                <td colspan="2" __designer:mapid="7c3">
                                    <table class="style1" __designer:mapid="7c4">
                                        <tr __designer:mapid="7c5">
                                            <td __designer:mapid="7c6" align="right">
                                    <asp:Button ID="Button11" runat="server" Text="Confirmar Borrado" Width="150px" />
                                            </td>
                                            <td __designer:mapid="7d8">
                                                &nbsp;</td>
                                            <td valign="top" __designer:mapid="7d9">
                                                &nbsp;</td>
                                        </tr>
                                        <tr __designer:mapid="7c5">
                                            <td __designer:mapid="7c6">
                                                <asp:Panel ID="Panel1" runat="server" Height="350px" ScrollBars="Vertical" 
                                                    Width="100%">
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" Width="100%">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idtbsubmenu" HeaderText="#" />
                                                            <asp:BoundField DataField="idSubmenu" HeaderText="Id Submenu" />
                                                            <asp:BoundField DataField="nombresubmenu" HeaderText="Nombre Submenu" />
                                                            <asp:BoundField DataField="ruta" HeaderText="Ruta" />
                                                            <asp:BoundField DataField="estadoOpcion" HeaderText="Estado" />
                                                            <asp:TemplateField HeaderText="Eliminar">
                                                                <ItemTemplate>
                                                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
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
                                            <td __designer:mapid="7d8">
                                                &nbsp;</td>
                                            <td valign="top" __designer:mapid="7d9">
                                                <table class="style1" __designer:mapid="7da" 
                                                    style="border: thin solid #C0C0C0; height: 350px">
                                                    <tr __designer:mapid="7db">
                                                        <td __designer:mapid="7dc" align="center" class="style4" colspan="2">
                                                            Actualizacion De Opciones</td>
                                                    </tr>
                                                    <tr __designer:mapid="7de">
                                                        <td __designer:mapid="7df">
                                                            No De Opcion</td>
                                                        <td __designer:mapid="7e0">
                                                            <asp:TextBox ID="TextBox5" runat="server" Visible="False" Width="20px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="7e2">
                                                        <td __designer:mapid="7e3">
                                                            <asp:TextBox ID="TextBox4" runat="server" CssClass="campver" ReadOnly="True"></asp:TextBox>
                                                        </td>
                                                        <td __designer:mapid="7e5">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr __designer:mapid="7e6">
                                                        <td __designer:mapid="7e7">
                                                            No De Opcion Submenu</td>
                                                        <td __designer:mapid="7e8">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr __designer:mapid="7e9">
                                                        <td colspan="2" __designer:mapid="7ea" class="auto-style1">
                                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="campver"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="7ec">
                                                        <td __designer:mapid="7ed">
                                                            Nombre Submenu</td>
                                                        <td __designer:mapid="7ee">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr __designer:mapid="7ef">
                                                        <td colspan="2" __designer:mapid="7f0">
                                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="7f2">
                                                        <td __designer:mapid="7f3">
                                                            Ruta</td>
                                                        <td __designer:mapid="7f4">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr __designer:mapid="7f5">
                                                        <td colspan="2" __designer:mapid="7f6">
                                                            <asp:TextBox ID="TextBox3" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="7f8">
                                                        <td __designer:mapid="7f9">
                                                            Estado:</td>
                                                        <td __designer:mapid="7fa">
                                                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="Activo" />
                                                            <br __designer:mapid="7fc" />
                                                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                                                Text="Eliminado" />
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="7fe">
                                                        <td colspan="2" __designer:mapid="7ff">
                                                            <asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr __designer:mapid="801">
                                                        <td align="center" colspan="2" __designer:mapid="802">
                                                            <asp:Button ID="Button10" runat="server" Text="Nuevo" Width="100px" />
                                                            <asp:Button ID="Button9" runat="server" Text="Grabar" Width="100px" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr __designer:mapid="805">
                                            <td __designer:mapid="806">
                                                &nbsp;</td>
                                            <td __designer:mapid="807">
                                                &nbsp;</td>
                                            <td __designer:mapid="808">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

