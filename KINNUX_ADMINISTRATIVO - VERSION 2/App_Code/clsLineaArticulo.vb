Imports Microsoft.VisualBasic

Public Class clsLineaArticulo

    Private _idLinea As Integer
    Private _nombreLinea As String
    Private _estado As Integer
    Dim objOperacione As New clsOperacione

    Public Property idLinea As Integer
        Get
            Return _idLinea
        End Get
        Set(ByVal value As Integer)
            _idLinea = value
        End Set
    End Property

    Public Property nombreLinea As String
        Get
            Return _nombreLinea
        End Get
        Set(ByVal value As String)
            _nombreLinea = value
        End Set
    End Property

    Public Property estado As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

    Sub grabarLinea(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaLineArticulo " & _
        "@idLinea='" & Me.idLinea & "'," & _
        "@nombrelinea='" & Me.nombreLinea & "'," & _
        "@estado='" & Me.estado & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

End Class
