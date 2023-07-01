Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTEncFacturaPro

    Private _idEncFacturaPro As Integer
    Private _fechaEncFacturaPro As Date
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _codigoAfiliado As String
    Private _idEmpresa As Integer
    Private _idSucursal As Integer
    Private _tipoEncFacturaPro As String
    Private _paqueteEncFacturaPro As Integer
    Private _cEnvioEncFacturaPro As Double
    Private _valorCoEncFacturaPro As Double
    Private _valorMlEncFacturaPro As Double
    Private _puntosEncfacturaPro As Double
    Private _fpEfectivoEncFacturaPro As String
    Private _fpConsigEncFacturaPro As String
    Private _fpTarjetaEncFaturaPro As String
    Private _fpCruceEncfacturaPro As String
    Private _fpHotelEncFacturaPro As String
    Private _eliteEncFacturaPro As String
    Private _valorUsEncFacturaPro As Double
    Private _valorEfectivoEncFacturaPro As Double
    Private _valorConsigEncfacturaPro As Double
    Private _valorCruceEncfacturaPro As Double
    Private _valorHotelEncFacturaPro As Double
    Private _guiaEncFacturaPro As String
    Private _procesadoEncFacturaPro As String
    Private _pertenececiclo As String
    Private _estadoEncfacturaPro As Integer
    Private _mesFactura As Integer
    Private _anoFactura As Integer
    Private _idUsuario As Integer
    Dim objOperacione As New clsOperacione

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property mesFactura As Integer
        Get
            Return _mesFactura
        End Get
        Set(ByVal value As Integer)
            _mesFactura = value
        End Set
    End Property

    Public Property anoFactura As Integer
        Get
            Return _anoFactura
        End Get
        Set(ByVal value As Integer)
            _anoFactura = value
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


    Public Property fechaEncFacturaPro As Date
        Get
            Return _fechaEncFacturaPro
        End Get
        Set(ByVal value As Date)
            _fechaEncFacturaPro = value
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

    Public Property pertenececiclo As String
        Get
            Return _pertenececiclo
        End Get
        Set(ByVal value As String)
            _pertenececiclo = value
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

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property

    Public Property tipoEncFacturaPro As String
        Get
            Return _tipoEncFacturaPro
        End Get
        Set(ByVal value As String)
            _tipoEncFacturaPro = value
        End Set
    End Property

    Public Property paqueteEncFacturaPro As Integer
        Get
            Return _paqueteEncFacturaPro
        End Get
        Set(ByVal value As Integer)
            _paqueteEncFacturaPro = value
        End Set
    End Property

    Public Property cEnvioEncFacturaPro As Double
        Get
            Return _cEnvioEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _cEnvioEncFacturaPro = value
        End Set
    End Property

    Public Property valorCoEncFacturaPro As Double
        Get
            Return _valorCoEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorCoEncFacturaPro = value
        End Set
    End Property

    Public Property valorMlEncFacturaPro As Double
        Get
            Return _valorMlEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorMlEncFacturaPro = value
        End Set
    End Property

    Public Property puntosEncfacturaPro As Double
        Get
            Return _puntosEncfacturaPro
        End Get
        Set(ByVal value As Double)
            _puntosEncfacturaPro = value
        End Set
    End Property

    Public Property fpEfectivoEncFacturaPro As String
        Get
            Return _fpEfectivoEncFacturaPro
        End Get
        Set(ByVal value As String)
            _fpEfectivoEncFacturaPro = value
        End Set
    End Property

    Public Property fpConsigEncFacturaPro As String
        Get
            Return _fpConsigEncFacturaPro
        End Get
        Set(ByVal value As String)
            _fpConsigEncFacturaPro = value
        End Set
    End Property

    Public Property fpTarjetaEncFaturaPro As String
        Get
            Return _fpTarjetaEncFaturaPro
        End Get
        Set(ByVal value As String)
            _fpTarjetaEncFaturaPro = value
        End Set
    End Property

    Public Property fpCruceEncfacturaPro As String
        Get
            Return _fpCruceEncfacturaPro
        End Get
        Set(ByVal value As String)
            _fpCruceEncfacturaPro = value
        End Set
    End Property

    Public Property fpHotelEncFacturaPro As String
        Get
            Return _fpHotelEncFacturaPro
        End Get
        Set(ByVal value As String)
            _fpHotelEncFacturaPro = value
        End Set
    End Property

    Public Property eliteEncFacturaPro As String
        Get
            Return _eliteEncFacturaPro
        End Get
        Set(ByVal value As String)
            _eliteEncFacturaPro = value
        End Set
    End Property

    Public Property valorUsEncFacturaPro As Double
        Get
            Return _valorUsEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorUsEncFacturaPro = value
        End Set
    End Property

    Public Property valorEfectivoEncFacturaPro As Double
        Get
            Return _valorEfectivoEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorEfectivoEncFacturaPro = value
        End Set
    End Property

    Public Property valorConsigEncfacturaPro As Double
        Get
            Return _valorConsigEncfacturaPro
        End Get
        Set(ByVal value As Double)
            _valorConsigEncfacturaPro = value
        End Set
    End Property

    Public Property valorCruceEncfacturaPro As Double
        Get
            Return _valorCruceEncfacturaPro
        End Get
        Set(ByVal value As Double)
            _valorCruceEncfacturaPro = value
        End Set
    End Property

    Public Property valorHotelEncFacturaPro As Double
        Get
            Return _valorHotelEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorHotelEncFacturaPro = value
        End Set
    End Property

    Public Property guiaEncFacturaPro As String
        Get
            Return _guiaEncFacturaPro
        End Get
        Set(ByVal value As String)
            _guiaEncFacturaPro = value
        End Set
    End Property

    Public Property procesadoEncFacturaPro As String
        Get
            Return _procesadoEncFacturaPro
        End Get
        Set(ByVal value As String)
            _procesadoEncFacturaPro = value
        End Set
    End Property

    Public Property estadoEncfacturaPro As Integer
        Get
            Return _estadoEncfacturaPro
        End Get
        Set(ByVal value As Integer)
            _estadoEncfacturaPro = value
        End Set
    End Property

    Function obtenerUltimaFacturaPorCodigoAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select max(idEncFacturaPro) as numFactura from TTEncFacturaPro" & _
            " where codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosEncabezadoFacturaPorIdEncabezado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTEncFacturaPro" & _
            " where idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerFacturaUnidades() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "exec sp_rep_facturacionEstandar " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' reportes
    Function obtenerFacturacion(ByVal tipo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "TTEncFacturaPro.tipoEncFacturaPro, " & _
        "TTEncFacturaPro.puntosEncfacturaPro, " & _
        "TTEncFacturaPro.valorEfectivoEncFacturaPro," & _
        "TTEncFacturaPro.procesadoEncFacturaPro, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        " case TTEncFacturaPro.estadoEncfacturaPro" & _
        " when 1 then 'Activo'" & _
        " when 2 then 'Anulado'" & _
        " end estado" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa"
        Select Case tipo
            Case Is = 1
                sql = sql & " where TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'"
            Case Is = 2
                sql = sql & " where TTEncFacturaPro.estadoEncfacturaPro=1"
            Case Is = 3
                sql = sql & " where TTEncFacturaPro.estadoEncfacturaPro=0"
            Case Is = 4
                sql = sql & " where TTEncFacturaPro.idEmpresa=" & Me.idEmpresa
        End Select
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el encabezado de la facrura para anular
    Function obtenerDatosEncabezadoRemision() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal, " & _
        "dbo.TBSucursal.nombreSucursal, " & _
        "case TTEncFacturaPro.tipoEncFacturaPro" & _
        " when 'KI' then 'Kit De Afiliación'" & _
        " when 'UN' then 'Unidades'" & _
        " when 'PA' then 'Paquete'" & _
        " when 'PE' then 'Personalizada'" & _
        " when 'EL' then 'Elite'" & _
        " when 'CM' then 'Compra Mensual'" & _
        " when 'RE' then 'RECOMPRA'" & _
        " ELSE ''" & _
        " end tipoEncFacturaPro," & _
        " TTEncFacturaPro.paqueteEncFacturaPro," & _
        " TTEncFacturaPro.numtsEncFacturaPro," & _
        " TTEncFacturaPro.valorCoEncFacturaPro," & _
        " TTEncFacturaPro.valorMlEncFacturaPro," & _
        " TTEncFacturaPro.puntosEncfacturaPro," & _
        " TTEncFacturaPro.fpEfectivoEncFacturaPro," & _
        " TTEncFacturaPro.fpCruceEncFacturaPro," & _
        " TTEncFacturaPro.fpTarjetaEncFaturaPro," & _
        " TTEncFacturaPro.fpConsigEncFacturaPro," & _
        " TTEncFacturaPro.fpHotelEncFacturaPro," & _
        " TTEncFacturaPro.eliteEncFacturaPro," & _
        " TTEncFacturaPro.valorUsEncFacturaPro," & _
        " TTEncFacturaPro.valorEfectivoEncFacturaPro," & _
        " TTEncFacturaPro.valorConsigEncfacturaPro," & _
        " TTEncFacturaPro.valorCruceEncfacturaPro," & _
        " TTEncFacturaPro.valorHotelEncFacturaPro," & _
        " TTEncFacturaPro.estadoEncfacturaPro," & _
        " TTEncFacturaPro.valorAbonoEncFacturaPun," & _
        " TTEncFacturaPro.estadoEncFacturaPro," & _
        " TBUsuario.nombreCompletoUsuario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTEncFacturaPro ON dbo.Afiliaciones.codigoAfiliado = TTEncFacturaPro.codigoAfiliado INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTLogFactura.idusuario = TBUsuario.idUsuario" & _
        " where TTEncFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para anular facturas
    Sub AnularFacturas()
        Dim sql As String
        sql = "exec sp_actualizaTTEncFacturaProAnulaFactura " & _
        "@idEncFacturaPro='" & Me.idEncFacturaPro & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener el encabezado por empresas
    Function obtenerDatosEncabezadoPorEmpresas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from vw_encabezadoFacturas2019" & _
        " where fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " and estadoEncfacturaPro=1 and valorCoEncFacturaPro<>0"

        'sql = "SELECT " & _
        '"'(' + TTEncFacturaPro.codigoafiliado +') ' + dbo.Afiliaciones.Pnombre + ' '  + dbo.Afiliaciones.Snombre +  ' ' +  dbo.Afiliaciones.Papellido  +  ' ' +  dbo.Afiliaciones.sapellido as nombres," & _
        '"TTEncFacturaPro.idEncFacturaPro, " & _
        '"TTEncFacturaPro.fechaEncFacturaPro, " & _
        '"TTEncFacturaPro.idEmpresa, " & _
        '"TTEncFacturaPro.idSucursal, " & _
        '"dbo.TBEmpresa.nombreEmpresa, " & _
        '"dbo.TBSucursal.nombreSucursal, " & _
        '"case TTEncFacturaPro.tipoEncFacturaPro" & _
        '" when 'KI' then 'KIT'" & _
        '" when 'UN' then 'UNI'" & _
        '" when 'PA' then 'PAQ'" & _
        '" when 'PE' then 'PER'" & _
        '" when 'EL' then 'ELI'" & _
        '" when 'CM' then 'CME'" & _
        '" when 'RE' then 'RE'" & _
        '" else ''" & _
        '" end tipoEncFacturaPro, " & _
        '" TTEncFacturaPro.valorEfectivoEncFacturaPro, " & _
        '" TTEncFacturaPro.valorConsigEncFacturaPro, " & _
        '" TTEncFacturaPro.valorUsEncFacturaPro, " & _
        '" TTEncFacturaPro.valorCruceEncFacturaPro, " & _
        '" TTEncFacturaPro.valorHotelEncFacturaPro, " & _
        '" TTEncFacturaPro.valorAbonoEncFacturaPun, " & _
        '" TTEncFacturaPro.valorCoEncFacturaPro, " & _
        '" TTEncFacturaPro.puntosEncfacturaPro, " & _
        '" TTEncFacturaPro.numtsEncFacturapro, " & _
        '" TTEncFacturaPro.stsencfacturapro, " & _
        '" TBUsuario.nombreCompletoUsuario, " & _
        '" case TTEncFacturaPro.estadoEncFacturaPro" & _
        '" when 1 then 'Activo'" & _
        '" when 0 then 'Anulado'" & _
        '" end estadoEncFacturaPro" & _
        '" FROM" & _
        '" dbo.Afiliaciones INNER JOIN" & _
        '" TTEncFacturaPro ON dbo.Afiliaciones.codigoAfiliado = TTEncFacturaPro.codigoAfiliado INNER JOIN" & _
        '" dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        '" dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        '" TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro INNER JOIN" & _
        '" TBUsuario ON TTLogFactura.idusuario = TBUsuario.idUsuario" & _
        '" where TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and TTEncFacturaPro.pertenececiclo='s'" & _
        '" and TTEncFacturaPro.estadoEncfacturaPro=" & Me.estadoEncfacturaPro '& " and TTEncFacturaPro.valorCoEncFacturaPro<>0"
        If Me.idEmpresa = 0 Then
            sql = sql
        Else
            sql = sql & " and idempresa=" & Me.idEmpresa
        End If
        ' sucursales
        If Me.idSucursal = 0 Then
            sql = sql
        Else
            sql = sql & " and idsucursal=" & Me.idSucursal
        End If
        sql = sql & " order by fechaEncFacturaPro,nombreEmpresa,nombreSucursal"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el encabezado por empresas
    Function obtenerTotalesPorEmpresas() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "count(*) as numero," & _
        " isnull(sum(TTEncFacturaPro.valorCoEncFacturaPro),0) as valor, " & _
        " isnull(sum(TTEncFacturaPro.puntosEncfacturaPro),0) as puntos " & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " dbo.Afiliaciones ON TTEncFacturaPro.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and TTEncFacturaPro.estadoEncfacturaPro=" & Me.estadoEncfacturaPro
        If Me.idEmpresa = 0 Then
            sql = sql
        Else
            sql = sql & " and dbo.TBEmpresa.idempresa=" & Me.idEmpresa
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el encabezado por codigo afiliado
    Function obtenerDatosEncabezadoRemisionPorCodigoAfiliado() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal, " & _
        "dbo.TBSucursal.nombreSucursal, " & _
        "TTEncFacturaPro.numtsEncFacturaPro, " & _
        "TTEncFacturaPro.stsEncFacturaPro, " & _
        "case TTEncFacturaPro.tipoEncFacturaPro" & _
        " when 'KI' then 'Kit De Afiliación'" & _
        " when 'UN' then 'Unidades'" & _
        " when 'PA' then 'Paquete'" & _
        " when 'PE' then 'Personalizada'" & _
        " when 'EL' then 'Elite'" & _
        " when 'CM' then 'Compra Mensual'" & _
        " else ''" & _
        " end tipoEncFacturaPro," & _
        " TTEncFacturaPro.paqueteEncFacturaPro," & _
        " TTEncFacturaPro.valorCoEncFacturaPro," & _
        " TTEncFacturaPro.valorMlEncFacturaPro," & _
        " TTEncFacturaPro.puntosEncfacturaPro," & _
        " TTEncFacturaPro.fpEfectivoEncFacturaPro," & _
        " TTEncFacturaPro.fpCruceEncFacturaPro," & _
        " TTEncFacturaPro.fpTarjetaEncFaturaPro," & _
        " TTEncFacturaPro.fpConsigEncFacturaPro," & _
        " TTEncFacturaPro.fpHotelEncFacturaPro," & _
        " TTEncFacturaPro.eliteEncFacturaPro," & _
        " TTEncFacturaPro.numTsEncFacturaPro," & _
        " TTEncFacturaPro.sTsEncFacturaPro," & _
        " TTEncFacturaPro.eliteEncFacturaPro," & _
        " TTEncFacturaPro.valorUsEncFacturaPro," & _
        " TTEncFacturaPro.valorEfectivoEncFacturaPro," & _
        " TTEncFacturaPro.valorConsigEncfacturaPro," & _
        " TTEncFacturaPro.valorCruceEncfacturaPro," & _
        " TTEncFacturaPro.valorHotelEncFacturaPro," & _
        " TTEncFacturaPro.valorAbonoEncFacturaPun," & _
        " case TTEncFacturaPro.estadoEncfacturaPro" & _
        " when 1 then 'Activa'" & _
        " when 0 then 'Anulada'" & _
        " end estadoEncfacturaPro," & _
        " TBUsuario.nombreCompletoUsuario," & _
        " '' nombrePaquete," & _
        " year(TTEncFacturaPro.fechaEncFacturaPro) as ano, " & _
        " case month(TTEncFacturaPro.fechaEncFacturaPro)" & _
        " when '01' then 'Enero'" & _
        " when '02' then 'Febrero'" & _
        " when '03' then 'Marzo'" & _
        " when '04' then 'Abril'" & _
        " when '05' then 'Mayo'" & _
        " when '06' then 'Junio'" & _
        " when '07' then 'Julio'" & _
        " when '08' then 'Agosto'" & _
        " when '09' then 'Septiembre'" & _
        " when '10' then 'Octubre'" & _
        " when '11' then 'Noviembre'" & _
        " when '12' then 'Diciembre'" & _
        " end mes" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTEncFacturaPro ON dbo.Afiliaciones.codigoAfiliado = TTEncFacturaPro.codigoAfiliado INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTLogFactura.idusuario = TBUsuario.idUsuario" & _
        " where dbo.Afiliaciones.codigoAfiliado='" & Me.codigoAfiliado & "'" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para sumar los puntos por mes y año
    Function sumarPuntosPorAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select isnull(sum(puntosEncFacturaPro),0) as suma from ttencFacturaPro" & _
            " where codigoafiliado='" & Me.codigoAfiliado & "' and" & _
            " month(fechaEncFacturaPro)=" & Me.mesFactura & " and" & _
            " year(fechaEncFacturaPro)=" & Me.anoFactura & " and estadoEncFacturapro=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion detalle de productos facturados
    Function obtenerDetalleProductosFacturados(ByVal idProducto As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad, " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & " ' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTEncFacturaPro.estadoEncFacturaPro = 1 And" & _
        " TBProducto.idProducto = " & idProducto & " And" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa & _
        " and TTEncFacturaPro.idsucursal = " & Me.idSucursal & _
        " Group by" & _
        " TTEncFacturaPro.idEncFacturaPro," & _
        " TTEncFacturaPro.fechaEncFacturaPro," & _
        " TBProducto.idProducto," & _
        " TBProducto.nombreProducto" & _
        " having(sum(TTDetFacturaPro.cantidadDetFacturaPro) > 0)" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los productos facturados
    Function obtenerProductosFacturados() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto," & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad " & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa & _
        " and TTEncFacturaPro.idsucursal = " & Me.idSucursal & _
        " group by TBProducto.idProducto, " & _
        " TBProducto.nombreProducto"
        '" order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los productos facturados estadisticas generales
    Function obtenerProductosFacturadosEstadisticas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto," & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad " & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa
        If Me.idSucursal <> 0 Then
            sql = sql & " and TTEncFacturaPro.idsucursal = " & Me.idSucursal
        End If
        sql = sql & " group by TBProducto.idProducto, " & _
        " TBProducto.nombreProducto" & _
        " order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los tipos de facturacion estadisticas generales
    Function obtenerTiposDeFacturacionEstadisticas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "case tipoEncfacturapro" & _
        " when 'KI' then 'KIT'" & _
        " when 'UN' then 'UNIDADES'" & _
        " when 'PA' then 'PAQUETES'" & _
        " when 'PE' then 'PERSONALIZADA'" & _
        " when 'EL' then 'ELITE'" & _
        " when 'CM' then 'COMPRA MENSUAL'" & _
        " end tipoEncfacturapro," & _
        " count(*) as cantidad" & _
        " from ttencfacturapro" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa
        If Me.idSucursal <> 0 Then
            sql = sql & " and TTEncFacturaPro.idsucursal = " & Me.idSucursal
        End If
        sql = sql & " group by tipoEncfacturapro " & _
        " order by tipoEncfacturapro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los paquetes facturados estadisticas generales
    Function obtenerPaquetesFacturadosEstadisticas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete," & _
        "count(*) as cantidad" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TTEncFacturaPro ON TBPaquete.idPaquete = TTEncFacturaPro.paqueteEncFacturaPro" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa
        If Me.idSucursal <> 0 Then
            sql = sql & " and TTEncFacturaPro.idsucursal = " & Me.idSucursal
        End If
        sql = sql & " group by TBPaquete.idPaquete," & _
        " TBPaquete.nombrePaquete" & _
        " order by TBPaquete.nombrePaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los paquetes facturados estadisticas generales
    Function obtenerPuntosAnuales(ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "exec sp_sumaPuntosPorEmpresas " & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@anoActual='" & ano & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los puntos de las sucursales estadisticas PV anual
    Function obtenerPVestadisticasSucursales(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "isnull(sum(puntosencfacturapro),0) as puntos" & _
        " from ttencfacturapro" & _
        " where" & _
        " Month(fechaEncFacturaPro) = " & mes & " And" & _
        " Year(fechaEncFacturaPro) = " & ano & " And " & _
        " estadoEncfacturaPro = 1 And" & _
        " idEmpresa = " & Me.idEmpresa & " And" & _
        " idSucursal = " & Me.idSucursal
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los puntos de las empresas estadisticas PV anual
    Function obtenerPVestadisticasEmpresas(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "isnull(sum(puntosencfacturapro),0) as puntos" & _
        " from ttencfacturapro" & _
        " where" & _
        " Month(fechaEncFacturaPro) = " & mes & " And" & _
        " Year(fechaEncFacturaPro) = " & ano & " And " & _
        " estadoEncfacturaPro = 1 And" & _
        " idEmpresa = " & Me.idEmpresa
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPuntosMensualesPorSucursales(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "isnull(sum(TTEncFacturaPro.puntosEncfacturaPro),0) as puntos, " & _
        "dbo.TBSucursal.nombreSucursal," & _
        "dbo.TBEmpresa.nombreEmpresa" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where Month(fechaEncFacturaPro) = " & mes & " And" & _
        " Year(fechaEncFacturaPro) = " & ano & " And" & _
        " ttencfacturapro.estadoencfacturapro = 1" & _
        " Group by" & _
        " dbo.TBSucursal.nombreSucursal," & _
        " dbo.TBEmpresa.nombreEmpresa" & _
        " having sum(TTEncFacturaPro.puntosEncfacturaPro)<>0 order by puntos desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPuntosAnualesPorEmpresas(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "isnull(sum(TTEncFacturaPro.puntosEncfacturaPro),0) as puntos" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa" & _
        " where Month(fechaEncFacturaPro) = " & mes & " And" & _
        " Year(fechaEncFacturaPro) = " & ano & " And" & _
        " ttencfacturapro.estadoencfacturapro = 1" & _
        " Group by" & _
        " dbo.TBEmpresa.nombreEmpresa"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function sumaPuntosAnualesPorMes(ByVal anoActual As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_sumaPuntosAnualesPorMes '" & anoActual & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los productos facturados por usuarios
    Function obtenerProductosFacturadosPorusuarios() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN" & _
        " TTEncFacturaPro ON TTDetFacturaPro.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro" & _
        " where" & _
        " TTLogFactura.idusuario=" & Me.idUsuario & " and" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa & _
        " and TTEncFacturaPro.idsucursal = " & Me.idSucursal & _
        " group by TBProducto.idProducto, " & _
        " TBProducto.nombreProducto" & _
        " order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los productos facturados remisiones KIT por usuarios
    Function obtenerProductosFacturadosRemisionesKIT() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN" & _
        " TTEncFacturaPro ON TTDetFacturaPro.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " and TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa & _
        " and TTEncFacturaPro.idsucursal = " & Me.idSucursal & _
        " and TTEncFacturaPro.tipoEncFacturapro='KI'" & _
        " group by TBProducto.idProducto, " & _
        " TBProducto.nombreProducto" & _
        " order by TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function RemisionesCuadreDeCaja() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "'(' + TTEncFacturaPro.codigoafiliado +') ' + dbo.Afiliaciones.Pnombre + ' ' +  dbo.Afiliaciones.Papellido as nombres," & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "TTEncFacturaPro.idEmpresa, " & _
        "TTEncFacturaPro.idSucursal, " & _
        "dbo.TBEmpresa.nombreEmpresa, " & _
        "dbo.TBSucursal.nombreSucursal, " & _
        "case TTEncFacturaPro.tipoEncFacturaPro" & _
        " when 'KI' then 'KIT'" & _
        " when 'UN' then 'UNI'" & _
        " when 'PA' then 'PAQ'" & _
        " when 'PE' then 'PER'" & _
        " when 'EL' then 'ELI'" & _
        " when 'CM' then 'CME'" & _
        " end tipoEncFacturaPro, " & _
        " TTEncFacturaPro.valorEfectivoEncFacturaPro, " & _
        " TTEncFacturaPro.valorConsigEncFacturaPro, " & _
        " TTEncFacturaPro.valorUsEncFacturaPro, " & _
        " TTEncFacturaPro.valorCruceEncFacturaPro, " & _
        " TTEncFacturaPro.valorHotelEncFacturaPro, " & _
        " TTEncFacturaPro.valorAbonoEncFacturaPun, " & _
        " TTEncFacturaPro.valorCoEncFacturaPro, " & _
        " TTEncFacturaPro.puntosEncfacturaPro, " & _
        " TBUsuario.nombreCompletoUsuario, " & _
        " case TTEncFacturaPro.estadoEncFacturaPro" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Anulado'" & _
        " end estadoEncFacturaPro" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTEncFacturaPro ON dbo.Afiliaciones.codigoAfiliado = TTEncFacturaPro.codigoAfiliado INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTLogFactura.idusuario = TBUsuario.idUsuario" & _
        " where" & _
        " TTEncFacturaPro.idEmpresa=" & Me.idEmpresa & " and" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTEncFacturaPro.estadoEncFacturaPro=1 and" & _
        " TTEncFacturaPro.idSucursal=" & Me.idSucursal & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion detalle de productos facturados por usuarios
    Function obtenerDetalleProductosFacturadosPorUsuarios(ByVal idProducto As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "sum(TTDetFacturaPro.cantidadDetFacturaPro) as cantidad, " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " TTDetFacturaPro ON TTEncFacturaPro.idEncFacturaPro = TTDetFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro" & _
        " where" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & " ' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTEncFacturaPro.estadoEncFacturaPro = 1 And" & _
        " TBProducto.idProducto = " & idProducto & " And" & _
        " TTEncFacturaPro.idempresa = " & Me.idEmpresa & _
        " and TTEncFacturaPro.idsucursal = " & Me.idSucursal & _
        " and TTLogFactura.idusuario = " & Me.idUsuario & _
        " Group by" & _
        " TTEncFacturaPro.idEncFacturaPro," & _
        " TTEncFacturaPro.fechaEncFacturaPro," & _
        " TBProducto.idProducto," & _
        " TBProducto.nombreProducto" & _
        " having(sum(TTDetFacturaPro.cantidadDetFacturaPro) > 0)" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las consignaciones de colombia en un rango de fecha
    Function obtenerConsignacionesColombia() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.Afiliaciones.codigoafiliado," & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.Afiliaciones.direccion," & _
        "dbo.Afiliaciones.telefono," & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "TTConsignacion.numeroConsignacion,TTConsignacion.valorConsignacion" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio INNER JOIN" & _
        " TTEncFacturaPro ON dbo.Afiliaciones.codigoAfiliado = TTEncFacturaPro.codigoAfiliado INNER JOIN" & _
        " TTFacturaConsig ON TTEncFacturaPro.idEncFacturaPro = TTFacturaConsig.idEncFacturaPro INNER JOIN" & _
        " TTConsignacion ON TTFacturaConsig.idConsignacion = TTConsignacion.idConsignacion" & _
        " where TTEncFacturaPro.estadoEncFacturapro=1 and" & _
        " TTEncFacturaPro.fpconsigencfacturapro='S' and" & _
        " TTEncFacturaPro.idEmpresa=15 and" & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial & "' and '" & Me.fechaFinal & "'" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
