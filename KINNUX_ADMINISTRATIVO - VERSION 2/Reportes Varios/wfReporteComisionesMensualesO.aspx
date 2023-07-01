<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfReporteComisionesMensualesO.aspx.vb" Inherits="Herramientas_wfcuadreCaja" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
        

        .style14
        {
            height: 18px;
        }
        .style15
        {
            width: 100%;
        }
        .style16
        {
            width: 161px;
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
                    Height="40px" ToolTip="Buscar" Width="40px" ID="ImageButton1"></asp:ImageButton>

                </td>
            <td width="5%" align="center">

                                        <asp:ImageButton ID="ImageButton13" runat="server" Height="40px" 
                                            ImageUrl="~/Imagenes/exportarexcel.png" ToolTip="Exportar a Excell" 
                                            Width="40px" />

                </td>
                            <td width="90%">Comisiones Mensuales</td>

            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style4" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <table class="style15">
                    <tr>
                        <td class="style16">
                            Fecha Inicial:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList12" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList13" runat="server" Width="150px">
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
                            <asp:DropDownList ID="DropDownList14" runat="server">
                                <asp:ListItem Value="00">Dia</asp:ListItem>
                                <asp:ListItem>01</asp:ListItem>
                                <asp:ListItem>02</asp:ListItem>
                                <asp:ListItem>03</asp:ListItem>
                                <asp:ListItem>04</asp:ListItem>
                                <asp:ListItem>05</asp:ListItem>
                                <asp:ListItem>06</asp:ListItem>
                                <asp:ListItem>07</asp:ListItem>
                                <asp:ListItem>08</asp:ListItem>
                                <asp:ListItem>09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem>25</asp:ListItem>
                                <asp:ListItem>26</asp:ListItem>
                                <asp:ListItem>27</asp:ListItem>
                                <asp:ListItem>28</asp:ListItem>
                                <asp:ListItem>29</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>31</asp:ListItem>
                            </asp:DropDownList>

                            <asp:Label ID="Label4" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Fecha Final:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList15" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList16" runat="server" Width="150px">
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
                            <asp:DropDownList ID="DropDownList17" runat="server">
                                <asp:ListItem Value="00">Dia</asp:ListItem>
                                <asp:ListItem>01</asp:ListItem>
                                <asp:ListItem>02</asp:ListItem>
                                <asp:ListItem>03</asp:ListItem>
                                <asp:ListItem>04</asp:ListItem>
                                <asp:ListItem>05</asp:ListItem>
                                <asp:ListItem>06</asp:ListItem>
                                <asp:ListItem>07</asp:ListItem>
                                <asp:ListItem>08</asp:ListItem>
                                <asp:ListItem>09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem>25</asp:ListItem>
                                <asp:ListItem>26</asp:ListItem>
                                <asp:ListItem>27</asp:ListItem>
                                <asp:ListItem>28</asp:ListItem>
                                <asp:ListItem>29</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>31</asp:ListItem>
                            </asp:DropDownList>

                            <asp:Label ID="Label5" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

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
                            Empresa(Pais):</td>
                        <td>
                            <asp:DropDownList ID="DropDownList18" runat="server" Width="300px" 
                            AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:Label ID="Label6" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            Sucursales:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
                                    </asp:DropDownList>
                                <asp:Label ID="Label7" runat="server" 
                                style="color: #FF0000; font-family: 'Courier New', Courier, monospace"></asp:Label>

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
                            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                                Text="Incluir Codigo Afiliado" />
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td class="style14" valign="top">
                            <br />

                        </td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style14" valign="top" colspan="2">
                        <asp:Panel ID="Panel6" runat="server" Height="400px" ScrollBars="Vertical">
                            <table cellpadding="0" cellspacing="0" class="style15">
                                <tr>
                                    <td align="left" bgcolor="#CCCCCC" style="font-weight: 700">
                                        &nbsp;</td>
                                    <td align="center" bgcolor="#CCCCCC" style="font-weight: 700">
                                        Comisiones Mensuales</td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" ShowFooter="True" style="font-weight: 700;">
                                <Columns>
                                    <asp:BoundField DataField="idComision" HeaderText="Id Comision" />
                                    <asp:BoundField DataField="Nombres" HeaderText="Afiliado" />
                                    <asp:BoundField DataField="total" DataFormatString="{0:N2}" HeaderText="Total">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fechapagocomision" DataFormatString="{0:yyyy/MM/dd}" 
                                        HeaderText="Fecha Pago" />
                                    <asp:BoundField DataField="mes" HeaderText="Mes pago" />
                                    <asp:BoundField DataField="anocomision" HeaderText="Año" />
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
                        </asp:Panel>

                        </td>
                    </tr>
                    <tr>
                        <td class="style14" valign="top">
                            &nbsp;</td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
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
</asp:Content>

