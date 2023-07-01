Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsDetalleEntrada

    Private _idDetalleEntrada As Integer
    Private _idEncabezadoEntrada As Integer
    Private _idProducto As Integer
    Private _cantidadDetalleEntrada As Integer
    Private _precioDetalleEntrada As Long
    Private _tipoEntrada As String
    Dim objOperacione As New clsOperacione

    Public Property idDetalleEntrada As Integer
        Get
            Return _idDetalleEntrada
        End Get
        Set(ByVal value As Integer)
            _idDetalleEntrada = value
        End Set
    End Property

    Public Property idEncabezadoEntrada As Integer
        Get
            Return _idEncabezadoEntrada
        End Get
        Set(ByVal value As Integer)
            _idEncabezadoEntrada = value
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

    Public Property cantidadDetalleEntrada As Integer
        Get
            Return _cantidadDetalleEntrada
        End Get
        Set(ByVal value As Integer)
            _cantidadDetalleEntrada = value
        End Set
    End Property

    Public Property precioDetalleEntrada As Long
        Get
            Return _precioDetalleEntrada
        End Get
        Set(ByVal value As Long)
            _precioDetalleEntrada = value
        End Set
    End Property

    Public Property tipoEntrada As String
        Get
            Return _tipoEntrada
        End Get
        Set(ByVal value As String)
            _tipoEntrada = value
        End Set
    End Property

    Sub actualizardetalleEntrada(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaDetalleEntrada " & _
        "@idDetalleEntrada='" & Me.idDetalleEntrada & "'," & _
        "@idEncabezadoEntrada='" & Me.idEncabezadoEntrada & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantidadDetalleEntrada='" & Me.cantidadDetalleEntrada & "'," & _
        "@precioDetalleEntrada='" & Me.precioDetalleEntrada & "'," & _
        "@tipoEntrada='" & Me.tipoEntrada & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerDetalleEntradaPorId() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TTDetalleEntrada where idEncabezadoEntrada=" & Me.idEncabezadoEntrada
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


End Class
