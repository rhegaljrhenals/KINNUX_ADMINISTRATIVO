Imports System.Data
Imports System.IO

Partial Class Reportes_wfExistencias
    Inherits System.Web.UI.Page

    Dim bodegaPais As New clsTTBodPaisProducto
    Dim empresas As New clsEmpresa

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarExistencias()
            'actualizaExportacion()
            'Me.ImageButton8.Visible = False
            cargarEmpresas()
        End If
        'If (Session("idUsuario") Is Nothing Or Session("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idempresa"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
        End With
    End Sub

    Sub actualizaExportacion()
        If Me.GridView1.Rows.Count = 0 Then
            Me.ImageButton8.Visible = False
        Else
            Me.ImageButton8.Visible = True
        End If
    End Sub

    Sub cargarExistencias()
        Dim tabla As New DataTable
        With bodegaPais
            .idEmpresa = Me.DropDownList1.SelectedValue
            tabla = .obtenerExistenciasPorEmpresas
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With


    End Sub

    Protected Sub ImageButton8_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        'panelDatos.Visible = False
        ExportToExcel("Existencias.xls", GridView1)
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView1.Columns(0).Visible = False
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

    Protected Sub ImageButton7_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        actualizaExportacion()
        cargarExistencias()
    End Sub
End Class
