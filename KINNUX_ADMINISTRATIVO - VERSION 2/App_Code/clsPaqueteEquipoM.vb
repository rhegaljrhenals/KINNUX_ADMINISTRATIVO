Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaqueteEquipoM

    Private _idPaqEquipoM As Integer
    Private _idEquipoM As Integer
    Private _cantPaqEquipoM As Integer
    Private _accionDetalleEquipoM As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqEquipoM As Integer
        Get
            Return _idPaqEquipoM
        End Get
        Set(ByVal value As Integer)
            _idPaqEquipoM = value
        End Set
    End Property

    Public Property idEquipoM As Integer
        Get
            Return _idEquipoM
        End Get
        Set(ByVal value As Integer)
            _idEquipoM = value
        End Set
    End Property

    Public Property cantPaqEquipoM As Integer
        Get
            Return _cantPaqEquipoM
        End Get
        Set(ByVal value As Integer)
            _cantPaqEquipoM = value
        End Set
    End Property

    Public Property accionDetalleEquipoM As Integer
        Get
            Return _accionDetalleEquipoM
        End Get
        Set(ByVal value As Integer)
            _accionDetalleEquipoM = value
        End Set
    End Property

    Sub grabarPaqueteEquiposM(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaqueteEquipos " & _
        "@idPaqEquipoM='" & Me.idPaqEquipoM & "'," & _
        "@idEquipoM='" & Me.idEquipoM & "'," & _
        "@cantPaqEquipoM='" & Me.cantPaqEquipoM & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetalleEquipoM='" & Me.accionDetalleEquipoM & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerEquiposMPorIdPaquete(ByVal idPaquete As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqEquipoM where idPaquete=" & idPaquete & " order by idEquipoM"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
