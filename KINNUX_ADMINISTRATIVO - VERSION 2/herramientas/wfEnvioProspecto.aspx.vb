Imports System.IO
Imports System.Data

Partial Class Reportes_Varios_wfConsultaDistribuidor
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise
    Dim afiliado As New ClsAfiliado

    Sub buscar()
        Me.Panel3.Visible = True
        Dim opcion As Integer
        Dim tabla As New DataTable
        Me.ImageButton10.Visible = False
        '
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton3.Checked = True Then
                opcion = 2
            Else
                If Me.RadioButton4.Checked = True Then
                    opcion = 3
                Else
                    If Me.RadioButton5.Checked = True Then
                        opcion = 4
                    Else
                        If Me.RadioButton6.Checked = True Then
                            opcion = 5
                        Else
                            If Me.RadioButton7.Checked = True Then
                                opcion = 6
                            End If
                        End If

                    End If
                End If
            End If
        End If
        cargarProspecto(opcion)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.ImageButton10.Visible = False
            Me.RadioButton1.Checked = True
            Me.Panel3.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    'Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
    '    ExportToExcel("Informe.xls", GridView1)
    'End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView3.Columns(0).Visible = False
        Me.GridView3.Columns(1).Visible = False
        Me.GridView3.Columns(2).Visible = False
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

    Sub cargarWord(ByVal destinatario As String, ByVal direccion As String, ByVal ciudad As String, ByVal nombreAfiliado As String, ByVal telefonoAfiliado As String, ByVal emailAfiliado As String, ByVal id As String, ByVal barrio As String)
        ' fecha actual
        Dim fecha As String
        Dim mes As String = ""
        Select Case Month(Now.Date)
            Case Is = 1
                mes = "Enero"
            Case Is = 2
                mes = "Febrero"
            Case Is = 3
                mes = "Marzo"
            Case Is = 4
                mes = "Abril"
            Case Is = 5
                mes = "Mayo"
            Case Is = 6
                mes = "Junio"
            Case Is = 7
                mes = "Julio"
            Case Is = 8
                mes = "Agosto"
            Case Is = 9
                mes = "Septiembre"
            Case Is = 10
                mes = "Octubre"
            Case Is = 11
                mes = "Noviembre"
            Case Is = 12
                mes = "Diciembre"
        End Select
        fecha = "Bogot&aacute D.C., " & mes & " " & "De " & Year(Now.Date)
        '
        Dim strBody As String = "<html>" +
        "<body>" +
        "<br><br><br><br>" +
        "<b><FONT FACE=arial size=2>" & fecha & "</FONT></b><br>" +
        "<b><FONT FACE=arial size=2>" & "Señor(a): " & destinatario & "</FONT></b><br>" +
        "<b><FONT FACE=arial size=2>" & "Direccion: " & direccion & "</FONT></b><br>" +
        "<b><FONT FACE=arial size=2>" & "Ciudad: " & ciudad & "</FONT></b><br>" +
        "<b><FONT FACE=arial size=2>" & "Barrio: " & barrio & "</FONT></b><br>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & "Reciba un cordial saludo de la compañía KINNUX CORP, deseamos que su salud y bienestar sean óptimos al momento de recibir nuestra correspondencia." & "</FONT></b>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "¿Sabía que más del 90% de las enfermedades tienen un mismo origen y es un pobre o deficiente funcionamiento del COLON o intestino grueso? ESTO HA LLEVADO A UN GRAN GRUPO DE PERSONAS a sufrir múltiples síntomas y desordenes en su organismo, deseamos que no sea su caso, y de ser así, lo invitamos a responder el cuestionario que viene adjunto en la parte dorsal del periódico, que se incluye en este sobre, junto con un video DVD del Dr. Joel Robbins, pues él nos explica la razón del origen de las  principales enfermedades que padecemos." & _
        "</FONT>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "Quizás usted o alguien de su entorno familiar, inclusive amigos o conocidos, actualmente estén sintiendo molestos síntomas o padeciendo de una o varias de las siguientes enfermedades." & _
        "</FONT></b>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "El agotamiento o debilidad, la falta de fuerza, el deseo constante de descansar o dormir, la diabetes, el cáncer, las alergias, problemas circulatorios, óseos, digestivos, son consecuencia de la perdida de energía a nivel celular, también la extra-acides del cuerpo generada desde el estómago provoca las enfermedades." & _
        "</FONT>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "La buena salud es un derecho que todos tenemos, por favor lea y escuche toda la información que le hemos enviado, le aportará un nuevo punto de vista para lograr una vida larga y sana. Antes de despedirnos, piense un momento quien de su familia se encuentra  enfermo en este momento, no olvide hacer la encuesta del periódico" & _
        "</FONT>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "Si el contenido de este sobre le llamo la atención, no dude en comunicarse con nosotros a estos teléfonos 3170090 - 4926222 en la ciudad de Bogotá o los celulares 3205680126 - 3212135192." & _
        "</FONT>" +
        "<br><br>" +
        "<FONT FACE=arial size=2>" & _
        "Cordialmente," & _
        "</FONT>" +
        "<br><br><br><br>" +
        "<FONT FACE=arial size=2>" & _
        nombreAfiliado & _
        "</FONT>" +
        "<br>" +
        "<FONT FACE=arial size=2>" & _
        "Distribuidor Independiente." & _
        "</FONT>" +
        "<br>" +
        "<FONT FACE=arial size=2>" & _
        "Kinnux Corp." & _
        "</FONT>" +
        "<br>" +
        "<FONT FACE=arial size=2>" & _
        "Tel: " & telefonoAfiliado & _
        "</FONT>" +
        "<br>" +
        "<FONT FACE=arial size=2>" & _
        "Email: " & emailAfiliado & _
        "</FONT>" +
        "<br>" +
        "</body>" +
        "</html>"
        Dim fileName As String = "Carta-" & id & ".doc"
        '
        Response.AppendHeader("Content-Type", "application/msword")
        Response.AppendHeader("Content-disposition", "attachment; filename=" + fileName)
        Response.Write(strBody)
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

    'Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
    '    Dim codigoPatrocinador As String = ""
    '    Dim tabla As New DataTable
    '    '------------------------------------------------------------------------------------
    '    ' datos afiliado
    '    With afiliado
    '        .codigoAfiliado = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
    '        tabla = .obtenerAfiliadoPorCodigoAfiliado
    '        If tabla.Rows.Count <> 0 Then
    '            codigoPatrocinador = tabla.Rows(0).Item("codigoPatrocinador")
    '            Me.TextBox2.Text = tabla.Rows(0).Item("codigoAfiliado")
    '            Me.TextBox5.Text = tabla.Rows(0).Item("identificacion")
    '            Me.TextBox3.Text = tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
    '            Me.TextBox4.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre")
    '            Me.TextBox6.Text = tabla.Rows(0).Item("direccion")
    '            Me.TextBox7.Text = tabla.Rows(0).Item("telefono")
    '            Me.TextBox8.Text = tabla.Rows(0).Item("celular")
    '            Me.TextBox9.Text = tabla.Rows(0).Item("email1")
    '            'mostrarDatosAcceso(Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text)
    '        End If
    '    End With
    '    '------------------------------------------------------------------------------------
    '    ' datos patrocinador
    '    With afiliado
    '        .codigoAfiliado = codigoPatrocinador
    '        tabla = .obtenerAfiliadoPorCodigoAfiliado
    '        If tabla.Rows.Count <> 0 Then
    '            Me.TextBox10.Text = tabla.Rows(0).Item("codigoAfiliado")
    '            Me.TextBox11.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("papellido")
    '        Else
    '            Me.TextBox10.Text = ""
    '            Me.TextBox11.Text = ""
    '        End If
    '    End With
    '    ''------------------------------------------------------------------------------------
    '    'Dim ventana As AjaxControlToolkit.ModalPopupExtender = New AjaxControlToolkit.ModalPopupExtender
    '    'ventana.ID = "popUp11"
    '    'Me.panelDatos.Visible = True
    '    'ventana.PopupControlID = "panelDatos"
    '    'ventana.TargetControlID = "HiddenField1"
    '    'ventana.DropShadow = True
    '    'ventana.BackgroundCssClass = "ModalPopupBG"
    '    'ventana.CancelControlID = "ImageButton11"
    '    'Me.Panel2.Controls.Add(ventana)
    '    'ventana.Show()
    '    '
    'End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub

    Sub cargarProspecto(ByVal opcion As Integer)
        Me.ImageButton10.Visible = False
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as afiliado," & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.Afiliaciones.celular," & _
        "dbo.Afiliaciones.email1," & _
        "dbo.TbProspecto.idProspecto," & _
        "dbo.TbProspecto.nombres + ' ' + dbo.TbProspecto.apellidos as nombres, " & _
        "dbo.TbProspecto.direccion," & _
        "dbo.TbProspecto.ciudad," & _
        "dbo.TbProspecto.barrio," & _
        "dbo.TbProspecto.telefono as tp," & _
        "dbo.TbProspecto.movil," & _
        "dbo.TbProspecto.email," & _
        "case dbo.TbProspecto.estado" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Eliminado'" & _
        " end estado," & _
        "dbo.TbProspecto.enviado" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " dbo.TbProspecto ON dbo.Afiliaciones.codigoAfiliado = dbo.TbProspecto.codigoAfiliado"
        Select Case opcion
            Case Is = 1
                sql = sql & " where dbo.Afiliaciones.codigoAfiliado='" & Me.TextBox1.Text & "' and dbo.TbProspecto.estado=1"
            Case Is = 2
                sql = sql & " where dbo.TbProspecto.enviado='s' and dbo.TbProspecto.estado=1"
            Case Is = 3
                sql = sql & " where dbo.TbProspecto.estado=1 or dbo.TbProspecto.estado=0"
            Case Is = 4
                sql = sql & " where dbo.TbProspecto.enviado='n' and dbo.TbProspecto.estado=1"
            Case Is = 5
                sql = sql & " where dbo.TbProspecto.estado=1"
            Case Is = 6
                sql = sql & " where dbo.TbProspecto.estado=0"
        End Select
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.ImageButton10.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
                Me.Label3.Text = Me.GridView3.Rows.Count & " Registros encontrados...!"
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
                Me.Label3.Text = "No se han encontrado registros...!"
            End If
        End With
    End Sub

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        Dim sql As String
        Dim fila As GridViewRow
        Dim y As Integer
        If Me.GridView3.Rows.Count <> 0 Then
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    If c1.Checked = True Then
                        sql = "update tbprospecto set enviado='s',fechaEnvio='" & Now.Date.ToString("yyyy/MM/dd") & "' where idProspecto=" & Me.GridView3.Rows(y).Cells(2).Text
                        With objOperacione
                            .Accion(sql)
                        End With
                    End If
                End If
            Next
            mostrarVentana()
            cargarProspecto(3)
        End If
        
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Envios Actualizados En El Sistema...!');", True)
    End Sub

    
    Protected Sub ImageButton10_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        ExportToExcel("prospecto.xls", Me.GridView3)
    End Sub

    Protected Sub GridView3_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView3.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Display the company name in italics.
            'e.Row.Cells(1).Text = "<i>" & e.Row.Cells(1).Text & "</i>"
            If e.Row.Cells(15).Text = "s" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

   
    'Protected Sub Button6_Click(sender As Object, e As System.EventArgs) Handles Button6.Click
    '    cargarWord()
    'End Sub

    'Protected Sub GridView3_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView3.RowCommand
    'Dim currentCommand As String = e.CommandName
    'Dim currentRowIndex As Integer = Int32.Parse(e.CommandArgument.ToString())
    'Dim ProductID As String = GridView3.DataKeys(currentRowIndex).Value

    'Label4.Text = "Command: " & currentCommand
    'Label5.Text = "Row Index: " & currentRowIndex.ToString
    'Label6.Text = "Product ID: " & ProductID
    'If e.CommandName = "Select" Then
    '    '
    '    ' Se obtiene indice de la row seleccionada
    '    '
    '    Dim index As Integer = Convert.ToInt32(e.CommandArgument)

    '    '
    '    ' Obtengo el id de la entidad que se esta editando
    '    ' en este caso de la entidad Person
    '    '

    '    Dim id As Integer = Convert.ToInt32(Me.GridView3.DataKeys(index).Value)
    'End If
    'End Sub


    'Protected Sub GridView3_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView3.RowDataBound
    '    If e.Row.RowType = DataControlRowType.DataRow Then
    '        ' Display the company name in italics.
    '        'e.Row.Cells(1).Text = "<i>" & e.Row.Cells(1).Text & "</i>"
    '        cargarWord(e.Row.Cells(7).Text)
    '    End If
    'End Sub

    Protected Sub GridView3_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        cargarWord(Me.GridView3.Rows(e.NewSelectedIndex).Cells(7).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(8).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(9).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(3).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(4).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(6).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(2).Text, Me.GridView3.Rows(e.NewSelectedIndex).Cells(10).Text)
    End Sub
End Class
