<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wfFabricante.aspx.vb" Inherits="Basicos_wfFabricante" %>

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
        .style9
        {
            width: 116px;
        }
        .style10
        {
            color: #000066;
            }
    .style11
    {
        color: #000066;
    }
        .style12
        {
            color: #000066;
            width: 116px;
        }
        .style13
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
                ImageUrl="~/Imagenes/nuevo.png" ToolTip="Nuevo Grupo Usuario" 
                Width="40px" />

              </td>
          <td width="5%" align="center">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                ImageUrl="~/Imagenes/guardar.png" ToolTip="Grabar Usuario" 
                Width="40px" />

              </td>
          <td width="5%" align="center">

                                                    &nbsp;</td>
                          <td width="90%">Fabricantes</td>
            </tr>
          </table></td>
      </tr>
    </table>
    <table class="style13">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" class="style1" __designer:mapid="1248" 
                    style="width: 100%">
                    <tr __designer:mapid="1249">
                        <td class="style9" __designer:mapid="124a">
                            &nbsp;</td>
                        <td align="left" __designer:mapid="124b">
                            <asp:Label ID="Label1" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="124d">
                        <td class="style12" align="left" __designer:mapid="124e">
                            Id Fabricante:</td>
                        <td align="left" __designer:mapid="124f">
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                                style="margin-left: 0px" Width="75px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr __designer:mapid="1251">
                        <td class="style12" align="left" __designer:mapid="1252">
                            Nit Fabricante:</td>
                        <td align="left" __designer:mapid="1253">
                            <asp:TextBox ID="TextBox8" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label9" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1256">
                        <td align="left" class="style12" __designer:mapid="1257">
                            Nombres:</td>
                        <td align="left" __designer:mapid="1258">
                            <asp:TextBox ID="TextBox2" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="125b">
                        <td align="left" class="style12" __designer:mapid="125c">
                            Direccion:</td>
                        <td align="left" __designer:mapid="125d">
                            <asp:TextBox ID="TextBox3" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1260">
                        <td align="left" class="style12" __designer:mapid="1261">
                            Telefono:</td>
                        <td align="left" __designer:mapid="1262">
                            <asp:TextBox ID="TextBox4" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1265">
                        <td align="left" class="style12" __designer:mapid="1266">
                            Email:</td>
                        <td align="left" __designer:mapid="1267">
                            <asp:TextBox ID="TextBox5" runat="server" Width="228px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label5" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="126a">
                        <td align="left" class="style12" __designer:mapid="126b">
                            Departamento:</td>
                        <td align="left" __designer:mapid="126c">
                            <asp:TextBox ID="TextBox6" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label7" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="126f">
                        <td align="left" class="style12" __designer:mapid="1270">
                            Ciudad:</td>
                        <td align="left" __designer:mapid="1271">
                            <asp:TextBox ID="TextBox7" runat="server" Width="228px"></asp:TextBox>
                            <asp:Label ID="Label8" runat="server" style="color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1274">
                        <td align="left" class="style12" __designer:mapid="1275">
                            Estado:</td>
                        <td align="left" __designer:mapid="1276">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="228px">
                                <asp:ListItem Value="1">Activo</asp:ListItem>
                                <asp:ListItem Value="2">Eliminado</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr __designer:mapid="127a">
                        <td align="left" class="style12" __designer:mapid="127b">
                            &nbsp;</td>
                        <td align="left" __designer:mapid="127c">
                            <asp:AsyncFileUpload ID="AsyncFileUpload1" runat="server" 
                                CompleteBackColor="#0099CC" UploaderStyle="Modern" Width="250px" 
                                Visible="False" />
                        </td>
                    </tr>
                    <tr __designer:mapid="127e">
                        <td align="left" class="style12" __designer:mapid="127f">
                            &nbsp;</td>
                        <td align="left" __designer:mapid="1280">
                            <asp:AsyncFileUpload ID="AsyncFileUpload2" runat="server" 
                                CompleteBackColor="#0099CC" UploaderStyle="Modern" Width="250px" 
                                Visible="False" />
                        </td>
                    </tr>
                    <tr __designer:mapid="1282">
                        <td align="left" class="style11" colspan="2" __designer:mapid="1283">
                            <asp:Label ID="Label11" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1285">
                        <td align="left" class="style10" colspan="2" __designer:mapid="1286">
                            <asp:Label ID="Label10" runat="server" 
                                style="color: #003300; font-weight: 700;" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr __designer:mapid="1288">
                        <td align="left" class="style10" colspan="2" __designer:mapid="1289">
                            <asp:Panel ID="Panel2" runat="server" Height="300px" ScrollBars="Both" 
                                Width="100%">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" style="font-size: x-small" Width="100%">
                                    <Columns>
                                        <asp:CommandField SelectText="Seleccione" ShowSelectButton="True" />
                                        <asp:BoundField DataField="idfabricante" HeaderText="Id " />
                                        <asp:BoundField DataField="nombrefabricante" HeaderText="Nombre" />
                                        <asp:BoundField DataField="direccionfabricante" HeaderText="Direccion" />
                                        <asp:BoundField DataField="telefonofabricante" HeaderText="Telefono" />
                                        <asp:BoundField DataField="emailfabricante" HeaderText="Email" />
                                        <asp:BoundField DataField="dptofabricante" HeaderText="Departamento" />
                                        <asp:BoundField DataField="ciudadfabricante" HeaderText="Ciudad" />
                                        <asp:BoundField DataField="estadofabricante" HeaderText="Estado" />
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
                </table>
            </td>
        </tr>
    </table>
    <br />
<br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

