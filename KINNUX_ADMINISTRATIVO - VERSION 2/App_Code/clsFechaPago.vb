Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsFechaPago

    Private _idFechaPago As Integer
    Private _idCampana As Integer
    Private _fechaPago As Date
    Private _numeroCuota As Integer
    Dim objOperacione As New clsOperacione


    Public Property idFechaPago As Integer
        Get
            Return _idFechaPago
        End Get
        Set(ByVal value As Integer)
            _idFechaPago = value
        End Set
    End Property

    Public Property idCampana As Integer
        Get
            Return _idCampana
        End Get
        Set(ByVal value As Integer)
            _idCampana = value
        End Set
    End Property

    Public Property fechaPago As Date
        Get
            Return _fechaPago
        End Get
        Set(ByVal value As Date)
            _fechaPago = value
        End Set
    End Property

    Public Property numeroCuota As Integer
        Get
            Return _numeroCuota
        End Get
        Set(ByVal value As Integer)
            _numeroCuota = value
        End Set
    End Property

    Sub actualizarFechasDePago(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaFechasDePago " & _
        "@idFechaPago='" & Me.idFechaPago & "'," & _
        "@idCampana='" & Me.idCampana & "'," & _
        "@fechaPago='" & Me.fechaPago.ToString("yyyyMMdd") & "'," & _
        "@numeroCuota='" & Me.numeroCuota & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerFechaDePagoPorCampanayPorCuota() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TBFechaPago " & _
            " where idcampana=" & Me.idCampana & " and" & _
            " numeroCuota=" & Me.numeroCuota
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
