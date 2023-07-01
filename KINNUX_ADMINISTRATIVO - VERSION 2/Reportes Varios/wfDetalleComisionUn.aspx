<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfDetalleComisionUn.aspx.vb" Inherits="Reportes_Varios_wfDetalleComisionIR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        

    
        .style12
        {
            width: 138px;
            height: 133px;
        }
        .style13
        {
            color: #000080;
            font-weight: bold;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
        }
        .style14
        {
            color: #000066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
    <div align="center">
    
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="width: 70%; font-family: 'Courier New', Courier, monospace;">
            <tr>
                <td align="right">
                    <span class="style13">Detalle Comisión Inicio Rápido</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="Label1" runat="server" style="color: #0000FF"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">
                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 500px">
                        <tr>
                            <td class="style14">
                                Valor Nivel 2:</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                    style="text-align: right"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                Valor Nivel 3:</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" 
                                    style="text-align: right"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                Valor Nivel 4:</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" 
                                    style="text-align: right"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                Valor Nivel 5:</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" 
                                    style="text-align: right"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                Valor Nivel 6:</td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" 
                                    style="text-align: right"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="387px" ScrollBars="Vertical">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                            CellPadding="3" CssClass="Grid" style="font-size: small">
                            <Columns>
                                <asp:BoundField DataField="codigoafiliadocom" HeaderText="Codigo">
                                <HeaderStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                <asp:BoundField DataField="niveldetcomisionmesir" HeaderText="Nivel" >
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="porcdetcomisionmesir" HeaderText="Porcentage" >
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="puntosdetcomisionmesir" HeaderText="Puntos" >
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="valordetcomisionmesir" HeaderText="Valor">
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
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    
    </div>
    </form>
</body>
</html>
