Imports System.Data

Partial Class Seguridad_wfIngreso
    Inherits System.Web.UI.Page

    Dim usuario As New clsTBUsuarios
    ' clsUsuario

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Label1.Text = ""
        validar()
    End Sub

    Sub validar()
        Dim claveEncriptada As String
        Dim tablaUsuario As New DataTable
        Dim ds As DataSet = New DataSet
        With usuario
            .nombreUsuario = Me.TextBox1.Text
            claveEncriptada = .encriptarClave(Me.TextBox2.Text)
            .claveUsuario = claveEncriptada
            tablaUsuario = .validaUsuario
            If tablaUsuario.Rows.Count = 0 Then
                Me.Label1.Text = "* Usuario No Existe, o se encuentra eliminado...!"
                Session("EntradaValida") = "no"
                Exit Sub
            End If
            '------------------------------------------------------------------
            Session("nombreusuario") = Me.TextBox1.Text
            'Session("codigoGrupo") = tablaUsuario.Rows(0).Item("codigoGrupo")
            Session("idUsuario") = tablaUsuario.Rows(0).Item("idUsuario")
            Session("nombreCompletoUsuario") = tablaUsuario.Rows(0).Item("nombreCompletoUsuario")

            Session("EntradaValida") = "si"
            Session.Timeout = 120
            Response.Redirect("~/Default.aspx")
            '------------------------------------------------------------------
        End With
    End Sub

    Protected Sub LinkButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton3.Click
        Response.Redirect("~/Seguridad/wfRecuperarContraseña.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.TextBox1.Focus()
        End If
    End Sub
End Class
