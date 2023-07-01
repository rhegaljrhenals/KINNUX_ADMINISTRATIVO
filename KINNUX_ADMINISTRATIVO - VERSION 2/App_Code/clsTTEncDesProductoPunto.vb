Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTEncDesProductoPunto

    Private _idEmpresa As Integer
    Private _idSucursal As Integer
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _idProducto As Integer
    Dim objOperaciones As New clsOperacione

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(value As Integer)
            _idSucursal = value
        End Set
    End Property

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
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

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Function obtenerDespachosaPuntos() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncDesProductoPunto.idEncDesProductoPunto," & _
        "TTEncDesProductoPunto.fechaEncDesProductoPunto," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal," & _
        "TTEncDesProductoPunto.idEncPedProductoPais," & _
        "TTEncDesProductoPunto.valorEncDesProductoPunto," & _
        "TTEncDesProductoPunto.guiaEncDesProductoPunto," & _
        "TTEncDesProductoPunto.dirEnvEncDesProductoPunto," & _
        "TTEncDesProductoPunto.observEncDesProductoPunto," & _
        "TTEncDesProductoPunto.procesadoEncDesProductoPunto," & _
        "TTEncDesProductoPunto.confirEncDesProductoPunto," & _
        "TTEncDesProductoPunto.estadoEndDesProductoPunto," & _
        "TTDetDesProductoPunto.cantEnvDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantRecDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantPenDetDesProductoPunto," & _
        "TTDetDesProductoPunto.valorDetDesProductoPunto," & _
        "TTDetDesProductoPunto.subtotalDetDesProductoPunto," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncDesProductoPunto INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPunto.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncDesProductoPunto.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncDesProductoPunto.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTDetDesProductoPunto ON " & _
        " TTEncDesProductoPunto.idEncDesProductoPunto = TTDetDesProductoPunto.idEncDesProductoPunto INNER JOIN" & _
        " TBProducto ON TTDetDesProductoPunto.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TBProducto.idProducto=" & Me.idProducto & " and" & _
        " TTEncDesProductoPunto.fechaEncDesProductoPunto between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " dbo.TBEmpresa.idEmpresa = " & Me.idEmpresa & " and" & _
        " TTEncDesProductoPunto.confirEncDesProductoPunto='si'" & _
        " order by TTEncDesProductoPunto.fechaEncDesProductoPunto"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDespachosaSucursales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncDesProductoPunto.idEncDesProductoPunto," & _
        "TTEncDesProductoPunto.fechaEncDesProductoPunto," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal," & _
        "TTEncDesProductoPunto.idEncPedProductoPais," & _
        "TTEncDesProductoPunto.valorEncDesProductoPunto," & _
        "TTEncDesProductoPunto.guiaEncDesProductoPunto," & _
        "TTEncDesProductoPunto.dirEnvEncDesProductoPunto," & _
        "TTEncDesProductoPunto.observEncDesProductoPunto," & _
        "TTEncDesProductoPunto.procesadoEncDesProductoPunto," & _
        "TTEncDesProductoPunto.confirEncDesProductoPunto," & _
        "TTEncDesProductoPunto.estadoEndDesProductoPunto," & _
        "TTDetDesProductoPunto.cantEnvDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantRecDetDesProductoPunto," & _
        "TTDetDesProductoPunto.cantPenDetDesProductoPunto," & _
        "TTDetDesProductoPunto.valorDetDesProductoPunto," & _
        "TTDetDesProductoPunto.subtotalDetDesProductoPunto," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " TTEncDesProductoPunto INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPunto.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncDesProductoPunto.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncDesProductoPunto.idSucursal = dbo.TBSucursal.idSucursal INNER JOIN" & _
        " TTDetDesProductoPunto ON " & _
        " TTEncDesProductoPunto.idEncDesProductoPunto = TTDetDesProductoPunto.idEncDesProductoPunto INNER JOIN" & _
        " TBProducto ON TTDetDesProductoPunto.idProducto = TBProducto.idProducto" & _
        " where" & _
        " TBProducto.idProducto=" & Me.idProducto & " and" & _
        " TTEncDesProductoPunto.fechaEncDesProductoPunto between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "' and" & _
        " dbo.TBEmpresa.idEmpresa = " & Me.idEmpresa & " and" & _
        " dbo.TBSucursal.idSucursal=" & Me.idSucursal & _
        " and TTEncDesProductoPunto.confirEncDesProductoPunto='si'" & _
        " order by TTEncDesProductoPunto.fechaEncDesProductoPunto"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDespachosPorEmpresas(ByVal tipoProceso As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncDesProductoPunto.idEncDesProductoPunto," & _
        "TTEncDesProductoPunto.fechaEncDesProductoPunto," & _
        "TTEncDesProductoPunto.idEncPedProductoPais," & _
        "TTEncDesProductoPunto.valorEncDesProductoPunto," & _
        "TTEncDesProductoPunto.guiaEncDesProductoPunto," & _
        "TTEncDesProductoPunto.dirEnvEncDesProductoPunto," & _
        "TTEncDesProductoPunto.observEncDesProductoPunto," & _
        "TTEncDesProductoPunto.procesadoEncDesProductoPunto," & _
        "TTEncDesProductoPunto.confirEncDesProductoPunto," & _
        "TTEncDesProductoPunto.estadoEndDesProductoPunto," & _
        "dbo.TBEmpresa.idEmpresa," & _
        "dbo.TBEmpresa.nombreEmpresa," & _
        "dbo.TBSucursal.idSucursal," & _
        "dbo.TBSucursal.nombreSucursal" & _
        " FROM" & _
        " TTEncDesProductoPunto INNER JOIN" & _
        " dbo.TBEmpresa ON TTEncDesProductoPunto.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TTEncDesProductoPunto.idEmpresa = dbo.TBSucursal.idEmpresa AND " & _
        " TTEncDesProductoPunto.idSucursal = dbo.TBSucursal.idSucursal" & _
        " where" & _
        " dbo.TBEmpresa.idEmpresa = " & Me.idEmpresa & _
        " and tbSucursal.idSucursal = " & Me.idSucursal & " and" & _
        " TTEncDesProductoPunto.fechaEncDesProductoPunto between '" & Me.fechaInicial.ToString("yyyy/MM/dd") & "' and '" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'"
        Select Case tipoProceso
            Case Is = 1
                sql = sql & " and TTEncDesProductoPunto.confirEncDesProductoPunto='Si'"
            Case Is = 2
                sql = sql & " and TTEncDesProductoPunto.confirEncDesProductoPunto='No'"
            Case Is = 3
                sql = sql & " and TTEncDesProductoPunto.confirEncDesProductoPunto='Pr'"
            Case Is = 4
                sql = sql & " and TTEncDesProductoPunto.estadoEndDesProductoPunto=0"
            Case Is = 5
                sql = sql & " and TTEncDesProductoPunto.estadoEndDesProductoPunto=1"
        End Select
        sql = sql & " Order by TTEncDesProductoPunto.fechaEncDesProductoPunto desc"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
