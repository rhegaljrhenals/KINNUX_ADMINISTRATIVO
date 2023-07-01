<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfAnularRemisiones.aspx.vb" Inherits="herramientas_wfAnularRemisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


    
        .style16
        {
            color: #000066;
        }
        .style17
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">
                    <asp:ImageButton runat="server" 
                    ImageUrl="~/Imagenes/Error 2.png" Height="40px" ToolTip="Anular" Width="40px" 
                    ID="ImageButton9"></asp:ImageButton>

                <br />
              </td>
              <td width="90%">Anular Remisiones</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="width: 100%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Panel ID="Panel7" runat="server" BorderColor="#000066" BorderStyle="Solid" 
                    BorderWidth="1px" Height="137px" Width="450px">
                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                        <tr>
                            <td colspan="2" 
                                style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                Confirmar Anulación</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Image ID="Image2" runat="server" Height="50px" 
                                    ImageUrl="~/Imagenes/Check Mark.png" Width="50px" />
                            </td>
                            <td align="left" style="font-size: large">
                                Está seguro de anular esta Remisión?</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="Button1" runat="server" 
                                    style="color: #FFFFFF; font-weight: 700; background-color: #006699" Text="Si" 
                                    Width="100px" />
                                <asp:Button ID="Button2" runat="server" 
                                    style="color: #FFFFFF; font-weight: 700; background-color: #006699" Text="No" 
                                    Width="100px" />
                            </td>
                        </tr>
                    </table>
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
            <td align="center" colspan="2">
                <asp:Panel ID="Panel2" runat="server" DefaultButton="ImageButton10" 
                    Width="350px">
                    Remision Numero:<asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" 
                        ImageUrl="~/Imagenes/buscar.png" ToolTip="Buscar Remisión" Width="30px" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Remision numero:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Fecha:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Puntos:</td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
                            <asp:TextBox ID="TextBox34" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Afiliado:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Empresa:</td>
                        <td>
                            <asp:TextBox ID="TextBox31" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Sucursal:</td>
                        <td>
                            <asp:TextBox ID="TextBox32" runat="server" ReadOnly="True" Width="60px"></asp:TextBox>
                            <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Tipo Factura:</td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Usuario:</td>
                        <td>
                            <asp:TextBox ID="TextBox30" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Estado:</td>
                        <td>
                            <asp:TextBox ID="TextBox33" runat="server" ReadOnly="True"></asp:TextBox>
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
            <td align="left">
                <asp:Button ID="Button3" runat="server" Text="Detalle Remision" Width="200px" />
                <asp:Button ID="Button4" runat="server" Text="Datos Adicionales" 
                    Width="200px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table class="style17">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" style="font-size: small" Width="100%">
                                        <Columns>
                                            <asp:BoundField DataField="idProducto" HeaderText="Id">
                                            <ItemStyle Width="50px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="nombreproducto" HeaderText="Descripción" />
                                            <asp:BoundField DataField="cantidadDetFacturaPro" HeaderText="Cantidad">
                                            <ItemStyle HorizontalAlign="Right" Width="50px" />
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
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Panel ID="Panel4" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                        BorderWidth="1px" Height="150px" Width="400px">
                                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                            <tr>
                                                <td align="center" colspan="2" 
                                                    style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                                    Forma De Pago</td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <span class="style16">Efectivo:</span><asp:Label ID="Label2" runat="server" 
                                                        CssClass="style16" Text="[]"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox11" runat="server" ReadOnly="True" 
                                                        style="text-align: right"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <span class="style16">Cruce De Comisiones:</span><asp:Label ID="Label3" 
                                                        runat="server" CssClass="style16" Text="[]"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True" 
                                                        style="text-align: right"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <span class="style16">Abono Hotel:</span><asp:Label ID="Label4" runat="server" 
                                                        CssClass="style16" Text="[]"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True" 
                                                        style="text-align: right"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <span class="style16">Consignación:</span><asp:Label ID="Label5" runat="server" 
                                                        CssClass="style16" Text="[]"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" 
                                                        style="text-align: right"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <span class="style16">Tarjeta De Credito:</span><asp:Label ID="Label6" 
                                                        runat="server" CssClass="style16" Text="[]"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox15" runat="server" ReadOnly="True" 
                                                        style="text-align: right"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                    <asp:View ID="View2" runat="server">
                        <table class="style17">
                            <tr>
                                <td>
                                    <table class="style17">
                                        <tr>
                                            <td>
                                                <asp:Panel ID="Panel5" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                    BorderWidth="1px" Height="208px" ScrollBars="Both" Width="500px">
                                                    <table cellpadding="0" cellspacing="0" class="style1">
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" style="font-size: small" Width="100%">
                                                                    <Columns>
                                                                        <asp:BoundField DataField="idFacturaConsig" HeaderText="#">
                                                                        <ItemStyle Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="idConsignacion" HeaderText="Id">
                                                                        <ItemStyle Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="numeroConsignacion" 
                                                                            HeaderText="Número Consigancion" />
                                                                        <asp:BoundField DataField="valorConsignacion" HeaderText="Valor">
                                                                        <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="valorUtilizadoConsignacion" 
                                                                            HeaderText="valor Utilizado" />
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
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                <asp:Panel ID="Panel12" runat="server" BorderColor="#CCCCCC" 
                                                    BorderStyle="Solid" BorderWidth="1px" Height="208px" ScrollBars="Both" 
                                                    Width="500px">
                                                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                                        <tr>
                                                            <td align="center" colspan="2" 
                                                                style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                                                Datos Tarjetas de Crédito</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                    CellPadding="3" Height="40px" style="font-size: small" Width="100%">
                                                                    <Columns>
                                                                        <asp:BoundField DataField="idtarjeta" HeaderText="Id">
                                                                        <ItemStyle Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="aprobacionTarjetaCre" HeaderText="# Aprobación">
                                                                        <ItemStyle Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="valorUsdTarjetaCre" HeaderText="Valor Us">
                                                                        <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="valorDolarTarjetaCre" HeaderText="Valor Dolar">
                                                                        <ItemStyle HorizontalAlign="Right" Width="80px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="titularTarjetaCre" HeaderText="Titular Tarjeta">
                                                                        <ItemStyle HorizontalAlign="Left" Width="50px" />
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
                                                            </td>
                                                        </tr>
                                                    </table>
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
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Panel ID="Panel6" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                                    BorderWidth="1px" Height="208px" Width="500px">
                                                    <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                                                        <tr>
                                                            <td align="center" colspan="2" 
                                                                style="color: #FFFFFF; font-weight: 700; background-color: #006699">
                                                                Apartados</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                Recibo 1:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox21" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="50px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox24" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="100px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox27" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="120px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                Recibo 2:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox22" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="50px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox25" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="100px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox28" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="120px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style16">
                                                                Recibo 3:</td>
                                                            <td>
                                                                <asp:TextBox ID="TextBox23" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="50px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox26" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="100px"></asp:TextBox>
                                                                <asp:TextBox ID="TextBox29" runat="server" ReadOnly="True" 
                                                                    style="text-align: right" Width="120px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                            <td>
                                                &nbsp;</td>
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
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
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
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                </asp:MultiView>
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
</asp:Content>

