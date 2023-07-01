<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfAsignacionPQR.aspx.vb" Inherits="Reportes_Varios_wfEstadisticasFacturacion" %>

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

            <td width="90%">Consultas y Asignación De PQR</td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Panel ID="Panel1" runat="server" Height="250px" ScrollBars="Vertical">
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
                                                            <asp:CommandField SelectText="Asignar" ShowSelectButton="True" />
                                                            <asp:BoundField DataField="idpqr" HeaderText="Id PQR" />
                                                            <asp:BoundField DataField="nombres" HeaderText="Afiliado" />
                                                            <asp:BoundField DataField="estadoPqr" HeaderText="Estado">
                                                            <ItemStyle HorizontalAlign="Right" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="tipoSolicitud" HeaderText="Tipo Solicitud">
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="prioridadPqr" HeaderText="Prioridad">
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
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
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="Silver" BorderStyle="Solid" 
                                        BorderWidth="1px" Height="500px" Width="520px">
                                        <table class="style4">
                                            <tr>
                                                <td align="center" colspan="2" style="background-color: #006699">
                                                    <asp:Label ID="Label5" runat="server" style="color: #FFFFFF" Text="Detalle PQR"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label6" runat="server" Text="Id PQR:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label7" runat="server" Text="Afiliado:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="300px" 
                                                        CssClass="campver"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label8" runat="server" Text="Descripción:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2">
                                                    <asp:Panel ID="Panel3" runat="server" Height="150px" ScrollBars="Both">
                                                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                            CellPadding="3" Width="100%">
                                                            <Columns>
                                                                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                                                <asp:BoundField DataField="fecha" DataFormatString="{0:yyyy/MM/dd}" 
                                                                    HeaderText="Fecha" />
                                                                <asp:BoundField DataField="hora" HeaderText="Hora" />
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
                                                <td align="left">
                                                    <asp:Label ID="Label9" runat="server" Text="Estado:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label10" runat="server" Text="Tipo De Solicitud:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label11" runat="server" Text="Prioridad:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label14" runat="server" Text="Asignar Este PQR a:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button ID="Button1" runat="server" Text="Grabar Asignacion" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    &nbsp;</td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </asp:View>
                    <br />
                    <br />
                </asp:MultiView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" BorderStyle="None" Width="0px"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>

