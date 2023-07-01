<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfPreguntasCertificaciones.aspx.vb" Inherits="Reportes_Varios_wfEstadisticasFacturacion" %>

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
        .style6
        {
            width: 149px;
        }
        .style7
        {
            height: 19px;
            width: 149px;
        }
        .style8
        {
            background-color: #CCCCCC;
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

            <td width="90%">Preguntas Certificaciones</td>
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
                        <td class="style6">
                            <asp:Label ID="Label4" runat="server" Text="Id Pregunta:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCCCCC" ReadOnly="True" 
                                Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:Label ID="Label20" runat="server" Text="Examen:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox11" runat="server" CssClass="style8" ReadOnly="True" 
                                Width="50px"></asp:TextBox>
                            <asp:TextBox ID="TextBox12" runat="server" CssClass="style8" ReadOnly="True" 
                                Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:Label ID="Label21" runat="server" Text="Curso:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox13" runat="server" CssClass="style8" ReadOnly="True" 
                                Width="50px"></asp:TextBox>
                            <asp:TextBox ID="TextBox14" runat="server" CssClass="style8" ReadOnly="True" 
                                Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            <asp:Label ID="Label12" runat="server" Text="Tipo Pregunta:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:DropDownList ID="DropDownList5" runat="server" Width="350px" 
                                AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            <asp:Label ID="Label10" runat="server" Text="Puntaje Pregunta:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox5" runat="server" style="text-align: right" 
                                Width="100px"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="TextBox5_FilteredTextBoxExtender" 
                                runat="server" Enabled="True" FilterType="Numbers" TargetControlID="TextBox5">
                            </asp:FilteredTextBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            <asp:Label ID="Label11" runat="server" Text="Estado Pregunta:"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:DropDownList ID="DropDownList3" runat="server" Width="100px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="0">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <table style="width: 300px">
                                <tr>
                                    <td align="right">
                            <asp:Label ID="Label22" runat="server" Text="Numero De Preguntas:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="TextBox15" runat="server" ReadOnly="True" 
                                            style="text-align: right" Width="50px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                            <asp:Label ID="Label23" runat="server" Text="Preguntas Registradas En Este Examen:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="TextBox16" runat="server" ReadOnly="True" 
                                            style="text-align: right" Width="50px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table class="style4">
                                <tr>
                                    <td colspan="3">
                            <asp:Label ID="Label13" runat="server" Text="Enunciado Pregunta"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="2">
                                        <asp:TextBox ID="TextBox6" runat="server" Height="60px" TextMode="MultiLine" 
                                            Width="550px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="2" 
                                            Text="Verdadero" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="2" Text="Falso" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td colspan="2">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style5">
                            <asp:Label ID="Label14" runat="server" Text="Opciones"></asp:Label>
                                    </td>
                                    <td align="center" class="style5" colspan="2">
                            <asp:Label ID="Label19" runat="server" Text="Respuesta Correcta?"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                            <asp:Label ID="Label15" runat="server" Text="1 - "></asp:Label>
                                        <asp:TextBox ID="TextBox7" runat="server" Width="500px"></asp:TextBox>
                                    </td>
                                    <td align="center">
                                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" />
                                    </td>
                                    <td align="center">
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style5">
                            <asp:Label ID="Label16" runat="server" Text="2 - "></asp:Label>
                                        <asp:TextBox ID="TextBox8" runat="server" Width="500px"></asp:TextBox>
                                    </td>
                                    <td align="center" class="style5">
                                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" />
                                    </td>
                                    <td align="center">
                                        <asp:CheckBox ID="CheckBox2" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                            <asp:Label ID="Label17" runat="server" Text="3 - "></asp:Label>
                                        <asp:TextBox ID="TextBox9" runat="server" Width="500px"></asp:TextBox>
                                    </td>
                                    <td align="center">
                                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" />
                                    </td>
                                    <td align="center">
                                        <asp:CheckBox ID="CheckBox3" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                            <asp:Label ID="Label18" runat="server" Text="4 - "></asp:Label>
                                        <asp:TextBox ID="TextBox10" runat="server" Width="500px"></asp:TextBox>
                                    </td>
                                    <td align="center">
                                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" />
                                    </td>
                                    <td align="center">
                                        <asp:CheckBox ID="CheckBox4" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td colspan="2">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td colspan="2">
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

