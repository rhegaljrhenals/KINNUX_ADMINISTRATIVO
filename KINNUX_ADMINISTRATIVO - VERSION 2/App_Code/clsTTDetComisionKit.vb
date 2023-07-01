Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetComisionKit
    Private _idDetComisionKit As Integer
    Private _idComisionKit As Integer
    Private _codigoAfiliado As String
    Private _valorDetComisionKit As Double
    Private _codigoAfiliadoCom As String
    Private _idEncFacturaPro As Integer
    Private _fechaComDetComisionKit As Date
    Dim objOperacione As New clsOperacione

    Public Property codigoAfiliadoCom As String
        Get
            Return _codigoAfiliadoCom
        End Get
        Set(ByVal value As String)
            _codigoAfiliadoCom = value
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

    Public Property fechaComDetComisionKit As Date
        Get
            Return _fechaComDetComisionKit
        End Get
        Set(ByVal value As Date)
            _fechaComDetComisionKit = value
        End Set
    End Property

    Public Property idDetComisionKit As Integer
        Get
            Return _idComisionKit
        End Get
        Set(ByVal value As Integer)
            _idComisionKit = value
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

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property valorDetComisionKit As Double
        Get
            Return _valorDetComisionKit
        End Get
        Set(ByVal value As Double)
            _valorDetComisionKit = value
        End Set
    End Property

    ' funcion para obtener el detalle de la comision por id
    Function obtenerDetalleComision() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TTDetComisionKit.idEncFacturaPro," & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres," & _
        "TTDetComisionKit.fechaComDetComisionKit," & _
        "TTDetComisionKit.valorDetComisionKit" & _
        " FROM" & _
        " TTDetComisionKit INNER JOIN" & _
        " dbo.Afiliaciones ON TTDetComisionKit.codigoAfiliadoCom = dbo.Afiliaciones.codigoAfiliado" & _
        " where TTDetComisionKit.idComisionKit=" & Me.idComisionKit & _
        " order by TTDetComisionKit.fechaComDetComisionKit"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener el detalle de la comision or numero remision
    Function obtenerDetalleComisionPorIdRemision() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from ttDetComisionKit where idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para elimimar el registro del detalle de la comision
    Sub eliminaRegistroDetalleComision()
        Dim sql As String
        sql = "delete from ttDetcomisionkit where idComisionKit=" & Me.idComisionKit
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
