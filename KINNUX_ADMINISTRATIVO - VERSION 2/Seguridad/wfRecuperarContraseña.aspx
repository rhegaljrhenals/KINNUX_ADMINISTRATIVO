<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfRecuperarContraseña.aspx.vb" Inherits="Seguridad_wfRecuperarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .style6
        {
            width: 51px;
            height: 27px;
        }
        .style7
        {
            width: 170px;
            color: #000066;
            font-weight: bold;
        }
        .style8
        {
            color: #FFFFFF;
        }
        .style12
        {
            width: 138px;
            height: 133px;
        }
        .style13
        {
            color: #000066;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="2" class="style1" 
        style="border-style: ridge; border-width: thin; width: 50%;">
        <tr>
            <td align="right" bgcolor="#CCCCCC" colspan="2" class="style8">
                <strong><span class="style13">Recuperar Contraseñas</span>
        <img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <img alt="" class="style6" src="../images/Info%203.png" />&nbsp;
                <asp:Label ID="Label2" runat="server" style="color: #000066"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style7">
                Nombre De Usuario:</td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="* Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left" class="style7">
                Correo Electrónico:</td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ControlToValidate="TextBox2" 
                    ErrorMessage="* Ingrese un email correcto" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5">
                &nbsp;</td>
            <td align="left">
                <asp:Button ID="Button1" runat="server" Height="30px" Text="Enviar" 
                    Width="95px" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style5" colspan="2">
                <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>

