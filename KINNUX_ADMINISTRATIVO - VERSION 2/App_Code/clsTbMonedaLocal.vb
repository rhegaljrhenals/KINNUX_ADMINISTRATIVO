Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTbMonedaLocal

    Private _idEmpresa As Integer
    Private _valorMonedaLocal As Double
    Private _fecha As Date
    Dim objOperaciones As New clsOperacione

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property valorMonedaLocal As Double
        Get
            Return _valorMonedaLocal
        End Get
        Set(value As Double)
            _valorMonedaLocal = value
        End Set
    End Property

    Function obtenerValorMonedaLocalPorEmpresa() As datatable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from TBMonedaLocal where idEmpresa=" & Me.idEmpresa
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'funcion para obtener la moneda local colombia
    Function obtenerValorMonedaLocalColombia() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_obtenerTbmonedalocal " & _
        "@fecha='" & Me.fecha.ToString("yyyy/MM/dd") & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    'funcion para obtener la moneda local colombia
    Function obtenerValorMonedaLocalColombiaCiclo() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "exec sp_obtenerTbmonedalocalciclo " & _
        "@fecha='" & Me.fecha.ToString("yyyy/MM/dd") & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'"
        With objOperaciones
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
