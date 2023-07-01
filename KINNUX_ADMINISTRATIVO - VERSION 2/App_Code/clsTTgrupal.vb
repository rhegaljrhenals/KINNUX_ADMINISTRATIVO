Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsTTgrupal

    Private _mesSeleccionado As Integer
    Private _anoSeleccionado As Integer
    Dim objoperacione As New clsOperacione

    Public Property mesSeleccionado As Integer
        Get
            Return _mesSeleccionado
        End Get
        Set(ByVal value As Integer)
            _mesSeleccionado = value
        End Set
    End Property

    Public Property anoSeleccionado As Integer
        Get
            Return _anoSeleccionado
        End Get
        Set(ByVal value As Integer)
            _anoSeleccionado = value
        End Set
    End Property


    'funcion para obtener los datos grupales
    Function obtenerdatosGrupales() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre+ ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTGrupal.compragrupal," & _
        "TTGrupal.nivel1grupal," & _
        "TTGrupal.nivel2grupal," & _
        "TTGrupal.nivel3grupal," & _
        "TTGrupal.nivel4grupal," & _
        "TTGrupal.nivel5grupal," & _
        "TTGrupal.nivel6grupal," & _
        "TTGrupal.nivel7grupal," & _
        "TTGrupal.nivel8grupal," & _
        "TTGrupal.nivel9grupal," & _
        "TTGrupal.nivel10grupal," & _
        "TTGrupal.nivel11grupal," & _
        "TTGrupal.nivel12grupal," & _
        "TTGrupal.nivel13grupal," & _
        "TTGrupal.nivel14grupal," & _
        "TTGrupal.nivel15grupal," & _
        "TTGrupal.nivel16grupal," & _
        "TTGrupal.nivel17grupal," & _
        "TTGrupal.nivel18grupal," & _
        "TTGrupal.nivel19grupal," & _
        "TTGrupal.nivel20grupal" & _
        " FROM" & _
        " TTGrupal INNER JOIN" & _
        " dbo.Afiliaciones ON TTGrupal.codigoafiliado = dbo.Afiliaciones.codigoAfiliado" & _
        " where TTGrupal.mesgrupal=" & Me.mesSeleccionado & " and TTGrupal.anogrupal=" & Me.anoSeleccionado & _
        " order by dbo.Afiliaciones.Pnombre,dbo.Afiliaciones.Snombre,dbo.Afiliaciones.Papellido,dbo.Afiliaciones.Sapellido"
        With objoperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function
End Class
