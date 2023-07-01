Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTDetPedProductoBod

    Private _idEncPedProductoBod As Integer
    Private _idDetPedProductoBod As Integer
    Private _idProducto As Integer
    Private _cantDetPedProductoBod As Double
    Private _cantEntregaDetPedProductoBod As Double
    Private _valorDetPedProductoBod As Double
    Private _subtotalDetPedProductoBod As Double
    Dim objOperacione As New clsOperacione

    Public Property idEncPedProductoBod As Integer
        Get
            Return _idEncPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncPedProductoBod = value
        End Set
    End Property

    Public Property idDetPedProductoBod As Integer
        Get
            Return _idDetPedProductoBod
        End Get
        Set(ByVal value As Integer)
            _idDetPedProductoBod = value
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

    Public Property cantDetPedProductoBod As Double
        Get
            Return _cantDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _cantDetPedProductoBod = value
        End Set
    End Property

    Public Property cantEntregaDetPedProductoBod As Double
        Get
            Return _cantEntregaDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _cantEntregaDetPedProductoBod = value
        End Set
    End Property

    Public Property valorDetPedProductoBod As Double
        Get
            Return _valorDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _valorDetPedProductoBod = value
        End Set
    End Property

    Public Property subtotalDetPedProductoBod As Double
        Get
            Return _subtotalDetPedProductoBod
        End Get
        Set(ByVal value As Double)
            _subtotalDetPedProductoBod = value
        End Set
    End Property

    Sub actualizaTTDetPedProductoBodcantEntregaDetPedProductoBod()
        Dim sql As String
        sql = "exec sp_actualizaTTDetPedProductoBodcantEntregaDetPedProductoBod " & _
        "@idEncPedProductoBod='" & Me.idEncPedProductoBod & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantEntregaDetPedProductoBod='" & Me.cantEntregaDetPedProductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
