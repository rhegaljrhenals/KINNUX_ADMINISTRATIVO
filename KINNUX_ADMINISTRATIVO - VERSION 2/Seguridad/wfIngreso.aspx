<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfIngreso.aspx.vb" Inherits="Seguridad_wfIngreso" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .redondear
    {
        height: 138px;
    }
        .style8
    {
        width: 146px;
    }
    .style9
    {
        color: #000066;
        width: 146px;
        height: 5px;
    }
        .style10
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
    <div style="width: 570px; background-color: #CCCCCC;" align="right">
        <strong>
        <span class="style13">Ingreso Al Sistema</span><span class="style10">
        <img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></span></strong><br />
    </div>
    <div style="width: 570px; height: 227px;">

    <asp:UpdateProgress ID="UpdateProg1" DisplayAfter="0" runat="server">
    <ProgressTemplate>
        Procesando...
        <img src="../Imagenes/loading.gif" />
    </ProgressTemplate>
			</asp:UpdateProgress>
            
        <asp:Panel ID="Panel1" runat="server" Height="169px" BackColor="White" 
            BorderColor="Silver" BorderStyle="Groove" BorderWidth="1px" 
            DefaultButton="Button1">

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            
                <table cellpadding="2" class="style1">
                    <tr>
                        <td align="left" class="style9">
                            Nombre De Usuario:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
                                Width="200px"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox1" ErrorMessage="* Nombre Usuario Requerido" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style9" align="left" valign=top>
                            Clave De Acceso:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TextBox2" ErrorMessage="Requerido" 
                                ForeColor="Red">* Clave De Acceso Requerido</asp:RequiredFieldValidator>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            &nbsp;</td>
                        <td align="left">
                            <asp:Button ID="Button1" runat="server" Height="30px" 
                                style="color: #000066; background-color: #CCCCCC" Text="Entrar" 
                                Width="100px" BackColor="#006699" />
                            &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False">¿Olvidaste Tu Contraseña?</asp:LinkButton>
                            <br />
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            
            </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </asp:Panel>
    </div>
    </asp:Content>

