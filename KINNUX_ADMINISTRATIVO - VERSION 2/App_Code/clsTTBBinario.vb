Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTBBinario

    Private _fechaInicio As Date
    Private _fechaFinal As Date
    Private _fechaInicial As Date
    Private _mesSeleccionado As Integer
    Private _anoSeleccionado As Integer
    Private _codigoPais As Integer
    Private _idEmpresa As Integer
    Private _idSucursal As Integer
    Private _idPais As Integer
    Dim usuarios As New clsTBUsuarios
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

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
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

    Public Property codigoPais As Integer
        Get
            Return _codigoPais
        End Get
        Set(ByVal value As Integer)
            _codigoPais = value
        End Set
    End Property

    Public Property mesSeleccionado As Integer
        Get
            Return _mesSeleccionado
        End Get
        Set(ByVal value As Integer)
            _mesSeleccionado = value
        End Set
    End Property

    Public Property anoSeleccionado As Integer
        Get
            Return _anoSeleccionado
        End Get
        Set(ByVal value As Integer)
            _anoSeleccionado = value
        End Set
    End Property

    Public Property fechaInicio As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
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

    ' funcion para obtener los datos
    Function obtenerDatosTTBbinario() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        '        sql = "SELECT " & _
        '"dbo.Afiliaciones.codigoAfiliado, " & _
        '"dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        '"TTBbinario.idbbinario," & _
        '"TTBbinario.acumbbinario," & _
        '"TTBbinario.valorbbinario," & _
        '"TTBbinario.porcbbinario," & _
        '"TTBbinario.fechainibbinario," & _
        '"TTBbinario.fechafinbbinario," & _
        '"TTBbinario.fechavenbbinario" & _
        '" FROM" & _
        '" dbo.Afiliaciones INNER JOIN" & _
        '" TTBbinario ON dbo.Afiliaciones.codigoAfiliado = TTBbinario.codigoafiliado" & _
        sql = "SELECT     " & _
         "dbo.Afiliaciones.codigoAfiliado, " & _
         "dbo.Afiliaciones.identificacion, " & _
         "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
         "TTBbinario.acumbbinario," & _
         "TTBbinario.valorbbinario," & _
         "TTBbinario.idbbinario," & _
         "TTBbinario.porcbbinario," & _
         "TTBbinario.fechainibbinario," & _
         "TTBbinario.fechafinbbinario," & _
         "TTBbinario.fechavenbbinario," & _
         "TTBbinario.pagobbinario," & _
         "TTBbinario.fechapagobbinario," & _
         "TTBbinario.usuariopagbbinario," & _
         "dbo.TBpais.codigoPais, dbo.TBpais.nombrePais," & _
         "dbo.TBDpto.nombreDpto," & _
         "dbo.TBMunicipio.nombreMunicipio" & _
         " FROM" & _
         " dbo.Afiliaciones INNER JOIN" & _
         " TTBbinario ON dbo.Afiliaciones.codigoAfiliado = TTBbinario.codigoafiliado INNER JOIN" & _
         " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
         " dbo.TBDpto ON dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto AND dbo.TBpais.codigoPais = dbo.TBDpto.idPais INNER JOIN" & _
         " dbo.TBMunicipio ON dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
         " dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais" & _
         " where TTBbinario.fechainibbinario='" & Me.fechaInicio.ToString("yyyy/MM/dd") & "' and TTBbinario.fechafinbbinario='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and TTBbinario.pagobbinario='C'"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by dbo.TBpais.nombrePais"
        Else
            sql = sql & _
                " and dbo.TBpais.codigoPais=" & Me.codigoPais & _
                " order by dbo.Afiliaciones.codigoAfiliado"
        End If
        '
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los datos semanales
    Function obtenerDatosTrimestralBonoPatrimonio() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "sum(TTPagoPatrimonio.acumPagoPatrimonio) acumulado, " & _
        "sum(TTPagoPatrimonio.valorPagoPatrimonio) valor, " & _
        "TTPagoPatrimonio.fechainiPagoPatrimonio," & _
        "TTPagoPatrimonio.fechafinPagoPatrimonio" & _
        " FROM" & _
        " TTPagoPatrimonio " & _
        " where" & _
        " TTPagoPatrimonio.fechainiPagoPatrimonio>='" & Me.fechaInicial & "' And " & _
        " TTPagoPatrimonio.fechafinPagoPatrimonio<='" & Me.fechaFinal & "'"
        If Me.codigoPais <> 0 Then
            sql = sql & " and  afiliaciones.codigoPais=" & Me.codigoPais
        End If
        sql = sql & " group by TTPagoPatrimonio.fechainiPagoPatrimonio," & _
        " TTPagoPatrimonio.fechafinPagoPatrimonio" & _
        " order by TTPagoPatrimonio.fechainiPagoPatrimonio"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los datos
    Function obtenerDetalleBonoPatrimonio() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
         "dbo.Afiliaciones.codigoAfiliado, " & _
         "dbo.Afiliaciones.identificacion, " & _
         "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
         "TTPagoPatrimonio.acumPagoPatrimonio," & _
         "TTPagoPatrimonio.valorPagoPatrimonio," & _
         "TTPagoPatrimonio.idPagoPatrimonio," & _
         "TTPagoPatrimonio.fechainiPagoPatrimonio," & _
         "TTPagoPatrimonio.fechafinPagoPatrimonio," & _
         "TTPagoPatrimonio.fechaPagoPatrimonio," & _
         "TTPagoPatrimonio.usuarioPagoPatrimonio," & _
         "dbo.TBpais.codigoPais, dbo.TBpais.nombrePais," & _
         "dbo.TBDpto.nombreDpto," & _
         "dbo.TBMunicipio.nombreMunicipio" & _
         " FROM" & _
         " dbo.Afiliaciones INNER JOIN" & _
         " TTPagoPatrimonio ON dbo.Afiliaciones.codigoAfiliado = TTPagoPatrimonio.codigoafiliado INNER JOIN" & _
         " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
         " dbo.TBDpto ON dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto AND dbo.TBpais.codigoPais = dbo.TBDpto.idPais INNER JOIN" & _
         " dbo.TBMunicipio ON dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
         " dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais" & _
        " where TTPagoPatrimonio.fechainiPagoPatrimonio>='" & Me.fechaInicial & "' And " & _
        " TTPagoPatrimonio.fechafinPagoPatrimonio<='" & Me.fechaFinal & "'"
        If Me.codigoPais = 0 Then
            sql = sql & " order by dbo.TBpais.nombrePais"
        Else
            sql = sql & _
                " and dbo.TBpais.codigoPais=" & Me.codigoPais & _
                " order by dbo.Afiliaciones.codigoAfiliado"
        End If
        '
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los datos semanales
    Function obtenerDatosSemanales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        'sql = "select " & _
        '"sum(acumbbinario) acumulado," & _
        '"sum(valorbbinario) valor," & _
        '"fechainibbinario," & _
        '"fechafinbbinario" & _
        '" from ttbbinario" & _
        '" where" & _
        '" Month(fechainibbinario) = " & Me.mesSeleccionado & " And" & _
        '" Year(fechainibbinario) = " & Me.anoSeleccionado & _
        '" group by fechainibbinario," & _
        '" fechafinbbinario" & _
        '" order by fechainibbinario"

        sql = "SELECT     " & _
        "sum(TTBbinario.acumbbinario) acumulado, " & _
        "sum(TTBbinario.valorbbinario) valor, " & _
        "TTBbinario.fechainibbinario," & _
        "TTBbinario.fechafinbbinario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTBbinario ON dbo.Afiliaciones.codigoAfiliado = TTBbinario.codigoafiliado" & _
        " where" & _
        " Month(TTBbinario.fechainibbinario) = " & Me.mesSeleccionado & " And " & _
        " Year(TTBbinario.fechainibbinario) = " & Me.anoSeleccionado & "  and TTBbinario.pagobbinario='C'"
        If Me.codigoPais <> 0 Then
            sql = sql & " and  afiliaciones.codigoPais=" & Me.codigoPais
        End If
        sql = sql & " group by TTBbinario.fechainibbinario," & _
        " TTBbinario.fechafinbbinario" & _
        " order by TTBbinario.fechainibbinario"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las comisiones pagadas por un usuario (cuadre caja)
    Function obtenerComisionesPagadasPorUsuario() As DataTable
        Dim sql As String
        Dim cadena As String = Nothing
        Dim tabla As New DataTable
        Dim monedaLocal As New clsTbMonedaLocal
        Dim valorMoneda As Double
        '
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
            tabla = .obtenerUsuariosSucursales
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    cadena += tabla.Rows(y).Item("idUsuario") & ","
                Next
                cadena = Mid(cadena, 1, cadena.Length - 1)
            End If
        End With
        '-------------------------------------------------------------------------------
        sql = "SELECT     " & _
        "TTBbinario.idbbinario, " & _
        "TTBbinario.acumbbinario, " & _
         "TTBbinario.valorbbinario  * " & valorMoneda & " as valorbbinario," & _
        "TTBbinario.porcbbinario, " & _
        "TTBbinario.fechainibbinario, " & _
        "TTBbinario.fechafinbbinario, " & _
        "TTBbinario.fechavenbbinario," & _
        "TTBbinario.pagobbinario, " & _
        "TTBbinario.fechapagobbinario, " & _
        "TTBbinario.usuariopagbbinario," & _
        "TTBbinario.paisIbBinario, " & _
        "TTBbinario.paisfbBinario, " & _
        "TTBbinario.dptoIbBinario, " & _
        "TTBbinario.dptoFbBinario, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        " case month(TTBbinario.fechainibbinario)" & _
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
        " year(TTBbinario.fechainibbinario) ano" & _
        " FROM" & _
        " TTBbinario INNER JOIN" & _
        " dbo.Afiliaciones ON TTBbinario.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where" & _
        " TTBbinario.fechapagobbinario between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " TTBbinario.usuariopagbbinario in (" & cadena & ")" & _
        " order by TTBbinario.fechapagobbinario"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
