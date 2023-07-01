Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class clsNuevoPlan
    Public codigoafiliado As String
    Public codigopatrocinador As String
    Dim recparametro As New SqlDataAdapter
    Dim operaciones As New clsOperacione
    ' clsfactura
    Private fechaencfacturapro As Date
    Private puntosencfacturapro As Double
    Private stsencfacturapro As Double
    Private estadoendfacturapro As Integer
    Private tipoencfacturapro As String
    Private fechaini As Date
    Private fechafin As Date
    Dim recfactura As New SqlDataAdapter
    'clsGrupalTS
    Private _codigoAfiliado As String
    Private _puntogrupal As Double
    Private _mesgrupal As Integer
    Private _anogrupal As Integer
    Private _compragrupal As Double
    Private _nivel As Integer
    Dim recgru As SqlDataAdapter
    Dim execonsulta As New SqlCommand

    Public Property puntogrupal As Double
        Get
            Return _puntogrupal
        End Get
        Set(ByVal value As Double)
            _puntogrupal = value
        End Set
    End Property

    Public Property compragrupal As Double
        Get
            Return _compragrupal
        End Get
        Set(ByVal value As Double)
            _compragrupal = value
        End Set
    End Property

    Public Property mesgrupal As Integer
        Get
            Return _mesgrupal
        End Get
        Set(ByVal value As Integer)
            _mesgrupal = value
        End Set
    End Property

    Public Property anogrupal As Integer
        Get
            Return _anogrupal
        End Get
        Set(ByVal value As Integer)
            _anogrupal = value
        End Set
    End Property

    Public Property nivel As Integer
        Get
            Return _nivel
        End Get
        Set(ByVal value As Integer)
            _nivel = value
        End Set
    End Property


    Public Property vfechaini As Date
        Get
            Return fechaini
        End Get
        Set(ByVal value As Date)
            fechaini = value
        End Set
    End Property
    Public Property vfechafin As Date
        Get
            Return fechafin
        End Get
        Set(ByVal value As Date)
            fechafin = value
        End Set
    End Property

    Public Property vfechaencfacturapro As Date
        Get
            Return fechaencfacturapro
        End Get
        Set(ByVal value As Date)
            fechaencfacturapro = value
        End Set
    End Property
    
    Public Property vpuntosencfacturapro As Double
        Get
            Return puntosencfacturapro
        End Get
        Set(ByVal value As Double)
            puntosencfacturapro = value
        End Set
    End Property

    Public Property vstsencfacturapro As Double
        Get
            Return stsencfacturapro
        End Get
        Set(ByVal value As Double)
            stsencfacturapro = value
        End Set
    End Property

    Public Property vestadoendfacturapro As Integer
        Get
            Return estadoendfacturapro
        End Get
        Set(ByVal value As Integer)
            estadoendfacturapro = value
        End Set
    End Property
    Public Property vtipoencfacturapro As String
        Get
            Return tipoencfacturapro
        End Get
        Set(ByVal value As String)
            tipoencfacturapro = value
        End Set
    End Property


    Public Property vcodigoafiliado As String
        Get
            Return codigoafiliado
        End Get
        Set(ByVal value As String)
            codigoafiliado = value
        End Set
    End Property

    Public Property vcodigopatrocinador As String
        Get
            Return codigopatrocinador
        End Get
        Set(ByVal value As String)
            codigopatrocinador = value
        End Set
    End Property

    Function obtenerpatrocinador() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select codigopatrocinador from afiliaciones where codigoafiliado = '" & vcodigoafiliado & "' "
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerpatrocinadorbin() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select directo, posicion from afiliaciones where codigoafiliado = '" & vcodigoafiliado & "' "
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    ' clsFactura

    Function obtenerfacturas() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos, f.codigoafiliado, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro between a.fechaInicioIr and a.fechaFinIrCorto group by f.codigoafiliado,a.codigopatrocinador"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenercompra() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select isnull (sum(f.numtsEncfacturapro),0) as puntos,f.stsEncfacturaPro, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and f.codigoafiliado = '" & vcodigoafiliado & "' group by f.codigoafiliado,a.codigopatrocinador"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturasun() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos, f.codigoafiliado, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro not between a.fechaInicioIr and a.fechaFinIrCorto group by f.codigoafiliado,a.codigopatrocinador"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturagrupal() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos,f.stsEncfacturaPro, f.codigoafiliado, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' group by f.codigoafiliado,a.codigopatrocinador,f.stsEncfacturaPro"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturabin() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos, f.codigoafiliado, a.directo, a.posicion from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' group by f.codigoafiliado,a.directo, a.posicion"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function
    Function obtenercomprapatro() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select isnull (sum(f.numtsEncfacturapro),0) as puntos,f.stsEncfacturaPro, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and a.codigopatrocinador = '" & vcodigoafiliado & "' group by f.codigoafiliado,a.codigopatrocinador"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturaspatrocinador() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos,f.stsEncfacturaPro, f.codigoafiliado, a.codigopatrocinador from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and a.codigopatrocinador = '" & Me.codigoafiliado & "' and f.fechaencfacturapro between a.fechaInicioIr and a.fechaFinIrCorto group by f.codigoafiliado,a.codigopatrocinador order by puntos desc "
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function
    Function obtenerfacturasTotalIR() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select sum(f.numtsEncfacturapro) as puntos from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro between a.fechaInicioIr and a.fechaFinIrCorto "
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturasirNiv() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select f.idencfacturapro, f.numtsEncfacturapro, f.codigoafiliado, a.codigopatrocinador, f.fechaEncFacturaPro from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1  and f.tipoencfacturapro <> 'ki' and f.tipoencfacturapro <> 'el'  and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro between a.fechaInicioIr and a.fechaFinIrCorto "
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    Function obtenerfacturasgeneral() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select isnull (sum(f.numtsEncfacturapro),0) as puntos, a.codigoafiliado from ttencfacturapro f, afiliaciones a where f.codigoafiliado = a.codigoafiliado and f.estadoencfacturapro = 1 and f.tipoencfacturapro <> 'ki' and f.fechaencfacturapro >= '" & vfechaini.ToString("yyyy/MM/dd") & "' and f.fechaencfacturapro <= '" & vfechafin.ToString("yyyy/MM/dd") & "' group by a.codigoafiliado"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
            Return tabla
        End With
        Return tabla
    End Function

    ' clsGrupalTS
    Function obtenergrupal() As DataTable
        Dim sqlpar As String
        Dim tabla As New DataTable
        sqlpar = "select count (codigoafiliado) as grupal from ttgrupalts where mesgrupalts =  '" & Me.mesgrupal & "' and anogrupalts = '" & Me.anogrupal & "'and codigoafiliado = '" & Me.codigoafiliado & "'"
        With operaciones
            tabla = .DevuelveDato(sqlpar)
        End With
        Return tabla
    End Function

    Sub actualizarcomprag()
        Dim tabla As New DataTable
        Dim sqlup As String
        sqlup = "update ttgrupalts set compragrupalts = compragrupalts + " & Me.compragrupal & " where mesgrupalts = " & Me.mesgrupal & " and anogrupalts = " & Me.anogrupal & " and codigoafiliado = " & Me.codigoafiliado & ""
        With operaciones
            tabla = .DevuelveDato(sqlup)
        End With
    End Sub

    Sub actualizarsupercomprag()
        Dim tabla As New DataTable
        Dim sqlup As String
        sqlup = "update ttgrupalts set compragrupalsts = compragrupalsts + " & Me.compragrupal & " where mesgrupalts = " & Me.mesgrupal & " and anogrupalts = " & Me.anogrupal & " and codigoafiliado = " & Me.codigoafiliado & ""
        With operaciones
            .Accion(sqlup)
        End With
    End Sub

    Sub insertacomprag()
        Dim sqlup As String
        sqlup = "insert into ttgrupalts (codigoafiliado, compragrupalts, mesgrupalts, anogrupalts) values (" & Me.codigoAfiliado & ", " & Me.compragrupal & "," & Me.mesgrupal & "," & Me.anogrupal & ")"
        With operaciones
            .Accion(sqlup)
        End With
    End Sub

    Sub insertasupercomprag()
        Dim sqlup As String
        sqlup = "insert into ttgrupalts (codigoafiliado, compragrupalsts, mesgrupalts, anogrupalts) values (" & Me.codigoAfiliado & ", " & Me.compragrupal & "," & Me.mesgrupal & "," & Me.anogrupal & ")"
        With operaciones
            .Accion(sqlup)
        End With
    End Sub

    Sub actualizargrupal()
        Dim sqlup As String
        sqlup = "update ttgrupalts set nivel" & Me.nivel & "grupalts = nivel" & Me.nivel & "grupalts + " & Me.puntogrupal & " where mesgrupalts = " & Me.mesgrupal & " and anogrupalts = " & Me.anogrupal & " and codigoafiliado = " & Me.codigoAfiliado & ""
        With operaciones
            .Accion(sqlup)
        End With
    End Sub

    Sub insertargrupal()
        Dim sqlup As String
        sqlup = "insert into ttgrupalts (codigoafiliado, nivel" & Me.nivel & "grupalts, mesgrupalts, anogrupalts) values (" & Me.codigoAfiliado & ", " & Me.puntogrupal & "," & Me.mesgrupal & "," & Me.anogrupal & ")"
        With operaciones
            .Accion(sqlup)
        End With
    End Sub
End Class
