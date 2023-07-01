Imports System.IO
Imports System.Data

Partial Class Reportes_Varios_wfConsultaDistribuidor
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise
    Dim afiliado As New ClsAfiliado
    Dim encabezadoRemision As New clsTTEncFacturaPro
    Dim afiliados As New ClsAfiliado
    Dim detalleFactura As New clsTTDetFacturaPro
    Dim reciboFactura As New clsTTReciboFactura
    Dim consignaciones As New clsTTConsignacion
    Dim bodegaSucursal As New clsTTBodPuntoProducto
    Dim apartados As New clsTTRecibo
    Dim comisionKit As New clsTTComisionKit
    Dim detalleComisionKit As New clsTTDetComisionKit
    Dim facturaConsig As New clsTTFacturaConsig
    Dim comisionesIr As New clsTTComisionIr
    Dim paquete As New clsPaquetePais
    Dim facturasTarjetas As New clsfacturaTarjeta
    Dim paquetes As New clsTBPaquete
    Dim usuarios As New clsTBUsuarios

    Sub buscar()
        Me.Panel3.Visible = False
        Me.Panel5.Visible = True
        Dim sql As String
        Dim opcion As Integer
        Dim tabla As New DataTable
        Me.ImageButton10.Visible = False
        '
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton2.Checked = True Then
                opcion = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    opcion = 3
                Else
                    If Me.RadioButton4.Checked = True Then
                        opcion = 4
                    Else
                        If Me.RadioButton5.Checked = True Then
                            opcion = 5
                        Else
                            If Me.RadioButton6.Checked = True Then
                                opcion = 6
                            Else
                                If Me.RadioButton7.Checked = True Then
                                    opcion = 7
                                Else
                                    If Me.RadioButton8.Checked = True Then
                                        opcion = 8
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '
        sql = "SELECT        " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.Afiliaciones.celular," & _
        "dbo.Afiliaciones.direccion," & _
        "dbo.Afiliaciones.email1, " & _
        "dbo.Afiliaciones.fotos, " & _
        "dbo.Afiliaciones.clave, " & _
        "dbo.Afiliaciones.fechaNacido, " & _
        "dbo.Afiliaciones.fechaAfiliacion, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.nombreMunicipio, " & _
        "'( ' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS patrocinador" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON dbo.Afiliaciones.codigoPatrocinador = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio"
        Select Case opcion
            Case Is = 1
                sql = sql & " where Afiliaciones.codigoafiliado='" & Me.TextBox1.Text & "'"
            Case Is = 2
                sql = sql & " where Afiliaciones.identificacion='" & Me.TextBox1.Text & "'"
            Case Is = 3
                sql = sql & " where Afiliaciones.papellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 4
                sql = sql & " where Afiliaciones.sapellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 5
                sql = sql & " where Afiliaciones.pnombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 6
                sql = sql & " where Afiliaciones.snombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 7
                sql = sql & " where Afiliaciones.email1 like '%" & Me.TextBox1.Text & "%'"
            Case Is = 8
                sql = sql & " where TBpais.codigoPais='" & Me.DropDownList1.SelectedValue & "'"
        End Select
        sql = sql & " order by Afiliaciones.codigoAfiliado"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Panel5.Visible = True
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
                '
                Me.Label3.Text = "Registros Encontrados: " & tabla.Rows.Count

                Me.DataList1.DataSource = tabla
                Me.DataList1.DataBind()

            Else
                Me.DataList1.DataSource = Nothing
                Me.DataList1.DataBind()
                '
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
        If Session("idusuario") = "7" Or Session("idusuario") = "48" Or Session("idusuario") = "131" Or Session("idusuario") = "141" Then
            Me.GridView1.Columns(11).Visible = True
        Else
            Me.GridView1.Columns(11).Visible = False

        End If
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarPais()
            Me.ImageButton10.Visible = False
            'Me.panelDatos.Visible = False
            Me.Panel3.Visible = False
            Me.Panel5.Visible = False
            Me.RadioButton1.Checked = True
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.DropDownList1.DataSource = tabla
            Me.DropDownList1.DataTextField = "nombrePais"
            Me.DropDownList1.DataValueField = "codigopais"
            Me.DropDownList1.DataBind()
        End With
        Me.DropDownList1.Items.Insert(0, "Seleccione Pais")
    End Sub

    'Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
    '    panelDatos.Visible = False
    '    ExportToExcel("Informe.xls", GridView1)
    'End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView1.Columns(0).Visible = False
        Dim responsePage As HttpResponse = Response
        Dim sw As New StringWriter()
        Dim htw As New HtmlTextWriter(sw)
        Dim pageToRender As New Page()
        Dim form As New HtmlForm()
        form.Controls.Add(wControl)
        pageToRender.Controls.Add(form)
        responsePage.Clear()
        responsePage.Buffer = True
        responsePage.ContentType = "application/vnd.ms-excel"
        responsePage.AddHeader("Content-Disposition", "attachment;filename=" & nameReport)
        responsePage.Charset = "UTF-8"
        responsePage.ContentEncoding = Encoding.Default
        pageToRender.RenderControl(htw)
        responsePage.Write(sw.ToString())
        responsePage.End()
    End Sub

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Dim codigoPatrocinador As String = ""
        Dim tabla As New DataTable
        Dim mensaje As String = ""
        '------------------------------------------------------------------------------------
        ' datos afiliado
        With afiliado
            .codigoAfiliado = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                codigoPatrocinador = tabla.Rows(0).Item("codigoPatrocinador")
                mensaje = "Codigo Afiliado: " & tabla.Rows(0).Item("codigoAfiliado") & "\n"
                mensaje = mensaje & "Identificacion: " & tabla.Rows(0).Item("identificacion") & "\n"
                mensaje = mensaje & "Nombres: " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido") & " " & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & "\n"
                mensaje = mensaje & "Direccion: " & tabla.Rows(0).Item("direccion") & "\n"
                mensaje = mensaje & "Telefono: " & tabla.Rows(0).Item("telefono") & "\n"
                mensaje = mensaje & "Celular: " & tabla.Rows(0).Item("celular") & "\n"
                mensaje = mensaje & "Email: " & tabla.Rows(0).Item("email1") & "\n"
                mensaje = mensaje & "Fecha De Nacimiento(Año/Mes/Dia): " & tabla.Rows(0).Item("fechanacido") & "\n"
            End If
        End With
        '------------------------------------------------------------------------------------
        ' datos patrocinador
        With afiliado
            .codigoAfiliado = codigoPatrocinador
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                mensaje = mensaje & "Patrocinador: (" & tabla.Rows(0).Item("codigoAfiliado") & ") " & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                mostrarVentana(mensaje)
            End If
        End With
        '------------------------------------------------------------------------------------
        'Dim ventana As AjaxControlToolkit.ModalPopupExtender = New AjaxControlToolkit.ModalPopupExtender
        'ventana.ID = "popUp11"
        'Me.panelDatos.Visible = True
        'ventana.PopupControlID = "panelDatos"
        'ventana.TargetControlID = "HiddenField1"
        'ventana.DropShadow = True
        'ventana.BackgroundCssClass = "ModalPopupBG"
        'ventana.CancelControlID = "ImageButton11"
        'Me.Panel2.Controls.Add(ventana)
        'ventana.Show()
        '
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'panelDatos.Visible = False
        buscar()
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        Me.Panel3.Visible = False
        Me.Panel5.Visible = True
    End Sub

    Protected Sub LinkButton4_Click(sender As Object, e As System.EventArgs) Handles LinkButton4.Click
        Me.Panel3.Visible = True
        Me.Panel5.Visible = False
    End Sub

    Protected Sub DataList1_ItemCommand(source As Object, e As DataListCommandEventArgs) Handles DataList1.ItemCommand
        Dim sql As String
        If e.CommandName = "retirar" Then
            '
            Dim txtCodigoAfiliado As TextBox
            txtCodigoAfiliado = CType(e.Item.FindControl("TextBox2"), TextBox)
            System.Threading.Thread.Sleep(2000)
            '
            sql = "update afiliaciones set identificacion = identificacion + 'RET', estado = 0 where codigoafiliado = '" & txtCodigoAfiliado.Text & "'"
            With objOperacione
                .Accion(sql)
            End With
            '
            mostrarVentana("Afiliado Retirado...")
            buscar()
        End If
    End Sub

    Protected Sub DataList1_ItemCreated(sender As Object, e As System.Web.UI.WebControls.DataListItemEventArgs) Handles DataList1.ItemCreated
        If e.Item.ItemType = ListItemType.Item Or _
             e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim clave As TextBox = CType(e.Item.FindControl("TextBox12"), TextBox)
            Dim etiquetaClave As Label = CType(e.Item.FindControl("Label12"), Label)
            Dim btnRetirar As Button = CType(e.Item.FindControl("Button5"), Button)
            ' no muestra la clave para algunos usuarios
            If Request.QueryString("iu") = "7" Or Request.QueryString("iu") = "48" Or Request.QueryString("iu") = "131" Or Request.QueryString("iu") = "141" Then
                clave.Visible = True
                etiquetaClave.Visible = True
            Else
                clave.Visible = False
                etiquetaClave.Visible = False
            End If
            ' no muestra el boton retirar
            If Request.QueryString("iu") = "7" Or Request.QueryString("iu") = "48" Then
                btnRetirar.Visible = True
            Else
                btnRetirar.Visible = False
            End If
        End If
    End Sub

    
End Class
