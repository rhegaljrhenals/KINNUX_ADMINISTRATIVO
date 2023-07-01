Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsGrupoUsuario

    Private _codigoGrupo As Integer
    Private _nombreGrupo As String
    Dim objOperacione As New clsOperacione
    
    Public Property codigoGrupo As Integer
        Get
            Return _codigoGrupo
        End Get
        Set(ByVal value As Integer)
            _codigoGrupo = value
        End Set
    End Property

    Public Property nombreGrupo As String
        Get
            Return _nombreGrupo
        End Get
        Set(ByVal value As String)
            _nombreGrupo = value
        End Set
    End Property

    Sub grabarUsuario(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_grabarGrupoUsuario " & _
            "@nombreGrupo='" & Me.nombreGrupo & "'," & _
            "@codigoGrupo='" & Me.codigoGrupo & "'," & _
            "@accion='" & accion & "'"
        With objOperacione
            .accion(sql)
        End With
    End Sub
End Class
