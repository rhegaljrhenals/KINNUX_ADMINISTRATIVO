Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsConceptoGastos

    Private _idConcepto As Integer
    Private _nombreGasto As String
    Private _estadoConcepto As Integer
    Dim operaciones As New clsOperacione

    Public Property estadoConcepto As Integer
        Get
            Return _estadoConcepto
        End Get
        Set(value As Integer)
            _estadoConcepto = value
        End Set
    End Property

    Public Property idConcepto As Integer
        Get
            Return _idConcepto
        End Get
        Set(value As Integer)
            _idConcepto = value
        End Set
    End Property

    Public Property nombreGasto As String
        Get
            Return _nombreGasto
        End Get
        Set(value As String)
            _nombreGasto = value
        End Set
    End Property

    Sub grabarConcepto(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_TBConceptoGasto " & _
        "@idConceptoGasto='" & Me.idConcepto & "'," & _
        "@nombreConceptoGasto='" & Me.nombreGasto.ToUpper & "'," & _
        "@estadoConceptoGasto='" & Me.estadoConcepto & "'," & _
        "@accion='" & accion & "'"
        With operaciones
            .Accion(sql)
        End With
    End Sub

    Function obtenerConceptoDeGastos() As datatable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "idconceptogasto," & _
        "nombreconceptogasto," & _
        " case estadoConceptoGasto" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Eliminado'" & _
        " else ''" & _
        " end estado" & _
        " from TBConceptoGasto"
        With operaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
