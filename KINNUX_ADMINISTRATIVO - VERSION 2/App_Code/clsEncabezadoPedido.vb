Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsEncabezadoPedido

    Private _idEncPedProductoBod As Integer
    Private _fechaEncPedProductoBod As Date
    Private _idEmpresa As Integer
    Private _observEncPedProductoBod As String
    Private _procesadoEncPedProductoBod As String
    Private _confirEncPedProductoBod As String
    Private _estadoEncPedProductoBod As Integer
    Dim objOperacione As New clsOperacione

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

    Sub grabarEncabezadoPedido()
        Dim sql As String
        sql = "exec sp_actualizaTTEncPedProductoBod " & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'," & _
        "@fechaEncPedProductoBod='" & Me.fechaEncPedProductoBod.ToString("yyyyMMdd") & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@observEncPedProductoBod='" & Me.observEncPedProductoBod & "'," & _
        "@procesadoEncPedProductoBod='" & Me.procesadoEncPedProductoBod & "'," & _
        "@confirEncPedProductoBod='" & Me.confirEncPedProductoBod & "'," & _
        "@estadoEncPedProductoBod='" & Me.estadoEncPedProductoBod & "'," & _
        "@accion='1'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPedidosPorPais() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "idEncPedProductoBod, " & _
        "fechaEncPedProductoBod," & _
        "observEncPedProductoBod, " & _
        "procesadoEncPedProductoBod," & _
        "confirEncPedProductoBod, " & _
        "estadoEncPedProductoBod," & _
        " case estadoEncPedProductoBod" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Anulado'" & _
        " end nombreEstado" & _
        " FROM" & _
        " TTEncPedProductoBod" & _
        " where idEmpresa=" & Me.idEmpresa
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub anularPedido()
        Dim sql As String
        sql = "exec sp_anularPedidoTTEncPedProductoBod " & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function ObtenerPedidoPorIdPedido() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        'sql = "select * from TTEncPedProductoBod where idEncPedProductoBod=" & Me.idEncPedProductoBod & " and confirEncPedProductoBod='No' or confirEncPedProductoBod='Pr'"
        sql = "select * from TTEncPedProductoBod where idEncPedProductoBod=" & Me.idEncPedProductoBod
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
