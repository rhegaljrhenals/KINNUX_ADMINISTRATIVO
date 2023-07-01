Imports Microsoft.VisualBasic

Public Class clsTTDetalleKit

    Private _idItemDetalleKit As Integer
    Private _tipoDetalleKit As String
    Private _cantidadDetalleKit As Integer
    Dim objOperacione As New clsOperacione

    Public Property idItemDetalleKit As Integer
        Get
            Return _idItemDetalleKit
        End Get
        Set(ByVal value As Integer)
            _idItemDetalleKit = value
        End Set
    End Property

    Public Property tipoDetalleKit As String
        Get
            Return _tipoDetalleKit
        End Get
        Set(ByVal value As String)
            _tipoDetalleKit = value
        End Set
    End Property

    Public Property cantidadDetalleKit As Integer
        Get
            Return _cantidadDetalleKit
        End Get
        Set(ByVal value As Integer)
            _cantidadDetalleKit = value
        End Set
    End Property

    Sub grabarTTDetalleKit()
        Dim sql As String
        sql = "exec sp_actualizaTTDetalleKit " & _
        "@idItemDetalleKit='" & Me.idItemDetalleKit & "'," & _
        "@tipoDetalleKit='" & Me.tipoDetalleKit & "'," & _
        "@cantidadDetalleKit='" & Me.cantidadDetalleKit & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

End Class
