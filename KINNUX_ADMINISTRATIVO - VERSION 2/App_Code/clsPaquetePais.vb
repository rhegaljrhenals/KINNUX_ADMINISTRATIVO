Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePais

    Private _idPaquete As Integer
    Private _paqInicial As Integer
    Private _paqFinal As Integer
    Private _nombrePaquete As String
    Private _puntosPaquete As Integer
    Private _idpaquetePais As Integer
    Private _idPais As Integer
    Private _precioPaquetePais As Double
    Private _precioLocalPaquetePais As Double
    Private _estadoPaquete As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaquete As Integer
        Get
            Return _idPaquete
        End Get
        Set(ByVal value As Integer)
            _idPaquete = value
        End Set
    End Property

    Public Property paqInicial As Integer
        Get
            Return _paqInicial
        End Get
        Set(ByVal value As Integer)
            _paqInicial = value
        End Set
    End Property

    Public Property paqFinal As Integer
        Get
            Return _paqFinal
        End Get
        Set(ByVal value As Integer)
            _paqFinal = value
        End Set
    End Property


    Public Property nombrePaquete As String
        Get
            Return _nombrePaquete
        End Get
        Set(ByVal value As String)
            _nombrePaquete = value
        End Set
    End Property

    Public Property puntosPaquete As Integer
        Get
            Return _puntosPaquete
        End Get
        Set(ByVal value As Integer)
            _puntosPaquete = value
        End Set
    End Property

    Public Property idpaquetePais As Integer
        Get
            Return _idpaquetePais
        End Get
        Set(ByVal value As Integer)
            _idpaquetePais = value
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

    Public Property precioPaquetePais As Double
        Get
            Return _precioPaquetePais
        End Get
        Set(ByVal value As Double)
            _precioPaquetePais = value
        End Set
    End Property

    Public Property precioLocalPaquetePais As Double
        Get
            Return _precioLocalPaquetePais
        End Get
        Set(ByVal value As Double)
            _precioLocalPaquetePais = value
        End Set
    End Property

    Public Property estadoPaquete As Integer
        Get
            Return _estadoPaquete
        End Get
        Set(ByVal value As Integer)
            _estadoPaquete = value
        End Set
    End Property

    Function obtenerPaquetes() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquete.puntosPaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "TBPaquetePais.estadoPaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "0 as subtotal" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where TBPaquetePais.idPais=" & Me.idPais & _
        "  order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPaquetesNoAscensos() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquete.puntosPaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "TBPaquetePais.estadoPaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "0 as subtotal" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where TBPaquetePais.idPais=" & Me.idPais & " and ascenso='no'" & _
        "  order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPaquetesDeAscensos() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquete.puntosPaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "TBPaquetePais.estadoPaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "0 as subtotal" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where TBPaquetePais.idPais=" & Me.idPais & " and TBPaquete.paqInicial=" & Me.idPaquete & " and (TBPaquete.ascenso='si') or TBPaquete.ascenso='cm'" & _
        "  order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerCompraMensual() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquete.puntosPaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "TBPaquetePais.estadoPaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "0 as subtotal" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where TBPaquetePais.idPais=" & Me.idPais & " and (TBPaquete.ascenso='cm')" & _
        "  order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosPaquetesPorPaisIdPaquete() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquete.puntosPaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "TBPaquetePais.estadoPaquete," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "0 as subtotal" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where TBPaquetePais.idPais=" & Me.idPais & " and" & _
        " TBPaquete.idPaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductosPorPaquetes() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TBPaqProducto.cantPaqProducto," & _
        "'0' as precioPaquetePais," & _
        "'0' as precioLocalPaquetePais, " & _
        "'0' as precioProductoPersonal," & _
        "'0' as puntosPaquete" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        " TBPaqProducto ON TBPaquete.idPaquete = TBPaqProducto.idPaquete INNER JOIN" & _
        " TBProducto ON TBPaqProducto.idProducto = TBProducto.idProducto" & _
        " where TBPaquete.idPaquete = " & Me.idPaquete & " And" & _
        " TBPaquetePais.idPais = " & Me.idPais

        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener la cantidad de productos de un paquete
    Function obtenerNumeroDeProductosPaquete() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "sum(TBPaqProducto.cantPaqProducto) as cantidad" & _
        " FROM" & _
        " TBPaquete INNER JOIN " & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN " & _
        " TBPaqProducto ON TBPaquete.idPaquete = TBPaqProducto.idPaquete INNER JOIN " & _
        " TBProducto ON TBPaqProducto.idProducto = TBProducto.idProducto " & _
        " where TBPaquete.idPaquete = " & Me.idPaquete & " And" & _
        " TBPaquetePais.idPais = " & Me.idPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el paquete inicial y final del paquete
    Function obtienePaqueteFinal() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select paqInicial,paqFinal from tbPaquete where IdPaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion obtener el nombre del paquete por idpaquete
    Function obtenerNombrePaquetePorIdPaquete() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbPaquete where idPaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
