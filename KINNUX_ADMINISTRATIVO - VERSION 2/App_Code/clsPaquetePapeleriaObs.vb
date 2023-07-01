Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePapeleriaObs

    Private _idPaqPapeleriaObs As Integer
    Private _idPapeleria As Integer
    Private _idObsequio As Integer
    Private _cantPaqPapeleriaObs As Integer
    Private _accionDetallePapeleriaObs As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPapeleriaObs As Integer
        Get
            Return _idPaqPapeleriaObs
        End Get
        Set(ByVal value As Integer)
            _idPaqPapeleriaObs = value
        End Set
    End Property

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
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

    Public Property idObsequio As Integer
        Get
            Return _idObsequio
        End Get
        Set(ByVal value As Integer)
            _idObsequio = value
        End Set
    End Property

    Public Property cantPaqPapeleriaObs As Integer
        Get
            Return _cantPaqPapeleriaObs
        End Get
        Set(ByVal value As Integer)
            _cantPaqPapeleriaObs = value
        End Set
    End Property

    Public Property accionDetallePapeleriaObs As Integer
        Get
            Return _accionDetallePapeleriaObs
        End Get
        Set(ByVal value As Integer)
            _accionDetallePapeleriaObs = value
        End Set
    End Property

    Sub grabarPaquetePapeleriaObs(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePapeleriaObs " & _
        "@idPaqPapeleriaObs='" & Me.idPaqPapeleriaObs & "'," & _
        "@idPapeleria='" & Me.idPapeleria & "'," & _
        "@cantPaqPapeleriaObs='" & Me.cantPaqPapeleriaObs & "'," & _
        "@idObsequio='" & Me.idObsequio & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePapeleriaObs='" & Me.accionDetallePapeleriaObs & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleriaPorIdObs() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPapeleriaObs where idObsequio=" & Me.idObsequio & " order by idPapeleria"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
