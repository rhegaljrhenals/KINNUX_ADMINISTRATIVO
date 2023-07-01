<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfSolucionarPQR.aspx.vb" Inherits="Reportes_Varios_wfEstadisticasFacturacion" %>

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
        .style6
        {
            height: 19px;
        }
        
        .campver{border:1px #99BF02 solid; -webkit-border-radius: 4px; -moz-border-radius: 4px; border-radius: 4px; height:20px; padding-left:5px;}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
      
        <td class="titleseccion">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
                      <td>
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/Check Mark.png" 
                                                        Height="40px" ToolTip="Consultar" 
                Width="40px" ID="ImageButton1"></asp:ImageButton>
      </td>
      <td>
      
            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/buscar.png" 
                                                        Height="40px" ToolTip="Exportar a Excell" 
                Width="40px" ID="ImageButton2"></asp:ImageButton>
      
      </td>

            <td width="90%">Soporte y Solución De PQR</td>
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
            <td align="left" colspan="2">
                                    <asp:Panel ID="Panel1" runat="server" Height="200px" 
                    ScrollBars="Vertical">
                                        <table class="style4">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label4" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                        CellPadding="3" ShowFooter="True" Width="100%">
                                                        <Columns>
                                                            <asp:CommandField SelectText="Responder Ticket" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idpqr" HeaderText="Id PQR" />
                                                            <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
                                                            <asp:BoundField DataField="estadoPqr" HeaderText="Estado">
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="tipoSolicitud" HeaderText="Tipo Solicitud">
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="prioridadPqr" HeaderText="Prioridad">
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="email1" HeaderText="Email Afiliado" />
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
                                        </table>
                                        <br />
                                    </asp:Panel>
                                </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                                        BorderWidth="1px" Height="500px" Width="100%">
                                        <table class="style4">
                                            <tr>
                                                <td align="left">
                                                    <table class="style4">
                                                        <tr>
                                                            <td style="width: 550px" valign="top">
                                                                <table class="style4" 
                                                                    style="border: thin solid #C0C0C0; width: 550px; height: 300px;">
                                                                    <tr>
                                                                        <td align="center" colspan="2" style="background-color: #006699">
                                                                            <asp:Label ID="Label5" runat="server" style="color: #FFFFFF" Text="Detalle PQR"></asp:Label>
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
                                                                            <asp:Label ID="Label6" runat="server" Text="Id PQR:"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox1" runat="server"
                                                                            ReadOnly="True" CssClass="campver"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label7" runat="server" Text="Afiliado:"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="300px" 
                                                                                CssClass="campver"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            <table class="style4">
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:Label ID="Label9" runat="server" Text="Estado:"></asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:Label ID="Label10" runat="server" Text="Tipo De Solicitud:"></asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:Label ID="Label11" runat="server" Text="Prioridad:"></asp:Label>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Width="150px" 
                                                                                            CssClass="campver"></asp:TextBox>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="150px" 
                                                                                            CssClass="campver"></asp:TextBox>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="150px" 
                                                                                            CssClass="campver"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            <asp:Panel ID="Panel3" runat="server" Height="200px" ScrollBars="Vertical">
                                                                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                                                    CellPadding="3">
                                                                                    <Columns>
                                                                                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                                                                        <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" 
                                                                                            HeaderText="Fecha" />
                                                                                        <asp:BoundField DataField="hora" HeaderText="Hora" />
                                                                                        <asp:BoundField DataField="tipo" HeaderText="Pregunta/Respuesta" />
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
                                                                        <td colspan="2">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td style="width: 10px">
                                                                &nbsp;</td>
                                                            <td valign="top">
                                                                <table class="style4" style="border: thin solid #C0C0C0; height: 300px;">
                                                                    <tr>
                                                                        <td align="center" colspan="2" style="background-color: #006699">
                                                                            <asp:Label ID="Label15" runat="server" style="color: #FFFFFF" 
                                                                                Text="Respuesta PQR"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            Si Este ticket está solucionado pulse el boton
                                                                            <asp:Button ID="Button2" runat="server" Text="Cerrar PQR" Width="150px" />
                                                                            &nbsp;Para Cerrar este PQR.</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label16" runat="server" Text="De:"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" Width="250px" 
                                                                                CssClass="campver">Soporte PQR</asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style6">
                                                                            <asp:Label ID="Label17" runat="server" Text="Para:"></asp:Label>
                                                                        </td>
                                                                        <td class="style6">
                                                                            <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True" Width="250px" 
                                                                                CssClass="campver"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style6">
                                                                            &nbsp;</td>
                                                                        <td class="style6">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2">
                                                                            <asp:Label ID="Label18" runat="server" Text="Mensaje a Enviar"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style6" colspan="2">
                                                                            <asp:TextBox ID="TextBox11" runat="server" Height="60px" TextMode="MultiLine" 
                                                                                Width="450px" CssClass="campver"></asp:TextBox>
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
                                                                            <asp:Button ID="Button1" runat="server" Text="Enviar" Width="150px" />
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
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" colspan="3">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" colspan="3">
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
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
        </table>
</asp:Content>

