<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfSublineaArticulo.aspx.vb" Inherits="Seguridad_wfGrupoUsuario" %>

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
        }
        .style9
        {
            color: #000066;
            width: 128px;
            text-align: left;
        }
        .style10
        {
            width: 100%;
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
<table width="100%" border="0" cellspacing="0" cellpadding="5">
      <tr>
        <td class="titleseccion"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
          <td width="5%" align="center">
            <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo" 
                Width="40px" />

              </td>
          <td width="5%" align="center">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar SubLinea" 
                Width="40px" />

              </td>
          <td width="5%" align="center">

                                                    &nbsp;</td>
                          <td width="90%">Sublineas De Productos</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style10">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" class="style1" __designer:mapid="19f2" 
                    style="width: 100%">
                    <tr __designer:mapid="19f3">
                        <td class="style8" __designer:mapid="19f4">
                            &nbsp;</td>
                        <td align="left" __designer:mapid="19f5">
                            <asp:Label ID="Label1" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="19f7">
                        <td class="style9" __designer:mapid="19f8">
                            Codigo SubLinea:</td>
                        <td align="left" __designer:mapid="19f9">
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr __designer:mapid="19fb">
                        <td class="style9" __designer:mapid="19fc">
                            Nombre SubLinea:</td>
                        <td align="left" __designer:mapid="19fd">
                            <asp:TextBox ID="TextBox2" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1a00">
                        <td class="style9" __designer:mapid="1a01">
                            Estado:</td>
                        <td align="left" __designer:mapid="1a02">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="228px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr __designer:mapid="1a06">
                        <td class="style9" __designer:mapid="1a07">
                            Linea:</td>
                        <td style="text-align: left" __designer:mapid="1a08">
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="228px">
                            </asp:DropDownList>
                            &nbsp;<asp:ImageButton ID="ImageButton6" runat="server" Height="30px" 
                                ImageUrl="~/Imagenes/buscar.png" ToolTip="Sublineas Por Lineas" 
                                Width="30px" />
                            &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1a0c">
                        <td class="style8" __designer:mapid="1a0d">
                            &nbsp;</td>
                        <td __designer:mapid="1a0e">
                            &nbsp;</td>
                    </tr>
                    <tr __designer:mapid="1a0f">
                        <td align="left" class="style8" colspan="2" __designer:mapid="1a10">
                            <asp:Label ID="Label4" runat="server" style="color: #003300; font-weight: 700"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1a12">
                        <td colspan="2" __designer:mapid="1a13">
                            <asp:Panel ID="Panel3" runat="server" Height="400px" ScrollBars="Both">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                    <Columns>
                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                        <asp:BoundField DataField="idsublinea" HeaderText="Codigo SubLinea" />
                                        <asp:BoundField DataField="nombresublinea" HeaderText="Nombre Sub Linea" />
                                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                                        <asp:BoundField DataField="idlinea" HeaderText="Id Linea" />
                                        <asp:BoundField DataField="nombrelinea" HeaderText="Nombre Linea" />
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
                            <br __designer:mapid="1a26" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>

