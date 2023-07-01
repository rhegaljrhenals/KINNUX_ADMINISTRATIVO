<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConsultaDistribuidor.aspx.vb" Inherits="Reportes_Varios_wfConsultaDistribuidor" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 90%;
        }
        .style16
        {
            color: #006699;
        }
        .style17
        {
            color: #FFFFFF;
        }
        .style18
        {
            width: 100%;
        }
        .style19
        {
            height: 37px;
        }
        .style20
        {
            background-color: #FFFFFF;
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
    <table cellpadding="0" cellspacing="0" class="style5" style="width: 100%">
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                <asp:Panel ID="Panel4" runat="server" DefaultButton="Button1" Height="200px">
                    <table style="border: thin solid #C0C0C0; width: 550px">
                        <tr>
                            <td align="center" class="style17" colspan="4" 
                            style="background-color: #006699">
                                Busqueda</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Codigo Afiliado" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Identificación" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Primer Apellido" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton8" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Pais" 
                                    CssClass="style16" Visible="False" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Segundo Apellido" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Primer Nombre" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton6" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Segundo Nombre" CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="50px" 
                                    Visible="False">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Email" 
                                    CssClass="style16" />
                            </td>
                            <td align="left">
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                            </td>
                            <td align="left">
                                &nbsp;</td>
                            <td align="left">
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="left" colspan="4">
                                Ingrese El Dato:
                                <asp:TextBox ID="TextBox1" runat="server" Width="150px" CssClass="campver"></asp:TextBox>
                                &nbsp;<label><asp:Button ID="Button1" runat="server" Height="30px" 
                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                    Text="Buscar" Width="100px" CssClass="btn-primary active" />
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                &nbsp;</td>
                            <td align="left" colspan="3">
                                <table class="style18">
                                    <tr>
                                        <td class="style19">
                                            <asp:LinkButton ID="LinkButton2" runat="server">Mostrar En Forma Detallada</asp:LinkButton>
                                            <br />
                                            <asp:LinkButton ID="LinkButton4" runat="server">Mostrar En Forma De Lista</asp:LinkButton>
                                        </td>
                                        <td class="style19">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <br />
            </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <table class="nav-justified">
                    <tr>
                        <td colspan="4">
                <asp:Label ID="Label3" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                <asp:Panel ID="Panel3" runat="server" Height="250px" ScrollBars="Both" Width="100%">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" 
                        CssClass="table-responsive">
                        <Columns>
                            <asp:CommandField SelectText="Ver Datos" ShowSelectButton="True" />
                            <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                            <asp:BoundField DataField="identificacion" HeaderText="Identificación" />
                            <asp:BoundField DataField="nombres" HeaderText="Afiliados" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="celular" HeaderText="Celular" />
                            <asp:BoundField DataField="email1" HeaderText="Email" />
                            <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                            <asp:BoundField DataField="nombreDpto" HeaderText="Dpto" />
                            <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
                            <asp:BoundField DataField="fechaafiliacion" HeaderText="Fecha Afiliación" 
                                DataFormatString="{0:yyyy/MM/dd}" />
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
                            <asp:HyperLinkField DataNavigateUrlFields="codigoAfiliado" Target="_blank" 
                                Text="Comisiones STS" 
                                
                                DataNavigateUrlFormatString="~/Reportes Varios/wfDetalleComisionesTS.aspx?id={0}" />
                            <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                                DataNavigateUrlFormatString="~/Reportes Varios/wfRedPatrocinio.aspx?id={0}" 
                                Target="_blank" Text="Red De Patrocinio" />
                            <asp:HyperLinkField Text="Comision Binaria" />
                        </Columns>
                        <FooterStyle ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#000066" HorizontalAlign="Left" />
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
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4" align="center">
                            <asp:Panel ID="Panel5" runat="server" Height="450px" ScrollBars="Vertical" 
                                Width="100%">
                                <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" Width="100%">
                                    <ItemTemplate>
                                        <table class="style18">
                                            <tr>
                                                <td align="left" valign="top">
                                                    <table class="style18">
                                                        <tr>
                                                            <td align="center">
                                                                <asp:Image ID="Image3" runat="server" Height="100px" 
                                                                    ImageUrl='<%# "http://www.knxplus.com/fotos_usuarios/" & Eval("fotos") %>' 
                                                                    Width="100px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink1" runat="server" 
                                                                    NavigateUrl ='<%# "~/Reportes Varios/wfCompras.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Compras</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink2" runat="server" 
                                                                    NavigateUrl='<%# "~/Reportes Varios/wfRedBinaria.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Red Binaria</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink3" runat="server" 
                                                                    NavigateUrl='<%# "~/Reportes Varios/wfRedUninivel.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Red Uninivel</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink4" runat="server" 
                                                                    NavigateUrl='<%# "~/Reportes Varios/wfRedPatrocinio.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Red De Patrocinio</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink5" runat="server" 
                                                                    NavigateUrl='<%# "~/Reportes Varios/wfComisiones.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Comisiones</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink6" runat="server" 
                                                                    NavigateUrl='<%# "~/Reportes Varios/wfDetalleComisionesTS.aspx?id=" & Eval("codigoafiliado") %>' 
                                                                    Target="_blank">Comisiones STS</asp:HyperLink>
                                                            </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="style20">
                                                                <asp:HyperLink ID="HyperLink7" runat="server" 
                                                                    NavigateUrl='<%# "http://backoffice.knxplus.com/?id=" & Eval("codigoafiliado")%>' 
                                                                    Target="_blank">BackOffice</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                    
                                                    </table>
                                                    <asp:Button ID="Button5" runat="server" Text="Retirar" CommandName="retirar" CommandArgument='<%# Eval("codigoafiliado")%>' />
                                                    <br />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    <table class="style18" align="left" style="border: thin solid #C0C0C0">
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label5" runat="server" Text="Codigo Afiliado:"></asp:Label>
                                                            </td>
                                                            <td align="left">
                                                                <asp:TextBox ID="TextBox2" runat="server" CssClass="Campver" 
                                                                    Text='<%# Eval("codigoafiliado") %>' ReadOnly="True" Width="80px"></asp:TextBox>
                                                            </td>
                                                            <td align="left">
                                                                <asp:Label ID="Label12" runat="server" Text="Clave:"></asp:Label>
                                                            </td>
                                                            <td align="left">
                                                                <asp:TextBox ID="TextBox12" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("clave") %>' Width="120px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                Identificación:</td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox13" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("identificacion") %>' Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label6" runat="server" Text="Nombres:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("nombres") %>' Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label7" runat="server" Text="Direccion:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox4" runat="server" CssClass="Campver" Width="250px"  
                                                                    Text='<%# Eval("direccion") %>' ReadOnly="True"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label8" runat="server" Text="Telefono:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox5" runat="server" CssClass="Campver" Width="250px"  
                                                                    Text='<%# Eval("telefono") %>' ReadOnly="True"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                Fecha Nacido:</td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox10" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("fechanacido") %>'></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox6" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("email1") %>' Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label10" runat="server" Text="Pais:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox7" runat="server" CssClass="Campver" Width="250px" 
                                                                    ReadOnly="True"  Text='<%# Eval("nombrepais") %>'></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                <asp:Label ID="Label11" runat="server" Text="Dpto:"></asp:Label>
                                                            </td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox8" runat="server" CssClass="Campver" Width="250px" 
                                                                    ReadOnly="True"  Text='<%# Eval("nombredpto") %>'></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                Ciudad:</td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox9" runat="server" CssClass="Campver" Width="250px" 
                                                                    ReadOnly="True"  Text='<%# Eval("nombreMunicipio") %>'></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                Patrocinador:</td>
                                                            <td align="left" colspan="3">
                                                                <asp:TextBox ID="TextBox11" runat="server" CssClass="Campver" ReadOnly="True" 
                                                                    Text='<%# Eval("patrocinador") %>' Width="250px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                            <td align="left" colspan="3">
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </ItemTemplate>
                                </asp:DataList>
                            </asp:Panel>
                        </td>
                    </tr>
                    </table>
            </td>
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

