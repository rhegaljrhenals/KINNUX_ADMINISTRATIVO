<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfCambiarContrasena.aspx.vb" Inherits="Seguridad_wfCambiarContraseña" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
    {
        color: #CC3300;
    }
        .style7
        {
            color: #000066;
            width: 156px;
            height: 5px;
        }
        .style8
        {
            width: 156px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="left" style="width: 90%; background-color: #FFFFFF">
        </div>
<asp:Panel ID="Panel3" runat="server" Width="90%">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

        <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" 
                    Height="40px" ImageUrl="~/Imagenes/guardar.png" ToolTip="Actualizar Contraseña" 
                    Width="40px" />
                <br />
              </td>
                          <td width="90%">Actualizar Contraseñas</td>

            </tr>
          </table></td>
      </tr>
    </table>


            <table cellpadding="2" class="style1" style="width: 779px">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Nombre Usuario:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                            style="margin-left: 0px" Width="228px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Clave Actual:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="228px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox2" ErrorMessage="* Clave De Acceso" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        &nbsp;</td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style6" colspan="2" align="center" bgcolor="#CCCCCC">
                        <strong style="background-color: #CCCCCC">Nuevos Datos</strong></td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Nuevo Nombre Usuario:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" 
                            Width="228px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox3" ErrorMessage="* Nombre Usuario Nuevo" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Nueva Clave:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 0px" 
                            TextMode="Password" Width="228px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox4" ErrorMessage="* Nueva Clave" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Confirmar Clave:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 0px" 
                            TextMode="Password" Width="228px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TextBox5" ErrorMessage="*  Confirmacion Clave" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ImageButton1" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Panel>
<br />
    <p>
        <br />
    </p>
    </asp:Content>

