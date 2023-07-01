Imports System.Data

Partial Class Basicos_wfActualizacionPrecios
    Inherits System.Web.UI.Page

    Dim empresas As New clsEmpresa
    Dim productos As New clsProducto
    Dim paquetes As New clsTBPaquete
    Dim paquetePais As New clsPaquete

    Sub cargarPaquetes()
        Dim tabla As New DataTable
        With paquetes
            tabla = .obtenerPaquetes
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEmpresas()
            cargarProductos()
            cargarPaquetes()
            Me.ImageButton2.Visible = False
            Me.ImageButton3.Visible = False
        End If
    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With productos
            tabla = .obtenerTTProducto
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Sub cargarEmpresas()
        Dim tabla As New DataTable
        With empresas
            tabla = .MostrarEmpresaGeneral
            If tabla.Rows.Count <> 0 Then
                Me.DropDownList1.DataSource = tabla
                Me.DropDownList1.DataTextField = "nombreempresa"
                Me.DropDownList1.DataValueField = "idpais"
                Me.DropDownList1.DataBind()
            Else
                Me.DropDownList1.DataSource = Nothing
                Me.DropDownList1.DataBind()
            End If
            Me.DropDownList1.Items.Insert(0, "Seleccione Empresa")
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.ImageButton2.Visible = False
        Me.ImageButton3.Visible = False
        '
        If Me.DropDownList1.SelectedIndex > 0 Then
            cargarProductos()
            cargarPaquetes()
            '
            cargarPrecioPais()
            cargarPreciosPaquetes()
            Me.ImageButton2.Visible = True
            Me.ImageButton3.Visible = True
        End If
    End Sub

    Sub cargarPreciosPaquetes()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim tabla As New DataTable
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim precio As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox2"), TextBox)
                If IsNothing(precio.Text) Or precio.Text = "0" Then

                Else
                    With paquetePais
                        .idPais = Me.DropDownList1.SelectedValue
                        .idPaquete = Me.GridView3.Rows(y).Cells(0).Text
                        tabla = .obtenerPreciosPorPaqueteyPais
                        If tabla.Rows.Count <> 0 Then
                            precio.Text = tabla.Rows(0).Item("precioPaquetePais")
                        End If
                    End With
                End If
            End If
        Next
    End Sub

    Sub cargarPrecioPais()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim tabla As New DataTable
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim precio As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox1"), TextBox)
                If IsNothing(precio.Text) Or precio.Text = "0" Then

                Else
                    With productos
                        .idPais = Me.DropDownList1.SelectedValue
                        .idProducto = Me.GridView2.Rows(y).Cells(0).Text
                        tabla = .obtenerPreciosPorProductos
                        If tabla.Rows.Count <> 0 Then
                            precio.Text = tabla.Rows(0).Item("precioProductoPais")
                        End If
                    End With
                End If
            End If
        Next
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Precios Productos Actualizados En El Sistema...!');", True)
    End Sub

    Sub actualizaPrecioProductos()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim tabla As New DataTable
        For y = 0 To Me.GridView2.Rows.Count - 1
            fila = Me.GridView2.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim precio As TextBox = CType(Me.GridView2.Rows(y).FindControl("TextBox1"), TextBox)
                If precio.Text = "" Then
                    precio.Text = "0"
                Else
                    With productos
                        .idPais = Me.DropDownList1.SelectedValue
                        .idProducto = Me.GridView2.Rows(y).Cells(0).Text
                        .precioProductoPais = precio.Text
                        .actualizaPrecioProducto()
                    End With
                End If
            End If
        Next
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        actualizaPrecioProductos()
        cargarProductos()
        'cargarPaquetes()
        mostrarVentana()
        'mostrarVentanaPaquete()
    End Sub

    Sub mostrarVentanaPaquete()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Precios Paquetes Actualizados En El Sistema...!');", True)
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        actualizaPrecioPaquetes()
        'cargarProductos()
        cargarPaquetes()
        '
        mostrarVentanaPaquete()
    End Sub

    'Sub mostrarVentana()
    '    ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Precios de productos actualizados En El Sistema...!');", True)
    'End Sub

    Sub actualizaPrecioPaquetes()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim tabla As New DataTable
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim precio As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox2"), TextBox)
                If precio.Text = "" Then
                    precio.Text = "0"
                End If
                '
                If precio.Text <> "0" Then
                    With paquetePais
                        .idPais = Me.DropDownList1.SelectedValue
                        .idpaquetePais = Me.GridView3.Rows(y).Cells(0).Text
                        .idPaquete = Me.GridView3.Rows(y).Cells(0).Text
                        .precioPaquetePais = precio.Text
                        .actualizaPreciosPaquetes()
                    End With
                End If
            End If
        Next
    End Sub
End Class
