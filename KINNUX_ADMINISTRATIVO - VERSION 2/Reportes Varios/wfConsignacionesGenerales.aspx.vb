Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteFacturacion
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadoFacturas As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            'cargarEmpresas()
            Me.Panel6.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    'Sub cargarEmpresas()
    '    Dim tabla As New DataTable
    '    With empresas
    '        tabla = .MostrarEmpresaGeneral
    '        Me.DropDownList18.DataSource = tabla
    '        Me.DropDownList18.DataTextField = "nombreempresa"
    '        Me.DropDownList18.DataValueField = "idEmpresa"
    '        Me.DropDownList18.DataBind()
    '    End With
    '    '
    '    Me.DropDownList18.Items.Insert(0, "Todas Las empresas")
    '    'Me.DropDownList18.DataBind()
    'End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2011 To Now.Year
            Me.DropDownList12.Items.Add(y)
            Me.DropDownList15.Items.Add(y)
            '
            Me.DropDownList12.DataValueField = y
            Me.DropDownList15.DataValueField = y
        Next
        '
        Me.DropDownList12.Items.Insert(0, "Año")
        Me.DropDownList15.Items.Insert(0, "Año")
    End Sub

    Sub mostrarDatos()
        Me.Panel6.Visible = False
        Dim tabla As New DataTable
        With encabezadoFacturas
            'If Me.RadioButton1.Checked = True Then
            '    .estadoEncfacturaPro = 1
            'Else
            '    .estadoEncfacturaPro = 0
            'End If
            .fechaInicial = Me.DropDownList12.SelectedValue & "/" & Me.DropDownList13.SelectedValue & "/" & Me.DropDownList14.SelectedValue
            .fechaFinal = Me.DropDownList15.SelectedValue & "/" & Me.DropDownList16.SelectedValue & "/" & Me.DropDownList17.SelectedValue
            tabla = .obtenerConsignacionesColombia
            If tabla.Rows.Count <> 0 Then
                Me.Panel6.Visible = True
                'Me.GridView5.Caption = titulo
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
        If Me.DropDownList12.SelectedIndex = 0 Or Me.DropDownList13.SelectedIndex = 0 Or Me.DropDownList14.SelectedIndex = 0 Then
            Me.Label5.Text = "debe seleccionar la fecha inicial correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList15.SelectedIndex = 0 Or Me.DropDownList16.SelectedIndex = 0 Or Me.DropDownList17.SelectedIndex = 0 Then
            Me.Label5.Text = "debe seleccionar la fecha final correctamente...!"
            Exit Sub
        End If
        '
        mostrarDatos()
        'mostrarTotales()
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
        Dim sumaPuntos As Double = 0
        If Me.GridView5.Rows.Count <> 0 Then
            For y = 0 To Me.GridView5.Rows.Count - 1
                suma1 += CDbl(Me.GridView5.Rows(y).Cells(4).Text)
                sumaPuntos += CDbl(Me.GridView5.Rows(y).Cells(3).Text)
                suma2 += CDbl(Me.GridView5.Rows(y).Cells(7).Text)
                suma3 += CDbl(Me.GridView5.Rows(y).Cells(8).Text)
                suma4 += CDbl(Me.GridView5.Rows(y).Cells(9).Text)
                suma5 += CDbl(Me.GridView5.Rows(y).Cells(10).Text)
                suma6 += CDbl(Me.GridView5.Rows(y).Cells(11).Text)
                suma7 += CDbl(Me.GridView5.Rows(y).Cells(12).Text)
            Next
            Me.GridView5.FooterRow.Cells(3).Text = FormatNumber(sumaPuntos, 0)
            Me.GridView5.FooterRow.Cells(4).Text = FormatNumber(suma1, 0)
            Me.GridView5.FooterRow.Cells(7).Text = FormatNumber(suma2, 0)
            Me.GridView5.FooterRow.Cells(8).Text = FormatNumber(suma3, 0)
            Me.GridView5.FooterRow.Cells(9).Text = FormatNumber(suma4, 0)
            Me.GridView5.FooterRow.Cells(10).Text = FormatNumber(suma5, 0)
            Me.GridView5.FooterRow.Cells(11).Text = FormatNumber(suma6, 0)
            Me.GridView5.FooterRow.Cells(12).Text = FormatNumber(suma7, 0)
            Me.GridView5.FooterRow.Cells(0).Text = "Totales:" 'FormatNumber(sumaPuntos, 0)
        End If
    End Sub

    'Sub cargarSucursales()
    '    Dim tabla As New DataTable
    '    With sucursales
    '        .idEmpresa = Me.DropDownList18.SelectedValue
    '        tabla = .obtenerSucursalePorEmpresa
    '        If tabla.Rows.Count <> 0 Then
    '            Me.DropDownList2.DataSource = tabla
    '            Me.DropDownList2.DataTextField = "nombreSucursal"
    '            Me.DropDownList2.DataValueField = "idSucursal"
    '            Me.DropDownList2.DataBind()
    '        Else
    '            Me.DropDownList2.DataSource = Nothing
    '            Me.DropDownList2.DataBind()
    '        End If
    '        Me.DropDownList2.Items.Insert(0, "Seleccione Sucursal")
    '    End With
    'End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If Me.GridView5.Rows.Count > 0 Then
            ExportToExcel("ConsignacionesGenerales.xls", Me.GridView5)
        End If
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView5.Columns(0).Visible = False
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
