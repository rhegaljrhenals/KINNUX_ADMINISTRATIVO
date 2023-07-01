Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsFabricanteProducto

    Private _IdColeccion As Integer
    Private _IdFabricante As Integer
    Dim objOperacione As New clsOperacione

    Public Property IdColeccion As Integer
        Get
            Return _IdColeccion
        End Get
        Set(ByVal value As Integer)
            _IdColeccion = value
        End Set
    End Property

    Public Property IdFabricante As Integer
        Get
            Return _IdFabricante
        End Get
        Set(ByVal value As Integer)
            _IdFabricante = value
        End Set
    End Property


    Sub GrabarFabricanteProducto(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaFabricanteProducto " & _
        "@idColeccion='" & Me.IdColeccion & "'," & _
        "@idFabricante='" & Me.IdFabricante & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtieneFabricantePorProducto() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from FabricanteProducto" & _
            " where idColeccion=" & Me.IdColeccion
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtieneFabricantePorProductoyIdColeccion() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from FabricanteProducto" & _
            " where idColeccion=" & Me.IdColeccion & " and idFabricante=" & Me.IdFabricante
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
