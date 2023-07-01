Imports System.IO
Imports System.Data

Partial Class reportes2019_wfReportesApartados2
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEventos()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEventos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_encabezadoEventos where estadoevento=1 order by idevento desc"
        With objOperacione
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


    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView2.Columns(0).Visible = False
        'Me.GridView2.Columns(2).ItemStyle ..ItemStyle ..DefaultCellStyle.Format = "N2"
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

    Protected Sub GridView1_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Dim idEvento As Integer
        idEvento = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        mostrarApartados(idEvento)
    End Sub

    Sub mostrarApartados(ByVal idevento As Integer)
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttrecibo where idevento=" & idevento & " order by nombrerecibo,valorrecibo desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label4.Text = Me.GridView2.Rows.Count & " Registros encontrados...!"
                mostrarTotal()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label4.Text = "0 Registros encontrados...!"
            End If
        End With
    End Sub

    Sub mostrarTotal()
        Dim y As Integer
        Dim suma As Double = 0
        If Me.GridView2.Rows.Count <> 0 Then
            For y = 0 To Me.GridView2.Rows.Count - 1
                suma += CDbl(Me.GridView2.Rows(y).Cells(2).Text)
            Next
            Me.GridView2.FooterRow.Cells(2).Text = FormatNumber(suma, 0)
            Me.GridView2.FooterRow.Cells(0).Text = "Total:"
        End If
    End Sub

    Protected Sub ImageButton10_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton10.Click
        ExportToExcel("reporteApartados.xls", GridView2)
    End Sub
End Class
