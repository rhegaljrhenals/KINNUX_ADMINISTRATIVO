<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfComisiones.aspx.vb" Inherits="Reportes_Varios_wfComisiones2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <%--<link href="StylesKINNUX/styleafilia.css" rel="stylesheet" type="text/css" />--%>
    <link href="../StylesKINNUX/styleafilia.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <center >
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">

                <br />
              </td>
                          <td width="90%">Comisiones</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label4" runat="server" 
                    style="color: #0000FF; font-size: medium; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
&nbsp;-
                <asp:Label ID="Label5" runat="server" 
                    style="color: #0000FF; font-size: medium; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2" 
                style="color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #CCCCCC">
                Comisiones De Inicio Rapido</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="288px" ScrollBars="Vertical">
                    <asp:Label ID="Label6" runat="server" 
                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                    <br />
                    <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" 
                        style="font-size: small; font-family: 'Courier New', Courier, monospace">
                        <Columns>
                            <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remision" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remisión" />
                            <asp:BoundField DataField="idComisionIr" HeaderText="Id Comision" />
                            <asp:BoundField DataField="valorComisionIr" HeaderText="Valor" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="fechaPagoComisionIr" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago Comision" />
                            <asp:BoundField DataField="pagoComisionIr" HeaderText="Estado Comision" />
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
            <td align="center" colspan="2" 
                style="color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #CCCCCC">
                Comisiones Bono De Inscripción</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel2" runat="server" Height="288px" ScrollBars="Vertical">
                    <asp:Label ID="Label7" runat="server" 
                        style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="GridView3" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" 
                        style="font-size: small; font-family: 'Courier New', Courier, monospace">
                        <Columns>
                            <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remision" />
                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remisión" />
                            <asp:BoundField DataField="idComisionKit" HeaderText="Id Comision" />
                            <asp:BoundField DataField="valorComisionkit" HeaderText="Valor" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="fechaPagoComisionkit" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago Comision" />
                            <asp:BoundField DataField="pagoComisionKit" HeaderText="Estado Comision" />
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
    </center>
    </form>
</body>
</html>
