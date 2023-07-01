Imports System.IO
Imports System.Data

Partial Class Reportes_Varios_wfConsultaDistribuidor
    Inherits System.Web.UI.Page

    Dim objOperacione As New clsOperacione
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            muestraDatos()
            Me.ImageButton10.Visible = False
            Me.Panel4.Visible = False
        End If
        'If (Session.Item("idUsuario") Is Nothing Or Session.Item("idUsuario") = 0) Then
        '    Response.Redirect("~/Default.aspx")
        'End If
    End Sub

    Sub muestraDatos()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTCalifEmpresario.vpcalifEmpresario," & _
        "TTCalifEmpresario.febcalifEmpresario," & _
        "TTCalifEmpresario.marzocalifEmpresario," & _
        "TTCalifEmpresario.abrilcalifEmpresario," & _
        "TTCalifEmpresario.mayocalifEmpresario," & _
        "TTCalifEmpresario.juniocalifEmpresario," & _
        "TTCalifEmpresario.vgafilcalifEmpresario," & _
        "TTCalifEmpresario.vggencalifEmpresario," & _
        "TTCalifEmpresario.vg1califEmpresario," & _
        "TTCalifEmpresario.nuevocalifEmpresario," & _
        "TTCalifEmpresario.calificadocalifEmpresario," & _
        "TTCalifEmpresario.cuposEmpresario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCalifEmpresario ON dbo.Afiliaciones.codigoAfiliado = TTCalifEmpresario.codigoafiliado INNER JOIN" & _
        " dbo.TBEmpresa ON dbo.Afiliaciones.codigoPais = dbo.TBEmpresa.idPais" & _
        " where dbo.Afiliaciones.codigoAfiliado not in('571','572','573','574','575','576','577')" & _
        " order by TTCalifEmpresario.vggencalifEmpresario desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.GridView2.DataSource = tabla
                Me.GridView2.DataBind()
            Else
                Me.GridView2.DataSource = Nothing
                Me.GridView2.DataBind()
            End If
        End With
    End Sub

    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Me.Panel4.Visible = False
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido nombres, " & _
        "TTCalifEmpresario.febcalifEmpresario + TTCalifEmpresario.marzocalifEmpresario + TTCalifEmpresario.abrilcalifEmpresario + TTCalifEmpresario.mayocalifEmpresario + TTCalifEmpresario.juniocalifEmpresario as total, " & _
        "TTCalifEmpresario.vg1califEmpresario," & _
        "TTCalifEmpresario.vggencalifEmpresario," & _
        "TTCalifEmpresario.calificadocalifEmpresario," & _
        "TTCalifEmpresario.vgAfilcalifEmpresario," & _
        "TTCalifEmpresario.nuevocalifEmpresario," & _
        "TTCalifEmpresario.cuposEmpresario" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCalifEmpresario ON dbo.Afiliaciones.codigoAfiliado = TTCalifEmpresario.codigoafiliado" & _
        " where dbo.Afiliaciones.codigopatrocinador = " & Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                Me.Panel4.Visible = True
                Me.GridView3.DataSource = tabla
                Me.GridView3.DataBind()
            Else
                Me.GridView3.DataSource = Nothing
                Me.GridView3.DataBind()
            End If
        End With

    End Sub
End Class
