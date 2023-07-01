<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfProveedore.aspx.vb" Inherits="Basicos_wfProveedore" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
                
    .header_bottom_image
    {
    background: url(../images/grupo usuario.jpg) left top no-repeat;
    border-left:2px solid #FFF;
    border-bottom:2px solid #FFF;
    height:123px;
    }
        .style8
        {
            color: #FFFFFF;
        }
        .style9
        {
            width: 134px;
        }
        .style10
        {
            color: #000066;
            }
        .style12
        {
            color: #000066;
        }
        .style13
        {
            color: #000066;
            height: 31px;
        }
        .style14
        {
            height: 31px;
        }
        </style>



<script type="text/javascript">
    function CallPrint(strid) {
        var prtContent = document.getElementById(strid);
        var WinPrint = window.open('', '', 'letf=0,top=0,width=400,height=400,toolbar=0,scrollbars=0,status=0');
        WinPrint.document.write(prtContent.innerHTML);
        WinPrint.document.close();
        WinPrint.focus();
        WinPrint.print();
        WinPrint.close();

    }
  </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="right" class="style8" 
    style="width: 90%; background-color: #CCCCCC">
        <strong><span class="style10">Proveedores</span>
        <img alt="" class="style12" height="30" src="../Imagenes/btknx.png" 
            style="width: 50px; height: 50px;" /></strong></div>
    <div style="width: 90%; background-color: #FFFFFF;" align="left">
            <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" 
                ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo Grupo Usuario" 
                Width="50px" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" 
                Width="50px" />
        </div>
    <asp:Panel ID="Panel3" runat="server" Width="90%">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table cellpadding="2" class="style1">
                    <tr>
                        <td class="style9">
                            &nbsp;</td>
                        <td align="left">
                            <asp:Label ID="Label1" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10" align="left">
                            Id Proveedor:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10" align="left">
                            Codigo Proveedor:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox8" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label9" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Nombres:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox2" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Direccion:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox3" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Telefono:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox4" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Email:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox5" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label5" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Departamento:</td>
                        <td align="left">
                            <asp:TextBox ID="TextBox6" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style13">
                            Ciudad:</td>
                        <td align="left" class="style14">
                            <asp:TextBox ID="TextBox7" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label8" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            Estado:</td>
                        <td align="left">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="228px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10">
                            &nbsp;</td>
                        <td align="left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="left" class="style10" colspan="2">
                            <asp:Label ID="Label10" runat="server" 
                                style="color: #003300; font-weight: 700;" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style10" colspan="2">
                            <asp:Panel ID="Panel2" runat="server" Height="911px" ScrollBars="Both" 
                                Width="100%">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%" GridLines="None">
                                    <Columns>
                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                        <asp:BoundField DataField="idproveedor" HeaderText="Id Proveedor" />
                                        <asp:BoundField DataField="nombreproveedor" HeaderText="Nombre" />
                                        <asp:BoundField DataField="direccionproveedor" HeaderText="Direccion" />
                                        <asp:BoundField DataField="telefonoproveedor" HeaderText="Telefono" />
                                        <asp:BoundField DataField="emailproveedor" HeaderText="Email" />
                                        <asp:BoundField DataField="dptoproveedor" HeaderText="Departamento" />
                                        <asp:BoundField DataField="ciudadproveedor" HeaderText="Ciudad" />
                                        <asp:BoundField DataField="estadoproveedor" HeaderText="Estado" />
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
                        <td colspan="2">
                            <br />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ImageButton1" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ImageButton5" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
</asp:Panel>
<br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

