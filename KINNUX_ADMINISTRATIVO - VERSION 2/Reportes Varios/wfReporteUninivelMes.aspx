<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteUninivelMes.aspx.vb" Inherits="Reportes_Varios_wfReporteIRMes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style12
        {
            color: #000066;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="width: 80%; font-family: 'Courier New', Courier, monospace;">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td align="right">
            <strong>Liquidación Sistema Uninivel<img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="left" colspan="2" bgcolor="#CCCCCC">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="50px" ToolTip="Consultar" 
                Width="50px" ID="ImageButton9"></asp:ImageButton>
            </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="left">
            Periodo:</td>
        <td align="left">
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
        <td align="left">
            Pais:</td>
        <td align="left">
            <asp:DropDownList ID="DropDownList11" runat="server" Width="350px">
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
        <td align="left" colspan="2">
            <asp:Panel ID="Panel2" runat="server" Height="195px">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" style="font-size: small" Width="100%" ShowFooter="True">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="codigoafiliado" 
                            DataNavigateUrlFormatString="~/Reportes Varios/wfDetalleComisionUn.aspx?id={0}" 
                            Target="_blank" Text="Ver Detalle" />
                        <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo" />
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="valnivel1comisionUn" HeaderText="Valor Nivel 1">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valnivel2comisionUn" HeaderText="Valor Nivel 2">
                        </asp:BoundField>
                        <asp:BoundField DataField="valnivel3comisionUn" HeaderText="Valor Nivel 3">
                        </asp:BoundField>
                        <asp:BoundField DataField="valnivel4comisionUn" HeaderText="Valor Nivel 4">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valnivel5comisionUn" HeaderText="Valor Nivel 5">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valnivel6comisionUn" HeaderText="Valor Nivel 6">
                        <ItemStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="total" HeaderText="Total">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Right" 
                        Font-Bold="True" />
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
</asp:Content>

