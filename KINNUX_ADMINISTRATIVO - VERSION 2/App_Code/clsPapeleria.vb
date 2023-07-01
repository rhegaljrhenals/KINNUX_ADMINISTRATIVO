Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsPapeleria

    Private _idPapeleria As Integer
    Private _nombrePapeleria As String
    Private _idpapeleriaPais As Integer
    Private _idPais As Integer
    Private _precioPapeleria As Double
    Private _precioLocalPapeleria As Double
    Private _stockPapeleria As Double
    Private _estadoPapeleria As Integer
    Dim objOperacione As New clsOperacione

    Public Property idPapeleria As Integer
        Get
            Return _idPapeleria
        End Get
        Set(ByVal value As Integer)
            _idPapeleria = value
        End Set
    End Property

    Public Property nombrePapeleria As String
        Get
            Return _nombrePapeleria
        End Get
        Set(ByVal value As String)
            _nombrePapeleria = value
        End Set
    End Property

    Public Property idpapeleriaPais As Integer
        Get
            Return _idpapeleriaPais
        End Get
        Set(ByVal value As Integer)
            _idpapeleriaPais = value
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

    Public Property precioLocalPapeleria As Double
        Get
            Return _precioLocalPapeleria
        End Get
        Set(ByVal value As Double)
            _precioLocalPapeleria = value
        End Set
    End Property

    Public Property precioPapeleria As Double
        Get
            Return _precioPapeleria
        End Get
        Set(ByVal value As Double)
            _precioPapeleria = value
        End Set
    End Property

    Public Property stockPapeleria As Double
        Get
            Return _stockPapeleria
        End Get
        Set(ByVal value As Double)
            _stockPapeleria = value
        End Set
    End Property

    Public Property estadoPapeleria As Integer
        Get
            Return _estadoPapeleria
        End Get
        Set(ByVal value As Integer)
            _estadoPapeleria = value
        End Set
    End Property

    Sub grabarPapeleria(ByVal accion As Integer)
        Dim sql As String
        sql = "exec sp_ActualizaPapeleria " & _
        "@idPapeleria='" & Me.idPapeleria & "'," & _
        "@nombrePapeleria='" & Me.nombrePapeleria & "'," & _
        "@accion='" & accion & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Sub grabarPapeleriaPais(ByVal accion As Integer, ByVal chequeado As String)
        Dim sql As String
        sql = "exec sp_actualizaPapeleriaPais " & _
        "@idpapeleria='" & Me.idPapeleria & "'," & _
        "@idpapeleriaPais='" & Me.idpapeleriaPais & "'," & _
        "@idPais='" & Me.idPais & "'," & _
        "@precioPapeleria='" & Me.precioPapeleria & "'," & _
        "@precioLocalPapeleria='" & Me.precioLocalPapeleria & "'," & _
        "@stockPapeleria='" & Me.stockPapeleria & "'," & _
        "@estadoPapeleria='" & Me.estadoPapeleria & "'," & _
        "@accion='" & accion & "'," & _
        "@chequeado='" & chequeado & "'"
        With objOperacione
            .Accion(sql)
        End With
    End Sub

    Function obtenerPapeleria() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT     " & _
        "TBPapeleria.idPapeleria," & _
        "TBPapeleria.nombrePapeleria," & _
        "TBPapeleriaPais.idPapeleriaPais," & _
        "TBPapeleriaPais.precioPapeleria," & _
        "TBPapeleriaPais.precioLocalPapeleria, " & _
        "TBPapeleriaPais.stockPapeleria," & _
        "TBPapeleriaPais.estadoPapeleria, " & _
        "dbo.TBpais.codigoPais, dbo.TBpais.nombrePais" & _
        " FROM" & _
        " TBPapeleria INNER JOIN" & _
        " TBPapeleriaPais ON TBPapeleria.idPapeleria = TBPapeleriaPais.idPapeleria INNER JOIN" & _
        " dbo.TBpais ON TBPapeleriaPais.idPais = dbo.TBpais.codigoPais"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener la papeleria por pais
    Function papeleriaPorPais() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "TBPapeleria.idPapeleria," & _
        "TBPapeleria.nombrePapeleria" & _
        " FROM" & _
        " TBPapeleria INNER JOIN" & _
        " TBPapeleriaPais ON TBPapeleria.idPapeleria = TBPapeleriaPais.idPapeleria INNER JOIN" & _
        " dbo.TBpais ON TBPapeleriaPais.idPais = dbo.TBpais.codigoPais" & _
        " where dbo.TBpais.codigoPais=" & Me.idPais
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
