Imports System.Data

Public Class clsResumenFacturacionPaquetes

    Private _idPaquete As Integer
    Private _mes As Integer
    Private _ano As Integer

    Dim objOperacione As New clsOperacione

    Public Property idPaquete() As Integer
        Get
            Return _idPaquete
        End Get
        Set(ByVal value As Integer)
            _idPaquete = value
        End Set
    End Property

    Public Property mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property

    Public Property ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _mes = _ano
        End Set
    End Property


    Function obtenerResumen() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select idpaquete from tbresumenfacturacionpaquetes"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function buscarPaquetePorFecha(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from tbresumenfacturacionpaquetes " & _
        " where idpaquete=" & Me.idPaquete & " and mes=" & mes & " and" & _
        " ano=" & ano
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function PaquetePorFecha(ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TBPaquete.idPaquete, " & _
        "TBPaquete.nombrePaquete, " & _
        "TBResumenFacturacionPaquetes.honduras," & _
        "TBResumenFacturacionPaquetes.bolivia," & _
        "TBResumenFacturacionPaquetes.panama," & _
        "TBResumenFacturacionPaquetes.usa, " & _
        "TBResumenFacturacionPaquetes.ecuador, " & _
        "TBResumenFacturacionPaquetes.venezuela, " & _
        "TBResumenFacturacionPaquetes.guatemala," & _
        "TBResumenFacturacionPaquetes.uruguay, " & _
        "TBResumenFacturacionPaquetes.colombia," & _
        "TBResumenFacturacionPaquetes.mes, " & _
        "TBResumenFacturacionPaquetes.ano," & _
        "TBResumenFacturacionPaquetes.honduras + TBResumenFacturacionPaquetes.bolivia + TBResumenFacturacionPaquetes.panama + TBResumenFacturacionPaquetes.usa + TBResumenFacturacionPaquetes.ecuador + TBResumenFacturacionPaquetes.venezuela + TBResumenFacturacionPaquetes.guatemala + TBResumenFacturacionPaquetes.uruguay + TBResumenFacturacionPaquetes.colombia as total" & _
        " FROM" & _
        " TBPaquete INNER JOIN" & _
        " TBResumenFacturacionPaquetes ON TBPaquete.idPaquete = TBResumenFacturacionPaquetes.idPaquete" & _
        " where TBResumenFacturacionPaquetes.mes = " & mes & " And" & _
        " TBResumenFacturacionPaquetes.ano = " & ano & " And" & _
        " TBResumenFacturacionPaquetes.honduras + TBResumenFacturacionPaquetes.bolivia + TBResumenFacturacionPaquetes.panama + TBResumenFacturacionPaquetes.usa + TBResumenFacturacionPaquetes.ecuador + TBResumenFacturacionPaquetes.venezuela + TBResumenFacturacionPaquetes.guatemala + TBResumenFacturacionPaquetes.uruguay + TBResumenFacturacionPaquetes.colombia <> 0" & _
        " order by TBPaquete.idPaquete"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
