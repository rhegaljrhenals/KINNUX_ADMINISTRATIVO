Imports System.Data
Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic
Imports System.Net.Mime
Imports System.IO

Partial Class Reportes_Varios_wfEstadisticasFacturacion
    Inherits System.Web.UI.Page

    Dim resumenFacturacion As New clsResumenFacturacionPaquetes
    Dim operaciones As New clsOperacione
    Dim mail As New MailMessage
    Dim servidorSMTP As New SmtpClient


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim sql As String
        Dim tabla As New DataTable
        Dim id, accion As Integer
        Me.Label7.Text = ""
        If Me.TextBox5.Text = "" Then
            Me.TextBox5.Text = "0"
        End If
        ''
        If Me.TextBox5.Text = "0" Then
            Me.Label7.Text = "Ingrese el puntaje de la pregunta de la pregunta...!"
            Me.TextBox5.Focus()
            Exit Sub
        End If
        ''
        Select Case DropDownList5.SelectedIndex
            Case Is = 0
                Me.Label7.Text = "Debe seleccionar el tipo de pregunta...!"
                Me.DropDownList5.Focus()
                Exit Sub
            Case Is = 1
                If Me.TextBox6.Text = "" Then
                    Me.Label7.Text = "Ingrese el enunciado...!"
                    Me.TextBox6.Focus()
                    Exit Sub
                End If
                '
                If Me.TextBox7.Text = "" Or Me.TextBox8.Text = "" Or Me.TextBox9.Text = "" Or Me.TextBox10.Text = "" Then
                    Me.Label7.Text = "Debe ingresar todas las opciones de esta pregunta...!"
                    Me.TextBox6.Focus()
                    Exit Sub
                End If
                ''
                If Me.RadioButton1.Checked = False And Me.RadioButton2.Checked = False And Me.RadioButton3.Checked = False And Me.RadioButton4.Checked = False Then
                    Me.Label7.Text = "Debe seleccionar la respuesta correcta...!"
                    Me.RadioButton1.Focus()
                    Exit Sub
                End If
            Case Is = 2
                If Me.TextBox6.Text = "" Then
                    Me.Label7.Text = "Ingrese el enunciado...!"
                    Me.TextBox6.Focus()
                    Exit Sub
                End If
                '
                If Me.TextBox7.Text = "" Or Me.TextBox8.Text = "" Or Me.TextBox9.Text = "" Or Me.TextBox10.Text = "" Then
                    Me.Label7.Text = "Debe ingresar todas las opciones de esta pregunta...!"
                    Me.TextBox6.Focus()
                    Exit Sub
                End If
                ''
                If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False Then
                    Me.Label7.Text = "Debe seleccionar las opciones correctas...!"
                    Me.CheckBox1.Focus()
                    Exit Sub
                End If
            Case Is = 3
                If Me.TextBox6.Text = "" Then
                    Me.Label7.Text = "Ingrese el enunciado...!"
                    Me.TextBox6.Focus()
                    Exit Sub
                End If
                '
                If Me.RadioButton5.Checked = False And Me.RadioButton6.Checked = False Then
                    Me.Label7.Text = "Debe seleccionar la opcion correcta...!"
                    Me.RadioButton5.Focus()
                    Exit Sub
                End If
        End Select
        ''
        If CDbl(Me.TextBox16.Text) >= CDbl(Me.TextBox15.Text) Then
            Me.Label7.Text = "Ya se ha completado el numero de preguntas para este examen...!"
            Me.ImageButton1.Focus()
            Exit Sub
        End If
        ''
        If Me.TextBox1.Text = "" Then
            id = 0
            accion = 1
        Else
            id = Me.TextBox1.Text
            accion = 2
        End If
        ''
        Dim idPregunta As Integer = 0
        '' encabezado pregunta
        sql = "exec sp_TTPregunta " & _
        "@idPregunta='" & id & "'," & _
        "@idExamen='" & Me.TextBox11.Text & "'," & _
        "@idCurso='" & Me.TextBox13.Text & "'," & _
        "@idTipoPregunta='" & Me.DropDownList5.SelectedValue & "'," & _
        "@enunciadoPregunta='" & Me.TextBox6.Text & "'," & _
        "@pesoPregunta='" & Me.TextBox5.Text & "'," & _
        "@estadoPregunta='" & Me.DropDownList3.SelectedValue & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                idPregunta = tabla.Rows(0).Item("numero")
            End If
        End With
        '' opciones
        '' detalle pregunta (Opciones)
        Select Case Me.DropDownList5.SelectedIndex
            Case Is = 1 '' tipo de pregunta unica seleccion
                '' opcion correcta
                '' opcion 1
                Dim opcionCorrecta1 As String = "n"
                If Me.RadioButton1.Checked = True Then
                    opcionCorrecta1 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox7.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta1 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 2
                Dim opcionCorrecta2 As String = "n"
                If Me.RadioButton2.Checked = True Then
                    opcionCorrecta2 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox8.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta2 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 3
                Dim opcionCorrecta3 As String = "n"
                If Me.RadioButton3.Checked = True Then
                    opcionCorrecta3 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox9.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta3 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 4
                Dim opcionCorrecta4 As String = "n"
                If Me.RadioButton4.Checked = True Then
                    opcionCorrecta4 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox10.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta4 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
            Case Is = 2 '' tipo de pregunta opciones multiples
                '' opcion correcta
                '' opcion 1
                Dim opcionCorrecta1 As String = "n"
                If Me.CheckBox1.Checked = True Then
                    opcionCorrecta1 = "s"
                Else
                    opcionCorrecta1 = "n"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox7.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta1 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 2
                Dim opcionCorrecta2 As String = "n"
                If Me.CheckBox2.Checked = True Then
                    opcionCorrecta2 = "s"
                Else
                    opcionCorrecta2 = "n"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox8.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta2 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 3
                Dim opcionCorrecta3 As String = "n"
                If Me.CheckBox3.Checked = True Then
                    opcionCorrecta3 = "s"
                Else
                    opcionCorrecta3 = "n"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox9.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta3 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 4
                Dim opcionCorrecta4 As String = "n"
                If Me.CheckBox4.Checked = True Then
                    opcionCorrecta4 = "s"
                Else
                    opcionCorrecta4 = "n"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & Me.TextBox10.Text & "'," & _
                "@correctaOpcion='" & opcionCorrecta4 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
            Case Is = 3 '' tipo de respuesta falso y verdadero
                '' opcion correcta
                '' opcion 1
                Dim opcionCorrecta1 As String = "n"
                If Me.RadioButton5.Checked = True Then
                    opcionCorrecta1 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & "Verdadero" & "'," & _
                "@correctaOpcion='" & opcionCorrecta1 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
                '' opcion 2
                Dim opcionCorrecta2 As String = "n"
                If Me.RadioButton6.Checked = True Then
                    opcionCorrecta2 = "s"
                End If
                ''
                sql = "exec sp_TTOpcion " & _
                "@idOpcion='" & "0" & "'," & _
                "@idPregunta='" & idPregunta & "'," & _
                "@enunciadoOpcion='" & "Falso" & "'," & _
                "@correctaOpcion='" & opcionCorrecta2 & "'," & _
                "@estadoOpcion='" & "1" & "'"
                With operaciones
                    .Accion(sql)
                End With
        End Select
        '            
        nuevo()
        mostrarVentana("Pregunta Grabada En El Sistema")
    End Sub

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
            cargarExamenes()
            cargarTiposDePreguntas()
            Me.RadioButton1.Checked = True
        End If
    End Sub

    Sub cargarTiposDePreguntas()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from Tbtipopregunta where estadoTipoPregunta=1 order by idtipoPregunta"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList5.DataSource = tabla
                Me.DropDownList5.DataTextField = "nombreTipoPregunta"
                Me.DropDownList5.DataValueField = "idtipoPregunta"
                Me.DropDownList5.DataBind()
            Else
                Me.DropDownList5.DataSource = Nothing
                Me.DropDownList5.DataBind()
            End If
            Me.DropDownList5.Items.Insert(0, "Seleccione El Tipo De Pregunta")
        End With
    End Sub

    Sub cargarExamenes()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "dbo.TBExamen.idExamen," & _
        "dbo.TBExamen.nombreExamen," & _
        "dbo.TBExamen.numeroPreguntasExamen," & _
        "dbo.TTCurso.idCurso," & _
        "dbo.TTCurso.nombreCurso" & _
        " FROM" & _
        " dbo.TBExamen INNER JOIN" & _
        " dbo.TTCurso ON dbo.TBExamen.idCurso = dbo.TTCurso.idCurso" & _
        " where dbo.TBExamen.idExamen=" & Request.QueryString("idexamen")
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox11.Text = tabla.Rows(0).Item("idExamen")
                Me.TextBox12.Text = tabla.Rows(0).Item("nombreExamen")
                Me.TextBox13.Text = tabla.Rows(0).Item("idCurso")
                Me.TextBox14.Text = tabla.Rows(0).Item("nombreCurso")
                Me.TextBox15.Text = tabla.Rows(0).Item("numeroPreguntasExamen")
            Else
                Me.TextBox11.Text = "0"
                Me.TextBox12.Text = ""
                Me.TextBox13.Text = "0"
                Me.TextBox14.Text = ""
            End If
        End With
    End Sub

    Sub nuevo()
        'mostrarDatos()
        Me.TextBox1.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.TextBox10.Text = ""
        ''
        Me.TextBox5.Text = "0"
        Me.TextBox6.Focus()
        ''-------------------------------------------------------------
        Me.RadioButton1.Visible = False
        Me.RadioButton2.Visible = False
        Me.RadioButton3.Visible = False
        Me.RadioButton4.Visible = False
        ''
        Me.RadioButton5.Visible = False
        Me.RadioButton6.Visible = False
        ''
        Me.CheckBox1.Visible = False
        Me.CheckBox2.Visible = False
        Me.CheckBox3.Visible = False
        Me.CheckBox4.Visible = False
        ''
        Me.Label13.Visible = False
        Me.Label14.Visible = False
        Me.Label19.Visible = False
        ''
        Me.Label15.Visible = False
        Me.Label16.Visible = False
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        ''
        ''
        Me.TextBox6.Visible = False
        Me.TextBox7.Visible = False
        Me.TextBox8.Visible = False
        Me.TextBox9.Visible = False
        Me.TextBox10.Visible = False
        ''-------------------------------------------------------------
        muestraPreguntasRegistradas()
    End Sub

    Sub muestraPreguntasRegistradas()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select count(*) as numero from TTPregunta where idExamen=" & Request.QueryString("idExamen") & " and idCurso=" & Request.QueryString("idCurso") & " and estadoPregunta=1"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox16.Text = tabla.Rows(0).Item("numero")
            Else
                Me.TextBox16.Text = "0"
            End If
        End With
    End Sub
    
    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        nuevo()
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList5.SelectedIndexChanged
        Me.RadioButton1.Visible = False
        Me.RadioButton2.Visible = False
        Me.RadioButton3.Visible = False
        Me.RadioButton4.Visible = False
        ''
        Me.RadioButton5.Visible = False
        Me.RadioButton6.Visible = False
        ''
        Me.CheckBox1.Visible = False
        Me.CheckBox2.Visible = False
        Me.CheckBox3.Visible = False
        Me.CheckBox4.Visible = False
        ''
        Me.Label14.Visible = False
        Me.Label19.Visible = False
        ''
        Me.Label15.Visible = False
        Me.Label16.Visible = False
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        ''
        Me.Label13.Visible = False
        ''
        Me.TextBox6.Visible = False
        Me.TextBox7.Visible = False
        Me.TextBox8.Visible = False
        Me.TextBox9.Visible = False
        Me.TextBox10.Visible = False
        If Me.DropDownList5.SelectedIndex = 0 Or Me.DropDownList5.SelectedIndex = -1 Then

        Else
            Select Case Me.DropDownList5.SelectedValue
                Case Is = 1
                    Me.RadioButton1.Visible = True
                    Me.RadioButton2.Visible = True
                    Me.RadioButton3.Visible = True
                    Me.RadioButton4.Visible = True
                    ''
                    Me.Label15.Visible = True
                    Me.Label16.Visible = True
                    Me.Label17.Visible = True
                    Me.Label18.Visible = True
                    ''
                    Me.Label13.Visible = True
                    Me.Label14.Visible = True
                    Me.Label19.Visible = True
                    ''
                    Me.TextBox6.Visible = True
                    Me.TextBox7.Visible = True
                    Me.TextBox8.Visible = True
                    Me.TextBox9.Visible = True
                    Me.TextBox10.Visible = True
                Case Is = 2
                    Me.CheckBox1.Visible = True
                    Me.CheckBox2.Visible = True
                    Me.CheckBox3.Visible = True
                    Me.CheckBox4.Visible = True
                    ''
                    Me.Label15.Visible = True
                    Me.Label16.Visible = True
                    Me.Label17.Visible = True
                    Me.Label18.Visible = True
                    ''
                    Me.Label13.Visible = True
                    Me.Label14.Visible = True
                    Me.Label19.Visible = True
                    ''
                    Me.TextBox6.Visible = True
                    Me.TextBox7.Visible = True
                    Me.TextBox8.Visible = True
                    Me.TextBox9.Visible = True
                    Me.TextBox10.Visible = True
                Case Is = 3
                    Me.RadioButton5.Visible = True
                    Me.RadioButton6.Visible = True
                    ''
                    Me.Label13.Visible = True
                    ''
                    Me.TextBox6.Visible = True
            End Select
        End If
    End Sub
End Class
