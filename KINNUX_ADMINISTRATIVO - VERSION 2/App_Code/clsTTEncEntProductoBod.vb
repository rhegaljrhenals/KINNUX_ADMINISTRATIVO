Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTEncEntProductoBod

    Private _idEncEntProductoBod As Integer
    Private _fechaEncEntProductoBod As Date
    Private _fechaInicial As String
    Private _fechaFinal As String
    Private _idProveedor As Integer
    Private _valorEncProductoBod As Double
    Private _guiaEncEntProductoBod As String
    Private _procesaEncEntProductoBod As String
    Private _confirEncEntProductoBod As String
    Private _estadoEncEntProductoBod As Integer
    Private _observEncEntProdcutoBod As String
    Dim objOperacione As New clsOperacione

    Public Property idEncEntProductoBod As Integer
        Get
            Return _idEncEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncEntProductoBod = value
        End Set
    End Property

    Public Property fechaEncEntProductoBod As Date
        Get
            Return _fechaEncEntProductoBod
        End Get
        Set(ByVal value As Date)
            _fechaEncEntProductoBod = value
        End Set
    End Property

    Public Property fechaInicial As String
        Get
            Return _fechaInicial
        End Get
        Set(ByVal value As String)
            _fechaInicial = value
        End Set
    End Property

    Public Property fechaFinal As String
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As String)
            _fechaFinal = value
        End Set
    End Property

    Public Property idProveedor As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property

    Public Property valorEncProductoBod As Double
        Get
            Return _valorEncProductoBod
        End Get
        Set(ByVal value As Double)
            _valorEncProductoBod = value
        End Set
    End Property

    Public Property guiaEncEntProductoBod As String
        Get
            Return _guiaEncEntProductoBod
        End Get
        Set(ByVal value As String)
            _guiaEncEntProductoBod = value
        End Set
    End Property


    Public Property procesaEncEntProductoBod As String
        Get
            Return _procesaEncEntProductoBod
        End Get
        Set(ByVal value As String)
            _procesaEncEntProductoBod = value
        End Set
    End Property

    Public Property confirEncEntProductoBod As String
        Get
            Return _confirEncEntProductoBod
        End Get
        Set(ByVal value As String)
            _confirEncEntProductoBod = value
        End Set
    End Property

    Public Property estadoEncEntProductoBod As Integer
        Get
            Return _estadoEncEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _estadoEncEntProductoBod = value
        End Set
    End Property

    Public Property observEncEntProdcutoBod As String
        Get
            Return _observEncEntProdcutoBod
        End Get
        Set(ByVal value As String)
            _observEncEntProdcutoBod = value
        End Set
    End Property

    Sub grabarTTEncEntProductoBod()
        Dim sql As String
        sql = "exec sp_actualizaTTEncEntProductoBod " & _
        "@idEncEntProductoBod='" & Me.idEncEntProductoBod & "'," & _
        "@fechaEncEntProductoBod='" & Me.fechaEncEntProductoBod.ToString("yyyyMMdd") & "'," & _
        "@idProveedor='" & Me.idProveedor & "'," & _
        "@valorEncProductoBod='" & Me.valorEncProductoBod & "'," & _
        "@guiaEncEntProductoBod='" & Me.guiaEncEntProductoBod & "'," & _
        "@procesaEncEntProductoBod='" & Me.procesaEncEntProductoBod & "'," & _
        "@confirEncEntProductoBod='" & Me.confirEncEntProductoBod & "'," & _
        "@estadoEncEntProductoBod='" & Me.estadoEncEntProductoBod & "'," & _
        "@observEncEntProdcutoBod='" & Me.observEncEntProdcutoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerTTEncEntProductoBodPorIdEntrada() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TTEncEntProductoBod.fechaEncEntProductoBod," & _
        "TTEncEntProductoBod.valorEncProductoBod," & _
        "TTEncEntProductoBod.guiaEncEntProductoBod," & _
        "TTEncEntProductoBod.procesaEncEntProductoBod," & _
        "TTEncEntProductoBod.confirEncEntProductoBod," & _
        "TTEncEntProductoBod.estadoEncEntProductoBod," & _
        "TTEncEntProductoBod.observEncEntProdcutoBod," & _
        "dbo.TBProveedor.idProveedor," & _
        "dbo.TBProveedor.nombreProveedor" & _
        " FROM" & _
        " TTEncEntProductoBod INNER JOIN" & _
        " dbo.TBProveedor ON TTEncEntProductoBod.idProveedor = dbo.TBProveedor.idProveedor" & _
        " where TTEncEntProductoBod.idEncEntProductoBod=" & Me.idEncEntProductoBod & " and (TTEncEntProductoBod.confirEncEntProductoBod='No' or TTEncEntProductoBod.confirEncEntProductoBod='Pr')"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub ActualizaProcesoTTEncEntProductoBod(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_CambiaProcesoTTEncEntProductoBod " & _
        "@idEncEntProductoBod='" & Me.idEncEntProductoBod & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerEntradasPorTipoproceso() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTEncEntProductoBod.idEncEntProductoBod," & _
        "TTEncEntProductoBod.fechaEncEntProductoBod," & _
        "dbo.TBProveedor.idProveedor," & _
        "dbo.TBProveedor.nombreProveedor," & _
        "TTEncEntProductoBod.valorEncProductoBod," & _
        "TTEncEntProductoBod.guiaEncEntProductoBod," & _
        "TTEncEntProductoBod.procesaEncEntProductoBod," & _
        "TTEncEntProductoBod.confirEncEntProductoBod," & _
        "TTEncEntProductoBod.estadoEncEntProductoBod" & _
        " FROM" & _
        " TTEncEntProductoBod INNER JOIN" & _
        " dbo.TBProveedor ON TTEncEntProductoBod.idProveedor = dbo.TBProveedor.idProveedor" & _
        " where TTEncEntProductoBod.confirEncEntProductoBod='Pr' or TTEncEntProductoBod.confirEncEntProductoBod='No'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerEntradasProductos(ByVal tipo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTEncEntProductoBod.idEncEntProductoBod," & _
        "TTEncEntProductoBod.fechaEncEntProductoBod," & _
        "dbo.TBProveedor.nombreProveedor," & _
        "TTEncEntProductoBod.valorEncProductoBod," & _
        "TTEncEntProductoBod.guiaEncEntProductoBod," & _
        "TTEncEntProductoBod.procesaEncEntProductoBod," & _
        "TTEncEntProductoBod.confirEncEntProductoBod," & _
        " case  TTEncEntProductoBod.confirEncEntProductoBod" & _
        " when 'Si' then 'Confirmado'" & _
        " when 'No' then 'No Confirmado'" & _
        " when 'Pr' then 'En Proceso'" & _
        " end confirmado," & _
        " case TTEncEntProductoBod.estadoEncEntProductoBod" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Anulado'" & _
        " end estado" & _
        " FROM" & _
        " TTEncEntProductoBod INNER JOIN" & _
        " dbo.TBProveedor ON TTEncEntProductoBod.idProveedor = dbo.TBProveedor.idProveedor" & _
        " where TTEncEntProductoBod.fechaEncEntProductoBod between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'"
        Select Case tipo
            Case Is = 1
                sql = sql & " and TTEncEntProductoBod.confirEncEntProductoBod='Si'"
            Case Is = 2
                sql = sql & " and TTEncEntProductoBod.confirEncEntProductoBod='No'"
            Case Is = 3
                sql = sql & " and TTEncEntProductoBod.confirEncEntProductoBod='Pr'"
            Case Is = 4
                sql = sql
        End Select
        sql = sql & " order by TTEncEntProductoBod.fechaEncEntProductoBod DESC"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function validaNumeroGuia() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTEncEntProductoBod where guiaEncentProductoBod='" & Me.guiaEncEntProductoBod & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
