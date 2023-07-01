Imports Microsoft.VisualBasic

Public Class clsTTLogAnulacionesRemisiones

    Private _idEncfacturaPro As Integer
    Private _idUsuario As Integer
    Dim objOperacione As New clsOperacione

    Public Property idEncfacturaPro As Integer
        Get
            Return _idEncfacturaPro
        End Get
        Set(value As Integer)
            _idEncfacturaPro = value
        End Set
    End Property

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Sub grabarTTLogAnulacionesRemisiones()
        Dim sql As String
        sql = "exec sp_actualizaTTLogAnulacionesRemisiones " & _
        "@idEncfacturaPro='" & Me.idEncfacturaPro & "'," & _
        "@idUsuario='" & Me.idUsuario & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

End Class
