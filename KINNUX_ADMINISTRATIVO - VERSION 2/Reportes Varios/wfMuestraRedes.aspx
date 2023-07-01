<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfMuestraRedes.aspx.vb" Inherits="Reportes_Varios_wfMuestraRedes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            color: #006699;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">
                                        <asp:ImageButton runat="server" 
                        ImageUrl="~/images/red_uni.png" Height="40px" ToolTip="Red Uninivel" 
                        Width="40px" ID="ImageButton7"></asp:ImageButton>

              </td>
          <td width="5%" align="center">

                                        <asp:ImageButton runat="server" 
                        ImageUrl="~/images/red_binaria.png" Height="40px" ToolTip="Red Binaria" 
                        Width="40px" ID="ImageButton8"></asp:ImageButton>

              </td>
          <td width="5%" align="center">

                    &nbsp;</td>
                          <td width="90%">Consultar Redes</td>
            </tr>
          </table></td>
      </tr>
    </table>
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="width: 100%; font-family: 'Courier New', Courier, monospace;">
            <tr>
                <td align="left">
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                Codigo:</td>
                            <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>
                                    <asp:ImageButton ID="ImageButton9" runat="server" Height="30px" 
                                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar" Width="30px" />
                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Periodo:</td>
                            <td>
                                <table class="style1">
                                    <tr>
                                        <td class="style2">
                                            Mes:</td>
                                        <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
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
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Año:</td>
                                        <td>
                                            <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
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
                    </table>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="View1" runat="server">
                            <table cellpadding="0" cellspacing="0" class="style1">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="Panel1" runat="server" Height="1000px" ScrollBars="Vertical">
                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" CssClass="Grid" style="font-size: small">
                                                <Columns>
                                                    <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo">
                                                    <HeaderStyle Width="100px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="identificacion" HeaderText="Identificacion" 
                                                        Visible="False" />
                                                    <asp:BoundField DataField="apellidosynombre" HeaderText="Apellidos y Nombres">
                                                    <HeaderStyle Width="300px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="codigopatrocinador" HeaderText="Patrocinador">
                                                    <HeaderStyle Width="100px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="directo" HeaderText="Apalancado" Visible="False" />
                                                    <asp:BoundField DataField="posicion" HeaderText="Posicion" Visible="False" />
                                                    <asp:BoundField DataField="indirecto" HeaderText="PIndirecto" Visible="False" />
                                                    <asp:BoundField DataField="nodo" HeaderText="Leg" Visible="False" />
                                                    <asp:BoundField DataField="Rango" HeaderText="Rango" Visible="False" />
                                                    <asp:BoundField DataField="left" HeaderText="l" Visible="False" />
                                                    <asp:BoundField DataField="right" HeaderText="r" Visible="False" />
                                                    <asp:TemplateField HeaderText="Left" Visible="False">
                                                        <ItemTemplate>
                                                            <asp:Image ID="Image1" runat="server" Height="20px" Width="20px" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Right" Visible="False">
                                                        <ItemTemplate>
                                                            <asp:Image ID="Image2" runat="server" Height="20px" Width="20px" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="email" HeaderText="Email" />
                                                    <asp:BoundField DataField="rango" HeaderText="Rango" Visible="False" />
                                                    <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                                                    <asp:BoundField DataField="puntos" HeaderText="Puntos">
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
                            </table>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            <asp:Panel ID="Panel3" runat="server" Height="1000px" ScrollBars="Vertical">
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" CssClass="tabladathead" style="font-size: small">
                                    <Columns>
                                        <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo">
                                        <HeaderStyle Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="identificacion" HeaderText="Identificacion" 
                                            Visible="False" />
                                        <asp:BoundField DataField="apellidosynombre" HeaderText="Apellidos y Nombres">
                                        <HeaderStyle Width="300px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="codigopatrocinador" HeaderText="Patrocinador">
                                        <HeaderStyle Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="directo" HeaderText="Apalancado" />
                                        <asp:BoundField DataField="posicion" HeaderText="Posicion" />
                                        <asp:BoundField DataField="indirecto" HeaderText="PIndirecto" Visible="False" />
                                        <asp:BoundField DataField="nodo" HeaderText="Leg" Visible="False" />
                                        <asp:BoundField DataField="Rango" HeaderText="Rango" Visible="False" />
                                        <asp:BoundField DataField="left" HeaderText="l" Visible="False" />
                                        <asp:BoundField DataField="right" HeaderText="r" Visible="False" />
                                        <asp:TemplateField HeaderText="Left" Visible="False">
                                            <ItemTemplate>
                                                <asp:Image ID="Image3" runat="server" Height="20px" Width="20px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Right" Visible="False">
                                            <ItemTemplate>
                                                <asp:Image ID="Image4" runat="server" Height="20px" Width="20px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="email" HeaderText="Email" Visible="False" />
                                        <asp:BoundField DataField="rango" HeaderText="Rango" Visible="False" />
                                        <asp:BoundField DataField="puntos" HeaderText="Puntos">
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
                        </asp:View>
                        <br />
                    </asp:MultiView>
                </td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

