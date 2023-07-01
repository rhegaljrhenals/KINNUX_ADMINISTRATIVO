<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfImpresionReciboKit.aspx.vb" Inherits="Facturacion_wfImpresionFactura" %>

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
            setTimeout(function () {
                printWindow.print();
            }, 50);
            return false;
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
        .style30
        {
            height: 23px;
        }
        .style31
        {
            font-size: xx-large;
            font-weight: bold;
        }
        .style32
        {
            width: 350px;
            height: 32px;
        }
        .style33
        {
            height: 32px;
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
                    BorderWidth="1px" BorderStyle="Solid" Height="14.5cm" ID="panelImpresion">
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
                                                                                                    <td align="center" valign="top">
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
                                                        <asp:Panel ID="Panel13" runat="server" BorderStyle="None" Height="42px">
                                                            <table cellpadding="0" cellspacing="0" class="style17" 
                                                                style="border-style: solid; border-width: thin; width: 700px">
                                                                <tr>
                                                                    <td>
                                                                        Distribuidor:</td>
                                                                    <td>
                                                                        <asp:Label ID="Label27" runat="server" BackColor="#CCCCCC" Width="250px"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        Fecha:</td>
                                                                    <td>
                                                                        <asp:Label ID="Label25" runat="server" BackColor="#CCCCCC" 
                                                                            style="text-align: left" Width="100px"></asp:Label>
                                                                        Recibo:</td>
                                                                    <td colspan="2">
                                                                        <asp:Label ID="Label26" runat="server" BackColor="#CCCCCC" 
                                                                            style="text-align: right" Width="100px"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        Dirección:</td>
                                                                    <td>
                                                                        <asp:Label ID="Label28" runat="server" BackColor="#CCCCCC" Width="250px"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        Telefono:</td>
                                                                    <td>
                                                                        <asp:Label ID="Label30" runat="server" BackColor="#CCCCCC" Width="100px"></asp:Label>
                                                                        Valor:</td>
                                                                    <td>
                                                                        <asp:Label ID="Label42" runat="server" BackColor="#CCCCCC" 
                                                                            style="text-align: right" Width="100px"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        Recibo Bono De Inscripción</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                            CellPadding="3" style="font-size: small" Width="100%">
                                                            <Columns>
                                                                <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="quiencompro" HeaderText="Distribuidor">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="fechaEncFacturaPro" 
                                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha">
                                                                <ItemStyle HorizontalAlign="Right" />
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="valorComisionKit" HeaderText="Valor">
                                                                <ItemStyle HorizontalAlign="Right" />
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
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style30" align="right">
                                                        Total:
                                                        <asp:Label ID="Label41" runat="server" BackColor="#CCCCCC" 
                                                            style="text-align: right" Width="100px"></asp:Label>
                                                        <br />
                                                        Total Moneda Local:
                                                        <asp:Label ID="Label47" runat="server" BackColor="#CCCCCC" 
                                                            style="text-align: right" Width="100px"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style30" align="right">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style30">
                                                        <table cellpadding="0" cellspacing="0" class="style1">
                                                            <tr>
                                                                <td class="style32" valign="top">
                                                                    Elaborado Por:
                                                                    <asp:Label ID="Label46" runat="server" BackColor="#CCCCCC" Width="200px"></asp:Label>
                                                                </td>
                                                                <td class="style33">
                                                                    Recibe:____________________________<br /> C.C</td>
                                                                <td class="style33" valign="top">
                                                                    <asp:Panel ID="Panel14" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                                        BorderWidth="1px" Height="80px" Width="80px">
                                                                    </asp:Panel>
                                                                </td>
                                                            </tr>
                                                        </table>
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
    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
