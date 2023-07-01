Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteProducto

    Private _idPaqProducto As Integer
    Private _idProducto As Integer
    Private _cantPaqProducto As Integer
    Private _accionDetalleProducto As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqProducto As Integer
        Get
            Return _idPaqProducto
        End Get
        Set(ByVal value As Integer)
            _idPaqProducto = value
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


    Public Property cantPaqProducto As Integer
        Get
            Return _cantPaqProducto
        End Get
        Set(ByVal value As Integer)
            _cantPaqProducto = value
        End Set
    End Property

    Public Property accionDetalleProducto As Integer
        Get
            Return _accionDetalleProducto
        End Get
        Set(ByVal value As Integer)
            _accionDetalleProducto = value
        End Set
    End Property

    Sub grabarPaqueteProducto(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteProducto " & _
        "@idPaqProducto='" & Me.idPaqProducto & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantPaqProducto='" & Me.cantPaqProducto & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleProducto='" & Me.accionDetalleProducto & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosPorIdPaquete(ByVal idPaquete As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqProducto where idPaquete=" & idPaquete & " order by idProducto"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
