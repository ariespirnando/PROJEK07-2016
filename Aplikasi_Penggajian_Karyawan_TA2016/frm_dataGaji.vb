Public Class frm_dataGaji
    Sub simpan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbl_Gaji SET UpahperHari=@1, BPJSperusahaan=@2, BPJSpegawai=@3, lemburLibur=@4, lemburBiasa=@4 WHERE idGaji = '" + ID.Text + "'", con)
        cmd.Parameters.Add("@1", SqlDbType.Float).Value = txtUpah.Text
        cmd.Parameters.Add("@2", SqlDbType.Float).Value = txtBPJSperusahaan.Text
        cmd.Parameters.Add("@3", SqlDbType.Float).Value = txtBPJSpegawai.Text
        cmd.Parameters.Add("@4", SqlDbType.Float).Value = txtLemburlibur.Text
        cmd.Parameters.Add("@5", SqlDbType.Float).Value = txtlemburBiasa.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilgaji()
    End Sub
    Sub toedit()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Gaji WHERE Jabatan = '" + cmbJabatan.Text + "'", con)
        Try
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            baca.Read()
            Dim a As Double = Val(baca.Item("UpahperHari").ToString)
            Dim b As Double = Val(baca.Item("BPJSperusahaan").ToString)
            Dim c As Double = Val(baca.Item("BPJSpegawai").ToString)
            Dim d As Double = Val(baca.Item("lemburLibur").ToString)
            Dim e As Double = Val(baca.Item("lemburBiasa").ToString)
            txtUpah.Text = a
            txtBPJSperusahaan.Text = b
            txtBPJSpegawai.Text = c
            txtLemburlibur.Text = d
            txtlemburBiasa.Text = e
            ID.Text = baca.Item("idGaji")
        Catch ex As Exception
            MessageBox.Show("Pilih Jabatan dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub frm_dataGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
    End Sub
    Sub tampilgaji()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Gaji WHERE Jabatan = '" + cmbJabatan.Text + "'", con)
        Try
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            baca.Read()
            Dim a As Double = Val(baca.Item("UpahperHari").ToString)
            Dim b As Double = Val(baca.Item("BPJSperusahaan").ToString)
            Dim c As Double = Val(baca.Item("BPJSpegawai").ToString)
            Dim d As Double = Val(baca.Item("lemburLibur").ToString)
            Dim e As Double = Val(baca.Item("lemburBiasa").ToString)
            txtUpah.Text = Format(a, "#,###")
            txtBPJSperusahaan.Text = Format(b, "#,###")
            txtBPJSpegawai.Text = Format(c, "#,###")
            txtLemburlibur.Text = Format(d, "#,###")
            txtlemburBiasa.Text = Format(e, "#,###")
            ID.Text = baca.Item("idGaji")
        Catch ex As Exception
            MessageBox.Show("Pilih Jabatan dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cmbJabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJabatan.SelectedIndexChanged
        tampilgaji()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbJabatan.Text = "..:: Jabatan ::.." Then
            MessageBox.Show("Pilih Jabatan dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            GroupBox2.Enabled = False
            GroupBox1.Enabled = True
            Button2.Visible = True
            Button1.Visible = False
            toedit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtBPJSpegawai.Text = "" Or txtUpah.Text = "" Or txtBPJSperusahaan.Text = "" Or txtlemburBiasa.Text = "" Or txtLemburlibur.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            simpan()
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
            Button2.Visible = False
            Button1.Visible = True
            tampilgaji()
        End If
    End Sub
End Class