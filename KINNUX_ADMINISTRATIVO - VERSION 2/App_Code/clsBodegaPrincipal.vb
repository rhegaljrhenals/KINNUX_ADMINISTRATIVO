Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsBodegaPrincipal

    Private _idBodprincipal As Integer
    Private _idproducto As Integer
    Private _cantBodPrincipal As Integer
    Private _precioBodPrincipal As Double
    Dim objOperacione As New clsOperacione

    Public Property idBodprincipal As Integer
        Get
            Return _idBodprincipal
        End Get
        Set(ByVal value As Integer)
            _idBodprincipal = value
        End Set
    End Property

    Public Property idproducto As Integer
        Get
            Return _idproducto
        End Get
        Set(ByVal value As Integer)
            _idproducto = value
        End Set
    End Property

    Public Property cantBodPrincipal As Integer
        Get
            Return _cantBodPrincipal
        End Get
        Set(ByVal value As Integer)
            _cantBodPrincipal = value
        End Set
    End Property

    Public Property precioBodPrincipal As Double
        Get
            Return _precioBodPrincipal
        End Get
        Set(ByVal value As Double)
            _precioBodPrincipal = value
        End Set
    End Property

    Sub grabarEntradaBodegaPrincipal()
        Dim sql As String
        sql = "exec sp_actualizaBodPrincipal " & _
        "@idBodprincipal='" & Me.idBodprincipal & "'," & _
        "@idproducto='" & Me.idproducto & "'," & _
        "@cantBodPrincipal='" & Me.cantBodPrincipal & "'," & _
        "@precioBodPrincipal='" & Me.precioBodPrincipal & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub actualizaExistencias()
        Dim sql As String
        sql = "exec sp_actualizatBBodPrincipalRestaExistencia " & _
        "@idProducto='" & Me.idproducto & "'," & _
        "@cantidad='" & Me.cantBodPrincipal & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtieneExistenciaEnBodegaPorIdProducto() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select cantBodPrincipal from tBBodPrincipal where idProducto=" & Me.idproducto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizaExistenciaEntradaProductos()
        Dim sql As String
        sql = "exec sp_actualizaExistenciaBodPrincipalEntrada " & _
        "@idProducto='" & Me.idproducto & "'," & _
        "@cantBodPrincipal='" & Me.cantBodPrincipal & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerExistenciasBodegaPrincipal() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "tBBodPrincipal.cantBodPrincipal" & _
        " FROM" & _
        " tBBodPrincipal INNER JOIN" & _
        " TBProducto ON tBBodPrincipal.idproducto = TBProducto.idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
