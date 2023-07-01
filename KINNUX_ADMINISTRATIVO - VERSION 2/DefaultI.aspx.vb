Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    'Dim afiliado As New ClsAfiliado
    'Dim usuario As New clsUsuario
    'Dim NOMBRE_ARCHIVO_VAR As String


    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If IsPostBack = False Then
    '        If Session("EntradaValida") = "si" Then
    '            mostrarInformacionUsuario()
    '        Else
    '            'limpiar()

    '        End If
    '    End If
    'End Sub

    'Sub mostrarInformacionUsuario()
    '    Dim tabla As New DataTable
    '    With usuario
    '        .idUsuario = Session("idUsuario")
    '        tabla = .obtenerUsuarioPorIdUsuario
    '        If tabla.Rows.Count <> 0 Then
    '            Me.Label3.Text = "Bienvenido(a): " & tabla.Rows(0).Item("nombrecompletoUsuario")
    '            Me.Label4.Text = "Perfil: " & tabla.Rows(0).Item("nombreGrupo")
    '        End If
    '    End With
    'End Sub

End Class
