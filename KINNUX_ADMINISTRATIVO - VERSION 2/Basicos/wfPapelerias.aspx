<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPapelerias.aspx.vb" Inherits="Basicos_wfPapelerias" %>

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
        .style14
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
                                                        Height="40px" ToolTip="Nuevo" Width="40px" 
                        ID="ImageButton7">
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
                          <td width="90%">Papelerias</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="2" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td class="style14" align="left" colspan="2">
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
            <td class="style14" align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14" align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style14">
                            Id:</td>
                        <td>
                                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Nombre Papeleria:</td>
                        <td>
                                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                        Width="350px"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td class="style14">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14">
                            Estado:</td>
                        <td>
                                    <asp:DropDownList ID="DropDownList25" runat="server" Width="250px">
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                    </asp:DropDownList>
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
            <td class="style14">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14" align="left" colspan="2">
                <asp:Panel ID="Panel2" runat="server" Height="400px">
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                BackColor="White" 
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                CellPadding="3" Width="100%">
                        <Columns>
                            <asp:TemplateField HeaderText="Seleccione">
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="codigopais" HeaderText="Id Pais" />
                            <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                            <asp:TemplateField HeaderText="Precio Pais">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server" style="text-align: right" 
                                        Width="100px"></asp:TextBox>
                                    <asp:FilteredTextBoxExtender ID="TextBox8_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox8">
                                    </asp:FilteredTextBoxExtender>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio Local">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox9" runat="server" style="text-align: right" 
                                        Width="100px"></asp:TextBox>
                                    <asp:FilteredTextBoxExtender ID="TextBox9_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox9">
                                    </asp:FilteredTextBoxExtender>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Stock">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox11" runat="server" style="text-align: right" 
                                        Width="50px"></asp:TextBox>
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
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" class="style14" colspan="2">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

