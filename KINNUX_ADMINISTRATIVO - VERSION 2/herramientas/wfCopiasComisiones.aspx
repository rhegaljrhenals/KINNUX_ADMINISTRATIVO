<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfCopiasComisiones.aspx.vb" Inherits="herramientas_wfCopiasComisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="left" colspan="2">
                                    <table border="0" cellpadding="5" cellspacing="0" width="100%" 
                                        __designer:mapid="22a7">
                                        <tr __designer:mapid="22a8">
                                            <td class="titleseccion" __designer:mapid="22a9">
                                                <table border="0" cellpadding="0" cellspacing="0" width="100%" 
                                                    __designer:mapid="22aa">
                                                    <tr __designer:mapid="22ab">
                                                        <td align="center" width="5%" __designer:mapid="22ac">
                                                            <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" 
                                                                ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar" Width="40px" />
                                                        </td>
                                                        <td width="90%" __designer:mapid="22b4">
                                                            Copias Recibo De Comisiones</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label4" runat="server" 
                    style="font-family: 'Courier New', Courier, monospace" 
                    Text="Codigo Del Afiliado:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
            </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style1" style="width: 500px">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Height="30px" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                Text="Inicio Rápido" Width="158px" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Height="30px" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                Text="Inscripción" Width="158px" />
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" Height="30px" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                Text="Binarias" Width="158px" />
                        </td>
                        <td>
                            <asp:Button ID="Button4" runat="server" Height="30px" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                Text="Mensuales" Width="158px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table class="style1">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Vertical">
                                        <table class="style1">
                                            <tr>
                                                <td align="center" style="background-color: #CCCCCC">
                                                    <asp:Label ID="Label5" runat="server" 
                                                        style="color: #000000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="background-color: #CCCCCC">
                                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="40px" 
                                                        ImageUrl="~/Imagenes/impresora.png" ToolTip="Imprimir" Width="40px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:Label ID="Label6" runat="server" 
                                                        style="font-size: large; font-weight: 700; font-family: 'Courier New', Courier, monospace; color: #005FAE" 
                                                        Text="Comisiones Inicio Rápido"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" ShowFooter="True" style="font-weight: 700" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
                                                <asp:BoundField DataField="idcomisionir" HeaderText="Recibo No" />
                                                <asp:BoundField DataField="valorComisonIr" HeaderText="Valor">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                                                <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                                <asp:BoundField DataField="fechaEncFacturaPro" 
                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remisión" />
                                                <asp:BoundField DataField="fechaPagoComisionIr" 
                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago" />
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                HorizontalAlign="Right" />
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
                    <asp:View ID="View2" runat="server">
                        <table class="style1">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel2" runat="server" Height="400px" ScrollBars="Vertical">
                                        <table class="style1">
                                            <tr>
                                                <td align="center" style="background-color: #CCCCCC">
                                                    <asp:Label ID="Label7" runat="server" 
                                                        style="color: #000000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="background-color: #CCCCCC">
                                                    <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                                                        ImageUrl="~/Imagenes/impresora.png" ToolTip="Imprimir" Width="40px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:Label ID="Label8" runat="server" 
                                                        style="font-size: large; font-weight: 700; font-family: 'Courier New', Courier, monospace; color: #005FAE" 
                                                        Text="Comisiones De Inscripción"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" ShowFooter="True" style="font-weight: 700" Width="100%">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idComisionKit" HeaderText="Recibo No" />
                                                            <asp:BoundField DataField="valorComisionKit" HeaderText="Valor">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                                                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remisión" />
                                                            <asp:BoundField DataField="nombreCompletoUsuario" HeaderText="Usuario Pagó" />
                                                            <asp:BoundField DataField="fechaPagoComisionKit" 
                                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago" />
                                                        </Columns>
                                                        <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                            HorizontalAlign="Right" />
                                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                        <RowStyle ForeColor="#000066" />
                                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <table class="style1">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Vertical">
                                        <table class="style1">
                                            <tr>
                                                <td align="center" style="background-color: #CCCCCC">
                                                    <asp:Label ID="Label9" runat="server" 
                                                        style="color: #000000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="background-color: #CCCCCC">
                                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="40px" 
                                                        ImageUrl="~/Imagenes/impresora.png" ToolTip="Imprimir" Width="40px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:Label ID="Label10" runat="server" 
                                                        style="font-size: large; font-weight: 700; font-family: 'Courier New', Courier, monospace; color: #005FAE" 
                                                        Text="Comisiones Mensuales"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" ShowFooter="True" ShowHeaderWhenEmpty="True" 
                                                        style="font-weight: 700">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idcomision" HeaderText="Recibo No" />
                                                            <asp:BoundField DataField="compracomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Compras">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="iniciorcomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Inicio Rapido">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="uninivelcomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Uninivel">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="avancelcomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Avance">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="genbinariocomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Gen. Binario">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="generacionalcomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Generacional">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="estructuracomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Estructura">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="elitecomision" DataFormatString="{0:N2}" 
                                                                HeaderText="Elite" Visible="False">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="bono1comision" DataFormatString="{0:N2}" 
                                                                HeaderText="MultiEstructura">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="bono2comision" DataFormatString="{0:N2}" 
                                                                HeaderText="Compresión IR Diario">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="anocomision" HeaderText="Año" />
                                                            <asp:BoundField DataField="mescomision" HeaderText="Mes" />
                                                            <asp:BoundField DataField="suma" DataFormatString="{0:N2}" HeaderText="Total">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                        <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" 
                                                            HorizontalAlign="Right" />
                                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                        <RowStyle ForeColor="#000066" />
                                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

