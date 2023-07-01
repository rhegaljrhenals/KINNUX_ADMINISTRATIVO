<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteGrupalBinario.aspx.vb" Inherits="Reportes_Varios_wfReporteTTBBinario" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style15
        {
            color: #FFFFFF;
            font-weight: bold;
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
                Width="40px" ID="ImageButton9"></asp:ImageButton>
                <br />
              </td>
                          <td width="90%">Reporte Grupal Binario</td>
            </tr>
          </table></td>
      </tr>
    </table>
    
    <table cellpadding="0" cellspacing="0" style="width: 80%">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
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
                    <td>
                        Fechas:</td>
                    <td>
            <asp:DropDownList ID="DropDownList9" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList10" runat="server" Width="150px">
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
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
                    <td>
                <asp:Panel ID="panelDatos" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#000066" BorderStyle="Solid" BorderWidth="1px" Height="395px" 
                    Width="502px">
                    <table cellpadding="0" cellspacing="0" class="style1" 
                        style="font-family: 'Courier New', Courier, monospace">
                        <tr>
                            <td align="center" bgcolor="#006699" colspan="4">
                                &nbsp;<span class="style15">Detalle Comisión</span></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Afiliado:</td>
                            <td colspan="3">
                                <asp:Label ID="Label4" runat="server" BackColor="#CCCCCC" Width="350px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Fechas:</td>
                            <td colspan="3">
                                <asp:Label ID="Label5" runat="server" BackColor="#CCCCCC" Width="350px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Grupal Izquierdo:</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" 
                                    style="text-align: right" Width="80px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Grupal Derecho:</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" 
                                    style="text-align: right" Width="80px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Panel ID="Panel2" runat="server" Height="155px" ScrollBars="Vertical">
                                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" Width="100%" style="font-weight: 700">
                                        <Columns>
                                            <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" />
                                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                            <asp:BoundField DataField="puntosdetgrupalbinario" HeaderText="Puntos">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="ladodetgrupalbinario" HeaderText="Lado" />
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
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <label>
                                <asp:Button ID="Button1" runat="server" Height="30px" 
                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                    Text="Cerrar" Width="100px" />
                                </label>
                            </td>
                        </tr>
                    </table>
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
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
        <td align="left" colspan="2">
            <asp:Panel ID="Panel1" runat="server" Height="140px" ScrollBars="Vertical">
                <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" Width="100%" style="font-weight: 700">
                    <Columns>
                        <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                        <asp:BoundField DataField="izq" HeaderText="Izquierdo" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="der" HeaderText="Derecho" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fechaiGrupalBinario" HeaderText="Fecha Inicio" 
                            DataFormatString="{0:yyyy/MM/dd}">
                        </asp:BoundField>
                        <asp:BoundField DataField="fechafGrupalBinario" HeaderText="Fecha Final" 
                            DataFormatString="{0:yyyy/MM/dd}">
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="left" colspan="2">
            <asp:Panel ID="Panel3" runat="server" Height="650px" ScrollBars="Vertical">
                <asp:GridView ID="GridView4" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" Width="100%" style="font-weight: 700">
                    <Columns>
                        <asp:CommandField SelectText="Ver Resumen" ShowSelectButton="True" />
                        <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" >
                        <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" >
                        <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="izqgrupalbinario" HeaderText="Izquierdo">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="dergrupalbinario" HeaderText="Derecho">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fechaigrupalbinario" 
                            DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Inicio" />
                        <asp:BoundField DataField="fechafgrupalbinario" 
                            DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Final" />
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
</table>
    
    
    
</asp:Content>

