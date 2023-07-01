Imports System.Data

Partial Class Basicos_wfEquipos
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim equipos As New clsEquipos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarPais()
            cargarEquipos()
            nuevo()
            Me.panelError.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarEquipos()
        Dim tabla As New DataTable
        With equipos
            tabla = .obtenerEquipos
            Me.GridView2.DataSource = tabla
            Me.GridView2.DataBind()
        End With
    End Sub

    Sub cargarPais()
        Dim tabla As New DataTable
        With pais
            tabla = .MostrarPaise
            Me.DropDownList23.DataSource = tabla
            Me.DropDownList23.DataTextField = "nombrePais"
            Me.DropDownList23.DataValueField = "codigoPais"
            Me.DropDownList23.DataBind()
        End With
        Me.DropDownList23.Items.Insert(0, "Seleccione Pais")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.panelError.Visible = False
        Me.Label15.Text = ""
        '
        If Me.DropDownList23.SelectedIndex = 0 Or Me.DropDownList23.SelectedIndex = -1 Then
            huboError = "si"
            mensajeError = "- Seleccione el pais"
        End If
        ''
        If Me.TextBox1.Text = "" Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- Ingrese el nombre de la papeleria"
        End If
        '
        If Me.TextBox3.Text Is Nothing Or Val(Me.TextBox3.Text) <= 0 Then
            huboError = "si"
            mensajeError = mensajeError & "<br>" & "- ingrese el precio de la papeleria correctamente"
        End If
        ''
        If huboError = "si" Then
            Me.panelError.Visible = True
            Me.Label15.Text = mensajeError
            Exit Sub
        End If
        '
        grabarEquipo()
        grabarEquipoPais()
        cargarEquipos()
        nuevo()
    End Sub

    Sub nuevo()
        Me.DropDownList23.SelectedIndex = 0
        Me.TextBox1.Text = Nothing
        Me.TextBox3.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.TextBox8.Text = Nothing
        '
        Me.DropDownList25.SelectedIndex = 0
        Me.panelError.Visible = False
        Session("accion") = 1
        '
        Me.TextBox1.Focus()
    End Sub

    Sub grabarEquipo()
        With equipos
            If Session("accion") = 1 Then
                .idEquipom = 0
            Else
                .idEquipom = Val(Me.TextBox7.Text)
            End If
            .nombreEquipom = Me.TextBox1.Text.ToUpper
            .grabarEquipo(Session("accion"))
        End With
    End Sub

    Sub grabarEquipoPais()
        With equipos
            If Session("accion") = 1 Then
                .idEquipoPais = 0
            Else
                .idEquipoPais = Val(Me.TextBox8.Text)
            End If
            .idPais = Me.DropDownList23.SelectedValue
            .precioEquipo = Me.TextBox3.Text
            .estadoEquipo = Me.DropDownList25.SelectedValue
            .grabarEquipoPais(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox7.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox8.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(3).Text
        '
        Me.DropDownList23.SelectedValue = Me.GridView2.Rows(e.NewSelectedIndex).Cells(6).Text
        Me.TextBox1.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.TextBox3.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
        '
        Session("accion") = 2
    End Sub
End Class
