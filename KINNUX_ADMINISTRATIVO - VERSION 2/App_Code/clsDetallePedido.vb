Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsDetallePedido

    Private _idEncPedProductoBod As Integer
    Private _idDetPedProductoBod As Integer
    Private _idProducto As Integer
    Private _cantDetPedProductoBod As Double
    Private _cantEntregaDetPedProductoBod As Double
    Private _valorDetPedProductoBod As Double
    Private _subtotalDetPedProductoBod As Double
    Dim objOperacione As New clsOperacione

    Public Property idEncPedProductoBod As Integer
        Get
            Return _idEncPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncPedProductoBod = value
        End Set
    End Property

    Public Property idDetPedProductoBod As Integer
        Get
            Return _idDetPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idDetPedProductoBod = value
        End Set
    End Property

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property cantDetPedProductoBod As Double
        Get
            Return _cantDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _cantDetPedProductoBod = value
        End Set
    End Property

    Public Property cantEntregaDetPedProductoBod As Double
        Get
            Return _cantEntregaDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _cantEntregaDetPedProductoBod = value
        End Set
    End Property

    Public Property valorDetPedProductoBod As Double
        Get
            Return _valorDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _valorDetPedProductoBod = value
        End Set
    End Property

    Public Property subtotalDetPedProductoBod As Double
        Get
            Return _subtotalDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _subtotalDetPedProductoBod = value
        End Set
    End Property

    Sub grabarDetallepedido()
        Dim sql As String
        sql = "exec sp_actualizaTTDetPedProductoBod " & _
        "@idDetPedProductoBod='" & Me.idDetPedProductoBod & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantDetPedProductoBod='" & Me.cantDetPedProductoBod & "'," & _
        "@cantEntregaDetPedProductoBod='" & Me.cantEntregaDetPedProductoBod & "'," & _
        "@valorDetPedProductoBod='" & Me.valorDetPedProductoBod & "'," & _
        "@subtotalDetPedProductoBod='" & Me.subtotalDetPedProductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerDetallePedidoPorIdPedido() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTDetPedProductoBod.cantDetPedProductoBod," & _
        "TTDetPedProductoBod.valorDetPedProductoBod," & _
        "TTDetPedProductoBod.subtotalDetPedProductoBod," & _
        "TTDetPedProductoBod.cantEntregaDetPedProductoBod," & _
        "TTDetPedProductoBod.cantDetPedProductoBod - TTDetPedProductoBod.cantEntregaDetPedProductoBod as resta," & _
        "TTDetPedProductoBod.cantEntregaDetPedProductoBod," & _
        "0 as existencias" & _
        " FROM" & _
        " TTDetPedProductoBod INNER JOIN " & _
        " TBProducto ON " & _
        " TTDetPedProductoBod.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TTDetPedProductoBod.idEncPedProductoBod=" & Me.idEncPedProductoBod & " And" & _
        " (TTDetPedProductoBod.cantDetPedProductoBod - TTDetPedProductoBod.cantEntregaDetPedProductoBod) <> 0"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetallePedidoActualizaConfirmacion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTDetPedProductoBod where idEncPedProductoBod=" & Me.idEncPedProductoBod
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaTTDetPedProductoBodcantEntregaDetPedProductoBod()
        Dim sql As String
        sql = "exec sp_actualizaTTDetPedProductoBodcantEntregaDetPedProductoBod " & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantEntregaDetPedProductoBod='" & Me.cantEntregaDetPedProductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub


End Class
