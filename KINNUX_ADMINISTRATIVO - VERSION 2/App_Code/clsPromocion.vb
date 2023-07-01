Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPromocion

    Private _idPromocion As Integer
    Private _idPaquete As Integer
    Private _promocionFechaInicial As Date
    Private _promocionFechaFinal As Date
    Private _idPromocionPais As Integer
    Private _idPais As Integer
    '
    Private _idpromocionts As Integer
    Private _fechaipromocionts As Date
    Private _fechafpromocionts As Date
    Private _idevento As Integer
    Private _idpaqueteTs As Integer
    Private _nombrepromocionts As String
    Private _valorpromocionts As Double
    Private _nprodpromocionts As Integer
    Private _estadopromocionts As Integer
    Private _idSucursal As Integer
    Private _nProductosBaseTS As Integer
    Private _tipoPromocionTS As String
    Private _precioEspecialTs As String
    Private _idProducto As Integer
    Private _inicioPromocionTs As String
    Private _nunstspromocionts As Double
    Private _numProductosObsequio As Double
    Private _califpromocionts As String
    Private _ciclopromocionts As String

    '
    Dim objOperacione As New clsOperacione

    Public Property numProductosObsequio As Double
        Get
            Return _numProductosObsequio
        End Get
        Set(ByVal value As Double)
            _numProductosObsequio = value
        End Set
    End Property

    Public Property califpromocionts As String
        Get
            Return _califpromocionts
        End Get
        Set(ByVal value As String)
            _califpromocionts = value
        End Set
    End Property

    Public Property ciclopromocionts As String
        Get
            Return _ciclopromocionts
        End Get
        Set(ByVal value As String)
            _ciclopromocionts = value
        End Set
    End Property

    Public Property nunstspromocionts As Double
        Get
            Return _nunstspromocionts
        End Get
        Set(ByVal value As Double)
            _nunstspromocionts = value
        End Set
    End Property

    Public Property inicioPromocionTs As String
        Get
            Return _inicioPromocionTs
        End Get
        Set(ByVal value As String)
            _inicioPromocionTs = value
        End Set
    End Property

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property precioEspecialTs As String
        Get
            Return _precioEspecialTs
        End Get
        Set(ByVal value As String)
            _precioEspecialTs = value
        End Set
    End Property

    Public Property tipoPromocionTS As String
        Get
            Return _tipoPromocionTS
        End Get
        Set(ByVal value As String)
            _tipoPromocionTS = value
        End Set
    End Property

    Public Property nProductosBaseTS As Integer
        Get
            Return _nProductosBaseTS
        End Get
        Set(ByVal value As Integer)
            _nProductosBaseTS = value
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

    Public Property estadopromocionts As Integer
        Get
            Return _estadopromocionts
        End Get
        Set(ByVal value As Integer)
            _estadopromocionts = value
        End Set
    End Property

    Public Property nprodpromocionts As Integer
        Get
            Return _nprodpromocionts
        End Get
        Set(ByVal value As Integer)
            _nprodpromocionts = value
        End Set
    End Property

    Public Property valorpromocionts As Double
        Get
            Return _valorpromocionts
        End Get
        Set(ByVal value As Double)
            _valorpromocionts = value
        End Set
    End Property

    Public Property nombrepromocionts As String
        Get
            Return _nombrepromocionts
        End Get
        Set(ByVal value As String)
            _nombrepromocionts = value
        End Set
    End Property

    Public Property idpaqueteTs As Integer
        Get
            Return _idpaqueteTs
        End Get
        Set(ByVal value As Integer)
            _idpaqueteTs = value
        End Set
    End Property

    Public Property idevento As Integer
        Get
            Return _idevento
        End Get
        Set(ByVal value As Integer)
            _idevento = value
        End Set
    End Property

    Public Property fechafpromocionts As Date
        Get
            Return _fechafpromocionts
        End Get
        Set(ByVal value As Date)
            _fechafpromocionts = value
        End Set
    End Property

    Public Property fechaipromocionts As Date
        Get
            Return _fechaipromocionts
        End Get
        Set(ByVal value As Date)
            _fechaipromocionts = value
        End Set
    End Property

    Public Property idpromocionts As Integer
        Get
            Return _idpromocionts
        End Get
        Set(ByVal value As Integer)
            _idpromocionts = value
        End Set
    End Property

    Public Property idPromocion As Integer
        Get
            Return _idPromocion
        End Get
        Set(ByVal value As Integer)
            _idPromocion = value
        End Set
    End Property

    Public Property idPaquete As Integer
        Get
            Return _idPaquete
        End Get
        Set(ByVal value As Integer)
            _idPaquete = value
        End Set
    End Property

    Public Property promocionFechaInicial As Date
        Get
            Return _promocionFechaInicial
        End Get
        Set(ByVal value As Date)
            _promocionFechaInicial = value
        End Set
    End Property

    Public Property promocionFechaFinal As Date
        Get
            Return _promocionFechaFinal
        End Get
        Set(ByVal value As Date)
            _promocionFechaFinal = value
        End Set
    End Property

    Public Property idPromocionPais As Integer
        Get
            Return _idPromocionPais
        End Get
        Set(ByVal value As Integer)
            _idPromocionPais = value
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

    Sub grabarPromocion(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPromociones " & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@idPaquete='" & Me.idPaquete & "'," & _
        "@promocionFechaInicial='" & Me.promocionFechaInicial.ToString("yyyyMMdd") & "'," & _
        "@promocionFechaFinal='" & Me.promocionFechaFinal.ToString("yyyyMMdd") & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarPromocionpais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPromocionPais " & _
        "@idPromocionPais='" & Me.idPromocionPais & "'," & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPromociones() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBPromocion.idPromocion," & _
        "TBPromocion.promocionFechaInicial," & _
        "TBPromocion.promocionFechaFinal," & _
        "TBPromocionPais.idPromocionPais," & _
        "dbo.TBpais.codigoPais," & _
        "dbo.TBpais.nombrePais," & _
        "TBPaquete.idPaquete," & _
        "TBPaquete.nombrePaquete" & _
        " FROM" & _
        " dbo.TBpais INNER JOIN" & _
        " TBPromocionPais ON dbo.TBpais.codigoPais = TBPromocionPais.idPais INNER JOIN" & _
        " TBPromocion ON TBPromocionPais.idPromocion = TBPromocion.idPromocion INNER JOIN" & _
        " TBPaquete ON TBPromocion.idPaquete = TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'procedimiento para grabar la configuracion de promocion ts
    Function grabarPromocionTS(ByVal accion As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_TBPromocionTS " & _
        "@idpromocionts='" & Me.idpromocionts & "'," & _
        "@fechaipromocionts='" & Me.fechaipromocionts.ToString("yyyy/MM/dd") & "'," & _
        "@fechafpromocionts='" & Me.fechafpromocionts.ToString("yyyy/MM/dd") & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@idevento='" & Me.idevento & "'," & _
        "@idpaquete='" & Me.idPaquete & "'," & _
        "@nombrepromocionts='" & Me.nombrepromocionts & "'," & _
        "@valorpromocionts='" & Me.valorpromocionts & "'," & _
        "@nBasePromocionts='" & Me.nProductosBaseTS & "'," & _
        "@nprodpromocionts='" & Me.nprodpromocionts & "'," & _
        "@tipoPromocionTs='" & Me.tipoPromocionTS & "'," & _
        "@inicioPromocionTs='" & Me.inicioPromocionTs & "'," & _
        "@estadopromocionts='" & Me.estadopromocionts & "'," & _
        "@nunstspromocionts='" & Replace(Me.nunstspromocionts, ",", ".") & "'," & _
        "@califpromocionts='" & Me.califpromocionts & "'," & _
        "@ciclopromocionts='" & Me.ciclopromocionts & "'," & _
        "@nprodobsequiopromosionts='" & Me.numProductosObsequio & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'funcion para obtener las promociones ts
    Function obtenerPromocionesTS() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "dbo.TBPromocionTS.idpromocionts, " & _
        "dbo.TBPromocionTS.fechaipromocionts, " & _
        "dbo.TBPromocionTS.fechafpromocionts, " & _
        "dbo.TBEmpresa.idEmpresa, " & _
        "dbo.TBEmpresa.nombreEmpresa, " & _
        "'' as nombresucursal," & _
        "'' as nombreEvento," & _
        "dbo.TBPromocionTS.idpaquete, " & _
        "dbo.TBPromocionTS.nombrepromocionts, " & _
        "dbo.TBPromocionTS.valorpromocionts, " & _
        "dbo.TBPromocionTS.nbasepromocionts, " & _
        "dbo.TBPromocionTS.nprodpromocionts, " & _
        "dbo.TBPromocionTS.tipopromocionts, " & _
        " Case dbo.TBPromocionTS.tipopromocionts" & _
        " when 'P' Then 'Promocion Para Pais'" & _
        " when 'S' Then 'Promocion Para Sucursal'" & _
        " when 'E' Then 'Promocion Para Evento'" & _
        " else ''" & _
        " end tipopromocion," & _
        " dbo.TBPromocionTS.inicioPromocionTs, " & _
        " dbo.TBPromocionTS.estadopromocionts," & _
        " Case dbo.TBPromocionTS.estadopromocionts" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Eliminado'" & _
        " end estado," & _
        " case " & _
        " when getdate() < = dbo.TBPromocionTS.fechafpromocionts then 'Promocion Vigente'" & _
        " when getdate() > dbo.TBPromocionTS.fechafpromocionts then 'Promocion No Vigente'" & _
        " End vigente" & _
        " FROM" & _
        " dbo.TBPromocionTS INNER JOIN" & _
        " dbo.TBEmpresa ON dbo.TBPromocionTS.idpais = dbo.TBEmpresa.idEmpresa order by dbo.TBPromocionTS.idpromocionts desc"

        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub grabarProductosPromocion()
        Dim sql As String
        sql = "exec sp_TTProdPromo " & _
        "@idpromocionts='" & Me.idpromocionts & "'," & _
        "@idproducto='" & Me.idProducto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosDeLaPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTProdPromo where idPromocionTs=" & Me.idpromocionts
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
