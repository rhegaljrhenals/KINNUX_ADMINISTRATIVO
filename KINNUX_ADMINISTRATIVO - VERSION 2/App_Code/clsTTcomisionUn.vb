Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTcomisionUn

    Private _idcomisionUn As Integer
    Private _codigoAfiliado As String
    Private _valNivel1ComisionesMesUn As Double
    Private _valNivel2ComisionesMesUn As Double
    Private _valNivel3ComisionesMesUn As Double
    Private _valNivel4ComisionesMesUn As Double
    Private _valNivel5ComisionesMesUn As Double
    Private _valNivel6ComisionesMesUn As Double
    Private _mesComisionmesUn As Integer
    Private _anocomisionmesUn As Integer
    Dim objOperacione As New clsOperacione

    Public Property idcomisionmesUn As Integer
        Get
            Return _idcomisionUn
        End Get
        Set(ByVal value As Integer)
            _idcomisionUn = value
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

    Public Property valNivel2ComisionesMesUn As Double
        Get
            Return _valNivel2ComisionesMesUn
        End Get
        Set(ByVal value As Double)
            _valNivel2ComisionesMesUn = value
        End Set
    End Property

    Public Property valNivel3ComisionesMesUn As Double
        Get
            Return _valNivel3ComisionesMesUn
        End Get
        Set(ByVal value As Double)
            _valNivel3ComisionesMesUn = value
        End Set
    End Property

    Public Property valNivel4ComisionesMesUn As Double
        Get
            Return _valNivel4ComisionesMesUn
        End Get
        Set(ByVal value As Double)
            _valNivel4ComisionesMesUn = value
        End Set
    End Property

    Public Property valNivel5ComisionesMesUn As Double
        Get
            Return _valNivel5ComisionesMesUn
        End Get
        Set(ByVal value As Double)
            _valNivel5ComisionesMesUn = value
        End Set
    End Property

    Public Property valNivel6ComisionesMesUn As Double
        Get
            Return _valNivel6ComisionesMesUn
        End Get
        Set(ByVal value As Double)
            _valNivel6ComisionesMesUn = value
        End Set
    End Property

    Public Property mesComisionmesUn As Integer
        Get
            Return _mesComisionmesUn
        End Get
        Set(ByVal value As Integer)
            _mesComisionmesUn = value
        End Set
    End Property

    Public Property anocomisionmesUn As Integer
        Get
            Return _anocomisionmesUn
        End Get
        Set(ByVal value As Integer)
            _anocomisionmesUn = value
        End Set
    End Property

    ' funcion para obtener las comisiones de Un por mes y año
    Function obtenerComisionesUn() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTComisionun.codigoafiliado, " & _
        "dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido + ' ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre as nombres, " & _
        "TTComisionun.valnivel1comisionUn," & _
        "TTComisionun.valnivel2comisionUn," & _
        "TTComisionun.valnivel3comisionUn," & _
        "TTComisionun.valnivel4comisionUn," & _
        "TTComisionun.valnivel5comisionUn," & _
        "TTComisionun.valnivel6comisionUn," & _
        "TTComisionun.mescomisionUn," & _
        "(TTComisionun.valnivel1comisionUn + TTComisionun.valnivel2comisionUn + TTComisionun.valnivel3comisionUn + TTComisionun.valnivel4comisionUn + TTComisionun.valnivel5comisionUn + TTComisionun.valnivel6comisionUn) as total " & _
        " FROM" & _
        " TTComisionun INNER JOIN dbo.Afiliaciones ON " & _
        " TTComisionun.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where" & _
        " TTComisionun.mescomisionUn = " & Me.mesComisionmesUn & " And" & _
        " TTComisionun.anocomisionUn = " & Me.anocomisionmesUn & _
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
        "TTComisionun.codigoafiliado, " & _
        "TTComisionun.valnivel2comisionmesUn, " & _
        "TTComisionun.valnivel3comisionmesUn, " & _
        "TTComisionun.valnivel4comisionmesUn, " & _
        "TTComisionun.valnivel5comisionmesUn, " & _
        "TTComisionun.valnivel6comisionmesUn, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTComisionun ON dbo.Afiliaciones.codigoAfiliado = TTComisionun.codigoafiliado" & _
        " where TTComisionun.codigoafiliado='" & Me.codigoAfiliado & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
