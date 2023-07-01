Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsMensajeBienvenida

    Private _idMensaje As Integer
    Private _descripcionMensaje As String
    Dim objOperacione As New clsOperacione

    Public Property idMensaje As Integer
        Get
            Return _idMensaje
        End Get
        Set(ByVal value As Integer)
            _idMensaje = value
        End Set
    End Property

    Public Property descripcionMensaje As String
        Get
            Return _descripcionMensaje
        End Get
        Set(ByVal value As String)
            _descripcionMensaje = value
        End Set
    End Property

    Function mensajeAfiliacion() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TBMensaje where idMensaje=" & Me.idMensaje
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
