<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfEnvioProspecto.aspx.vb" Inherits="Reportes_Varios_wfConsultaDistribuidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 90%;
        }
        .style6
        {
            height: 20px;
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
                          <td width="90%">Envio De Prospectos</td>
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
            <td align="left" valign="top">
                <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                    BorderWidth="1px" Height="200px" Width="400px" DefaultButton="Button1">
                    <table cellpadding="0" cellspacing="0" class="style1" align="left" 
                        style="width: 100%">
                        <tr>
                            <td align="center" bgcolor="#006699" colspan="2" 
                                style="color: #FFFFFF; font-family: 'Courier New', Courier, monospace">
                                Busqueda Por</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Codigo Afiliado" />
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="campver" Width="150px"></asp:TextBox>
                                <label>
                                <asp:Button ID="Button1" runat="server" Height="30px" 
                                    style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                                    Text="Buscar" Width="100px" />
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Enviados" />
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left" class="style6">
                                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="No Enviados" />
                            </td>
                            <td align="left" class="style6">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton6" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Activos" />
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" Text="Eliminados" />
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                                    style="font-family: 'Courier New', Courier, monospace" 
                                    Text="Todos" />
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
                </asp:Panel>
            </td>
            <td align="left" valign="top">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" style="width: 462px" valign="top">
                &nbsp;</td>
            <td align="left" valign="top">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label3" runat="server" 
                    style="font-size: medium; color: #0000FF; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
            </td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style1">
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Both" 
                                Width="1050px">
                                <table class="style1">
                                    <tr>
                                        <td align="left">
                                            <asp:Button ID="Button5" runat="server" 
                                                style="color: #FFFFFF; background-color: #339933" Text="Confirmar Envio" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" Width="100%">
                                                <Columns>
                                                    <asp:CommandField ButtonType="Button" SelectText="Generar Carta" 
                                                        ShowSelectButton="True" />
                                                    <asp:TemplateField HeaderText="Enviar">
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                                        </ItemTemplate>
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="idprospecto" HeaderText="Id" />
                                                    <asp:BoundField DataField="afiliado" HeaderText="Afiliado" />
                                                    <asp:BoundField DataField="telefono" HeaderText="Telefono Afiliado" />
                                                    <asp:BoundField DataField="celular" HeaderText="Celular Afiliado" />
                                                    <asp:BoundField DataField="Email1" HeaderText="Email Afiliado" />
                                                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                                                    <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
                                                    <asp:BoundField DataField="barrio" HeaderText="Barrio" />
                                                    <asp:BoundField DataField="tp" HeaderText="Telefono" />
                                                    <asp:BoundField DataField="movil" HeaderText="Movil" Visible="False">
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="email" HeaderText="Email" />
                                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                                    <asp:BoundField DataField="enviado" HeaderText="Enviado?" />
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
                                <br />
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
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
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

