Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPremio

    Private _idPremio As Integer
    Private _nombrePremio As String
    Private _idPremioPais As Integer
    Private _precioPremioPais As Double
    Private _estadoPremioPais As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPremio As Integer
        Get
            Return _idPremio
        End Get
        Set(ByVal value As Integer)
            _idPremio = value
        End Set
    End Property

    Public Property nombrePremio As String
        Get
            Return _nombrePremio
        End Get
        Set(ByVal value As String)
            _nombrePremio = value
        End Set
    End Property

    Public Property idPremioPais As Integer
        Get
            Return _idPremioPais
        End Get
        Set(ByVal value As Integer)
            _idPremioPais = value
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

    Public Property precioPremioPais As Double
        Get
            Return _precioPremioPais
        End Get
        Set(ByVal value As Double)
            _precioPremioPais = value
        End Set
    End Property

    Public Property estadoPremioPais As Integer
        Get
            Return _estadoPremioPais
        End Get
        Set(ByVal value As Integer)
            _estadoPremioPais = value
        End Set
    End Property

    Sub grabarPremio(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_kinnux_actualizaPremio " & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@nombrePremio='" & Me.nombrePremio & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarPremioPais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_kinnux_actualizaPremioPais " & _
        "@idPremioPais='" & Me.idPremioPais & "'," & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@precioPremioPais='" & Me.precioPremioPais & "'," & _
        "@estadoPremioPais='" & Me.estadoPremioPais & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPremios() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBPremio.idPremio," & _
        "TBPremio.nombrePremio," & _
        "TBPremioPais.idPremioPais," & _
        "TBPremioPais.precioPremioPais," & _
        "TBPremioPais.estadoPremioPais," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TBPremio INNER JOIN" & _
        " TBPremioPais ON TBPremio.idPremio = TBPremioPais.idPremio INNER JOIN" & _
        " dbo.TBpais ON TBPremioPais.idPais = dbo.TBpais.codigoPais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPremiosPorPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBPremio.idPremio," & _
        "TBPremio.nombrePremio" & _
        " FROM" & _
        " TBPremio INNER JOIN" & _
        " TBPremioPais ON TBPremio.idPremio = TBPremioPais.idPremio INNER JOIN" & _
        " dbo.TBpais ON TBPremioPais.idPais = dbo.TBpais.codigoPais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
