Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPaquetePremioProm
    Private _idPaqPremioProm As Integer
    Private _idPremio As Integer
    Private _idPromocion As Integer
    Private _cantPaqPremioProm As Integer
    Private _accionDetallePremioProm As Integer
    Private _idPais As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPaqPremioProm As Integer
        Get
            Return _idPaqPremioProm
        End Get
        Set(ByVal value As Integer)
            _idPaqPremioProm = value
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

    Public Property idPremio As Integer
        Get
            Return _idPremio
        End Get
        Set(ByVal value As Integer)
            _idPremio = value
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

    Public Property cantPaqPremioProm As Integer
        Get
            Return _cantPaqPremioProm
        End Get
        Set(ByVal value As Integer)
            _cantPaqPremioProm = value
        End Set
    End Property

    Public Property accionDetallePremioProm As Integer
        Get
            Return _accionDetallePremioProm
        End Get
        Set(ByVal value As Integer)
            _accionDetallePremioProm = value
        End Set
    End Property

    Sub grabarPaquetePremioProm(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPaquetePremioPromocion " & _
        "@idPaqPremioProm='" & Me.idPaqPremioProm & "'," & _
        "@idPremio='" & Me.idPremio & "'," & _
        "@cantPaqPremioProm='" & Me.cantPaqPremioProm & "'," & _
        "@idPromocion='" & Me.idPromocion & "'," & _
        "@accion='" & accion & "'," & _
        "@accionDetallePremioProm='" & Me.accionDetallePremioProm & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleriaPorIdPromocion() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from TBPaqPremioProm where idPromocion=" & Me.idPromocion & " order by idPremio"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
