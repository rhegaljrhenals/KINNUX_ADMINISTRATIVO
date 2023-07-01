Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTEncPedProductoBod

    Private _idEncPedProductoBod As Integer
    Private _fechaEncPedProductoBod As Date
    Private _idEmpresa As Integer
    Private _observEncPedProductoBod As String
    Private _procesadoEncPedProductoBod As String
    Private _confirEncPedProductoBod As String
    Private _estadoEncPedProductoBod As Integer
    Private _idProducto As Integer
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Dim objOperacione As New clsOperacione

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(ByVal value As Date)
            _fechaInicial = value
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

    Public Property idEncPedProductoBod As Integer
        Get
            Return _idEncPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncPedProductoBod = value
        End Set
    End Property

    Public Property fechaEncPedProductoBod As Date
        Get
            Return _fechaEncPedProductoBod
        End Get
        Set(ByVal value As Date)
            _fechaEncPedProductoBod = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property observEncPedProductoBod As String
        Get
            Return _observEncPedProductoBod
        End Get
        Set(ByVal value As String)
            _observEncPedProductoBod = value
        End Set
    End Property

    Public Property procesadoEncPedProductoBod As String
        Get
            Return _procesadoEncPedProductoBod
        End Get
        Set(ByVal value As String)
            _procesadoEncPedProductoBod = value
        End Set
    End Property

    Public Property confirEncPedProductoBod As String
        Get
            Return _confirEncPedProductoBod
        End Get
        Set(ByVal value As String)
            _confirEncPedProductoBod = value
        End Set
    End Property

    Public Property estadoEncPedProductoBod As Integer
        Get
            Return _estadoEncPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _estadoEncPedProductoBod = value
        End Set
    End Property

    Function obtenerPedidosParaDespachar(ByVal tipoProceso As String) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TTEncPedProductoBod.idEncPedProductoBod," & _
        "TTEncPedProductoBod.fechaEncPedProductoBod," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "TTEncPedProductoBod.procesadoEncPedProductoBod," & _
        "TTEncPedProductoBod.confirEncPedProductoBod," & _
        "TTEncPedProductoBod.estadoEncPedProductoBod" & _
        " FROM" & _
        " TTEncPedProductoBod INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncPedProductoBod.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where TTEncPedProductoBod.confirEncPedProductoBod='No' or TTEncPedProductoBod.confirEncPedProductoBod='Pr' order by TTEncPedProductoBod.fechaEncPedProductoBod desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPedidosPorEmpresas(ByVal tipoProceso As String) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TTEncPedProductoBod.idEncPedProductoBod," & _
        "TTEncPedProductoBod.fechaEncPedProductoBod," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "TTEncPedProductoBod.procesadoEncPedProductoBod," & _
        "TTEncPedProductoBod.confirEncPedProductoBod," & _
        "TTEncPedProductoBod.estadoEncPedProductoBod" & _
        " FROM" & _
        " TTEncPedProductoBod INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncPedProductoBod.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where " & _
        " dbo.TBEmpresa.idEmpresa=" & Me.idEmpresa
        Select Case tipoProceso
            Case Is = 1
                sql = sql & " and TTEncPedProductoBod.confirEncPedProductoBod='Si'"
            Case Is = 2
                sql = sql & " and TTEncPedProductoBod.confirEncPedProductoBod='No'"
            Case Is = 3
                sql = sql & " and TTEncPedProductoBod.confirEncPedProductoBod='Pr'"
            Case Is = 4
                sql = sql & " and TTEncPedProductoBod.estadoEncPedProductoBod=0"
            Case Is = 5
                sql = sql & " and TTEncPedProductoBod.estadoEncPedProductoBod=1"
        End Select
        sql = sql & " Order by TTEncPedProductoBod.fechaEncPedProductoBod desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaTTEncPedProductoBodconfirEncPedProductoBod(ByVal tipo As String)
        Dim sql As String
        sql = "exec sp_actualizaTTEncPedProductoBodconfirEncPedProductoBod " & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'," & _
        "@tipo='" & tipo & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
