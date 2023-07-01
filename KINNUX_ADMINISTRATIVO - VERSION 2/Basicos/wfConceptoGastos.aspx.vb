Imports System.Data
Imports System.IO


Partial Class Basicos_wfSucursale
    Inherits System.Web.UI.Page

    Dim conceptoGastos As New clsConceptoGastos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label8.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim huboError As String = "no"
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        '
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* requerido"
            huboError = "si"
        End If
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        mostrarVentana()
        Nuevo()
    End Sub

    Sub cargarGastos()
        Dim tabla As New DataTable
        With conceptoGastos
            tabla = .obtenerConceptoDeGastos
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Registro Ingresado En El Sistema...!');", True)
    End Sub

    Sub Grabar()
        Dim accion As Integer
        Dim id As Integer
        If Me.TextBox1.Text = "" Then
            accion = 1
            id = 0
        Else
            accion = 2
            id = Me.TextBox1.Text
        End If
        '
        With conceptoGastos
            .idConcepto = id
            .nombreGasto = Me.TextBox2.Text
            .estadoConcepto = Me.DropDownList1.SelectedValue
            .grabarConcepto(accion)
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Nuevo()
    End Sub

    Sub Nuevo()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        '
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        '
        Me.TextBox2.Focus()
        cargarGastos()
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        Me.TextBox2.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        If Me.GridView1.Rows(e.NewSelectedIndex).Cells(3).Text = "Activo" Then
            Me.DropDownList1.SelectedIndex = 0
        Else
            Me.DropDownList1.SelectedIndex = 1
        End If
    End Sub
End Class
