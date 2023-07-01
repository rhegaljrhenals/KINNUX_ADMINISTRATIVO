Imports System.IO
Imports System.Data

Partial Class Reportes_Varios_wfConsultaDistribuidor
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise
    Dim afiliado As New ClsAfiliado


    Sub buscar()
        Dim sql As String
        Dim opcion As Integer
        Dim tabla As New DataTable
        Me.ImageButton10.Visible = False
        '
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton2.Checked = True Then
                opcion = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    opcion = 3
                Else
                    If Me.RadioButton4.Checked = True Then
                        opcion = 4
                    Else
                        If Me.RadioButton5.Checked = True Then
                            opcion = 5
                        Else
                            If Me.RadioButton6.Checked = True Then
                                opcion = 6
                            Else
                                If Me.RadioButton7.Checked = True Then
                                    opcion = 7
                                Else
                                    If Me.RadioButton8.Checked = True Then
                                        opcion = 8
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.Afiliaciones.direccion," & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.Afiliaciones.celular," & _
        "dbo.Afiliaciones.email1," & _
        "dbo.TBpais.nombrePais," & _
        "dbo.TBDpto.nombreDpto," & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "dbo.Afiliaciones.clave" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio"
        Select Case opcion
            Case Is = 1
                sql = sql & " and Afiliaciones.codigoafiliado='" & Me.TextBox1.Text & "'"
            Case Is = 2
                sql = sql & " and Afiliaciones.identificacion='" & Me.TextBox1.Text & "'"
            Case Is = 3
                sql = sql & " and Afiliaciones.papellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 4
                sql = sql & " and .sapellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 5
                sql = sql & " and Afiliaciones.pnombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 6
                sql = sql & " and Afiliaciones.snombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 7
                sql = sql & " and Afiliaciones.email1 like '%" & Me.TextBox1.Text & "%'"
            Case Is = 8
                sql = sql & " and TBpais.codigoPais='" & Me.DropDownList1.SelectedValue & "'"
        End Select
        sql = sql & " order by Afiliaciones.codigoAfiliado"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
            '
            Me.DataList1.DataSource = tabla
            Me.DataList1.DataBind()
        End With
        Dim encontrado As String = "no"
        If Me.GridView1.Rows.Count = 0 Then
            Me.Label3.Text = "No hay registros Encontrados...!"
            Me.ImageButton10.Visible = False
            encontrado = "no"
        Else
            Me.Label3.Text = "Registros Encontrados: " & Me.GridView1.Rows.Count
            Me.ImageButton10.Visible = True
            encontrado = "si"
        End If
        Me.TextBox1.Focus()

        If Session("idusuario") = "7" Or Session("idusuario") = "48" Or Session("idusuario") = "131" Or Session("idusuario") = "141" Then
            Me.GridView1.Columns(11).Visible = True
            'Me.GridView1.Columns(10).Visible = True
        Else
            Me.GridView1.Columns(11).Visible = False
            'Me.GridView1.Columns(10).Visible = False
        End If
        '
        'If encontrado = "si" Then
        '    Dim fila As GridViewRow
        '    Dim y As Integer
        '    For y = 0 To Me.GridView1.Rows.Count - 1
        '        fila = Me.GridView1.Rows(y)
        '        If fila.RowType = DataControlRowType.DataRow Then
        '            Dim imagen As ImageButton = CType(Me.GridView1.Rows(y).FindControl("ImageButton12"), ImageButton)
        '            imagen.Attributes.Add("onclick", "window.open('wfDetalleComisionesTS.aspx?id=" & Me.GridView1.Rows(y).Cells(1).Text & "',null,'height=450, width=800,status= no, resizable= no, scrollbars=si, toolbar=no,location=no,menubar=no ');")
        '        End If
        '    Next
        'End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            Me.ImageButton10.Visible = False
            Me.panelDatos.Visible = False
            Me.RadioButton1.Checked = True
        End If
        If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
            Response.Redirect("~/Default.aspx")
        End If
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.DropDownList1.DataSource = tabla
            Me.DropDownList1.DataTextField = "nombrePais"
            Me.DropDownList1.DataValueField = "codigopais"
            Me.DropDownList1.DataBind()
        End With
        Me.DropDownList1.Items.Insert(0, "Seleccione Pais")
    End Sub

    'Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
    '    panelDatos.Visible = False
    '    buscar()
    'End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        panelDatos.Visible = False
        ExportToExcel("Informe.xls", GridView1)
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView1.Columns(0).Visible = False
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

    'Sub mostrarDatosAcceso(ByVal codigo As String)
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    Me.Panel4.Visible = False
    '    If Session("idusuario") = "7" Or Session("idusuario") = "48" Or Session("idusuario") = "131" Or Session("idusuario") = "141" Then
    '        Me.Panel4.Visible = True
    '        sql = "select codigoafiliado,clave from afiliaciones where codigoafiliado='" & codigo & "'"
    '        With objOperacione
    '            tabla = .DevuelveDato(sql)
    '            If tabla.Rows.Count <> 0 Then
    '                Me.TextBox12.Text = tabla.Rows(0).Item("codigoAfiliado")
    '                Me.TextBox13.Text = tabla.Rows(0).Item("clave")
    '            End If
    '        End With
    '    End If
    'End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Dim codigoPatrocinador As String = ""
        Dim tabla As New DataTable
        '------------------------------------------------------------------------------------
        ' datos afiliado
        With afiliado
            .codigoAfiliado = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                codigoPatrocinador = tabla.Rows(0).Item("codigoPatrocinador")
                Me.TextBox2.Text = tabla.Rows(0).Item("codigoAfiliado")
                Me.TextBox5.Text = tabla.Rows(0).Item("identificacion")
                Me.TextBox3.Text = tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                Me.TextBox4.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre")
                Me.TextBox6.Text = tabla.Rows(0).Item("direccion")
                Me.TextBox7.Text = tabla.Rows(0).Item("telefono")
                Me.TextBox8.Text = tabla.Rows(0).Item("celular")
                Me.TextBox9.Text = tabla.Rows(0).Item("email1")
                'mostrarDatosAcceso(Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text)
            End If
        End With
        '------------------------------------------------------------------------------------
        ' datos patrocinador
        With afiliado
            .codigoAfiliado = codigoPatrocinador
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.TextBox10.Text = tabla.Rows(0).Item("codigoAfiliado")
                Me.TextBox11.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("papellido")
            Else
                Me.TextBox10.Text = ""
                Me.TextBox11.Text = ""
            End If
        End With
        '------------------------------------------------------------------------------------
        Dim ventana As AjaxControlToolkit.ModalPopupExtender = New AjaxControlToolkit.ModalPopupExtender
        ventana.ID = "popUp11"
        Me.panelDatos.Visible = True
        ventana.PopupControlID = "panelDatos"
        ventana.TargetControlID = "HiddenField1"
        ventana.DropShadow = True
        ventana.BackgroundCssClass = "ModalPopupBG"
        ventana.CancelControlID = "ImageButton11"
        Me.Panel2.Controls.Add(ventana)
        ventana.Show()
        '
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        panelDatos.Visible = False
        buscar()
    End Sub
End Class
