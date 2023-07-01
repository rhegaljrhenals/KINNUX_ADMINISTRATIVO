Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquete

    Private _idPaquete As Integer
    Private _nombrePaquete As String
    Private _puntosPaquete As Integer
    Private _ascenso As String
    Private _paqInicial As Integer
    Private _paqFinal As Integer
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

    Sub grabarPaquete(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquete " & _
        "@idPaquete='" & Me.idPaquete & "'," & _
        "@nombrePaquete='" & Me.nombrePaquete & "'," & _
        "@puntosPaquete='" & Me.puntosPaquete & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarPaquetePais(ByVal accion As Integer, ByVal chequeado As String)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePais " & _
        "@idPaquete='" & Me.idpaquetePais & "'," & _
        "@idpaquetePais='" & Me.idpaquetePais & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precioPaquetePais='" & Me.precioPaquetePais & "'," & _
        "@precioLocalPaquetePais='" & Me.precioLocalPaquetePais & "'," & _
        "@estadoPaquete='" & Me.estadoPaquete & "'," & _
        "@accion='" & accion & "'," & _
        "@chequeado='" & chequeado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPaquetes() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbPaquete order by idPaquete"
        'sql = "SELECT     " & _
        '"TBPaquete.idPaquete," & _
        '"TBPaquete.nombrePaquete," & _
        '"TBPaquete.puntosPaquete," & _
        '"TBPaquetePais.idPaquetePais," & _
        '"TBPaquetePais.precioPaquetePais," & _
        '"TBPaquetePais.precioLocalPaquetePais," & _
        '"TBPaquetePais.estadoPaquete," & _
        '"dbo.TBpais.codigoPais," & _
        '"dbo.TBpais.nombrePais" & _
        '" FROM" & _
        '" TBPaquete INNER JOIN" & _
        '" TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete INNER JOIN" & _
        '" dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenertbPaquetePaisPorIdPaquete() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from tbPaquetePais where idPaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los precios de los paquetes por pais
    Function obtenerPreciosPorPaqueteyPais() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbpaquetepais" & _
            " where idPais=" & Me.idPais & " and" & _
            " idpaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaPreciosPaquetes()
        Dim sql As String
        sql = "exec sp_modificaPreciosPaquetes " & _
        "@idPaquete='" & Me.idPaquete & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precio='" & Me.precioPaquetePais & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function listadoPreciosPaquetesPorPais() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TBPaquetePais INNER JOIN" & _
        " TBPaquete ON TBPaquetePais.idPaquete = TBPaquete.idPaquete INNER JOIN" & _
        " dbo.TBpais ON TBPaquetePais.idPais = dbo.TBpais.codigoPais" & _
        " where" & _
        " dbo.TBpais.codigoPais = " & Me.idPais & _
        " order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
