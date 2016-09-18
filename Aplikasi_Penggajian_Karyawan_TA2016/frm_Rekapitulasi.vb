
Imports Microsoft.Reporting.WinForms
Public Class frm_Rekapitulasi


    Private Sub frm_Rekapitulasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        txtTanggal.Value = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As String = txtTanggal.Value.ToString("MM")
        Dim B As String = txtTanggal.Value.ToString("yyyy")

        Dim Bulan As New ReportParameter("Bulan", txtTanggal.Value.ToString("MMMM"))
        Dim Tahun As New ReportParameter("Tahun", B)

        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM View_Laporan WHERE (MONTH(Tanggaltransaksi) = '" + A + "') AND " +
                                    "(YEAR(Tanggaltransaksi) = '" + B + "')", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        If baca.Read() Then
            Me.TotalRekapTableAdapter.Fill(Me.DataSetLaporan.TotalRekap, A, B)
            Me.PramuRekapTableAdapter.Fill(Me.DataSetLaporan.PramuRekap, A, B)
            Me.SatpamRekapTableAdapter.Fill(Me.DataSetLaporan.SatpamRekap, A, B)
            Me.ReportViewer1.LocalReport.SetParameters(Bulan)
            Me.ReportViewer1.LocalReport.SetParameters(Tahun)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Data Tidak Ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTanggal.Value = Now
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class