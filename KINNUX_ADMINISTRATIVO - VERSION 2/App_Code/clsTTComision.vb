Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTComision

    Dim sucursales As New clsSucursale
    Dim empresas As New clsEmpresa
    Dim usuarios As New clsUsuario
    Dim objOperacione As New clsOperacione
    Private _codigoPais As Integer
    Private _mes As Integer
    Private _ano As Integer
    Private _idEmpresa As Integer
    Private _usuarioPagoComision As String
    Private _fechaFinal As Date
    Private _fechaInicial As Date
    Private _idSucursal As Integer
    Private _idPais As Integer
    Private _codigoAfiliado As String
    Private _fecha As Date
    Private _dptoFComision As Integer

    Public Property dptoFComision As Integer
        Get
            Return _dptoFComision
        End Get
        Set(value As Integer)
            _dptoFComision = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(value As String)
            _codigoAfiliado = value
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

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property usuarioPagoComision As String
        Get
            Return _usuarioPagoComision
        End Get
        Set(value As String)
            _usuarioPagoComision = value
        End Set
    End Property


    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property codigoPais As Integer
        Get
            Return _codigoPais
        End Get
        Set(ByVal value As Integer)
            _codigoPais = value
        End Set
    End Property

    Public Property mes As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property

    Public Property ano As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property

    Function obtenerDatosComisionesMensualesCiclos2019() As DataTable
        Dim codigoPais As Integer
        Dim empresas As New clsEmpresa
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim sql As String
        Dim fecha As String
        Dim tabla As New DataTable
        fecha = Me.fecha.ToString("yyyy/MM/dd")
        With monedaLocal
            .fecha = fecha
            .idEmpresa = Me.idEmpresa
            tabla = .obtenerValorMonedaLocalColombia
            If tabla.Rows.Count <> 0 Then
                valorMoneda = tabla.Rows(0).Item("valorMonedaLocal")
            Else
                valorMoneda = 1
            End If
        End With
        '
        With empresas
            .IdEmpresa = Me.idEmpresa
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            Else
                codigoPais = 0
            End If
        End With
        '
        sql = "SELECT     " & _
        "ircomisionvp * " & valorMoneda & " as ircomisionvp" & _
        ",trinariocomisionvp * " & valorMoneda & " as trinariocomisionvp" & _
        ",cicloscomisionvp * " & valorMoneda & " as cicloscomisionvp" & _
        ",rebatecomisionvp * " & valorMoneda & " as rebatecomisionvp" & _
        ",mundialcomisionvp * " & valorMoneda & " as mundialcomisionvp" & _
        ",binariocomisionvp * " & valorMoneda & " as binariocomisionvp" & _
        ",bono1comisionvp * " & valorMoneda & " as bono1comisionvp" & _
        ",Ttcomisionvp.mescomisionvp, " & _
        "Ttcomisionvp.anocomisionvp, " & _
        "Ttcomisionvp.fechapagocomisionvp, " & _
        "Ttcomisionvp.usuariopagocomisionvp, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "(Ttcomisionvp.ircomisionvp + Ttcomisionvp.trinariocomisionvp + Ttcomisionvp.cicloscomisionvp + Ttcomisionvp.rebatecomisionvp + Ttcomisionvp.mundialcomisionvp + Ttcomisionvp.binariocomisionvp + Ttcomisionvp.bono1comisionvp + Ttcomisionvp.bono2comisionvp + Ttcomisionvp.bono3comisionvp) * " & valorMoneda & " as total" & _
        " FROM" & _
        " Ttcomisionvp INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionvp.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where TTComisionvp.mescomisionvp=" & Me.mes & " and" & _
        " Ttcomisionvp.anocomisionvp=" & Me.ano & " and" & _
        "(Ttcomisionvp.ircomisionvp + Ttcomisionvp.trinariocomisionvp + Ttcomisionvp.cicloscomisionvp + Ttcomisionvp.rebatecomisionvp + Ttcomisionvp.mundialcomisionvp + Ttcomisionvp.binariocomisionvp + Ttcomisionvp.bono1comisionvp + Ttcomisionvp.bono2comisionvp + Ttcomisionvp.bono3comisionvp) <>0"
        ' empresa
        If codigoPais = 0 Then
            sql = sql
        Else
            sql = sql & " and dbo.TBpais.codigoPais=" & codigoPais
        End If
        ' sucursal
        If Me.dptoFComision = 0 Then
            sql = sql
        Else
            sql = sql & " and dbo.Ttcomisionvp.dptofcomisionvp=" & Me.dptoFComision
        End If

        sql = sql & " order by dbo.TBpais.nombrePais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosComisionesMensuales() As DataTable
        Dim codigoPais As Integer
        Dim empresas As New clsEmpresa
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim sql As String
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
        With empresas
            .IdEmpresa = Me.idEmpresa
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            Else
                codigoPais = 0
            End If
        End With

        sql = "SELECT     " & _
        "TTComision.compracomision, " & _
        "TTComision.iniciorcomision * " & valorMoneda & " iniciorcomision, " & _
        "TTComision.uninivelcomision * " & valorMoneda & " uninivelcomision, " & _
        "TTComision.avancelcomision * " & valorMoneda & " avancelcomision, " & _
        "TTComision.genbinariocomision * " & valorMoneda & " genbinariocomision, " & _
        "TTComision.generacionalcomision * " & valorMoneda & " generacionalcomision, " & _
        "TTComision.estructuracomision * " & valorMoneda & " estructuracomision, " & _
        "TTComision.elitecomision * " & valorMoneda & " elitecomision, " & _
        "TTComision.bono1comision * " & valorMoneda & " bono1comision, " & _
        "TTComision.bono2comision * " & valorMoneda & " bono2comision, " & _
        "TTComision.bonocarrocomision * " & valorMoneda & " bonocarrocomision, " & _
        "TTComision.mescomision, " & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision)  * " & valorMoneda & " as suma" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where TTComision.mescomision=" & Me.mes & " and" & _
        " TTComision.anocomision=" & Me.ano & " and" & _
        " (TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision) <> 0"
        If codigoPais = 0 Then
            sql = sql & _
                " order by dbo.TBpais.nombrePais"
        Else
            sql = sql & _
                " and dbo.TBpais.codigoPais=" & codigoPais & _
                " order by dbo.Afiliaciones.codigoAfiliado"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosComisionesMensualesTS() As DataTable
        Dim codigoPais As Integer
        Dim empresas As New clsEmpresa
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim sql As String
        Dim tabla As New DataTable
        With monedaLocal
            .idEmpresa = Me.idEmpresa
            .fecha = Me.fecha
            tabla = .obtenerValorMonedaLocalColombia
            If tabla.Rows.Count <> 0 Then
                valorMoneda = tabla.Rows(0).Item("valorMonedaLocal")
            Else
                valorMoneda = 1
            End If
        End With
        '
        With empresas
            .IdEmpresa = Me.idEmpresa
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            Else
                codigoPais = 0
            End If
        End With
        '
        sql = "SELECT     " & _
        "TTComisionTs.stsComisionTs, " & _
        "TTComisionTs.tsComisionTs, " & _
        "TTComisionTs.unicomisionts, " & _
        "TTComisionTs.spcomisionts * " & valorMoneda & " spcomisionts, " & _
        "TTComisionTs.bonoafilcomisionts * " & valorMoneda & " bonoafilcomisionts, " & _
        "TTComisionTs.bonostscomisionts * " & valorMoneda & " bonostscomisionts, " & _
        "TTComisionTs.bmundialcomisionts * " & valorMoneda & " bmundialcomisionts, " & _
        "TTComisionTs.uninivelcomisionts * " & valorMoneda & " uninivelcomisionts, " & _
        "TTComisionTs.bonomovcomisionts * " & valorMoneda & " bonomovcomisionts, " & _
        "TTComisionTs.bonorangocomisionts * " & valorMoneda & " bonorangocomisionts, " & _
        "TTComisionTs.bigualrcomisionts * " & valorMoneda & " bigualrcomisionts, " & _
        "TTComisionTs.avancercomisionts * " & valorMoneda & " avancercomisionts, " & _
        "TTComisionTs.bono1comisionts * " & valorMoneda & " bono1comisionts, " & _
        "TTComisionTs.mescomisionts, " & _
        "TTComisionTs.anocomisionts, " & _
        "TTComisionTs.fechapagocomisionts, " & _
        "TTComisionTs.usuariopagocomisionts, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "(TTComisionTs.spcomisionts + TTComisionTs.bonoafilcomisionts + TTComisionTs.bonostscomisionts + TTComisionTs.bmundialcomisionts + TTComisionTs.uninivelcomisionts + TTComisionTs.bonomovcomisionts + TTComisionTs.bonorangocomisionts + TTComisionTs.bigualrcomisionts + TTComisionTs.avancercomisionts + TTComisionTs.bono1comisionts)  * " & valorMoneda & " as suma" & _
        " FROM" & _
        " TTComisionTs INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionTs.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where TTComisionTs.mescomisionts=" & Me.mes & " and" & _
        " TTComisionTs.anocomisionts=" & Me.ano & " and" & _
        "(TTComisionTs.spcomisionts + TTComisionTs.bonoafilcomisionts + TTComisionTs.bonostscomisionts + TTComisionTs.bmundialcomisionts + TTComisionTs.uninivelcomisionts + TTComisionTs.bonomovcomisionts + TTComisionTs.bonorangocomisionts + TTComisionTs.bigualrcomisionts + TTComisionTs.avancercomisionts + TTComisionTs.bpatrimoniocomisionts + TTComisionTs.bono1comisionts) <>0"

        If codigoPais = 0 Then
            sql = sql & _
                " order by dbo.TBpais.nombrePais"
        Else
            sql = sql & _
                " and dbo.TBpais.codigoPais=" & codigoPais & _
                " order by dbo.Afiliaciones.codigoAfiliado"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


    Function obtenerDatosComisionesMensualesCiclo() As DataTable
        Dim codigoPais As Integer
        Dim empresas As New clsEmpresa
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        Dim sql As String
        Dim tabla As New DataTable
        With monedaLocal
            .idEmpresa = Me.idEmpresa
            .fecha = Me.fecha
            tabla = .obtenerValorMonedaLocalColombiaCiclo
            If tabla.Rows.Count <> 0 Then
                valorMoneda = tabla.Rows(0).Item("valorMonedaLocalciclo")
            Else
                valorMoneda = 1
            End If
        End With
        '
        With empresas
            .IdEmpresa = Me.idEmpresa
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            Else
                codigoPais = 0
            End If
        End With
        '
        sql = "SELECT     " & _
        "TTComisionCiclo.escalonadocomisionciclo * " & valorMoneda & " escalonadocomisionciclo, " & _
        "TTComisionCiclo.ciclocomisionciclo * " & valorMoneda & " ciclocomisionciclo, " & _
        "TTComisionCiclo.mescomisionciclo, " & _
        "TTComisionCiclo.anocomisionciclo, " & _
        "TTComisionCiclo.fechapagocomisionciclo, " & _
        "TTComisionCiclo.usuariopagocomisionciclo, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "(TTComisionCiclo.escalonadocomisionciclo + TTComisionCiclo.ciclocomisionciclo)  * " & valorMoneda & " as suma" & _
        " FROM" & _
        " TTComisionCiclo INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionCiclo.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio" & _
        " where TTComisionCiclo.mescomisionciclo=" & Me.mes & " and" & _
        " TTComisionCiclo.anocomisionciclo=" & Me.ano & " and" & _
        "(TTComisionCiclo.escalonadocomisionciclo + TTComisionCiclo.ciclocomisionciclo) <>0"

        If codigoPais = 0 Then
            sql = sql & _
                " order by dbo.TBpais.nombrePais"
        Else
            sql = sql & _
                " and dbo.TBpais.codigoPais=" & codigoPais & _
                " order by dbo.Afiliaciones.codigoAfiliado"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function



    ' funcion para obtener las comisiones mensuales pagadas por un usuario
    Function obtenerComisionesMensualesCuadreCaja() As DataTable
        Dim cadena As String = Nothing
        Dim monedaLocal As New clsTbMonedaLocal
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
        '
        sql = "SELECT     " & _
        "TTComision.idcomision, " & _
        "TTComision.compracomision, " & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision) * " & valorMoneda & " as total, " & _
        "TTComision.mescomision, " & _
        "case TTComision.mescomision" & _
        " when 1 then 'Enero'" & _
        " when 2 then 'Febrero'" & _
        " when 3 then 'Marzo'" & _
        " when 4 then 'Abril'" & _
        " when 5 then 'Mayo'" & _
        " when 6 then 'Junio'" & _
        " when 7 then 'Julio'" & _
        " when 8 then 'Agosto'" & _
        " when 9 then 'Septiembre'" & _
        " when 10 then 'Octubre'" & _
        " when 11 then 'Noviembre'" & _
        " when 12 then 'Diciembre'" & _
        " end mes," & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "TTComision.paisIComision, " & _
        "TTComision.paisFComision, " & _
        "TTComision.dptoIComision, " & _
        "TTComision.dptoFComision, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where " & _
        " TTComision.usuariopagocomision in(" & cadena & ") And " & _
        " TTComision.fechapagocomision between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " order by TTComision.fechapagocomision"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las comisiones mensuales
    Function obtenerComisionesMensualesReportes() As DataTable
        Dim codigoPais As String = ""
        Dim dptoSucursal As String = ""
        Dim cadena As String = Nothing
        Dim monedaLocal As New clsTbMonedaLocal
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
        '
        With empresas
            .IdEmpresa = Me.idEmpresa
            tabla = .MostrarEmpresaPorId
            If tabla.Rows.Count <> 0 Then
                codigoPais = tabla.Rows(0).Item("idPais")
            End If
        End With
        '
        With sucursales
            .idSucursal = Me.idSucursal
            tabla = .obtenerSucursalPorId
            If tabla.Rows.Count <> 0 Then
                dptoSucursal = tabla.Rows(0).Item("dptoSucursal")
            End If
        End With
        '
        sql = "SELECT     " & _
        "TTComision.idcomision, " & _
        "TTComision.compracomision, " & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision) * " & valorMoneda & " as total, " & _
        "TTComision.mescomision, " & _
        "case TTComision.mescomision" & _
        " when 1 then 'Enero'" & _
        " when 2 then 'Febrero'" & _
        " when 3 then 'Marzo'" & _
        " when 4 then 'Abril'" & _
        " when 5 then 'Mayo'" & _
        " when 6 then 'Junio'" & _
        " when 7 then 'Julio'" & _
        " when 8 then 'Agosto'" & _
        " when 9 then 'Septiembre'" & _
        " when 10 then 'Octubre'" & _
        " when 11 then 'Noviembre'" & _
        " when 12 then 'Diciembre'" & _
        " end mes," & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "TTComision.paisIComision, " & _
        "TTComision.paisFComision, " & _
        "TTComision.dptoIComision, " & _
        "TTComision.dptoFComision, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " dbo.Afiliaciones ON TTComision.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where " & _
        " TTComision.paisFComision=" & codigoPais & " and" & _
        " TTComision.dptoFComision=" & dptoSucursal & " and" & _
        " TTComision.fechapagocomision between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'" & _
        " order by TTComision.fechapagocomision"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para mostrar las comisiones ya canceladas de un afiliado
    Function obtenerComisonesCanceladas() As DataTable
        Dim monedaLocal As New clsTbMonedaLocal
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
        '
        sql = "SELECT     " & _
        "TTComision.idcomision, " & _
        "TTComision.compracomision, " & _
        "(TTComision.iniciorcomision + TTComision.uninivelcomision + TTComision.avancelcomision + TTComision.genbinariocomision + TTComision.generacionalcomision + TTComision.estructuracomision + TTComision.elitecomision + TTComision.bono1comision + TTComision.bono2comision + TTComision.bonocarrocomision) * " & valorMoneda & " as total, " & _
        "TTComision.mescomision, " & _
        "TTComision.anocomision, " & _
        "TTComision.fechapagocomision, " & _
        "TTComision.usuariopagocomision, " & _
        "TTComision.paisIComision, " & _
        "TTComision.paisFComision, " & _
        "TTComision.dptoIComision, " & _
        "TTComision.dptoFComision, " & _
        "TBUsuario.nombreCompletoUsuario," & _
        " case TTComision.mescomision" & _
        " when 1 then 'Enero'" & _
        " when 2 then 'Febrero'" & _
        " when 3 then 'Marzo'" & _
        " when 4 then 'Abril'" & _
        " when 5 then 'Mayo'" & _
        " when 6 then 'Junio'" & _
        " when 7 then 'Julio'" & _
        " when 8 then 'Agosto'" & _
        " when 9 then 'Septiembre'" & _
        " when 10 then 'Octubre'" & _
        " when 11 then 'Noviembre'" & _
        " when 12 then 'Diciembre'" & _
        " end mes" & _
        " FROM" & _
        " TTComision INNER JOIN" & _
        " TBUsuario ON TTComision.usuariopagocomision = TBUsuario.idUsuario" & _
        " where TTComision.codigoAfiliado = '" & Me.codigoAfiliado & "' and" & _
        " TTComision.usuariopagocomision is not null" & _
        " order by TTComision.anocomision, TTComision.mescomision"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
