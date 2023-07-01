<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteTarjetaCredito.aspx.vb" Inherits="Reportes_Varios_wfReporteConsignacion" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style12
        {
            color: #000066;
        }
        .botonform
        {
            font-weight: 700;
            font-family: "Courier New", Courier, monospace;
            color: #FFFFFF;
            background-color: #006699;
        }
        .style13
        {
            width: 100%;
        }
        .style14
        {
            width: 184px;
        }
        .style15
        {
            width: 182px;
        }
        .style16
        {
            width: 104px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Buscar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar Excell" 
                Width="40px" ID="ImageButton6"></asp:ImageButton>
                      </td>

            <td width="90%">Consulta De Tarjetas De Credito</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 100%; font-family: 'Courier New', Courier, monospace">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1" style="width: 100%">
                            <tr>
                                <td class="style12">
                                    <table class="style13" style="width: 100%">
                                        <tr>
                                            <td class="style14">
                                                Id:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Numero Aprobacion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="250px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Fecha Aprobacion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Valor Dolar:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" 
                                                    style="text-align: right" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Valor Transaccion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" 
                                                    style="text-align: right" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Valor Local Transaccion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True" 
                                                    style="text-align: right" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Valor Utilizado:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" 
                                                    style="text-align: right" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Titular:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox15" runat="server" ReadOnly="True" Width="250px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Observacion:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox16" runat="server" ReadOnly="True" Width="250px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Empresa:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox17" runat="server" ReadOnly="True" Width="50px" CssClass="campver"></asp:TextBox>
                                                <asp:TextBox ID="TextBox18" runat="server" ReadOnly="True" Width="300px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                Sucursal:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox19" runat="server" ReadOnly="True" Width="50px" CssClass="campver"></asp:TextBox>
                                                <asp:TextBox ID="TextBox20" runat="server" ReadOnly="True" Width="300px" CssClass="campver"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style14">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                                                    Height="300px" Width="100%">
                                                    <asp:TabPanel ID="tab1" runat="server" HeaderText="Afiliados Cargados">
                                                        <ContentTemplate>
                                                            <br />
                                                            <table class="style13">
                                                                <tr>
                                                                    <td align="center">
                                                                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                            CellPadding="3">
                                                                            <Columns>
                                                                                <asp:BoundField DataField="codigoafiliado" HeaderText="Codigo Afiliado" />
                                                                                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
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
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </ContentTemplate>
                                                    </asp:TabPanel>
                                                    <asp:TabPanel ID="tab2" runat="server" HeaderText="Remisiones Cargadas">
                                                        <ContentTemplate>
                                                            <br />
                                                            <table class="style13">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Panel ID="Panel5" runat="server" Height="200px" ScrollBars="Both" 
                                                                            Width="100%">
                                                                            <table class="style13">
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                            CellPadding="3">
                                                                                            <Columns>
                                                                                                <asp:BoundField DataField="idencfacturapro" HeaderText="Remision No" />
                                                                                                <asp:BoundField DataField="fechaencfacturapro" 
                                                                                                    DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remision" />
                                                                                                <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
                                                                                                <asp:BoundField DataField="valorCoEncFacturaPro" DataFormatString="{0:N0}" 
                                                                                                    HeaderText="Valor" />
                                                                                                <asp:BoundField DataField="fpEfectivoEncFacturaPro" 
                                                                                                    HeaderText="Pago Efectivo" />
                                                                                                <asp:BoundField DataField="fpConsigEncFacturaPro" 
                                                                                                    HeaderText="Pago Consignacion" />
                                                                                                <asp:BoundField DataField="fpTarjetaEncFaturaPro" HeaderText="Pago Tarjeta" />
                                                                                                <asp:BoundField DataField="fpHotelEncFacturaPro" HeaderText="Pago Hotel" />
                                                                                                <asp:BoundField DataField="fpCruceEncfacturaPro" HeaderText="Pago Cruce" />
                                                                                                <asp:BoundField DataField="valorEfectivoEncFacturaPro" 
                                                                                                    DataFormatString="{0:N2}" HeaderText="Valor Efectivo" />
                                                                                                <asp:BoundField DataField="valorconsigEncFacturaPro" DataFormatString="{0:N2}" 
                                                                                                    HeaderText="Valor Consignacion" />
                                                                                                <asp:BoundField DataField="valorusEncFacturaPro" DataFormatString="{0:N2}" 
                                                                                                    HeaderText="Valor Tarjeta" />
                                                                                                <asp:BoundField DataField="valorcruceEncFacturaPro" DataFormatString="{0:N2}" 
                                                                                                    HeaderText="Valor Cruce" />
                                                                                                <asp:BoundField DataField="valorhotelEncFacturaPro" DataFormatString="{0:N2}" 
                                                                                                    HeaderText="Valor Hotel" />
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
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </table>
                                                                        </asp:Panel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </ContentTemplate>
                                                    </asp:TabPanel>
                                                </asp:TabContainer>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                    <asp:View ID="View2" runat="server">
                        <table class="style13">
                            <tr>
                                <td class="style15">
                                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                                        Text="Numero De Aprobación" />
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox12" runat="server" Width="250px" CssClass="campver"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" 
                                        Text="Fecha Aprobacion" />
                                </td>
                                <td>
                                    <table class="style13">
                                        <tr>
                                            <td class="style16">
                                                Fecha Inicial:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox10" runat="server" CssClass="campver"></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox10_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                                                    TargetControlID="TextBox10">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton4" runat="server" Height="22px" 
                                                    ImageUrl="~/images/calendario_imagen.png" Width="22px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style16">
                                                Fecha Final:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox11" runat="server" CssClass="campver"></asp:TextBox>
                                                <asp:CalendarExtender ID="TextBox11_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton5" 
                                                    TargetControlID="TextBox11">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="ImageButton5" runat="server" Height="22px" 
                                                    ImageUrl="~/images/calendario_imagen.png" Width="22px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" 
                                        Text="Por Empresas" />
                                </td>
                                <td>
                                    <table class="style13">
                                        <tr>
                                            <td>
                                                Empresa:</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                                    style="margin-left: 0px" Width="300px" CssClass="campver">
                                                </asp:DropDownList>
                                                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                                                    Text="Incluir Sucursal" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text="Sucursal:"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList2" runat="server" Width="300px" CssClass="campver">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <label>
                                    <asp:Button ID="Button1" runat="server" Height="30px" 
                                        style="color: #FFFFFF; font-weight: 700; font-family: 'Courier New', Courier, monospace; background-color: #006699" 
                                        Text="Buscar" Width="124px" />
                                    </label>
                                    <asp:Label ID="Label5" runat="server" 
                                        style="color: #FF0000; font-weight: 700; font-family: 'Book Antiqua'"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table cellpadding="0" cellspacing="0" class="style13">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel4" runat="server" Height="600px" ScrollBars="Vertical">
                                        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="3" Width="100%">
                                            <Columns>
                                                <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                                <asp:BoundField DataField="idTarjetaCre" HeaderText="Id" />
                                                <asp:BoundField DataField="aprobacionTarjetaCre" 
                                                    HeaderText="Numero Aprobacion" />
                                                <asp:BoundField DataField="fechaAprobacionTarjetaCre" DataFormatString="{0:yyyy/MM/dd}" 
                                                    HeaderText="Fecha Aprobacion" />
                                                <asp:BoundField DataField="valorUsdTarjetaCre" DataFormatString="{0:N2}" 
                                                    HeaderText="Valor Transaccion">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorDolarTarjetaCre" 
                                                    DataFormatString="{0:N2}" HeaderText="Valor Dolar">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorUtilizado" HeaderText="Valor Utilizado" 
                                                    DataFormatString="{0:N2}" >
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="valorLocalTarjetaCre" DataFormatString="{0:N2}" 
                                                    HeaderText="Valor Local">
                                                <ItemStyle HorizontalAlign="Right" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="titularTarjetaCre" HeaderText="Titular" />
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
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                </asp:MultiView>
            </td>
        </tr>
        </table>
</asp:Content>

