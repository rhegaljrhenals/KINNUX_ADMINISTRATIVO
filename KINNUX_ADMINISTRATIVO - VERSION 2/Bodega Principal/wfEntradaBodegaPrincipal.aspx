<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfEntradaBodegaPrincipal.aspx.vb" Inherits="Bodega_Principal_wfEntradaBodegaPrincipal" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        height: 17px;
    }
        .style13
        {
            font-family: "Courier New", Courier, monospace;
            font-weight: bold;
            color: #0000FF;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
            height: 35px;
            width: 38px;
        }
        
        .style15
        {
            color: #000066;
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


                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/nuevo.png" Height="40px" 
                                        ToolTip="Nuevo" Width="40px" ID="ImageButton11"></asp:ImageButton>

                                    


                <br />
              </td>
            <td width="5%" align="center">

                                    


                                    <asp:ImageButton runat="server" 
                    ImageUrl="~/Imagenes/guardar.png" Height="40px" ToolTip="Grabar Entrada" 
                    Width="40px" ID="ImageButton12"></asp:ImageButton>

                                    


                                </td>
                          <td width="90%">Entrada De Productos</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style16">
        <tr>
            <td align="left">
                        

                        <table cellpadding="0" cellspacing="0" class="style1" 
                    __designer:mapid="cd2" style="width: 100%">
                            

                            <tr __designer:mapid="cd7">
                                

                                <td colspan="2" __designer:mapid="cd8">
                                    

                                    <asp:Panel runat="server" BorderColor="Red" BorderWidth="1px" 
                                        BorderStyle="Groove" Height="120px" ID="panelError">
                                        

                                        <img alt="" class="style13" src="../Imagenes/xkill.png" />

                                        <asp:Label runat="server" ID="Label14" style="color: #FF0000">Errores Encontrados</asp:Label>

                                        


                                        <br />
                                        

                                        <asp:Label runat="server" ID="Label15" style="color: #FF0000"></asp:Label>

                                        


                                        <br />
                                        

                                        <br />
                                        

                                        <br />
                                        

                                    </asp:Panel>

                                    


                                </td>
                                

                            </tr>
                            

                            <tr __designer:mapid="ce1">
                                

                                <td __designer:mapid="ce2">
                                    

                                    </td>
                                

                                <td __designer:mapid="ce3">
                                    

                                    </td>
                                

                            </tr>
                            

                            <tr __designer:mapid="ce4">
                                

                                <td colspan="2" __designer:mapid="ce5">
                                    

                                    <asp:UpdatePanel runat="server" ID="UpdatePanel1"><ContentTemplate>
                                            

                                            <table cellpadding="0" cellspacing="0" class="style1" 
                                                style="font-family: 'Courier New', Courier, monospace; width: 100%;">
                                                

                                                <tr>
                                                    

                                                    <td>
                                                        

                                                        &nbsp;</td>
                                                    

                                                    <td>
                                                        

                                                        &nbsp;</td>
                                                    

                                                </tr>
                                                

                                                <tr>
                                                    <td colspan="2">
                                                        <table class="style16">
                                                            <tr>
                                                                <td valign="top">
                                                                    <table class="style16">
                                                                        <tr>
                                                                            <td>Proveedor:</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="campver" Width="250px">
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>Numero De Guia:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="campver" Width="250px"></asp:TextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>Fecha:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox6" runat="server" CssClass="campver"></asp:TextBox>
                                                                                <asp:CalendarExtender ID="TextBox6_CalendarExtender" runat="server" BehaviorID="TextBox6_CalendarExtender" Format="yyyy/MM/dd" PopupButtonID="ImageButton13" TargetControlID="TextBox6" />
                                                                                <asp:ImageButton ID="ImageButton13" runat="server" Height="30px" ImageUrl="~/images/calendario_imagen.png" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList4" runat="server" Visible="False">
                                                                                </asp:DropDownList>
                                                                                <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
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
                                                                                <asp:DropDownList ID="DropDownList3" runat="server" Visible="False">
                                                                                    <asp:ListItem>Dia</asp:ListItem>
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
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                                <td>&nbsp;</td>
                                                                <td>
                                                                    <asp:Panel ID="Panel2" runat="server" Height="400px" ScrollBars="Vertical">
                                                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="font-size: small" Width="100%">
                                                                            <Columns>
                                                                                <asp:TemplateField HeaderText="Seleccione">
                                                                                    <ItemTemplate>
                                                                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                                    </ItemTemplate>
                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                </asp:TemplateField>
                                                                                <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                                                                <asp:BoundField DataField="nombreproducto" HeaderText="Nombres Productos" />
                                                                                <asp:TemplateField HeaderText="# Cajas">
                                                                                    <ItemTemplate>
                                                                                        <asp:TextBox ID="TextBox4" runat="server" style="text-align: right" Width="50px" CssClass="campver"></asp:TextBox>
                                                                                        <asp:FilteredTextBoxExtender ID="TextBox4_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox4" />
                                                                                    </ItemTemplate>
                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                </asp:TemplateField>
                                                                                <asp:TemplateField HeaderText="Unidades x Cajas">
                                                                                    <ItemTemplate>
                                                                                        <asp:TextBox ID="TextBox5" runat="server" style="text-align: right" Width="80px" CssClass="campver"></asp:TextBox>
                                                                                        <asp:FilteredTextBoxExtender ID="TextBox5_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox5" />
                                                                                    </ItemTemplate>
                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                </asp:TemplateField>
                                                                                <asp:BoundField DataField="precioProductoPais" HeaderText="Precio">
                                                                                <ItemStyle HorizontalAlign="Right" />
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
                                                                <td colspan="3">&nbsp;</td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                

                                            </table>
                                            
 
                                            
                                        
</ContentTemplate>
</asp:UpdatePanel>

                                    


                                </td>
                                

                            </tr>
                            

                        </table>
                        
 
                        
                    </td>
        </tr>
    </table>
    <br />
</asp:Content>

