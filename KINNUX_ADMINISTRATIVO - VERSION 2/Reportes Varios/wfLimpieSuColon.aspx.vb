Imports System.Data
Imports System.IO

Partial Class Reportes_wfLimpieSuColon
    Inherits System.Web.UI.Page

    Dim calificacionCartagena As New clsTtCalifCartagena
    Dim paises As New clsPaise
    Dim operaciones As New clsOperacione

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            mostrarDatosAll()
            Me.TextBox1.Text = Now.Date.ToString("yyyy/MM/dd")
            Me.TextBox2.Text = Now.Date.ToString("yyyy/MM/dd")
            limpiarImgenes()
        End If
    End Sub

    Sub limpiarImgenes()
        Me.Image3.Visible = False
        Me.Image4.Visible = False
        Me.Image5.Visible = False
        Me.Image6.Visible = False
        Me.Image7.Visible = False
        Me.Image8.Visible = False
        Me.Image9.Visible = False
        Me.Image10.Visible = False
        Me.Image11.Visible = False
        Me.Image12.Visible = False
        Me.Image13.Visible = False
        Me.Image14.Visible = False
        Me.Image15.Visible = False
        Me.Image16.Visible = False
        Me.Image17.Visible = False
        Me.Image18.Visible = False
        Me.Image19.Visible = False
        Me.Image20.Visible = False
        Me.Image21.Visible = False
        Me.Image22.Visible = False
        Me.Image23.Visible = False


    End Sub

    Sub mostrarDatosAll()
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT * from vw_afiliadosLImpieSuColon order by id"
        With operaciones
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

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label4.Text = ""
        Me.GridView2.DataSource = Nothing
        Me.GridView2.DataBind()
        'Dim encontroDatos As String = mostrarDatos()
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        Dim sql As String
        Dim tabla As New DataTable
        If Me.CheckBox1.Checked = True Then
            sql = "SELECT * from vw_afiliadosLImpieSuColon order by id"
        Else
            sql = "SELECT * from vw_afiliadosLImpieSuColon where fecha between '" & Me.TextBox1.Text & "' and '" & Me.TextBox2.Text & "' order by id"
        End If
        '
        With operaciones
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

    
    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        'panelDatos.Visible = False
        If Me.GridView2.Rows.Count <> 0 Then
            ExportToExcel("Cancun2016.xls", Me.GridView2)
        Else

        End If

    End Sub

    Private Sub ExportToExcel(ByVal nameReport As String, ByVal wControl As GridView)
        'Me.GridView2.Columns(0).Visible = False
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

   
    Protected Sub GridView2_SelectedIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        Dim sql As String
        Dim tabla As New DataTable
        limpiarImgenes()
        sql = "select top 1 * from encuestaLimpieSuColon where idAfiliado=" & Me.GridView2.Rows(e.NewSelectedIndex).Cells(1).Text
        With operaciones
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                validaRespuesta(Me.Image3, tabla.Rows(0).Item("gastriti"))
                validaRespuesta(Me.Image4, tabla.Rows(0).Item("hemorroides"))
                validaRespuesta(Me.Image5, tabla.Rows(0).Item("reflujo"))
                validaRespuesta(Me.Image6, tabla.Rows(0).Item("acne"))
                validaRespuesta(Me.Image7, tabla.Rows(0).Item("acidez"))
                validaRespuesta(Me.Image8, tabla.Rows(0).Item("colitis"))
                validaRespuesta(Me.Image9, tabla.Rows(0).Item("diarrea"))
                validaRespuesta(Me.Image10, tabla.Rows(0).Item("estrenimiento"))
                validaRespuesta(Me.Image11, tabla.Rows(0).Item("cirritable"))
                validaRespuesta(Me.Image12, tabla.Rows(0).Item("alergias"))
                '
                validaRespuesta(Me.Image13, tabla.Rows(0).Item("cbiliar"))
                validaRespuesta(Me.Image14, tabla.Rows(0).Item("darticulares"))
                validaRespuesta(Me.Image15, tabla.Rows(0).Item("hepatitis"))
                validaRespuesta(Me.Image16, tabla.Rows(0).Item("sobrepeso"))
                validaRespuesta(Me.Image17, tabla.Rows(0).Item("ugastrica"))
                validaRespuesta(Me.Image18, tabla.Rows(0).Item("ccolon"))
                validaRespuesta(Me.Image19, tabla.Rows(0).Item("einflamado"))
                'validaRespuesta(Me.Image20, tabla.Rows(0).Item("estrenimiento"))' migraña
                validaRespuesta(Me.Image21, tabla.Rows(0).Item("hipertension"))
                validaRespuesta(Me.Image22, tabla.Rows(0).Item("diabetes"))
                validaRespuesta(Me.Image23, tabla.Rows(0).Item("maliento"))
            End If
        End With
    End Sub

    Sub validaRespuesta(ByVal imagen As Image, ByVal resp As String)
        imagen.Visible = False
        If resp = "si" Then
            imagen.Visible = True
            imagen.ImageUrl = "~/Imagenes/Yes_Check_Circle.svg.png"
        End If
    End Sub
End Class
