Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePapeleriaProm

    Private _idPaqPapeleriaProm As Integer
    Private _idPapeleria As Integer
    Private _idPromocion As Integer
    Private _cantPaqPapeleriaProm As Integer
    Private _accionDetallePapeleriaProm As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPapeleriaProm As Integer
        Get
            Return _idPaqPapeleriaProm
        End Get
        Set(ByVal value As Integer)
            _idPaqPapeleriaProm = value
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

    Public Property idPromocion As Integer
        Get
            Return _idPromocion
        End Get
        Set(ByVal value As Integer)
            _idPromocion = value
        End Set
    End Property

    Public Property cantPaqPapeleriaProm As Integer
        Get
            Return _cantPaqPapeleriaProm
        End Get
        Set(ByVal value As Integer)
            _cantPaqPapeleriaProm = value
        End Set
    End Property

    Public Property accionDetallePapeleriaProm As Integer
        Get
            Return _accionDetallePapeleriaProm
        End Get
        Set(ByVal value As Integer)
            _accionDetallePapeleriaProm = value
        End Set
    End Property

    Sub grabarPaquetePapeleriaProm(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePapeleriaPromocion " & _
        "@idPaqPapeleriaProm='" & Me.idPaqPapeleriaProm & "'," & _
        "@idPapeleria='" & Me.idPapeleria & "'," & _
        "@cantPaqPapeleriaProm='" & Me.cantPaqPapeleriaProm & "'," & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePapeleriaProm='" & Me.accionDetallePapeleriaProm & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleriaPorIdPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPapeleriaProm where idPromocion=" & Me.idPromocion & " order by idPapeleria"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
