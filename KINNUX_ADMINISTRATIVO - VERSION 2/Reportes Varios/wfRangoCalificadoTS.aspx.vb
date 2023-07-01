Imports System.Data
Imports System.IO

Partial Class Reportes_Varios_wfComisionMensual
    Inherits System.Web.UI.Page

    Dim objTTComision As New clsTTComision
    Dim paises As New clsPaise
    Dim empresas As New clsEmpresa
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'cargarPaises()
            cargarEmpresas()
            'cargarDpto()
            cargarAno()
            Me.ImageButton2.Visible = False
            Me.DropDownList14.Visible = False
            Me.DropDownList15.Visible = False
            Me.Label7.Visible = False
            Me.Label8.Visible = False
            '
            Me.Panel1.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarDpto()
        Dim sql As String
        Dim tabla As New DataTable
        '
        sql = "SELECT     " & _
        "distinct(dbo.TBDpto.nombreDpto), " & _
        "dbo.TBDpto.codigoDpto" & _
        " FROM" & _
        " TTRangoCalifTS INNER JOIN" & _
        " dbo.Afiliaciones ON TTRangoCalifTS.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto" & _
        " where dbo.TBpais.codigoPais=" & Me.DropDownList1.SelectedValue
        With operaciones
            .cargarCombos(Me.DropDownList14, sql, "codigoDpto", "nombreDpto", "Todos Los Departamento")
        End With
    End Sub

    Sub cargarMunicipio()
        Dim sql As String
        Dim tabla As New DataTable
        '
        sql = "SELECT     " & _
        "distinct(dbo.TBMunicipio.codigoMunicipio), " & _
        "dbo.TBMunicipio.nombreMunicipio" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTRangoCalifTS ON dbo.Afiliaciones.codigoAfiliado = TTRangoCalifTS.codigoafiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where dbo.TBDpto.codigoDpto=" & Me.DropDownList14.SelectedValue
        With operaciones
            .cargarCombos(Me.DropDownList15, sql, "codigoMunicipio", "nombreMunicipio", "Todos Los Municipios")
        End With
    End Sub

    Sub cargarEmpresas()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbempresa order by nombreempresa"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreEmpresa"
                Me.DropDownList1.DataValueField = "idpais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Todas las empresas")
        End With
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList12.Items.Add(y)
        Next
        Me.DropDownList12.Items.Insert(0, "Año")
    End Sub

    Sub cargarPaises()
        Dim tabla As New DataTable
        With paises
            tabla = .MostrarPaise
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombrepais"
                Me.DropDownList1.DataValueField = "codigopais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Todos Los Paises")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim sql As String
        Dim tabla As New DataTable
        Me.Label4.Text = ""
        Me.Panel1.Visible = False
        Me.Label6.Text = ""
        If Me.DropDownList13.SelectedIndex = 0 Or Me.DropDownList12.SelectedIndex = 0 Then
            Me.Label4.Text = "Seleccione el periodo correctamente...!"
        Else
            sql = "SELECT     " & _
            "dbo.Afiliaciones.codigoAfiliado, " & _
            "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.sapellido as nombres, " & _
            " case TTRangoCalifTS.rangocalifts" & _
            " when 'em' then 'Empresarial'" & _
            " when 'vi' then 'Visionario'" & _
            " when 'ee' then 'Entrenador'" & _
            " when 'ec' then 'Entrenador De Campo'" & _
            " when 'pf' then 'Profesional'" & _
            " when 'di' then 'Director'" & _
            " when 'dn' then 'Director Internacional'" & _
            " when 'pr' then 'Presidente'" & _
            " else ''" & _
            " end Rango," & _
            " case TTRangoCalifTS.mesrangocalifts" & _
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
            " end mes," & _
            " TTRangoCalifTS.anorangocalifts," & _
            " TTRangoCalifTS.tsrangocalifts," & _
            " TTRangoCalifTS.posicion," & _
            " dbo.TBpais.nombrePais," & _
            " dbo.TBDpto.nombreDpto," & _
            " dbo.TBMunicipio.nombreMunicipio" & _
            " FROM" & _
            " TTRangoCalifTS INNER JOIN" & _
            " dbo.Afiliaciones ON TTRangoCalifTS.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
            " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
            " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
            " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
            " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
            " where TTRangoCalifTS.mesrangocalifts=" & Me.DropDownList13.SelectedValue & " and" & _
            " TTRangoCalifTS.anorangocalifts=" & Me.DropDownList12.SelectedItem.Text
            If Me.DropDownList1.SelectedIndex = 0 Then
                sql = sql & " order by dbo.TBpais.nombrePais"
            Else
                sql = sql & " and dbo.TBpais.codigopais=" & Me.DropDownList1.SelectedValue
                If Me.DropDownList14.SelectedIndex = 0 Then
                    sql = sql & " order by dbo.Afiliaciones.codigoAfiliado"
                Else
                    sql = sql & " and dbo.TBDpto.codigoDpto=" & Me.DropDownList14.SelectedValue
                    If Me.DropDownList15.SelectedIndex = 0 Then
                        sql = sql & " and dbo.TBMunicipio.codigoMunicipio=" & Me.DropDownList15.SelectedValue
                    End If
                End If
            End If
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.Panel1.Visible = True
                    Me.GridView2.DataSource = tabla
                    Me.GridView2.DataBind()
                Else
                    Me.GridView2.DataSource = Nothing
                    Me.GridView2.DataBind()
                End If
            End With
        End If
    End Sub

    Sub calcularTotales()
        Dim y As Integer
        Dim suma1 As Decimal = 0
        Dim suma2 As Decimal = 0
        Dim suma3 As Decimal = 0
        Dim suma4 As Decimal = 0
        Dim suma5 As Decimal = 0
        Dim suma6 As Decimal = 0
        Dim suma7 As Decimal = 0
        Dim suma8 As Decimal = 0
        Dim suma9 As Decimal = 0
        Dim suma10 As Decimal = 0
        Dim suma11 As Decimal = 0
        Dim sumaBono2 As Decimal = 0
        Dim suma12 As Decimal = 0
        Dim suma13 As Decimal = 0

        '
        For y = 0 To Me.GridView2.Rows.Count - 1
            suma1 += CDbl(Me.GridView2.Rows(y).Cells(6).Text)
            suma2 += CDbl(Me.GridView2.Rows(y).Cells(7).Text)
            suma3 += CDbl(Me.GridView2.Rows(y).Cells(8).Text)
            suma4 += CDbl(Me.GridView2.Rows(y).Cells(9).Text)
            suma5 += CDbl(Me.GridView2.Rows(y).Cells(10).Text)
            suma6 += CDbl(Me.GridView2.Rows(y).Cells(11).Text)
            suma7 += CDbl(Me.GridView2.Rows(y).Cells(12).Text)
            suma8 += CDbl(Me.GridView2.Rows(y).Cells(13).Text)
            suma9 += CDbl(Me.GridView2.Rows(y).Cells(14).Text)
            sumaBono2 += CDbl(Me.GridView2.Rows(y).Cells(15).Text)
            suma11 += CDbl(Me.GridView2.Rows(y).Cells(16).Text)
            suma12 += CDbl(Me.GridView2.Rows(y).Cells(17).Text)
            suma13 += CDbl(Me.GridView2.Rows(y).Cells(18).Text)

        Next
        Me.GridView2.FooterRow.Cells(0).Text = "Totales:"
        '
        Me.GridView2.FooterRow.Cells(6).Text = FormatNumber(suma1, 2)
        Me.GridView2.FooterRow.Cells(7).Text = FormatNumber(suma2, 2)
        Me.GridView2.FooterRow.Cells(8).Text = FormatNumber(suma3, 2)
        Me.GridView2.FooterRow.Cells(9).Text = FormatNumber(suma4, 2)
        Me.GridView2.FooterRow.Cells(10).Text = FormatNumber(suma5, 2)
        Me.GridView2.FooterRow.Cells(11).Text = FormatNumber(suma6, 2)
        Me.GridView2.FooterRow.Cells(12).Text = FormatNumber(suma7, 2)
        Me.GridView2.FooterRow.Cells(13).Text = FormatNumber(suma8, 2)
        Me.GridView2.FooterRow.Cells(14).Text = FormatNumber(suma9, 2)
        Me.GridView2.FooterRow.Cells(15).Text = FormatNumber(sumaBono2, 2)
        Me.GridView2.FooterRow.Cells(16).Text = FormatNumber(suma11, 2)
        Me.GridView2.FooterRow.Cells(17).Text = FormatNumber(suma12, 2)
        Me.GridView2.FooterRow.Cells(18).Text = FormatNumber(suma13, 2)

    End Sub

    'Function mostrarDatos() As String
    '    Dim encontroDatos As String = "no"
    '    Me.ImageButton2.Visible = False
    '    Dim tabla As New DataTable
    '    Dim idEmpresa As Integer
    '    If Me.DropDownList1.SelectedIndex = 0 Then
    '        idEmpresa = 0
    '    Else
    '        idEmpresa = Me.DropDownList1.SelectedValue
    '    End If
    '    'With objTTComision
    '    '    .idEmpresa = idEmpresa
    '    '    .mes = Me.DropDownList13.SelectedValue
    '    '    .ano = Me.DropDownList12.SelectedItem.Text
    '    '    tabla = .obtenerDatosComisionesMensualesTS
    '    '    If tabla.Rows.Count <> 0 Then
    '    '        Me.GridView2.DataSource = tabla
    '    '        Me.GridView2.DataBind()
    '    '        '
    '    '        Me.Label5.Text = "Periodo: " & Me.DropDownList13.SelectedItem.Text & " De " & Me.DropDownList12.SelectedItem.Text & " - " & Me.DropDownList1.SelectedItem.Text
    '    '        Me.ImageButton2.Visible = True
    '    '        encontroDatos = "si"
    '    '    Else
    '    '        Me.GridView2.DataSource = Nothing
    '    '        Me.GridView2.DataBind()
    '    '        Me.Label5.Text = ""
    '    '        encontroDatos = "no"
    '    '    End If
    '    'End With
    '    'Return encontroDatos
    'End Function

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        ExportToExcel("ComisionMensual.xls", Me.GridView2)
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

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedIndex = 0 Then
            Me.Label7.Visible = False
            Me.DropDownList14.Visible = False
        Else
            Me.Label7.Visible = True
            Me.DropDownList14.Visible = True
            cargarDpto()
        End If
    End Sub

    Protected Sub DropDownList14_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList14.SelectedIndexChanged
        If Me.DropDownList14.SelectedIndex = 0 Then
            Me.DropDownList15.Visible = False
            Me.Label8.Visible = False
        Else
            Me.DropDownList15.Visible = True
            Me.Label8.Visible = True
            cargarMunicipio()
        End If
    End Sub
End Class
