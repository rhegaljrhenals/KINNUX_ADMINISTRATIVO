<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfConsultaCumpleano.aspx.vb" Inherits="Reportes_Varios_wfConsultaCumpleano" %>

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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style5">
        <tr>
            <td align="right" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" bgcolor="#CCCCCC" colspan="2">
                <strong>&nbsp; <span class="style13">Reportes De Cumpleaños</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label4" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace">Mes:</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    <asp:ListItem>Seleccione Mes</asp:ListItem>
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
&nbsp;<asp:Button ID="Button1" runat="server" Height="30px" Text="Buscar" Width="115px" />
            &nbsp;<asp:Button ID="Button2" runat="server" Height="30px" Text="Enviar Email" 
                    Width="115px" />
                <asp:Label ID="Label5" runat="server" style="font-size: small; color: #0000FF">Enviando Correo...!</asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
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
                <asp:Panel ID="Panel3" runat="server" Height="1319px" ScrollBars="Vertical">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%" 
                        GridLines="None">
                        <Columns>
                            <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="email1" HeaderText="Email" />
                            <asp:BoundField DataField="fechanacido" DataFormatString="{0:yyyy/MM/dd}" 
                                HeaderText="Fecha De Nacimiento" />
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

