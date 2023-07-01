<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfFechasCierre.aspx.vb" Inherits="Seguridad_wfFechasCierre" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            font-family: "Courier New", Courier, monospace;
        }
        .style2
        {
            width: 100%;
        }
        .auto-style1 {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="5%" align="center">
<asp:ImageButton runat="server" ImageUrl="~/Imagenes/guardar.png" Height="40px" 
                    ToolTip="Actualizar Fechas" Width="40px" ID="ImageButton10"></asp:ImageButton>

                <br />
              </td>
                          <td width="90%">Fechas De Cierre</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style1" style="width: 80%">
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label4" runat="server" style="color: #FF0000; font-size: small"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table cellpadding="0" cellspacing="0" class="style2">
                    <tr>
                        <td class="auto-style1">
                            Id:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Fecha Inicial(Año/Mes/Dia):</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton11" 
                                TargetControlID="TextBox2">
                            </asp:CalendarExtender>
<asp:ImageButton runat="server" ImageUrl="~/images/calendario_imagen.png" Height="30px" 
                    ToolTip="Grabar" Width="30px" ID="ImageButton11"></asp:ImageButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Fecha Final(Año/Mes/Dia):</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" CssClass="campver"></asp:TextBox>
                            <asp:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" 
                                Enabled="True" Format="yyyy/MM/dd" PopupButtonID="ImageButton12" 
                                TargetControlID="TextBox3">
                            </asp:CalendarExtender>
<asp:ImageButton runat="server" ImageUrl="~/images/calendario_imagen.png" Height="30px" 
                    ToolTip="Grabar" Width="30px" ID="ImageButton12"></asp:ImageButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
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
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

