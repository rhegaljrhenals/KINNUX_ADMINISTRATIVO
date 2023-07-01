Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfConsultaAfiliaciones
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise

    Sub buscar()
        Dim sql As String
        Dim tabla As New DataTable
        Me.ImageButton10.Visible = False
        sql = "select " & _
        "a.codigoafiliado," & _
        "a.pnombre + ' ' + a.snombre + ' ' + a.papellido + ' ' + a.sapellido as nombres," & _
        "a.email1," & _
        "p.nombrepais," & _
        "a.fechaAfiliacion" & _
        " from afiliaciones a,tbPais p" & _
        " where" & _
        " a.codigopais=p.codigoPais and" & _
        " fechaAfiliacion between '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "'" & _
        " order by a.fechaAfiliacion"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
        If Me.GridView1.Rows.Count = 0 Then
            Me.Label3.Text = "No hay registros Encontrados...!"
            Me.ImageButton10.Visible = False
        Else
            Me.Label3.Text = "Registros Encontrados: " & Me.GridView1.Rows.Count
            Me.ImageButton10.Visible = True
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.ImageButton10.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.Label4.Text = ""
        If Me.TextBox1.Text <> "" And Me.TextBox2.Text <> "" Then
            buscar()
        Else
            Me.Label4.Text = "Seleccione las fechas correspondientes"
        End If
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        ExportToExcel("Informe.xls", GridView1)
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
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
