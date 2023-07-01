<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfRedBinaria.aspx.vb" Inherits="Reportes_Varios_wfRedBinaria" %>

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
        

    
        .style2
        {
            width: 215px;
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

            <td width="90%">Red Binaria</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
        <table cellpadding="0" cellspacing="0" class="style1" 
            style="width: 70%; font-family: 'Courier New', Courier, monospace;">
            <tr>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                Seleccione Periodo De Compra:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Mes</asp:ListItem>
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
                                <asp:DropDownList ID="DropDownList2" runat="server">
                                </asp:DropDownList>
                                <asp:Button ID="Button1" runat="server" Text="Mostrar" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel3" runat="server" Height="526px" ScrollBars="Vertical">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                            CellPadding="3" CssClass="tabladathead" style="font-size: small">
                            <Columns>
                                <asp:CommandField SelectText="Ver Compras" ShowSelectButton="True" />
                                <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo">
                                <HeaderStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="identificacion" HeaderText="Identificacion" 
                                    Visible="False" />
                                <asp:BoundField DataField="apellidosynombre" HeaderText="Apellidos y Nombres">
                                <HeaderStyle Width="300px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="codigopatrocinador" HeaderText="Patrocinador">
                                <HeaderStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="directo" HeaderText="Apalancado" />
                                <asp:BoundField DataField="posicion" HeaderText="Posicion" />
                                <asp:BoundField DataField="indirecto" HeaderText="PIndirecto" Visible="False" />
                                <asp:BoundField DataField="nodo" HeaderText="Leg" Visible="False" />
                                <asp:BoundField DataField="Rango" HeaderText="Rango" Visible="False" />
                                <asp:BoundField DataField="left" HeaderText="l" />
                                <asp:BoundField DataField="right" HeaderText="r" />
                                <asp:TemplateField HeaderText="Left">
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" Height="20px" Width="20px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Right">
                                    <ItemTemplate>
                                        <asp:Image ID="Image2" runat="server" Height="20px" Width="20px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="email" HeaderText="Email" Visible="False" />
                                <asp:BoundField DataField="rango" HeaderText="Rango" Visible="False" />
                                <asp:BoundField HeaderText="Hizo Compra?" />
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
                <td align="left">
                    <asp:Panel ID="Panel6" runat="server" Height="216px" ScrollBars="Vertical">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="center" style="color: #FFFFFF; background-color: #006699">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" CssClass="Grid" style="font-size: x-small">
                                        <Columns>
                                            <asp:BoundField DataField="idencfacturapro" HeaderText="Remisión Numero">
                                            <HeaderStyle Width="100px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="fechaencfacturapro" 
                                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                            <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                                            <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" />
                                            <asp:BoundField DataField="tipoEncFacturaPro" HeaderText="Tipo Factura" />
                                            <asp:BoundField DataField="puntosEncfacturaPro" HeaderText="Puntos">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="valorCoEncFacturaPro" HeaderText="Valor">
                                            <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="estadoEncfacturaPro" HeaderText="Estado" />
                                            <asp:BoundField DataField="ano" HeaderText="Año" />
                                            <asp:BoundField DataField="mes" HeaderText="Mes" />
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
                        </table>
                    </asp:Panel>
                </td>
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
    </form>
</body>
</html>
