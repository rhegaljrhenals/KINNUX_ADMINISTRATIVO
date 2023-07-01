<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfDetalleComisionesTS.aspx.vb" Inherits="Reportes_Varios_wfDetalleComisionesTS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

.titleseccion{font-size:2em; background:#F4F4F4; height:25px; border:#999 solid 1px; border-radius:6px; -moz-border-radius:6px; text-align:center; color: #146295; }
        .style4
        {
            font-family: "Courier New", Courier, monospace;
            font-size: medium;
            color: #004277;
            font-weight: bold;
        }
        .style5
        {
            font-family: "Courier New", Courier, monospace;
            font-size: medium;
            color: #004277;
            font-weight: bold;
            height: 24px;
        }
        .style6
        {
            height: 24px;
        }
        .style7
        {
            width: 100%;
        }
        .campver{border:1px #99BF02 solid; -webkit-border-radius: 4px; -moz-border-radius: 4px; border-radius: 4px; height:20px; padding-left:5px;}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table class="style1" style="border: thin solid #C0C0C0">
        <tr>
            <td colspan="2">
                <table width="100%" border="0" cellspacing="0" cellpadding="5">
                    <tr>
                        <td class="titleseccion">
                            <table width="100%" border="0" 
                cellspacing="0" cellpadding="0">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="Label21" runat="server" 
                                            style="color: #006666; font-size: x-large; font-family: Arial" 
                                            Text="Mis Comisiones"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label17" runat="server" 
                    style="font-weight: 700; font-family: 'Courier New', Courier, monospace; color: #005FAE"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <table class="style7">
                    <tr>
                        <td>
                            Codigo Afiliado:</td>
                        <td>
                            <asp:TextBox ID="TextBox17" runat="server" ReadOnly="True" CssClass="campver"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Nombres:</td>
                        <td>
                            <asp:TextBox ID="TextBox18" runat="server" ReadOnly="True" Width="300px" 
                                CssClass="campver"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td>
                                    Periodo:
                                    <asp:DropDownList ID="DropDownList5" runat="server" Width="200px" 
                                        CssClass="campver">
                                        <asp:ListItem Value="00">Mes</asp:ListItem>
                                        <asp:ListItem Value="01">Enero</asp:ListItem>
                                        <asp:ListItem Value="02">Febrero</asp:ListItem>
                                        <asp:ListItem Value="03">Marzo</asp:ListItem>
                                        <asp:ListItem Value="04">Abril</asp:ListItem>
                                        <asp:ListItem Value="05">Mayo</asp:ListItem>
                                        <asp:ListItem Value="06">Junio</asp:ListItem>
                                        <asp:ListItem Value="07">Julio</asp:ListItem>
                                        <asp:ListItem Value="08">Agosto</asp:ListItem>
                                        <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                        <asp:ListItem Value="10">Octubre</asp:ListItem>
                                        <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                        <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownList6" runat="server" Width="100px" 
                                        CssClass="campver">
                                    </asp:DropDownList>
                                    <label>
                                    &nbsp;<asp:Button ID="Button3" runat="server" CssClass="botnfrm" Text="Mostrar" 
                                        Width="100px" />
                                    </label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" 
                                        
                                        
                                        style="color: #FF0000; font-size: small; font-family: 'Courier New', Courier, monospace"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="style1" 
                                        style="border: thin solid #CCCCCC; width: 600px">
                                        <tr>
                                            <td align="left" class="style4">
                                                Star Point:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                <asp:ImageButton ID="ImageButton13" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/propiedades-icono-8768-96.png" 
                                                    ToolTip="Mostrar Detalle" Width="30px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono De Afiliación:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox16" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                <asp:ImageButton ID="ImageButton14" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/propiedades-icono-8768-96.png" 
                                                    ToolTip="Mostrar Detalle" Width="30px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono STS:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox5" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                <asp:ImageButton ID="ImageButton15" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/propiedades-icono-8768-96.png" 
                                                    ToolTip="Mostrar Detalle" Width="30px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style5">
                                                Bono Mundial:</td>
                                            <td align="left" class="style6">
                                                <asp:TextBox ID="TextBox7" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td class="style6" align="center">
                                                <asp:ImageButton ID="ImageButton16" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/propiedades-icono-8768-96.png" 
                                                    ToolTip="Mostrar Detalle" Width="30px" />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono Uninivel:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox9" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                <asp:ImageButton ID="ImageButton17" runat="server" Height="30px" 
                                                    ImageUrl="~/Imagenes/propiedades-icono-8768-96.png" 
                                                    ToolTip="Mostrar Detalle" Width="30px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono Movilidad:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox15" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono De Rango:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox13" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono Igualación De Rango:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox14" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Avance De Rango:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox19" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono De Patrimonio:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox20" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left" class="style4">
                                                Bono Binario:</td>
                                            <td align="left">
                                                <asp:TextBox ID="TextBox21" runat="server" CssClass="campver" ReadOnly="True" 
                                                    
                                                    style="text-align: right; font-family: 'Courier New', Courier, monospace; font-weight: bold; font-size: medium; color: #005FAE;" 
                                                    Width="150px"></asp:TextBox>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                &nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" 
                                                    style="text-align: right; color: #FF0000; font-size: large" Width="300px">$ 0</asp:Label>
                                            </td>
                                            <td align="center">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
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
        </div>
    
    </form>
</body>
</html>
