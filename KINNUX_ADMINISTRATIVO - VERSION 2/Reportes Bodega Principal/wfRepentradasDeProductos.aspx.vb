Imports System.IO
Imports System.Data

Partial Class Reportes_Bodega_Principal_wfRepentradasDeProductos
    Inherits System.Web.UI.Page
    Dim entradaProducto As New clsTTEncEntProductoBod
    Dim detalleEntrada As New clsTTDetEntProductoBod

    Protected Sub ImageButton8_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        ExportToExcel("EntradasProductos.xls", GridView1)
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

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            cargarAno()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

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

    Sub mostrarInformacion()
        Dim tipo As Integer
        Me.Panel4.Visible = False
        Me.Panel5.Visible = False
        '
        If Me.RadioButton1.Checked = True Then
            tipo = 1
        Else
            If Me.RadioButton2.Checked = True Then
                tipo = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    tipo = 3
                Else
                    If Me.RadioButton4.Checked = True Then
                        tipo = 4
                    End If
                End If
            End If
        End If
        Dim tabla As New DataTable
        With entradaProducto
            .fechaInicial = Me.DropDownList1.SelectedItem.Text & "/" & Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedItem.Text
            .fechaFinal = Me.DropDownList4.SelectedItem.Text & "/" & Me.DropDownList5.SelectedValue & "/" & Me.DropDownList6.SelectedItem.Text
            tabla = .obtenerEntradasProductos(tipo)
            If tabla.Rows.Count <> 0 Then
                Me.Panel4.Visible = True
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
                '
                Me.Label2.Text = Me.GridView1.Rows.Count & " Registros encontrados...!"
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
                '
                Me.Label2.Text = "No existen registros encontrados...!"
            End If
        End With

    End Sub

    'Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
    '    Dim tipo As Integer
    '    If RadioButton2.Checked = True Then
    '        tipo = 2
    '    Else
    '        If Me.RadioButton3.Checked = True Then
    '            tipo = 3
    '        Else
    '            If Me.RadioButton4.Checked = True Then
    '                tipo = 4
    '            Else
    '                If Me.RadioButton5.Checked = True Then
    '                    tipo = 5
    '                End If
    '            End If
    '        End If
    '    End If
    '    mostrarInformacion(tipo)
    'End Sub

    Protected Sub ImageButton9_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        mostrarInformacion()
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        '
        Me.Panel5.Visible = False
        Dim id As Integer
        Dim tabla As New DataTable
        id = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        With detalleEntrada
            .idEncEntProductoBod = id
            tabla = .ObtenerDetEntProductoBodPorIdEntrada
            If tabla.Rows.Count <> 0 Then
                Me.Panel5.Visible = True

                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With

    End Sub
End Class
