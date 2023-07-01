Imports System.Data

Partial Class Seguridad_wfOpciones
    Inherits System.Web.UI.Page

    Dim opcionesPrincipales As New clsOpciones

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        Me.TextBox6.Text = "1"
        Me.Label5.Text = "Opciones Aplicacion Administrativa"
        cargarOpcionesPrincipales(1)
    End Sub

    Sub cargarOpcionesPrincipales(ByVal opcion As Integer)
        Button11.Visible = False
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        '
        Dim tabla As New DataTable
        Me.GridView2.DataSource = tabla
        Me.GridView2.DataBind()
        With opcionesPrincipales
            .tipoOpcion = opcion
            tabla = .obtenerOpcionesPrincipales
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombremenu"
                Me.DropDownList1.DataValueField = "idmenu"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Opcion Principal")
        End With
    End Sub

    Protected Sub Button8_Click(sender As Object, e As System.EventArgs) Handles Button8.Click
        If Me.DropDownList1.SelectedIndex > 0 Then
            Me.TextBox4.Text = Me.DropDownList1.SelectedValue.ToString
            mostrarOpcionesSubmenu(Me.TextBox6.Text, Me.DropDownList1.SelectedValue, Me.GridView2)
        Else
            GridView2.DataSource = Nothing
            GridView2.DataBind()
        End If
    End Sub

    Sub mostrarOpcionesSubmenu(ByVal aplicacion As Integer, ByVal tipoOpcion As Integer, ByVal grilla As GridView)
        Button11.Visible = False
        Dim tabla As New DataTable
        With opcionesPrincipales
            .idAplicacion = aplicacion
            .idOpcionPrincipal = tipoOpcion
            tabla = .obtenerOpcionesSubmenu
            If tabla.Rows.Count <> 0 Then
                grilla.DataSource = tabla
                grilla.DataBind()
                Button11.Visible = True
            Else
                grilla.DataSource = Nothing
                grilla.DataBind()
            End If
        End With
    End Sub

    Protected Sub Button10_Click(sender As Object, e As System.EventArgs) Handles Button10.Click
        Me.Label4.Text = ""
        If Me.DropDownList1.SelectedIndex = 0 Then
            Me.Label4.Text = "Debe seleccionar la opcion principal...!"
            Me.DropDownList1.Focus()
            Exit Sub
        End If
        Me.RadioButton1.Checked = True
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox5.Text = "1"
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Button9_Click(sender As Object, e As System.EventArgs) Handles Button9.Click
        Me.Label4.Text = ""
        If Me.TextBox4.Text = "" Then
            Me.Label4.Text = "Debe seleccionar la opcion principal...!"
            Me.TextBox4.Focus()
            Exit Sub
        End If
        '
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Then
            Me.Label4.Text = "Debe ingresar todos los datos de la opcion...!"
            Exit Sub
        End If
        grabarOpcionSubmenu(Me.TextBox6.Text, Me.DropDownList1.SelectedValue, Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
        mostrarVentana("Opcion Grabada En El Sistema...!")
        Me.TextBox4.Text = Me.DropDownList1.SelectedValue.ToString
        mostrarOpcionesSubmenu(Me.TextBox6.Text, Me.DropDownList1.SelectedValue, Me.GridView2)
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
    End Sub

    Sub grabarOpcionSubmenu(ByVal aplicacion As Integer, ByVal idMenu As Integer, ByVal idSubmenu As Integer, ByVal nombreSubmenu As String, ByVal ruta As String)
        Dim accion As Integer
        Dim estado As Integer
        If Me.TextBox5.Text = "1" Then
            accion = 1
        Else
            accion = 2
        End If
        'estado
        If Me.RadioButton1.Checked = True Then
            estado = 1
        Else
            estado = 0
        End If
        With opcionesPrincipales
            .idMenu = idMenu
            .idSubMenu = idSubmenu
            .nombreSubmenu = nombreSubmenu
            .ruta = ruta
            .tipoSubmenu = aplicacion
            '.orden = 0
            '.estado = estado
            .grabarOpcionSubmenu(accion)
        End With
    End Sub

    Protected Sub GridView2_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView2.RowDataBound
        Dim fila As GridViewRow
        Dim tabla As New DataTable
        fila = e.Row
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(5).Text = "Eliminado" Then
                e.Row.ForeColor = Drawing.Color.Red
            End If
            If fila.RowType = DataControlRowType.DataRow Then
                Dim eliminar As CheckBox = CType(e.Row.FindControl("CheckBox1"), CheckBox)
                If e.Row.Cells(5).Text = "Eliminado" Then
                    eliminar.Checked = True
                Else
                    eliminar.Checked = False
                End If
            End If
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        '
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        Me.TextBox5.Text = "2"
        If Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text = "Activo" Then
            Me.RadioButton1.Checked = True
            Me.RadioButton2.Checked = False
        Else
            Me.RadioButton2.Checked = True
            Me.RadioButton1.Checked = False
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.TextBox6.Text = "1"
            Me.Label5.Text = "Opciones Aplicacion Administrativa"
            cargarOpcionesPrincipales(1)
        End If
    End Sub

    Protected Sub Button6_Click(sender As Object, e As System.EventArgs) Handles Button6.Click
        Me.TextBox6.Text = "2"
        Me.Label5.Text = "Opciones Aplicacion Pais"
        cargarOpcionesPrincipales(2)
    End Sub

    Protected Sub Button7_Click(sender As Object, e As System.EventArgs) Handles Button7.Click
        Me.TextBox6.Text = "3"
        Me.Label5.Text = "Opciones Aplicacion Punto"
        cargarOpcionesPrincipales(3)
    End Sub

    Protected Sub Button11_Click(sender As Object, e As System.EventArgs) Handles Button11.Click
        Dim estado As Integer
        Dim fila As GridViewRow
        Dim y As Integer
        Dim tabla As New DataTable
        If Me.GridView2.Rows.Count <> 0 Then
            For y = 0 To Me.GridView2.Rows.Count - 1
                fila = Me.GridView2.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim check As CheckBox = CType(Me.GridView2.Rows(y).FindControl("CheckBox1"), CheckBox)
                    If check.Checked = True Then
                        estado = 0
                    Else
                        estado = 1
                    End If
                    With opcionesPrincipales
                        .idAplicacion = Me.TextBox6.Text
                        .idMenu = Me.TextBox4.Text
                        .idSubMenu = Me.GridView2.Rows(y).Cells(1).Text
                        .idTbSubMenu = Me.GridView2.Rows(y).Cells(1).Text
                        .actualizaestadosOpcionesPorIdtbSubmenu(estado)
                    End With
                End If
            Next
        End If
        mostrarVentana("Opcion Actualizadas En El Sistema")
        Me.TextBox4.Text = Me.DropDownList1.SelectedValue.ToString
        mostrarOpcionesSubmenu(Me.TextBox6.Text, Me.DropDownList1.SelectedValue, Me.GridView2)
    End Sub

    Sub mostrarVentana(ByVal mensaje As String)
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('" & mensaje & "');", True)
    End Sub
End Class
