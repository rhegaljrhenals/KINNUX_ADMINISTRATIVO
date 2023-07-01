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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatos()
            cargarAno()
            redBinaria(Request.QueryString("id"))
            Me.Panel3.Visible = False
        End If
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from afiliaciones where codigoafiliado='" & Request.QueryString("id") & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label21.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
            End If
        End With
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = 2014 To Now.Year
            Me.DropDownList1.Items.Add(y)
        Next
        Me.DropDownList1.Items.Insert(0, "Año")
    End Sub

    'Function desencriptarCadena() As String
    '    Dim encriptacion As New clsEncriptacion
    '    Dim codigo As String
    '    codigo = encriptacion.Desencriptar(HttpUtility.UrlDecode(Request.QueryString("iu")))
    '    Return codigo
    'End Function

    'Sub cargarAno()
    '    Dim y As Integer
    '    For y = 2012 To Now.Year
    '        Me.DropDownList2.Items.Add(y)
    '    Next
    '    Me.DropDownList2.Items.Insert(0, "Año")
    'End Sub

    Sub redBinaria(ByVal codigo As Integer)
        If codigo <> 0 Then
            With objRede
                .vaciarTablaOrganizacionTS()
                .crearTablaTemporalOTS()
                BuscarPatrocinador(codigo)
                If Session("encontrado") = "si" Then
                    Recorrido(codigo)
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
        sql = "SELECT    " & _
        "dbo.Afiliaciones.codigoAfiliado," & _
        "dbo.Afiliaciones.Pnombre," & _
        "dbo.Afiliaciones.snombre," & _
        "dbo.Afiliaciones.Papellido," & _
        "dbo.Afiliaciones.sapellido," & _
        "dbo.Afiliaciones.codigoPatrocinador," & _
        "dbo.Afiliaciones.directo," & _
        "dbo.Afiliaciones.indirecto," & _
        "0 as compragrupalts," & _
        "0 as compragrupalsts," & _
        "0 as gn1," & _
        "0 as gn2," & _
        "0 as gn3," & _
        "0 as gn4," & _
        "0 as gn5," & _
        "0 as gn6," & _
        "0 as gn7," & _
        "0 as gn8" & _
        " FROM" & _
        " dbo.Afiliaciones " & _
        " where Afiliaciones.codigoAfiliado=" & codigoPatrocinador
        With objOperacione
            tablaPatrocinador = .DevuelveDato(sql)
            If tablaPatrocinador.Rows.Count <> 0 Then
                Session("encontrado") = "si"
                With objRede
                    .codigoPatrocinador = tablaPatrocinador.Rows(0).Item("codigoPatrocinador")
                    .directo = tablaPatrocinador.Rows(0).Item("directo")
                    .indirecto = tablaPatrocinador.Rows(0).Item("indirecto")
                    .codigoAfiliado = tablaPatrocinador.Rows(0).Item("codigoAfiliado")
                    .apellidos = tablaPatrocinador.Rows(0).Item("papellido") & " " & tablaPatrocinador.Rows(0).Item("sapellido")
                    .nombres = tablaPatrocinador.Rows(0).Item("pnombre") & " " & tablaPatrocinador.Rows(0).Item("snombre")
                    .nivel = 0
                    .ts = tablaPatrocinador.Rows(0).Item("compragrupalts")
                    .sts = tablaPatrocinador.Rows(0).Item("compragrupalsts")
                    .gn1 = tablaPatrocinador.Rows(0).Item("gn1")
                    .gn2 = tablaPatrocinador.Rows(0).Item("gn2")
                    .gn3 = tablaPatrocinador.Rows(0).Item("gn3")
                    .gn4 = tablaPatrocinador.Rows(0).Item("gn4")
                    .gn5 = tablaPatrocinador.Rows(0).Item("gn5")
                    .gn6 = tablaPatrocinador.Rows(0).Item("gn6")
                    .gn7 = tablaPatrocinador.Rows(0).Item("gn7")
                    .gn8 = tablaPatrocinador.Rows(0).Item("gn8")
                    tm = .grabarRegistroRedPatrocinioOTS
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
        sql = "exec sp_recorridoRedDePatrocinioOTS '" & sentenciaIn & "'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                For y = 0 To tabla.Rows.Count - 1
                    With objRede
                        .codigoPatrocinador = tabla.Rows(y).Item("codigoPatrocinador")
                        .directo = tabla.Rows(y).Item("directo")
                        .indirecto = tabla.Rows(y).Item("indirecto")
                        .codigoAfiliado = tabla.Rows(y).Item("codigoAfiliado")
                        .apellidos = tabla.Rows(y).Item("papellido") & " " & tabla.Rows(y).Item("sapellido")
                        .nombres = tabla.Rows(y).Item("pnombre") & " " & tabla.Rows(y).Item("snombre")
                        .nivel = Session("nivel")
                        .puntos = 0
                        .ts = tabla.Rows(0).Item("compragrupalts")
                        .sts = tabla.Rows(0).Item("compragrupalsts")
                        .gn1 = tabla.Rows(0).Item("gn1")
                        .gn2 = tabla.Rows(0).Item("gn2")
                        .gn3 = tabla.Rows(0).Item("gn3")
                        .gn4 = tabla.Rows(0).Item("gn4")
                        .gn5 = tabla.Rows(0).Item("gn5")
                        .gn6 = tabla.Rows(0).Item("gn6")
                        .gn7 = tabla.Rows(0).Item("gn7")
                        .gn8 = tabla.Rows(0).Item("gn8")
                        tm = .grabarRegistroRedPatrocinioOTS
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

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Me.Label20.Text = ""
        Me.Panel3.Visible = False
        If Me.DropDownList1.SelectedIndex > 0 And Me.DropDownList2.SelectedIndex > 0 Then
            Me.Panel3.Visible = True
            actualizaGrupales()
        Else
            Me.Label20.Text = "Seleccione el periodo correctamente...!"
        End If

    End Sub

    Sub actualizaGrupales()
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        If Me.GridView1.Rows.Count <> 0 Then
            For y = 0 To Me.GridView1.Rows.Count - 1
                sql = "select * from TTGrupalts " & _
                    " where codigoafiliado=" & Me.GridView1.Rows(y).Cells(0).Text & " and" & _
                    " mesGrupalTs=" & Me.DropDownList2.SelectedValue & " and" & _
                    " anoGrupalTs=" & Me.DropDownList1.SelectedItem.Text
                With objOperacione
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Dim ts As Double = tabla.Rows(0).Item("compragrupalts")
                        Dim sts As Double = tabla.Rows(0).Item("compragrupalsts")

                        Dim gn1 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts")
                        Dim gn2 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts")
                        Dim gn3 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts")
                        Dim gn4 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts")
                        Dim gn5 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts")
                        Dim gn6 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts") + tabla.Rows(0).Item("nivel6grupalts")
                        Dim gn7 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts") + tabla.Rows(0).Item("nivel6grupalts") + tabla.Rows(0).Item("nivel7grupalts")
                        Dim gn8 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts") + tabla.Rows(0).Item("nivel6grupalts") + tabla.Rows(0).Item("nivel7grupalts") + tabla.Rows(0).Item("nivel8grupalts")
                        Dim gn15 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts") + tabla.Rows(0).Item("nivel6grupalts") + tabla.Rows(0).Item("nivel7grupalts") + tabla.Rows(0).Item("nivel8grupalts") + tabla.Rows(0).Item("nivel9grupalts") + tabla.Rows(0).Item("nivel10grupalts") + tabla.Rows(0).Item("nivel11grupalts") + tabla.Rows(0).Item("nivel12grupalts") + tabla.Rows(0).Item("nivel13grupalts") + tabla.Rows(0).Item("nivel14grupalts") + tabla.Rows(0).Item("nivel15grupalts")
                        Dim gn20 As Double = tabla.Rows(0).Item("compragrupalts") + tabla.Rows(0).Item("compragrupalsts") + tabla.Rows(0).Item("nivel1grupalts") + tabla.Rows(0).Item("nivel2grupalts") + tabla.Rows(0).Item("nivel3grupalts") + tabla.Rows(0).Item("nivel4grupalts") + tabla.Rows(0).Item("nivel5grupalts") + tabla.Rows(0).Item("nivel6grupalts") + tabla.Rows(0).Item("nivel7grupalts") + tabla.Rows(0).Item("nivel8grupalts") + tabla.Rows(0).Item("nivel9grupalts") + tabla.Rows(0).Item("nivel10grupalts") + tabla.Rows(0).Item("nivel11grupalts") + tabla.Rows(0).Item("nivel12grupalts") + tabla.Rows(0).Item("nivel13grupalts") + tabla.Rows(0).Item("nivel14grupalts") + tabla.Rows(0).Item("nivel15grupalts") + tabla.Rows(0).Item("nivel16grupalts") + tabla.Rows(0).Item("nivel17grupalts") + tabla.Rows(0).Item("nivel18grupalts") + tabla.Rows(0).Item("nivel19grupalts") + tabla.Rows(0).Item("nivel20grupalts")
                        '
                        If ts = 0 Then
                            Me.GridView1.Rows(y).Cells(3).Text = ""
                        Else
                            Me.GridView1.Rows(y).Cells(3).Text = ts
                        End If
                        '
                        If sts = 0 Then
                            Me.GridView1.Rows(y).Cells(4).Text = ""
                        Else
                            Me.GridView1.Rows(y).Cells(4).Text = sts
                        End If
                        '
                        Me.GridView1.Rows(y).Cells(5).Text = gn1
                        Me.GridView1.Rows(y).Cells(6).Text = gn2
                        Me.GridView1.Rows(y).Cells(7).Text = gn3
                        Me.GridView1.Rows(y).Cells(8).Text = gn4
                        Me.GridView1.Rows(y).Cells(9).Text = gn5
                        Me.GridView1.Rows(y).Cells(10).Text = gn6
                        Me.GridView1.Rows(y).Cells(11).Text = gn7
                        Me.GridView1.Rows(y).Cells(12).Text = gn8
                        Me.GridView1.Rows(y).Cells(13).Text = gn15
                        Me.GridView1.Rows(y).Cells(14).Text = gn20

                    Else
                        Me.GridView1.Rows(y).Cells(3).Text = ""
                        Me.GridView1.Rows(y).Cells(4).Text = ""
                        Me.GridView1.Rows(y).Cells(5).Text = ""
                        Me.GridView1.Rows(y).Cells(6).Text = ""
                        Me.GridView1.Rows(y).Cells(7).Text = ""
                        Me.GridView1.Rows(y).Cells(8).Text = ""
                        Me.GridView1.Rows(y).Cells(9).Text = ""
                        Me.GridView1.Rows(y).Cells(10).Text = ""
                        Me.GridView1.Rows(y).Cells(11).Text = ""
                        Me.GridView1.Rows(y).Cells(12).Text = ""
                        Me.GridView1.Rows(y).Cells(13).Text = ""
                        Me.GridView1.Rows(y).Cells(14).Text = ""

                    End If
                End With
            Next
        End If
    End Sub
   
End Class
