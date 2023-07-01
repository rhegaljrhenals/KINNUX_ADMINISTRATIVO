Imports System.Data

Partial Class Reportes_Varios_wfDetalleComisionIR
    Inherits System.Web.UI.Page

    Dim afiliados As New ClsAfiliado
    Dim comisionMesIR As New clsTTComisionMesIr
    Dim detalleComisionMes As New clsTTDetComisionMesIR


    Sub mostrarDatosAfiliados()
        Dim tabla As New DataTable
        With afiliados
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerAfiliadoPorCodigoAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.Label1.Text = "Distribuidor: (" & tabla.Rows(0).Item("codigoAfiliado") & ")" & tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre") & " " & tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
            Else
                Me.Label1.Text = ""
            End If
        End With
    End Sub

    Sub mostrarDatosNiveles()
        Dim tabla As New DataTable
        With comisionMesIR
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerComisionMesPorAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.TextBox1.Text = tabla.Rows(0).Item("valNivel2comisionmesir")
                Me.TextBox2.Text = tabla.Rows(0).Item("valNivel3comisionmesir")
                Me.TextBox3.Text = tabla.Rows(0).Item("valNivel4comisionmesir")
                Me.TextBox4.Text = tabla.Rows(0).Item("valNivel5comisionmesir")
                Me.TextBox5.Text = tabla.Rows(0).Item("valNivel6comisionmesir")
            Else
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
            End If
        End With
    End Sub

    Sub mostrardetalleComisionMesIR()
        Dim tabla As New DataTable
        With detalleComisionMes
            .codigoAfiliado = Request.QueryString("id")
            tabla = .obtenerDetalleComisionesIRporAfiliado
            If tabla.Rows.Count <> 0 Then
                Me.GridView1.DataSource = tabla
                Me.GridView1.DataBind()
            Else
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
            End If
        End With
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatosAfiliados()
            mostrarDatosNiveles()
            mostrardetalleComisionMesIR()
        End If
    End Sub
End Class
