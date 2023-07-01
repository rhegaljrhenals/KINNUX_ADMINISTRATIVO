<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfObsequios.aspx.vb" Inherits="Basicos_wfObsequios" %>

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
            width: 220px;
        }
        .style17
        {
            color: #000066;
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
          <td width="5%" align="center">

                                                    &nbsp;</td>
                          <td width="90%">Obsequios</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="2" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="panelError" 
                    runat="server" BorderColor="Red" 
                                                                        BorderStyle="Groove" 
                    BorderWidth="1px" Height="164px">
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
            <td align="left" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <table cellpadding="2" cellspacing="0" class="style1">
                            <tr>
                                <td class="style22">
                                    id:</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                    <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
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
                                    Pais:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList23" runat="server" AutoPostBack="True" 
                                        Width="250px">
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
                                <td class="style22">
                                    Nombre Obsequio:</td>
                                <td>
                                    <asp:TextBox ID="TextBox15" runat="server" Width="250px"></asp:TextBox>
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
                                    Paquete:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList24" runat="server" AutoPostBack="True" 
                                        Width="250px">
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
                                    <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" 
                                        Height="1100px" Width="100%">
                                        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1"><HeaderTemplate>Configurar Obsequio</HeaderTemplate><ContentTemplate><table 
                                            cellpadding="0" cellspacing="0" class="style1"><tr><td align="center" 
                                                style="font-weight: 700">&nbsp;</td><td valign="top">&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td 
                                            align="center" bgcolor="#C1D82F" style="font-weight: 700">Productos</td><td 
                                            valign="top">&nbsp;</td><td align="center" bgcolor="#C1D82F" 
                                            style="font-weight: 700">Papelerias</td><td>&nbsp;</td></tr><tr><td 
                                            style="width: 338px"><asp:Panel ID="Panel2" runat="server" 
                                            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Height="315px" 
                                            ScrollBars="Vertical" Width="500px"><span><asp:GridView ID="GridView3" 
                                                runat="server" AutoGenerateColumns="False" BackColor="White" 
                                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                Width="100%"><Columns><asp:TemplateField><ItemTemplate><asp:CheckBox ID="CheckBox1" 
                                                        runat="server" /></ItemTemplate></asp:TemplateField><asp:BoundField 
                                                        DataField="idProducto" HeaderText="Id"></asp:BoundField><asp:BoundField 
                                                        DataField="nombreproducto" HeaderText="Nombres"></asp:BoundField><asp:TemplateField 
                                                        HeaderText="Cantidad"><ItemTemplate><asp:TextBox ID="TextBox11" runat="server" 
                                                            Width="50px"></asp:TextBox><asp:FilteredTextBoxExtender 
                                                            ID="TextBox11_FilteredTextBoxExtender" runat="server" Enabled="True" 
                                                            FilterType="Numbers" TargetControlID="TextBox11"></asp:FilteredTextBoxExtender></ItemTemplate></asp:TemplateField></Columns><FooterStyle 
                                                    BackColor="White" ForeColor="#000066"></FooterStyle><HeaderStyle 
                                                    BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle><PagerStyle 
                                                    BackColor="White" ForeColor="#000066" HorizontalAlign="Left"></PagerStyle><RowStyle 
                                                    ForeColor="#000066"></RowStyle><SelectedRowStyle BackColor="#669999" 
                                                    Font-Bold="True" ForeColor="White"></SelectedRowStyle><sortedascendingcellstyle 
                                                    backcolor="#F1F1F1"></sortedascendingcellstyle><sortedascendingheaderstyle 
                                                    backcolor="#007DBB"></sortedascendingheaderstyle><sorteddescendingcellstyle 
                                                    backcolor="#CAC9C9"></sorteddescendingcellstyle><sorteddescendingheaderstyle 
                                                    backcolor="#00547E"></sorteddescendingheaderstyle></asp:GridView></span></asp:Panel></td><td 
                                            valign="top">&nbsp;</td><td style="width: 338px" valign="top"><asp:Panel ID="Panel3" 
                                                runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                                                Height="315px" ScrollBars="Vertical" Width="500px"><span><asp:GridView 
                                                ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="White" 
                                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                Width="100%"><Columns><asp:TemplateField><ItemTemplate><asp:CheckBox ID="CheckBox2" 
                                                        runat="server" /></ItemTemplate></asp:TemplateField><asp:BoundField 
                                                        DataField="idPapeleria" HeaderText="Id"></asp:BoundField><asp:BoundField 
                                                        DataField="nombrepapeleria" HeaderText="Nombres"></asp:BoundField><asp:TemplateField 
                                                        HeaderText="Cantidad"><ItemTemplate><asp:TextBox ID="TextBox12" runat="server" 
                                                            Width="50px"></asp:TextBox><asp:FilteredTextBoxExtender 
                                                            ID="TextBox12_FilteredTextBoxExtender" runat="server" Enabled="True" 
                                                            FilterType="Numbers" TargetControlID="TextBox12"></asp:FilteredTextBoxExtender></ItemTemplate></asp:TemplateField></Columns><FooterStyle 
                                                    BackColor="White" ForeColor="#000066"></FooterStyle><HeaderStyle 
                                                    BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle><PagerStyle 
                                                    BackColor="White" ForeColor="#000066" HorizontalAlign="Left"></PagerStyle><RowStyle 
                                                    ForeColor="#000066"></RowStyle><SelectedRowStyle BackColor="#669999" 
                                                    Font-Bold="True" ForeColor="White"></SelectedRowStyle><sortedascendingcellstyle 
                                                    backcolor="#F1F1F1"></sortedascendingcellstyle><sortedascendingheaderstyle 
                                                    backcolor="#007DBB"></sortedascendingheaderstyle><sorteddescendingcellstyle 
                                                    backcolor="#CAC9C9"></sorteddescendingcellstyle><sorteddescendingheaderstyle 
                                                    backcolor="#00547E"></sorteddescendingheaderstyle></asp:GridView></span></asp:Panel></td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td 
                                            valign="top">&nbsp;</td><td valign="top">&nbsp;</td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td 
                                            valign="top">&nbsp;</td><td valign="top">&nbsp;</td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td 
                                            valign="top">&nbsp;</td><td valign="top">&nbsp;</td><td>&nbsp;</td></tr><tr><td 
                                            align="center" bgcolor="#C1D82F" style="font-weight: 700">Premios</td><td 
                                            valign="top">&nbsp;</td><td align="center" bgcolor="#C1D82F" 
                                            style="font-weight: 700" valign="top">Equipos Médicos</td><td>&nbsp;</td></tr><tr><td><asp:Panel 
                                            ID="Panel4" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                            BorderWidth="1px" Height="315px" ScrollBars="Vertical" Width="500px"><span><asp:GridView 
                                            ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="White" 
                                            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                            Width="100%"><Columns><asp:TemplateField><ItemTemplate><asp:CheckBox ID="CheckBox3" 
                                                    runat="server" /></ItemTemplate></asp:TemplateField><asp:BoundField 
                                                    DataField="idPremio" HeaderText="Id"></asp:BoundField><asp:BoundField 
                                                    DataField="nombrepremio" HeaderText="Nombres"></asp:BoundField><asp:TemplateField 
                                                    HeaderText="Cantidad"><ItemTemplate><asp:TextBox ID="TextBox13" runat="server" 
                                                        Width="50px"></asp:TextBox><asp:FilteredTextBoxExtender 
                                                        ID="TextBox13_FilteredTextBoxExtender" runat="server" Enabled="True" 
                                                        FilterType="Numbers" TargetControlID="TextBox13"></asp:FilteredTextBoxExtender></ItemTemplate></asp:TemplateField></Columns><FooterStyle 
                                                BackColor="White" ForeColor="#000066"></FooterStyle><HeaderStyle 
                                                BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle><PagerStyle 
                                                BackColor="White" ForeColor="#000066" HorizontalAlign="Left"></PagerStyle><RowStyle 
                                                ForeColor="#000066"></RowStyle><SelectedRowStyle BackColor="#669999" 
                                                Font-Bold="True" ForeColor="White"></SelectedRowStyle><sortedascendingcellstyle 
                                                backcolor="#F1F1F1"></sortedascendingcellstyle><sortedascendingheaderstyle 
                                                backcolor="#007DBB"></sortedascendingheaderstyle><sorteddescendingcellstyle 
                                                backcolor="#CAC9C9"></sorteddescendingcellstyle><sorteddescendingheaderstyle 
                                                backcolor="#00547E"></sorteddescendingheaderstyle></asp:GridView></span></asp:Panel></td><td 
                                            valign="top">&nbsp;</td><td valign="top"><asp:Panel ID="Panel5" runat="server" 
                                                BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Height="315px" 
                                                ScrollBars="Vertical" Width="500px"><span><asp:GridView ID="GridView6" 
                                                runat="server" AutoGenerateColumns="False" BackColor="White" 
                                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                Width="100%"><Columns><asp:TemplateField><ItemTemplate><asp:CheckBox ID="CheckBox4" 
                                                        runat="server" /></ItemTemplate></asp:TemplateField><asp:BoundField 
                                                        DataField="idEquipoM" HeaderText="Id"></asp:BoundField><asp:BoundField 
                                                        DataField="nombreEquipom" HeaderText="Nombres"></asp:BoundField><asp:TemplateField 
                                                        HeaderText="Cantidad"><ItemTemplate><asp:TextBox ID="TextBox14" runat="server" 
                                                            Width="50px"></asp:TextBox><asp:FilteredTextBoxExtender 
                                                            ID="TextBox14_FilteredTextBoxExtender" runat="server" Enabled="True" 
                                                            FilterType="Numbers" TargetControlID="TextBox14"></asp:FilteredTextBoxExtender></ItemTemplate></asp:TemplateField></Columns><FooterStyle 
                                                    BackColor="White" ForeColor="#000066"></FooterStyle><HeaderStyle 
                                                    BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle><PagerStyle 
                                                    BackColor="White" ForeColor="#000066" HorizontalAlign="Left"></PagerStyle><RowStyle 
                                                    ForeColor="#000066"></RowStyle><SelectedRowStyle BackColor="#669999" 
                                                    Font-Bold="True" ForeColor="White"></SelectedRowStyle><sortedascendingcellstyle 
                                                    backcolor="#F1F1F1"></sortedascendingcellstyle><sortedascendingheaderstyle 
                                                    backcolor="#007DBB"></sortedascendingheaderstyle><sorteddescendingcellstyle 
                                                    backcolor="#CAC9C9"></sorteddescendingcellstyle><sorteddescendingheaderstyle 
                                                    backcolor="#00547E"></sorteddescendingheaderstyle></asp:GridView></span></asp:Panel></td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td 
                                            valign="top">&nbsp;</td><td valign="top">&nbsp;</td><td>&nbsp;</td></tr></table></ContentTemplate></asp:TabPanel>
                                        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2"><HeaderTemplate>Consultar Obsequios</HeaderTemplate><ContentTemplate><table 
                                            cellpadding="0" cellspacing="0" class="style1"><tr><td>&nbsp;</td></tr><tr><td>
                                            <asp:Panel 
                                            ID="Panel10" runat="server" Height="400px"><asp:GridView ID="GridView2" 
                                            runat="server" AutoGenerateColumns="False" BackColor="White" 
                                            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                            style="font-size: small" Width="100%"><Columns><asp:CommandField 
                                                    SelectText="Seleccionar" ShowSelectButton="True" />
                                                    <asp:BoundField 
                                                    DataField="idObsequio" HeaderText="Id" />
                                                    <asp:BoundField 
                                                    DataField="nombreObsequio" 
                                                    HeaderText="Nombre Obsequio" />
                                                    <asp:BoundField 
                                                    DataField="idPaquete" 
                                                    HeaderText="Id Paquete" />
                                                    <asp:BoundField DataField="nombrePaquete" 
                                                    HeaderText="Nombre Paquete" /><asp:BoundField DataField="codigoPais" 
                                                    HeaderText="Codigo Pais" /><asp:BoundField DataField="nombrePais" 
                                                    HeaderText="Pais" /></Columns><FooterStyle BackColor="White" 
                                                ForeColor="#000066" /><HeaderStyle BackColor="#006699" Font-Bold="True" 
                                                ForeColor="White" /><PagerStyle BackColor="White" ForeColor="#000066" 
                                                HorizontalAlign="Left" /><RowStyle ForeColor="#000066" /><SelectedRowStyle 
                                                BackColor="#669999" Font-Bold="True" ForeColor="White" /><SortedAscendingCellStyle 
                                                BackColor="#F1F1F1" /><SortedAscendingHeaderStyle BackColor="#007DBB" /><SortedDescendingCellStyle 
                                                BackColor="#CAC9C9" /><SortedDescendingHeaderStyle BackColor="#00547E" /></asp:GridView></asp:Panel></td></tr></table></ContentTemplate></asp:TabPanel>
                                    </asp:TabContainer>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

