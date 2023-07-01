Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsExistenciaBodegaPrincipal

    Private _idExistenciaBodega As Integer
    Private _idProducto As Integer
    Private _cantidad As Integer
    Private _tipoProducto As String
    Dim objOperacione As New clsOperacione

    Public Property idExistenciaBodega As Integer
        Get
            Return _idExistenciaBodega
        End Get
        Set(ByVal value As Integer)
            _idExistenciaBodega = value
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

    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property tipoProducto As String
        Get
            Return _tipoProducto
        End Get
        Set(ByVal value As String)
            _tipoProducto = value
        End Set
    End Property

    Sub actualizarExistenciaBodegaPrincipal(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaExistenciaBodegaPrincipal " & _
        "@idExistenciaBodega='" & Me.idExistenciaBodega & "'," & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantidad='" & Me.cantidad & "'," & _
        "@tipoProducto='" & Me.tipoProducto & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerProductosExistentesEnBodega() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TBencabezadoColeccione.idColeccion," & _
        "TBencabezadoColeccione.nombreColeccion" & _
        " FROM" & _
        " TBencabezadoColeccione INNER JOIN TTExistenciaBodegaPrincipal" & _
        " ON TBencabezadoColeccione.idColeccion = TTExistenciaBodegaPrincipal.idProducto" & _
        " where TBencabezadoColeccione.idTipoPaquete='1'" & _
        " and TTExistenciaBodegaPrincipal.cantidad>0" & _
        " order by TBencabezadoColeccione.idColeccion"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Sub actualizarExistenciaBodegaPrincipalDisminuir()
        Dim sql As String
        sql = "exec sp_actualizaExistenciaBodegaPrincipalDisminuye " & _
        "@idProducto='" & Me.idProducto & "'," & _
        "@cantidad='" & Me.cantidad & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleriaExistentesEnBodega() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TBpapeleria.idPapeleria," & _
        "TBpapeleria.nombrePapeleria" & _
        " FROM" & _
        " TBpapeleria INNER JOIN TTExistenciaBodegaPrincipal" & _
        " ON TBpapeleria.idPapeleria = TTExistenciaBodegaPrincipal.idProducto" & _
        " where TTExistenciaBodegaPrincipal.tipoProducto='PAP'" & _
        " and TTExistenciaBodegaPrincipal.cantidad>0" & _
        " order by TBpapeleria.idPapeleria"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    
End Class
