Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteProductoObs

    Private _idPaqProductoObs As Integer
    Private _idProducto As Integer
    Private _idObsequio As Integer
    Private _cantPaqProductoObs As Integer
    Private _accionDetalleProductoObs As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqProductoObs As Integer
        Get
            Return _idPaqProductoObs
        End Get
        Set(ByVal value As Integer)
            _idPaqProductoObs = value
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

    Public Property idObsequio As Integer
        Get
            Return _idObsequio
        End Get
        Set(ByVal value As Integer)
            _idObsequio = value
        End Set
    End Property

    Public Property cantPaqProductoObs As Integer
        Get
            Return _cantPaqProductoObs
        End Get
        Set(ByVal value As Integer)
            _cantPaqProductoObs = value
        End Set
    End Property

    Public Property accionDetalleProductoObs As Integer
        Get
            Return _accionDetalleProductoObs
        End Get
        Set(ByVal value As Integer)
            _accionDetalleProductoObs = value
        End Set
    End Property

    Sub grabarPaqueteProductoObs(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteProductoObs " & _
        "@idPaqProductoObs='" & Me.idPaqProductoObs & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantPaqProductoObs='" & Me.cantPaqProductoObs & "'," & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleProductoObs='" & Me.accionDetalleProductoObs & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosPorIdObs() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqProductoObs where idObsequio=" & Me.idObsequio & " order by idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
