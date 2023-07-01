Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPrecioPorPais
    Private _idColeccionPais As Integer
    Private _idColeccion As Integer
    Private _idCampana As Integer
    Private _precioColeccion As Long
    Private _precioLocalColeccion As Long
    Private _precioPersonalColeccion As Long
    Private _porcPersonalColeccion As Integer
    Private _stockColeccion As Integer
    Private _tipoPersonalColeccion As Integer
    Private _tipoEstadoColeccion As Integer
    Private _tipoPaquete As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idColeccionPais As Integer
        Get
            Return _idColeccionPais
        End Get
        Set(ByVal value As Integer)
            _idColeccionPais = value
        End Set
    End Property

    Public Property idCampana As Integer
        Get
            Return _idCampana
        End Get
        Set(ByVal value As Integer)
            _idCampana = value
        End Set
    End Property

    Public Property tipoPaquete As Integer
        Get
            Return _tipoPaquete
        End Get
        Set(ByVal value As Integer)
            _tipoPaquete = value
        End Set
    End Property


    Public Property idColeccion As Integer
        Get
            Return _idColeccion
        End Get
        Set(ByVal value As Integer)
            _idColeccion = value
        End Set
    End Property

    Public Property PrecioColeccion As Long
        Get
            Return _precioColeccion
        End Get
        Set(ByVal value As Long)
            _precioColeccion = value
        End Set
    End Property

    Public Property PrecioLocalColeccion As Long
        Get
            Return _precioLocalColeccion
        End Get
        Set(ByVal value As Long)
            _precioLocalColeccion = value
        End Set
    End Property

    Public Property PrecioPersonalColeccion As Long
        Get
            Return _precioPersonalColeccion
        End Get
        Set(ByVal value As Long)
            _precioPersonalColeccion = value
        End Set
    End Property

    Public Property PorcentageColeccion As Long
        Get
            Return _porcPersonalColeccion
        End Get
        Set(ByVal value As Long)
            _porcPersonalColeccion = value
        End Set
    End Property

    Public Property stockColeccion As Integer
        Get
            Return _stockColeccion
        End Get
        Set(ByVal value As Integer)
            _stockColeccion = value
        End Set
    End Property

    Public Property tipoPersonalColeccion As Integer
        Get
            Return _tipoPersonalColeccion
        End Get
        Set(ByVal value As Integer)
            _tipoPersonalColeccion = value
        End Set
    End Property

    Public Property tipoEstadoColeccion As Integer
        Get
            Return _tipoEstadoColeccion
        End Get
        Set(ByVal value As Integer)
            _tipoEstadoColeccion = value
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

    Sub grabarColeccionPais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_ActualizaTBColeccionPais " & _
        "@idColeccionPais='" & Me.idColeccionPais & "'," & _
        "@idCampana='" & Me.idCampana & "'," & _
        "@idColeccion='" & Me.idColeccion & "'," & _
        "@precioColeccion='" & Me.PrecioColeccion & "'," & _
        "@precioLocalColeccion='" & Me.PrecioLocalColeccion & "'," & _
        "@precioPersonalColeccion='" & Me.PrecioPersonalColeccion & "'," & _
        "@porcPersonalColeccion='" & Me.PorcentageColeccion & "'," & _
        "@stockColeccion='" & Me.stockColeccion & "'," & _
        "@tipoPersonalColeccion='" & Me.tipoPersonalColeccion & "'," & _
        "@tipoEstadoColeccion='" & Me.tipoEstadoColeccion & "'," & _
        "@tipoPaquete='" & Me.tipoPaquete & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPrecioPorIDColeccion() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBColeccionPais.idColeccionPais," & _
        "TBColeccionPais.idColeccion," & _
        "TBColeccionPais.precioColeccion," & _
        "TBColeccionPais.precioLocalColeccion," & _
        "TBColeccionPais.precioPersonalColeccion," & _
        "TBColeccionPais.porcPersonalColeccion," & _
        "TBColeccionPais.stockColeccion," & _
        "TBpais.idpais," & _
        "TBpais.nombrePais" & _
        " FROM" & _
        " TBColeccionPais INNER JOIN" & _
        " TBpais ON TBColeccionPais.idPais = TBpais.idpais" & _
        " where TBColeccionPais.idColeccion=" & Me.idColeccion
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtienePreciosPorid() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT * from TBColeccionPais " & _
        "where idColeccion=" & Me.idColeccion & " and idPais=" & Me.idPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerProductoTipoProductoPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_muestraProductoTipoProductoPorPais " & _
        "@idPais='" & Me.idPais & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
