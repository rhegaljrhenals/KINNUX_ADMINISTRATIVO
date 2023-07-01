Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTBodPuntoProducto
    Private _idBodPuntoProducto As Integer
    Private _idProducto As Integer
    Private _idSucursal As Integer
    Private _idEmpresa As Integer
    Private _cantBodPuntoProducto As Double
    Private _precioBodPuntoProducto As Double
    Dim objOperacione As New clsOperacione

    Public Property idBodPuntoProducto As Integer
        Get
            Return _idBodPuntoProducto
        End Get
        Set(ByVal value As Integer)
            _idBodPuntoProducto = value
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

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
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

    Public Property cantBodPuntoProducto As Double
        Get
            Return _cantBodPuntoProducto
        End Get
        Set(ByVal value As Double)
            _cantBodPuntoProducto = value
        End Set
    End Property

    Public Property precioBodPuntoProducto As Double
        Get
            Return _precioBodPuntoProducto
        End Get
        Set(ByVal value As Double)
            _precioBodPuntoProducto = value
        End Set
    End Property

    Sub grabarTTBodPuntoProducto()
        Dim sql As String
        sql = "exec sp_actualizaTTBodPuntoProducto " & _
        "@idBodPuntoProducto='" & Me.idBodPuntoProducto & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@cantBodPuntoProducto='" & Me.cantBodPuntoProducto & "'," & _
        "@precioBodPuntoProducto='" & Me.precioBodPuntoProducto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub actualizaTTBodPuntoProductoDisminuyeExistencias()
        Dim sql As String
        sql = "exec sp_actualizaTTBodPuntoProductoDisminuyeExistencias " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@cantBodPuntoProducto='" & Me.cantBodPuntoProducto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerExistenciasPorIdproducto() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTBodPuntoProducto " & _
            " where idProducto=" & Me.idProducto & " and" & _
            " idEmpresa=" & Me.idEmpresa & " and" & _
            " idSucursal=" & Me.idSucursal
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerExistenciasProductosTodos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTBodPuntoProducto.cantBodPuntoProducto" & _
        " FROM" & _
        " TTBodPuntoProducto INNER JOIN" & _
        " TBProducto ON TTBodPuntoProducto.idProducto = TBProducto.idProducto" & _
        " where idEmpresa=" & Me.idEmpresa & " and" & _
        " idSucursal=" & Me.idSucursal

        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para aumentar las existencias
    Sub aumentaExistenciasBodegaPunto()
        Dim sql As String
        sql = "exec sp_actualizaTTBodPuntoProductoAumentaExistencias " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@cantBodPuntoProducto='" & Me.cantBodPuntoProducto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
