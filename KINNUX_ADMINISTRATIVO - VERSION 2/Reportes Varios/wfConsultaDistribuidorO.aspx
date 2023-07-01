<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConsultaDistribuidorO.aspx.vb" Inherits="Reportes_Varios_wfConsultaDistribuidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 90%;
        }
        .style12
        {
            color: #000066;
        }
        .style14
        {
            height: 19px;
            font-family: "Courier New", Courier, monospace;
        }
        .style15
        {
            color: #FFFFFF;
            font-weight: bold;
        }
        .style16
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

                                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" 
                    ToolTip="Exportar a excell" Width="40px" ID="ImageButton10" Visible="False"></asp:ImageButton>

                <br />
              </td>
                          <td width="90%">Consulta De Distribuidores</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style5" style="width: 80%">
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" style="width: 462px" valign="top">
                <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                    BorderWidth="1px" Height="220px" Width="500px" DefaultButton="Button1">
                    <table cellpadding="0" cellspacing="0" class="style1" align="left" 
                        style="width: 100%">
                        <tr>
                            <td align="center" bgcolor="#006699" colspan="2" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace">
                                Busqueda Por</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Codigo Afiliado" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Primer Nombre" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Identificación" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton6" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Segundo Nombre" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Primer Apellido" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Email" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Segundo Apellido" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton8" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Pais" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="230px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14" colspan="2">
                                Ingrese el dato a buscar y pulse el boton buscar</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                <label>
                                &nbsp;<asp:Button ID="Button1" runat="server" Height="30px" 
                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                    Text="Buscar" Width="100px" />
                                </label>
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
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td align="left" valign="top">
                <asp:Panel ID="panelDatos" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#000066" BorderStyle="Solid" BorderWidth="1px" Height="350px" 
                    Width="500px">
                    <table cellpadding="0" cellspacing="0" class="style1" 
                        style="font-family: 'Courier New', Courier, monospace; width: 100%;">
                        <tr>
                            <td align="right" bgcolor="#006699" colspan="4">
                                &nbsp;<span class="style15">Datos Del Afiliado</span><asp:ImageButton ID="ImageButton11" 
                                    runat="server" Height="20px" ImageUrl="~/Imagenes/Error 2.png" 
                                    ToolTip="Cerrar" Width="20px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Codigo Afiliado:</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Identificacion:</td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="120px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Codigo Patrocinador:</td>
                            <td>
                                <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True" Width="80px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Nombre Patrocinador:</td>
                            <td>
                                <asp:TextBox ID="TextBox11" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Apellidos</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Nombres:</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Direccion:</td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Telefono:</td>
                            <td>
                                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Celular:</td>
                            <td>
                                <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                            </td>
                            <td align="center" style="color: #000066; text-align: left;">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                Email:</td>
                            <td>
                                <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
                            </td>
                            <td style="color: #000066">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td colspan="3">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" style="width: 462px" valign="top">
                &nbsp;</td>
            <td align="left" valign="top">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label3" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel3" runat="server" Height="100px" ScrollBars="Both" 
                    Width="1000px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small">
                        <Columns>
                            <asp:CommandField SelectText="Ver Datos" ShowSelectButton="True" />
                            <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="celular" HeaderText="Celular" />
                            <asp:BoundField DataField="email1" HeaderText="Email" />
                            <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                            <asp:BoundField DataField="nombreDpto" HeaderText="Dpto" />
                            <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
                            <asp:BoundField DataField="codigoAfiliado" HeaderText="Usuario" />
                            <asp:BoundField DataField="clave" HeaderText="Clave De Acceso" />
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfCompras.aspx?id={0}" 
                                Target="_blank" Text="Compras">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfRedBinaria.aspx?id={0}" 
                                Target="_blank" Text="Red Binaria">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfRedUninivel.aspx?id={0}" 
                                Target="_blank" Text="Red Uninivel">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfComisiones.aspx?id={0}" 
                                Target="_blank" Text="Comisiones"></asp:HyperLinkField>
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfDetalleComisionesTS.aspx?id={0}" 
                                Target="_blank" Text="Comisiones TS">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfRedPatrocinio.aspx?id={0}" 
                                Target="_blank" Text="Red De Patrocinio" />
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
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server"  Text='<%# Eval("codigoAfiliado") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("nombres") %>'></asp:Label>
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server">Compras</asp:HyperLink>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

