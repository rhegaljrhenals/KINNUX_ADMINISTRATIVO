<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfUniversidadEmpresarios.aspx.vb" Inherits="Reportes_Varios_wfConsultaDistribuidor" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 90%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">

                                                    <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" 
                    ToolTip="Exportar a excell" Width="40px" ID="ImageButton10" Visible="False"></asp:ImageButton>

                <br />
              </td>
                          <td width="90%">Calificación Eje Cafetero</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style5" style="width: 100%">
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <table class="nav-justified">
                    <tr>
                        <td colspan="4">
                <asp:Label ID="Label3" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                <asp:Panel ID="Panel3" runat="server" Height="350px" ScrollBars="Vertical">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" Width="100%">
                        <Columns>
                            <asp:CommandField SelectText="Ver Frontales" ShowSelectButton="True" />
                            <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres">
                            <ItemStyle Width="250px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="febcalifEmpresario" HeaderText="Compra Febrero">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="marzocalifEmpresario" HeaderText="Compra Marzo">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="abrilcalifEmpresario" HeaderText="Compra Abril">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="mayocalifEmpresario" HeaderText="Compra Mayo">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="juniocalifEmpresario" HeaderText="Compra Junio">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="vg1califEmpresario" HeaderText="V. Grupal Frontal">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="vggencalifEmpresario" HeaderText="V. Grupal 3 Nivel">
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="calificadocalifEmpresario" HeaderText="Calificado">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="cuposEmpresario" HeaderText="Cupos">
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
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            Frontales</td>
                    </tr>
                    <tr>
                        <td colspan="4">
                <asp:Panel ID="Panel4" runat="server" Height="350px" ScrollBars="Vertical">
                    <asp:GridView ID="GridView3" runat="server" 
    AutoGenerateColumns="False" CellPadding="3" Width="100%" BackColor="White" 
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="nombres" 
            HeaderText="Nombres" />
                            <asp:BoundField DataField="total" 
            HeaderText="Puntos Personales">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="vg1califEmpresario" 
            HeaderText="V. Grupal Frontal">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="vgafilcalifEmpresario" 
            HeaderText="V. Grupal 3 Nivel">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="nuevocalifEmpresario" 
            HeaderText="Nuevo">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="White" 
        ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" 
        ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" 
        HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" 
        ForeColor="White" />
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
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
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

