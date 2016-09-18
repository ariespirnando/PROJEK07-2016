
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Koneksi
    Public con As SqlConnection
    Public ds As DataSet
    Public baca As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public str, sql As String
    Public Sub bukaKoneksi()
        str = "Data Source = IOSUX-PC; Initial Catalog = MI_TA2016; Integrated Security = true "
        con = New SqlConnection(str)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
