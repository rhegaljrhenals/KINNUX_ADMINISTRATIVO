<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>KINNUX SAS</title>
    <link href="StylesKINNUX/styleafilia.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
        }
    .campsform {padding:5px 5px 5px 5px; color: #006699;}
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
            <table width="100%" border="0" cellpadding="0" cellspacing="0" class="tabletop">
  <tr>
    <td width="9%" align="center"><img src="images/logo.png" alt="" width="122" height="122" /></td>
    <td width="91%"><img src="Imagenes/titleam.fw.png" alt="" width="440" height="40" /></td>
  </tr>
</table>
<table width="100%" border="0" cellpadding="5" cellspacing="0" class="tabletop2">
  <tr>
    <td align="center" class="titletop">&nbsp;</td>
  </tr>
</table>
<table width="100%" border="0" cellspacing="0" cellpadding="5">
  <tr>
    <td height="600" valign="top" class="textdown"><p>&nbsp;</p>
      <table width="600" border="0" align="center" cellpadding="5" cellspacing="0">
      <tr>
        <td class="titlesubsec">Acceso a la Administración</td>
        </tr>
    </table>
      <br />
      <table width="600" border="0" align="center" cellpadding="5" cellspacing="0" class="logint">
        <tr>
          <td valign="top"><p class="logintextin">Usar un nombre de usuario y contraseña válido para poder tener acceso a la Administración..</p>
            <table width="100%" border="0" cellpadding="5" cellspacing="0" class="logintextin2">
              <tr>
                <td class="style1">Nombre de Usuario: </td>
                <td><label>
                  &nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="campver" 
                        Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ForeColor="Red" 
                        ToolTip="* Nombre De Usuario Requerido">*</asp:RequiredFieldValidator>
                </label>
                  </td>
              </tr>
              <tr>
                <td class="style1">&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td class="style1">Clave de Acceso:</td>
                <td><label>
                  &nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="campver" 
                        TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ForeColor="Red" ToolTip="* Clave Requerida">*</asp:RequiredFieldValidator>
                </label>
                  </td>
              </tr>
              <tr>
                <td class="style1">&nbsp;</td>
                <td align="center"><label>
                  &nbsp;<br />
                    <asp:Button ID="Button1" runat="server" 
                            Text="Ingresar" Height="30px" Width="146px" 
                        style="font-size: medium; font-family: 'Courier New', Courier, monospace; color: #FFFFFF; font-weight: 700; background-color: #006699" />
                </label>
                  </td>
              </tr>
              <tr>
                <td class="style1" colspan="2">
                    <asp:Label ID="Label1" runat="server" 
                        style="color: #FF0000; font-family: 'Times New Roman', Times, serif; font-weight: 400; font-size: x-small"></asp:Label>
                  </td>
              </tr>
            </table></td>
          <td width="150"><img src="images/login_lock.png" alt=""  width="150" height="147" /></td>
        </tr>
      </table>
    <p>&nbsp;</p></td>
  </tr>
  <tr>
    <td class="textdown"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
  </tr>
</table>
    </form>

    </form>
</body>
</html>
