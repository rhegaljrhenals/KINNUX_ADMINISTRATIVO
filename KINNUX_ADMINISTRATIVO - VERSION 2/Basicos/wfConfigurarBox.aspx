<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConfigurarBox.aspx.vb" Inherits="Basicos_wfConfigurarBox" %>

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
        .auto-style1 {
            width: 230px;
        }
        .auto-style2 {
            width: 230px;
            height: 27px;
        }
        .auto-style3 {
            height: 27px;
        }
        .auto-style4 {
            width: 230px;
            height: 31px;
        }
        .auto-style5 {
            height: 31px;
        }
        .auto-style6 {
        }
        .auto-style7 {
            height: 19px;
        }
        .auto-style8 {
            height: 19px;
        }
        .auto-style11 {
            height: 29px;
        }
        .auto-style13 {
        }
        .auto-style14 {
            width: 65px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style16 {
            height: 25px;
        }
        .auto-style23 {
            width: 230px;
            height: 32px;
        }
        .auto-style24 {
            height: 32px;
        }
        .auto-style25 {
            width: 230px;
            height: 29px;
        }
        .auto-style26 {
            width: 188px;
        }
        .auto-style27 {
            width: 188px;
            height: 21px;
        }
        .auto-style28 {
            height: 21px;
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
              <td width="5%" align="center">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar" Width="40px" />

              </td>
              <td width="5%" align="center">
                                    <asp:ImageButton ID="ImageButton14" runat="server" Height="40px" 
                                        ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar Excell" Width="40px" />

              </td>
                          <td width="90%">Configurar Box</td>
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
            <td class="auto-style16" align="left" colspan="2">
                <asp:CheckBox ID="CheckBox3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Es Paquete De Promoción?" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left">
                
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table class="style20">
                            <tr>
                                <td valign="top">
                                    

                                    <div style="padding:2px">
                                        <span>Fecha Inicial</span><br />
                                            <asp:TextBox ID="TextBox14" runat="server" CssClass="campver" style="margin-left: 0px" ></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox14_CalendarExtender" runat="server" Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton12" TargetControlID="TextBox14">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton12" runat="server" Height="20px" ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                                <asp:TextBox ID="TextBox7" runat="server" BackColor="#CCCCCC" CssClass="campver" ReadOnly="True" Visible="False" Width="10px"></asp:TextBox>
                                            
                                    </div>
                                    <div style="padding:2px">
                                        <span>Fecha Final: </span><br />
                                             <asp:TextBox ID="TextBox15" runat="server" CssClass="campver" style="margin-left: 0px" ></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox15_CalendarExtender" runat="server" Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton13" TargetControlID="TextBox15">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton13" runat="server" Height="20px" ImageUrl="~/images/calendario_imagen.png" Width="20px" />
                                           
                                    </div>

                                    <div style="padding:2px">
                                        <span>Tipo De Promocion: </span><br />
                                        <asp:DropDownList ID="DropDownList28" runat="server" AutoPostBack="True" CssClass="campver" style="margin-left: 0px" >
                                                    <asp:ListItem Value="N">Seleccione El Tipo De Promocion</asp:ListItem>
                                                    <asp:ListItem Value="P">Promocion Para El Pais</asp:ListItem>
                                                    <asp:ListItem Value="S">Promocion Para Sucursal</asp:ListItem>
                                                    <asp:ListItem Value="E">Promocion Para El Evento</asp:ListItem>
                                                </asp:DropDownList>
                                             <asp:Label ID="Label24" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                           
                                    </div>

                                     <div style="padding:2px">
                                         <span><asp:Label ID="Label22" runat="server" Text="Pais:"></asp:Label> </span><br />
                                         <asp:DropDownList ID="DropDownList26" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="1" Width="300px" style="margin-left: 0px" >
                                        </asp:DropDownList>
                                        <asp:Label ID="Label25" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                     </div>

                                    <div style="padding:2px">
                                        <span><asp:Label ID="Label23" runat="server" Text="Sucursal: "></asp:Label></span><br />
                                        <asp:DropDownList ID="DropDownList27" runat="server" CssClass="campver" TabIndex="2" Width="300px" style="margin-left: 0px" >
                                        </asp:DropDownList>
                                        <asp:Label ID="Label26" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                           
                                    </div>

                                    <div style="padding:2px">
                                        <span><asp:Label ID="Label28" runat="server" Text="Evento:"></asp:Label> </span><br />
                                          <asp:DropDownList ID="DropDownList25" runat="server" CssClass="campver" TabIndex="3" Width="300px" style="margin-left: 0px" >
                                          </asp:DropDownList>
                                          <asp:Label ID="Label20" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                    </div>

                                    <div style="padding:2px">
                                        <span>No De Productos Base: </span><br />
                                               <asp:TextBox ID="TextBox17" runat="server" CssClass="campver" TabIndex="5" Width="100px" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox17_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox17">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label27" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                    </div>

                                    <div style="padding:2px">
                                        <span>No De Productos En Promoción: </span><br />
                                             <asp:TextBox ID="TextBox16" runat="server" CssClass="campver" TabIndex="6" Width="100px" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox16_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox16">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label21" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                           
                                        </div>

                                    <div style="padding:2px">
                                        <span>No Productos En Obsequios: </span><br />
                                          <asp:TextBox ID="TextBox19" runat="server" CssClass="campver" TabIndex="6" Width="100px" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox19_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox19">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label31" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                          
                                    </div>

                                    <div style="padding:2px">
                                        <span>Puntos Box: </span><br />
                                              <asp:TextBox ID="TextBox18" runat="server" CssClass="campver" TabIndex="7" Width="100px" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:Label ID="Label30" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                          
                                        </div>

                                    <div style="padding:2px">
                                        <span>Token: </span><br />
                                             <asp:TextBox ID="TextBox25" runat="server" CssClass="campver" style="margin-left: 0px;text-align:right" TabIndex="7" Width="100px"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox25_FilteredTextBoxExtender" runat="server" BehaviorID="TextBox25_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="TextBox25" />
                                           
                                        </div>

                                    <div style="padding:2px">
                                        <span>Numero De Ciclos: </span><br />
                                               <asp:TextBox ID="TextBox22" runat="server" CssClass="campver" TabIndex="10" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox22_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox22" />
                                                <asp:Label ID="Label33" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                         
                                        </div>

                                    <div style="padding:2px">
                                        <span>Referencia Box: </span><br />
                                            <asp:TextBox ID="TextBox20" runat="server" CssClass="campver" style="margin-left: 0px" TabIndex="9" Width="250px"></asp:TextBox>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Nombre Paquete Box: </span><br />
                                             <asp:TextBox ID="TextBox1" runat="server" CssClass="campver" style="margin-left: 0px" TabIndex="9" Width="400px"></asp:TextBox>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Valor Box Moneda Local: </span><br />
                                             <asp:TextBox ID="TextBox2" runat="server" CssClass="campver" TabIndex="10" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox2">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label18" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                           
                                        </div>

                                    <div style="padding:2px">
                                        <span>Valor Box USD: </span><br />
                                             <asp:TextBox ID="TextBox21" runat="server" CssClass="campver" TabIndex="10" style="margin-left: 0px;text-align:right" ></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox21_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox21">
                                                </asp:FilteredTextBoxExtender>
                                                <asp:Label ID="Label32" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                           
                                        </div>

                                    <h2 style="color:blue">Configuración Box</h2><br />

                                         <asp:Label ID="Label36" runat="server" style="color: #FF0000" Text="* Configure el paquete correctamente...!"></asp:Label>
                                           

                                    <div style="padding:2px">
                                        <span>Es Paquete De Inicio:? </span><br />
                                        <asp:DropDownList ID="DropDownList29" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="4">
                                            <asp:ListItem Value="s">Si</asp:ListItem>
                                            <asp:ListItem Value="n">No</asp:ListItem>
                                        </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Es Kit Basico:? </span><br />
                                        <asp:DropDownList ID="DropDownList37" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="4">
                                                                <asp:ListItem Value="S">Si</asp:ListItem>
                                                                <asp:ListItem Value="N">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Es Upgrade:? </span><br />
                                        <asp:DropDownList ID="DropDownList32" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="s">Si</asp:ListItem>
                                                                <asp:ListItem Value="n">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Es Inicio Express:? </span><br />
                                        <asp:DropDownList ID="DropDownList31" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="s">Si</asp:ListItem>
                                                                <asp:ListItem Value="n">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Es Recompra:? </span><br />
                                        <asp:DropDownList ID="DropDownList34" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="s">Si</asp:ListItem>
                                                                <asp:ListItem Value="n">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Acumula Millas:? </span><br />
                                                 <asp:DropDownList ID="DropDownList30" runat="server" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="s">Si</asp:ListItem>
                                                                <asp:ListItem Value="n">No</asp:ListItem>
                                                            </asp:DropDownList>
                                                            <asp:Label ID="Label17" runat="server" style="color: #FF0000" Text="* Requerido"></asp:Label>
                                                   
                                        </div>

                                    <div style="padding:2px">
                                        <span>Es Paquete Controlado:? </span><br />
                                        <asp:DropDownList ID="DropDownList36" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="S">Si</asp:ListItem>
                                                                <asp:ListItem Value="N">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>Activa Millas:? </span><br />
                                         <asp:DropDownList ID="DropDownList33" runat="server" AutoPostBack="True" CssClass="campver" TabIndex="8">
                                                                <asp:ListItem Value="s">Si</asp:ListItem>
                                                                <asp:ListItem Value="n">No</asp:ListItem>
                                                            </asp:DropDownList>
                                        </div>

                                    <div style="padding:2px">
                                        <span>    <asp:Label ID="Label37" runat="server" Text="No Periodo:"></asp:Label>
                                                         </span><br />
                                                <asp:TextBox ID="TextBox23" runat="server" CssClass="campver" Width="50px"></asp:TextBox>
                                                            <asp:FilteredTextBoxExtender ID="TextBox23_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox23" />
                                                    

                                        </div>

                                     <div style="padding:2px">
                                        <span>Estado: </span><br />
                                         <asp:DropDownList ID="DropDownList24" runat="server" CssClass="campver" Width="250px">
                                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                                    <asp:ListItem Value="0">Eliminado</asp:ListItem>
                                                </asp:DropDownList>
                                         </div>

                                    <asp:Label ID="Label34" runat="server" style="color: #FF0000" Text="* Debe seleccionar los productos e ingresar la cantidad...!"></asp:Label>
                                    
                                </td>
                                <td>&nbsp;</td>
                                <td align="center" style="text-align: left" valign="top">
                                    <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" TabIndex="11" Text="Seleccionar Todos" />
                                    <br />
                                    <asp:Label ID="Label29" runat="server" style="color: #FF0000" Text="* Debe seleccionar los productos e ingresar la cantidad...!"></asp:Label>
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Height="650px" ScrollBars="Vertical" Width="550px">
                                        <table class="style20">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" TabIndex="12" Width="100%">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Seleccione">
                                                                <ItemTemplate>
                                                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="idProducto" HeaderText="Id" />
                                                            <asp:BoundField DataField="nombreProducto" HeaderText="Nombre Producto" />
                                                            <asp:TemplateField HeaderText="Cantidad">
                                                                <ItemTemplate>
                                                                    <asp:TextBox ID="TextBox24" runat="server" CssClass="campver" Width="50px" style="margin-left: 0px"></asp:TextBox>
                                                                    <asp:FilteredTextBoxExtender ID="TextBox24_FilteredTextBoxExtender" runat="server" BehaviorID="TextBox24_FilteredTextBoxExtender" FilterType="Numbers" TargetControlID="TextBox24" />
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="tokenproducto" HeaderText="Token">
                                                            <ItemStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
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
                                    <br />

                                    <asp:Button ID="Button1" runat="server" Text="Calcular" style="margin-left: 0px" />

                                    <h2>Total Cantidad: 
                                    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                                    </h2>

                                    <h2>Total Token: 
                                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                                    </h2>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <table class="style20">
                            <tr>
                                <td>
                                    <table class="style20">
                                        <tr>
                                            <td class="auto-style6">
                                                <table class="style20">
                                                    <tr>
                                                        <td class="auto-style14">Sucursal:</td>
                                                        <td class="auto-style15">
                                                            <asp:DropDownList ID="DropDownList35" runat="server" style="margin-left: 0px" Width="350px">
                                                            </asp:DropDownList>
                                                            <asp:Button ID="Button5" runat="server" Text="Mostrar" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style13">&nbsp;</td>
                                                        <td>
                                                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="Paquete" />
                                                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="Promoción" />
                                                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" Text="Todos" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style13" colspan="2">
                                                            <asp:Label ID="Label35" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Height="450px" ScrollBars="Both" Width="100%">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" ButtonType="Button" >
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                </asp:CommandField>
                                                <asp:BoundField DataField="idbox" HeaderText="Id" />
                                                <asp:BoundField DataField="referenciabox" HeaderText="Referencia" />
                                                <asp:BoundField DataField="nombrebox" HeaderText="Nombre Box" />
                                                <asp:BoundField DataField="fechaibox" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Inicio" />
                                                <asp:BoundField DataField="fechafbox" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Final" />
                                                <asp:BoundField DataField="valormlbox" DataFormatString="{0:N0}" HeaderText="Valor Local">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorusdbox" DataFormatString="{0:N0}" HeaderText="Valor USD">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="puntosbox" HeaderText="Puntos">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="tokenbox" HeaderText="Token">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="nombreempresa" HeaderText="Sucursal" />
                                                <asp:BoundField DataField="basebox" HeaderText="No Productos Base" >
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="promobox" HeaderText="No Productos Promocion" >
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="obsqbox" HeaderText="No Productos Obsequio" >
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                
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
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
                
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

