Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTDetDesproductoPais

    Private _idDetDesProductoPais As Integer
    Private _idEncDesProductoPais As Integer
    Private _idProducto As Integer
    Private _cantdetDesProductoPais As Integer
    Private _valorDetDesProductoPais As Integer
    Private _subtotalDetDesProductoPais As Double
    Private _ncajasDetDesProductoPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idDetDesProductoPais As Integer
        Get
            Return _idDetDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _idDetDesProductoPais = value
        End Set
    End Property

    Public Property idEncDesProductoPais As Integer
        Get
            Return _idEncDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _idEncDesProductoPais = value
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

    Public Property cantdetDesProductoPais As Integer
        Get
            Return _cantdetDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _cantdetDesProductoPais = value
        End Set
    End Property

    Public Property valorDetDesProductoPais As Integer
        Get
            Return _valorDetDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _valorDetDesProductoPais = value
        End Set
    End Property

    Public Property subtotalDetDesProductoPais As Double
        Get
            Return _subtotalDetDesProductoPais
        End Get
        Set(ByVal value As Double)
            _subtotalDetDesProductoPais = value
        End Set
    End Property

    Public Property ncajasDetDesProductoPais As Integer
        Get
            Return _ncajasDetDesProductoPais
        End Get
        Set(ByVal value As Integer)
            _ncajasDetDesProductoPais = value
        End Set
    End Property

    Sub grabarTTDetDesproductoPais()
        Dim sql As String
        sql = "exec sp_actualizaTTDetDesproductoPais " & _
        "@idDetDesProductoPais='" & Me.idDetDesProductoPais & "'," & _
        "@idEncDesProductoPais='" & Me.idEncDesProductoPais & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantdetDesProductoPais='" & Me.cantdetDesProductoPais & "'," & _
        "@valorDetDesProductoPais='" & Me.valorDetDesProductoPais & "'," & _
        "@subtotalDetDesProductoPais='" & Me.subtotalDetDesProductoPais & "'," & _
        "@ncajasDetDesProductoPais='" & Me.ncajasDetDesProductoPais & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerDetalleDespachoPorIdPedido() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TTDetDesproductoPais where idEncDesProductoPais=" & Me.idEncDesProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function detalleDespacho() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "ttDetDesProductoPaisPais.idDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.idEncDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantEnvDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantRecDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.cantPenDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.valorDetDesProductoPaisPais," & _
        "ttDetDesProductoPaisPais.subtotalDetDesProductoPaisPais," & _
        "TBProducto.idProducto," & _
        "TBProducto.nombreProducto" & _
        " FROM" & _
        " ttDetDesProductoPaisPais INNER JOIN" & _
        " TBProducto ON ttDetDesProductoPaisPais.idProducto = TBProducto.idProducto" & _
        " where ttDetDesProductoPaisPais.idEncDesProductoPaisPais=" & Me.idEncDesProductoPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
