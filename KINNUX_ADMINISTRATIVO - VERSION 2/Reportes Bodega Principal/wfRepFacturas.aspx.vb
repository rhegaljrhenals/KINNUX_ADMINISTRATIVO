Imports System.IO
Imports System.Data

Partial Class Reportes_Bodega_Principal_wfRepFacturas
    Inherits System.Web.UI.Page

    Dim encabezadofatura As New clsTTEncFacturaPro
    Dim empresas As New clsEmpresa

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            cargarEmpresas()
            '
            Me.ImageButton8.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList7.DataSource = tabla
                Me.DropDownList7.DataTextField = "nombreempresa"
                Me.DropDownList7.DataValueField = "idEmpresa"
                Me.DropDownList7.DataBind()
            Else
                Me.DropDownList7.DataSource = Nothing
                Me.DropDownList7.DataBind()
            End If
        End With
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList1.Items.Add(y)
            Me.DropDownList4.Items.Add(y)
        Next
        Me.DropDownList1.Items.Insert(0, "Año")
        Me.DropDownList4.Items.Insert(0, "Año")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        mostrarInformacion(1)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Dim t As Integer
        If Me.RadioButton1.Checked = True Then
            t = 2
        Else
            If Me.RadioButton2.Checked = True Then
                t = 3
            End If
        End If
        mostrarInformacion(t)
    End Sub

    Sub mostrarInformacion(ByVal tipo As Integer)
        Me.ImageButton8.Visible = False
        Dim tabla As New DataTable
        With encabezadofatura
            Select Case tipo
                Case Is = 1
                    .fechaInicial = Me.DropDownList1.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedItem.Text
                    .fechaFinal = Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList5.SelectedValue & "/" & Me.DropDownList6.SelectedItem.Text
                Case Is = 4
                    .idEmpresa = Me.DropDownList7.SelectedValue
            End Select
            tabla = .obtenerFacturacion(tipo)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
                '
                Me.ImageButton8.Visible = True
                '
                Me.Label2.Text = Me.GridView5.Rows.Count & " Registros Encontrados...!"
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
                '
                Me.ImageButton8.Visible = False
                Me.Label2.Text = "No existen registros...!"
            End If
        End With
    End Sub

    Protected Sub ImageButton8_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        ExportToExcel("ReportesFacturas.xls", GridView5)
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

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        mostrarInformacion(4)
    End Sub
End Class
