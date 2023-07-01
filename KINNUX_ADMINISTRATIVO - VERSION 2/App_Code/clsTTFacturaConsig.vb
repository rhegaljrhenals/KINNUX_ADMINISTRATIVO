Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTFacturaConsig

    Private _codigoAfiliado As String
    Private _idFacturaConsig As Integer
    Private _idEncFacturaPro As Double
    Private _idConsignacion As Double
    Private _tipoFactura As String
    Dim objOperacione As New clsOperacione

    Public Property tipoFactura As String
        Get
            Return _tipoFactura
        End Get
        Set(ByVal value As String)
            _tipoFactura = value
        End Set
    End Property

    Public Property idFacturaConsig As Integer
        Get
            Return _idFacturaConsig
        End Get
        Set(ByVal value As Integer)
            _idFacturaConsig = value
        End Set
    End Property

    Public Property idEncFacturaPro As Double
        Get
            Return _idEncFacturaPro
        End Get
        Set(ByVal value As Double)
            _idEncFacturaPro = value
        End Set
    End Property

    Public Property idConsignacion As Double
        Get
            Return _idConsignacion
        End Get
        Set(ByVal value As Double)
            _idConsignacion = value
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

    Sub grabarTTFacturaConsig()
        Dim sql As String
        sql = "exec sp_actualizaTTFacturaConsig " & _
        "@codigoAfiliado='" & Me.codigoAfiliado & "'," & _
        "@idFacturaConsig='" & Me.idFacturaConsig & "'," & _
        "@idEncFacturaPro='" & Me.idEncFacturaPro & "'," & _
        "@idConsignacion='" & Me.idConsignacion & "'," & _
        "@tipoFactura='" & Me.tipoFactura & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los datos de la factura-consigancion por idEncabezado
    Function obtenerDatosConsignacion() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTFacturaConsig" & _
            " where idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para eliminar la relacion facturaConsig
    Sub eliminaRegistroFacturaConsig()
        Dim sql As String
        sql = "exec sp_actualizattfacturaconsigEliminaRegistro " & _
        "@idfacturaConsig='" & Me.idFacturaConsig & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obetner la relacion de la consignacion con las remisiones
    Function obtenerRemisionesDeConsignaciones() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTEncFacturaPro.idEncFacturaPro, " & _
        "TTEncFacturaPro.fechaEncFacturaPro, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTEncFacturaPro.tipoEncFacturaPro," & _
        "TTEncFacturaPro.valorCoEncFacturaPro," & _
        "TTEncFacturaPro.valorMlEncFacturaPro," & _
        "TTEncFacturaPro.puntosEncfacturaPro," & _
        "TTEncFacturaPro.valorAbonoEncFacturaPun," & _
        "TTEncFacturaPro.valorCruceEncfacturaPro," & _
        "TTEncFacturaPro.valorHotelEncFacturaPro," & _
        "TTEncFacturaPro.valorConsigEncfacturaPro," & _
        "TTEncFacturaPro.valorEfectivoEncFacturaPro," & _
        "TTEncFacturaPro.valorUsEncFacturaPro," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal," & _
        "TBUsuario.idUsuario," & _
        "TBUsuario.nombreCompletoUsuario" & _
        " FROM" & _
        " TTEncFacturaPro INNER JOIN" & _
        " TTFacturaConsig ON TTEncFacturaPro.idEncFacturaPro = TTFacturaConsig.idEncFacturaPro INNER JOIN" & _
        " dbo.Afiliaciones ON TTEncFacturaPro.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncFacturaPro.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON dbo.TBEmpresa.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncFacturaPro.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTLogFactura ON TTEncFacturaPro.idEncFacturaPro = TTLogFactura.idEncFacturaPro INNER JOIN" & _
        " TBUsuario ON TTLogFactura.idusuario = TBUsuario.idUsuario" & _
        " where TTFacturaConsig.idConsignacion=" & Me.idConsignacion
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
