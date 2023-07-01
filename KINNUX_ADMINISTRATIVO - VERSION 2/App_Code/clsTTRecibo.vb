Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTTRecibo

    Private _idRecibo As Integer
    Private _numeroRecibo As String
    Private _idEmpresa As Integer
    Private _idSucursal As Integer
    Private _fechaRecibo As Date
    Private _idEvento As Integer
    Private _cedulaRecibo As String
    Private _nombreRecibo As String
    Private _direccionRecibo As String
    Private _telefonoRecibo As String
    Private _valorRecibo As Double
    Private _facturadoRecibo As String
    Private _idRecibidor As Integer
    Private _estadoRecibo As Integer
    Dim objOeracione As New clsOperacione

    Public Property idRecibo As Integer
        Get
            Return _idRecibo
        End Get
        Set(ByVal value As Integer)
            _idRecibo = value
        End Set
    End Property

    Public Property numeroRecibo As String
        Get
            Return _numeroRecibo
        End Get
        Set(ByVal value As String)
            _numeroRecibo = value
        End Set
    End Property

    Public Property idEmpresa As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property idSucursal As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property

    Public Property fechaRecibo As Date
        Get
            Return _fechaRecibo
        End Get
        Set(ByVal value As Date)
            _fechaRecibo = value
        End Set
    End Property

    Public Property idEvento As Integer
        Get
            Return _idEvento
        End Get
        Set(ByVal value As Integer)
            _idEvento = value
        End Set
    End Property

    Public Property cedulaRecibo As String
        Get
            Return _cedulaRecibo
        End Get
        Set(ByVal value As String)
            _cedulaRecibo = value
        End Set
    End Property

    Public Property nombreRecibo As String
        Get
            Return _nombreRecibo
        End Get
        Set(ByVal value As String)
            _nombreRecibo = value
        End Set
    End Property

    Public Property direccionRecibo As String
        Get
            Return _direccionRecibo
        End Get
        Set(ByVal value As String)
            _direccionRecibo = value
        End Set
    End Property

    Public Property telefonoRecibo As String
        Get
            Return _telefonoRecibo
        End Get
        Set(ByVal value As String)
            _telefonoRecibo = value
        End Set
    End Property

    Public Property valorRecibo As Double
        Get
            Return _valorRecibo
        End Get
        Set(ByVal value As Double)
            _valorRecibo = value
        End Set
    End Property

    Public Property facturadoRecibo As String
        Get
            Return _facturadoRecibo
        End Get
        Set(ByVal value As String)
            _facturadoRecibo = value
        End Set
    End Property

    Public Property idRecibidor As Integer
        Get
            Return _idRecibidor
        End Get
        Set(ByVal value As Integer)
            _idRecibidor = value
        End Set
    End Property

    Public Property estadoRecibo As Integer
        Get
            Return _estadoRecibo
        End Get
        Set(ByVal value As Integer)
            _estadoRecibo = value
        End Set
    End Property

    Sub grabar()
        Dim sql As String
        sql = "exec sp_actualizaTTRecibo " & _
        "@idRecibo='" & Me.idRecibo & "'," & _
        "@numeroRecibo='" & Me.numeroRecibo & "'," & _
        "@idEmpresa='" & Me.idEmpresa & "'," & _
        "@idSucursal='" & Me.idSucursal & "'," & _
        "@fechaRecibo='" & Me.fechaRecibo.ToString("yyyyMMdd") & "'," & _
        "@idEvento='" & Me.idEvento & "'," & _
        "@cedulaRecibo='" & Me.cedulaRecibo & "'," & _
        "@nombreRecibo='" & Me.nombreRecibo & "'," & _
        "@direccionRecibo='" & Me.direccionRecibo & "'," & _
        "@telefonoRecibo='" & Me.telefonoRecibo & "'," & _
        "@valorRecibo='" & Me.valorRecibo & "'," & _
        "@facturadoRecibo='" & Me.facturadoRecibo & "'," & _
        "@idRecibidor='" & Me.idRecibidor & "'," & _
        "@estadoRecibo='" & Me.estadoRecibo & "'"
        With objOeracione
            .Accion(sql)
        End With
    End Sub

    ' funcion para obtener los recibos
    Function obtenerRecibos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECt " & _
        "TTRecibo.idRecibo," & _
        "TTRecibo.numeroRecibo," & _
        "TTRecibo.fechaRecibo," & _
        "TBEvento.idEvento," & _
        "TBEvento.nombreEvento," & _
        "TTRecibo.cedulaRecibo," & _
        "TTRecibo.nombreRecibo," & _
        "TTRecibo.valorRecibo," & _
        "TBRecibidor.idRecibidor," & _
        "TBRecibidor.nombreRecibidor," & _
        "TTRecibo.facturadoRecibo," & _
        "case TTRecibo.estadoRecibo" & _
        " when 1 then 'Activo'" & _
        " when 0 then 'Anulado'" & _
        " end estadoRecibo" & _
        " FROM" & _
        " TTRecibo INNER JOIN" & _
        " TBEvento ON TTRecibo.idEvento = TBEvento.idEvento INNER JOIN" & _
        " TBRecibidor ON TTRecibo.idRecibidor = TBRecibidor.idRecibidor"
        With objOeracione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para anular los recibos
    Sub anularRecibo()
        Dim sql As String
        sql = "exec sp_actualizaTTReciboAnular " & _
        "@idRecibo='" & Me.idRecibo & "'"
        With objOeracione
            .Accion(sql)
        End With
    End Sub

    ' funcion para validar el numero del recibo
    Function validaNumeroRecibo() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttRecibo where numeroRecibo='" & Me.numeroRecibo & "'"
        With objOeracione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para actualizar el facturado de los recibos
    Sub actualizaFacturado()
        Dim sql As String
        sql = "exec sp_actualizaTTReciboFacturado " & _
        "@idrecibo=" & Me.idRecibo
        With objOeracione
            .Accion(sql)
        End With
    End Sub

    ' function para obtener los recibos por numero de recibo
    Function obtenerRecicboPorIdRecibo() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from ttRecibo where idRecibo=" & Me.idRecibo
        With objOeracione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' procedimiento para actualizar el facturado de un recibo en "no"
    Sub actualizaReciboFacturadoNo()
        Dim sql As String
        sql = "exec sp_actualizaTTReciboFacturadono " & _
        "@idrecibo='" & Me.idRecibo & "'"
        With objOeracione
            .Accion(sql)
        End With

    End Sub
End Class
