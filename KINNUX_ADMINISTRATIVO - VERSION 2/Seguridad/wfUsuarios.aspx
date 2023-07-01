<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfUsuarios.aspx.vb" Inherits="Seguridad_wfUsuarios" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
            width: 100%;
        }
        .style15
        {
            color: #006699;
        }
        .style16
        {
            font-family: "Courier New", Courier, monospace;
            color: #006699;
        }
        .auto-style1 {
            color: #006699;
            width: 123px;
        }
        .auto-style2 {
            font-family: "Courier New", Courier, monospace;
            color: #006699;
            width: 127px;
        }
        .auto-style3 {
            width: 127px;
        }
        .auto-style4 {
            font-family: "Courier New", Courier, monospace;
            color: #006699;
            width: 120px;
        }
        .auto-style5 {
            width: 120px;
        }
        .auto-style6 {
            font-family: "Courier New", Courier, monospace;
            color: #006699;
            width: 133px;
        }
        .auto-style7 {
            font-family: "Courier New", Courier, monospace;
            color: #006699;
            width: 135px;
        }
        .auto-style8 {
            color: #006699;
            width: 122px;
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
                ImageUrl="~/Imagenes/mundo2.png" Height="40px" ToolTip="Usuarios Mundiales" 
                Width="40px" ID="ImageButton8"></asp:ImageButton>

                <br />
              </td>
            <td width="5%" align="center">

                                    <asp:ImageButton runat="server" 
                ImageUrl="~/Imagenes/mapa.png" Height="40px" ToolTip="Usuarios Aplicacion Pais" 
                Width="40px" ID="ImageButton9"></asp:ImageButton>

              </td>
            <td width="5%" align="center">

                                    <asp:ImageButton runat="server" 
                ImageUrl="~/Imagenes/bandera2.png" Height="40px" ToolTip="Usuarios Sucursales" 
                Width="40px" ID="ImageButton10"></asp:ImageButton>

              </td>
                          <td width="90%">Usuarios</td>

            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style14">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView2" runat="server">
                    <asp:View ID="View3" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                            <tr>
                                <td bgcolor="#CCCCCC">
                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" Width="40px" />
                                </td>
                                <td align="right" bgcolor="#CCCCCC" 
                                    style="color: #006699; font-size: medium; font-weight: 700; font-family: 'Courier New', Courier, monospace">
                                    Usuarios Aplicación Mundial</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        <table class="style14" style="width: 100%">
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Nombre Completo:</td>
                                                                <td>
                                                                    <asp:TextBox ID="TextBox5" runat="server" Width="228px" CssClass="form-control"></asp:TextBox>
                                                                    <asp:Label ID="Label6" runat="server" style="color: #FF0000"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Direccion:</td>
                                                                <td>
                                                                    <asp:TextBox ID="TextBox7" runat="server" TabIndex="1" Width="228px" 
                                                                        CssClass="form-control"></asp:TextBox>
                                                                    <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCCCCC" CssClass="campver" ReadOnly="True" style="margin-left: 0px" Visible="False" Width="75px"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Telefono:</td>
                                                                <td>
                                                                    <asp:TextBox ID="TextBox8" runat="server" TabIndex="2" Width="228px" 
                                                                        CssClass="form-control"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Correo Electronico:</td>
                                                                <td>
                                                                    <asp:TextBox ID="TextBox6" runat="server" TabIndex="3" Width="228px" 
                                                                        CssClass="form-control"></asp:TextBox>
                                                                    <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Datos De Acceso:</td>
                                                                <td>
                                                                    <table class="style14" style="border: thin solid #CCCCCC">
                                                                        <tr>
                                                                            <td class="auto-style8">
                                                                                Nombre De usuario:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox2" runat="server" TabIndex="6" Width="150px" 
                                                                                    CssClass="form-control"></asp:TextBox>
                                                                                <asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="auto-style8">
                                                                                Clave De Acceso:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox3" runat="server" TabIndex="7" TextMode="Password" 
                                                                                    Width="150px" CssClass="form-control"></asp:TextBox>
                                                                                &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="auto-style8">
                                                                                Confirmar Clave:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox4" runat="server" TabIndex="8" TextMode="Password" 
                                                                                    Width="150px" CssClass="form-control"></asp:TextBox>
                                                                                <asp:Label ID="Label5" runat="server" style="color: #FF0000"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="auto-style8">&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                </td>
                                                                <td>
                                                                    &nbsp;&nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style1">
                                                                    Estado:</td>
                                                                <td>
                                                                    <asp:DropDownList ID="DropDownList2" runat="server" TabIndex="9" Width="228px">
                                                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                                                        <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                                                    </asp:DropDownList>
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
                                                <tr>
                                                    <td colspan="2">
                                                        <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Vertical">
                                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                CellPadding="3" style="font-size: small" Width="100%">
                                                                <Columns>
                                                                    <asp:CommandField HeaderText="Seleccione" SelectText="Seleccione" 
                                                                        ShowSelectButton="True" />
                                                                    <asp:BoundField DataField="idUsuario" HeaderText="Id Usuario" />
                                                                    <asp:BoundField DataField="nombreUsuario" HeaderText="Nombre Usuario" />
                                                                    <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Nombres" />
                                                                    <asp:BoundField DataField="estadoUsuario" HeaderText="Estado" />
                                                                    <asp:BoundField DataField="clave" HeaderText="Clave" />
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
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                            <tr>
                                <td bgcolor="#CCCCCC">
                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />
                                    <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" Width="40px" />
                                </td>
                                <td align="right" bgcolor="#CCCCCC" 
                                    style="color: #006699; font-size: medium; font-weight: 700; font-family: 'Courier New', Courier, monospace">
                                    Usuarios Aplicación País</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <table class="style14">
                                        <tr>
                                            <td class="auto-style2">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Id Usuario:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" 
                                                    style="margin-left: 0px" Width="75px" BackColor="#CCCCCC" 
                                                    CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Nombre Completo:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox10" runat="server" Width="228px" CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label10" runat="server" style="color: #FF0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Direccion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox11" runat="server" TabIndex="1" Width="228px" 
                                                    CssClass="campver"></asp:TextBox>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Telefono:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox12" runat="server" TabIndex="2" Width="228px" 
                                                    CssClass="campver"></asp:TextBox>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Email:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox13" runat="server" TabIndex="3" Width="228px" 
                                                    CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label11" runat="server" style="color: #FF0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Empresa(Pais):</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList3" runat="server" Width="228px" 
                                                    CssClass="campver">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Datos De Acceso:</td>
                                            <td>
                                                <table class="style14" style="border: thin solid #CCCCCC">
                                                    <tr>
                                                        <td class="auto-style7">
                                                            Nombre De Usuario:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox14" runat="server" TabIndex="6" Width="228px" 
                                                                CssClass="campver"></asp:TextBox>
                                                            <asp:Label ID="Label12" runat="server" style="color: #FF0000"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">
                                                            Clave De Acceso:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox15" runat="server" TabIndex="7" TextMode="Password" 
                                                                Width="228px" CssClass="campver"></asp:TextBox>
                                                            <asp:Label ID="Label13" runat="server" style="color: #FF0000"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">
                                                            Confirmar Clave:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox16" runat="server" TabIndex="8" TextMode="Password" 
                                                                Width="228px" CssClass="campver"></asp:TextBox>
                                                            <asp:Label ID="Label14" runat="server" style="color: #FF0000"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                Estado:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList4" runat="server" TabIndex="9" Width="228px" 
                                                    CssClass="campver">
                                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                                    <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">
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
                                <td colspan="2">
                                    <asp:Panel ID="Panel7" runat="server" Height="400px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: small" Width="100%">
                                            <Columns>
                                                <asp:CommandField HeaderText="Seleccione" SelectText="Seleccione" 
                                                    ShowSelectButton="True" />
                                                <asp:BoundField DataField="idUsuario" HeaderText="Id Usuario" />
                                                <asp:BoundField DataField="nombreUsuario" HeaderText="Nombre Usuario" />
                                                <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Nombres" />
                                                <asp:BoundField DataField="estadoUsuario" HeaderText="Estado" />
                                                <asp:BoundField DataField="idempresa" HeaderText="Id Empresa" />
                                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                <asp:BoundField DataField="clave" HeaderText="Clave" />
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
                    <asp:View ID="View5" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style14">
                            <tr>
                                <td bgcolor="#CCCCCC">
                                    <asp:ImageButton ID="ImageButton11" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="40px" />
                                    <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" Width="40px" />
                                </td>
                                <td align="right" bgcolor="#CCCCCC" 
                                    style="color: #146295; font-size: medium; font-style: normal; font-family: 'Courier New', Courier, monospace; font-weight: 700">
                                    Usuarios Aplicación Puntos</td>
                            </tr>
                        </table>
                        <table class="style14">
                            <tr>
                                <td class="auto-style4">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Id Usuario:</td>
                                <td>
                                    <asp:TextBox ID="TextBox17" runat="server" ReadOnly="True" 
                                        style="margin-left: 0px" Width="75px" BackColor="#CCCCCC" 
                                        CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Nombre Completo:</td>
                                <td>
                                    <asp:TextBox ID="TextBox18" runat="server" Width="228px" CssClass="campver"></asp:TextBox>
                                    <asp:Label ID="Label15" runat="server" style="color: #FF0000"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Direccion:</td>
                                <td>
                                    <asp:TextBox ID="TextBox19" runat="server" TabIndex="1" Width="228px" 
                                        CssClass="campver"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Telefono:</td>
                                <td>
                                    <asp:TextBox ID="TextBox20" runat="server" TabIndex="2" Width="228px" 
                                        CssClass="campver"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Email:</td>
                                <td>
                                    <asp:TextBox ID="TextBox21" runat="server" TabIndex="3" Width="228px" 
                                        CssClass="campver"></asp:TextBox>
                                    <asp:Label ID="Label16" runat="server" style="color: #FF0000"></asp:Label>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Empresa(Pais):</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                                        Width="228px" CssClass="campver">
                                    </asp:DropDownList>
                                    <asp:Label ID="Label20" runat="server" style="color: #FF0000"></asp:Label>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Sucursales:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList7" runat="server" Width="228px" 
                                        CssClass="campver">
                                    </asp:DropDownList>
                                    <asp:Label ID="Label21" runat="server" style="color: #FF0000"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Datos De Acceso:</td>
                                <td>
                                    <table class="style14" style="border: thin solid #CCCCCC">
                                        <tr>
                                            <td class="auto-style6">
                                                Nombre De Usuario:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox22" runat="server" TabIndex="6" Width="228px" 
                                                    CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label17" runat="server" style="color: #FF0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                Clave De Acceso:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox23" runat="server" TabIndex="7" TextMode="Password" 
                                                    Width="228px" CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label18" runat="server" style="color: #FF0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                Confirmar Clave:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox24" runat="server" TabIndex="8" TextMode="Password" 
                                                    Width="228px" CssClass="campver"></asp:TextBox>
                                                <asp:Label ID="Label19" runat="server" style="color: #FF0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    Estado:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList6" runat="server" TabIndex="9" Width="228px" 
                                        CssClass="campver">
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel8" runat="server" Height="400px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: small" Width="100%">
                                            <Columns>
                                                <asp:CommandField HeaderText="Seleccione" SelectText="Seleccione" 
                                                    ShowSelectButton="True" />
                                                <asp:BoundField DataField="idUsuario" HeaderText="Id Usuario" />
                                                <asp:BoundField DataField="nombreUsuario" HeaderText="Nombre Usuario" />
                                                <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Nombres" />
                                                <asp:BoundField DataField="estadoUsuario" HeaderText="Estado" />
                                                <asp:BoundField DataField="idempresa" HeaderText="Id Empresa" />
                                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                <asp:BoundField DataField="idsucursal" HeaderText="Id Sucursal" />
                                                <asp:BoundField DataField="nombresucursal" HeaderText="Sucursal" />
                                                <asp:BoundField DataField="clave" HeaderText="Clave" />
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
                                <td colspan="2">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        <br />
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
    </table>
</asp:Content>

