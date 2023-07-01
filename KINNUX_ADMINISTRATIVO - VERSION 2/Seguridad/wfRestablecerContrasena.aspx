<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfRestablecerContrasena.aspx.vb" Inherits="Seguridad_wfRestablecerContrasena" %>

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
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="left" style="width: 90%; background-color: #FFFFFF">
        </div>
<asp:Panel ID="Panel3" runat="server" Width="90%">
    
        <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" 
                    Height="40px" ImageUrl="~/Imagenes/guardar.png" ToolTip="Actualizar Contraseña" 
                    Width="40px" />
                <br />
              </td>
                          <td width="90%">Restablecer Contraseñas</td>

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
                        Codigo Afiliado:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox1" runat="server" 
                            style="margin-left: 0px" Width="120px"></asp:TextBox>
                        <label>
                        <asp:Button ID="Button1" runat="server" Height="30px" 
                            style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                            Text="Buscar" Width="120px" />
                        </label>
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Nombres:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="350px" 
                            ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="style7">
                        Correo Electronico:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" TextMode="Password" 
                            Width="350px"></asp:TextBox>
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
                        Nombre Usuario:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" 
                            Width="228px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        Nueva Clave:</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 0px" 
                            TextMode="Password" Width="228px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style7" align="left">
                        &nbsp;</td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style8" colspan="2">
                        <label>
                        <asp:Button ID="Button2" runat="server" Height="30px" 
                            style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" 
                            Text="Restablecer Contraseña" Width="250px" />
                        </label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
<br />
    <p>
        <br />
    </p>
    </asp:Content>

