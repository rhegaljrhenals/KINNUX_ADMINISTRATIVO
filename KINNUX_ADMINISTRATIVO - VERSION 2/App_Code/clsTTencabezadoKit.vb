Imports Microsoft.VisualBasic

Public Class clsTTencabezadoKit

    Private _idKit As Integer
    Private _nombreKit As String
    Private _puntosKit As Integer
    Private _estadoKit As Integer
    Private _accion As Integer
    Dim objOperacione As New clsOperacione


    Public Property idKit As Integer
        Get
            Return _idKit
        End Get
        Set(ByVal value As Integer)
            _idKit = value
        End Set
    End Property

    Public Property nombreKit As String
        Get
            Return _nombreKit
        End Get
        Set(ByVal value As String)
            _nombreKit = value
        End Set
    End Property

    Public Property puntosKit As Integer
        Get
            Return _puntosKit
        End Get
        Set(ByVal value As Integer)
            _puntosKit = value
        End Set
    End Property

    Public Property estadoKit As Integer
        Get
            Return _estadoKit
        End Get
        Set(ByVal value As Integer)
            _estadoKit = value
        End Set
    End Property

    Sub grabarTTencabezadoKit(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaTTencabezadoKit " & _
        "@idKit='" & Me.idKit & "'," & _
        "@nombreKit='" & Me.nombreKit.ToUpper & "'," & _
        "@puntosKit='" & Me.puntosKit & "'," & _
        "@estadoKit='" & Me.estadoKit & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub


End Class
