Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfRangoCalificado
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            cargarAno()
        End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList3.Items.Add(y)
        Next
        Me.DropDownList3.Items.Insert(0, "Año")
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idpais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Todas Las Empresas")
        End With
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

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label6.Text = ""
        If Me.DropDownList2.SelectedIndex = 0 Or Me.DropDownList3.SelectedIndex = 0 Then
            Me.Label6.Text = "Seleccione el periodo correctamente...!"
            Exit Sub
        End If
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "ttrangoPago.codigoafiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        " case ttrangoPago.rangoPago" & _
        " when 'vi' then 'Visionario'" & _
        " when 'ee' then 'Entrenador Experto'" & _
        " when 'ec' then 'Entrenador De Campo'" & _
        " when 'pf' then 'Profesional'" & _
        " end rangoPago," & _
        "ttrangoPago.volumenPago," & _
        " case ttrangoPago.mesRangoPago" & _
        " when 1 then 'Enero'" & _
        " when 2 then 'Febrero'" & _
        " when 3 then 'Marzo'" & _
        " when 4 then 'Abril'" & _
        " when 5 then 'Mayo'" & _
        " when 6 then 'Junio'" & _
        " when 7 then 'Julio'" & _
        " when 8 then 'Agosto'" & _
        " when 9 then 'Septiembre'" & _
        " when 10 then 'Octubre'" & _
        " when 11 then 'Noviembre'" & _
        " when 12 then 'Diciembre'" & _
        " end mesRangoPago," & _
        "ttrangoPago.anoRangoPago," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " ttrangoPago ON dbo.Afiliaciones.codigoAfiliado = ttrangoPago.codigoafiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais" & _
        " where ttrangoPago.mesRangoPago=" & Me.DropDownList2.SelectedValue & " and ttrangoPago.anoRangoPago=" & Me.DropDownList3.SelectedItem.Text
        If Me.DropDownList1.SelectedIndex = 0 Then
            sql = sql
        Else
            sql = sql & " and TBpais.codigoPais=" & Me.DropDownList1.SelectedValue
        End If
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("RangosPagos.xls", Me.GridView2)
        End If
    End Sub
End Class
