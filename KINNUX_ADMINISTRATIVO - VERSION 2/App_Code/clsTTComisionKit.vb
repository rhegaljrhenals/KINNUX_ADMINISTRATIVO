Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTComisionKit

    Private _idComisionKit As Integer
    Private _idEmpresa As Integer
    Private _codigoAfiliado As String
    Private _valorComisionKit As Double
    Private _pagoComisionKit As String
    Private _fechaPagoComisionKit As Date
    Private _usuarioPagoComisionKit As Integer
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _idSucursal As Integer
    Private _idPais As Integer
    Dim usuarios As New clsUsuario
    Dim objOperacione As New clsOperacione

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
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

    Public Property idComisionKit As Integer
        Get
            Return _idComisionKit
        End Get
        Set(ByVal value As Integer)
            _idComisionKit = value
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

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property valorComisionKit As Double
        Get
            Return _valorComisionKit
        End Get
        Set(ByVal value As Double)
            _valorComisionKit = value
        End Set
    End Property

    Public Property pagoComisionKit As String
        Get
            Return _pagoComisionKit
        End Get
        Set(ByVal value As String)
            _pagoComisionKit = value
        End Set
    End Property

    Public Property fechaPagoComisionKit As Date
        Get
            Return _fechaPagoComisionKit
        End Get
        Set(ByVal value As Date)
            _fechaPagoComisionKit = value
        End Set
    End Property

    Public Property usuarioPagoComisionKit As Integer
        Get
            Return _usuarioPagoComisionKit
        End Get
        Set(ByVal value As Integer)
            _usuarioPagoComisionKit = value
        End Set
    End Property

    Function obtenerUltimoCodigoKit() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select max(idComisionKit) as ultimoCodigo from TTComisionKit where codigoAfiliado=" & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las comisiones no cobradas
    Function obtenerComisionesNoCobradas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTComisionKit where codigoAfiliado=" & Me.codigoAfiliado & " and pagoComisionKit='No'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' function para obtener la suma de las comisiones no cobradas
    Function obtenerSumaComisionesNoCobradas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select isnull(sum(valorComisionKit),0) as valor from TTComisionKit where codigoAfiliado=" & Me.codigoAfiliado & " and pagoComisionKit='No'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para realizar el pago de las comisiones
    Sub realizaPagosComisiones()
        Dim sql As String
        sql = "exec sp_actualizaTTComisionKitReallizaPago " & _
        "@idComisionKit='" & Me.idComisionKit & "'," & _
        "@usuarioPagoComision='" & Me.usuarioPagoComisionKit & "'," & _
        "@fechaPagoComision='" & Me.fechaPagoComisionKit.ToString("yyyyMMdd") & "'," & _
        "@pagoComision='si'," & _
        "@idEmpresa='" & Me.idEmpresa & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los datos de el encabezado de las comisiones por id
    Function obetenerDatosComisionesporId() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTComisionKit where idComisionKit=" & Me.idComisionKit
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para determinar si el afiliado(patrocinador) tiene comisiones pendientes
    Function obtenerComisionesKitPendientes() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttComisionKit where codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
            " (pagoComisionkit='pe' or pagoComisionKit='no')"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para determinar si el afiliado tiene comisiones pendientes para actualizar el estado
    Function obtenerComisionesPendientesAfiliado() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from ttComisionKit where codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
            " pagoComisionKit='no'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para actualizar el pago de la comision
    Sub actualizapagoComision()
        Dim sql As String
        sql = "exec sp_actualizaTTComisionKitPagoComisionKit " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento para descontar el valor de la comision una vez se anula
    ' una remision
    Sub descuentaValorComision(ByVal valor As Double)
        Dim sql As String
        sql = "exec sp_actualizattComisionKitDescuentaValor " & _
        "@idComisionKit='" & Me.idComisionKit & "'," & _
        "@valor='" & valor & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener las comisiones pagadas
    Function obtenerComisionesPagadasKIT(ByVal tipo As Integer) As DataTable
        Dim sql As String = ""
        Dim tabla As New DataTable
        Select Case tipo
            Case Is = 1
                sql = "SELECT     " & _
                "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
                "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
                "TTComisionKit.idComisionKit, " & _
                "TTComisionKit.valorComisionKit, " & _
                "TTComisionKit.fechaPagoComisionKit, " & _
                "TTComisionKit.usuarioPagoComisionKit, " & _
                "TTComisionKit.pagoComisionKit, " & _
                "TTEncFacturaPro.idEncFacturaPro, " & _
                "TTEncFacturaPro.fechaEncFacturaPro, " & _
                "dbo.TBEmpresa.idEmpresa AS Expr7, " & _
                "dbo.TBEmpresa.nombreEmpresa," & _
                "dbo.TBSucursal.idSucursal," & _
                "dbo.TBSucursal.nombreSucursal," & _
                "TBUsuario.nombreCompletoUsuario" & _
                " FROM" & _
                " TTDetComisionKit INNER JOIN" & _
                " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
                " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
                " TTComisionKit ON TTDetComisionKit.idComisionKit = TTComisionKit.idComisionKit INNER JOIN" & _
                " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
                " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
                " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal AND " & _
                " TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa INNER JOIN" & _
                " TBUsuario ON TTComisionKit.usuarioPagoComisionKit = TBUsuario.idUsuario" & _
                " where TTEncFacturaPro.idEmpresa=" & Me.idEmpresa & " and " & _
                " TTEncFacturaPro.estadoencfacturapro=1 and " & _
                " TTEncFacturaPro.idsucursal=" & Me.idSucursal & " and" & _
                " TTComisionKit.pagoComisionKit='si' and" & _
                " TTEncFacturaPro.fechaencfacturapro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
                " order by TTEncFacturaPro.fechaencfacturapro"
            Case Is = 2
                sql = "SELECT     " & _
                "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
                "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
                "TTComisionKit.idComisionKit, " & _
                "TTComisionKit.valorComisionKit, " & _
                "TTComisionKit.fechaPagoComisionKit, " & _
                "TTComisionKit.usuarioPagoComisionKit, " & _
                "TTComisionKit.pagoComisionKit, " & _
                "TTEncFacturaPro.idEncFacturaPro, " & _
                "TTEncFacturaPro.fechaEncFacturaPro, " & _
                "dbo.TBEmpresa.idEmpresa AS Expr7, " & _
                "dbo.TBEmpresa.nombreEmpresa," & _
                "dbo.TBSucursal.idSucursal," & _
                "dbo.TBSucursal.nombreSucursal" & _
                " FROM" & _
                " TTDetComisionKit INNER JOIN" & _
                " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
                " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
                " TTComisionKit ON TTDetComisionKit.idComisionKit = TTComisionKit.idComisionKit INNER JOIN" & _
                " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
                " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
                " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal AND " & _
                " TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa" & _
                " where TTEncFacturaPro.idEmpresa=" & Me.idEmpresa & " and " & _
                " TTEncFacturaPro.estadoencfacturapro=1 and " & _
                " TTEncFacturaPro.idsucursal=" & Me.idSucursal & " and" & _
                " TTComisionKit.pagoComisionKit='pe' and" & _
                " TTEncFacturaPro.fechaencfacturapro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
                " order by TTEncFacturaPro.fechaencfacturapro"
            Case Is = 3
                sql = "SELECT     " & _
                "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
                "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
                "TTComisionKit.idComisionKit, " & _
                "TTComisionKit.valorComisionKit, " & _
                "TTComisionKit.fechaPagoComisionKit, " & _
                "TTComisionKit.usuarioPagoComisionKit, " & _
                "TTComisionKit.pagoComisionKit, " & _
                "TTEncFacturaPro.idEncFacturaPro, " & _
                "TTEncFacturaPro.fechaEncFacturaPro, " & _
                "dbo.TBEmpresa.idEmpresa AS Expr7, " & _
                "dbo.TBEmpresa.nombreEmpresa," & _
                "dbo.TBSucursal.idSucursal," & _
                "dbo.TBSucursal.nombreSucursal" & _
                " FROM" & _
                " TTDetComisionKit INNER JOIN" & _
                " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
                " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
                " TTComisionKit ON TTDetComisionKit.idComisionKit = TTComisionKit.idComisionKit INNER JOIN" & _
                " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
                " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
                " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal AND " & _
                " TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa" & _
                " where TTEncFacturaPro.idEmpresa=" & Me.idEmpresa & " and " & _
                " TTEncFacturaPro.estadoencfacturapro=1 and " & _
                " TTEncFacturaPro.idsucursal=" & Me.idSucursal & " and" & _
                " TTComisionKit.pagoComisionKit='no' and" & _
                " TTEncFacturaPro.fechaencfacturapro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
                " order by TTEncFacturaPro.fechaencfacturapro"
            Case Is = 4
                sql = "SELECT     " & _
                "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
                "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
                "TTComisionKit.idComisionKit, " & _
                "TTComisionKit.valorComisionKit, " & _
                "TTComisionKit.fechaPagoComisionKit, " & _
                "TTComisionKit.usuarioPagoComisionKit, " & _
                "TTComisionKit.pagoComisionKit, " & _
                "TTEncFacturaPro.idEncFacturaPro, " & _
                "TTEncFacturaPro.fechaEncFacturaPro, " & _
                "dbo.TBEmpresa.idEmpresa AS Expr7, " & _
                "dbo.TBEmpresa.nombreEmpresa," & _
                "dbo.TBSucursal.idSucursal," & _
                "dbo.TBSucursal.nombreSucursal" & _
                " FROM" & _
                " TTDetComisionKit INNER JOIN" & _
                " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
                " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
                " TTComisionKit ON TTDetComisionKit.idComisionKit = TTComisionKit.idComisionKit INNER JOIN" & _
                " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
                " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
                " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal AND " & _
                " TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa" & _
                " where TTEncFacturaPro.idEmpresa=" & Me.idEmpresa & " and " & _
                " TTEncFacturaPro.estadoencfacturapro=1 and " & _
                " TTEncFacturaPro.idsucursal=" & Me.idSucursal & " and" & _
                " TTEncFacturaPro.fechaencfacturapro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
                " order by TTEncFacturaPro.fechaencfacturapro"
        End Select
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el detalle de las comisiones de kit
    Function obtenerDetalleComisionesKirPorAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionKit.idComisionKit, " & _
        "TTComisionKit.valorComisionKit, " & _
        "TTComisionKit.fechaPagoComisionKit, " & _
        "TTComisionKit.usuarioPagoComisionKit, " & _
        "case TTComisionKit.pagoComisionKit" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'no' then 'No Cobrada'" & _
        " when 'si' then 'cancelada'" & _
        " end pagoComisionKit," & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro" & _
        " FROM" & _
        " TTComisionKit INNER JOIN" & _
        " TTDetComisionKit ON TTComisionKit.idComisionKit = TTDetComisionKit.idComisionKit INNER JOIN" & _
        " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliadoCom = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro" & _
        " where TTComisionkit.codigoafiliado = '" & Me.codigoAfiliado & "' and TTEncFacturaPro.estadoencfacturapro=1" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function comisionesKITCuadreCaja() As DataTable
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim y As Integer
        Dim cadena As String = Nothing
        Dim sql As String = ""
        Dim tabla As New DataTable
        With monedaLocal
            .idEmpresa = Me.idEmpresa
            tabla = .obtenerValorMonedaLocalPorEmpresa
            If tabla.Rows.Count <> 0 Then
                valorMoneda = tabla.Rows(0).Item("valorMonedaLocal")
            Else
                valorMoneda = 1
            End If
        End With
        '
        '-------------------------------------------------------------------------------
        ' obtener los id de los usuarios
        With usuarios
            .idPais = Me.idPais
            .idSucursal = Me.idSucursal
            tabla = .obtenerUsuariosPorSucursales
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    cadena += tabla.Rows(y).Item("idUsuario") & ","
                Next
                cadena = Mid(cadena, 1, cadena.Length - 1)
            End If
        End With
        '-------------------------------------------------------------------------------
        sql = "SELECT     " & _
        "TTComisionKit.idComisionKit, " & _
        "TTComisionKit.valorComisionKit * " & valorMoneda & " as valorComisionKit, " & _
        "TTComisionKit.fechaPagoComisionKit, " & _
        "TTComisionKit.usuarioPagoComisionKit, " & _
        "TTComisionKit.pagoComisionKit, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido quiencobro, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro" & _
        " FROM" & _
        " TTComisionKit INNER JOIN" & _
        " TTDetComisionKit ON TTComisionKit.idComisionKit = TTDetComisionKit.idComisionKit INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionKit.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionKit.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionKit.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTComisionKit.usuarioPagoComisionKit = TBUsuario.idUsuario" & _
        " where" & _
        " TBUsuario.idusuario in (" & cadena & ")" & _
        " and TTComisionKit.pagoComisionKit='si' and " & _
        " TTComisionKit.fechaPagoComisionKit between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
