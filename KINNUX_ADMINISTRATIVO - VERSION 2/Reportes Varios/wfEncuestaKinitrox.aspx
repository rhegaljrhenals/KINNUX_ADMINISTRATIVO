<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfEncuestaKinitrox.aspx.vb" Inherits="Reportes_wfEncuestaKinitrox" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
    {
        width: 100%;
    }
    .style5
    {
        width: 90px;
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
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" Height="40px" ToolTip="Exportar a Excell" Width="40px" ID="ImageButton2"></asp:ImageButton>
              </td>

            <td width="90%">Encuesta Sistema Circulatorio</td>
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
            <td align="left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Button ID="Button6" runat="server" Text="Encuesta Guiada" />
                <asp:Button ID="Button7" runat="server" Text="Encuesta Rápida" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="text-align: center">
                <asp:Label ID="Label5" runat="server" style="color: #005DAA; font-size: small; font-weight: 700; font-style: italic"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table class="style4">
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Height="300px" ScrollBars="Vertical" Width="100%">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True" style="font-weight: 700" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Encuesta" ShowSelectButton="True" />
                                                <asp:BoundField DataField="idafiliado" HeaderText="Id" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="email" HeaderText="email" />
                                                <asp:BoundField DataField="telefono" HeaderText="telefono" />
                                                <asp:BoundField DataField="patrocinador" HeaderText="Patrocinador" />
                                                <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                <asp:BoundField DataField="pais" HeaderText="Pais" />
                                                <asp:BoundField HeaderText="Realizó Encuesta?">
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:CommandField ButtonType="Button" DeleteText="Eliminar" ShowDeleteButton="True">
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:CommandField>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:Button ID="Button5" runat="server" Text="Enviar Encuesta" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel2" runat="server" Height="450px" ScrollBars="Vertical" Width="1050px">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True" style="font-weight: 700" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="numero" HeaderText="#" />
                                                <asp:BoundField DataField="enunciadopregunta" HeaderText="Pregunta" />
                                                <asp:BoundField DataField="respuesta" HeaderText="Respuesta">
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="View2" runat="server">

                        <table class="style4">
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel3" runat="server" Height="300px" ScrollBars="Vertical" Width="100%">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True" style="font-weight: 700" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Encuesta" ShowSelectButton="True" />
                                                <asp:BoundField DataField="idafiliado" HeaderText="Id" />
                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="email" HeaderText="email" />
                                                <asp:BoundField DataField="telefono" HeaderText="telefono" />
                                                <asp:BoundField DataField="patrocinador" HeaderText="Patrocinador" />
                                                <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                                <asp:BoundField DataField="pais" HeaderText="Pais" />
                                                <asp:BoundField HeaderText="Realizó Encuesta?">
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:CommandField ButtonType="Button" DeleteText="Eliminar" ShowDeleteButton="True">
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:CommandField>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:Button ID="Button8" runat="server" Text="Enviar Encuesta" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel4" runat="server" Height="200px" ScrollBars="Vertical" Width="100%">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True" style="font-weight: 700" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="hipertension" HeaderText="Hipertension" >
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="hipotension" HeaderText="Hipotension" />
                                                <asp:BoundField DataField="calto" HeaderText="Colesterol Alto" />
                                                <asp:BoundField DataField="dcerebral" HeaderText="Derrame Cerebral" />
                                                <asp:BoundField DataField="aneurisma" HeaderText="Aneurisma" />
                                                <asp:BoundField DataField="Arterioesclerosis" HeaderText="Arterioesclerosis" />
                                                <asp:BoundField DataField="taquicardia" HeaderText="Taquicardia" />
                                                <asp:BoundField DataField="icardiaca" HeaderText="Insuficiencia Cardiaca" />
                                                <asp:BoundField DataField="arritmias" HeaderText="Arritmias" />
                                                <asp:BoundField DataField="apecho" HeaderText="Angina De Pecho" />
                                                <asp:BoundField DataField="anemia" HeaderText="Anemia" />
                                                <asp:BoundField DataField="leucemia" HeaderText="Leucemia" />
                                                <asp:BoundField DataField="isquemia" HeaderText="Isquemia" />
                                                <asp:BoundField DataField="hemofilia" HeaderText="Hemofilia" />
                                                <asp:BoundField DataField="varices" HeaderText="Varices" />
                                                <asp:BoundField DataField="trombosis" HeaderText="Trombosis" />
                                                <asp:BoundField DataField="flebitis" HeaderText="Flebitis" />
                                                <asp:BoundField DataField="diabetes" HeaderText="Diabetes" />
                                                <asp:BoundField DataField="infarto" HeaderText="Infarto" />
                                                <asp:BoundField DataField="alergias" HeaderText="Alergias" />
                                                <asp:BoundField DataField="hemorroides" HeaderText="Hemorroides" />
                                                <asp:BoundField DataField="sangrado" HeaderText="Sangrado" />



                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Right" />
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
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>

                    </asp:View>
                </asp:MultiView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td>
                            &nbsp;</td>
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

