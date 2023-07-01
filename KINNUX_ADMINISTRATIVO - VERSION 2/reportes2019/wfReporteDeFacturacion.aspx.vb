Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteFacturacion
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadoFacturas As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarAno()
            cargarEmpresas()
            Me.RadioButton1.Checked = True
            Me.RadioButton3.Checked = True
            '
            Me.Label6.Visible = False
            Me.Panel5.Visible = False
            Me.Panel6.Visible = False
            Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            Me.DropDownList18.DataSource = tabla
            Me.DropDownList18.DataTextField = "nombreempresa"
            Me.DropDownList18.DataValueField = "idEmpresa"
            Me.DropDownList18.DataBind()
        End With
        '
        Me.DropDownList18.Items.Insert(0, "Todas Las empresas")
        'Me.DropDownList18.DataBind()
    End Sub

    Sub mostrarDatos()
        Me.MultiView1.ActiveViewIndex = 0
        Dim titulo As String
        Me.Panel6.Visible = False
        Dim idempresa As Integer
        Dim idsucursal As Integer
        Dim tabla As New DataTable
        With encabezadoFacturas
            If Me.RadioButton1.Checked = True Then
                .estadoEncfacturaPro = 1
            Else
                .estadoEncfacturaPro = 0
            End If

            If Me.RadioButton3.Checked = True Then
                .pertenececiclo = "n"
            Else
                .pertenececiclo = "s"
            End If

            .fechaInicial = Me.TextBox1.Text 'Me.DropDownList12.SelectedValue & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.TextBox2.Text 'Me.DropDownList15.SelectedValue & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            If Me.DropDownList18.SelectedIndex = 0 Then
                idempresa = 0
            Else
                idempresa = Me.DropDownList18.SelectedValue
            End If
            ' sucursales
            If Me.CheckBox1.Checked = True Then
                idsucursal = Me.DropDownList2.SelectedValue
            Else
                .idSucursal = 0
            End If
            titulo = Me.TextBox1.Text & " - " & Me.TextBox2.Text
            If Me.CheckBox1.Checked = True Then
                titulo = titulo & "(" & Me.DropDownList18.SelectedItem.Text & ") " & Me.DropDownList2.SelectedItem.Text
            Else
                titulo = titulo & "(" & Me.DropDownList18.SelectedItem.Text & ") "
            End If

            .idEmpresa = idempresa '
            .idSucursal = idsucursal
            tabla = .obtenerDatosEncabezadoPorEmpresas
            If tabla.Rows.Count <> 0 Then
                Me.Panel6.Visible = True
                Me.GridView5.Caption = titulo
                '
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.Label5.Text = ""
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        Me.Panel6.Visible = False
        '
        If Me.DropDownList18.SelectedIndex = 0 Or Me.DropDownList18.SelectedIndex = -1 Then
            Me.Label5.Text = "Seleccione la empresa...!"
            Exit Sub
        End If
        ''
        'If Me.DropDownList13.SelectedIndex > 0 Then
        '    Select Case Me.DropDownList13.SelectedIndex
        '        Case Is = 2
        '            If Me.DropDownList14.SelectedIndex Then
        '                If Me.DropDownList14.SelectedIndex > 28 Then
        '                    Me.Label5.Text = "este mes es de solo 28 dias...!"
        '                    Exit Sub
        '                End If
        '            End If
        '        Case Is = 4, 6, 9, 11 ' meses de 30 dias
        '            If Me.DropDownList14.SelectedIndex > 30 Then
        '                Me.Label5.Text = "este mes es de solo 30 dias...!"
        '                Exit Sub
        '            End If
        '    End Select
        'End If
        ''
        'If Me.DropDownList15.SelectedIndex = 0 Or Me.DropDownList16.SelectedIndex = 0 Or Me.DropDownList17.SelectedIndex = 0 Then
        '    Me.Label5.Text = "debe seleccionar la fecha final correctamente...!"
        '    Exit Sub
        'End If
        ''
        'If Me.DropDownList16.SelectedIndex > 0 Then
        '    Select Case Me.DropDownList16.SelectedIndex
        '        Case Is = 2
        '            If Me.DropDownList17.SelectedIndex Then
        '                If Me.DropDownList14.SelectedIndex > 28 Then
        '                    Me.Label5.Text = "este mes es de solo 28 dias...!"
        '                    Exit Sub
        '                End If
        '            End If
        '        Case Is = 4, 6, 9, 11 ' meses de 30 dias
        '            If Me.DropDownList17.SelectedIndex > 30 Then
        '                Me.Label5.Text = "este mes es de solo 30 dias...!"
        '                Exit Sub
        '            End If
        '    End Select
        'End If
        '
        If Me.CheckBox1.Checked = True Then
            If Me.DropDownList2.SelectedIndex = 0 Then
                Me.Label5.Text = "debe seleccionar la sucursal...!"
                Exit Sub
            End If
        End If
        '
        mostrarDatos()
        mostrarTotales()
        ' productos facturados
        datosProductosFacturados()
        mostrarTotalesProductosFacturados()
        ' productos facturados por usuario
        datosProductosFacturadosPorUsuarios()
        mostrarTotalesProductosFacturadosPorUsuarios()
    End Sub

    Sub mostrarTotalesProductosFacturadosPorUsuarios()
        Dim y As Integer
        Dim suma1 As Double = 0

        If Me.GridView1.Rows.Count <> 0 Then
            For y = 0 To Me.GridView1.Rows.Count - 1
                suma1 += CDbl(Me.GridView1.Rows(y).Cells(3).Text)
            Next
            Me.GridView1.FooterRow.Cells(3).Text = FormatNumber(suma1, 0)
            Me.GridView1.FooterRow.Cells(0).Text = "Totales:"
        End If

    End Sub

    Sub datosProductosFacturadosPorUsuarios()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "nombreCompletoUsuario,referenciaproducto," & _
        "nombreProducto," & _
        "sum(cantidadDetFacturaPro) as cantidad" & _
        " from vw_productosFacturadosPorUsuarios" & _
        " where" & _
        " fechaEncFacturaPro between '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' and" & _
        " estadoEncfacturaPro = 1 And" & _
        " idEmpresa = " & Me.DropDownList18.SelectedValue
        ' sucursales
        If Me.CheckBox1.Checked = True Then
            sql = sql & " and idsucursal=" & Me.DropDownList2.SelectedValue
        End If
        sql = sql & " Group by" & _
        " nombreCompletoUsuario,referenciaproducto," & _
        " nombreProducto" & _
        " order by nombreCompletoUsuario,sum(cantidadDetFacturaPro) desc"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub


    Sub mostrarTotalesProductosFacturados()
        Dim y As Integer
        Dim suma1 As Double = 0

        If Me.GridView6.Rows.Count <> 0 Then
            For y = 0 To Me.GridView6.Rows.Count - 1
                suma1 += CDbl(Me.GridView6.Rows(y).Cells(2).Text)
            Next
            Me.GridView6.FooterRow.Cells(2).Text = FormatNumber(suma1, 0)
            Me.GridView6.FooterRow.Cells(0).Text = "Totales:"
        End If

    End Sub

    Sub datosProductosFacturados()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "referenciaproducto," & _
        "nombreProducto," & _
        "sum(cantidadDetFacturaPro) as cantidad" & _
        " from vw_reporteProductosFacturados" & _
        " where" & _
        " fechaEncFacturaPro between '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' and" & _
        " estadoEncfacturaPro = 1 And" & _
        " idEmpresa = " & Me.DropDownList18.SelectedValue
        ' sucursales

        If Me.CheckBox1.Checked = True Then
            sql = sql & " and idsucursal=" & Me.DropDownList2.SelectedValue
        End If
        sql = sql & " Group by" & _
        " referenciaproducto," & _
        " nombreProducto" & _
        " order by sum(cantidadDetFacturaPro) desc"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView6.DataSource = tabla
                Me.GridView6.DataBind()
            Else
                Me.GridView6.DataSource = Nothing
                Me.GridView6.DataBind()
            End If
        End With
    End Sub

    Sub mostrarTotales()
        Dim y As Integer
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        Dim suma4 As Double = 0
        Dim suma5 As Double = 0
        Dim suma6 As Double = 0
        Dim suma7 As Double = 0
        Dim suma8 As Double = 0
        Dim sumaPuntos As Double = 0
        Dim sumaNumeroTs As Double = 0

        If Me.GridView5.Rows.Count <> 0 Then
            For y = 0 To Me.GridView5.Rows.Count - 1
                sumaPuntos += CDbl(Me.GridView5.Rows(y).Cells(3).Text)
                suma1 += CDbl(Me.GridView5.Rows(y).Cells(4).Text)
                suma2 += CDbl(Me.GridView5.Rows(y).Cells(5).Text)
                suma3 += CDbl(Me.GridView5.Rows(y).Cells(6).Text)
                suma4 += CDbl(Me.GridView5.Rows(y).Cells(7).Text)
                suma5 += CDbl(Me.GridView5.Rows(y).Cells(8).Text)
                suma6 += CDbl(Me.GridView5.Rows(y).Cells(9).Text)
                suma7 += CDbl(Me.GridView5.Rows(y).Cells(10).Text)
                suma8 += CDbl(Me.GridView5.Rows(y).Cells(11).Text)
            Next
            Me.GridView5.FooterRow.Cells(3).Text = FormatNumber(sumaPuntos, 0)
            Me.GridView5.FooterRow.Cells(4).Text = FormatNumber(suma1, 0)
            Me.GridView5.FooterRow.Cells(5).Text = FormatNumber(suma2, 0)
            Me.GridView5.FooterRow.Cells(6).Text = FormatNumber(suma3, 0)
            Me.GridView5.FooterRow.Cells(7).Text = FormatNumber(suma4, 0)
            Me.GridView5.FooterRow.Cells(8).Text = FormatNumber(suma5, 0)
            Me.GridView5.FooterRow.Cells(9).Text = FormatNumber(suma6, 0)
            Me.GridView5.FooterRow.Cells(10).Text = FormatNumber(suma7, 0)
            Me.GridView5.FooterRow.Cells(11).Text = FormatNumber(suma8, 0)
            'Me.GridView5.FooterRow.Cells(15).Text = FormatNumber(sumaNumeroTs, 0)
            Me.GridView5.FooterRow.Cells(0).Text = "Totales:" 'FormatNumber(sumaPuntos, 0)
        End If
    End Sub

    Protected Sub DropDownList18_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList18.SelectedIndexChanged
        If Me.DropDownList18.SelectedIndex > 0 Then
            cargarSucursales()
        Else
            Me.CheckBox1.Checked = False
            Me.Panel5.Visible = False
        End If
    End Sub

    Sub cargarSucursales()
        Dim tabla As New DataTable
        With sucursales
            .idEmpresa = Me.DropDownList18.SelectedValue
            tabla = .obtenerSucursalePorEmpresa
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList2.DataSource = tabla
                Me.DropDownList2.DataTextField = "nombreSucursal"
                Me.DropDownList2.DataValueField = "idSucursal"
                Me.DropDownList2.DataBind()
            Else
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()
            End If
            Me.DropDownList2.Items.Insert(0, "Seleccione Sucursal")
        End With
    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Panel5.Visible = True
            Me.Label6.Visible = True
        Else
            Me.Panel5.Visible = False
            Me.Label6.Visible = False
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If Me.GridView5.Rows.Count > 0 Then
            ExportToExcel("reporteFacturacion-" & Me.DropDownList18.SelectedItem.Text & ".xls", Me.GridView5)
        End If
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView2.Columns(0).Visible = False
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

   
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub ImageButton12_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton12.Click
        If Me.GridView6.Rows.Count > 0 Then
            ExportToExcelProductosFacturados("ProductosFacturados-" & Me.DropDownList18.SelectedItem.Text & ".xls", Me.GridView6)
        End If
    End Sub

    Private Sub ExportToExcelProductosFacturados(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView2.Columns(0).Visible = False
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

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.MultiView1.ActiveViewIndex = 2
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView1.Rows.Count > 0 Then
            ExportToExcelProductosFacturadosPorUsuarios("ProductosFacturadosPorUsuarios-" & Me.DropDownList18.SelectedItem.Text & ".xls", Me.GridView1)
        End If
    End Sub

    Private Sub ExportToExcelProductosFacturadosPorUsuarios(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView2.Columns(0).Visible = False
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
End Class
