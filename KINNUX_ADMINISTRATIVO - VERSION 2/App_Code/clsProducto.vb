Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsProducto

    Private _idProducto As Integer
    Private _idProductoPais As Integer
    Private _nombreProducto As String
    Private _puntosProducto As Double
    Private _tokenProducto As Integer
    Private _idLinea As Double
    Private _precioProductoPais As Decimal
    Private _precioProductoPaisLocal As Decimal
    Private _precioProductoPersonal As Decimal
    Private _precioProductoPorcentage As Decimal
    Private _precioProductoStock As Decimal
    Private _precioProductoTipo As String
    Private _precioProductoEstado As Integer
    Private _idPais As Integer
    Private _precioElite As Double
    Dim objOperacione As New clsOperacione

    Public Property tokenProducto As Integer
        Get
            Return _tokenProducto
        End Get
        Set(ByVal value As Integer)
            _tokenProducto = value
        End Set
    End Property

    Public Property precioElite As Double
        Get
            Return _precioElite
        End Get
        Set(ByVal value As Double)
            _precioElite = value
        End Set
    End Property

    Public Property nombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(ByVal value As String)
            _nombreProducto = value
        End Set
    End Property

    Public Property puntosProducto As Double
        Get
            Return _puntosProducto
        End Get
        Set(ByVal value As Double)
            _puntosProducto = value
        End Set
    End Property

    Public Property idLinea As Double
        Get
            Return _idLinea
        End Get
        Set(ByVal value As Double)
            _idLinea = value
        End Set
    End Property


    Public Property precioProductoPais As Decimal
        Get
            Return _precioProductoPais
        End Get
        Set(ByVal value As Decimal)
            _precioProductoPais = value
        End Set
    End Property

    Public Property precioProductoPaisLocal As Decimal
        Get
            Return _precioProductoPaisLocal
        End Get
        Set(ByVal value As Decimal)
            _precioProductoPaisLocal = value
        End Set
    End Property


    Public Property precioProductoPersonal As Decimal
        Get
            Return _precioProductoPersonal
        End Get
        Set(ByVal value As Decimal)
            _precioProductoPersonal = value
        End Set
    End Property

    Public Property precioProductoPorcentage As Decimal
        Get
            Return _precioProductoPorcentage
        End Get
        Set(ByVal value As Decimal)
            _precioProductoPorcentage = value
        End Set
    End Property

    Public Property precioProductoStock As Decimal
        Get
            Return _precioProductoStock
        End Get
        Set(ByVal value As Decimal)
            _precioProductoStock = value
        End Set
    End Property

    Public Property precioProductoTipo As String
        Get
            Return _precioProductoTipo
        End Get
        Set(ByVal value As String)
            _precioProductoTipo = value
        End Set
    End Property

    Public Property precioProductoEstado As Integer
        Get
            Return _precioProductoEstado
        End Get
        Set(ByVal value As Integer)
            _precioProductoEstado = value
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

    Public Property idProductoPais As Integer
        Get
            Return _idProductoPais
        End Get
        Set(ByVal value As Integer)
            _idProductoPais = value
        End Set
    End Property

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Sub grabarProducto(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_kinnux_actualizaProducto " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@nombreProducto='" & Me.nombreProducto & "'," & _
        "@puntosProducto='" & Me.puntosProducto & "'," & _
        "@tokenProducto='" & Me.tokenProducto & "'," & _
        "@idLinea='" & Me.idLinea & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarProductoPais(ByVal accion As Integer, ByVal chequeado As String)
        Dim sql As String
        sql = "exec sp_kinnux_actualizaTBProductoPais " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@idProductoPais='" & Me.idProductoPais & "'," & _
        "@precioProductoPais='" & Me.precioProductoPais & "'," & _
        "@precioProductoPaisLocal='" & Me.precioProductoPaisLocal & "'," & _
        "@precioProductoPersonal='" & Me.precioProductoPersonal & "'," & _
        "@precioProductoPorcentage='" & Me.precioProductoPorcentage & "'," & _
        "@precioProductoStock='" & Me.precioProductoStock & "'," & _
        "@precioProductoTipo='" & Me.precioProductoTipo & "'," & _
        "@precioProductoEstado='" & Me.precioProductoEstado & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'," & _
        "@chequeado='" & chequeado & "'," & _
        "@precioElite='" & Me.precioElite & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion que devuelve todos los productos
    Function obtenerProductosPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBProducto.puntosProducto," & _
        "TBProducto.idLinea," & _
        "dbo.TBlinea.nombrelinea," & _
        "TBProductoPais.idProductoPais," & _
        "TBProductoPais.precioProductoPais," & _
        "TBProductoPais.precioProductoPaisLocal," & _
        "TBProductoPais.precioProductoPersonal," & _
        "TBProductoPais.precioProductoPorcentage," & _
        "TBProductoPais.precioProductoStock," & _
        "TBProductoPais.precioProductoTipo," & _
        "TBProductoPais.precioProductoEstado," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " dbo.TBpais INNER JOIN" & _
        " TBProductoPais ON dbo.TBpais.codigoPais = TBProductoPais.idPais INNER JOIN" & _
        " TBProducto INNER JOIN" & _
        " dbo.TBlinea ON TBProducto.idLinea = dbo.TBlinea.idLinea ON " & _
        " TBProductoPais.idProducto = TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion que devuelve los productos por pais
    Function productosPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TBProductoPais ON TBProducto.idProducto = TBProductoPais.idProducto INNER JOIN" & _
        " dbo.TBpais ON TBProductoPais.idPais = dbo.TBpais.codigoPais" & _
        " where dbo.TBpais.codigoPais = " & Me.idPais & " and TBProductoPais.precioProductoEstado=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        'sql = "select idProducto,nombreProducto from tbProducto"
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBProductoPais.precioProductoPais" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TBProductoPais ON " & _
        " TBProducto.idProducto = TBProductoPais.idProducto" & _
        " where TBProductoPais.idPais=" & Me.idPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPreciosPorProductos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        'sql = "select idProducto,nombreProducto from tbProducto"
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBProductoPais.precioProductoPais" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TBProductoPais ON " & _
        " TBProducto.idProducto = TBProductoPais.idProducto" & _
        " where TBProductoPais.idPais=" & Me.idPais & " and TBProducto.idProducto=" & Me.idProducto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductosPorIdProducto() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select idProducto,nombreProducto from tbProducto where idProducto=" & Me.idProducto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerTTProducto() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from tbProducto where estadoproducto=1 order by nombreproducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductosPaginasPersonales() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from preciosProductosPaginaPersonal order by idproducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductoPaisPorIdProducto() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbProductoPais where idProducto=" & Me.idProducto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los precios de los productos por pais
    Function obtenerPreciosProductosPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBProductoPais.idProductoPais," & _
        "TBProductoPais.precioProductoPais," & _
        "TBProductoPais.precioProductoPaisLocal," & _
        "TBProductoPais.precioEliteUnoProductoPais," & _
        "TBProductoPais.precioEliteProductoPais" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TBProductoPais ON TBProducto.idProducto = TBProductoPais.idProducto" & _
        " where TBProductoPais.idpais=" & Me.idPais & _
        " order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaPrecioProducto()
        Dim sql As String
        sql = "exec sp_modificaPreciosProductos " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precio='" & Me.precioProductoPais & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function listadoPreciosProductosPorPais() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBProductoPais.precioProductoPais," & _
        "TBProductoPais.precioProductoPaisLocal, dbo.TBpais.nombrePais, dbo.TBpais.codigoPais" & _
        " FROM" & _
        " TBProducto INNER JOIN" & _
        " TBProductoPais ON TBProducto.idProducto = TBProductoPais.idProducto INNER JOIN" & _
        " dbo.TBpais ON TBProductoPais.idPais = dbo.TBpais.codigoPais" & _
        " where" & _
        " dbo.TBpais.codigoPais = " & Me.idPais & _
        " order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
