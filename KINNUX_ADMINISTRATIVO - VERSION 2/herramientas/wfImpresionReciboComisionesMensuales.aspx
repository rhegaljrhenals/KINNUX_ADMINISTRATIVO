<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfImpresionReciboComisionesMensuales.aspx.vb" Inherits="Facturacion_wfImpresionFactura" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title >
</title>
    <script type = "text/javascript">
        function PrintPanel() {
//            var panel = document.getElementById("panelImpresion").innerHTML;
//            var printWindow = window.open('', '', 'height=799,width=708');
//            printWindow.document.write('<html><head><title>KINNUX</title>');
//            printWindow.document.write('</head><body >');
//            printWindow.document.write(panel);
//            printWindow.document.write('</body></html>');
//            printWindow.document.close();
//            printWindow.print();
//            printWindow.document.close();
//            //*****************************************************************************
            var divElements = document.getElementById("panelImpresion").innerHTML;
            var oldPage = document.body.innerHTML;
            document.body.innerHTML =
            "<html><head><title>KINNUX</title></head><body>" +
            divElements + "</body>";
            window.print();
            window.close();
            document.body.innerHTML = oldPage;
            //*****************************************************************************
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
                                                        <asp:Panel ID="Panel18" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table cellpadding="0" cellspacing="0" class="style4">
                                                                <tr>
                                                                    <td>
                                                                        Identificación:</td>
                                                                    <td>
                                                                        <asp:TextBox ID="TextBox101" runat="server" ReadOnly="True" 
                                                                            style="text-align: left" Width="200px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <table cellpadding="0" cellspacing="0" class="style4">
                                                                            <tr>
                                                                                <td align="right">
                                                                                    Número De Recibo:</td>
                                                                                <td align="right">
                                                                                    <asp:TextBox ID="TextBox103" runat="server" ReadOnly="True" 
                                                                                        style="text-align: right" Width="114px"></asp:TextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="right">
                                                                                    Fecha (Año/Mes/Dia):</td>
                                                                                <td align="right">
                                                                                    <asp:TextBox ID="TextBox104" runat="server" ReadOnly="True" 
                                                                                        style="text-align: right" Width="114px"></asp:TextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        Afiliado:</td>
                                                                    <td colspan="2">
                                                                        <asp:TextBox ID="TextBox102" runat="server" ReadOnly="True" 
                                                                            style="text-align: justify" Width="350px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        &nbsp;Pago Comisión Mensual (<asp:Label ID="Label48" runat="server"></asp:Label>
                                                        )<asp:TextBox ID="TextBox96" runat="server" ReadOnly="True" 
                                                            style="text-align: right" Visible="False" Width="5px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Panel ID="Panel15" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table cellpadding="0" cellspacing="0" class="style4">
                                                                <tr>
                                                                    <td align="left">
                                                                        <table cellpadding="0" cellspacing="0" class="style4">
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style4" style="width: 400px">
                                                                                        <tr>
                                                                                            <td>
                                                                                                Inicio Rápido:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox90" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Uninivel:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox91" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Avnce:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox92" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Generacional Binario:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox93" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Generacional:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox94" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td valign="top">
                                                                                    <table cellpadding="0" cellspacing="0" class="style4">
                                                                                        <tr>
                                                                                            <td>
                                                                                                Estructura:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox95" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                MultiEstructura:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox97" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Compresión IR Diario:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox98" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                                Bono Carro:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox99" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td align="right">
                                                                                                Total:</td>
                                                                                            <td>
                                                                                                <asp:TextBox ID="TextBox100" runat="server" ReadOnly="True" 
                                                                                                    style="text-align: right"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
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
                                                    <td align="center">
                                                        <asp:Panel ID="Panel16" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                            BorderWidth="1px">
                                                            <table class="style4">
                                                                <tr>
                                                                    <td align="left" style="width: 85px" valign="top">
                                                                        <asp:Panel ID="Panel17" runat="server" BorderColor="Black" BorderStyle="Solid" 
                                                                            BorderWidth="1px" Height="80px" Width="80px">
                                                                        </asp:Panel>
                                                                        &nbsp; Huella</td>
                                                                    <td align="left" valign="top">
                                                                        _______________________________<br /> Recibí Conforme<br /> C.C<br />
                                                                        </td>
                                                                    <td align="left" valign="top">
                                                                        Entregado Por:<br />
                                                                        <asp:TextBox ID="TextBox105" runat="server" ReadOnly="True" 
                                                                            style="text-align: left" Width="300px"></asp:TextBox>
                                                                    </td>
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
