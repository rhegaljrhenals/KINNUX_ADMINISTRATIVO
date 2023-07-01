Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsEquipos
    Private _idEquipom As Integer
    Private _nombreEquipom As String
    Private _idEquipoPais As Integer
    Private _idPais As Integer
    Private _precioEquipo As Double
    Private _estadoEquipo As Integer
    Dim objOperacione As New clsOperacione

    Public Property idEquipom As Integer
        Get
            Return _idEquipom
        End Get
        Set(ByVal value As Integer)
            _idEquipom = value
        End Set
    End Property

    Public Property nombreEquipom As String
        Get
            Return _nombreEquipom
        End Get
        Set(ByVal value As String)
            _nombreEquipom = value
        End Set
    End Property

    Public Property idEquipoPais As Integer
        Get
            Return _idEquipoPais
        End Get
        Set(ByVal value As Integer)
            _idEquipoPais = value
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

    Public Property precioEquipo As Double
        Get
            Return _precioEquipo
        End Get
        Set(ByVal value As Double)
            _precioEquipo = value
        End Set
    End Property

    Public Property estadoEquipo As Integer
        Get
            Return _estadoEquipo
        End Get
        Set(ByVal value As Integer)
            _estadoEquipo = value
        End Set
    End Property

    Sub grabarEquipo(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaEquiposMedicos " & _
        "@idEquipom='" & Me.idEquipom & "'," & _
        "@nombreEquipom='" & Me.nombreEquipom & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarEquipoPais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaEquipoPais " & _
        "@idEquipoPais='" & Me.idEquipoPais & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precioEquipo='" & Me.precioEquipo & "'," & _
        "@estadoEquipo='" & Me.estadoEquipo & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerEquipos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBEquipom.idEquipom," & _
        "TBEquipom.nombreEquipom," & _
        "TBEquipoPais.idEquipoPais," & _
        "TBEquipoPais.precioEquipo," & _
        "TBEquipoPais.estadoEquipo," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " dbo.TBpais INNER JOIN" & _
        " TBEquipoPais ON dbo.TBpais.codigoPais = TBEquipoPais.idPais INNER JOIN" & _
        " TBEquipom ON TBEquipoPais.idEquipom = TBEquipom.idEquipom"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerEquiposPorPais() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TBEquipom.idEquipom," & _
        "TBEquipom.nombreEquipom" & _
        " FROM" & _
        " TBEquipom INNER JOIN" & _
        " TBEquipoPais ON TBEquipom.idEquipom = TBEquipoPais.idEquipom INNER JOIN" & _
        " dbo.TBpais ON TBEquipoPais.idPais = dbo.TBpais.codigoPais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
