<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfCalificacionCrucero2016.aspx.vb" Inherits="Reportes_Varios_wfCalificacionCrucero2016" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            color: #006699;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td width="5%" align="center">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
              </td>
            <td width="5%" align="center">
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
              </td>

            <td width="90%">Calificación Crucero Kinnux 2016</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label4" runat="server" 
                    style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style2">
                            Pais:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="300px" 
                                CssClass="campver">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table class="style1">
                                <tr>
                                    <td>
                <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Both" 
                    Width="1050px">
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" 
                        style="font-weight: 700" Width="100%">
                        <Columns>
                            <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                            <asp:BoundField DataField="codigoAfiliado" HeaderText="Codigo" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="nombrePais" HeaderText="Pais" />
                            <asp:BoundField DataField="nombreDpto" HeaderText="Dpto" />
                            <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
                            <asp:BoundField DataField="vpcalifCrucero" HeaderText="Volumen Personal" 
                                DataFormatString="{0:N2}" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="vg1califCrucero" HeaderText="Acumulado Nivel 1">
                            </asp:BoundField>
                            <asp:BoundField DataField="vggencalifCrucero" HeaderText="Vol Grupal Nivel 3" />
                            <asp:BoundField DataField="calificadocalifCrucero" HeaderText="Calificado">
                            </asp:BoundField>
                            <asp:BoundField DataField="cuposCrucero" HeaderText="Cupos" >
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="novcalifcrucero" HeaderText="Nov(2015)" />
                            <asp:BoundField DataField="diccalifcrucero" HeaderText="Dic(2015)" />
                            <asp:BoundField DataField="enecalifcrucero" HeaderText="Ene(2016)" />
                            <asp:BoundField DataField="febcalifcrucero" HeaderText="Feb(2016)" />
                            <asp:BoundField DataField="marzocalifcrucero" HeaderText="Mar(2016)" />
                            <asp:BoundField DataField="abrilcalifcrucero" HeaderText="Abr(2016)" />
                            <asp:BoundField DataField="mayocalifcrucero" HeaderText="May(2016)" />
                            <asp:BoundField DataField="juniocalifcrucero" HeaderText="Jun(2016)" />
                            <asp:BoundField DataField="juliocalifcrucero" HeaderText="Jul(2016)" />
                            <asp:BoundField DataField="agostocalifcrucero" HeaderText="Ago(2016)" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Right" 
                            Font-Bold="True" />
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
                                    <td valign="top">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                <asp:Panel ID="Panel2" runat="server" Height="300px" ScrollBars="Vertical" 
                    Width="100%">
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" ShowHeaderWhenEmpty="True" style="font-weight: 700">
                                    <Columns>
                                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                        <asp:BoundField DataField="vpcalifCrucero" DataFormatString="{0:N2}" 
                                            HeaderText="Puntos Personales">
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="vgafilcalifCrucero" 
                                            HeaderText="Volumen Grupal 3 Nivel">
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nuevocalifCrucero" HeaderText="Nuevo" />
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
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="1px" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                                    </td>
                                    <td>
                                        &nbsp;</td>
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
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

