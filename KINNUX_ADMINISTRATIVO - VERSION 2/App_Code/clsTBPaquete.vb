Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTBPaquete

    Private _idPaquete As Integer
    Private _nombrePaquete As String
    Private _puntosPaquete As Integer
    Private _ascenso As String
    Private _paqInicial As Integer
    Private _paqFinal As Integer
    Private _tsPaquete As Double
    Private _promocion As String
    Private _paquete As Integer
    Private _paqueteBase As String
    Private _esSuperTs As String
    Private _esSuperPaquete As String

    Dim objOperacione As New clsOperacione

    Public Property esSuperPaquete As String
        Get
            Return _esSuperPaquete
        End Get
        Set(ByVal value As String)
            _esSuperPaquete = value
        End Set
    End Property

    Public Property esSuperTs As String
        Get
            Return _esSuperTs
        End Get
        Set(ByVal value As String)
            _esSuperTs = value
        End Set
    End Property

    Public Property paqueteBase As String
        Get
            Return _paqueteBase
        End Get
        Set(ByVal value As String)
            _paqueteBase = value
        End Set
    End Property


    Public Property tsPaquete As Double
        Get
            Return _tsPaquete
        End Get
        Set(ByVal value As Double)
            _tsPaquete = value
        End Set
    End Property

    Public Property promocion As String
        Get
            Return _promocion
        End Get
        Set(ByVal value As String)
            _promocion = value
        End Set
    End Property

    Public Property paquete As Integer
        Get
            Return _paquete
        End Get
        Set(ByVal value As Integer)
            _paquete = value
        End Set
    End Property

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

    Public Property ascenso As String
        Get
            Return _ascenso
        End Get
        Set(ByVal value As String)
            _ascenso = value
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

    ' procedimiento para grabar datos en TBPaquete
    Sub grabarTBPaquete(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquete " & _
        "@idPaquete='" & Me.idPaquete & "'," & _
        "@nombrePaquete='" & Me.nombrePaquete & "'," & _
        "@puntosPaquete='" & Me.puntosPaquete & "'," & _
        "@accion='" & accion & "'," & _
        "@ascenso='" & Me.ascenso & "'," & _
        "@paqInicial='" & Me.paqInicial & "'," & _
        "@paqFinal='" & Me.paqFinal & "'," & _
        "@tsPaquete='" & Me.tsPaquete & "'," & _
        "@promocion='" & Me.promocion & "'," & _
        "@paquete='" & Me.paquete & "'," & _
        "@paqueteBase='" & Me.paqueteBase & "'," & _
        "@esSuperTs='" & Me.esSuperTs & "'," & _
        "@esSuperPaquete='" & Me.esSuperPaquete & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento para obtener los paquetes de no ascensos
    Function obtenerPaquetesNoAscensos() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbPaquete where ascenso='no' order by idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los precios de los paquetes por pais
    Function obtenerPreciosPaquetesPorPais(ByVal pais As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "TBPaquetePais.idPaquetePais," & _
        "TBPaquetePais.precioPaquetePais," & _
        "TBPaquetePais.precioLocalPaquetePais" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBPaquetePais ON TBPaquete.idPaquete = TBPaquetePais.idPaquete" & _
        " where TBPaquetePais.idPais=" & pais & _
        " order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los paquetes
    Function obtenerPaquetes() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbpaquete order by idpaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los paquetes por idpaquete
    Function obtenerPaquetesPorIdPaquete() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbPaquete where idPaquete=" & Me.idPaquete
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
