Imports System.Data

Partial Class Reportes_Varios_wfRedUninivel
    Inherits System.Web.UI.Page


    Dim objRede As New clsRedes
    Dim objOperacione As New clsOperacione
    Dim afiliado As New ClsAfiliado
    Dim tablaBinaria As New clsTablaRedBinaria
    Dim matrizBinaria(,) As String = {}
    Dim encabezadofactura As New clsTTEncFacturaPro
    Public nivel As Integer = 1
    Dim encabezadoRemision As New clsTTEncFacturaPro

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            If Request.QueryString("id") Is Nothing Then
                Response.Redirect("Default.aspx")
            End If
            '
            Me.Panel6.Visible = False
            'cargarAno()
            redBinaria(Val(Request.QueryString("id")))
            'mostrarGrafica(Request.QueryString("id"))
        End If
    End Sub

    Sub redBinaria(ByVal codigo As Integer)
        If Request.QueryString("id") <> 0 Then
            With objRede
                .vaciarTabla()
                .crearTablaTemporal()
                BuscarPatrocinador(codigo)
                If Session("encontrado") = "si" Then
                    Recorrido(Request.QueryString("id"))
                    Session("numeroRegistros") = Me.GridView1.Rows.Count
                    If Session("numeroRegistros") >= 3 Then
                    Else
                    End If
                End If
            End With
        End If
    End Sub

    Sub BuscarPatrocinador(ByVal codigoPatrocinador As Integer)
        Dim tm As New DataTable
        Dim tablaPatrocinador As New DataTable
        Dim sql As String
        'sql = "select *" & _
        '    " from afiliaciones" & _
        '    " where codigoAfiliado=" & codigoPatrocinador
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

    Sub Recorrido(ByVal sentenciaIn As String)
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
                Recorrido(cadena)
            Else
                mostrarRedBinaria()
                cadena = ""
            End If
        End With
        ''-----------------------------------------------------------------
    End Sub

    Sub mostrarRedBinaria()
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

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label2.Text = ""
        Me.Panel6.Visible = False
        Dim codigoPatrocinador As String = ""
        Dim tabla As New DataTable
        '------------------------------------------------------------------------------------
        With encabezadoRemision
            .codigoAfiliado = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
            tabla = .obtenerDatosEncabezadoRemisionPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.Panel6.Visible = True
                Me.Label1.Text = "Compras (" & Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text & ") " & Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.Panel6.Visible = True
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label2.Text = "No hay registro de compras para este afiliado...!"
                Me.Label1.Text = "Compras (" & Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text & ") " & Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
            End If
        End With
        '------------------------------------------------------------------------------------

    End Sub
End Class
