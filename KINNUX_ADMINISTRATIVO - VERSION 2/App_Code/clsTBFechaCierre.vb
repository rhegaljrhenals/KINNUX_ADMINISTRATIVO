Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTBFechaCierre

    Private _idFechaCierre As Integer
    Private _fechaInicio As Date
    Private _fechaFinal As Date
    Private _fechaAcomparar As Date
    Dim objOperacione As New clsOperacione

    Public Property idFechaCierre As Integer
        Get
            Return _idFechaCierre
        End Get
        Set(ByVal value As Integer)
            _idFechaCierre = value
        End Set
    End Property

    Public Property fechaAcomparar As Date
        Get
            Return _fechaAcomparar
        End Get
        Set(ByVal value As Date)
            _fechaAcomparar = value
        End Set
    End Property

    Public Property fechaInicio As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property

    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    ' funcion para validar las fechas de cierre de las remisiones
    Function validaFechasDeCierre() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "exec sp_actualizaTBFechaCierreValidaFecha " & _
        "@fecha='" & Me.fechaAcomparar.ToString("yyyy/MM/dd") & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener las fechas de cierre
    Function mostrarFechas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBFechaCierre"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para actualizar las fechas
    Sub actualizaFechas()
        Dim sql As String
        sql = "exec sp_actualizaTBFechaCierre " & _
        "@idFechaCierre='" & Me.idFechaCierre & "'," & _
        "@fechaInicio='" & Me.fechaInicio.ToString("yyyy/MM/dd") & "'," & _
        "@fechaFinal='" & Me.fechaFinal.ToString("yyyy/MM/dd") & "'," & _
        "@accion='2'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub
End Class
