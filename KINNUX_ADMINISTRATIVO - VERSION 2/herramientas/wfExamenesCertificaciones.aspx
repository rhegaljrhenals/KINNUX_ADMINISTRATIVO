<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfExamenesCertificaciones.aspx.vb" Inherits="Reportes_Varios_wfEstadisticasFacturacion" %>

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

            <td width="90%">Actualización De Examenes</td>
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
            <td align="right">
                <asp:Label ID="Label26" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style4">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Id Examen:"></asp:Label>
                        </td>
                        <td colspan="6">
                            <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label5" runat="server" Text="Nombre Curso:"></asp:Label>
                        </td>
                        <td class="style5" colspan="2">
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
                            </asp:DropDownList>
                        </td>
                        <td class="style5">
                            <asp:Label ID="Label8" runat="server" Text="Nombre Examen:"></asp:Label>
                        </td>
                        <td class="style5" colspan="3">
                            <asp:TextBox ID="TextBox6" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label9" runat="server" Text="Duracion Examen(HH:MM):"></asp:Label>
                        </td>
                        <td class="style5" colspan="2">
                            <asp:TextBox ID="TextBox3" runat="server" style="text-align: right" 
                                Width="50px"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" 
                                runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox3">
                            </asp:FilteredTextBoxExtender>
                            <asp:TextBox ID="TextBox4" runat="server" style="text-align: right" 
                                Width="50px"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="TextBox4_FilteredTextBoxExtender" 
                                runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox4">
                            </asp:FilteredTextBoxExtender>
                        </td>
                        <td class="style5">
                            <asp:Label ID="Label10" runat="server" Text="Puntaje Examen:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox5" runat="server" style="text-align: right" 
                                Width="100px"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="TextBox5_FilteredTextBoxExtender" 
                                runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox5">
                            </asp:FilteredTextBoxExtender>
                        </td>
                        <td class="style5">
                            <asp:Label ID="Label12" runat="server" Text="No De Preguntas:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox7" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label11" runat="server" Text="Estado Examen:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:DropDownList ID="DropDownList3" runat="server" Width="100px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="0">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style5" colspan="2">
                            &nbsp;</td>
                        <td class="style5" colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label27" runat="server" Text="Ingreso De Preguntas:"></asp:Label>
                        </td>
                        <td class="style5" colspan="6">
                            <asp:HyperLink ID="HyperLink1" runat="server">Ingresar Preguntas de este examen</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="7">
                            <asp:Panel ID="Panel1" runat="server" Height="300px" ScrollBars="Vertical">
                                <table class="style4">
                                    <tr>
                                        <td>
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                                CellPadding="3" Width="100%">
                                                <Columns>
                                                    <asp:CommandField SelectText="Ver Detalle" ShowSelectButton="True" />
                                                    <asp:BoundField DataField="idExamen" HeaderText="Id Examen" />
                                                    <asp:BoundField DataField="nombreExamen" HeaderText="Nombre Examen" />
                                                    <asp:BoundField DataField="duracionExamen" HeaderText="Duracion" />
                                                    <asp:BoundField DataField="pesoExamen" HeaderText="Valor Examen" />
                                                    <asp:BoundField DataField="idCurso" HeaderText="Id Curso" />
                                                    <asp:BoundField DataField="nombreCurso" HeaderText="Nombre Curso" />
                                                    <asp:BoundField DataField="numeroPreguntasExamen" 
                                                        HeaderText="Numero De Preguntas" />
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
                        <td class="style5">
                            &nbsp;</td>
                        <td class="style5" colspan="6">
                            &nbsp;</td>
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

