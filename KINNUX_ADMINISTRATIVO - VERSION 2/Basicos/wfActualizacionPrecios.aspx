<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfActualizacionPrecios.aspx.vb" Inherits="Basicos_wfActualizacionPrecios" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            font-family: "Courier New", Courier, monospace;
        }
        .style2
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
                <br />
              </td>
                          <td width="5%" align="center">
                <br />
              </td>

                          <td width="90%">Actualización De Precios</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                Empresas(Paises):
                <asp:DropDownList ID="DropDownList1" runat="server" Width="350px" 
                    CssClass="campver">
                </asp:DropDownList>
                  </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" 
                                                        Height="40px" ToolTip="Grabar" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
                                    </td>
            <td align="left">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" 
                                                        Height="40px" ToolTip="Grabar" 
                Width="40px" ID="ImageButton3"></asp:ImageButton>
                                    </td>
        </tr>
        <tr>
            <td align="left" valign="top">
                            <asp:Panel ID="Panel1" runat="server" Height="400px" 
                                BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" 
                    Width="300px" ScrollBars="Vertical">
                                <table cellpadding="0" cellspacing="0" class="style2">
                                    <tr>
                                        <td align="center" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Productos</td>
                                    </tr>
                                </table>
                                <br />
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="idProducto" HeaderText="Id Producto" />
                                        <asp:BoundField DataField="nombreProducto" HeaderText="Nombres" />
                                        <asp:TemplateField HeaderText="Precio">
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" style="text-align: right" 
                                                    Width="80px" CssClass="campver"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox1_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox1">
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
            <td align="left" valign="top">
                            <asp:Panel ID="Panel2" runat="server" Height="400px" ScrollBars="Vertical" 
                                BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" 
                    Width="500px">
                                <table cellpadding="0" cellspacing="0" class="style2">
                                    <tr>
                                        <td align="center" 
                                            style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                            Paquetes</td>
                                    </tr>
                                </table>
                                <br />
                                <asp:GridView ID="GridView3" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="idPaquete" HeaderText="Id Paquete" />
                                        <asp:BoundField DataField="nombrePaquete" HeaderText="Nombres" />
                                        <asp:TemplateField HeaderText="Precio">
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" style="text-align: right" 
                                                    Width="80px" CssClass="campver"></asp:TextBox>
                                                <asp:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" 
                                                    runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox2">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

