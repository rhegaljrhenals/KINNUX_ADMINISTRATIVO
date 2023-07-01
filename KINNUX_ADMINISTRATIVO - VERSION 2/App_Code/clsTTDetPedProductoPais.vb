Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetPedProductoPais

    Private _idDetPedProductoPais As Integer
    Private _idEncPedProductoPais As Integer
    Private _idProducto As Integer
    Private _cantDetPedProductoPais As Integer
    Private _canEntregDetPedProductoPais As Integer
    Private _valorDetPedProductoPais As Double
    Private _subtotalDetPedProductoPais As Double
    Dim objOperacione As New clsOperacione

    Public Property idDetPedProductoPais As Integer
        Get
            Return _idDetPedProductoPais
        End Get
        Set(ByVal value As Integer)
            _idDetPedProductoPais = value
        End Set
    End Property

    Public Property idEncPedProductoPais As Integer
        Get
            Return _idEncPedProductoPais
        End Get
        Set(ByVal value As Integer)
            _idEncPedProductoPais = value
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

    Public Property cantDetPedProductoPais As Integer
        Get
            Return _cantDetPedProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantDetPedProductoPais = value
        End Set
    End Property

    Public Property canEntregDetPedProductoPais As Integer
        Get
            Return _canEntregDetPedProductoPais
        End Get
        Set(ByVal value As Integer)
            _canEntregDetPedProductoPais = value
        End Set
    End Property

    Public Property valorDetPedProductoPais As Double
        Get
            Return _valorDetPedProductoPais
        End Get
        Set(ByVal value As Double)
            _valorDetPedProductoPais = value
        End Set
    End Property

    Public Property subtotalDetPedProductoPais As Double
        Get
            Return _subtotalDetPedProductoPais
        End Get
        Set(ByVal value As Double)
            _subtotalDetPedProductoPais = value
        End Set
    End Property

    Function obtenerDetallePedidoPuntoPorId() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTDetPedProductoPais.idDetPedProductoPais," & _
        "TTDetPedProductoPais.idEncPedProductoPais," & _
        "TTDetPedProductoPais.cantDetPedProductoPais," & _
        "TTDetPedProductoPais.canEntregDetPedProductoPais," & _
        "TTDetPedProductoPais.valorDetPedProductoPais," & _
        "TTDetPedProductoPais.subtotalDetPedProductoPais," & _
        "(TTDetPedProductoPais.cantDetPedProductoPais - TTDetPedProductoPais.canEntregDetPedProductoPais) as faltantes," & _
        "0 as existencias" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TTDetPedProductoPais ON TBProducto.idProducto = TTDetPedProductoPais.idProducto" & _
        " where TTDetPedProductoPais.idEncPedProductoPais=" & Me.idEncPedProductoPais & " and" & _
        " TTDetPedProductoPais.cantDetPedProductoPais - TTDetPedProductoPais.canEntregDetPedProductoPais<>0"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetallePedidoPaisPorId() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTDetPedProductoPais.idDetPedProductoPais," & _
        "TTDetPedProductoPais.idEncPedProductoPais," & _
        "TTDetPedProductoPais.cantDetPedProductoPais," & _
        "TTDetPedProductoPais.canEntregDetPedProductoPais," & _
        "TTDetPedProductoPais.valorDetPedProductoPais," & _
        "TTDetPedProductoPais.subtotalDetPedProductoPais," & _
        "(TTDetPedProductoPais.cantDetPedProductoPais - TTDetPedProductoPais.canEntregDetPedProductoPais) as faltantes," & _
        "0 as existencias" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TTDetPedProductoPais ON TBProducto.idProducto = TTDetPedProductoPais.idProducto" & _
        " where TTDetPedProductoPais.idEncPedProductoPais=" & Me.idEncPedProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetallePedidoPorEmpresas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTDetPedProductoBod.idEncPedProductoBod," & _
        "TTDetPedProductoBod.cantDetPedProductoBod," & _
        "TTDetPedProductoBod.cantEntregaDetPedProductoBod," & _
        "TTDetPedProductoBod.valorDetPedProductoBod," & _
        "TTDetPedProductoBod.subtotalDetPedProductoBod," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncPedProductoBod INNER JOIN" & _
        " TTDetPedProductoBod ON " & _
        " TTEncPedProductoBod.idEncPedProductoBod = TTDetPedProductoBod.idEncPedProductoBod INNER JOIN" & _
        " TBProducto ON TTDetPedProductoBod.idProducto = TBProducto.idProducto" & _
        " where TTDetPedProductoBod.idEncPedProductoBod=" & Me.idEncPedProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetallePedidoPorIdActuzalizaConfirmacion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTDetPedProductoPais where idEncPedProductoPais=" & Me.idEncPedProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaTTDetPedProductoPaiscanEntregDetPedProductoPais()
        Dim sql As String
        sql = "exec sp_actualizaTTDetPedProductoPaiscanEntregDetPedProductoPais " & _
        "@idDetPedProductoPais='" & Me.idDetPedProductoPais & "'," & _
        "@canEntregDetPedProductoPais='" & Me.canEntregDetPedProductoPais & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
