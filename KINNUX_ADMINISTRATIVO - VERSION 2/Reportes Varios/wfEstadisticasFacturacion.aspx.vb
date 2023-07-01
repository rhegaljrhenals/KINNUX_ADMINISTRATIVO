Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfEstadisticasFacturacion
    Inherits System.Web.UI.Page

    Dim resumenFacturacion As New clsResumenFacturacionPaquetes
    Dim operaciones As New clsOperacione

    Sub quitarCeros()
        Dim y As Integer
        Dim k As Integer
        For y = 0 To Me.GridView2.Rows.Count - 1
            For k = 2 To Me.GridView2.Columns.Count - 1
                If Me.GridView2.Rows(y).Cells(k).Text = "0" Then
                    Me.GridView2.Rows(y).Cells(k).Text = ""
                End If
            Next
        Next
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim columna As Integer = 2
        Dim suma1 As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        Dim suma4 As Double = 0
        Dim suma5 As Double = 0
        Dim suma6 As Double = 0
        Dim suma7 As Double = 0
        Dim suma8 As Double = 0
        Dim suma9 As Double = 0
        Dim suma10 As Double = 0
        '
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma1 += Me.GridView2.Rows(y).Cells(2).Text
            suma2 += Me.GridView2.Rows(y).Cells(4).Text
            suma3 += Me.GridView2.Rows(y).Cells(6).Text
            suma4 += Me.GridView2.Rows(y).Cells(7).Text
        Next
        Me.GridView2.FooterRow.Cells(0).Text = "Totales:"
        Me.GridView2.FooterRow.Cells(2).Text = FormatNumber(suma1, 0)
        Me.GridView2.FooterRow.Cells(4).Text = FormatNumber(suma2, 0)
        Me.GridView2.FooterRow.Cells(6).Text = FormatNumber(suma3, 0)
        Me.GridView2.FooterRow.Cells(7).Text = FormatNumber(suma4, 0)
    End Sub

    'Function mostrarDatos() As String
    '    Dim haydatos As String
    '    Dim tabla As New DataTable
    '    With resumenFacturacion
    '        tabla = .PaquetePorFecha(Me.DropDownList10.SelectedValue, Me.DropDownList9.SelectedItem.Text)
    '        If tabla.Rows.Count <> 0 Then
    '            Me.GridView2.DataSource = tabla
    '            Me.GridView2.DataBind()
    '            haydatos = "si"
    '        Else
    '            Me.GridView2.DataSource = Nothing
    '            Me.GridView2.DataBind()
    '            haydatos = "no"
    '        End If
    '    End With
    '    Return haydatos
    'End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            'Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.Label7.Visible = False
            Me.DropDownList12.Visible = False
            '
            cargarAno()
            cargarEmpresas()
        End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = Now.Year To 2012 Step -1
            Me.DropDownList13.Items.Add(y)
            Me.DropDownList16.Items.Add(y)
        Next
    End Sub

    Sub cargarEmpresas()
        With operaciones
            .cargarCombos(Me.DropDownList11, "select * from tbempresa order by idempresa", "idEmpresa", "nombreEmpresa", "")
        End With
    End Sub

    Sub cargarSucursales()
        Dim sql As String
        If Me.DropDownList11.SelectedIndex > 0 Then
            sql = "select * from tbsucursal where idEmpresa=" & Me.DropDownList11.SelectedValue
            With operaciones
                .cargarCombos(Me.DropDownList12, sql, "idSucursal", "nombreSucursal", "")
            End With
        End If
    End Sub

    'Sub cargarAno()
    '    Dim y As Integer
    '    For y = 2012 To Now.Year
    '        Me.DropDownList9.Items.Add(y)
    '    Next
    'End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("EstadisticasFacturacion.xls", Me.GridView2)
        End If
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

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.Label7.Visible = True
            Me.DropDownList12.Visible = True
            '
            cargarSucursales()
        Else
            Me.Label7.Visible = False
            Me.DropDownList12.Visible = False

        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim informacionEncontrada As String = "no"
        Me.Label8.Text = ""
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        If Me.DropDownList14.SelectedIndex = 0 Or Me.DropDownList15.SelectedIndex = 0 Then
            Me.Label8.Text = "Seleccione la fecha inicial correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList17.SelectedIndex = 0 Or Me.DropDownList18.SelectedIndex = 0 Then
            Me.Label8.Text = "Seleccione la fecha final correctamente...!"
            Exit Sub
        End If
        '
        If Me.DropDownList11.SelectedIndex = 0 Then
            Me.Label8.Text = "Seleccione la empresa...!"
            Exit Sub
        End If
        '
        If Me.CheckBox1.Checked = True Then
            If Me.DropDownList12.SelectedIndex = 0 Then
                Me.Label8.Text = "Debe seleccionar la sucursal...!"
                Exit Sub
            End If
        End If
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "distinct(TBPaquete.idPaquete), " & _
        "TBPaquete.nombrePaquete, " & _
        "TBPaquetePais.precioLocalPaquetePais, " & _
        "TBPaquete.unibase,'' as cantidad,'' as v1,'' as v2" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBEmpresa ON TBPaquetePais.idPais = dbo.TBEmpresa.idPais INNER JOIN" & _
        " TTEncFacturaPro ON TBPaquete.idPaquete = TTEncFacturaPro.paqueteEncFacturaPro INNER JOIN" & _
        " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro" & _
        " where" & _
        " dbo.TBEmpresa.idEmpresa=" & Me.DropDownList11.SelectedValue & " and" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.DropDownList13.SelectedItem.Text & "/" & Me.DropDownList14.SelectedValue & "/" & Me.DropDownList15.SelectedValue & "' and '" & Me.DropDownList16.SelectedItem.Text & "/" & Me.DropDownList17.SelectedValue & "/" & Me.DropDownList18.SelectedValue & "' and" & _
        " TTEncFacturaPro.estadoencFacturaPro = 1"
        If Me.CheckBox1.Checked = True Then
            sql = sql & " and TTEncFacturaPro.idSucursal=" & Me.DropDownList12.SelectedValue
        End If
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                informacionEncontrada = "si"
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                informacionEncontrada = "no"
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
        '
        If informacionEncontrada = "si" Then
            ' cantidad facturada
            For y = 0 To Me.GridView2.Rows.Count - 1
                sql = "SELECT isnull(sum(TTEncFacturaPro.numtsEncFacturapro),0) as cantidad " & _
                " FROM TTEncFacturaPro" & _
                " where" & _
                " TTEncFacturaPro.idEmpresa=" & Me.DropDownList11.SelectedValue & " and" & _
                " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.DropDownList13.SelectedItem.Text & "/" & Me.DropDownList14.SelectedValue & "/" & Me.DropDownList15.SelectedValue & "' and '" & Me.DropDownList16.SelectedItem.Text & "/" & Me.DropDownList17.SelectedValue & "/" & Me.DropDownList18.SelectedValue & "' and" & _
                " TTEncFacturaPro.estadoencFacturaPro = 1 and" & _
                " TTEncFacturaPro.paqueteEncfacturapro=" & Me.GridView2.Rows(y).Cells(0).Text
                If Me.CheckBox1.Checked = True Then
                    sql = sql & " and TTEncFacturaPro.idSucursal=" & Me.DropDownList12.SelectedValue
                End If
                With operaciones
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView2.Rows(y).Cells(2).Text = FormatNumber(tabla.Rows(0).Item("cantidad"), 0)
                    End If
                End With
            Next y
            ' calculo unidades en promocion
            For y = 0 To Me.GridView2.Rows.Count - 1
                sql = "SELECT     " & _
                "isnull(sum(TTDetFacturaPro.cantidadDetFacturaPro),0) as cantidad" & _
                " FROM" & _
                " TTEncFacturaPro INNER JOIN" & _
                " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro" & _
                " where TTEncFacturaPro.idEmpresa=" & Me.DropDownList11.SelectedValue & " And " & _
                " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.DropDownList13.SelectedItem.Text & "/" & Me.DropDownList14.SelectedValue & "/" & Me.DropDownList15.SelectedValue & "' and '" & Me.DropDownList16.SelectedItem.Text & "/" & Me.DropDownList17.SelectedValue & "/" & Me.DropDownList18.SelectedValue & "' and" & _
                " TTEncFacturaPro.estadoEncFacturaPro = 1 and (TTDetFacturaPro.promoDetFacturaPro='P' or TTDetFacturaPro.promoDetFacturaPro='O') and" & _
                " TTEncFacturaPro.paqueteEncfacturapro=" & Me.GridView2.Rows(y).Cells(0).Text
                If Me.CheckBox1.Checked = True Then
                    sql = sql & " and TTEncFacturaPro.idSucursal=" & Me.DropDownList12.SelectedValue
                End If
                '
                With operaciones
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView2.Rows(y).Cells(4).Text = FormatNumber(tabla.Rows(0).Item("cantidad"), 0)
                    End If
                End With
            Next
            ' cantidad facturada * valor paquete
            For y = 0 To Me.GridView2.Rows.Count - 1
                Me.GridView2.Rows(y).Cells(6).Text = FormatNumber((CDbl(Me.GridView2.Rows(y).Cells(2).Text) * CDbl(Me.GridView2.Rows(y).Cells(5).Text)), 0)
            Next
            ' unidad base * cantidad facturada
            For y = 0 To Me.GridView2.Rows.Count - 1
                Me.GridView2.Rows(y).Cells(7).Text = FormatNumber((CDbl(Me.GridView2.Rows(y).Cells(3).Text) * CDbl(Me.GridView2.Rows(y).Cells(2).Text)), 0)
            Next
            '
            If Me.GridView2.Rows.Count <> 0 Then
                calcularTotales()
            End If
        Else
            Me.Label8.Text = "Informacion no encontrada con este criterio de busqueda...!"
        End If
    End Sub
End Class
