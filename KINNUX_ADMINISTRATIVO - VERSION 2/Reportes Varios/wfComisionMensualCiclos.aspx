<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfComisionMensualCiclos.aspx.vb" Inherits="Reportes_Varios_wfComisionMensualCiclos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .auto-style1 {
            width: 61px;
        }
        .auto-style2 {
            width: 61px;
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 88px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td width="5%" align="center">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
              </td>
            <td width="5%" align="center">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
              </td>

            <td width="90%">Comisiones Mensuales Puntos</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label4" runat="server" 
                    style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
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
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="auto-style1">
                            Periodo:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList13" runat="server" Width="150px" CssClass="campver">
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
                            <asp:DropDownList ID="DropDownList12" runat="server" CssClass="campver">
                            </asp:DropDownList>
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            </td>
                        <td class="auto-style3">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Empresa:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList14" runat="server" CssClass="campver" Width="300px">
                            </asp:DropDownList>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Mostrar Las Sucursales" />
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            <asp:Panel ID="Panel2" runat="server">
                                <table class="auto-style4">
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">Sucursales:</td>
                                        <td>
                                            <asp:DropDownList ID="DropDownList15" runat="server" Width="350px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="592px" ScrollBars="Both" 
                    Width="100%">
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td align="center" 
                                style="background-color: #CCCCCC; font-weight: 700; font-family: 'Courier New', Courier, monospace;">
                                <asp:Label ID="Label5" runat="server" 
                                    
                                    style="color: #000000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" style="color: #FF0000"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <asp:GridView ID="GridView2" runat="server" 
    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" ShowFooter="True" ShowHeaderWhenEmpty="True" 
                        style="font-weight: 700">
                        <Columns>
                            <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" />
                            <asp:BoundField DataField="identificacion" HeaderText="Identificación" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                            <asp:BoundField DataField="nombreDpto" HeaderText="Dpto" />
                            <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
                            <asp:BoundField DataField="ircomisionvp" HeaderText="Inicio Rapido" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="trinariocomisionvp" HeaderText="Trinario" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="cicloscomisionvp" HeaderText="Ciclos" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="rebatecomisionvp" HeaderText="Rebate" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="mundialcomisionvp" HeaderText="Bono MUndial" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="binariocomisionvp" HeaderText="Binario" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="total" HeaderText="Total" DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Right" 
                            Font-Bold="True" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#000066" HorizontalAlign="Left" />
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
</asp:Content>

