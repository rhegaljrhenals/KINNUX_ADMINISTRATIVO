<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfActualizacionDeDatos.aspx.vb" Inherits="Seguridad_wfActualizacionDeDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    
        .style14
        {            color: #000066;
        }
        .style16
        {
            width: 100%;
        }
        .style17
        {
            color: #146295;
        }
        .auto-style1 {
            color: #146295;
            }
        .auto-style2 {
            width: 168px;
        }
        .auto-style3 {
            width: 153px;
        }
        .auto-style4 {
            width: 170px;
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
                    ImageUrl="~/Imagenes/buscar.png" Height="40px" ToolTip="Buscar Datos" Width="40px" 
                    ID="ImageButton9"></asp:ImageButton>

                <br />
              </td>
            <td width="5%" align="center">
                  <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Imagenes/icono-PDF_opt.png" Target="_blank">Descargar PDF</asp:HyperLink>
              </td>
                          <td width="90%">Actualización De Datos</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
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
                        <table class="style16">
                            <tr>
                                <td class="auto-style1">
                                    <table class="style16">
                                        <tr>
                                            <td class="auto-style4">Id:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox12" runat="server" CssClass="campver" ReadOnly="True" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Codigo Afiliado:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="campver" ReadOnly="True" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Identificacion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Primer Nombre:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Segundo Nombre:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox4" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Primer Apellido:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox5" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Segundo Apellido:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox6" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Direccion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox7" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Telefono:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox8" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Celular:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox9" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">* Email:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox10" runat="server" CssClass="campver" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Fecha De Nacimiento:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="campver">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="campver" Width="150px">
                                                    <asp:ListItem Value="00">Mes</asp:ListItem>
                                                    <asp:ListItem Value="01">Enero</asp:ListItem>
                                                    <asp:ListItem Value="02">Febrero</asp:ListItem>
                                                    <asp:ListItem Value="03">Marzo</asp:ListItem>
                                                    <asp:ListItem Value="04">Abril</asp:ListItem>
                                                    <asp:ListItem Value="05">Mayo</asp:ListItem>
                                                    <asp:ListItem Value="06">Junio</asp:ListItem>
                                                    <asp:ListItem Value="07">Julio</asp:ListItem>
                                                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                                                    <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                                                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="campver">
                                                    <asp:ListItem Value="00">Dia</asp:ListItem>
                                                    <asp:ListItem>01</asp:ListItem>
                                                    <asp:ListItem>02</asp:ListItem>
                                                    <asp:ListItem>03</asp:ListItem>
                                                    <asp:ListItem>04</asp:ListItem>
                                                    <asp:ListItem>05</asp:ListItem>
                                                    <asp:ListItem>06</asp:ListItem>
                                                    <asp:ListItem>07</asp:ListItem>
                                                    <asp:ListItem>08</asp:ListItem>
                                                    <asp:ListItem>09</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Pais:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" CssClass="campver" Width="300px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Departamento:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True" CssClass="campver" Width="300px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Ciudad:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList8" runat="server" CssClass="campver" Width="300px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">Estado</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList5" runat="server" CssClass="campver" Width="300px">
                                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                                    <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" style="color: #FF0000; font-size: small" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style4">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="Button1" runat="server" Height="30px" style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" Text="Actualizar Datos" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" style="color: #FF0000; font-size: small"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                        BorderWidth="1px" Height="250px" Width="462px">
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
                                                        style="font-family: 'Courier New', Courier, monospace" Text="Pais" 
                                                        Visible="False" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="230px" 
                                                        Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style14" colspan="2">
                                                    Ingrese el dato a buscar y pulse el boton &quot;Buscar Datos&quot;</td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2">
                                                    <asp:TextBox ID="TextBox11" runat="server" Width="300px" CssClass="campver"></asp:TextBox>
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
                                    <asp:Panel ID="Panel3" runat="server" Height="350px" ScrollBars="Vertical" 
                                        Width="100%">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" style="font-size: x-small" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" ButtonType="Button" >
                                                <ControlStyle CssClass="botones" />
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:CommandField>
                                                <asp:BoundField DataField="id" HeaderText="Id" />
                                                <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                                                <asp:BoundField DataField="identificacion" HeaderText="Identificación" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
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

