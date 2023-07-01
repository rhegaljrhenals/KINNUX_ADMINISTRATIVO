Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetFacturaPro

    Private _codigoAfiliado As String
    Private _idDetFacturaPro As Integer
    Private _idEncFacturaPro As Integer
    Private _idProducto As Integer
    Private _promoDetFacturaPro As String
    Private _cantidadDetFacturaPro As Double
    Private _valorDetFacturaPro As Double
    Private _subtotalDetFacturaPro As Double
    Private _puntosDetFacturaPro As Double
    Private _subtotalPuntosDetFacturaPro As Double
    Private _valorMl As Double
    Private _subtotalMl As Double
    Dim objOperacione As New clsOperacione

    Public Property idDetFacturaPro As Integer
        Get
            Return _idDetFacturaPro
        End Get
        Set(ByVal value As Integer)
            _idDetFacturaPro = value
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

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property promoDetFacturaPro As String
        Get
            Return _promoDetFacturaPro
        End Get
        Set(ByVal value As String)
            _promoDetFacturaPro = value
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

    Public Property cantidadDetFacturaPro As Double
        Get
            Return _cantidadDetFacturaPro
        End Get
        Set(ByVal value As Double)
            _cantidadDetFacturaPro = value
        End Set
    End Property

    Public Property valorDetFacturaPro As Double
        Get
            Return _valorDetFacturaPro
        End Get
        Set(ByVal value As Double)
            _valorDetFacturaPro = value
        End Set
    End Property

    Public Property subtotalDetFacturaPro As Double
        Get
            Return _subtotalDetFacturaPro
        End Get
        Set(ByVal value As Double)
            _subtotalDetFacturaPro = value
        End Set
    End Property

    Public Property puntosDetFacturaPro As Double
        Get
            Return _puntosDetFacturaPro
        End Get
        Set(ByVal value As Double)
            _puntosDetFacturaPro = value
        End Set
    End Property

    Public Property subtotalPuntosDetFacturaPro As Double
        Get
            Return _subtotalPuntosDetFacturaPro
        End Get
        Set(ByVal value As Double)
            _subtotalPuntosDetFacturaPro = value
        End Set
    End Property

    Public Property valorMl As Double
        Get
            Return _valorMl
        End Get
        Set(ByVal value As Double)
            _valorMl = value
        End Set
    End Property

    Public Property subtotalMl As Double
        Get
            Return _subtotalMl
        End Get
        Set(ByVal value As Double)
            _subtotalMl = value
        End Set
    End Property

    Function obtenerDetalleFacturaPorIdEncabezado() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Pro'" & _
        " when 'O' then 'Obs'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetalleFacturaPorIdEncabezadoFacturaPersonalizada() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Promocion'" & _
        " when 'O' then 'Obsequio'" & _
        " else ''" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetalleFacturaPorIdEncabezadoKit() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Pro'" & _
        " when 'O' then 'Obs'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro & " and" & _
        " TTDetFacturaPro.promoDetFacturaPro='0'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetalleFacturaPorIdEncabezadoFacturaPaquetes() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Pro'" & _
        " when 'O' then 'Obs'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro & " and" & _
        " TTDetFacturaPro.promoDetFacturaPro='N'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


    ' funcion para obtener la cantidad de productos de una remision
    Function obtenerNumeroDeProductosPorIdEncabezado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select isnull(count(*),0) as cantidad from ttDetFacturaPro where idEncFacturaPro=" & Me.idEncFacturaPro & " and promoDetfacturaPro='N'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para llenas de datos vacios
    Function llenarDatosVacios() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select top 5 '0' as idProducto," & _
            "'' as nombreProducto," & _
            "'' as cantidadDetFacturaPro," & _
            "'' as pro," & _
            "'' as obs" & _
            " from tbNumeroItem"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los registros de promociones y obsequios
    Function obtenerPromocionesyObsequios() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        'sql = "select * from ttDetFacturaPro where idEncFacturaPro=" & Me.idEncFacturaPro & " and promoDetfacturaPro<>'N'"
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Prom'" & _
        " when 'O' then 'Obse'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro & " and" & _
        " TTDetFacturaPro.promoDetFacturaPro<>'N' order by promoDetFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los registros de obsequios
    Function obtenerObsequios() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        'sql = "select * from ttDetFacturaPro where idEncFacturaPro=" & Me.idEncFacturaPro & " and promoDetfacturaPro<>'N'"
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Prom'" & _
        " when 'O' then 'Obse'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro & " and" & _
        " TTDetFacturaPro.promoDetFacturaPro='O' order by promoDetFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerPromociones() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        'sql = "select * from ttDetFacturaPro where idEncFacturaPro=" & Me.idEncFacturaPro & " and promoDetfacturaPro<>'N'"
        sql = "SELECT  " & _
        "TBProducto.idProducto, " & _
        "TBProducto.nombreProducto, " & _
        "TTDetFacturaPro.cantidadDetFacturaPro," & _
        "TTDetFacturaPro.valorDetFacturaPro, " & _
        "TTDetFacturaPro.puntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalPuntosDetFacturaPro, " & _
        "TTDetFacturaPro.subtotalDetFacturaPro, " & _
        "'' as pro," & _
        "'' as obs," & _
        " case TTDetFacturaPro.promoDetFacturaPro " & _
        " when 'N' then ''" & _
        " when 'P' then 'Prom'" & _
        " when 'O' then 'Obse'" & _
        " end promoDetFacturaPro" & _
        " FROM" & _
        " TTDetFacturaPro INNER JOIN " & _
        " TBProducto ON TTDetFacturaPro.idProducto = TBProducto.idProducto " & _
        " where TTDetFacturaPro.idEncFacturaPro=" & Me.idEncFacturaPro & " and" & _
        " TTDetFacturaPro.promoDetFacturaPro='P' order by promoDetFacturaPro"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las cantidades de productos de las remisiones
    Function obtenerCantidades() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select isnull(sum(cantidadDetFacturaPro),0) as total" & _
        " from ttDetFacturaPro" & _
        " where idEncFacturaPro = " & Me.idEncFacturaPro & _
        " and promoDetFacturaPro='" & Me.promoDetFacturaPro & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function



    ' funcion para obtener las cantidades de productos de las remisiones de cliente elite
    Function obtenerCantidadesClienteElite() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select isnull(sum(cantidadDetFacturaPro),0) as total" & _
        " from ttDetFacturaPro" & _
        " where idEncFacturaPro = " & Me.idEncFacturaPro
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
