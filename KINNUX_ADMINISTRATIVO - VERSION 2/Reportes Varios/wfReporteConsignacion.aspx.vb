Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteConsignacion
    Inherits System.Web.UI.Page


    Dim consignaciones As New clsTTConsignacion
    Dim afiliadosConsignaciones As New clsTTCodConsig
    Dim remisionesConsignaciones As New clsTTFacturaConsig
    Dim operaciones As New clsOperacione

    Sub mostrarRemisiones()
        Dim tabla As New DataTable
        With remisionesConsignaciones
            .idConsignacion = Me.TextBox2.Text
            tabla = .obtenerRemisionesDeConsignaciones
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Sub mostrarAfiliados()
        Dim tabla As New DataTable
        With afiliadosConsignaciones
            .idConsignacion = Me.TextBox2.Text
            tabla = .obtenerAfiliadosPorConsiganacion
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Function buscarConsignacion(ByVal numero As String) As String
        Dim ruta As String = ""
        Dim tabla As New DataTable
        Dim encontrado As String = "no"
        'obtiene la ruta donde se va a mostrar la imagen
        With operaciones
            tabla = .obtenerRutaDondeGrabar("consignacion y tarjetas de credito")
            If tabla.Rows.Count <> 0 Then
                ruta = tabla.Rows(0).Item("mostrarImagenAdministrativo")
            End If
        End With
        '
        With consignaciones
            .numeroConsignacion = numero
            tabla = .datosConsignacionesPorNumero
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("idconsignacion")
                Me.TextBox3.Text = tabla.Rows(0).Item("numeroconsignacion")
                Me.TextBox4.Text = tabla.Rows(0).Item("fechaConsignacion")
                Me.TextBox5.Text = tabla.Rows(0).Item("valorConsignacion")
                Me.TextBox6.Text = tabla.Rows(0).Item("valorUtilizadoConsignacion")
                Me.TextBox7.Text = tabla.Rows(0).Item("numeroCuenta")
                Me.TextBox8.Text = tabla.Rows(0).Item("idBanco")
                Me.TextBox9.Text = tabla.Rows(0).Item("nombreBanco")
                ' si es una imagen
                If Right(tabla.Rows(0).Item("imagenConsignacion"), 3) = "pdf" Or Right(tabla.Rows(0).Item("imagenConsignacion"), 3) = "PDF" Then

                Else
                    Try
                        Me.Image1.ImageUrl = ruta & tabla.Rows(0).Item("imagenConsignacion")
                    Catch ex As Exception
                        Me.Image1.ImageUrl = "~/images/imagennodisponible.png"
                    End Try
                End If
                encontrado = "si"
            Else
                encontrado = "no"
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox8.Text = ""
                Me.TextBox9.Text = ""
            End If
        End With
        Return encontrado
    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.ImageButton6.Visible = False
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 1
            Me.ImageButton6.Visible = False
            Me.TextBox10.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox11.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.Panel5.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Dim numeroConsignacion As String = Me.GridView4.Rows(e.NewSelectedIndex).Cells(2).Text
        buscar(numeroConsignacion)
        Me.MultiView1.ActiveViewIndex = 0
        Me.ImageButton6.Visible = False
    End Sub

    Sub buscar(ByVal numeroConsignacion As String)
        Me.TextBox2.Text = ""
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        Me.TextBox1.Text = numeroConsignacion
        Dim tabla As New DataTable
        Dim encontrado As String = buscarConsignacion(numeroConsignacion)
        If encontrado = "si" Then
            mostrarAfiliados()
            mostrarRemisiones()
        Else
            'Me.Label2.Text = "Consignacion no existe en el sistema...!"
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tabla As New DataTable
        With consignaciones
            .fechaInicial = Me.TextBox10.Text
            .fechaFinal = Me.TextBox11.Text
            tabla = .obtenerConsignacionesPorFechas
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                Me.ImageButton6.Visible = True
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
                Me.ImageButton6.Visible = False
            End If
        End With
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView4.Columns(0).Visible = False
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

    Protected Sub ImageButton6_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        ExportToExcel("Consignaciones-" & Me.TextBox10.Text & "-" & Me.TextBox11.Text & ".xls", Me.GridView4)
    End Sub

    'Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
    '    Me.Image1.ImageUrl = "~/Punto/Consignaciones/201597096.png"
    'End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim tabla As New DataTable
        With consignaciones
            .numeroConsignacion = Me.TextBox12.Text
            tabla = .obtenerConsignacionesPorNumeroConsignacion
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                Me.ImageButton6.Visible = True
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
                Me.ImageButton6.Visible = False
            End If
        End With
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As System.EventArgs) Handles LinkButton2.Click
        If Me.LinkButton2.Text = "Ver Imagen Consignación" Then
            Me.LinkButton2.Text = "Ocultar Imagen Consignación"
            Me.Panel5.Visible = True
            'Me.TextBox13.Focus()
        Else
            Me.LinkButton2.Text = "Ver Imagen Consignación"
            Me.Panel5.Visible = False
        End If
    End Sub
End Class
