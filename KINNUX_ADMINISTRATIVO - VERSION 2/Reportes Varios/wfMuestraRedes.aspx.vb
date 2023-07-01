Imports System.Data

Partial Class Reportes_Varios_wfMuestraRedes
    Inherits System.Web.UI.Page

    Dim afiliados As New ClsAfiliado
    Dim objRede As New clsRedes
    Dim objOperacione As New clsOperacione
    Dim afiliado As New ClsAfiliado
    Dim tablaBinaria As New clsTablaRedBinaria
    Dim matrizBinaria(,) As String = {}
    Dim encabezadofactura As New clsTTEncFacturaPro
    Public nivel As Integer = 1

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarAno()
            Me.ImageButton7.Visible = False
            Me.ImageButton8.Visible = False

        End If
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2012 To Now.Year
            Me.DropDownList2.Items.Add(y)
        Next
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.ImageButton7.Visible = False
        Me.ImageButton8.Visible = False
        '
        If Me.TextBox1.Text <> "" Then
            Me.GridView1.DataSource = Nothing
            Me.GridView1.DataBind()
            '
            Dim encontrado As String = mostrarAfiliado()
            If encontrado = "si" Then
                Me.ImageButton7.Visible = True
                Me.ImageButton8.Visible = True
            End If
        End If
    End Sub

    Function mostrarAfiliado() As String
        Dim encontrado As String = "no"
        Dim tabla As New DataTable
        With afiliados
            .codigoAfiliado = Me.TextBox1.Text
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                encontrado = "si"
            Else
                Me.TextBox2.Text = "No existe o está eliminado...!"
                encontrado = "no"
            End If
        End With
        Return encontrado
    End Function

    
    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Me.MultiView1.ActiveViewIndex = 0
        redUninivel(Me.TextBox1.Text)
        muestraPuntosUninivel()
    End Sub

    Sub muestraPuntosUninivel()
        Dim tabla As New DataTable
        Dim y As Integer
        With encabezadofactura
            .mesFactura = Me.DropDownList1.SelectedValue
            .anoFactura = Me.DropDownList2.SelectedItem.Text
            For y = 0 To Me.GridView1.Rows.Count - 1
                .codigoAfiliado = Me.GridView1.Rows(y).Cells(0).Text
                tabla = .sumarPuntosPorAfiliado
                If tabla.Rows.Count <> 0 Then
                    Me.GridView1.Rows(y).Cells(16).Text = tabla.Rows(0).Item("suma")
                Else
                    Me.GridView1.Rows(y).Cells(16).Text = "0"
                End If
            Next
        End With
    End Sub

    Sub redUninivel(ByVal codigo As Integer)
        If Me.TextBox1.Text <> "" Then
            With objRede
                .vaciarTabla()
                .crearTablaTemporal()
                BuscarPatrocinadorUninivel(codigo)
                If Session("encontrado") = "si" Then
                    RecorridoUninivel(Me.TextBox1.Text)
                    Session("numeroRegistros") = Me.GridView1.Rows.Count
                    If Session("numeroRegistros") >= 3 Then
                    Else
                    End If
                End If
            End With
        End If
    End Sub

    Sub RecorridoUninivel(ByVal sentenciaIn As String)
        ''-----------------------------------------------------------------
        Session("nivel") = nivel
        Dim cadena As String = Nothing
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        Dim tm As New DataTable
        sql = "exec sp_recorridoUninivel '" & sentenciaIn & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    With objRede
                        .codigoPatrocinador = tabla.Rows(y).Item("codigoPatrocinador")
                        .directo = tabla.Rows(y).Item("directo")
                        .indirecto = tabla.Rows(y).Item("indirecto")
                        .codigoAfiliado = tabla.Rows(y).Item("codigoAfiliado")
                        .identificacion = tabla.Rows(y).Item("identificacion")
                        .apellidos = tabla.Rows(y).Item("papellido") & " " & tabla.Rows(y).Item("sapellido")
                        .nombres = tabla.Rows(y).Item("pnombre") & " " & tabla.Rows(y).Item("snombre")
                        .nodo = tabla.Rows(0).Item("nodo")
                        .posicion = tabla.Rows(y).Item("posicion")
                        .rango = tabla.Rows(y).Item("rango")
                        .left = tabla.Rows(y).Item("l")
                        .right = tabla.Rows(y).Item("r")
                        .email = tabla.Rows(y).Item("email1")
                        .rango = tabla.Rows(y).Item("rango")
                        .nivel = Session("nivel")
                        '.puntos = 0
                        tm = .grabarRegistro
                        Session("tablaRecorrido") = tm
                        cadena += tabla.Rows(y).Item("codigoAfiliado") & ","
                    End With
                Next
                nivel += 1
                cadena = Mid(cadena, 1, cadena.Length - 1)
                RecorridoUninivel(cadena)
            Else
                mostrarRedUninivel()
                cadena = ""
            End If
        End With
        ''-----------------------------------------------------------------
    End Sub

    Sub mostrarRedUninivel()
        Dim tablaRes As New DataTable
        tablaRes = CType(Session("tablaRecorrido"), DataTable)
        '
        Me.GridView1.DataSource = Nothing
        Me.GridView1.DataBind()
        Try
            Me.GridView1.DataSource = tablaRes
            Me.GridView1.DataBind()
            '
            'actualizarGrilla()

        Catch ex As Exception
            'Me.Label3.Text = Err.Description
            MsgBox(Err.Description)
            Me.GridView1.DataSource = Nothing
            Me.GridView1.DataBind()
        End Try
    End Sub

    Sub BuscarPatrocinadorUninivel(ByVal codigoPatrocinador As Integer)
        Dim tm As New DataTable
        Dim tablaPatrocinador As New DataTable
        Dim sql As String
        sql = "select " & _
        "af.codigopatrocinador," & _
        "af.directo," & _
        "af.indirecto," & _
        "af.codigoafiliado," & _
        "af.identificacion," & _
        "af.papellido," & _
        "af.sapellido," & _
        "af.pnombre," & _
        "af.snombre," & _
        "af.nodo," & _
        "af.posicion," & _
        "ra.idRango," & _
        "ra.nombreRango as Rango," & _
        "af.l," & _
        "af.r," & _
        "af.email1" & _
        " from afiliaciones af" & _
        " inner join tbRango ra on af.idRango=ra.idrango" & _
        " where af.codigoAfiliado=" & codigoPatrocinador
        With objOperacione
            tablaPatrocinador = .DevuelveDato(sql)
            If tablaPatrocinador.Rows.Count <> 0 Then
                Session("encontrado") = "si"
                With objRede
                    .codigoPatrocinador = tablaPatrocinador.Rows(0).Item("codigoPatrocinador")
                    .directo = tablaPatrocinador.Rows(0).Item("directo")
                    .indirecto = tablaPatrocinador.Rows(0).Item("indirecto")
                    .codigoAfiliado = tablaPatrocinador.Rows(0).Item("codigoAfiliado")
                    .identificacion = tablaPatrocinador.Rows(0).Item("identificacion")
                    .apellidos = tablaPatrocinador.Rows(0).Item("papellido") & " " & tablaPatrocinador.Rows(0).Item("sapellido")
                    .nombres = tablaPatrocinador.Rows(0).Item("pnombre") & " " & tablaPatrocinador.Rows(0).Item("snombre")
                    .nodo = tablaPatrocinador.Rows(0).Item("nodo")
                    .posicion = tablaPatrocinador.Rows(0).Item("posicion")
                    .rango = tablaPatrocinador.Rows(0).Item("idRango")
                    .left = tablaPatrocinador.Rows(0).Item("l")
                    .right = tablaPatrocinador.Rows(0).Item("r")
                    .email = tablaPatrocinador.Rows(0).Item("email1")
                    .rango = tablaPatrocinador.Rows(0).Item("rango")
                    .nivel = 0
                    '.puntos = 0
                    tm = .grabarRegistro
                    Session("tablaRecorrido") = tm
                End With
            Else
                Session("encontrado") = "no"
            End If
        End With
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Me.MultiView1.ActiveViewIndex = 1
        redBinaria(Me.TextBox1.Text)
        muestraPuntosBinario()
    End Sub

    Sub muestraPuntosBinario()
        Dim tabla As New DataTable
        Dim y As Integer
        With encabezadofactura
            .mesFactura = Me.DropDownList1.SelectedValue
            .anoFactura = Me.DropDownList2.SelectedItem.Text
            For y = 0 To Me.GridView2.Rows.Count - 1
                .codigoAfiliado = Me.GridView2.Rows(y).Cells(0).Text
                tabla = .sumarPuntosPorAfiliado
                If tabla.Rows.Count <> 0 Then
                    Me.GridView2.Rows(y).Cells(15).Text = tabla.Rows(0).Item("suma")
                Else
                    Me.GridView2.Rows(y).Cells(15).Text = "0"
                End If
            Next
        End With
    End Sub

    Sub redBinaria(ByVal codigo As Integer)
        If Me.TextBox1.Text <> "" Then
            With objRede
                .vaciarTabla()
                .crearTablaTemporal()
                BuscarPatrocinadorBinario(codigo)
                If Session("encontrado") = "si" Then
                    'Recorrido(Session("idAfiliado"))
                    RecorridoBinario(Me.TextBox1.Text)
                    Session("numeroRegistros") = Me.GridView2.Rows.Count
                    If Session("numeroRegistros") >= 3 Then
                    Else
                    End If
                End If
            End With
        End If
    End Sub

    Sub RecorridoBinario(ByVal sentenciaIn As String)
        ''-----------------------------------------------------------------
        Dim cadena As String = Nothing
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        Dim tm As New DataTable
        sql = "exec sp_recorrido '" & sentenciaIn & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    With objRede
                        .codigoPatrocinador = tabla.Rows(y).Item("codigoPatrocinador")
                        .directo = tabla.Rows(y).Item("directo")
                        .indirecto = tabla.Rows(y).Item("indirecto")
                        .codigoAfiliado = tabla.Rows(y).Item("codigoAfiliado")
                        .identificacion = tabla.Rows(y).Item("identificacion")
                        .apellidos = tabla.Rows(y).Item("papellido") & " " & tabla.Rows(y).Item("sapellido")
                        .nombres = tabla.Rows(y).Item("pnombre") & " " & tabla.Rows(y).Item("snombre")
                        .nodo = tabla.Rows(0).Item("nodo")
                        .posicion = tabla.Rows(y).Item("posicion")
                        .rango = tabla.Rows(y).Item("rango")
                        .left = tabla.Rows(y).Item("l")
                        .right = tabla.Rows(y).Item("r")
                        .email = tabla.Rows(y).Item("email1")
                        .rango = tabla.Rows(y).Item("rango")
                        tm = .grabarRegistro
                        Session("tablaRecorridoBinario") = tm
                        cadena += tabla.Rows(y).Item("codigoAfiliado") & ","
                    End With
                Next
                cadena = Mid(cadena, 1, cadena.Length - 1)
                RecorridoBinario(cadena)
            Else
                mostrarRedBinaria()
                cadena = ""
            End If
        End With
        ''-----------------------------------------------------------------
    End Sub

    Sub mostrarRedBinaria()
        Dim tablaRes As New DataTable
        tablaRes = CType(Session("tablaRecorridoBinario"), DataTable)
        '
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        Try
            Me.GridView2.DataSource = tablaRes
            Me.GridView2.DataBind()
            '
            'actualizarGrilla()

        Catch ex As Exception
            'Me.Label3.Text = Err.Description
            MsgBox(Err.Description)
            Me.GridView2.DataSource = Nothing
            Me.GridView2.DataBind()
        End Try
    End Sub

    Sub BuscarPatrocinadorBinario(ByVal codigoPatrocinador As Integer)
        Dim tm As New DataTable
        Dim tablaPatrocinador As New DataTable
        Dim sql As String
        sql = "select " & _
        "af.codigopatrocinador," & _
        "af.directo," & _
        "af.indirecto," & _
        "af.codigoafiliado," & _
        "af.identificacion," & _
        "af.papellido," & _
        "af.sapellido," & _
        "af.pnombre," & _
        "af.snombre," & _
        "af.nodo," & _
        "af.posicion," & _
        "ra.idRango," & _
        "ra.nombreRango as Rango," & _
        "af.l," & _
        "af.r," & _
        "af.email1" & _
        " from afiliaciones af" & _
        " inner join tbRango ra on af.idRango=ra.idrango" & _
        " where af.codigoAfiliado=" & codigoPatrocinador
        With objOperacione
            tablaPatrocinador = .DevuelveDato(sql)
            If tablaPatrocinador.Rows.Count <> 0 Then
                Session("encontrado") = "si"
                With objRede
                    .codigoPatrocinador = tablaPatrocinador.Rows(0).Item("codigoPatrocinador")
                    .directo = tablaPatrocinador.Rows(0).Item("directo")
                    .indirecto = tablaPatrocinador.Rows(0).Item("indirecto")
                    .codigoAfiliado = tablaPatrocinador.Rows(0).Item("codigoAfiliado")
                    .identificacion = tablaPatrocinador.Rows(0).Item("identificacion")
                    .apellidos = tablaPatrocinador.Rows(0).Item("papellido") & " " & tablaPatrocinador.Rows(0).Item("sapellido")
                    .nombres = tablaPatrocinador.Rows(0).Item("pnombre") & " " & tablaPatrocinador.Rows(0).Item("snombre")
                    .nodo = tablaPatrocinador.Rows(0).Item("nodo")
                    .posicion = tablaPatrocinador.Rows(0).Item("posicion")
                    .rango = tablaPatrocinador.Rows(0).Item("idRango")
                    .left = tablaPatrocinador.Rows(0).Item("l")
                    .right = tablaPatrocinador.Rows(0).Item("r")
                    .email = tablaPatrocinador.Rows(0).Item("email1")
                    .rango = tablaPatrocinador.Rows(0).Item("rango")
                    .nivel = 0
                    '.puntos = 0
                    tm = .grabarRegistro
                    Session("tablaRecorrido") = tm
                End With
            Else
                Session("encontrado") = "no"
            End If
        End With
    End Sub
End Class
