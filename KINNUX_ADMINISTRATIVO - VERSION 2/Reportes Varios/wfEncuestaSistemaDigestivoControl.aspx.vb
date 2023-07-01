Imports System.Data
Imports System.IO

Partial Class Reportes_wfEncuestaSistemaDigestivoControl
    Inherits System.Web.UI.Page

    Dim calificacionCartagena As New clsTtCalifCartagena
    Dim paises As New clsPaise
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'mostrarDatosAll()
            'mostrarAfiliadosAfiliadosEncuestaFormaRapida()
            'Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            'Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.MultiView1.ActiveViewIndex = 0
            Me.RadioButton1.Checked = True
        End If
    End Sub

    Sub mostrarAfiliadosAfiliadosEncuestaFormaRapida()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select *,'(' + codigoafiliado + ') ' + pnombre + ' ' + papellido as patrocinador from vw_resultadoencuestalimpiesucolon1" & _
        " order by fecha desc"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
                '

                'actualizaGrilla()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
                'Me.Label5.Text = "ENCUESTA FORMA RÁPIDA Total: ( 0 )"
            End If
        End With
    End Sub

    'Sub mostrarDatosAll()
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    sql = "select * from vw_afiliadosEncuestaKinitrox order by fecha desc"
    '    With operaciones
    '        tabla = .DevuelveDato(sql)
    '        If tabla.Rows.Count <> 0 Then
    '            Me.GridView2.DataSource = tabla
    '            Me.GridView2.DataBind()
    '            '
    '            actualizaGrilla()
    '        Else
    '            Me.GridView2.DataSource = Nothing
    '            Me.GridView2.DataBind()
    '        End If
    '    End With
    'End Sub

    Sub actualizaGrilla()
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        For y = 0 To Me.GridView2.Rows.Count - 1
            sql = "select * from detalleEncuestaSistemaDigestivo where idAfiliado=" & Me.GridView2.Rows(y).Cells(1).Text
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.Rows(y).Cells(7).Text = "Si"
                Else
                    Me.GridView2.Rows(y).Cells(7).Text = "No"
                    Me.GridView2.Rows(y).ForeColor = Drawing.Color.Red
                End If
            End With
        Next
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("Cancun2016.xls", Me.GridView2)
        Else

        End If

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

    Protected Sub GridView2_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView2.RowDeleting
        Dim sql As String
        Dim idAfiliado As Integer
        idAfiliado = Val(Me.GridView2.Rows(e.RowIndex).Cells(1).Text)
        '
        sql = "delete from afiliadosEncuestaSistemaDigestivo where idafiliado=" & idAfiliado
        With operaciones
            .Accion(sql)
        End With
        '
        sql = "delete from detalleEncuestaSistemaDigestivo where idafiliado=" & idAfiliado
        With operaciones
            .Accion(sql)
        End With
        '
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        mostrarDatosAll()
    End Sub


    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        mostrarEncuesta(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarEncuesta(ByVal idAfiliado As Integer)
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_resultadoEncuestaSistemaDigestivo where idafiliado=" & idAfiliado & " order by numero"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        mostrarDatosAll()
        mostrarAfiliadosAfiliadosEncuestaFormaRapida()
    End Sub

    Sub mostrarDatosAll()
        Dim sql As String
        Dim tabla As New DataTable
        'sql = "select * from vw_resultadoEncuestaSistemaCirculatorio"
        sql = "select distinct(idafiliado),nombres,email,telefono,pais,fecha,'(' + codigoafiliado + ') ' +  pnombre + ' ' + papellido as patrocinador" & _
        " from vw_resultadoEncuestaSistemaDigestivo" & _
        " order by fecha desc"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                '
                actualizaGrilla()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.MultiView1.ActiveViewIndex = 0
        Me.Label5.Text = "ENCUESTA FORMA GUIADA"
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.Label5.Text = "ENCUESTA FORMA RÁPIDA Total: ( " & Me.GridView4.Rows.Count & " )"
    End Sub

    Protected Sub GridView4_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView4.RowDeleting

        Dim sql As String
        Dim idAfiliado As Integer
        idAfiliado = Val(Me.GridView4.Rows(e.RowIndex).Cells(1).Text)
        '
        sql = "delete from limpiesucolon where id=" & idAfiliado
        With operaciones
            .Accion(sql)
        End With
        '
        sql = "delete from encuestaLimpieSuColon where idafiliado=" & idAfiliado
        With operaciones
            .Accion(sql)
        End With
        '
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()
        '
        mostrarAfiliadosAfiliadosEncuestaFormaRapida()
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Me.GridView5.DataSource = Nothing
        Me.GridView5.DataBind()

        mostrarEncuestaFormaRapida(Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarEncuestaFormaRapida(ByVal idAfiliado As Integer)
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from vw_resultadoencuestalimpiesucolon1 where id=" & idAfiliado
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub

    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.TextBox1.Text <> "" Then
            mostrarDatosAllPorCodigo()
        End If
    End Sub

    Sub mostrarDatosAllPorCodigo()
        Dim encontrado As String = "no"
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        Dim sql As String
        Dim tabla As New DataTable
        ' busqueda afiliado
        sql = "select * from afiliaciones where codigoafiliado='" & Me.TextBox1.Text & "' or identificacion='" & Me.TextBox1.Text & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                encontrado = "si"
                Me.Label6.Text = "Nombre: " & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("papellido")
            Else
                encontrado = "no"
                Me.Label6.Text = "No encontrado"
            End If
        End With
        '
        If encontrado = "si" Then
            sql = "select * from limpieSuColon where codigoafiliado='" & Me.TextBox1.Text & "'"
            With operaciones
                tabla = .DevuelveDato(sql)
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.DataSource = tabla
                    Me.GridView2.DataBind()
                    '
                    actualizaGrilla()
                Else
                    Me.GridView2.DataSource = Nothing
                    Me.GridView2.DataBind()
                End If
            End With

        End If
    End Sub
End Class
