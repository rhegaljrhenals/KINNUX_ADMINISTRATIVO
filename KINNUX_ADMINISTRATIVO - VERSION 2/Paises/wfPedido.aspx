<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPedido.aspx.vb" Inherits="Paises_wfPedido" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style12
        {
            color: #000066;
        }
        .style13
        {
            width: 47px;
            height: 34px;
        }
        .style20
    {
        color: #000066;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="2" class="style1">
        <tr>
            <td align="right" 
                style="color: #000066; font-weight: 700; background-color: #CCCCCC">
                &nbsp;Pedidos A Bodega Principal
        <strong>
        <img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="3" 
                    Height="950px" Width="100%">
                    <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                        
                        
                    <HeaderTemplate>
                            Productos
                        
</HeaderTemplate>
<ContentTemplate>
                            <table cellpadding="2" class="style1">
                                <tr>
                                    <td bgcolor="#CCCCCC">
                                        <asp:ImageButton ID="ImageButton17" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" />

                                        <asp:ImageButton ID="ImageButton18" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" />

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <table cellpadding="2" class="style1">
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="panelError" runat="server" BorderColor="Red" 
                                                                BorderStyle="Groove" BorderWidth="1px">
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
                                                        <td class="style20">
                                                            Id Pedido:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="style20" ReadOnly="True" 
                                                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                                                        </td>
                                                        <td style="color: #000066; font-weight: 700">
                                                            Pedido Producto Numero:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox25" runat="server" ReadOnly="True" 
                                                                style="font-weight: 700; color: #FF0000; text-align: right" Width="100px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Pais:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList24" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Empresas:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList35" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Fecha:</td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox24" runat="server" CssClass="style20" 
                                                                style="text-align: left" Width="120px"></asp:TextBox>
                                                            <asp:CalendarExtender ID="TextBox24_CalendarExtender" runat="server" 
                                                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton9" 
                                                                TargetControlID="TextBox24">
                                                            </asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton9" runat="server" Height="30px" 
                                                                ImageUrl="~/Imagenes/calendario.png" ToolTip="Calendario Fecha Inicio" 
                                                                Width="30px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Estado:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="style20" 
                                                                Width="220px">
                                                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                                                <asp:ListItem Value="2">Anulada</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="Panel1" runat="server" Height="650px" ScrollBars="Both">
                                                                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idcoleccion" HeaderText="Id Producto" />
                                                                        <asp:BoundField DataField="nombrecoleccion" HeaderText="Nombres Productos" />
                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox7" runat="server" style="text-align: right" 
                                                                                    Width="50px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox7_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox7">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Precio">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox26" runat="server" style="text-align: right" 
                                                                                    Width="100px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox26_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox26">
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
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="ImageButton17" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="ImageButton18" EventName="Click" />
</Triggers>
</asp:UpdatePanel>

                                    </td>
                                </tr>
                            </table>
                        
</ContentTemplate>
</asp:TabPanel>
                    <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                        
                        
                    <HeaderTemplate>
                            Premios
                        
</HeaderTemplate>
<ContentTemplate>
                            <table cellpadding="2" class="style1">
                                <tr>
                                    <td bgcolor="#CCCCCC">
                                        <asp:ImageButton ID="ImageButton19" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" />
                                        <asp:ImageButton ID="ImageButton20" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <table cellpadding="2" class="style1">
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="panelErrorPremio" runat="server" BorderColor="Red" 
                                                                BorderStyle="Groove" BorderWidth="1px">
                                                                <img alt="" class="style13" src="../Imagenes/Remove%20Mark.png" />
                                                                <asp:Label ID="Label16" runat="server" style="color: #FF0000">Errores Encontrados</asp:Label>
                                                                <br />
                                                                <asp:Label ID="Label17" runat="server" style="color: #FF0000"></asp:Label>
                                                                <br />
                                                                <br />
                                                                <br />
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Id Pedido:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox27" runat="server" CssClass="style20" ReadOnly="True" 
                                                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                                                        </td>
                                                        <td style="color: #000066; font-weight: 700">
                                                            Pedido Premio Numero:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox28" runat="server" ReadOnly="True" 
                                                                style="font-weight: 700; color: #FF0000; text-align: right" Width="100px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Pais:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList25" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Empresas:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList36" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Fecha:</td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox29" runat="server" CssClass="style20" 
                                                                style="text-align: left" Width="120px"></asp:TextBox>
                                                            <asp:CalendarExtender ID="TextBox29_CalendarExtender" runat="server" 
                                                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton21" 
                                                                TargetControlID="TextBox29">
                                                            </asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton21" runat="server" Height="30px" 
                                                                ImageUrl="~/Imagenes/calendario.png" ToolTip="Calendario Fecha Inicio" 
                                                                Width="30px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Estado:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList27" runat="server" CssClass="style20" 
                                                                Width="220px">
                                                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                                                <asp:ListItem Value="2">Anulada</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="Panel2" runat="server" Height="650px" ScrollBars="Both">
                                                                <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idPremio" HeaderText="Id Premio" />
                                                                        <asp:BoundField DataField="nombrepremio" HeaderText="Nombre Premio" />
                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox30" runat="server" style="text-align: right" 
                                                                                    Width="50px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox30_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox30">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Precio">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox31" runat="server" style="text-align: right" 
                                                                                    Width="100px"></asp:TextBox>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                    <sortedascendingcellstyle backcolor="#F1F1F1" />
                                                                    <sortedascendingheaderstyle backcolor="#007DBB" />
                                                                    <sorteddescendingcellstyle backcolor="#CAC9C9" />
                                                                    <sorteddescendingheaderstyle backcolor="#00547E" />
                                                                </asp:GridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                            <triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ImageButton19" EventName="Click" />
                                                <asp:AsyncPostBackTrigger ControlID="ImageButton20" EventName="Click" />
                                            </triggers>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
                        
</ContentTemplate>
</asp:TabPanel>
                    <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                        
                        
                    <HeaderTemplate>
                            Papelerias
                        
</HeaderTemplate>
<ContentTemplate>
                            <table cellpadding="2" class="style1">
                                <tr>
                                    <td bgcolor="#CCCCCC">
                                        <asp:ImageButton ID="ImageButton22" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" Width="50px" />
                                        <asp:ImageButton ID="ImageButton23" runat="server" Height="50px" 
                                            ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar" Width="50px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>
                                                <table cellpadding="2" class="style1">
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="panelErrorPapeleria" runat="server" BorderColor="Red" 
                                                                BorderStyle="Groove" BorderWidth="1px">
                                                                <img alt="" class="style13" src="../Imagenes/Remove%20Mark.png" />
                                                                <asp:Label ID="Label18" runat="server" style="color: #FF0000">Errores Encontrados</asp:Label>
                                                                <br />
                                                                <asp:Label ID="Label19" runat="server" style="color: #FF0000"></asp:Label>
                                                                <br />
                                                                <br />
                                                                <br />
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Id Pedido:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox32" runat="server" CssClass="style20" ReadOnly="True" 
                                                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                                                        </td>
                                                        <td style="color: #000066; font-weight: 700">
                                                            Pedido Papeleria Numero:</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox33" runat="server" ReadOnly="True" 
                                                                style="font-weight: 700; color: #FF0000; text-align: right" Width="100px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Pais:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList28" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Empresas:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList37" runat="server" AutoPostBack="True" 
                                                                Width="220px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Fecha:</td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="TextBox34" runat="server" CssClass="style20" 
                                                                style="text-align: left" Width="120px"></asp:TextBox>
                                                            <asp:CalendarExtender ID="TextBox34_CalendarExtender" runat="server" 
                                                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton24" 
                                                                TargetControlID="TextBox34">
                                                            </asp:CalendarExtender>
                                                            <asp:ImageButton ID="ImageButton24" runat="server" Height="30px" 
                                                                ImageUrl="~/Imagenes/calendario.png" ToolTip="Calendario Fecha Inicio" 
                                                                Width="30px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style20">
                                                            Estado:</td>
                                                        <td colspan="3">
                                                            <asp:DropDownList ID="DropDownList30" runat="server" CssClass="style20" 
                                                                Width="220px">
                                                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                                                <asp:ListItem Value="2">Anulada</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="4">
                                                            <asp:Panel ID="Panel3" runat="server" Height="650px" ScrollBars="Both">
                                                                <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                                                    <Columns>
                                                                        <asp:TemplateField>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="CheckBox3" runat="server" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="idpapeleria" HeaderText="Id" />
                                                                        <asp:BoundField DataField="nombrepapeleria" HeaderText="Nombre Papeleria" />
                                                                        <asp:TemplateField HeaderText="Cantidad">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox35" runat="server" style="text-align: right" 
                                                                                    Width="50px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox35_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox35">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Precio">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="TextBox36" runat="server" style="text-align: right" 
                                                                                    Width="100px"></asp:TextBox>
                                                                                <asp:FilteredTextBoxExtender ID="TextBox36_FilteredTextBoxExtender" 
                                                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox36">
                                                                                </asp:FilteredTextBoxExtender>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                    </Columns>
                                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                    <RowStyle ForeColor="#000066" />
                                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                    <sortedascendingcellstyle backcolor="#F1F1F1" />
                                                                    <sortedascendingheaderstyle backcolor="#007DBB" />
                                                                    <sorteddescendingcellstyle backcolor="#CAC9C9" />
                                                                    <sorteddescendingheaderstyle backcolor="#00547E" />
                                                                </asp:GridView>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                            <triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ImageButton22" EventName="Click" />
                                                <asp:AsyncPostBackTrigger ControlID="ImageButton23" EventName="Click" />
                                            </triggers>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
                        
</ContentTemplate>
</asp:TabPanel>
                    <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="TabPanel4">
                        
                        
                    <HeaderTemplate>
                            Consulta General
                        
</HeaderTemplate>
<ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <table cellpadding="2" class="style1">
                                        <tr>
                                            <td bgcolor="#CCCCCC">
                                                <asp:ImageButton ID="ImageButton25" runat="server" Height="50px" 
                                                    ImageUrl="~/Imagenes/productos.png" ToolTip="Productos" Width="50px" />
                                                <asp:ImageButton ID="ImageButton26" runat="server" Height="50px" 
                                                    ImageUrl="~/Imagenes/premios.png" ToolTip="Premios" Width="50px" />
                                                <asp:ImageButton ID="ImageButton27" runat="server" Height="50px" 
                                                    ImageUrl="~/Imagenes/papeleria.png" ToolTip="Papelerias" Width="50px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:MultiView ID="MultiView1" runat="server">
                                                    <asp:View ID="vistaProducto" runat="server">
                                                        <table cellpadding="2" class="style1">
                                                            <tr>
                                                                <td bgcolor="#006699" style="color: #FFFFFF; font-weight: 700">
                                                                    Pedidos De Productos</td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <table cellpadding="2" class="style1">
                                                                        <tr>
                                                                            <td class="style20">
                                                                                <asp:Button ID="Button4" runat="server" Text="Consultar General" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                            <td>
                                                                                &#160;</td>
                                                                            <td>
                                                                                &#160;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Seleccione Pais:</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList31" runat="server" Width="220px">
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button1" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Numero De Pedido:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox37" runat="server" style="text-align: right"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button2" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Numero De Pedido" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Fecha Inicial:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox38" runat="server" Width="100px"></asp:TextBox>
                                                                                &#160;<span class="style20">Fecha Final:</span>
                                                                                <asp:CalendarExtender ID="TextBox38_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox38">
                                                                                </asp:CalendarExtender>
                                                                                <asp:TextBox ID="TextBox39" runat="server" Width="100px"></asp:TextBox>
                                                                                <asp:CalendarExtender ID="TextBox39_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox39">
                                                                                </asp:CalendarExtender>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button3" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Entre Fechas" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <asp:Panel ID="Panel4" runat="server" Height="650px" ScrollBars="Both">
                                                                        <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" 
                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                            CellPadding="3" style="font-size: x-small" Width="100%">
                                                                            <Columns>
                                                                                <asp:CommandField ShowSelectButton="True" />
                                                                                <asp:BoundField DataField="idEncabezadopedido" HeaderText="Id" />
                                                                                <asp:BoundField DataField="consecutivopedido" HeaderText="Numero" />
                                                                                <asp:BoundField DataField="idempresa" HeaderText="Id Empresa" />
                                                                                <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                                                                <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                                                                <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                                                                                <asp:BoundField DataField="fechaEncabezadopedido" 
                                                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
                                                    <asp:View ID="vistaPremio" runat="server">
                                                        <table cellpadding="2" class="style1">
                                                            <tr>
                                                                <td bgcolor="#006699" colspan="2" style="color: #FFFFFF; font-weight: 700">
                                                                    Pedidos De Premios</td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <table cellpadding="2" class="style1">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Button ID="Button5" runat="server" Text="Consultar General" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                            <td>
                                                                                &#160;</td>
                                                                            <td>
                                                                                &#160;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Seleccione Pais:</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList32" runat="server" Width="220px">
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button6" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Numero de Pedido:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox40" runat="server" style="text-align: right"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button7" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Fecha Inicial:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox41" runat="server" Width="100px"></asp:TextBox>
                                                                                &#160;<span class="style20">Fecha Final:</span>
                                                                                <asp:CalendarExtender ID="TextBox41_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox41">
                                                                                </asp:CalendarExtender>
                                                                                <asp:TextBox ID="TextBox42" runat="server" Width="100px"></asp:TextBox>
                                                                                <asp:CalendarExtender ID="TextBox42_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox42">
                                                                                </asp:CalendarExtender>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button8" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                                <td>
                                                                    &#160;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2">
                                                                    <asp:Panel ID="Panel5" runat="server" Height="650px" ScrollBars="Both">
                                                                        <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" 
                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                            CellPadding="3" style="font-size: x-small" Width="100%">
                                                                            <Columns>
                                                                                <asp:CommandField ShowSelectButton="True" />
                                                                                <asp:BoundField DataField="idEncabezadopedido" HeaderText="Id" />
                                                                                <asp:BoundField DataField="consecutivopedido" HeaderText="Numero" />
                                                                                <asp:BoundField DataField="idproveedor" HeaderText="Id Proveedor" />
                                                                                <asp:BoundField DataField="nombreproveedor" HeaderText="Proveedor" />
                                                                                <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                                                                <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                                                                                <asp:BoundField DataField="fechaEncabezadopedido" HeaderText="Fecha" />
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
                                                    <asp:View ID="vistaPapeleria" runat="server">
                                                        <table cellpadding="2" class="style1">
                                                            <tr>
                                                                <td bgcolor="#006699" style="color: #FFFFFF; font-weight: 700">
                                                                    Pedidos Papelerias</td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <table cellpadding="2" class="style1">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Button ID="Button9" runat="server" Text="Consultar General" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                            <td>
                                                                                &#160;</td>
                                                                            <td>
                                                                                &#160;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Seleccione Pais:</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList33" runat="server" Width="220px">
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button10" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Numero De Pedido:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox43" runat="server" style="text-align: right"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button11" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style20">
                                                                                Fecha Inicial:</td>
                                                                            <td>
                                                                                <asp:TextBox ID="TextBox44" runat="server" Width="100px"></asp:TextBox>
                                                                                &#160;<span class="style20">Fecha Final:</span>
                                                                                <asp:CalendarExtender ID="TextBox44_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox44">
                                                                                </asp:CalendarExtender>
                                                                                <asp:TextBox ID="TextBox45" runat="server" Width="100px"></asp:TextBox>
                                                                                <asp:CalendarExtender ID="TextBox45_CalendarExtender" runat="server" 
                                                                                    Enabled="True" Format="yyyyMMdd" TargetControlID="TextBox45">
                                                                                </asp:CalendarExtender>
                                                                            </td>
                                                                            <td>
                                                                                <asp:Button ID="Button12" runat="server" Text="Consultar" 
                                                                                    ToolTip="Consulta Por Pais" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <asp:Panel ID="Panel6" runat="server" Height="650px" ScrollBars="Both">
                                                                        <asp:GridView ID="GridView12" runat="server" AutoGenerateColumns="False" 
                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                            CellPadding="3" style="font-size: x-small" Width="100%">
                                                                            <Columns>
                                                                                <asp:CommandField ShowSelectButton="True" />
                                                                                <asp:BoundField DataField="idEncabezadopedido" HeaderText="Id" />
                                                                                <asp:BoundField DataField="consecutivopedido" HeaderText="Numero" />
                                                                                <asp:BoundField DataField="idproveedor" HeaderText="Id Proveedor" />
                                                                                <asp:BoundField DataField="nombreproveedor" HeaderText="Proveedor" />
                                                                                <asp:BoundField DataField="idpais" HeaderText="Id Pais" />
                                                                                <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                                                                                <asp:BoundField DataField="fechaEncabezadopedido" HeaderText="Fecha" />
                                                                            </Columns>
                                                                            <FooterStyle BackColor="White" ForeColor="#000066" />
                                                                            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                                            <RowStyle ForeColor="#000066" />
                                                                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                                            <sortedascendingcellstyle backcolor="#F1F1F1" />
                                                                            <sortedascendingheaderstyle backcolor="#007DBB" />
                                                                            <sorteddescendingcellstyle backcolor="#CAC9C9" />
                                                                            <sorteddescendingheaderstyle backcolor="#00547E" />
                                                                        </asp:GridView>
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:View>
                                                </asp:MultiView>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ImageButton25" EventName="Click" />
                                    <asp:AsyncPostBackTrigger ControlID="ImageButton26" EventName="Click" />
                                    <asp:AsyncPostBackTrigger ControlID="ImageButton27" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
                        
</ContentTemplate>
</asp:TabPanel>
                </asp:TabContainer>
            </td>
        </tr>
    </table>
</asp:Content>

