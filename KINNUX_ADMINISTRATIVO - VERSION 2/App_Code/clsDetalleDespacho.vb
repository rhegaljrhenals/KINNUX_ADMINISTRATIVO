Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsDetalleDespacho

    Private _idDetalleDespacho As Integer
    Private _idProducto As Integer
    Private _cantidadDetalleDespacho As Long
    Private _precioDetalledespacho As Long
    Private _tipoEnvio As String
    Dim objOperacione As New clsOperacione

    Public Property idDetalleDespacho As Integer
        Get
            Return _idDetalleDespacho
        End Get
        Set(ByVal value As Integer)
            _idDetalleDespacho = value
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

    Public Property cantidadDetalleDespacho As Long
        Get
            Return _cantidadDetalleDespacho
        End Get
        Set(ByVal value As Long)
            _cantidadDetalleDespacho = value
        End Set
    End Property

    Public Property precioDetalledespacho As Long
        Get
            Return _precioDetalledespacho
        End Get
        Set(ByVal value As Long)
            _precioDetalledespacho = value
        End Set
    End Property

    Public Property tipoEnvio As String
        Get
            Return _tipoEnvio
        End Get
        Set(ByVal value As String)
            _tipoEnvio = value
        End Set
    End Property

    Sub actualizaDetalleDespacho(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaDetalleDepacho " & _
        "@idDetalleDespacho='" & Me.idDetalleDespacho & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantidadDetalleDespacho='" & Me.cantidadDetalleDespacho & "'," & _
        "@precioDetalledespacho='" & Me.precioDetalledespacho & "'," & _
        "@accion='" & accion & "'," & _
        "@tipoEnvio='" & Me.tipoEnvio & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerDetalleDespachoPorId(ByVal idEncabezado As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTDetalleDespacho where idEncabezadodespacho=" & idEncabezado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
