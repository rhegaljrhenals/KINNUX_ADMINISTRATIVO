<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConsultaAfiliaciones.aspx.vb" Inherits="Reportes_Varios_wfConsultaAfiliaciones" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style5
        {
            width: 90%;
        }
        .style13
        {
            font-size: medium;
            font-family: "Courier New", Courier, monospace;
            color: #0000FF;
        }
        .style12
        {
            color: #000066;
        }
        .style14
    {
        height: 18px;
    }
    .style15
    {
        height: 18px;
        color: #000066;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style5">
    <tr>
        <td align="right" colspan="2">
            <strong>&nbsp; <span class="style13">Consulta De Afiliaciones</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></td>
    </tr>
    <tr>
        <td align="left" bgcolor="#CCCCCC" colspan="2">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="50px" ToolTip="Consultar" 
                Width="50px" ID="ImageButton9"></asp:ImageButton>
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="51px" 
                ToolTip="Exportar a excell" Width="50px" ID="ImageButton10">
            </asp:ImageButton>
        </td>
    </tr>
    <tr>
        <td align="left">
            <asp:Label ID="Label4" runat="server" 
                style="color: #FF0000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
        </td>
        <td align="left">
                &nbsp;</td>
    </tr>
    <tr>
        <td align="left">
            <asp:Panel ID="Panel4" runat="server" Height="139px" Width="343px">
                <table cellpadding="0" cellspacing="0" class="style1" 
                    style="font-family: 'Courier New', Courier, monospace">
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
                        <td class="style12">
                            Fecha Inicial:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton11" 
                                TargetControlID="TextBox1">
                            </asp:CalendarExtender>
                            <asp:ImageButton ID="ImageButton11" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/calendario.png" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style15">
                            Fecha Final:</td>
                        <td class="style14">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton12" 
                                TargetControlID="TextBox2">
                            </asp:CalendarExtender>
                            <asp:ImageButton ID="ImageButton12" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/calendario.png" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td align="left">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="left">
            &nbsp;</td>
        <td align="left">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="left">
            <asp:Label ID="Label3" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
        </td>
        <td align="left">
                &nbsp;</td>
    </tr>
    <tr>
        <td align="left">
                &nbsp;</td>
        <td align="left">
                &nbsp;</td>
    </tr>
    <tr>
        <td align="left" colspan="2">
            <asp:Panel ID="Panel3" runat="server" Height="1300px" ScrollBars="Vertical">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%" 
                        GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="email1" HeaderText="Email" />
                        <asp:BoundField DataField="nombrepais" HeaderText="Pais" />
                        <asp:BoundField DataField="fechaAfiliacion" HeaderText="Fecha Afiliacion" 
                            DataFormatString="{0:yyyy/MM/dd}" />
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
        <td align="left">
                &nbsp;</td>
        <td align="left">
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

