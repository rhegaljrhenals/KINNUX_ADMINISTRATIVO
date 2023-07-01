Imports System.Data

Partial Class Seguridad_wfActualizacionDeDatos
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise
    Dim afiliado As New ClsAfiliado
    Dim pdf As New generadorPDF

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Panel3.Visible = False
        buscar()
    End Sub

    Sub buscar()
        Dim sql As String
        Dim opcion As Integer
        Dim tabla As New DataTable
        '
        If Me.RadioButton1.Checked = True Then
            opcion = 1
        Else
            If Me.RadioButton2.Checked = True Then
                opcion = 2
            Else
                If Me.RadioButton3.Checked = True Then
                    opcion = 3
                Else
                    If Me.RadioButton4.Checked = True Then
                        opcion = 4
                    Else
                        If Me.RadioButton5.Checked = True Then
                            opcion = 5
                        Else
                            If Me.RadioButton6.Checked = True Then
                                opcion = 6
                            Else
                                If Me.RadioButton7.Checked = True Then
                                    opcion = 7
                                Else
                                    If Me.RadioButton8.Checked = True Then
                                        opcion = 8
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '
        sql = "select " & _
        "af.id," & _
        "af.codigoafiliado," & _
        "af.identificacion," & _
        "af.papellido + ' ' + af.sapellido as apellidos," & _
        "af.pnombre + ' ' + af.snombre as nombres," & _
        "af.direccion," & _
        "af.telefono," & _
        "af.celular," & _
        "af.email1," & _
        "pais.NombrePais," & _
        "fechaAfiliacion" & _
        " from afiliaciones af,TBpais pais" & _
        " where af.codigoPais = pais.CodigoPais"
        Select Case opcion
            Case Is = 1
                sql = sql & " and af.codigoafiliado='" & Me.TextBox11.Text & "'"
            Case Is = 2
                sql = sql & " and af.identificacion='" & Me.TextBox11.Text & "'"
            Case Is = 3
                sql = sql & " and af.papellido like '%" & Me.TextBox11.Text & "%'"
            Case Is = 4
                sql = sql & " and af.sapellido like '%" & Me.TextBox11.Text & "%'"
            Case Is = 5
                sql = sql & " and af.pnombre like '%" & Me.TextBox11.Text & "%'"
            Case Is = 6
                sql = sql & " and af.snombre like '%" & Me.TextBox11.Text & "%'"
            Case Is = 7
                sql = sql & " and af.email1 like '%" & Me.TextBox11.Text & "%'"
            Case Is = 8
                sql = sql & " and pais.codigoPais='" & Me.DropDownList1.SelectedValue & "'"
        End Select
        sql = sql & " order by af.codigoAfiliado"
        With objOperacione
            tabla = .DevuelveDato(sql)
            Me.GridView1.DataSource = tabla
            Me.GridView1.DataBind()
        End With
        If Me.GridView1.Rows.Count = 0 Then
            Me.Label2.Text = "No hay registros Encontrados...!"
            Me.Panel3.Visible = False
        Else
            Me.Label2.Text = "Registros Encontrados: " & Me.GridView1.Rows.Count
            Me.Panel3.Visible = True
        End If
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 1
            Me.Panel3.Visible = False
            Me.RadioButton1.Checked = True
            Me.TextBox11.Focus()
            cargarPais()
            cargarAno()
            Me.HyperLink1.Visible = False
        End If
    End Sub

    Sub cargarPais()
        With objOperacione
            .cargarCombos(Me.DropDownList6, "select * from tbpais", "codigopais", "nombrepais", "Seleccione El Pais")
        End With
    End Sub

    Sub cargarAno()
        Dim y As Integer
        For y = Now.Year To 1900 Step -1
            Me.DropDownList2.Items.Add(y)
            Me.DropDownList2.DataValueField = y
        Next
        Me.DropDownList2.Items.Insert(0, "Año")
        Me.DropDownList2.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Me.TextBox1.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.Label4.Text = Me.GridView1.Rows(e.NewSelectedIndex).Cells(2).Text
        Me.HyperLink1.Visible = True
        mostrarDatosAfiliados()
    End Sub

    Sub mostrarDatosAfiliados()
        Dim tabla As New DataTable
        With afiliado
            .codigoAfiliado = Me.TextBox1.Text
            tabla = .datosParaActualizar
            If tabla.Rows.Count <> 0 Then
                Me.TextBox2.Text = tabla.Rows(0).Item("identificacion")
                Me.TextBox12.Text = tabla.Rows(0).Item("id")
                Me.TextBox3.Text = tabla.Rows(0).Item("pnombre")
                Me.TextBox4.Text = tabla.Rows(0).Item("snombre")
                Me.TextBox5.Text = tabla.Rows(0).Item("papellido")
                Me.TextBox6.Text = tabla.Rows(0).Item("sapellido")
                Me.TextBox7.Text = tabla.Rows(0).Item("direccion")
                Me.TextBox8.Text = tabla.Rows(0).Item("telefono")
                Me.TextBox9.Text = tabla.Rows(0).Item("celular")
                Me.TextBox10.Text = tabla.Rows(0).Item("email1")
                '
                Me.DropDownList2.SelectedValue = tabla.Rows(0).Item("ano")
                Me.DropDownList3.SelectedIndex = tabla.Rows(0).Item("mes")
                Me.DropDownList4.SelectedIndex = tabla.Rows(0).Item("dia")
                Me.DropDownList5.SelectedValue = tabla.Rows(0).Item("estado")
                Me.DropDownList6.SelectedValue = tabla.Rows(0).Item("codigoPais")
                cargarDpto()
                Me.DropDownList7.SelectedValue = tabla.Rows(0).Item("codigodpto")
                cargarCiudad()
                Me.DropDownList8.SelectedValue = tabla.Rows(0).Item("codigociudad")

                '
                Me.MultiView1.ActiveViewIndex = 0
                '
                '----------------------------------------------------------------------------
                ' generacion pdf
                Dim nombre As String
                With pdf
                    nombre = .datosDelAfiliado(Me.Label4.Text)
                End With
                '----------------------------------------------------------------------------
                Me.HyperLink1.NavigateUrl = "http://knxplus.com/pdfmillas/" & nombre
            Else
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
            End If
        End With
    End Sub

    Sub cargarCiudad()
        Dim sql As String
        If Me.DropDownList6.SelectedIndex > 0 And Me.DropDownList7.SelectedIndex > 0 Then
            sql = "select * from tbmunicipio where idpais=" & Me.DropDownList6.SelectedValue & " and idDpto=" & Me.DropDownList7.SelectedValue
            With objOperacione
                .cargarCombos(Me.DropDownList8, sql, "codigomunicipio", "nombremunicipio", "Seleccione Ciudad")
            End With
        End If
    End Sub

    Sub cargarDpto()
        Dim sql As String
        If Me.DropDownList6.SelectedIndex > 0 Then
            sql = "select * from tbdpto where idpais=" & Me.DropDownList6.SelectedValue
            With objOperacione
                .cargarCombos(Me.DropDownList7, sql, "codigodpto", "nombredpto", "Seleccione Dpto")
            End With
        End If
    End Sub

    

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Me.MultiView1.ActiveViewIndex = 1
        Me.Panel3.Visible = False
        Me.GridView1.DataSource = Nothing
        Me.GridView1.DataBind()
        '
        Me.Label2.Text = ""
        Me.HyperLink1.Visible = False
        '-------------------------------------------------
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Label3.Text = ""
        If Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox5.Text = "" Or Me.TextBox7.Text = "" Or Me.TextBox8.Text = "" Or Me.TextBox10.Text = "" Then
            Me.Label3.Text = "Diligencie todos los campos obligatorios...!"
            Exit Sub
        End If
        If Me.DropDownList6.SelectedIndex = 0 Or Me.DropDownList6.SelectedIndex = -1 Then
            Me.Label3.Text = "Seleccione el pais...!"
            Exit Sub
        End If
        '
        If Me.DropDownList7.SelectedIndex = 0 Or Me.DropDownList7.SelectedIndex = -1 Then
            Me.Label3.Text = "Seleccione el departamento...!"
            Exit Sub
        End If
        '
        If Me.DropDownList8.SelectedIndex = 0 Or Me.DropDownList8.SelectedIndex = -1 Then
            Me.Label3.Text = "Seleccione la ciudad...!"
            Exit Sub
        End If
        '
        actualizar()
        '-------------------------------------------------
        Me.MultiView1.ActiveViewIndex = 1
        Me.GridView1.DataSource = Nothing
        Me.GridView1.DataBind()
        '
        Me.Label2.Text = ""
        '-------------------------------------------------
        mostrarVentana()
    End Sub

    Sub mostrarVentana()
        ScriptManager.RegisterStartupScript(Me, [GetType](), "showalert", "alert('Datos Actualizados Correctamente...!');", True)
    End Sub

    Sub actualizar()
        With afiliado
            .codigoAfiliado = Me.TextBox1.Text
            .identificacion = Me.TextBox2.Text
            .papellidoAfiliado = Me.TextBox5.Text.ToUpper
            .sapellidoAfiliado = Me.TextBox6.Text.ToUpper
            .pnombreAfiliado = Me.TextBox3.Text.ToUpper
            .snombreAfiliado = Me.TextBox4.Text.ToUpper
            .telefono = Me.TextBox8.Text
            .celular = Me.TextBox9.Text
            .email1 = Me.TextBox10.Text.ToLower
            .fechaNacido = Me.DropDownList2.SelectedValue & "/" & Me.DropDownList3.SelectedValue & "/" & Me.DropDownList4.SelectedValue 'fechaNacido
            .pais = Me.DropDownList6.SelectedValue '0 'Me.TextBox12.Text
            .departamento = Me.DropDownList7.SelectedValue '0 'e.TextBox14.Text
            .ciudad = Me.DropDownList8.SelectedValue ' 'Me.TextBox13.Text
            .direccion = Me.TextBox7.Text.ToUpper
            .estadoAfiliado = Me.DropDownList5.SelectedValue
            .actualizaDatosAfiliados()
        End With
    End Sub
End Class
