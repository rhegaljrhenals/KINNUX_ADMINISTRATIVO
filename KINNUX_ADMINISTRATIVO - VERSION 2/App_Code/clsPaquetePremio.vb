Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePremio

    Private _idPaqPremio As Integer
    Private _idPremio As Integer
    Private _cantPaqPremio As Integer
    Private _accionDetallePremio As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPremio As Integer
        Get
            Return _idPaqPremio
        End Get
        Set(ByVal value As Integer)
            _idPaqPremio = value
        End Set
    End Property

    Public Property idPremio As Integer
        Get
            Return _idPremio
        End Get
        Set(ByVal value As Integer)
            _idPremio = value
        End Set
    End Property


    Public Property cantPaqPremio As Integer
        Get
            Return _cantPaqPremio
        End Get
        Set(ByVal value As Integer)
            _cantPaqPremio = value
        End Set
    End Property

    Public Property accionDetallePremio As Integer
        Get
            Return _accionDetallePremio
        End Get
        Set(ByVal value As Integer)
            _accionDetallePremio = value
        End Set
    End Property

    Sub grabarPaquetePremio(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePremio " & _
        "@idPaqPremio='" & Me.idPaqPremio & "'," & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@cantPaqPremio='" & Me.cantPaqPremio & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePremio='" & Me.accionDetallePremio & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPremioPorIdPaquete(ByVal idPaquete As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPremio where idPaquete=" & idPaquete & " order by idPremio"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
