Public Class frm_Laporan

    Private Sub frm_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        txtTanggal.Value = Now
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As String = txtTanggal.Value.ToString("MM")
        Dim B As String = txtTanggal.Value.ToString("yyyy")
        Dim C As String = cmbJabatan.Text

        If C = "..:: Jabatan ::.." Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM View_Laporan WHERE(MONTH(Tanggaltransaksi) = '" + A + "') AND " +
                                           "(YEAR(Tanggaltransaksi) = '" + B + "') AND (Jabatan = '" + C + "')", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                Me.LaporanTableAdapter.Fill(Me.DataSetLaporan.Laporan, A, B, C)
                Me.ReportViewer1.RefreshReport()
            Else
                MessageBox.Show("Data Tidak Ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTanggal.Value = Now
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class