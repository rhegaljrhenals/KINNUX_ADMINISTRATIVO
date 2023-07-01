Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteProductoPromocion

    Private _idPaqProductoProm As Integer
    Private _idProducto As Integer
    Private _idPromocion As Integer
    Private _cantPaqProductoProm As Integer
    Private _accionDetalleProductoProm As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqProductoProm As Integer
        Get
            Return _idPaqProductoProm
        End Get
        Set(ByVal value As Integer)
            _idPaqProductoProm = value
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

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
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

    Public Property cantPaqProductoProm As Integer
        Get
            Return _cantPaqProductoProm
        End Get
        Set(ByVal value As Integer)
            _cantPaqProductoProm = value
        End Set
    End Property

    Public Property accionDetalleProductoProm As Integer
        Get
            Return _accionDetalleProductoProm
        End Get
        Set(ByVal value As Integer)
            _accionDetalleProductoProm = value
        End Set
    End Property

    Sub grabarPaqueteProductoProm(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteProductoPromocion " & _
        "@idPaqProductoProm='" & Me.idPaqProductoProm & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantPaqProductoProm='" & Me.cantPaqProductoProm & "'," & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleProductoProm='" & Me.accionDetalleProductoProm & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosPorIdPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqProductoProm where idPromocion=" & Me.idPromocion & " order by idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
