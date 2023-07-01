<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfKitAfiliacion.aspx.vb" Inherits="Basicos_wfPaquetes" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style13
        {
            color: #000066;
            font-weight: bold;
            height: 35px;
            width: 38px;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
        }
        .style17
        {
            color: #000066;
        }
        .style19
        {
            color: #000066;
            height: 26px;
            width: 220px;
        }
        .style20
        {
            height: 26px;
        }
        .style22
        {
            color: #000066;
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">
                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/nuevo.png" 
                                                        Height="40px" ToolTip="Nuevo" 
                  Width="40px" ID="ImageButton7">
                    </asp:ImageButton>

              </td>
          <td width="5%" align="center">

                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" 
                                                        Height="40px" ToolTip="Grabar" 
                  Width="40px" ID="ImageButton8">
                    </asp:ImageButton>

              </td>
                          <td width="90%">Kit De Afiliacion</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="2" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td align="left">
                <asp:Panel ID="panelError" 
                    runat="server" BorderColor="Red" 
                                                                        BorderStyle="Groove" 
                    BorderWidth="1px" Height="131px" ScrollBars="Vertical">
                    <img alt="" class="style13" src="../Imagenes/Remove%20Mark.png" />
                    <asp:Label ID="Label14" runat="server" style="color: #FF0000">Errores Encontrados</asp:Label>
                    <br />
                    <asp:Label ID="Label15" runat="server" style="color: #FF0000"></asp:Label>
                    <br />
                    <br />
                    <br />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <table cellpadding="2" cellspacing="0" class="style1">
                            <tr>
                                <td class="style22">
                                    id:</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style22">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style19">
                                    Nombre Kit:</td>
                                <td class="style20">
                                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                        Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style22">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style19">
                                    Puntos Kit:</td>
                                <td class="style20">
                                    <asp:TextBox ID="TextBox3" runat="server" style="text-align: right" 
                                        Width="80px"></asp:TextBox>
                                    <asp:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox3">
                                    </asp:FilteredTextBoxExtender>
                                </td>
                            </tr>
                            <tr>
                                <td class="style22">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style22">
                                    Estado:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList25" runat="server" Width="250px">
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="style22">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style17" colspan="2">
                                    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                                        Height="1209px" Width="100%">
                                        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                                            <HeaderTemplate>
                                                Configuración Kit
                                            </HeaderTemplate>
                                            <ContentTemplate>
                                                <table cellpadding="0" cellspacing="0" class="style1">
                                                    <tr>
                                                        <td align="center" style="font-weight: 700">
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" bgcolor="#C1D82F" style="font-weight: 700">
                                                            Productos</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td align="center" bgcolor="#C1D82F" style="font-weight: 700">
                                                            Papelerias</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 338px">
                                                            <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                BorderWidth="1px" Height="315px" ScrollBars="Vertical" Width="500px">
                                                                <span>
                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idProducto" HeaderText="Id" />
                                                                        <asp:BoundField DataField="nombreproducto" HeaderText="Nombres" />
                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox11" runat="server" Width="50px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox11_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox11">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" />
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
                                                                </span>
                                                            </asp:Panel>
                                                        </td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td style="width: 338px" valign="top">
                                                            <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                BorderWidth="1px" Height="315px" ScrollBars="Vertical" Width="500px">
                                                                <span>
                                                                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idPapeleria" HeaderText="Id" />
                                                                        <asp:BoundField DataField="nombrepapeleria" HeaderText="Nombres" />
                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox12" runat="server" Width="50px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox12_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox12">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" />
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
                                                                </span>
                                                            </asp:Panel>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td valign="top">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="Panel11" runat="server" Height="730px" ScrollBars="Vertical">
                                                                <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox5" runat="server" />
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="codigopais" HeaderText="Id Pais" />
                                                                        <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                                                                        <asp:TemplateField HeaderText="Precio Pais">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox15" runat="server" style="text-align: right" 
                                                                                    Width="100px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox15_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox15">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                            <HeaderStyle HorizontalAlign="Right" />
                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Precio Local">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox16" runat="server" style="text-align: right" 
                                                                                    Width="100px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox16_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox16">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Right" />
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
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                        </asp:TabPanel>
                                        <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                                            <HeaderTemplate>
                                                Consultar Kit Afiliación
                                            </HeaderTemplate>
                                            <ContentTemplate>
                                                <table cellpadding="0" cellspacing="0" class="style1">
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Panel ID="Panel10" runat="server" Height="835px">
                                                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small" Width="100%">
                                                                    <Columns>
                                                                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                                                                        <asp:BoundField DataField="idPaquete" HeaderText="Id" />
                                                                        <asp:BoundField DataField="nombrePaquete" HeaderText="Nombre Paquete" />
                                                                        <asp:BoundField DataField="puntosPaquete" HeaderText="Puntos Paquete" >
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
                                            </ContentTemplate>
                                        </asp:TabPanel>
                                    </asp:TabContainer>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        </table>
</asp:Content>

