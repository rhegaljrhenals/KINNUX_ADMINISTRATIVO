Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTComisionMesIr

    Private _idcomisionmesir As Integer
    Private _codigoAfiliado As String
    Private _valNivel2ComisionesMesIr As Double
    Private _valNivel3ComisionesMesIr As Double
    Private _valNivel4ComisionesMesIr As Double
    Private _valNivel5ComisionesMesIr As Double
    Private _valNivel6ComisionesMesIr As Double
    Private _mesComisionmesir As Integer
    Private _anocomisionmesir As Integer
    Dim objOperacione As New clsOperacione

    Public Property idcomisionmesir As Integer
        Get
            Return _idcomisionmesir
        End Get
        Set(ByVal value As Integer)
            _idcomisionmesir = value
        End Set
    End Property

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property valNivel2ComisionesMesIr As Double
        Get
            Return _valNivel2ComisionesMesIr
        End Get
        Set(ByVal value As Double)
            _valNivel2ComisionesMesIr = value
        End Set
    End Property

    Public Property valNivel3ComisionesMesIr As Double
        Get
            Return _valNivel3ComisionesMesIr
        End Get
        Set(ByVal value As Double)
            _valNivel3ComisionesMesIr = value
        End Set
    End Property

    Public Property valNivel4ComisionesMesIr As Double
        Get
            Return _valNivel4ComisionesMesIr
        End Get
        Set(ByVal value As Double)
            _valNivel4ComisionesMesIr = value
        End Set
    End Property

    Public Property valNivel5ComisionesMesIr As Double
        Get
            Return _valNivel5ComisionesMesIr
        End Get
        Set(ByVal value As Double)
            _valNivel5ComisionesMesIr = value
        End Set
    End Property

    Public Property valNivel6ComisionesMesIr As Double
        Get
            Return _valNivel6ComisionesMesIr
        End Get
        Set(ByVal value As Double)
            _valNivel6ComisionesMesIr = value
        End Set
    End Property

    Public Property mesComisionmesir As Integer
        Get
            Return _mesComisionmesir
        End Get
        Set(ByVal value As Integer)
            _mesComisionmesir = value
        End Set
    End Property

    Public Property anocomisionmesir As Integer
        Get
            Return _anocomisionmesir
        End Get
        Set(ByVal value As Integer)
            _anocomisionmesir = value
        End Set
    End Property

    ' funcion para obtener las comisiones de IR por mes y año
    Function obtenerComisionesIR() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionMesIr.codigoafiliado, " & _
        "dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido + ' ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre as nombres, " & _
        "TTComisionMesIr.valnivel2comisionmesir," & _
        "TTComisionMesIr.valnivel3comisionmesir," & _
        "TTComisionMesIr.valnivel4comisionmesir," & _
        "TTComisionMesIr.valnivel5comisionmesir," & _
        "TTComisionMesIr.valnivel6comisionmesir," & _
        "TTComisionMesIr.mescomisionmesir," & _
        "(TTComisionMesIr.valnivel2comisionmesir + TTComisionMesIr.valnivel3comisionmesir + TTComisionMesIr.valnivel4comisionmesir + TTComisionMesIr.valnivel5comisionmesir + TTComisionMesIr.valnivel6comisionmesir) as total" & _
        " FROM" & _
        " TTComisionMesIr INNER JOIN" & _
        " dbo.Afiliaciones ON TTComisionMesIr.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where TTComisionMesIr.mescomisionmesir = " & Me.mesComisionmesir & " And" & _
        " TTComisionMesIr.anocomisionmesir = " & Me.anocomisionmesir & _
        " order by dbo.Afiliaciones.Papellido,dbo.Afiliaciones.sapellido,dbo.Afiliaciones.Pnombre,dbo.Afiliaciones.snombre"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' funcion para obtener los datos e la comision mes por codigo del afiliado
    Function obtenerComisionMesPorAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionMesIr.codigoafiliado, " & _
        "TTComisionMesIr.valnivel2comisionmesir, " & _
        "TTComisionMesIr.valnivel3comisionmesir, " & _
        "TTComisionMesIr.valnivel4comisionmesir, " & _
        "TTComisionMesIr.valnivel5comisionmesir, " & _
        "TTComisionMesIr.valnivel6comisionmesir, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTComisionMesIr ON dbo.Afiliaciones.codigoAfiliado = TTComisionMesIr.codigoafiliado" & _
        " where TTComisionMesIr.codigoafiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
