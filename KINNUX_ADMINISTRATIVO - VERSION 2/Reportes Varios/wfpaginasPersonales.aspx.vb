Imports System.Data

Partial Class Reportes_Varios_wfpaginasPersonales
    Inherits System.Web.UI.Page

    Dim operaciones As New clsOperacione

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        '
        Dim opcion As Integer
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton2.Checked = True Then
                opcion = 2
            End If
        End If
        If Me.RadioButton1.Checked = True And Me.TextBox1.Text = "" Then
            Me.Label4.Text = "Ingrese el codigo del afiliado...!"
            Exit Sub
        End If
        mostrarDatos(opcion)
    End Sub

    Sub mostrarDatos(ByVal opcion As Integer)
        Me.Label5.Text = ""
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "TTcontactoWeb.nombreContacto," & _
        "TTcontactoWeb.mailContacto," & _
        "TTcontactoWeb.paisContacto," & _
        "TTcontactoWeb.mensajeContacto" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTcontactoWeb ON dbo.Afiliaciones.codigoAfiliado = TTcontactoWeb.codigoAfiliado"
        If opcion = 1 Then
            sql = sql & " where dbo.Afiliaciones.codigoAfiliado='" & Me.TextBox1.Text & "'"
        Else
            sql = sql
        End If
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.Label5.Text = "No existen datos...!"
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 0
            Me.RadioButton2.Checked = True
            Me.RadioButton3.Checked = True
            Me.RadioButton8.Checked = True

            Me.TextBox1.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Me.MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            Me.TextBox1.Visible = False
        End If
    End Sub

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.TextBox1.Visible = True
            Me.TextBox1.Focus()
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Me.MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Me.MultiView1.ActiveViewIndex = 2
        Me.RadioButton8.Checked = True
    End Sub

    'Function buscaAfiliado() As String
    '    Dim encontrado As String = "no"
    '    Dim sql As String
    '    Dim tabla As New DataTable
    '    sql = "select * from afiliaciones where codigoafiliado='" & Me.TextBox2.Text & "'"
    '    With operaciones
    '        tabla = .DevuelveDato(sql)
    '        If tabla.Rows.Count <> 0 Then
    '            Me.TextBox3.Text = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
    '            encontrado = "si"
    '        Else
    '            encontrado = "no"
    '            Me.TextBox3.Text = "No existe...!"
    '        End If
    '    End With
    '    Return encontrado
    'End Function

    Protected Sub ImageButton2_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Me.Label13.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.Label14.Text = ""
        Me.Label16.Text = ""
        Me.Label7.Text = ""

        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
        '
        If Me.RadioButton8.Checked = True Then
            sql = "SELECT  " & _
            "TTtestimonio.idtestimonio, " & _
            "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres, " & _
            "TTtestimonio.nombre, " & _
            "TTtestimonio.cuerpoTestimonio, " & _
            "TTtestimonio.estadoTestimonio," & _
            "TTtestimonio.fotoTestimonio," & _
            " case TTtestimonio.estadoTestimonio" & _
            " when 'a' then 'Activo'" & _
            " when 'p' then 'Pendiente'" & _
            " when 'r' then 'Rechazado'" & _
            " else ''" & _
            " end nombreEstado" & _
            " FROM" & _
            " dbo.Afiliaciones INNER JOIN" & _
            " TTtestimonio ON dbo.Afiliaciones.codigoAfiliado = TTtestimonio.codigoAfiliado" & _
            " where TTtestimonio.estadoTestimonio='a'"
        Else
            If Me.RadioButton9.Checked = True Then
                sql = "SELECT  " & _
                "TTtestimonio.idtestimonio, " & _
                "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres, " & _
                "TTtestimonio.nombre, " & _
                "TTtestimonio.cuerpoTestimonio, " & _
                "TTtestimonio.estadoTestimonio," & _
                "TTtestimonio.fotoTestimonio," & _
                " case TTtestimonio.estadoTestimonio" & _
                " when 'a' then 'Activo'" & _
                " when 'p' then 'Pendiente'" & _
                " when 'r' then 'Rechazado'" & _
                " else ''" & _
                " end nombreEstado" & _
                " FROM" & _
                " dbo.Afiliaciones INNER JOIN" & _
                " TTtestimonio ON dbo.Afiliaciones.codigoAfiliado = TTtestimonio.codigoAfiliado" & _
                " where TTtestimonio.estadoTestimonio='p'"
            Else
                If Me.RadioButton10.Checked = True Then
                    sql = "SELECT  " & _
                    "TTtestimonio.idtestimonio, " & _
                    "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres, " & _
                    "TTtestimonio.nombre, " & _
                    "TTtestimonio.cuerpoTestimonio, " & _
                    "TTtestimonio.estadoTestimonio," & _
                    "TTtestimonio.fotoTestimonio," & _
                    " case TTtestimonio.estadoTestimonio" & _
                    " when 'a' then 'Activo'" & _
                    " when 'p' then 'Pendiente'" & _
                    " when 'r' then 'Rechazado'" & _
                    " else ''" & _
                    " end nombreEstado" & _
                    " FROM" & _
                    " dbo.Afiliaciones INNER JOIN" & _
                    " TTtestimonio ON dbo.Afiliaciones.codigoAfiliado = TTtestimonio.codigoAfiliado" & _
                    " where TTtestimonio.estadoTestimonio='r'"
                Else
                    If Me.RadioButton11.Checked = True Then
                        sql = "SELECT  " & _
                        "TTtestimonio.idtestimonio, " & _
                        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Papellido as nombres, " & _
                        "TTtestimonio.nombre, " & _
                        "TTtestimonio.cuerpoTestimonio, " & _
                        "TTtestimonio.estadoTestimonio," & _
                        "TTtestimonio.fotoTestimonio," & _
                        " case TTtestimonio.estadoTestimonio" & _
                        " when 'a' then 'Activo'" & _
                        " when 'p' then 'Pendiente'" & _
                        " when 'r' then 'Rechazado'" & _
                        " else ''" & _
                        " end nombreEstado" & _
                        " FROM" & _
                        " dbo.Afiliaciones INNER JOIN" & _
                        " TTtestimonio ON dbo.Afiliaciones.codigoAfiliado = TTtestimonio.codigoAfiliado"
                    End If
                End If
            End If
        End If
                With operaciones
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView3.DataSource = tabla
                        Me.GridView3.DataBind()
                    Else
                        Me.Label7.Text = "No hay registros...!"
                        Me.GridView3.DataSource = Nothing
                        Me.GridView3.DataBind()
                    End If
                End With
    End Sub

    Protected Sub GridView3_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select " & _
        "idTestimonio," & _
        "nombre," & _
        "cuerpoTestimonio," & _
        " case estadotestimonio" & _
        " when 'a' then 'Activo'" & _
        " when 'n' then 'Anulado'" & _
        " when 'p' then 'Pendiente'" & _
        " when 'r' then 'Rechazado'" & _
        " end estadotestimonio" & _
        " from tttestimonio" & _
        " where idtestimonio=" & Me.GridView3.Rows(e.NewSelectedIndex).Cells(1).Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Label13.Text = tabla.Rows(0).Item("idtestimonio")
                Me.TextBox4.Text = tabla.Rows(0).Item("cuerpotestimonio")
                Me.Label14.Text = tabla.Rows(0).Item("estadotestimonio")
                Me.TextBox5.Text = tabla.Rows(0).Item("nombre")
            Else
                Me.Label13.Text = ""
                Me.TextBox4.Text = ""
                Me.Label14.Text = ""
                Me.TextBox5.Text = ""
            End If
        End With
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Me.Label16.Text = ""
        If Me.Label13.Text = "" Then
            Me.Label16.Text = "Debe seleccionar el testimonio...!"
            Me.TextBox6.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then
            Me.Label16.Text = "Debe ingresar el testimonio y/o el nombre de quien está dando el testimonio...!"
            Me.TextBox6.Focus()
            Exit Sub
        End If
        actualizarTestimonio()
    End Sub

    Sub actualizarTestimonio()
        Dim sql As String
        Dim estado As String = ""
        If Me.RadioButton3.Checked = True Then
            estado = "a"
        Else
            If Me.RadioButton4.Checked = True Then
                estado = "r"
            Else
                If Me.RadioButton5.Checked = True Then
                    estado = "n"
                End If
            End If
        End If
        sql = "exec sp_TTtestimonio " & _
        "@id='" & Me.Label13.Text & "'," & _
        "@codigoAfiliado='0'," & _
        "@fotoTestimonio=''," & _
        "@cuerpoTestimonio='" & Me.TextBox4.Text & "'," & _
        "@estadoTestimonio='" & estado & "'," & _
        "@accion='2'," & _
        "@nombre='" & Me.TextBox5.Text & "'"
        With operaciones
            .Accion(sql)
        End With
        '
        Me.Label13.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.Label14.Text = ""
        mostrarVentana()
        Me.GridView3.DataSource = Nothing
        Me.GridView3.DataBind()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Testimonio Actualizado en el sistema...!');", True)
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        mostrarDatosPedidos()
    End Sub

    Sub mostrarDatosPedidos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTEncPedidoWeb.nombreEncpedidoWeb + ' ' + TTEncPedidoWeb.apellidoEncPedidoWeb as nombrecontacto," & _
        "TTEncPedidoWeb.mailEncPedidoWeb, " & _
        "TTEncPedidoWeb.direccionEncPedidoWeb," & _
        "TTEncPedidoWeb.dptoEncPedidoWeb, " & _
        "TTEncPedidoWeb.paisEncPedidoWeb, " & _
        "TTEncPedidoWeb.telefonoEncPedidoWeb, " & _
        "TTEncPedidoWeb.celularEncPedidoWeb, " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTEncPedidoWeb.id" & _
        " FROM" & _
        " TTEncPedidoWeb INNER JOIN" & _
        " dbo.Afiliaciones ON TTEncPedidoWeb.codigoAfiliado = dbo.Afiliaciones.codigoAfiliado"
        If Me.RadioButton6.Checked = True Then
            sql = sql & " where dbo.Afiliaciones.codigoAfiliado='" & Me.TextBox7.Text & "'"
        Else
            sql = sql
        End If
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView4.DataSource = tabla
                Me.GridView4.DataBind()
            Else
                Me.GridView4.DataSource = Nothing
                Me.GridView4.DataBind()
            End If
        End With
    End Sub

    Protected Sub GridView4_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView4.SelectedIndexChanging
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from ttdetPedidoweb where idencpedidoweb=" & Me.GridView4.Rows(e.NewSelectedIndex).Cells(1).Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView5.DataSource = tabla
                Me.GridView5.DataBind()
            Else
                Me.GridView5.DataSource = Nothing
                Me.GridView5.DataBind()
            End If
        End With
    End Sub
End Class
