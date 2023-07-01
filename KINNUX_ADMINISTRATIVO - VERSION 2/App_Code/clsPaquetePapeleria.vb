Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePapeleria

    Private _idPaqPapeleria As Integer
    Private _idPapeleria As Integer
    Private _cantPaqPapeleria As Integer
    Private _accionDetallePapeleria As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPapeleria As Integer
        Get
            Return _idPaqPapeleria
        End Get
        Set(ByVal value As Integer)
            _idPaqPapeleria = value
        End Set
    End Property

    Public Property idPapeleria As Integer
        Get
            Return _idPapeleria
        End Get
        Set(ByVal value As Integer)
            _idPapeleria = value
        End Set
    End Property


    Public Property cantPaqPapeleria As Integer
        Get
            Return _cantPaqPapeleria
        End Get
        Set(ByVal value As Integer)
            _cantPaqPapeleria = value
        End Set
    End Property

    Public Property accionDetallePapeleria As Integer
        Get
            Return _accionDetallePapeleria
        End Get
        Set(ByVal value As Integer)
            _accionDetallePapeleria = value
        End Set
    End Property

    Sub grabarPaquetePapeleria(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePapeleria " & _
        "@idPaqPapeleria='" & Me.idPaqPapeleria & "'," & _
        "@idPapeleria='" & Me.idPapeleria & "'," & _
        "@cantPaqPapeleria='" & Me.cantPaqPapeleria & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePapeleria='" & Me.accionDetallePapeleria & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleriaPorIdPaquete(ByVal idPaquete As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPapeleria where idPaquete=" & idPaquete & " order by idPapeleria"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
