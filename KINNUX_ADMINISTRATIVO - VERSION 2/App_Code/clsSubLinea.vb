Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsSubLinea

    Private _idSubLinea As Integer
    Private _nombreSubLinea As String
    Private _estado As Integer
    Private _linea As Integer
    Dim objOperacione As New clsOperacione

    Public Property idSubLinea As Integer
        Get
            Return _idSubLinea
        End Get
        Set(ByVal value As Integer)
            _idSubLinea = value
        End Set
    End Property

    Public Property Linea As Integer
        Get
            Return _linea
        End Get
        Set(ByVal value As Integer)
            _linea = value
        End Set
    End Property

    Public Property NombreSubLinea As String
        Get
            Return _nombreSubLinea
        End Get
        Set(ByVal value As String)
            _nombreSubLinea = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

    Sub GrabarSubLinea(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaSubLinea " & _
        "@idSublinea='" & Me.idsublinea & "'," & _
        "@nombreSublinea='" & Me.NombreSubLinea & "'," & _
        "@estado='" & Me.Estado & "'," & _
        "@idLinea='" & Me.Linea & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function ConsultaSubLinea() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_mostrarSubLinea"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerSublineasPorLinea() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
         "TBsubLinea.idSublinea idsublinea, " & _
         "TBsubLinea.nombreSublinea nombresublinea, " & _
         "TBsubLinea.estado estado, " & _
         "TBlinea.idLinea idlinea, " & _
         "TBlinea.nombrelinea nombrelinea" & _
         " FROM" & _
        " TBsubLinea INNER JOIN TBlinea ON TBsubLinea.idLinea = TBlinea.idLinea"
        If Me.Linea <> 0 Then
            sql = sql & " where TBsubLinea.idLinea=" & Me.Linea
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
