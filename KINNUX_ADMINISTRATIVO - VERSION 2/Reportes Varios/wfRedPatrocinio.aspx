<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfRedPatrocinio.aspx.vb" Inherits="Reportes_Varios_wfRedUninivel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                <link href="../StylesKINNUX/styleafilia.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        

    
        .style6
        {
            width: 100%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
                          &nbsp;</td>
      <td>
      
            &nbsp;</td>

            <td width="90%">Red De Patrocinio
                <asp:Label ID="Label21" runat="server"></asp:Label>
                      </td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
    <div align="center">
    
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="width: 70%; font-family: 'Courier New', Courier, monospace;">
            <tr>
                <td>
                <table class="style6">
                    <tr>
                        <td class="style7">
                            Periodo:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="campver">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="campver">
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
                            <asp:Button ID="Button1" runat="server" Text="Mostrar" />
                            <asp:Label ID="Label20" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style7" colspan="2">
                                <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Both" 
                                    Width="830px">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                        CellPadding="4" CssClass="Grid" style="font-size: x-small" 
                                        ForeColor="#333333">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo">
                                            <HeaderStyle Width="100px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="apellidosynombre" HeaderText="Nombres">
                                            <HeaderStyle Width="300px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="nivel" HeaderText="Nivel" >
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="ts" HeaderText="TS">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="sts" HeaderText="STS">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn1" HeaderText="Grupal Nivel 1">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn2" HeaderText="Grupal Nivel 2">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn3" HeaderText="Grupal Nivel 3">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn4" HeaderText="Grupal Nivel 4">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn5" HeaderText="Grupal Nivel 5">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn6" HeaderText="Grupal Nivel 6">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn7" HeaderText="Grupal Nivel 7">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn8" HeaderText="Grupal Nivel 8">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="gn15" HeaderText="Grupal Nivel 15" />
                                            <asp:BoundField DataField="gn20" HeaderText="Grupal Nivel 20" />
                                        </Columns>
                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                    </asp:GridView>
                                </asp:Panel>
                            </td>
                    </tr>
                    <tr>
                        <td class="style7" colspan="2">
                            &nbsp;</td>
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
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
