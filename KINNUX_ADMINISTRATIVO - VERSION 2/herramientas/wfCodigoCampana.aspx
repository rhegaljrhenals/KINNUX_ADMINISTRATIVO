<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfCodigoCampana.aspx.vb" Inherits="herramientas_wfCodigoCampana" %>

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
            height: 19px;
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
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/nuevo.png" 
                                                        Height="40px" ToolTip="Nuevo" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" 
                                                        Height="40px" ToolTip="Grabar/Actualizar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      
      </td>

            <td width="90%">Codigos Campaña</td>
            </tr>
          </table>
          </td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
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
                <table class="style4">
                    <tr>
                        <td class="style5">
                            CODIGO GENERADO:</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox5" runat="server" CssClass="campver"></asp:TextBox>
                            
                            <asp:Label ID="Label8" runat="server" 
                                style="font-size: large; font-weight: 700"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Fecha:</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton3" 
                                TargetControlID="TextBox3">
                            </asp:CalendarExtender>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/calendario.png" 
                                                        Height="30px" ToolTip="Grabar/Actualizar" 
                Width="30px" ID="ImageButton3"></asp:ImageButton>
      
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Fecha Vence:</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox4" runat="server" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox4_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton4" 
                                TargetControlID="TextBox4">
                            </asp:CalendarExtender>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/calendario.png" 
                                                        Height="30px" ToolTip="Grabar/Actualizar" 
                Width="30px" ID="ImageButton4"></asp:ImageButton>
      
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Premio a Entregar:</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox2" runat="server" Width="350px" CssClass="campver"></asp:TextBox>
                            <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCCCCC" ReadOnly="True" 
                                Visible="False" Width="10px"></asp:TextBox>
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
                            <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Vertical">
                                <table class="style4">
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView ID="GridView2" runat="server" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" AutoGenerateColumns="False" Width="100%">
                                                <Columns>
                                                    <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                                    <asp:BoundField DataField="idcodigo" HeaderText="Id" />
                                                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                                                    <asp:BoundField DataField="premio" HeaderText="Premio a Entregar" />
                                                    <asp:BoundField DataField="nombreestado" HeaderText="Estado" />
                                                    <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" 
                                                        HeaderText="Fecha" />
                                                    <asp:BoundField DataField="fechavence" DataFormatString="{0:yyyy/MM/dd}" 
                                                        HeaderText="Fecha Vence" />
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

