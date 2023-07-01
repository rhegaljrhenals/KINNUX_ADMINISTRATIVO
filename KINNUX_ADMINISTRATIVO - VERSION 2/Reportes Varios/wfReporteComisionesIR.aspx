<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteComisionesIR.aspx.vb" Inherits="Reportes_Varios_wfReporteComisionesIR" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 15px;
        }
        .style3
        {
            color: #000066;
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
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
      
      </td>

            <td width="90%">Comisiones Inicio Rápido Diario</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style3">
                Fecha Inicial:</td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                    TargetControlID="TextBox1">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton4" runat="server" Height="30px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="30px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style2">
                </td>
            <td align="left" class="style2">
                </td>
        </tr>
        <tr>
            <td align="left" class="style3">
                Fecha Final:</td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton5" 
                    TargetControlID="TextBox2">
                </asp:CalendarExtender>
                <asp:ImageButton ID="ImageButton5" runat="server" Height="30px" 
                    ImageUrl="~/images/calendario_imagen.png" Width="30px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style3">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style3">
                Empresas (Pais):</td>
            <td align="left">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="left" class="style3">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style3">
                Tipo:</td>
            <td align="left">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                    Text="Pagadas" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="Pendientes" />
&nbsp;<asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" Text="Sin Cobrar" />
            &nbsp;<asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" 
                    Text="Todas" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style3">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                    Text="Incluir Codigo?" Visible="False" />
            </td>
            <td align="left">
                <asp:Panel ID="Panel2" runat="server">
                    Codigo:
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Panel ID="Panel1" runat="server" Height="815px" ScrollBars="Vertical">
                    <table class="style1">
                        <tr>
                            <td align="center" style="background-color: #CCCCCC">
                                <asp:Label ID="Label4" runat="server" 
                                    
                                    style="color: #000000; font-size: small; font-weight: 700; font-family: 'Courier New', Courier, monospace"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <asp:GridView ID="GridView2" runat="server" 
    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" AutoGenerateColumns="False" ShowFooter="True" Width="100%" 
                        style="font-weight: 700">
                        <Columns>
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="nombreDpto" HeaderText="Departamento" />
                            <asp:BoundField DataField="nombreMunicipio" HeaderText="Ciudad" />
                            <asp:BoundField DataField="valorComisonIr" HeaderText="Valor">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="quiencompro" HeaderText="Quien Compró?" />
                            <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                            <asp:BoundField DataField="fechaEncFacturaPro" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Remisión" />
                            <asp:BoundField DataField="fechaPagoComisionIr" 
                                DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha Pago" />
                            <asp:BoundField DataField="pagoComisionIr" HeaderText="Estado" />
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
        </tr>
        <tr>
            <td align="left">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

