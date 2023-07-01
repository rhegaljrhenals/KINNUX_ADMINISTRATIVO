<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteTTBBinario.aspx.vb" Inherits="Reportes_Varios_wfReporteTTBBinario" %>

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
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
      
      </td>

            <td width="90%">Reporte Binario</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    
    
    <table cellpadding="0" cellspacing="0" style="width: 80%">
    <tr>
        <td align="left">
            <asp:Label ID="Label6" runat="server" 
                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
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
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        Pais:</td>
                    <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                <asp:Panel ID="panelDatos" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#000066" BorderStyle="Solid" BorderWidth="1px" Height="352px" 
                    Width="502px">
                    <table cellpadding="0" cellspacing="0" class="style1" 
                        style="font-family: 'Courier New', Courier, monospace">
                        <tr>
                            <td align="right" bgcolor="#006699" colspan="4">
                                &nbsp;<span class="style15">Datos De la Comisión</span><asp:ImageButton ID="ImageButton12" 
                                    runat="server" Height="30px" ImageUrl="~/Imagenes/Error 2.png" 
                                    ToolTip="Cerrar" />
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
                                <asp:Panel ID="Panel2" runat="server" Height="155px" ScrollBars="Both">
                                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3">
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
            <asp:Panel ID="Panel1" runat="server" Height="150px" ScrollBars="Vertical">
                <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" Width="100%" style="font-weight: 700">
                    <Columns>
                        <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                        <asp:BoundField DataField="acumulado" HeaderText="Acumulado" 
                            DataFormatString="{0:N2}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valor" HeaderText="Valor" DataFormatString="{0:N2}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fechainibbinario" DataFormatString="{0:yyyy/MM/dd}" 
                            HeaderText="Fecha Inicio" />
                        <asp:BoundField DataField="fechafinbbinario" DataFormatString="{0:yyyy/MM/dd}" 
                            HeaderText="Fecha Final" />
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
                        <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" >
                        <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="identificacion" HeaderText="Identificación" />
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" >
                        <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="acumbbinario" HeaderText="Acumulado" 
                            DataFormatString="{0:N2}">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valorbbinario" HeaderText="Valor" 
                            DataFormatString="{0:N2}">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="porcbbinario" HeaderText="Porcentage" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fechainibbinario" 
                            DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Inicio" />
                        <asp:BoundField DataField="fechafinbbinario" DataFormatString="{0:yyyy/MM/dd}" 
                            HeaderText="Fecha Final" />
                        <asp:BoundField DataField="fechavenbbinario" DataFormatString="{0:yyyy/MM/dd}" 
                            HeaderText="Fecha Vence" />
                        <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                        <asp:BoundField DataField="nombreDpto" HeaderText="Dpto" />
                        <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
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

