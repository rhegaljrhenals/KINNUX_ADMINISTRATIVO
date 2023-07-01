Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfReporteProductosFacturados
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim encabezadofactura As New clsTTEncFacturaPro
    Dim sucursales As New clsSucursale
    Dim usuarios As New clsUsuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarEmpresas()
            cargarUsuarios()
            Me.TextBox1.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.TextBox2.Text = CDate(Now.Date).ToString("yyyy/MM/dd")
            Me.Panel1.Visible = False
        End If
    End Sub

    Sub cargarUsuarios()
        Dim tabla As New DataTable
        With usuarios
            tabla = .obtenerUsuariosBogota
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList2.DataSource = tabla
                Me.DropDownList2.DataTextField = "nombrecompletousuario"
                Me.DropDownList2.DataValueField = "idUsuario"
                Me.DropDownList2.DataBind()
            Else
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()
            End If
            Me.DropDownList2.Items.Insert(0, "Seleccione Usuario")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label5.Text = ""
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Then
            Me.Label5.Text = "Seleccione la fecha...!"
            Exit Sub
        End If
        '
        Me.Panel1.Visible = False
        '
        Me.GridView4.DataSource = Nothing
        Me.GridView4.DataBind()
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        Dim tabla As New DataTable
        With encabezadofactura
            .idEmpresa = 15
            .idSucursal = 21
            .idUsuario = Me.DropDownList2.SelectedValue
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            tabla = .obtenerProductosFacturadosPorusuarios
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
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

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView4.Rows.Count > 0 Then
            ExportToExcel("ProductosFacturados-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView4)
        End If
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Me.Panel1.Visible = True
        Dim idProducto As Integer
        Dim tabla As New DataTable
        idProducto = Val(Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text)
        With encabezadofactura
            .idEmpresa = Session("idpais")
            .idSucursal = Session("idsucursal")
            .fechaInicial = Me.TextBox1.Text
            .fechaFinal = Me.TextBox2.Text
            .idUsuario = Session("idusuario")
            tabla = .obtenerDetalleProductosFacturadosPorUsuarios(idProducto)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
                Me.Label4.Text = "Detalle Facturado: " & Me.GridView4.Rows(e.NewSelectedIndex).Cells(2).Text
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
                Me.Label4.Text = ""
            End If
        End With
        '
        If Me.GridView5.Rows.Count <> 0 Then
            calcularTotales()
        End If
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma As Double = 0
        For y = 0 To Me.GridView5.Rows.Count - 1
            suma += Me.GridView5.Rows(y).Cells(2).Text
        Next
        Me.GridView5.FooterRow.Cells(0).Text = "Total:"
        Me.GridView5.FooterRow.Cells(2).Text = FormatNumber(suma, 0)
    End Sub

    Protected Sub ImageButton6_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        If Me.GridView5.Rows.Count > 0 Then
            ExportToExcelDetalle("Detalle-" & Me.TextBox1.Text & "-" & Me.TextBox2.Text & ".xls", Me.GridView5)
        End If
    End Sub

    Private Sub ExportToExcelDetalle(ByVal nameReport As String, ByVal wControl As GridView)
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
