Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Dim usuario As New clsTBUsuarios
    ' clsUsuario

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Label1.Text = ""
        validar()
    End Sub

    Sub validar()
        'Dim claveEncriptada As String
        Dim tablaUsuario As New DataTable
        Dim ds As DataSet = New DataSet
        With usuario
            .nombreUsuario = Me.TextBox1.Text
            'claveEncriptada = .encriptarClave(Me.TextBox2.Text)
            .claveUsuario = Me.TextBox2.Text 'claveEncriptada
            tablaUsuario = .validaUsuario
            If tablaUsuario.Rows.Count = 0 Then
                Me.Label1.Text = "* Usuario No Existe, o se encuentra eliminado...!"
                Session("EntradaValida") = "no"
                Exit Sub
            End If
            '------------------------------------------------------------------
            'Session("nombreusuario") = Me.TextBox1.Text
            ''Session("codigoGrupo") = tablaUsuario.Rows(0).Item("codigoGrupo")
            'Session("idUsuario") = tablaUsuario.Rows(0).Item("idUsuario")
            'Session("nombreCompletoUsuario") = tablaUsuario.Rows(0).Item("nombreCompletoUsuario")

            Session("EntradaValida") = "si"
            'Session.Timeout = 120
            Response.Redirect("~/DefaultI.aspx?iu=" & tablaUsuario.Rows(0).Item("idUsuario"))
            '------------------------------------------------------------------
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.Label2.Text = "Derechos Reservados KINNUX S.A.S - " & Now.Year
            Me.TextBox1.Focus()
        End If
    End Sub

End Class
