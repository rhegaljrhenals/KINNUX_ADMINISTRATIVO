<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfImpresionReciboComisionesBinarias.aspx.vb" Inherits="Facturacion_wfImpresionFactura" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title >
</title>
    <script type = "text/javascript">
        function PrintPanel() {
            /*var panel = document.getElementById("panelImpresion");
            var printWindow = window.open('', '', 'height=799,width=708');
            printWindow.document.write('<html><head><title>KINNUX</title>');
            printWindow.document.write('</head><body >');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            printWindow.print();
            printWindow.document.close();
            */
            var divElements = document.getElementById("panelImpresion").innerHTML;
            var oldPage = document.body.innerHTML;
            document.body.innerHTML =
            "<html><head><title>KINNUX</title></head><body>" +
            divElements + "</body>";
            window.print();
            window.close();
            document.body.innerHTML = oldPage;
            }
    </script>

    <style type="text/css">
        .style1
        {
            width: 100%;
            font-size: small;
            font-family: "Courier New", Courier, monospace;
        }
        .style4
        {
            width: 100%;
        }
        

        .style17
        {
            width: 100%;
        }
        .style31
        {
            font-size: xx-large;
            font-weight: bold;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <table cellpadding="0" cellspacing="0" class="style4" style="width: 20%">
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
            <td align="left" bgcolor="#CCCCCC" colspan="2">
                <asp:ImageButton runat="server" ImageUrl="~/Imagenes/impresora.png" Height="50px" 
                    ToolTip="Imprimir Factura" Width="50px" ID="ImageButton1" OnClientClick = "return PrintPanel();" >
                </asp:ImageButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2" id="listado">
                                        <asp:Panel runat="server" BorderColor="#333333" 
                    BorderWidth="1px" BorderStyle="Solid" Height="14.5cm" ID="panelImpresion" Width="708px">
                                            <table class="style17">
                                                <tr>
                                                    <td align="left">
                                                        <div style="height: 98px">
                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                <tr>
                                                                    <td valign="top">
                                                                        <div style="height: 89px">
                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                <tr>
                                                                                    <td align="left">
                                                                                        <div>
                                                                                            <table cellpadding="0" cellspacing="0" class="style4">
                                                                                                <tr>
                                                                                                    <td style="width: 85px">
                                                                                                        <table cellpadding="0" cellspacing="0" class="style4">
                                                                                                            <tr>
                                                                                                                <td>
                                                                                                                    <asp:Image ID="Image7" runat="server" Height="86px" 
                                                                                                                        ImageUrl="~/Imagenes/kinnux.png" Width="64px" />
                                                                                                                </td>
                                                                                                                <td class="style31">
                                                                                                                    RECIBO</td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                    <td align="right" valign="top">
                                                                                                        <br /> 3111 Camino Del Rio North, Suite 400,
                                                                                                        <br />
                                                                                                        San Diego California, 92108</td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="Panel18" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table class="style4">
                                                                <tr>
                                                                    <td valign="top">
                                                                        Identificación:<br /> Afiliado:</td>
                                                                    <td valign="top">
                                                                        <asp:TextBox ID="TextBox101" runat="server" ReadOnly="True" 
                                                                            style="text-align: left" Width="200px"></asp:TextBox>
                                                                        <br />
                                                                        <asp:TextBox ID="TextBox102" runat="server" ReadOnly="True" 
                                                                            style="text-align: justify" Width="350px"></asp:TextBox>
                                                                    </td>
                                                                    <td rowspan="2">
                                                                        <table class="style4">
                                                                            <tr>
                                                                                <td>
                                                                                    N° Recibo:</td>
                                                                                <td>
                                                                                    <asp:TextBox ID="TextBox103" runat="server" ReadOnly="True" 
                                                                                        style="text-align: right" Width="100px"></asp:TextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    Fecha:</td>
                                                                                <td>
                                                                                    <asp:TextBox ID="TextBox104" runat="server" ReadOnly="True" 
                                                                                        style="text-align: right" Width="100px"></asp:TextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top">
                                                                        &nbsp;</td>
                                                                    <td valign="top">
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        &nbsp;Pago Comisiónes Binaria (<asp:Label ID="Label48" runat="server"></asp:Label>
                                                        )</td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Panel ID="Panel15" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table class="style4">
                                                                <tr>
                                                                    <td valign="top" colspan="3">
                                                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                            CellPadding="3" Width="100%">
                                                                            <Columns>
                                                                                <asp:BoundField DataField="acumbbinario" HeaderText="Acumulado">
                                                                                <ItemStyle HorizontalAlign="Right" />
                                                                                </asp:BoundField>
                                                                                <asp:BoundField DataField="porcbbinario" HeaderText="Porcentage">
                                                                                <ItemStyle HorizontalAlign="Right" />
                                                                                </asp:BoundField>
                                                                                <asp:BoundField DataField="valorbbinario" DataFormatString="{0:N2}" 
                                                                                    HeaderText="Valor">
                                                                                <ItemStyle HorizontalAlign="Right" />
                                                                                </asp:BoundField>
                                                                                <asp:BoundField DataField="fechainibbinario" DataFormatString="{0:yyyy/MM/dd}" 
                                                                                    HeaderText="Fecha Inicial" />
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
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td valign="top">
                                                                        &nbsp;</td>
                                                                    <td align="right" valign="top">
                                                                        &nbsp;</td>
                                                                    <td align="right" valign="top">
                                                                        Total:
                                                                        <asp:TextBox ID="TextBox106" runat="server" ReadOnly="True" 
                                                                            style="text-align: right" Width="100px"></asp:TextBox>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Panel ID="Panel16" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table class="style4">
                                                                <tr>
                                                                    <td align="left" style="width: 85px" valign="top">
                                                                        <asp:Panel ID="Panel17" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                                            BorderWidth="1px" Height="80px" Width="80px">
                                                                        </asp:Panel>
                                                                    </td>
                                                                    <td align="left">
                                                                        _______________________________<br /> Recibí Conforme<br />
                                                                        </td>
                                                                    <td align="right" valign="top">
                                                                        <br />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" style="width: 85px" valign="top">
                                                                        &nbsp;</td>
                                                                    <td align="right">
                                                                        Usuario:<asp:TextBox ID="TextBox105" runat="server" ReadOnly="True" 
                                                                            style="text-align: left" Width="300px"></asp:TextBox>
                                                                    </td>
                                                                    <td align="right" valign="top">
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>

                                    </td>
        </tr>
        </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
