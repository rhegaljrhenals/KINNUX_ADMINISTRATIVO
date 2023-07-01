Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTablaRedBinaria

    Private _codigo As String
    Private _izquierda As String
    Private _derecha As String
    Public tablaBinaria As New DataTable
    Dim registro As DataRow

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property izquierda As String
        Get
            Return _izquierda
        End Get
        Set(ByVal value As String)
            _izquierda = value
        End Set
    End Property


    Public Property derecha As String
        Get
            Return _derecha
        End Get
        Set(ByVal value As String)
            _derecha = value
        End Set
    End Property

    Public Sub vaciarTabla()
        tablaBinaria.Rows.Clear()
        tablaBinaria.AcceptChanges()
        '
    End Sub

    Public Sub crearTablaBinaria()
        tablaBinaria.TableName = "tablaBinaria"
        Dim cCodigo As New DataColumn
        cCodigo.ColumnName = "codigo"
        cCodigo.DataType = System.Type.GetType("System.String")
        tablaBinaria.Columns.Add(cCodigo)
        '
        Dim cIzquierda As New DataColumn
        cIzquierda.ColumnName = "izquierda"
        cIzquierda.DataType = System.Type.GetType("System.String")
        tablaBinaria.Columns.Add(cIzquierda)
        '
        Dim cDerecha As New DataColumn
        cDerecha.ColumnName = "derecha"
        cDerecha.DataType = System.Type.GetType("System.String")
        tablaBinaria.Columns.Add(cDerecha)
        '
    End Sub

    Public Function grabarRegistro() As DataTable
        registro = tablaBinaria.NewRow
        registro.Item("codigo") = Me.codigo
        registro.Item("izquierda") = Me.izquierda
        registro.Item("derecha") = Me.derecha
        '
        tablaBinaria.Rows.Add(registro)
        tablaBinaria.AcceptChanges()
        Return tablaBinaria
    End Function

End Class
