Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTBodPaisProducto

    Private _idProducto As Integer
    Private _idEmpresa As Integer
    Private _cantBodPaisProducto As Double
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Dim objOperacione As New clsOperacione

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property cantBodPaisProducto As Integer
        Get
            Return _cantBodPaisProducto
        End Get
        Set(value As Integer)
            _cantBodPaisProducto = value
        End Set
    End Property

    Function obtenerExistenciasPorEmpresas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTBodPaisProducto.cantBodPaisProducto," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa" & _
        " FROM" & _
        " TTBodPaisProducto INNER JOIN" & _
        " TBProducto ON TTBodPaisProducto.idProducto = TBProducto.idProducto INNER JOIN" & _
        " dbo.TBEmpresa ON TTBodPaisProducto.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where dbo.TBEmpresa.idEmpresa=" & Me.idEmpresa
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los pedido por productos
    Function obtenerPedidosPorProductos() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncPedProductoBod.idEncPedProductoBod," & _
        "TTEncPedProductoBod.fechaEncPedProductoBod," & _
        "TTEncPedProductoBod.idEmpresa," & _
        "TTEncPedProductoBod.observEncPedProductoBod," & _
        "TTEncPedProductoBod.procesadoEncPedProductoBod," & _
        "TTEncPedProductoBod.confirEncPedProductoBod," & _
        "TTEncPedProductoBod.estadoEncPedProductoBod," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTDetPedProductoBod.cantDetPedProductoBod," & _
        "TTDetPedProductoBod.cantEntregaDetPedProductoBod," & _
        "TTDetPedProductoBod.valorDetPedProductoBod, TTDetPedProductoBod.subtotalDetPedProductoBod" & _
        " FROM" & _
        " TTEncPedProductoBod INNER JOIN" & _
        " TTDetPedProductoBod ON " & _
        " TTEncPedProductoBod.idEncPedProductoBod = TTDetPedProductoBod.idEncPedProductoBod INNER JOIN" & _
        " TBProducto ON TTDetPedProductoBod.idProducto = TBProducto.idProducto" & _
        " where TTEncPedProductoBod.idEmpresa=" & Me.idEmpresa & " and" & _
        " TBProducto.idProducto=" & Me.idProducto & " and" & _
        " TTEncPedProductoBod.fechaEncPedProductoBod between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " (TTEncPedProductoBod.confirEncPedProductoBod='si'  or  TTEncPedProductoBod.confirEncPedProductoBod='Pr')" & _
        " order by TTEncPedProductoBod.fechaEncPedProductoBod"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
