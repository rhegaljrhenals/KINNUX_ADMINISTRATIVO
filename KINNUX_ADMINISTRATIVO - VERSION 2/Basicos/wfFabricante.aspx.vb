Imports System.Data
Imports System.IO

Partial Class Basicos_wfFabricante
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim fabricante As New clsFabricante
    Dim extensionArchivo As String = String.Empty
    Dim extensionArchivoFichaTecnica As String = String.Empty

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            CargarFabricante()
            Nuevo()
            mostrarNumeroDeRegistro()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub mostrarNumeroDeRegistro()
        Me.Label10.Text = "Numero De Registros: " & Me.GridView1.Rows.Count
    End Sub

    Sub CargarFabricante()
        Dim tabla As New DataTable
        With fabricante
            tabla = .obtieneFabricantesTodos
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim nombreArchivo As String = String.Empty
        Dim nombreArchivoFichaTecnica As String = String.Empty

        '
        Dim huboError As String = "no"
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        Me.Label7.Text = ""
        Me.Label8.Text = ""
        Me.Label11.Text = ""
        '
        If Me.TextBox8.Text = "" Then
            Me.Label9.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox2.Text = "" Then
            Me.Label2.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox3.Text = "" Then
            Me.Label3.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox4.Text = "" Then
            Me.Label4.Text = "* requerido"
            huboError = "si"
        End If
        '
        If Me.TextBox5.Text = "" Then
            Me.Label5.Text = "* requerido"
            huboError = "si"
        End If
        '
        ''-----------------------------------------------------------------------
        '' valida el permiso de salud del fabricante
        'If Me.AsyncFileUpload1.HasFile Then
        '    nombreArchivo = AsyncFileUpload1.FileName
        '    extensionArchivo = Path.GetExtension(nombreArchivo)
        '    '
        '    If ValidaExtension(extensionArchivo) = True Then
        '        AsyncFileUpload1.SaveAs(MapPath("~/Fabricantes Permisos Salud/" + Me.TextBox8.Text & extensionArchivo))
        '        'imgSubida.Width = 300
        '        'imgSubida.Width = 300
        '        'imgSubida.ImageUrl = "/images/" & sName
        '        'lblMensaje.Text = "Archivo cargado correctamente."
        '    Else
        '        Me.Label11.Text = "- El tipo de archivo cargado no es valido, (Solo archivos .Jpg, o .Pdf)"
        '        huboError = "si"
        '    End If
        'Else
        '    Me.Label11.Text = "No ha seleccionado ningun archivo...!"
        '    huboError = "si"
        'End If
        '-----------------------------------------------------------------------
        '-----------------------------------------------------------------------
        ' valida la ficha tecnica del fabricante
        'If Me.AsyncFileUpload2.HasFile Then
        '    nombreArchivoFichaTecnica = AsyncFileUpload2.FileName
        '    extensionArchivoFichaTecnica = Path.GetExtension(nombreArchivoFichaTecnica)
        '    '
        '    If ValidaExtension(extensionArchivoFichaTecnica) = True Then
        '        AsyncFileUpload2.SaveAs(MapPath("~/Fabricantes Ficha Tecnica/" + Me.TextBox8.Text & extensionArchivoFichaTecnica))
        '    Else
        '        Me.Label11.Text = "- El tipo de archivo cargado no es valido, (Solo archivos .Jpg, o .Pdf)"
        '        huboError = "si"
        '    End If
        'Else
        '    Me.Label11.Text = "No ha seleccionado ningun archivo...!"
        '    huboError = "si"
        'End If
        '-----------------------------------------------------------------------
        '
        If huboError = "si" Then
            Exit Sub
        End If
        '
        Grabar()
        CargarFabricante()
        Nuevo()
        Me.Label1.Text = "Registro Actualizado En El Sistema...!"
        mostrarNumeroDeRegistro()
    End Sub

    Sub Grabar()
        With fabricante
            If Session("accion") = 1 Then
                .idFabricante = 0
            Else
                .idFabricante = Me.TextBox1.Text
            End If
            .codigoFabricante = Me.TextBox8.Text
            .nombreFabricante = Me.TextBox2.Text
            .direccionFabricante = Me.TextBox3.Text
            .telefonoFabricante = Me.TextBox4.Text
            .emailFabricante = Me.TextBox5.Text
            .dptoFabricante = Me.TextBox6.Text
            .ciudadFabricante = Me.TextBox7.Text
            .estadoFabricante = Me.DropDownList1.SelectedValue
            .permisoFabricante = "" '~/Fabricantes Permisos Seguridad/" & Me.TextBox8.Text & extensionArchivo
            .fichaFabricante = "" '~/Fabricantes Ficha Tecnica/" & Me.TextBox8.Text & extensionArchivoFichaTecnica
            .actualizarFabricante(Session("accion"))
        End With
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Nuevo()
    End Sub

    Sub Nuevo()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        '
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        '
        Me.TextBox8.Focus()
        Session("accion") = 1
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
        Me.Label5.Text = ""
        Me.Label9.Text = ""
        '
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(1).Text
        MostrarFabricantePorId()
        Session("accion") = 2
    End Sub

    Sub MostrarFabricantePorId()
        Dim tablaEmpresa As New DataTable
        With fabricante
            .idFabricante = Me.TextBox1.Text
            tablaEmpresa = .obtieneFabricantesPorId
            Me.TextBox2.Text = tablaEmpresa.Rows(0).Item("nombreFabricante")
            Me.TextBox3.Text = tablaEmpresa.Rows(0).Item("direccionFabricante")
            Me.TextBox4.Text = tablaEmpresa.Rows(0).Item("telefonoFabricante")
            Me.TextBox5.Text = tablaEmpresa.Rows(0).Item("emailFabricante")
            Me.TextBox6.Text = tablaEmpresa.Rows(0).Item("dptoFabricante")
            Me.TextBox7.Text = tablaEmpresa.Rows(0).Item("ciudadFabricante")
            Me.TextBox8.Text = tablaEmpresa.Rows(0).Item("codigoFabricante")
            Me.DropDownList1.SelectedValue = tablaEmpresa.Rows(0).Item("estadoFabricante")
            '
        End With
    End Sub

    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension
            Case ".jpg", ".jpeg", ".png", ".gif", ".bmp"
                Return True
            Case ".Pdf", ".pdf", ".PDF"
                Return True
            Case Else
                Return False
        End Select
    End Function
End Class
