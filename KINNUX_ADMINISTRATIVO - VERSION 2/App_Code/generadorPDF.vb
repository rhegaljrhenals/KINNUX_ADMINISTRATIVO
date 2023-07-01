Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO.FileStream
Imports System.Diagnostics

Public Class generadorPDF

    Private _idProgramacion As Integer
    Dim objOperacione As New clsOperacione
    Dim afiliado As New ClsAfiliado


    Public Property idProgramacion As Integer
        Get
            Return _idProgramacion
        End Get
        Set(value As Integer)
            _idProgramacion = value
        End Set
    End Property

    Function obtieneRutaParaGrabarPDF() As String
        Dim sql As String
        Dim tabla As New DataTable
        Dim ruta As String = ""
        sql = "select valor from tbconfiguracion where descripcion='pdfmillas'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                ruta = tabla.Rows(0).Item("valor")
            End If
        End With
        Return ruta
    End Function

    Function obtieneRutaParaMostrarImagen() As String
        Dim sql As String
        Dim tabla As New DataTable
        Dim ruta As String = ""
        sql = "select valor from tbconfiguracion where descripcion='pdfmillaslogo'"
        With objOperacione
            tabla = .DevuelveDato(sql)
            If tabla.Rows.Count <> 0 Then
                ruta = tabla.Rows(0).Item("valor")
            End If
        End With
        Return ruta
    End Function

    Function datosDelAfiliado(ByVal codigo As Integer) As String
        Dim mes As String = ""
        Dim nombreAfiliado, identificacion, apellidos, rango, direccion, telefono, celular, whatsapp, email, pais, dpto, ciudad, estado, fechanac, Dia, ano, id, tipoAfiliado As String
        Dim ultimaFechaActualizacion As String
        Dim diaua, anoua, mesua As String

        Dim codigoAfiliado As String = ""
        '
        Dim tabla As New DataTable
        ' datos del afiliado
        With afiliado
            .codigoAfiliado = codigo
            tabla = .obtenerDatosAfiliado
            If tabla.Rows.Count <> 0 Then
                nombreAfiliado = tabla.Rows(0).Item("pnombre") & " " & tabla.Rows(0).Item("snombre")
                apellidos = tabla.Rows(0).Item("papellido") & " " & tabla.Rows(0).Item("sapellido")
                codigoAfiliado = tabla.Rows(0).Item("codigoafiliado")
                identificacion = tabla.Rows(0).Item("identificacion")
                rango = tabla.Rows(0).Item("nombrerango")
                direccion = tabla.Rows(0).Item("direccion")
                telefono = tabla.Rows(0).Item("telefono")
                celular = tabla.Rows(0).Item("celular")
                whatsapp = "(+" & tabla.Rows(0).Item("codigopais") + ") " & tabla.Rows(0).Item("celular")
                email = tabla.Rows(0).Item("email1")
                pais = tabla.Rows(0).Item("nombrepais")
                dpto = tabla.Rows(0).Item("nombredpto")
                ciudad = tabla.Rows(0).Item("nombremunicipio")
                ultimaFechaActualizacion = CDate(tabla.Rows(0).Item("ultimafechaactualizacion")).ToString("yyyy/MM/dd")
                estado = IIf(tabla.Rows(0).Item("estado") = 1, "Activo", "Eliminado")
                ' fecha de nacido
                fechanac = CDate(tabla.Rows(0).Item("fechanacido")).ToString("yyyy/MM/dd")
                Dia = Day(CDate(tabla.Rows(0).Item("fechanacido")).ToString("yyyy/MM/dd"))
                ano = Year(CDate(tabla.Rows(0).Item("fechanacido")).ToString("yyyy/MM/dd"))
                ' fecha ultima actualizacion
                diaua = Day(CDate(tabla.Rows(0).Item("ultimafechaactualizacion")).ToString("yyyy/MM/dd"))
                anoua = Year(CDate(tabla.Rows(0).Item("ultimafechaactualizacion")).ToString("yyyy/MM/dd"))
                '
                id = tabla.Rows(0).Item("id")
                tipoAfiliado = IIf(tabla.Rows(0).Item("tipoAfiliado") = "di", "Distribuidor", "Cliente Elite")

                Select Case Month(fechanac)
                    Case 1
                        mes = "Enero"
                    Case 2
                        mes = "Febrero"
                    Case 3
                        mes = "Marzo"
                    Case 4
                        mes = "Abril"
                    Case 5
                        mes = "Mayo"
                    Case 6
                        mes = "Junio"
                    Case 7
                        mes = "Julio"
                    Case 8
                        mes = "Agosto"
                    Case 9
                        mes = "Septiembre"
                    Case 10
                        mes = "Octubre"
                    Case 11
                        mes = "Noviembre"
                    Case 12
                        mes = "Diciembre"
                End Select
                ' ultima fecha actualizazion
                Select Case Month(ultimaFechaActualizacion)
                    Case 1
                        mesua = "Ene"
                    Case 2
                        mesua = "Feb"
                    Case 3
                        mesua = "Mar"
                    Case 4
                        mesua = "Abr"
                    Case 5
                        mesua = "May"
                    Case 6
                        mesua = "Jun"
                    Case 7
                        mesua = "Jul"
                    Case 8
                        mesua = "Ago"
                    Case 9
                        mesua = "Sep"
                    Case 10
                        mesua = "Oct"
                    Case 11
                        mesua = "Nov"
                    Case 12
                        mesua = "Dic"
                End Select
            End If
        End With
        
       
        '----------------------------------------------------------------------------
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim miGUID As System.Guid = System.Guid.NewGuid()
        Dim sGUID As String = miGUID.ToString()
        'Dim rutaArchivo As String = obtieneRutaParaGrabarPDF()
        'Dim rutaMuestraImagen As String = obtieneRutaParaMostrarImagen()
        'Dim NombreArchivo As String = rutaArchivo & "Millas_" & codigoAfiliado & "_" & sGUID & ".pdf"
        Dim NombreFile As String = "Datos_" & codigoAfiliado & "_" & sGUID & ".pdf"
        '
        Dim pdfTemplate As String = "C:\ClientSites\knxplus.com\httpdocs\pdfmillas\plantilladatos.pdf"
        Dim newFile As String = "C:\ClientSites\knxplus.com\httpdocs\pdfmillas\" & NombreFile
        'Dim pdfTemplate As String = "C:\pdf\plantilladatos.pdf"
        'Dim newFile As String = "C:\pdf\" & NombreFile
        '
        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields
        ' The first worksheet and W-4 form
        ' ultima fecha de actualizacion
        pdfFormFields.SetField("Texto1", diaua)
        pdfFormFields.SetField("Texto2", mesua)
        pdfFormFields.SetField("Texto3", anoua)
        '
        pdfFormFields.SetField("Texto4", id)
        pdfFormFields.SetField("Texto5", codigoAfiliado)
        pdfFormFields.SetField("Texto6", tipoAfiliado)
        pdfFormFields.SetField("Texto7", identificacion)
        pdfFormFields.SetField("Texto8", nombreAfiliado)
        pdfFormFields.SetField("Texto9", apellidos)
        pdfFormFields.SetField("Texto10", rango)
        pdfFormFields.SetField("Texto11", direccion)
        pdfFormFields.SetField("Texto12", telefono)
        pdfFormFields.SetField("Texto13", celular)
        pdfFormFields.SetField("Texto14", whatsapp)
        pdfFormFields.SetField("Texto15", email)
        pdfFormFields.SetField("Texto16", Dia) ' dia nacimiento
        pdfFormFields.SetField("Texto17", mes) ' mes nacimiento
        pdfFormFields.SetField("Texto18", ano) ' mes nacimiento
        '
        pdfFormFields.SetField("Texto19", pais)
        pdfFormFields.SetField("Texto20", dpto)
        pdfFormFields.SetField("Texto21", ciudad)
        pdfFormFields.SetField("Texto22", estado)
        ' report by reading values from completed PDF
        Dim sTmp As String = "W-4 Completed for " + _
        pdfFormFields.GetField("f1_09(0)") + " " + _
        pdfFormFields.GetField("f1_10(0)")
        'MessageBox.Show(sTmp, "Finished")

        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Return NombreFile
    End Function
End Class
