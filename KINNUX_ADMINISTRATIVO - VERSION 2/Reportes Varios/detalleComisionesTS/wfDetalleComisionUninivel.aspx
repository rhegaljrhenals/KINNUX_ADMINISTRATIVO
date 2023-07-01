<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfDetalleComisionUninivel.aspx.vb" Inherits="wfReporteDetalleComisionIR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table width="800px" border="0" cellpadding="0" cellspacing="0" 
                class="tabletop">
  <tr>
    <td width="9%" align="center">&nbsp;</td>
    <td width="91%" 
          style="font-size: xx-large; font-family: 'Courier New', Courier, monospace; color: #0000FF">
        Detalle Comisión 
        Uninivel</td>
  </tr>
  <tr>
    <td width="9%" align="center">&nbsp;</td>
    <td width="91%" 
          style="font-size: xx-large; font-family: 'Courier New', Courier, monospace; color: #0000FF">
        &nbsp;</td>
  </tr>
</table>

        <table cellpadding="0" cellspacing="0" class="style1" style="width: 800px">
            <tr>
                <td align="center">
                                                    <asp:Panel runat="server" ScrollBars="Vertical" 
                        Height="232px" ID="Panel7" Width="650px">
                                                        <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                CellPadding="3" 
                                                                
                                                            style="font-size: small; font-family: 'Courier New', Courier, monospace;" 
                                                            Width="100%">
                                                            <Columns>
                                                                <asp:BoundField DataField="nombres" HeaderText="Afiliado" >
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="niveldetcomisionunts" HeaderText="Nivel" 
                                                                    DataFormatString="{0:N0}" >
                                                                <ItemStyle HorizontalAlign="Right" />
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="valordetcomisionunts" HeaderText="Valor" 
                                                                    DataFormatString="{0:N0}" >
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

                                                    </asp:Panel>

                                                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Height="30px" 
                        style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                        Text="Cerrar" Width="94px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
