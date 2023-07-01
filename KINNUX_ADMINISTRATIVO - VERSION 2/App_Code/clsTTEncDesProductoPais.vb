Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTEncDesProductoPais

    Private _idEncDesProductoPais As Integer
    Private _fechaEncDesProductoPais As Date
    Private _fechaInicial As String
    Private _fechaFinal As String
    Private _idEncPedProductoBod As Integer
    Private _IdEmpresa As Integer
    Private _valorEncDesProductoPais As Double
    Private _guiaEncDesProductoPais As String
    Private _dirEnvioEncDesProductoPais As String
    Private _observEncDesProductoPais As String
    Private _procesadoEncDesProductoPais As String
    Private _confirEncDesProductoPais As String
    Private _estadoEncDesProductoPais As String
    Dim objOperacione As New clsOperacione

    Public Property idEncDesProductoPais As Integer
        Get
            Return _idEncDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _idEncDesProductoPais = value
        End Set
    End Property


    Public Property fechaEncDesProductoPais As Date
        Get
            Return _fechaEncDesProductoPais
        End Get
        Set(ByVal value As Date)
            _fechaEncDesProductoPais = value
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


    Public Property idEncPedProductoBod As Integer
        Get
            Return _idEncPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncPedProductoBod = value
        End Set
    End Property

    Public Property IdEmpresa As Integer
        Get
            Return _IdEmpresa
        End Get
        Set(ByVal value As Integer)
            _IdEmpresa = value
        End Set
    End Property

    Public Property valorEncDesProductoPais As Double
        Get
            Return _valorEncDesProductoPais
        End Get
        Set(ByVal value As Double)
            _valorEncDesProductoPais = value
        End Set
    End Property

    Public Property guiaEncDesProductoPais As String
        Get
            Return _guiaEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _guiaEncDesProductoPais = value
        End Set
    End Property

    Public Property dirEnvioEncDesProductoPais As String
        Get
            Return _dirEnvioEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _dirEnvioEncDesProductoPais = value
        End Set
    End Property

    Public Property observEncDesProductoPais As String
        Get
            Return _observEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _observEncDesProductoPais = value
        End Set
    End Property

    Public Property procesadoEncDesProductoPais As String
        Get
            Return _procesadoEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _procesadoEncDesProductoPais = value
        End Set
    End Property

    Public Property confirEncDesProductoPais As String
        Get
            Return _confirEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _confirEncDesProductoPais = value
        End Set
    End Property

    Public Property estadoEncDesProductoPais As String
        Get
            Return _estadoEncDesProductoPais
        End Get
        Set(ByVal value As String)
            _estadoEncDesProductoPais = value
        End Set
    End Property

    Sub grabarEncabezadoDespachoPais()
        Dim sql As String
        sql = "exec sp_actualizaTTEncDesProductoPais " & _
        "@idEncDesProductoPais='" & Me.idEncDesProductoPais & "'," & _
        "@fechaEncDesProductoPais='" & Me.fechaEncDesProductoPais.ToString("yyyyMMdd") & "'," & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'," & _
        "@IdEmpresa='" & Me.IdEmpresa & "'," & _
        "@valorEncDesProductoPais='" & Me.valorEncDesProductoPais & "'," & _
        "@guiaEncDesProductoPais='" & Me.guiaEncDesProductoPais & "'," & _
        "@dirEnvioEncDesProductoPais='" & Me.dirEnvioEncDesProductoPais & "'," & _
        "@observEncDesProductoPais='" & Me.observEncDesProductoPais & "'," & _
        "@procesadoEncDesProductoPais='" & Me.procesadoEncDesProductoPais & "'," & _
        "@confirEncDesProductoPais='" & Me.confirEncDesProductoPais & "'," & _
        "@estadoEncDesProductoPais='" & Me.estadoEncDesProductoPais & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funccion que devuelves los despachos lo utilice para reportes
    Function obtenerDespachos(ByVal tipo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTEncDesProductoPais.idEncDesProductoPais, " & _
        "TTEncDesProductoPais.fechaEncDesProductoPais," & _
        "TTEncDesProductoPais.idEncPedProductoBod, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa, " & _
        "TTEncDesProductoPais.valorEncDesProductoPais, " & _
        "TTEncDesProductoPais.guiaEncDesProductoPais, " & _
        "TTEncDesProductoPais.procesadoEncDesProductoPais," & _
        "TTEncDesProductoPais.confirEncDesProductoPais, " & _
        " case TTEncDesProductoPais.estadoEncDesProductoPais" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Anulado'" & _
        " end estado" & _
        " FROM" & _
        " TTEncDesProductoPais INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPais.IdEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where TTEncDesProductoPais.fechaEncDesProductoPais between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and dbo.TBEmpresa.idEmpresa=" & Me.IdEmpresa
        Select Case tipo
            Case Is = 1
                sql = sql & " and TTEncDesProductoPais.confirEncDesProductoPais='Si'"
            Case Is = 2
                sql = sql & " and TTEncDesProductoPais.confirEncDesProductoPais='No'"
            Case Is = 3
                sql = sql & " and TTEncDesProductoPais.estadoEncDesProductoPais=0"
            Case Is = 4
                sql = sql & " and TTEncDesProductoPais.estadoEncDesProductoPais=1"
        End Select
        sql = sql & " order by TTEncDesProductoPais.fechaEncDesProductoPais DESC"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function validaNumeroGuia() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTEncDesProductoPais where guiaEncDesProductoPais='" & Me.guiaEncDesProductoPais & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function detalleDespacho() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTDetDesproductoPais.idDetDesProductoPais," & _
        "TTDetDesproductoPais.idEncDesProductoPais," & _
        "TTDetDesproductoPais.cantdetDesProductoPais," & _
        "TTDetDesproductoPais.valorDetDesProductoPais," & _
        "TTDetDesproductoPais.subtotalDetDesProductoPais," & _
        "TTDetDesproductoPais.ncajasDetDesProductoPais," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTDetDesproductoPais INNER JOIN" & _
        " TBProducto ON TTDetDesproductoPais.idProducto = TBProducto.idProducto" & _
        " where TTDetDesproductoPais.idEncDesProductoPais=" & Me.idEncDesProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
