Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPapeleriaPais

    Private _idPapeleriaPais As Integer
    Private _idPapeleria As Integer
    Private _idPais As Integer
    Private _precioPapeleria As Long
    Private _precioLocalPapeleria As Long
    Private _stockPapeleria As Long
    Dim objOperacione As New clsOperacione

    Public Property idPapeleriaPais As Integer
        Get
            Return _idPapeleriaPais
        End Get
        Set(ByVal value As Integer)
            _idPapeleriaPais = value
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

    Public Property idPais As Integer
        Get
            Return _idPais
        End Get
        Set(ByVal value As Integer)
            _idPais = value
        End Set
    End Property

    Public Property precioPapeleria As Long
        Get
            Return _precioPapeleria
        End Get
        Set(ByVal value As Long)
            _precioPapeleria = value
        End Set
    End Property

    Public Property precioLocalPapeleria As Long
        Get
            Return _precioLocalPapeleria
        End Get
        Set(ByVal value As Long)
            _precioLocalPapeleria = value
        End Set
    End Property

    Public Property stockPapeleria As Long
        Get
            Return _stockPapeleria
        End Get
        Set(ByVal value As Long)
            _stockPapeleria = value
        End Set
    End Property

    Sub actualizarPrecioPapeleriaPais(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_actualizaPapeleriaPais " & _
        "@idPapeleriaPais='" & Me.idPapeleriaPais & "'," & _
        "@idPapeleria='" & Me.idPapeleria & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precioPapeleria='" & Me.precioPapeleria & "'," & _
        "@precioLocalPapeleria='" & Me.precioLocalPapeleria & "'," & _
        "@stockPapeleria='" & Me.stockPapeleria & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function ObtenerPapeleriaPaisTodos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT " & _
        "TBPapeleria.idPapeleria," & _
        "TBPapeleria.nombrePapeleria," & _
        "TBPapeleriaPais.precioPapeleria," & _
        "TBPapeleriaPais.precioLocalPapeleria," & _
        "TBPapeleriaPais.stockPapeleria," & _
        "TBPapeleriaPais.idPais," & _
        "TBpais.nombrePais," & _
        "TBPapeleria.estadoPapeleria" & _
        " FROM" & _
        " TBPapeleria INNER JOIN TBPapeleriaPais ON dbo.TBPapeleria.idPapeleria = TBPapeleriaPais.idPapeleria INNER JOIN" & _
        " TBpais ON dbo.TBPapeleriaPais.idPais = dbo.TBpais.idpais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
