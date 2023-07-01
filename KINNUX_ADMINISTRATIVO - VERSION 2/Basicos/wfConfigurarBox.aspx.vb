Imports System.Data
Imports System.IO

Partial Class Basicos_wfConfigurarBox
    Inherits System.Web.UI.Page

    Dim pais As New clsPaise
    Dim linea As New clsLineaArticulo
    Dim objOperacione As New clsOperacione
    Dim producto As New clsProducto
    Dim promociones As New clsPromocion
    Dim box As New clsTTBox


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarEventos()
            'cargarPromociones()
            cargarPais()
            cargarEmpresa()
            'cargarLineas()
            nuevo()
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub cargarEmpresa()
        With objOperacione
            .cargarCombos(Me.DropDownList35, "select * from tbempresa", "idempresa", "nombreempresa", "Todas Las Empresas")
        End With
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
        Me.Label34.Visible = False

        Me.Label36.Visible = False
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
        If Me.TextBox17.Text = "" Or Val(Me.TextBox17.Text) < 0 Or Not IsNumeric(Me.TextBox17.Text) Then
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
        If Me.TextBox21.Text Is Nothing Or Val(Me.TextBox21.Text) <= 0 Then
            Me.Label32.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox16.Text Is Nothing Or Val(Me.TextBox16.Text) < 0 Then
            Me.Label21.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox18.Text = "" Then
            Me.Label30.Visible = True
            Exit Sub
        End If
        '
        If Me.TextBox22.Text = "" Then
            Me.Label33.Visible = True
            Exit Sub
        End If
        ' activa millas
        If Me.DropDownList33.SelectedIndex = 0 Then
            If Me.TextBox23.Text = "" Or Me.TextBox23.Text = "0" Then
                Me.Label34.Visible = True
                Exit Sub
            End If
        End If
        ' valida configuracion paquete
        If Me.DropDownList29.SelectedIndex = 1 And Me.DropDownList32.SelectedIndex = 1 And Me.DropDownList31.SelectedIndex = 1 And Me.DropDownList34.SelectedIndex = 1 And Me.DropDownList37.SelectedIndex = 1 Then
            Me.Label36.Visible = True
            Exit Sub
        End If
        ' validamos si ha seleccionado un producto de la promocion
        Dim siSelecciono As String = validaSeleccion()
        If siSelecciono = "no" Then
            Me.Label29.Visible = True
            Exit Sub
        Else
            ' valida si seleccionó, debe de ingresar la cantidad
            If Me.DropDownList36.SelectedIndex = 0 Then
                Dim ingresoCantidad As String = validaIngresoCantidad()
                If ingresoCantidad = "no" Then
                    Me.Label29.Visible = True
                    Exit Sub
                End If
            End If
            
        End If
        ' token
        If Me.TextBox25.Text = "" Then
            Me.TextBox25.Text = "0"
        End If
        grabar()
        mostrarVentana()
        'cargarPromociones()
        nuevo()
    End Sub

    Function validaIngresoCantidad() As String
        Dim ingresoCantidad As String = "si"
        Dim fila As GridViewRow
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
                If c1.Checked = True Then
                    If cantidad.Text = "0" Or cantidad.Text = "" Then
                        ingresoCantidad = "no"
                        Exit For
                    End If
                End If
            End If
        Next
        Return ingresoCantidad
    End Function

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
        Dim idBox As Integer
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
        ' es paquete de promocion
        Dim esPaqueteDePromocion As String = ""
        Dim paqueteBox As String = ""
        If Me.CheckBox3.Checked = True Then
            esPaqueteDePromocion = "s"
            paqueteBox = "pr"
        Else
            esPaqueteDePromocion = "n"
            paqueteBox = "pa"
        End If
        '
        With box
            .idBox = id
            .fechaIBox = Me.TextBox14.Text
            .fechaFBox = Me.TextBox15.Text
            .idPais = idEmpresa
            .idSucursal = idSucursal
            .baseBox = Me.TextBox17.Text
            .tipoBox = Me.DropDownList28.SelectedValue
            .idEvento = idEvento
            .referenciaBox = Me.TextBox20.Text
            '.precioEspecialTs = "" 'Me.DropDownList29.SelectedValue
            .inicioBox = Me.DropDownList29.SelectedValue
            .paqueteBox = paqueteBox
            .nombreBox = Me.TextBox1.Text.ToUpper
            .valorMlBox = Me.TextBox2.Text
            .promoBox = Me.TextBox16.Text
            .estadoBox = Me.DropDownList24.SelectedValue
            .puntosBox = Me.TextBox18.Text
            .obsBox = Me.TextBox19.Text
            .valorUsdBox = Me.TextBox21.Text
            .numCiclosBox = Me.TextBox22.Text
            .upgradeBox = Me.DropDownList32.SelectedValue
            .inicioExpBox = Me.DropDownList31.SelectedValue
            '.califpromocionts = Me.DropDownList30.SelectedValue
            '.ciclopromocionts = Me.DropDownList1.SelectedValue
            .activamillasbox = Me.DropDownList33.SelectedValue
            .periodoacivosbox = IIf(Me.DropDownList33.SelectedIndex = 0, Me.TextBox23.Text, "0")
            .acumulaMillasBox = Me.DropDownList30.SelectedValue
            .recompraBox = If(Me.DropDownList34.SelectedIndex = 0, "s", "n") 'Me.DropDownList34.SelectedValue
            .paqueteControlado = If(Me.DropDownList36.SelectedIndex = 0, "S", "N") 'Me.DropDownList34.SelectedValue
            .inicioPaqBox = If(Me.DropDownList37.SelectedIndex = 0, "S", "N") 'Me.DropDownList34.SelectedValue
            .tokenBox = Me.TextBox25.Text
            '
            idBox = .grabar(accion)
            If tabla.Rows.Count <> 0 Then
                idBox = tabla.Rows(0).Item("numero")
            End If
        End With
        ' obtengo el id del box
        Dim idNuevoBox As Integer
        If Me.TextBox7.Text = "" Then
            idNuevoBox = idBox
        Else
            idNuevoBox = Me.TextBox7.Text
        End If
        'eliminamos los registros actuales
        sql = "delete from TBproductobox where idbox=" & idNuevoBox
        With objOperacione
            .Accion(sql)
        End With

        'graba los productos de la promocion
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
                '
                If c1.Checked = True Then
                    sql = "exec sp_TBproductobox " & _
                    "@idbox='" & idNuevoBox & "'," & _
                    "@idproducto='" & Me.GridView3.Rows(y).Cells(1).Text & "'," & _
                    "@cantidad='" & cantidad.Text & "'"
                    With objOperacione
                        .Accion(sql)
                    End With
                End If
            End If
        Next
        ' actualiza los productos de las promociones
        'If accion = 2 Then
        '    'eliminamos los registros actuales
        '    sql = "delete from TBproductobox where idbox=" & Me.TextBox7.Text
        '    With objOperacione
        '        .Accion(sql)
        '    End With
        '    '
        '    'graba los productos de la promocion
        '    For y = 0 To Me.GridView3.Rows.Count - 1
        '        fila = Me.GridView3.Rows(y)
        '        If fila.RowType = DataControlRowType.DataRow Then
        '            Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
        '            Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
        '            If c1.Checked = True Then
        '                sql = "exec sp_TBproductobox " & _
        '                "@idbox='" & id & "'," & _
        '                "@idproducto='" & Me.GridView3.Rows(y).Cells(1).Text & "'," & _
        '                "@cantidad='" & cantidad.Text & "'"
        '                With objOperacione
        '                    .Accion(sql)
        '                End With
        '            End If
        '        End If
        '    Next
        'End If
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Producto Registrado En El Sistema...!');", True)
    End Sub

    Sub nuevo()
        Me.CheckBox3.Visible = True
        Me.ImageButton8.Visible = True
        Me.ImageButton14.Visible = False
        cargarProductos()
        Me.CheckBox3.Checked = False
        Me.CheckBox2.Text = "Seleccionar Todos"
        Me.Label23.Visible = False
        Me.Label22.Visible = False
        Me.Label28.Visible = False
        Me.Label29.Visible = False
        Me.Label30.Visible = False
        Me.Label31.Visible = False
        Me.Label32.Visible = False
        Me.Label34.Visible = False
        Me.Label36.Visible = False
        Me.DropDownList27.Visible = False
        Me.DropDownList26.Visible = False
        Me.DropDownList25.Visible = False
        '
        Me.DropDownList28.SelectedIndex = 0
        Me.DropDownList29.SelectedIndex = 1
        Me.DropDownList30.SelectedIndex = 1
        Me.DropDownList31.SelectedIndex = 1
        Me.DropDownList32.SelectedIndex = 1
        Me.DropDownList34.SelectedIndex = 1
        Me.DropDownList36.SelectedIndex = 1
        Me.DropDownList37.SelectedIndex = 1

        '
        Me.DropDownList33.SelectedIndex = 1
        'Me.Panel3.Visible = False
        Me.Label37.Visible = False
        Me.TextBox23.Visible = False
        '
        Me.ImageButton8.Visible = True
        '
        Me.TextBox1.Text = Nothing
        Me.TextBox2.Text = Nothing
        Me.TextBox7.Text = Nothing
        Me.TextBox16.Text = Nothing
        Me.TextBox17.Text = Nothing
        Me.TextBox18.Text = Nothing
        Me.TextBox19.Text = Nothing
        Me.TextBox21.Text = Nothing
        Me.TextBox20.Text = Nothing
        Me.TextBox22.Text = "0"
        '
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
        Me.Label33.Visible = False
        'Me.Label1.Visible = False
        Me.MultiView1.ActiveViewIndex = 0
        Me.RadioButton3.Checked = True
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        nuevo()
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        nuevo()
        Me.TextBox14.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(4).Text
        Me.TextBox15.Text = Me.GridView2.Rows(e.NewSelectedIndex).Cells(5).Text
        mostrarDatosPromocion(Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text)
        Me.MultiView1.ActiveViewIndex = 0
        'calcular()
    End Sub

    Sub mostrarDatosPromocion(ByVal idPromocion As Integer)
        Dim fila As GridViewRow
        Dim sql As String
        Dim tabla As New DataTable
        cargarProductos()
        sql = "select * from vw_ttbox where idbox=" & idPromocion
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.CheckBox3.Visible = True
                Me.ImageButton8.Visible = True
                Me.TextBox7.Text = tabla.Rows(0).Item("idbox")
                '
                Me.TextBox14.Text = CDate(tabla.Rows(0).Item("fechaibox")).ToString("yyyy/MM/dd")
                Me.TextBox15.Text = CDate(tabla.Rows(0).Item("fechafbox")).ToString("yyyy/MM/dd")
                '
                Me.TextBox17.Text = tabla.Rows(0).Item("basebox")
                Me.TextBox1.Text = tabla.Rows(0).Item("nombrebox")
                Me.TextBox2.Text = tabla.Rows(0).Item("valormlbox")
                Me.TextBox16.Text = tabla.Rows(0).Item("promobox")
                Me.TextBox18.Text = tabla.Rows(0).Item("puntosbox")
                Me.TextBox19.Text = tabla.Rows(0).Item("obsqbox")
                Me.TextBox20.Text = tabla.Rows(0).Item("referenciabox")
                Me.TextBox21.Text = tabla.Rows(0).Item("valorusdbox")
                Me.TextBox22.Text = tabla.Rows(0).Item("numciclosbox")
                Me.TextBox23.Text = tabla.Rows(0).Item("periodoacivosbox")
                Me.TextBox25.Text = tabla.Rows(0).Item("tokenbox")
                '
                Me.DropDownList32.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("upgdradebox"))
                Me.DropDownList31.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("inicioexpbox"))
                Me.DropDownList33.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("activamillasbox"))
                Me.DropDownList29.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("iniciobox"))
                Me.DropDownList34.SelectedValue = tabla.Rows(0).Item("recomprabox")
                Me.DropDownList30.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("acumulaMillasbox"))
                Me.DropDownList36.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("controlbox"))
                Me.DropDownList37.SelectedValue = Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("inicioPaqbox"))
                ' activa millas
                If Me.DropDownList33.SelectedIndex = 0 Then
                    Me.Label37.Visible = True
                    Me.TextBox23.Visible = True
                Else
                    Me.Label37.Visible = False
                    Me.TextBox23.Visible = False
                End If
                '-----------------------------------------------------------
                ' es paquete de promocion
                Me.CheckBox3.Checked = False
                If Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("paquetebox")) = "pa" Then
                    Me.CheckBox3.Checked = False
                Else
                    Me.CheckBox3.Checked = True
                End If
                '
                Dim tipo As String = tabla.Rows(0).Item("tipobox")
                'tipo de promocion
                Select Case Microsoft.VisualBasic.RTrim(tabla.Rows(0).Item("tipobox"))
                    Case Is = "P"
                        Me.DropDownList28.SelectedIndex = 1
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idempresa")
                    Case Is = "S"
                        Me.DropDownList28.SelectedIndex = 2
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idempresa")
                        cargarSucursales()
                        Me.DropDownList27.SelectedValue = tabla.Rows(0).Item("idSucursal")
                    Case Is = "E"
                        Me.DropDownList28.SelectedIndex = 3
                        Me.DropDownList26.SelectedValue = tabla.Rows(0).Item("idempresa")
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
            Me.DropDownList24.SelectedValue = tabla.Rows(0).Item("estadobox")
            'muestra los productos de la promocion
            With box
                .idBox = Me.TextBox7.Text
                tabla = .obtenerProductosDeLaPromocion
                If tabla.Rows.Count <> 0 Then
                    Dim k As Integer
                    For k = 0 To tabla.Rows.Count - 1
                        For y = 0 To Me.GridView3.Rows.Count - 1
                            fila = Me.GridView3.Rows(y)
                            If fila.RowType = DataControlRowType.DataRow Then
                                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
                                If tabla.Rows(k).Item("idProducto") = Me.GridView3.Rows(y).Cells(1).Text Then
                                    c1.Checked = True
                                    cantidad.Text = tabla.Rows(k).Item("cantProductoBox")
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

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.ImageButton8.Visible = False
        Me.CheckBox3.Visible = False
        If Me.GridView2.Rows.Count <> 0 Then
            Me.ImageButton14.Visible = True
        Else
            Me.ImageButton14.Visible = False
        End If
    End Sub

    Sub mostrarDatosBox()
        Dim tabla As New DataTable
        With box
            tabla = .obtenerBox
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub DropDownList33_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList33.SelectedIndexChanged
        If Me.DropDownList33.SelectedIndex = 0 Then
            Me.Label37.Visible = True
            Me.TextBox23.Visible = True
        Else
            Me.Label37.Visible = False
            Me.TextBox23.Visible = False
        End If
        Me.TextBox23.Focus()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim idEmpresa As Integer = 0
        Dim opcion As Integer = 0
        If Me.DropDownList35.SelectedIndex = 0 Then
            idEmpresa = 0
        Else
            idEmpresa = Me.DropDownList35.SelectedValue
        End If
        '
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton2.Checked = True Then
                opcion = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    opcion = 3
                End If
            End If
        End If
        mostrarDatosBoxPorId(idEmpresa, opcion)
    End Sub

    Sub mostrarDatosBoxPorId(ByVal idempresa As Integer, ByVal opcion As Integer)
        Me.ImageButton14.Visible = False
        Dim tabla As New DataTable
        With box
            tabla = .obtenerBoxPorId(idempresa, opcion)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
                Me.Label35.Text = Me.GridView2.Rows.Count & " Registros Encontrados...!"
                Me.ImageButton14.Visible = True
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
                Me.Label35.Text = "0 Registros Encontrados...!"
                Me.ImageButton14.Visible = False
            End If
        End With
    End Sub

    Protected Sub ImageButton14_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton14.Click
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("configuracionbox.xls", Me.GridView2)
        End If
    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        Me.GridView2.Columns(0).Visible = False
        Me.GridView2.Columns(1).Visible = False
        Dim responsePage As HttpResponse = Response
        Dim sw As New StringWriter()
        Dim htw As New HtmlTextWriter(sw)
        Dim pageToRender As New Page()
        Dim form As New HtmlForm()
        form.Controls.Add(wControl)
        pageToRender.Controls.Add(form)
        responsePage.Clear()
        responsePage.Buffer = True
        responsePage.ContentType = "application/vnd.ms-excel"
        responsePage.AddHeader("Content-Disposition", "attachment;filename=" & nameReport)
        responsePage.Charset = "UTF-8"
        responsePage.ContentEncoding = Encoding.Default
        pageToRender.RenderControl(htw)
        responsePage.Write(sw.ToString())
        responsePage.End()
    End Sub

    Protected Sub DropDownList29_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList29.SelectedIndexChanged
        If Me.DropDownList29.SelectedIndex = 0 Then
            Me.DropDownList32.SelectedIndex = 1
            Me.DropDownList31.SelectedIndex = 1
            Me.DropDownList34.SelectedIndex = 1
            Me.DropDownList37.SelectedIndex = 1
        End If
    End Sub

    Protected Sub DropDownList32_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList32.SelectedIndexChanged
        If Me.DropDownList32.SelectedIndex = 0 Then
            Me.DropDownList29.SelectedIndex = 1
            Me.DropDownList31.SelectedIndex = 1
            Me.DropDownList34.SelectedIndex = 1
            Me.DropDownList37.SelectedIndex = 1
        End If

    End Sub

    Protected Sub DropDownList31_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList31.SelectedIndexChanged
        If Me.DropDownList31.SelectedIndex = 0 Then
            Me.DropDownList32.SelectedIndex = 1
            Me.DropDownList29.SelectedIndex = 1
            Me.DropDownList34.SelectedIndex = 1
            Me.DropDownList37.SelectedIndex = 1
        End If

    End Sub

    Protected Sub DropDownList34_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList34.SelectedIndexChanged
        If Me.DropDownList34.SelectedIndex = 0 Then
            Me.DropDownList32.SelectedIndex = 1
            Me.DropDownList31.SelectedIndex = 1
            Me.DropDownList29.SelectedIndex = 1
            Me.DropDownList37.SelectedIndex = 1
        End If

    End Sub

    Protected Sub DropDownList37_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList37.SelectedIndexChanged
        If Me.DropDownList37.SelectedIndex = 0 Then
            Me.DropDownList32.SelectedIndex = 1
            Me.DropDownList31.SelectedIndex = 1
            Me.DropDownList29.SelectedIndex = 1
            Me.DropDownList34.SelectedIndex = 1
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcular()
    End Sub

    Sub calcular()
        Dim fila As GridViewRow
        Dim sumaCantidad As Double = 0
        Dim sumaToken As Double = 0
        Dim total As Double
        '
        For y = 0 To Me.GridView3.Rows.Count - 1
            fila = Me.GridView3.Rows(y)
            If fila.RowType = DataControlRowType.DataRow Then
                Dim c1 As CheckBox = CType(Me.GridView3.Rows(y).FindControl("CheckBox1"), CheckBox)
                Dim cantidad As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
                'Dim token As TextBox = CType(Me.GridView3.Rows(y).FindControl("TextBox24"), TextBox)
                '
                If c1.Checked = True And cantidad.Text <> "" Then
                    total = cantidad.Text * CDbl(Me.GridView3.Rows(y).Cells(4).Text)
                    sumaCantidad += CDbl(cantidad.Text)
                    sumaToken += total
                End If
            End If
        Next
        '
        Me.Label1.Text = FormatNumber(sumaCantidad, 0)
        Me.Label2.Text = FormatNumber(sumaToken, 0)
        Me.TextBox25.Text = sumaToken
    End Sub
End Class
