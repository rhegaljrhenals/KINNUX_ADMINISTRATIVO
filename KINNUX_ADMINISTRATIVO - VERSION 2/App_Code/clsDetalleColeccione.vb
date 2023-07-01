Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsDetalleColeccione

    Private _IdDetalleColeccion As Integer
    Private _IdColeccion As Integer
    Private _IdProducto As Integer
    Private _Cantidad As Integer
    Private _idPais As Integer
    Private _accionDetalle As Integer

    Dim objOperacione As New clsOperacione

    Public Property IdDetalleColeccion As Integer
        Get
            Return _IdDetalleColeccion
        End Get
        Set(ByVal value As Integer)
            _IdDetalleColeccion = value
        End Set
    End Property

    Public Property accionDetalle As Integer
        Get
            Return _accionDetalle
        End Get
        Set(ByVal value As Integer)
            _accionDetalle = value
        End Set
    End Property


    Public Property IdColeccion As Integer
        Get
            Return _IdColeccion
        End Get
        Set(ByVal value As Integer)
            _IdColeccion = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As Integer)
            _IdProducto = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Pais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Sub GrabarDetalleColeccion(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaDetalleColeccione " & _
        "@idDetalleColeccion='" & Me.IdDetalleColeccion & "'," &
        "@idColeccion='" & Me.IdColeccion & "'," & _
        "@idProducto='" & Me.IdProducto & "'," & _
        "@cantidad='" & Me.Cantidad & "'," & _
        "@idPais='" & Me.Pais & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalle='" & Me.accionDetalle & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosPorIdColeccion() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT * " & _
        "from TBdetalleColeccione where idColeccion=" & Me.IdColeccion & " and" & _
        " idProducto=" & Me.IdProducto
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
