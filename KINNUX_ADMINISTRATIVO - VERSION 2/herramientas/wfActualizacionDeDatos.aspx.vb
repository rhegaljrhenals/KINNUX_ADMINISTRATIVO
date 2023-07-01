Imports System.Data

Partial Class Seguridad_wfActualizacionDeDatos
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    Dim pais As New clsPaise
    Dim afiliado As New ClsAfiliado

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
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
                sql = sql & " and af.codigoafiliado='" & Me.TextBox1.Text & "'"
            Case Is = 2
                sql = sql & " and af.identificacion='" & Me.TextBox1.Text & "'"
            Case Is = 3
                sql = sql & " and af.papellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 4
                sql = sql & " and af.sapellido like '%" & Me.TextBox1.Text & "%'"
            Case Is = 5
                sql = sql & " and af.pnombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 6
                sql = sql & " and af.snombre like '%" & Me.TextBox1.Text & "%'"
            Case Is = 7
                sql = sql & " and af.email1 like '%" & Me.TextBox1.Text & "%'"
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
        Else
            Me.Label2.Text = "Registros Encontrados: " & Me.GridView1.Rows.Count
        End If
        Me.TextBox1.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.MultiView1.ActiveViewIndex = 1
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        mostrarDatos(Me.GridView1.Rows(e.NewSelectedIndex).Cells(0).Text)

    End Sub

    Sub mostrarDatos(ByVal codigo As String)
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select * from afiliaciones where codigoafiliado="
    End Sub
End Class
