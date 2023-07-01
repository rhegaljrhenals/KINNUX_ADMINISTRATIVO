<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfActualizacionDeDatos.aspx.vb" Inherits="Seguridad_wfActualizacionDeDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    
        .style12
        {
            width: 138px;
            height: 133px;
        }
        .style13
        {
            color: #000080;
            font-weight: bold;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
        }
        .style14
        {
        }
        .style15
        {
            color: #000066;
        }
        .style16
        {
            color: #000066;
            height: 15px;
        }
        .style17
        {
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 20%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                <span class="style13">Actualización De Datos</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" bgcolor="#CCCCCC" colspan="2">
                                        <asp:ImageButton runat="server" 
                    ImageUrl="~/Imagenes/buscar.png" Height="50px" ToolTip="Nuevo" Width="50px" 
                    ID="ImageButton9"></asp:ImageButton>

                                        </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="font-family: 'Courier New', Courier, monospace">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td class="style15">
                                    Codigo Afiliado:</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Identificación:</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" Width="200px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Primer Nombre:</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Segundo Nombre:</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Primer Apellido:</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Segundo Apellido:</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Direccion:</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Telefono:</td>
                                <td>
                                    <asp:TextBox ID="TextBox8" runat="server" Width="200px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style16">
                                    </td>
                                <td class="style17">
                                    </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Celular:</td>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server" Width="200px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    Email:</td>
                                <td>
                                    <asp:TextBox ID="TextBox10" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" class="style14" colspan="2">
                                    <asp:Button ID="Button1" runat="server" Height="30px" 
                                        style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                        Text="Actualizar Datos" />
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                        BorderWidth="1px" Height="220px" Width="462px" DefaultButton="Button2">
                                        <table align="left" cellpadding="0" cellspacing="0" class="style1">
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
                                                <td align="left" class="style14" colspan="2">
                                                    Ingrese el dato a buscar y pulse el boton &quot;Buscar Datos&quot;</td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2">
                                                    <asp:TextBox ID="TextBox11" runat="server" Width="300px"></asp:TextBox>
                                                    <asp:Button ID="Button2" runat="server" Height="30px" 
                                                        style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                                        Text="Buscar Datos" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server"></asp:Label>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel3" runat="server" Height="721px" ScrollBars="Vertical" 
                                        Width="800px">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: x-small" Width="800px">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Datos" ShowSelectButton="True" />
                                                <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                                                <asp:BoundField DataField="identificacion" HeaderText="Identificación" />
                                                <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                                                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                                                <asp:BoundField DataField="celular" HeaderText="Celular" />
                                                <asp:BoundField DataField="email1" HeaderText="Email" />
                                                <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                                                <asp:BoundField DataField="fechaafiliacion" DataFormatString="{0:yyyy/MM/dd}" 
                                                    HeaderText="Fecha Afiliación" />
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
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                </asp:MultiView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="font-family: 'Courier New', Courier, monospace">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

