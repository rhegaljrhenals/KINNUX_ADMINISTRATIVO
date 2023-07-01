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
        If Me.DropDownList2.SelectedIndex = 0 Then
            Me.Label7.Text = "Debe seleccionar el curso...!"
            Me.DropDownList2.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox6.Text = "" Then
            Me.Label7.Text = "Ingrese el nombre del examen...!"
            Me.TextBox6.Focus()
            Exit Sub
        Else
            Dim existeNombre As String = validaSiExisteNombreExamen
            If existeNombre = "si" Then
                Me.Label7.Text = "Este nombre de examen ya esta registrado en el sistema para este curso"
                Me.TextBox6.Focus()
                Exit Sub
            End If

        End If
        '
        If Me.TextBox3.Text = "" Then
            Me.TextBox3.Text = "0"
        End If
        '
        If Me.TextBox3.Text = "0" Then
            Me.Label7.Text = "Ingrese la hora del examen...!"
            Me.TextBox3.Focus()
            Exit Sub
        End If
        ''
        If Me.TextBox5.Text = "" Then
            Me.TextBox5.Text = "0"
        End If
        '
        If Me.TextBox5.Text = "0" Then
            Me.Label7.Text = "Ingrese el puntaje del examen...!"
            Me.TextBox5.Focus()
            Exit Sub
        End If
        '' configuracion hora y minuto
        Dim hora, minuto As String
        If Len(Me.TextBox3.Text) = 1 Then
            hora = "0" & Me.TextBox3.Text
        Else
            hora = Me.TextBox3.Text
        End If
        ''
        If Len(Me.TextBox4.Text) = 1 Then
            minuto = "0" & Me.TextBox4.Text
        Else
            minuto = Me.TextBox4.Text
        End If

        If Me.TextBox1.Text = "" Then
            id = 0
            accion = 1
        Else
            id = Me.TextBox1.Text
            accion = 2
        End If
        '' graba los datos del examen
        sql = "exec sp_TBExamen " & _
        "@idExamen='" & id & "'," & _
        "@idCurso='" & Me.DropDownList2.SelectedValue & "'," & _
        "@nombreExamen='" & Me.TextBox6.Text & "'," & _
        "@duracionExamen='" & hora & ":" & minuto & "'," & _
        "@pesoExamen='" & CDbl(Me.TextBox5.Text) & "'," & _
        "@estadoExamen='" & Me.DropDownList3.SelectedValue & "'," & _
        "@accion='" & accion & "'," & _
        "@numeroPreguntasExamen='" & Val(Me.TextBox7.Text) & "'"
        Dim idExamen As Integer = 0
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                idExamen = tabla.Rows(0).Item("numero")
            End If
        End With
        nuevo()
        mostrarVentana("Examen grabado en el sistema")
    End Sub

    Function validaSiExisteNombreExamen() As String
        Dim existe As String = "no"
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbexamen where idCurso=" & Me.DropDownList2.SelectedValue & " and nombreExamen='" & Me.TextBox6.Text.ToUpper & "' and estadoExamen=1"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                existe = "si"
            End If
        End With
        Return existe
    End Function

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            nuevo()
            cargarCursos()
        End If
    End Sub

    Sub cargarCursos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTCurso where estadoCurso=1 order by idCurso"
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList2.DataSource = tabla
                Me.DropDownList2.DataTextField = "nombreCurso"
                Me.DropDownList2.DataValueField = "idCurso"
                Me.DropDownList2.DataBind()
            Else
                Me.DropDownList2.DataSource = Nothing
                Me.DropDownList2.DataBind()
            End If
            Me.DropDownList2.Items.Insert(0, "Seleccione El Curso")
        End With
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.TBExamen.idExamen," & _
        "dbo.TBExamen.nombreExamen," & _
        "dbo.TBExamen.duracionExamen," & _
        "dbo.TBExamen.pesoExamen," & _
        "dbo.TTCurso.idCurso," & _
        "dbo.TTCurso.nombreCurso," & _
        "dbo.TBExamen.numeroPreguntasExamen" & _
        " FROM" & _
        " dbo.TBExamen INNER JOIN" & _
        " dbo.TTCurso ON dbo.TBExamen.idCurso = dbo.TTCurso.idCurso"
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

    Sub nuevo()
        mostrarDatos()
        Me.TextBox1.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = "0"
        Me.TextBox5.Text = "0"
        Me.HyperLink1.Visible = False
        Me.TextBox6.Focus()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox6.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        mustraDatosPorIdExamen(Me.TextBox1.Text)
    End Sub

    Sub mustraDatosPorIdExamen(ByVal idExamen As Integer)
        Me.HyperLink1.Visible = False
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBExamen where idExamen=" & idExamen
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.HyperLink1.Visible = True
                Me.HyperLink1.NavigateUrl = "~/herramientas/wfPreguntasCertificaciones.aspx?indice=5&idExamen=" & tabla.Rows(0).Item("idexamen") & "&idcurso=" & tabla.Rows(0).Item("idCurso")
                Me.TextBox3.Text = Left(tabla.Rows(0).Item("duracionExamen"), 2)
                Me.TextBox4.Text = Right(tabla.Rows(0).Item("duracionExamen"), 2)
                Me.TextBox5.Text = tabla.Rows(0).Item("pesoExamen")
                If tabla.Rows(0).Item("estadoExamen") = "1" Then
                    Me.DropDownList3.SelectedIndex = 0
                Else
                    Me.DropDownList3.SelectedIndex = 1
                End If
                Me.DropDownList2.SelectedValue = tabla.Rows(0).Item("idCurso")
            End If
        End With
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        nuevo()
    End Sub

End Class
