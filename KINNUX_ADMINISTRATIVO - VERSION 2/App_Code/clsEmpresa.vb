Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsEmpresa

    Private _idEmpresa As Integer
    Private _nombreEmpresa As String
    Private _direccionEmpresa As String
    Private _telefonoEmpresa As String
    Private _representanteEmpresa As String
    Private _idpais As Integer
    Private _estadoEmpresa As Integer

    Dim objOperacione As New clsOperacione

    Public Property IdEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property DireccionEmpresa As String
        Get
            Return _direccionEmpresa
        End Get
        Set(ByVal value As String)
            _direccionEmpresa = value
        End Set
    End Property

    Public Property RepresentanteEmpresa As String
        Get
            Return _representanteEmpresa
        End Get
        Set(ByVal value As String)
            _representanteEmpresa = value
        End Set
    End Property

    Public Property NombreEmpresa As String
        Get
            Return _nombreEmpresa
        End Get
        Set(ByVal value As String)
            _nombreEmpresa = value
        End Set
    End Property

    Public Property TelefonoEmpresa As String
        Get
            Return _telefonoEmpresa
        End Get
        Set(ByVal value As String)
            _telefonoEmpresa = value
        End Set
    End Property

    Public Property IdPais As Integer
        Get
            Return _idpais
        End Get
        Set(ByVal value As Integer)
            _idpais = value
        End Set
    End Property

    Public Property EstadoEmpresa As Integer
        Get
            Return _estadoEmpresa
        End Get
        Set(ByVal value As Integer)
            _estadoEmpresa = value
        End Set
    End Property

    Sub GrabarEmpresa(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaEmpresa " & _
        "@idEmpresa='" & Me.IdEmpresa & "'," & _
        "@nombreEmpresa='" & Me.NombreEmpresa & "'," & _
        "@direccionEmpresa='" & Me.DireccionEmpresa & "'," & _
        "@telefonoEmpresa='" & Me.TelefonoEmpresa & "'," & _
        "@representanteEmpresa='" & Me.RepresentanteEmpresa & "'," & _
        "@idPais='" & Me.IdPais & "'," & _
        "@estadoEmpresa='" & Me.EstadoEmpresa & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function MostrarEmpresaGeneral() As DataTable
        Dim sql As String
        Dim tablaEmpresa As New DataTable
        sql = "SELECT     " & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.idpais," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBEmpresa.direccionEmpresa," & _
        "dbo.TBEmpresa.telefonoEmpresa," & _
        "dbo.TBEmpresa.representanteEmpresa," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "dbo.TBEmpresa.estadoEmpresa" & _
        " FROM" & _
        " dbo.TBEmpresa INNER JOIN" & _
        " dbo.TBpais ON dbo.TBEmpresa.idPais = dbo.TBpais.codigoPais where dbo.TBEmpresa.estadoempresa=1"
        With objOperacione
            tablaEmpresa = .DevuelveDato(sql)
        End With
        Return tablaEmpresa
    End Function

    Function MostrarEmpresaPorId() As DataTable
        Dim tablaEmpresa As New DataTable
        With objOperacione
            tablaEmpresa = .DevuelveDato("select * from TBEmpresa where idEmpresa=" & Me.IdEmpresa)
        End With
        Return tablaEmpresa
    End Function

    Function MostrarEmpresaPorPais() As DataTable
        Dim tabla As New DataTable
        With objOperacione
            tabla = .DevuelveDato("exec sp_muestraEmpresaPorPais @idPais='" & Me.IdPais & "'")
        End With
        Return tabla
    End Function

    Function obtenerEmpresaPais() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBEmpresa.idEmpresa," & _
        "TBEmpresa.nombreEmpresa + ' - ' + TBpais.nombrePais as nombres" & _
        " FROM" & _
        " TBEmpresa INNER JOIN TBpais ON TBEmpresa.idPais = TBpais.idpais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' obtener empresas y sucursales
    Function obtenerEmpresaySucursales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal" & _
        " FROM" & _
        " dbo.TBEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON dbo.TBEmpresa.idEmpresa = dbo.TBSucursal.idEmpresa" & _
        " order by dbo.TBEmpresa.idEmpresa"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las sucursales estadisticas PV
    Function obtenerEmpresasEstadisticasPV() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal, " & _
        "dbo.TBSucursal.nombreSucursal," & _
        "'' as Ene," & _
        "'' as Feb," & _
        "'' as Mar," & _
        "'' as Abr," & _
        "'' as May," & _
        "'' as Jun," & _
        "'' as Jul," & _
        "'' as Ago," & _
        "'' as Sep," & _
        "'' as Oct," & _
        "'' as Nov," & _
        "'' as Dic" & _
        " FROM" & _
        " dbo.TBEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON dbo.TBEmpresa.idEmpresa = dbo.TBSucursal.idEmpresa" & _
        " order by dbo.TBEmpresa.idEmpresa"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las empresas estadisticas PV
    Function obtenerDetalleEmpresasEstadisticasPV() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "idEmpresa, " & _
        "nombreEmpresa," & _
        "'' as Ene," & _
        "'' as Feb," & _
        "'' as Mar," & _
        "'' as Abr," & _
        "'' as May," & _
        "'' as Jun," & _
        "'' as Jul," & _
        "'' as Ago," & _
        "'' as Sep," & _
        "'' as Oct," & _
        "'' as Nov," & _
        "'' as Dic" & _
        " FROM" & _
        " dbo.TBEmpresa" & _
        " order by dbo.TBEmpresa.idEmpresa"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
