<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfRepFacturas.aspx.vb" Inherits="Reportes_Bodega_Principal_wfRepFacturas" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style12
        {
            width: 138px;
            height: 133px;
        }
        .style13
        {
            color: #0000FF;
            font-weight: bold;
            border-left-color: #A0A0A0;
            border-right-color: #C0C0C0;
            border-top-color: #A0A0A0;
            border-bottom-color: #C0C0C0;
        }
        .style14
        {
            height: 18px;
        }
        .style15
        {
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="width: 90%; font-family: 'Courier New', Courier, monospace;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                <span class="style13">Reportes De Facturación</span><img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" bgcolor="#CCCCCC" class="style15" colspan="2">
                <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" Height="50px" 
                    ToolTip="Exportar a Excell" Width="50px" ID="ImageButton8"></asp:ImageButton>
                </td>
        </tr>
        <tr>
            <td align="left" colspan="2" style="color: #0000CC">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style14">
                <table cellpadding="0" cellspacing="0" class="style1" style="width: 88%">
                    <tr>
                        <td>
&nbsp;Fecha Inicial</td>
                        <td>
                            Fecha Final</td>
                    </tr>
                    <tr>
                        <td>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList2" runat="server">
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
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem>Dia</asp:ListItem>
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
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList ID="DropDownList5" runat="server">
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
                            <asp:DropDownList ID="DropDownList6" runat="server">
                                <asp:ListItem>Dia</asp:ListItem>
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
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td align="left" class="style14">
                <asp:Button ID="Button3" runat="server" Height="30px" Text="Buscar" 
                    Width="89px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style14">
                Busqueda Por Estados: 
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" 
                    Text="Activos" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="Anulados" />
            </td>
            <td align="left" class="style14">
                <asp:Button ID="Button4" runat="server" Height="30px" Text="Buscar" 
                    Width="89px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style14">
                &nbsp;</td>
            <td align="left" class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style14">
                Busqueda Por Paises: Empresas:
                <asp:DropDownList ID="DropDownList7" runat="server" Width="300px">
                </asp:DropDownList>
            </td>
            <td align="left" class="style14">
                <asp:Button ID="Button5" runat="server" Height="30px" Text="Buscar" 
                    Width="89px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style14" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="left" class="style14">
                <asp:Label ID="Label2" runat="server" style="color: #0000CC"></asp:Label>
            </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel2" runat="server" Height="1295px" ScrollBars="Vertical">
                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" style="font-size: small" Width="100%">
                                <Columns>
                                    <asp:BoundField DataField="idEncFacturaPro" HeaderText="Remisión" />
                                    <asp:BoundField DataField="fechaEncFacturaPro" 
                                        DataFormatString="{0:yyyy/MM/dd}" HeaderText="Fecha" />
                                    <asp:BoundField DataField="idEmpresa" HeaderText="Id Empresa" />
                                    <asp:BoundField DataField="nombreempresa" HeaderText="Empresa" />
                                    <asp:BoundField DataField="tipoEncFacturaPro" HeaderText="Tipo" />
                                    <asp:BoundField DataField="puntosEncfacturaPro" HeaderText="Puntos">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="valorEfectivoEncFacturaPro" HeaderText="Valor">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="procesadoEncFacturaPro" HeaderText="Procesado" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
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
                    </ContentTemplate>
                </asp:UpdatePanel>
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

