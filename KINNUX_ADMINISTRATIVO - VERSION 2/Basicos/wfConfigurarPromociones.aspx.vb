Imports System.Data

Partial Class Basicos_wfProducto
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim producto As New clsProducto
    Dim promociones As New clsPromocion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEventos()
            cargarPromociones()
            cargarPais()
            'cargarLineas()
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If

    End Sub

    Sub cargarProductos()
        Dim tabla As New DataTable
        With producto
            tabla = .obtenerTTProducto
            If tabla.Rows.Count <> 0 Then
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If

        End With
    End Sub

    Sub cargarPais()
        With objOperacione
            .cargarCombos(Me.DropDownList26, "select * from tbempresa", "idEmpresa", "nombreempresa", "Seleccione La Empresa")
            Me.DropDownList26.SelectedIndex = 0
        End With
    End Sub

    Sub cargarPromociones()
        Dim y As Integer
        Dim sql As String
        Dim tabla As New DataTable
        With promociones
            tabla = .obtenerPromocionesTS
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
        'actualiza eventos y sucursales
        If Me.GridView2.Rows.Count <> 0 Then
            For y = 0 To Me.GridView2.Rows.Count - 1
                'sucursal
                sql = "SELECT        " & _
                    "dbo.TBEmpresa.idEmpresa," & _
                    "dbo.TBEmpresa.nombreEmpresa," & _
                    "dbo.TBSucursal.nombreSucursal" & _
                    " FROM" & _
                    " dbo.TBPromocionTS INNER JOIN" & _
                    " dbo.TBEmpresa ON dbo.TBPromocionTS.idpais = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
                    " dbo.TBSucursal ON dbo.TBPromocionTS.idpais = dbo.TBSucursal.idEmpresa AND dbo.TBPromocionTS.idsucursal = dbo.TBSucursal.idSucursal" & _
                    " where TBPromocionTS.idPromocionTs=" & Me.GridView2.Rows(y).Cells(1).Text
                With objOperacione
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView2.Rows(y).Cells(8).Text = tabla.Rows(0).Item("nombreSucursal")
                    Else
                        Me.GridView2.Rows(y).Cells(8).Text = ""

                    End If
                End With
                'evento
                sql = "SELECT        " & _
                "TBEvento.nombreEvento" & _
                " FROM" & _
                " dbo.TBPromocionTS INNER JOIN" & _
                " TBEvento ON dbo.TBPromocionTS.idevento = TBEvento.idEvento" & _
                " where TBPromocionTS.idPromocionTs=" & Me.GridView2.Rows(y).Cells(1).Text
                With objOperacione
                    tabla = .DevuelveDato(sql)
                    If tabla.Rows.Count <> 0 Then
                        Me.GridView2.Rows(y).Cells(6).Text = tabla.Rows(0).Item("nombreEvento")
                    Else
                        Me.GridView2.Rows(y).Cells(6).Text = ""

                    End If
                End With
            Next
        End If
     End Sub

    Sub cargarEventos()
        Dim sql As String
        sql = "SELECT     " & _
        "TBEvento.idEvento, " & _
        "TBEvento.nombreEvento + ' *** ( ' + dbo.TBSucursal.nombreSucursal + ' )' as nombre " & _
        " FROM" & _
        " TBEvento INNER JOIN" & _
        " dbo.TBEmpresa ON TBEvento.idEmpresa = dbo.TBEmpresa.idEmpresa INNER JOIN" & _
        " dbo.TBSucursal ON TBEvento.idSucursal = dbo.TBSucursal.idSucursal" & _
        " where TBEvento.estadoEvento = 1 order by TBEvento.idEvento"
        With objOperacione
            .cargarCombos(Me.DropDownList25, sql, "idEvento", "nombre", "Seleccione Evento")
        End With
    End Sub


    Sub cargarLineas()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select idLinea,nombreLinea from TBlinea where estado=1"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.DropDownList24.DataSource = tabla
            Me.DropDownList24.DataTextField = "nombreLinea"
            Me.DropDownList24.DataValueField = "idLinea"
            Me.DropDownList24.DataBind()
        End With
        Me.DropDownList24.Items.Insert(0, "Seleccione Linea")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Dim mensajeError As String = Nothing
        Dim huboError As String = "no"
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label20.Visible = False
        Me.Label21.Visible = False
        Me.Label24.Visible = False
        Me.Label25.Visible = False
        Me.Label26.Visible = False
        Me.Label27.Visible = False
        Me.Label29.Visible = False
        Me.Label30.Visible = False
        Me.Label31.Visible = False
        Me.Label1.Visible = False
        '
        If Me.DropDownList28.SelectedIndex = 0 Then
            Me.Label24.Visible = True
            Exit Sub
        Else
            Select Case Me.DropDownList28.SelectedIndex
                Case 1
                    If Me.DropDownList26.SelectedIndex = 0 Then
                        Me.Label25.Visible = True
                        Exit Sub
                    End If
                Case 2
                    If Me.DropDownList26.SelectedIndex = 0 Then
                        Me.Label25.Visible = True
                        Exit Sub
                    End If
                    '
                    If Me.DropDownList27.SelectedIndex = 0 Then
                        Me.Label26.Visible = True
                        Exit Sub
                    End If
                Case 3
                    If Me.DropDownList25.SelectedIndex = 0 Then
                        Me.Label20.Visible = True
                        Exit Sub
                    End If

            End Select
        End If
        '
        If Me.TextBox17.Text = "" Or Val(Me.TextBox17.Text) <= 0 Or Not IsNumeric(Me.TextBox17.Text) Then
            Me.Label27.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox19.Text = "" Or Val(Me.TextBox19.Text) < 0 Or Not IsNumeric(Me.TextBox19.Text) Then
            Me.Label31.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox1.Text = "" Then
            Me.Label17.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox2.Text Is Nothing Or Val(Me.TextBox2.Text) <= 0 Then
            Me.Label18.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox16.Text Is Nothing Or Val(Me.TextBox16.Text) <= 0 Then
            Me.Label21.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox18.Text = "" Then
            Me.Label30.Visible = True
            Exit Sub
        End If
        ' validamos si ha seleccionado un producto de la promocion
        Dim siSelecciono As String = validaSeleccion
        If siSelecciono = "no" Then
            Me.Label29.Visible = True
            Exit Sub
        End If
        grabar()
        mostrarVentana()
        cargarPromociones()
        nuevo()
    End Sub

    Function validaSeleccion() As String
        Dim haySeleccion As String = "no"
        Dim fila As GridViewRow
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                If c1.Checked = True Then
                    haySeleccion = "si"
                    Exit For
                End If
            End If
        Next
        Return haySeleccion
    End Function

    Sub grabar()
        Dim fila As GridViewRow
        Dim y As Integer
        Dim idpromocionTs As Integer = 0
        Dim sql As String
        Dim tabla As New DataTable
        Dim accion As Integer
        Dim id As Integer
        If Me.TextBox7.Text = "" Then
            accion = 1
            id = 0
        Else
            accion = 2
            id = Me.TextBox7.Text
        End If
        '
        Dim idEmpresa As Integer
        Dim idSucursal As Integer
        Dim idEvento As Integer
        If Me.DropDownList28.SelectedIndex > 0 Then
            Select Case Me.DropDownList28.SelectedIndex
                Case 1 ' solo pais
                    idEmpresa = Me.DropDownList26.SelectedValue
                    idSucursal = 0
                    idEvento = 0
                Case 2 ' sucursal
                    idEmpresa = Me.DropDownList26.SelectedValue
                    idSucursal = Me.DropDownList27.SelectedValue
                    idEvento = 0
                Case 3 'evento
                    sql = "select * from tbevento where idEvento=" & Me.DropDownList25.SelectedValue
                    With objOperacione
                        tabla = .DevuelveDato(sql)
                        If tabla.Rows.Count <> 0 Then
                            idEmpresa = tabla.Rows(0).Item("idEmpresa")
                            idSucursal = tabla.Rows(0).Item("idSucursal")
                            idEvento = tabla.Rows(0).Item("idEvento")
                        End If
                    End With
            End Select
        End If
        '
        With promociones
            .idpromocionts = id
            .fechaipromocionts = Me.TextBox14.Text
            .fechafpromocionts = Me.TextBox15.Text
            .idPais = idEmpresa
            .idSucursal = idSucursal
            .nProductosBaseTS = Me.TextBox17.Text
            .tipoPromocionTS = Me.DropDownList28.SelectedValue
            .idevento = idEvento
            .precioEspecialTs = "" 'Me.DropDownList29.SelectedValue
            .inicioPromocionTs = Me.DropDownList29.SelectedValue
            .idpaqueteTs = 0
            .nombrepromocionts = Me.TextBox1.Text.ToUpper
            .valorpromocionts = Me.TextBox2.Text
            .nprodpromocionts = Me.TextBox16.Text
            .estadopromocionts = Me.DropDownList24.SelectedValue
            .nunstspromocionts = Me.TextBox18.Text
            .numProductosObsequio = Me.TextBox19.Text
            .califpromocionts = Me.DropDownList30.SelectedValue
            .ciclopromocionts = Me.DropDownList1.SelectedValue
            tabla = .grabarPromocionTS(accion)
            If tabla.Rows.Count <> 0 Then
                idpromocionTs = tabla.Rows(0).Item("numero")
            End If
        End With
        'graba los productos de la promocion
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                If c1.Checked = True Then
                    With promociones
                        .idpromocionts = idpromocionTs
                        .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                        .grabarProductosPromocion()
                    End With
                End If
            End If
        Next
        ' actualiza los productos de las promociones
        If accion = 2 Then
            'eliminamos los registros actuales
            sql = "delete from TTProdPromo where idPromocionts=" & Me.TextBox7.Text
            With objOperacione
                .Accion(sql)
            End With
            '
            'graba los productos de la promocion
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    If c1.Checked = True Then
                        With promociones
                            .idpromocionts = Me.TextBox7.Text
                            .idProducto = Me.GridView3.Rows(y).Cells(1).Text
                            .grabarProductosPromocion()
                        End With
                    End If
                End If
            Next
        End If
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Producto Registrado En El Sistema...!');", True)
    End Sub

    Sub nuevo()
        cargarProductos()
        Me.CheckBox2.Text = "Seleccionar Todos"
        Me.Label23.Visible = False
        Me.Label22.Visible = False
        Me.Label28.Visible = False
        Me.Label29.Visible = False
        Me.Label30.Visible = False
        Me.Label31.Visible = False
        Me.DropDownList27.Visible = False
        Me.DropDownList26.Visible = False
        Me.DropDownList25.Visible = False
        '
        Me.DropDownList28.SelectedIndex = 0
        Me.ImageButton8.Visible = True
        '
        Me.TextBox1.Text = Nothing
        Me.TextBox2.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.TextBox16.Text = Nothing
        Me.TextBox17.Text = Nothing
        Me.TextBox18.Text = Nothing
        Me.TextBox19.Text = Nothing
        Me.TextBox14.Text = Now.Date.ToString("yyyy/MM/dd")
        Me.TextBox15.Text = Now.Date.ToString("yyyy/MM/dd")
        Me.DropDownList24.SelectedIndex = 0
        Me.TextBox1.Focus()
        '
        Me.Label17.Visible = False
        Me.Label18.Visible = False
        Me.Label20.Visible = False
        Me.Label21.Visible = False
        Me.Label24.Visible = False
        Me.Label25.Visible = False
        Me.Label26.Visible = False
        Me.Label27.Visible = False
        Me.Label31.Visible = False
        Me.Label1.Visible = False
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.TextBox14.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
        Me.TextBox15.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        mostrarDatosPromocion(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
    End Sub

    Sub mostrarDatosPromocion(ByVal idPromocion As Integer)
        Dim fila As GridViewRow
        Dim sql As String
        Dim tabla As New DataTable
        cargarProductos()
        sql = "select * from tbpromocionts where idPromocionts=" & idPromocion
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.TextBox7.Text = tabla.Rows(0).Item("idpromocionts")
                'Me.TextBox14.Text = tabla.Rows(0).Item("fechaipromocionts")
                'Me.TextBox15.Text = tabla.Rows(0).Item("fechafpromocionts")
                Me.TextBox17.Text = tabla.Rows(0).Item("nbasepromocionts")
                Me.TextBox1.Text = tabla.Rows(0).Item("nombrepromocionts")
                Me.TextBox2.Text = tabla.Rows(0).Item("valorpromocionts")
                Me.TextBox16.Text = tabla.Rows(0).Item("nprodpromocionts")
                Me.TextBox18.Text = tabla.Rows(0).Item("nunstspromocionts")
                Me.TextBox19.Text = tabla.Rows(0).Item("nprodobsequiopromosionts")
                Me.DropDownList30.SelectedValue = tabla.Rows(0).Item("califpromocionts")
                Me.DropDownList29.SelectedValue = tabla.Rows(0).Item("iniciopromocionts")

                '-----------------------------------------------------------
                'tipo de promocion
                Select Case tabla.Rows(0).Item("tipopromocionts")
                    Case "P"
                        Me.DropDownList28.SelectedIndex = 1
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idpais")
                    Case "S"
                        Me.DropDownList28.SelectedIndex = 2
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idpais")
                        cargarSucursales()
                        Me.DropDownList27.SelectedValue = tabla.Rows(0).Item("idSucursal")
                    Case "E"
                        Me.DropDownList28.SelectedIndex = 3
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idpais")
                        Me.DropDownList27.SelectedValue = tabla.Rows(0).Item("idSucursal")
                        Me.DropDownList25.SelectedValue = tabla.Rows(0).Item("idEvento")
                End Select
                ' pais
                If Me.DropDownList28.SelectedIndex > 0 Then
                    Select Case Me.DropDownList28.SelectedIndex
                        Case 1
                            Me.Label22.Visible = True
                            Me.DropDownList26.Visible = True
                            '
                            Me.Label23.Visible = False
                            Me.DropDownList27.Visible = False
                            '
                            Me.Label28.Visible = False
                            Me.DropDownList25.Visible = False
                        Case 2
                            Me.Label22.Visible = True
                            Me.DropDownList26.Visible = True
                            '
                            Me.Label23.Visible = True
                            Me.DropDownList27.Visible = True
                            '
                            Me.Label28.Visible = False
                            Me.DropDownList25.Visible = False

                        Case 3
                            Me.Label22.Visible = False
                            Me.DropDownList26.Visible = False
                            '
                            Me.Label23.Visible = False
                            Me.DropDownList27.Visible = False
                            '
                            Me.Label28.Visible = True
                            Me.DropDownList25.Visible = True

                    End Select
                Else
                    Me.Label22.Visible = False
                    Me.DropDownList26.Visible = False
                    '
                    Me.Label23.Visible = False
                    Me.DropDownList27.Visible = False
                    '
                    Me.Label28.Visible = False
                    Me.DropDownList25.Visible = False
                End If

                '------------------------
            End If
            Me.DropDownList24.SelectedValue = tabla.Rows(0).Item("estadopromocionts")
            'muestra los productos de la promocion
            With promociones
                .idpromocionts = Me.TextBox7.Text
                tabla = .obtenerProductosDeLaPromocion
                If tabla.Rows.Count <> 0 Then
                    Dim k As Integer
                    For k = 0 To tabla.Rows.Count - 1
                        For y = 0 To Me.GridView3.Rows.Count - 1
                            fila = Me.GridView3.Rows(y)
                            If fila.RowType = DataControlRowType.DataRow Then
                                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                                If tabla.Rows(k).Item("idProducto") = Me.GridView3.Rows(y).Cells(1).Text Then
                                    c1.Checked = True
                                End If
                            End If
                        Next
                    Next
                End If
            End With
        End With
    End Sub

    Protected Sub DropDownList26_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList26.SelectedIndexChanged
        Me.DropDownList27.DataSource = Nothing
        Me.DropDownList27.DataBind()
        If Me.DropDownList26.SelectedIndex > 0 Then
            cargarSucursales()
        Else
            Me.DropDownList27.DataSource = Nothing
            Me.DropDownList27.DataBind()
        End If
    End Sub

    Sub cargarSucursales()
        Dim sql As String
        sql = "select * from tbsucursal where idEmpresa=" & Me.DropDownList26.SelectedValue
        With objOperacione
            .cargarCombos(Me.DropDownList27, sql, "idSucursal", "nombreSucursal", "Seleccione La Sucursal")
        End With
    End Sub

    Protected Sub DropDownList28_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList28.SelectedIndexChanged
        Me.Label24.Visible = False
        Me.Label25.Visible = False
        Me.Label26.Visible = False
        Me.Label20.Visible = False
        '
        If Me.DropDownList28.SelectedIndex > 0 Then
            Select Case Me.DropDownList28.SelectedIndex
                Case 1
                    Me.Label22.Visible = True
                    Me.DropDownList26.Visible = True
                    '
                    Me.Label23.Visible = False
                    Me.DropDownList27.Visible = False
                    '
                    Me.Label28.Visible = False
                    Me.DropDownList25.Visible = False
                Case 2
                    Me.Label22.Visible = True
                    Me.DropDownList26.Visible = True
                    '
                    Me.Label23.Visible = True
                    Me.DropDownList27.Visible = True
                    '
                    Me.Label28.Visible = False
                    Me.DropDownList25.Visible = False

                Case 3
                    Me.Label22.Visible = False
                    Me.DropDownList26.Visible = False
                    '
                    Me.Label23.Visible = False
                    Me.DropDownList27.Visible = False
                    '
                    Me.Label28.Visible = True
                    Me.DropDownList25.Visible = True

            End Select
        Else
            Me.Label22.Visible = False
            Me.DropDownList26.Visible = False
            '
            Me.Label23.Visible = False
            Me.DropDownList27.Visible = False
            '
            Me.Label28.Visible = False
            Me.DropDownList25.Visible = False
        End If
    End Sub

    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim fila As GridViewRow
        If Me.CheckBox2.Checked = True Then
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    c1.Checked = True
                End If
            Next
            Me.CheckBox2.Text = "Quitar Selección"
        Else
            For y = 0 To Me.GridView3.Rows.Count - 1
                fila = Me.GridView3.Rows(y)
                If fila.RowType = DataControlRowType.DataRow Then
                    Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                    c1.Checked = False
                End If
            Next
            Me.CheckBox2.Text = "Seleccionar Todos"
        End If
        Me.GridView3.Focus()
    End Sub
End Class
