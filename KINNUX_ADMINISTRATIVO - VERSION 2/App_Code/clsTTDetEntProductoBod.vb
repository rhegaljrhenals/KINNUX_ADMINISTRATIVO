Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetEntProductoBod

    Private _idDetEntProductoBod As Integer
    Private _idEncEntProductoBod As Integer
    Private _idProducto As Integer
    Private _cantDetEntProductoBod As Integer
    Private _valorDetEntProductoBod As Double
    Private _subtotalDetEntProductoBod As Double
    Private _cantRecDetEntProductoBod As Integer
    Private _ncajasDetEntproductoBod As Integer
    Dim objOperacione As New clsOperacione

    Public Property idDetEntProductoBod As Integer
        Get
            Return _idDetEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _idDetEntProductoBod = value
        End Set
    End Property

    Public Property idEncEntProductoBod As Integer
        Get
            Return _idEncEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _idEncEntProductoBod = value
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

    Public Property cantDetEntProductoBod As Integer
        Get
            Return _cantDetEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantDetEntProductoBod = value
        End Set
    End Property

    Public Property valorDetEntProductoBod As Double
        Get
            Return _valorDetEntProductoBod
        End Get
        Set(ByVal value As Double)
            _valorDetEntProductoBod = value
        End Set
    End Property

    Public Property subtotalDetEntProductoBod As Double
        Get
            Return _subtotalDetEntProductoBod
        End Get
        Set(ByVal value As Double)
            _subtotalDetEntProductoBod = value
        End Set
    End Property

    Public Property cantRecDetEntProductoBod As Integer
        Get
            Return _cantRecDetEntProductoBod
        End Get
        Set(ByVal value As Integer)
            _cantRecDetEntProductoBod = value
        End Set
    End Property

    Public Property ncajasDetEntproductoBod As Integer
        Get
            Return _ncajasDetEntproductoBod
        End Get
        Set(ByVal value As Integer)
            _ncajasDetEntproductoBod = value
        End Set
    End Property

    Sub grabarTTDetEntProductoBod()
        Dim sql As String
        sql = "exec sp_actualizaTTDetEntProductoBod " & _
        "@idDetEntProductoBod='" & Me.idDetEntProductoBod & "'," & _
        "@idEncEntProductoBod='" & Me.idEncEntProductoBod & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantDetEntProductoBod='" & Me.cantDetEntProductoBod & "'," & _
        "@valorDetEntProductoBod='" & Me.valorDetEntProductoBod & "'," & _
        "@subtotalDetEntProductoBod='" & Me.subtotalDetEntProductoBod & "'," & _
        "@cantRecDetEntProductoBod='" & Me.cantRecDetEntProductoBod & "'," & _
        "@ncajasDetEntproductoBod='" & Me.ncajasDetEntproductoBod & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function ObtenerDetEntProductoBodPorIdEntrada() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TTDetEntProductoBod.idDetEntProductoBod," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto," & _
        "TTDetEntProductoBod.idEncEntProductoBod," & _
        "TTDetEntProductoBod.cantDetEntProductoBod," & _
        "TTDetEntProductoBod.valorDetEntProductoBod," & _
        "TTDetEntProductoBod.subtotalDetEntProductoBod," & _
        "TTDetEntProductoBod.ncajasDetEntproductoBod" & _
        " FROM" & _
        " TTDetEntProductoBod INNER JOIN" & _
        " TBProducto ON TTDetEntProductoBod.idProducto = TBProducto.idProducto" & _
        " where TTDetEntProductoBod.idEncEntProductoBod=" & Me.idEncEntProductoBod
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
