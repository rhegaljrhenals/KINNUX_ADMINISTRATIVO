Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTConsignacion

    Private _idEncFacturaPro As Integer
    Private _idConsignacion As Integer
    Private _idCuenta As Integer
    Private _numeroConsignacion As String
    Private _fechaConsignacion As Date
    Private _nPaqConsignacion As Integer
    Private _valorConsignacion As Double
    Private _imagenConsignacion As String
    Private _estadoConsignacion As Integer
    Private _confirConsignacion As String
    Private _observConsignacion As String
    Private _valorUtilizadoConsignacion As Double
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Dim objOperacione As New clsOperacione

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(ByVal value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property idEncFacturaPro As Integer
        Get
            Return _idEncFacturaPro
        End Get
        Set(ByVal value As Integer)
            _idEncFacturaPro = value
        End Set
    End Property

    Public Property idConsignacion As Integer
        Get
            Return _idConsignacion
        End Get
        Set(ByVal value As Integer)
            _idConsignacion = value
        End Set
    End Property

    Public Property idCuenta As Integer
        Get
            Return _idCuenta
        End Get
        Set(ByVal value As Integer)
            _idCuenta = value
        End Set
    End Property

    Public Property numeroConsignacion As String
        Get
            Return _numeroConsignacion
        End Get
        Set(ByVal value As String)
            _numeroConsignacion = value
        End Set
    End Property

    Public Property fechaConsignacion As Date
        Get
            Return _fechaConsignacion
        End Get
        Set(ByVal value As Date)
            _fechaConsignacion = value
        End Set
    End Property

    Public Property nPaqConsignacion As Integer
        Get
            Return _nPaqConsignacion
        End Get
        Set(ByVal value As Integer)
            _nPaqConsignacion = value
        End Set
    End Property

    Public Property valorConsignacion As Double
        Get
            Return _valorConsignacion
        End Get
        Set(ByVal value As Double)
            _valorConsignacion = value
        End Set
    End Property

    Public Property valorUtilizadoConsignacion As Double
        Get
            Return _valorUtilizadoConsignacion
        End Get
        Set(ByVal value As Double)
            _valorUtilizadoConsignacion = value
        End Set
    End Property

    Public Property imagenConsignacion As String
        Get
            Return _imagenConsignacion
        End Get
        Set(ByVal value As String)
            _imagenConsignacion = value
        End Set
    End Property

    Public Property estadoConsignacion As Integer
        Get
            Return _estadoConsignacion
        End Get
        Set(ByVal value As Integer)
            _estadoConsignacion = value
        End Set
    End Property

    Public Property confirConsignacion As String
        Get
            Return _confirConsignacion
        End Get
        Set(ByVal value As String)
            _confirConsignacion = value
        End Set
    End Property

    Public Property observConsignacion As String
        Get
            Return _observConsignacion
        End Get
        Set(ByVal value As String)
            _observConsignacion = value
        End Set
    End Property

    Function obtenerConsignacionPorNumeroConsignacion() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttConsignacion where numeroConsignacion='" & Me.numeroConsignacion & "' and estadoConsignacion=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaValorUtilizado()
        Dim sql As String
        sql = "exec sp_actualizaTTConsignacionValorDisponible " & _
        "@idConsignacion='" & Me.idConsignacion & "'," & _
        "@valorUtilizado='" & Me.valorUtilizadoConsignacion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion mostrar consignacion por idEncfacturaPro
    Function obtenerConsignacionFactura() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTFacturaConsig.idConsignacion," & _
        "TTConsignacion.numeroConsignacion," & _
        "TTConsignacion.valorUtilizadoConsignacion" & _
        " FROM" & _
        " TTFacturaConsig INNER JOIN" & _
        " TTCodConsig ON TTFacturaConsig.idConsignacion = TTCodConsig.idConsignacion INNER JOIN" & _
        " TTConsignacion ON TTCodConsig.idConsignacion = TTConsignacion.idConsignacion" & _
        " where" & _
        " TTFacturaConsig.idEncFacturapro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimeitno para reversar el pago de una consignacion al anular una factura
    Sub reversarPagoConsignacion()
        Dim sql As String
        sql = "exec sp_actualizaTTConsignacionReversaPago " & _
        "@idConsignacion='" & Me.idConsignacion & "'," & _
        "@valorUtilizado='" & Me._valorUtilizadoConsignacion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para devolver las consignaciones pertenecientes a una remision
    Function obtenerConsigancionesPorIdremision() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTConsignacion.idConsignacion," & _
        "TTConsignacion.numeroConsignacion," & _
        "TTConsignacion.valorConsignacion," & _
        "TTConsignacion.valorUtilizadoConsignacion," & _
        "TTFacturaConsig.idFacturaConsig" & _
        " FROM" & _
        " TTFacturaConsig INNER JOIN" & _
        " TTEncFacturaPro ON TTFacturaConsig.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TTConsignacion ON TTFacturaConsig.idConsignacion = TTConsignacion.idConsignacion" & _
        " where TTEncFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procediento para reversar el valor utilizado
    Sub reversarValorUtilizado(ByVal valor As Double)
        Dim sql As String
        sql = "exec sp_actualizattconsignacionReversaValorUtilizado " & _
        "@idConsignacion='" & Me.idConsignacion & "'," & _
        "@valor='" & valor & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    'funcion para obtener los datos de las consignaciones
    Function datosConsignacionesPorNumero() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTConsignacion.idConsignacion," & _
        "TTConsignacion.numeroConsignacion," & _
        "TTConsignacion.fechaConsignacion," & _
        "TTConsignacion.valorConsignacion," & _
        "TTConsignacion.imagenConsignacion," & _
        "TTConsignacion.valorUtilizadoConsignacion," & _
        "TBCuenta.numeroCuenta," & _
        "dbo.TBBanco.idBanco," & _
        "dbo.TBBanco.nombreBanco," & _
        "TBCuenta.idPais" & _
        " FROM" & _
        " TTConsignacion INNER JOIN" & _
        " TBCuenta ON TTConsignacion.idCuenta = TBCuenta.idCuenta INNER JOIN" & _
        " dbo.TBBanco ON TBCuenta.idBanco = dbo.TBBanco.idBanco" & _
        " where TTConsignacion.numeroConsignacion='" & Me.numeroConsignacion & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las consignaciones entre dos fechas
    Function obtenerConsignacionesPorFechas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTConsignacion.idConsignacion," & _
        "TTConsignacion.numeroConsignacion," & _
        "TTConsignacion.fechaConsignacion," & _
        "TTConsignacion.valorConsignacion," & _
        "TTConsignacion.valorUtilizadoConsignacion," & _
        "TBCuenta.idCuenta," & _
        "TBCuenta.numeroCuenta," & _
        "dbo.TBBanco.idBanco," & _
        "dbo.TBBanco.nombreBanco," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TTConsignacion INNER JOIN" & _
        " TBCuenta ON TTConsignacion.idCuenta = TBCuenta.idCuenta INNER JOIN" & _
        " dbo.TBBanco ON TBCuenta.idBanco = dbo.TBBanco.idBanco INNER JOIN" & _
        " dbo.TBpais ON dbo.TBBanco.idPais = dbo.TBpais.codigoPais" & _
        " where TTConsignacion.fechaConsignacion between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' order by TTConsignacion.fechaConsignacion"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerConsignacionesPorNumeroConsignacion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTConsignacion.idConsignacion," & _
        "TTConsignacion.numeroConsignacion," & _
        "TTConsignacion.fechaConsignacion," & _
        "TTConsignacion.valorConsignacion," & _
        "TTConsignacion.valorUtilizadoConsignacion," & _
        "TBCuenta.idCuenta," & _
        "TBCuenta.numeroCuenta," & _
        "dbo.TBBanco.idBanco," & _
        "dbo.TBBanco.nombreBanco," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TTConsignacion INNER JOIN" & _
        " TBCuenta ON TTConsignacion.idCuenta = TBCuenta.idCuenta INNER JOIN" & _
        " dbo.TBBanco ON TBCuenta.idBanco = dbo.TBBanco.idBanco INNER JOIN" & _
        " dbo.TBpais ON dbo.TBBanco.idPais = dbo.TBpais.codigoPais" & _
        " where TTConsignacion.numeroConsignacion='" & Me.numeroConsignacion & "' order by TTConsignacion.fechaConsignacion"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
