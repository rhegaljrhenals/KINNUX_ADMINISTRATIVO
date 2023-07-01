Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTComisionIr

    Private _idComisionIr As Integer
    Private _codigoAfiliado As String
    Private _valorComisionIr As Double
    Private _pagoComisionIr As String
    Private _fechaPagoComisionIr As Date
    Private _usuarioPagoComisioIr As Integer
    Private _idEncfacturaPro As Integer
    Private _accion As Integer
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _idEmpresa As Integer
    Private _idPais As Integer
    Private _idSucursal As Integer
    Dim objOperacione As New clsOperacione
    Dim usuarios As New clsUsuario

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

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
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


    Public Property idEncfacturaPro As Integer
        Get
            Return _idEncfacturaPro
        End Get
        Set(ByVal value As Integer)
            _idEncfacturaPro = value
        End Set
    End Property

    Public Property idComisionIr As Integer
        Get
            Return _idComisionIr
        End Get
        Set(ByVal value As Integer)
            _idComisionIr = value
        End Set
    End Property

    Public Property accion As Integer
        Get
            Return _accion
        End Get
        Set(ByVal value As Integer)
            _accion = value
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

    Public Property valorComisionIr As Double
        Get
            Return _valorComisionIr
        End Get
        Set(ByVal value As Double)
            _valorComisionIr = value
        End Set
    End Property

    Public Property pagoComisionIr As String
        Get
            Return _pagoComisionIr
        End Get
        Set(ByVal value As String)
            _pagoComisionIr = value
        End Set
    End Property

    Public Property fechaPagoComisionIr As Date
        Get
            Return _fechaPagoComisionIr
        End Get
        Set(ByVal value As Date)
            _fechaPagoComisionIr = value
        End Set
    End Property

    Public Property usuarioPagoComisioIr As Integer
        Get
            Return _usuarioPagoComisioIr
        End Get
        Set(ByVal value As Integer)
            _usuarioPagoComisioIr = value
        End Set
    End Property

    Sub grabarTTComisionIr()
        Dim sql As String
        sql = "exec sp_actualizaTTComisionIr " & _
        "@idComisionIr='" & Me.idComisionIr & "'," & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'," & _
        "@valorComisionIr='" & Me.valorComisionIr & "'," & _
        "@pagoComisionIr='" & Me.pagoComisionIr & "'," & _
        "@fechaPagoComisionIr='" & Me.fechaPagoComisionIr.ToString("yyyyMMdd") & "'," & _
        "@usuarioPagoComisioIr='" & Me.usuarioPagoComisioIr & "'," & _
        "@accion='" & Me.accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener el ultimo codigo generado
    Function obtenerUltimoCodigogenerado() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select max(idComisionIR) as numero from TTComisionIr where codigoAfiliado=" & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimeinto para actualizar las comisiones pendientes
    Sub actualizaComisionesPendientes()
        Dim sql As String
        sql = "exec sp_actualizaTTComisionIrPendiente " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para validar si el patrocinador tiene comisiones pendientes
    Function validaSiTieneComisionesPendientes() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select count(*) as cantidad from ttComisionIr where codigoAfiliado='" & Me.codigoAfiliado & "' and (pagoComisionIr='pe' or pagoComisionIr='no')"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las comisiones de inicio rapido por codigoAfiliado
    Function obtenerComisionesIRporCodigoAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttComisionIr" & _
            " where codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
            " pagoComisionIr='no'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener la suma de las comisiones de IR por codigo del afiliado
    Function obtenerSumaComisionesIR() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select isnull(sum(valorComisionIr),0) as total from ttComisionIr" & _
        " where codigoAfiliado='" & Me.codigoAfiliado & "' and" & _
        " pagoComisionIr='no'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'procedimiento para realizar el pago de las comisiones de IR
    Sub actualizaPagoComisionesIr()
        Dim sql As String
        sql = "exec sp_actualizaTTComisionIrRealizaPago " & _
        "@idComisionIr='" & Me.idComisionIr & "'," & _
        "@usuarioPagoComision='" & Me.usuarioPagoComisioIr & "'," & _
        "@fechaPagoComision='" & Me.fechaPagoComisionIr.ToString("yyyy/MM/dd") & "'," & _
        "@pagoComision='" & Me.pagoComisionIr & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener la comision de IR por idComision
    Function obtenerComisionIRporIdComision() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttComisionIr where idComisionIr=" & Me.idComisionIr
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'procedimiento para actualizar el pago de la comision cuando se anula una factura
    Sub actualizaValorComision()
        Dim sql As String
        sql = "exec sp_actualizattComisionIrValorComisionIr " & _
        "@idComisionIr='" & Me.idComisionIr & "'," & _
        "@valorComisonIr='" & Me.valorComisionIr & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' procedimiento para reversar el pago de la comision IR
    Sub reversarPagoComisionIR()
        Dim sql As String
        sql = "exec sp_reversarPagoComisionIR " & _
        "@idencfacturapro='" & Me.idEncfacturaPro & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener las comisiones pagadas
    Function obtenerComisionesPagadasIR(ByVal codigoPais As Integer, ByVal tipo As Integer, ByVal codigo As String) As DataTable
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.nombreMunicipio, " & _
        "TTDetComisionIr.valorComisonIr, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro," & _
        " case TTComisionIr.pagoComisionIr" & _
        " when 'si' then 'Pagada'" & _
        " when 'no' then 'No Cobrada'" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'co' then 'Comprimida'" & _
        " end pagoComisionIr," & _
        " TTComisionIr.fechaPagoComisionIr" & _
        " FROM" & _
        " TTDetComisionIr INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionIr.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionIr.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais INNER JOIN" & _
        " dbo.Afiliaciones ON dbo.TBpais.codigoPais = dbo.Afiliaciones.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio ON" & _
        " TTDetComisionIr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " TTComisionIr ON TTDetComisionIr.idComisonIr = TTComisionIr.idComisionIr" & _
        " where " & _
        " TTEncFacturaPro.fechaEncFacturaPro between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and TTEncFacturaPro.estadoEncFacturaPro='1' and" & _
        " TTEncFacturaPro.idempresa=" & Me.idEmpresa

        Select Case tipo
            Case Is = 1
                sql = sql & " and TTComisionIr.pagoComisionIr='si'"
            Case Is = 2
                sql = sql & " and (TTComisionIr.pagoComisionIr='pe' or TTComisionIr.pagoComisionIr='co')"
            Case Is = 3
                sql = sql & " and TTComisionIr.pagoComisionIr='no'"
            Case Is = 4
                sql = sql
        End Select
        sql = sql & " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el detalle de las comisiones por afiliados
    Function obtenerDetalleComisionesPorAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT    " & _
        "TTComisionIr.idComisionIr, " & _
        "TTComisionIr.valorComisionIr, " & _
        "case TTComisionIr.pagoComisionIr" & _
        " when 'no' then 'No Cobrada'" & _
        " when 'si' then 'Cancelada'" & _
        " when 'pe' then 'Pendiente'" & _
        " end  pagoComisionIr," & _
        "TTComisionIr.fechaPagoComisionIr, " & _
        "TTComisionIr.usuarioPagoComisioIr, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTDetComisionIr ON dbo.Afiliaciones.codigoAfiliado = TTDetComisionIr.codigoAfiliadoCom INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionIr.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TTComisionIr ON TTDetComisionIr.idComisonIr = TTComisionIr.idComisionIr" & _
        " where TTComisionIr.codigoafiliado = '" & Me.codigoAfiliado & "' and TTEncFacturaPro.estadoencfacturapro=1" & _
        " order by TTEncFacturaPro.fechaEncFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetalleComisionPorRemision() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTComisionIr.idComisionIr, " & _
        "TTComisionIr.valorComisionIr, " & _
        "TTComisionIr.fechaPagoComisionIr, " & _
        " case TTComisionIr.pagoComisionIr " & _
        " when 'no' then 'Sin Cobrar'" & _
        " when 'pe' then 'Pendiente'" & _
        " when 'si' then 'Cobrada'" & _
        " when 'co' then 'Comprimida'" & _
        " end pagoComisionIr," & _
        "TTComisionIr.usuarioPagoComisioIr, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido nombres" & _
        " FROM" & _
        " TTDetComisionIr INNER JOIN" & _
        " TTComisionIr ON TTDetComisionIr.idComisonIr = TTComisionIr.idComisionIr INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionIr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where" & _
        " TTDetComisionIr.idencfacturapro = " & Me.idEncfacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las comisiones pagadas
    Function comisionesIRCuadreCaja() As DataTable
        Dim monedaLocal As New clsTbMonedaLocal
        Dim y As Integer
        Dim cadena As String = Nothing
        Dim valorMoneda As Double
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
        "TTComisionIr.idComisionIr, " & _
        "TTComisionIr.valorComisionIr * " & valorMoneda & " as valorComisionIr, " & _
        "TTComisionIr.pagoComisionIr, " & _
        "TTComisionIr.fechaPagoComisionIr, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as quiencobro, " & _
        "'(' + Afiliaciones_1.codigoAfiliado + ') ' + Afiliaciones_1.Pnombre + ' ' + Afiliaciones_1.Snombre + ' ' + Afiliaciones_1.Papellido + ' ' + Afiliaciones_1.Sapellido AS quiencompro, " & _
        "TTEncFacturaPro.idEncFacturaPro," & _
        "TTEncFacturaPro.fechaEncFacturaPro," & _
        "TTComisionIr.usuarioPagoComisioIr" & _
        " FROM" & _
        " TTComisionIr INNER JOIN" & _
        " TTDetComisionIr ON TTComisionIr.idComisionIr = TTDetComisionIr.idComisonIr INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionIr.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.Afiliaciones AS Afiliaciones_1 ON TTDetComisionIr.codigoAfiliadoCom = Afiliaciones_1.codigoAfiliado INNER JOIN" & _
        " TTEncFacturaPro ON TTDetComisionIr.idEncFacturaPro = TTEncFacturaPro.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTComisionIr.usuarioPagoComisioIr = TBUsuario.idUsuario" & _
        " where TBUsuario.idusuario in(" & cadena & ") And " & _
        " TTComisionIr.pagoComisionIr='si' and" & _
        " TTComisionIr.fechaPagoComisionIr between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
