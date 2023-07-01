<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfLimpieSuColon.aspx.vb" Inherits="Reportes_wfLimpieSuColon" %>

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
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/exportarexcel.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
              </td>

            <td width="90%">Encuesta Limpie Su Colon</td>
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
            <td align="left">
                <table class="style4">
                    <tr>
                        <td class="style5">
                            Fecha Inicial:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton3" 
                                TargetControlID="TextBox1">
                            </asp:CalendarExtender>
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/calendario.png" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Fecha Final:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                                TargetControlID="TextBox2">
                            </asp:CalendarExtender>
                            <asp:ImageButton ID="ImageButton4" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/calendario.png" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Ignorar rango de fechas" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td>
                            <table class="style1">
                                <tr>
                                    <td>
                <asp:Panel ID="Panel1" runat="server" Height="300px" ScrollBars="Vertical" 
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
                            <asp:CommandField SelectText="Ver Encuesta" ShowSelectButton="True" />
                            <asp:BoundField DataField="id" HeaderText="Id" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombres" />
                            <asp:BoundField DataField="email" HeaderText="email" />
                            <asp:BoundField DataField="telefono" HeaderText="telefono" />
                            <asp:BoundField DataField="afiliado" HeaderText="Afiliado" />
                            <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" 
                                HeaderText="Fecha" />
                            <asp:BoundField DataField="pais" HeaderText="Pais" />
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
                                        Datos Encuesta....</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <table border="1" class="style4" 
                                            style="border-width: thin; border-color: #000000; width: 50%">
                                            <tr>
                                                <td align="left">
                                                    Gastritis</td>
                                                <td align="center">
                                                    <asp:Image ID="Image3" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Caluculos Biliares</td>
                                                <td align="center">
                                                    <asp:Image ID="Image13" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Hemorroides</td>
                                                <td align="center">
                                                    <asp:Image ID="Image4" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Dolores Articulares</td>
                                                <td align="center">
                                                    <asp:Image ID="Image14" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Reflujo</td>
                                                <td align="center">
                                                    <asp:Image ID="Image5" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Hepatitis</td>
                                                <td align="center">
                                                    <asp:Image ID="Image15" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Acné</td>
                                                <td align="center">
                                                    <asp:Image ID="Image6" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Sobrepeso</td>
                                                <td align="center">
                                                    <asp:Image ID="Image16" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Acidez Estomacal</td>
                                                <td align="center">
                                                    <asp:Image ID="Image7" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Ulcera Gastrica</td>
                                                <td align="center">
                                                    <asp:Image ID="Image17" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Colitis</td>
                                                <td align="center">
                                                    <asp:Image ID="Image8" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Cancer De Colon</td>
                                                <td align="center">
                                                    <asp:Image ID="Image18" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Diarrea</td>
                                                <td align="center">
                                                    <asp:Image ID="Image9" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Estomago Inflamado</td>
                                                <td align="center">
                                                    <asp:Image ID="Image19" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Estreñimiento</td>
                                                <td align="center">
                                                    <asp:Image ID="Image10" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Migrañas</td>
                                                <td align="center">
                                                    <asp:Image ID="Image20" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Colon Irritable</td>
                                                <td align="center">
                                                    <asp:Image ID="Image11" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Hipertension</td>
                                                <td align="center">
                                                    <asp:Image ID="Image21" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Alergias</td>
                                                <td align="center">
                                                    <asp:Image ID="Image12" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    Diabetes</td>
                                                <td align="center">
                                                    <asp:Image ID="Image22" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    Mal Aliento</td>
                                                <td align="center">
                                                    <asp:Image ID="Image23" runat="server" Height="30px" 
                                                        ImageUrl="~/Imagenes/Yes_Check_Circle.svg.png" />
                                                </td>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td align="center">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
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

