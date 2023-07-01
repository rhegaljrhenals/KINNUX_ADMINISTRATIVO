<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPaquetes.aspx.vb" Inherits="Basicos_wfPaquetes" %>

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
        .style22
        {
            color: #000066;
            }
        .style23
        {
            color: #006699;
        }
        .style24
        {
            width: 100%;
        }
        .style25
        {
            width: 156px;
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
                                                        Height="40px" ToolTip="Grabar" Width="40px" 
                                  ID="ImageButton8">
                    </asp:ImageButton>

              </td>
          <td width="5%" align="center">

                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Buscar" Width="40px" 
                                  ID="ImageButton9">
                    </asp:ImageButton>

              </td>
                          <td width="90%">Paquetes</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style24">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView2" runat="server">
                    <asp:View ID="View3" runat="server">
                        <table <tr="" cellpadding="2" cellspacing="0" class="style1" 
                            style="width: 100%">
                            <tr>
                                <td align="left">
                                    <asp:Panel ID="panelError" runat="server" BorderColor="Red" 
                                        BorderStyle="Groove" BorderWidth="1px" Height="131px" ScrollBars="Vertical">
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
                                            <table cellpadding="2" cellspacing="0" class="style1" style="width: 100%">
                                                <tr>
                                                    <td class="style22">
                                                        <table class="style24" style="width: 100%">
                                                            <tr>
                                                                <td colspan="2">
                                                                    <table class="style24">
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Id:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Nombre Paquete:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                                                                    Width="350px"></asp:TextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Puntos:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox3" runat="server" style="text-align: right" 
                                                                                    Width="80px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox3">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Estado:</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList25" runat="server" Width="250px">
                                                                                    <asp:ListItem Value="1">Activo</asp:ListItem>
                                                                                    <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" 
                                                                                    Text="Es Ascenso?" />
                                                                            </td>
                                                                            <td>
                                                                                <asp:Panel ID="Panel12" runat="server" Height="43px" Width="414px">
                                                                                    <table cellpadding="0" cellspacing="0" class="style1">
                                                                                        <tr>
                                                                                            <td class="style23">
                                                                                                Paquete Inicial</td>
                                                                                            <td style="color: #006699">
                                                                                                Paquete Final</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <asp:DropDownList ID="DropDownList26" runat="server" Width="200px">
                                                                                                </asp:DropDownList>
                                                                                            </td>
                                                                                            <td>
                                                                                                <asp:DropDownList ID="DropDownList27" runat="server" Width="200px">
                                                                                                </asp:DropDownList>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Es Super Paquete?</td>
                                                                            <td>
                                                                                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="4" Text="Si" />
                                                                                &nbsp;<asp:RadioButton ID="RadioButton8" runat="server" GroupName="4" Text="No" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Es Paquete De Promocion?:</td>
                                                                            <td>
                                                                                <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                                                                                    GroupName="1" Text="Si" />
                                                                                &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                                                                                    GroupName="1" Text="No" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Es Paquete Base?:</td>
                                                                            <td>
                                                                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="2" Text="Si" />
                                                                                &nbsp;<asp:RadioButton ID="RadioButton4" runat="server" GroupName="2" Text="No" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Es SuperTS?</td>
                                                                            <td>
                                                                                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="3" Text="Si" />
                                                                                &nbsp;<asp:RadioButton ID="RadioButton6" runat="server" GroupName="3" Text="No" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                Numeros De TS que tiene este paquete:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox17" runat="server" style="text-align: right" 
                                                                                    Width="50px">0</asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox17_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox17">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style25">
                                                                                &nbsp;</td>
                                                                            <td>
                                                                                <asp:Panel ID="Panel13" runat="server" Height="50px">
                                                                                    <table class="style24">
                                                                                        <tr>
                                                                                            <td>
                                                                                                Este paquete de promocion es equivalente a este paquete:</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <asp:DropDownList ID="DropDownList28" runat="server" Width="300px">
                                                                                                </asp:DropDownList>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </asp:Panel>
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
                                                                <td>
                                                                    <table class="style24">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                                    BorderWidth="1px" Height="315px" ScrollBars="Both" Width="400px">
                                                                                    <table class="style24">
                                                                                        <tr>
                                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006666">
                                                                                                Productos</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <span>
                                                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                    CellPadding="3" style="font-size: small">
                                                                                                    <Columns>
                                                                                                        <asp:TemplateField>
                                                                                                            <ItemTemplate>
                                                                                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                                                            </ItemTemplate>
                                                                                                            <ItemStyle Width="50px" />
                                                                                                        </asp:TemplateField>
                                                                                                        <asp:BoundField DataField="idProducto" HeaderText="Id">
                                                                                                        <ItemStyle Width="50px" />
                                                                                                        </asp:BoundField>
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
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <span>
                                                                                    <br />
                                                                                    </span>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #FFFFFF">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                                    BorderWidth="1px" Height="315px" ScrollBars="Both" Width="400px">
                                                                                    <table class="style24">
                                                                                        <tr>
                                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006666">
                                                                                                Papelerias</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <span>
                                                                                                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                    CellPadding="3" style="font-size: small">
                                                                                                    <Columns>
                                                                                                        <asp:TemplateField>
                                                                                                            <ItemTemplate>
                                                                                                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                                                                                            </ItemTemplate>
                                                                                                            <ItemStyle Width="50px" />
                                                                                                        </asp:TemplateField>
                                                                                                        <asp:BoundField DataField="idPapeleria" HeaderText="Id">
                                                                                                        <ItemStyle Width="50px" />
                                                                                                        </asp:BoundField>
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
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <span>
                                                                                    <br />
                                                                                    </span>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #FFFFFF">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Panel ID="Panel4" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                                    BorderWidth="1px" Height="315px" ScrollBars="Both" Width="400px">
                                                                                    <table class="style24">
                                                                                        <tr>
                                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006666">
                                                                                                Premios</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <span>
                                                                                                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                    CellPadding="3" style="font-size: small">
                                                                                                    <Columns>
                                                                                                        <asp:TemplateField>
                                                                                                            <ItemTemplate>
                                                                                                                <asp:CheckBox ID="CheckBox3" runat="server" />
                                                                                                            </ItemTemplate>
                                                                                                        </asp:TemplateField>
                                                                                                        <asp:BoundField DataField="idPremio" HeaderText="Id" />
                                                                                                        <asp:BoundField DataField="nombrepremio" HeaderText="Nombres" />
                                                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                                                            <ItemTemplate>
                                                                                                                <asp:TextBox ID="TextBox13" runat="server" Width="50px"></asp:TextBox>
                                                                                                                <asp:FilteredTextBoxExtender ID="TextBox13_FilteredTextBoxExtender" 
                                                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox13">
                                                                                                                </asp:FilteredTextBoxExtender>
                                                                                                            </ItemTemplate>
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
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <span>
                                                                                    <br />
                                                                                    </span>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #FFFFFF">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Panel ID="Panel5" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                                                    BorderWidth="1px" Height="315px" ScrollBars="Both" Width="400px">
                                                                                    <table class="style24">
                                                                                        <tr>
                                                                                            <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006666">
                                                                                                Equipos Medicos</td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <span>
                                                                                                <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                                    CellPadding="3" style="font-size: small">
                                                                                                    <Columns>
                                                                                                        <asp:TemplateField>
                                                                                                            <ItemTemplate>
                                                                                                                <asp:CheckBox ID="CheckBox4" runat="server" />
                                                                                                            </ItemTemplate>
                                                                                                        </asp:TemplateField>
                                                                                                        <asp:BoundField DataField="idEquipoM" HeaderText="Id" />
                                                                                                        <asp:BoundField DataField="nombreEquipom" HeaderText="Nombres" />
                                                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                                                            <ItemTemplate>
                                                                                                                <asp:TextBox ID="TextBox14" runat="server" Width="50px"></asp:TextBox>
                                                                                                                <asp:FilteredTextBoxExtender ID="TextBox14_FilteredTextBoxExtender" 
                                                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox14">
                                                                                                                </asp:FilteredTextBoxExtender>
                                                                                                            </ItemTemplate>
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
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <span>
                                                                                    <br />
                                                                                    </span>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                                <td valign="top">
                                                                    <asp:Panel ID="Panel11" runat="server" BorderColor="#CCCCCC" 
                                                                        BorderStyle="Solid" BorderWidth="1px" Height="1335px" ScrollBars="Vertical">
                                                                        <table class="style24">
                                                                            <tr>
                                                                                <td style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006666">
                                                                                    Precios Por Paises</td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="center">
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
                                                                                            <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                                                                            <asp:BoundField DataField="nombreempresa" HeaderText="Empresas" />
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
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <br />
                                                                    </asp:Panel>
                                                                </td>
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
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <asp:Panel ID="Panel10" runat="server" Height="400px" ScrollBars="Vertical" 
                            Width="100%">
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" style="font-size: small" Width="100%">
                                <Columns>
                                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                                    <asp:BoundField DataField="idPaquete" HeaderText="Id" />
                                    <asp:BoundField DataField="nombrePaquete" HeaderText="Nombre Paquete" />
                                    <asp:BoundField DataField="puntosPaquete" HeaderText="Puntos Paquete">
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
                </asp:MultiView>
            </td>
        </tr>
    </table>
</asp:Content>

