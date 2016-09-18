Public Class frm_Penggajian
    Dim upah As Double = 0
    Dim jumHadir As Double = 0
    Dim upahBulan As Double = 0
    Dim bpjsPerusahan As Double = 0
    Dim bpjsPegawai As Double = 0
    Dim lemburBiasa As Double = 0
    Dim lemburLibur As Double = 0

    Dim jumlahlBiasa As Double = 0
    Dim jumlahlLibur As Double = 0

    Dim totbiasa As Double = 0

    Dim totlibur As Double = 0

    Dim jumLahLembur As Double = 0
    Dim jumlahlKotor As Double = 0
    Dim jumlahlPotongan As Double = 0
    Dim jumlahlBersih As Double = 0

    Sub bersih()
        upah = 0
        jumHadir = 0
        upahBulan = 0
        bpjsPerusahan = 0
        bpjsPegawai = 0
        lemburBiasa = 0
        lemburLibur = 0
        jumlahlBiasa = 0
        jumlahlLibur = 0
        totbiasa = 0
        totlibur = 0
        jumLahLembur = 0
        jumlahlKotor = 0
        jumlahlPotongan = 0
        jumlahlBersih = 0

        txtNamaKaryawan.Clear()
        txtJabatan.Clear()
        txtAlamat.Clear()
        txtCariKaryawan.Clear()
        txtUpah.Clear()
        txtBPJSpegawai.Clear()
        txtBPJSperusahaan.Clear()
        txtlemburBiasa.Clear()
        txtLemburlibur.Clear()
        txtjumlahHadir.Clear()
        txtupahBulan.Clear()
        txtJbiasa.Clear()
        txtJLibur.Clear()
        txtJumlahBersih.Clear()
        txtJumlahPotongan.Clear()
        txtJumlahKotor.Clear()
        txtcariGaji.Clear()
        Karyawan()
        nomorOtomatis()
        btncarikaryawan.Focus()
    End Sub

    Sub rumus()
        jumLahLembur = totlibur + totbiasa

        jumlahlPotongan = bpjsPegawai + bpjsPerusahan
        jumlahlKotor = bpjsPerusahan + jumLahLembur + upahBulan
        jumlahlBersih = jumlahlKotor - jumlahlPotongan

        txtJumlahBersih.Text = Format(jumlahlBersih, "#,###")
        txtJumlahKotor.Text = Format(jumlahlKotor, "#,###")
        txtJumlahPotongan.Text = Format(jumlahlPotongan, "#,###")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtJabatan.TextChanged

    End Sub

    Private Sub frm_Penggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        Karyawan()
        nomorOtomatis()
    End Sub
    Sub nilaigaji()
        Try
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            baca.Read()
            upah = Val(baca.Item("UpahperHari").ToString)
            bpjsPerusahan = Val(baca.Item("BPJSperusahaan").ToString)
            bpjsPegawai = Val(baca.Item("BPJSpegawai").ToString)
            lemburLibur = Val(baca.Item("lemburLibur").ToString)
            lemburBiasa = Val(baca.Item("lemburBiasa").ToString)
            ID.Text = baca.Item("idGaji")

            txtUpah.Text = Format(upah, "#,###")
            txtBPJSperusahaan.Text = Format(bpjsPerusahan, "#,###")
            txtBPJSpegawai.Text = Format(bpjsPegawai, "#,###")
            txtLemburlibur.Text = Format(lemburLibur, "#,###")
            txtlemburBiasa.Text = Format(lemburBiasa, "#,###")

        Catch ex As Exception
            MessageBox.Show("Pilih Jabatan dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub detailnilaiGaji()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Gaji WHERE Jabatan = '" + txtJabatan.Text + "'", con)
        nilaigaji()
    End Sub

    Sub Karyawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * from View_TransaksiGaji", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "View_TransaksiGaji")
        dtvPengajian.DataSource = ds
        dtvPengajian.DataMember = "View_TransaksiGaji"
        dtvPengajian.Columns(0).Width = 130
    End Sub
    Sub nomorOtomatis()
        Dim StrSementara As String = ""
        Dim Strisi As String = ""
        Dim tanggal1 As String = txtTanggal.Value.ToString("MMM")
        Dim tanggal2 As String = txtTanggal.Value.ToString("yy")
        Dim n As Integer = vbNull
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Penggajian order by kodTransaksi desc", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        If baca.Read() Then
            StrSementara = Mid(baca.Item("kodTransaksi"), 12, 5)
            Strisi = Val(StrSementara) + 1
            n = Val(Strisi)
            If n < 10 Then
                txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/0000" + Strisi
            ElseIf n < 100 Then
                txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/000" + Strisi
            ElseIf n < 1000 Then
                txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/00" + Strisi
            ElseIf n < 10000 Then
                txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/0" + Strisi
            Else
                txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/" + Strisi
            End If
        Else
            txtkodeGaji.Text = "Trx/" + tanggal1 + "/" + tanggal2 + "/00001"
        End If
        txtTanggal.Value = Now
        tglAkhir.Value = Now
        tglAwal.Value = Now
    End Sub
    Sub carigajiKaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * from View_TransaksiGaji WHERE nama_Karyawan = '" + txtcariGaji.Text + "' and Tanggaltransaksi BETWEEN '" + tglAwal.Text + "' and '" + tglAkhir.Text + "'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "View_TransaksiGaji")
        dtvPengajian.DataSource = ds
        dtvPengajian.DataMember = "View_TransaksiGaji"
        dtvPengajian.Columns(0).Width = 130
    End Sub
    Sub Carikaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT nama_Karyawan as Nama_Karyawan,Jabatan, alamat_Rumah as Alamat_Rumah, no_Karyawan " +
                                       "from tbl_Karyawan WHERE nama_Karyawan like '%" + txtCariKaryawan.Text + "%'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbl_Karyawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbl_Karyawan"
        dtvKaryawan.Columns(0).Width = 100
        dtvKaryawan.Columns(1).Width = 60
        dtvKaryawan.Columns(2).Width = 180
        dtvKaryawan.Columns(3).Width = 0

    End Sub
    Sub simpan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("INSERT INTO tbl_Penggajian VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtkodeGaji.Text
        cmd.Parameters.Add("@2", SqlDbType.Date).Value = txtTanggal.Value.ToString("yyyy-MM-dd")
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = txtNoKaryawan.Text
        cmd.Parameters.Add("@4", SqlDbType.Int).Value = ID.Text
        cmd.Parameters.Add("@5", SqlDbType.Int).Value = jumHadir
        cmd.Parameters.Add("@6", SqlDbType.Int).Value = jumlahlBiasa

        cmd.Parameters.Add("@7", SqlDbType.Int).Value = jumlahlLibur
        cmd.Parameters.Add("@8", SqlDbType.Float).Value = totbiasa
        cmd.Parameters.Add("@9", SqlDbType.Float).Value = totlibur

        cmd.Parameters.Add("@10", SqlDbType.Float).Value = jumLahLembur
        cmd.Parameters.Add("@11", SqlDbType.Float).Value = upahBulan
        cmd.Parameters.Add("@12", SqlDbType.Float).Value = jumlahlKotor
        cmd.Parameters.Add("@13", SqlDbType.Float).Value = jumlahlPotongan
        cmd.Parameters.Add("@14", SqlDbType.Float).Value = jumlahlBersih
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Karyawan()
    End Sub
    Sub hapus()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("DELETE FROM tbl_Penggajian WHERE kodTransaksi ='" & txtkodeGaji.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Karyawan()
    End Sub
    Sub edit()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbl_Penggajian SET Tanggaltransaksi = @2, no_Karyawan = @3, idGaji = @4, jumlahHadir = @5, " +
                                       "jumlahLemburBiasa =@6, jumlahLemburLibur =@7, TotalLemburBiasa =@8, TotalLemburLibur =@9, " +
                                       "TotalLembur =@10, jumlahperBulan =@11, jumlahGajiKotor =@12, jumlahPotongan =@13, jumlahGajiBersih =@14 WHERE kodTransaksi = @1", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtkodeGaji.Text
        cmd.Parameters.Add("@2", SqlDbType.Date).Value = txtTanggal.Value.ToString("yyyy-MM-dd")
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = txtNoKaryawan.Text
        cmd.Parameters.Add("@4", SqlDbType.Int).Value = ID.Text
        cmd.Parameters.Add("@5", SqlDbType.Int).Value = jumHadir
        cmd.Parameters.Add("@6", SqlDbType.Int).Value = jumlahlBiasa

        cmd.Parameters.Add("@7", SqlDbType.Int).Value = jumlahlLibur
        cmd.Parameters.Add("@8", SqlDbType.Float).Value = totbiasa
        cmd.Parameters.Add("@9", SqlDbType.Float).Value = totlibur

        cmd.Parameters.Add("@10", SqlDbType.Float).Value = jumLahLembur
        cmd.Parameters.Add("@11", SqlDbType.Float).Value = upahBulan
        cmd.Parameters.Add("@12", SqlDbType.Float).Value = jumlahlKotor
        cmd.Parameters.Add("@13", SqlDbType.Float).Value = jumlahlPotongan
        cmd.Parameters.Add("@14", SqlDbType.Float).Value = jumlahlBersih
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Karyawan()
    End Sub



    Private Sub txtkodeGaji_TextChanged(sender As Object, e As EventArgs) Handles txtkodeGaji.TextChanged

    End Sub

    Private Sub txtjumlahHadir_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahHadir.TextChanged
        jumHadir = Val(txtjumlahHadir.Text)
        upahBulan = jumHadir * upah
        txtupahBulan.Text = Format(upahBulan, "#,###")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtJLibur.TextChanged
        jumlahlLibur = Val(txtJLibur.Text)
        totlibur = lemburLibur * jumlahlLibur
        rumus()
    End Sub

    Private Sub txtJbiasa_TextChanged(sender As Object, e As EventArgs) Handles txtJbiasa.TextChanged

        jumlahlBiasa = Val(txtJbiasa.Text)
        totbiasa = lemburBiasa * jumlahlBiasa
        rumus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncarikaryawan.Click
        GroupBox6.Visible = True
        Carikaryawan()
    End Sub

    Private Sub txtCariKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txtCariKaryawan.TextChanged
        Carikaryawan()
    End Sub

    Private Sub dtvKaryawan_MouseClick(sender As Object, e As MouseEventArgs) Handles dtvKaryawan.MouseClick
        Dim i As Integer
        i = Me.dtvKaryawan.CurrentRow.Index
        With dtvKaryawan.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtNamaKaryawan.Text = .Cells(0).Value
                txtJabatan.Text = .Cells(1).Value
                txtAlamat.Text = .Cells(2).Value
                txtNoKaryawan.Text = .Cells(3).Value
            End If
        End With
        detailnilaiGaji()
        GroupBox6.Visible = False
    End Sub

    Private Sub dtvKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellContentClick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A As String = txtTanggal.Value.ToString("MM")
        Dim B As String = txtTanggal.Value.ToString("yyyy")

        If txtNoKaryawan.Text = "" Or txtjumlahHadir.Text = "" Or txtJbiasa.Text = "" Or txtJLibur.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM View_TransaksiGaji WHERE(MONTH(Tanggaltransaksi) = '" + A + "') AND " +
                                    "(YEAR(Tanggaltransaksi) = '" + B + "') AND (nama_Karyawan ='" + txtNamaKaryawan.Text + "')", con)
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Karyawan sudah melakukan transaksi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bersih()
            Else
                simpan()
                bersih()
            End If
        End If
    End Sub

    Private Sub dtvPengajian_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dtvPengajian.MouseDoubleClick
        
    End Sub

    Private Sub dtvPengajian_MouseClick(sender As Object, e As MouseEventArgs) Handles dtvPengajian.MouseClick
        Dim i As Integer
        i = Me.dtvPengajian.CurrentRow.Index
        With dtvPengajian.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtkodeGaji.Text = .Cells(0).Value
                txtTanggal.Value = Convert.ToDateTime(.Cells(1).Value)
                txtNamaKaryawan.Text = .Cells(2).Value
                txtJabatan.Text = .Cells(3).Value
                txtNoKaryawan.Text = .Cells(7).Value

                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT * from tbl_Karyawan WHERE no_Karyawan ='" + txtNoKaryawan.Text + "'", con)
                cmd.ExecuteNonQuery()
                baca = cmd.ExecuteReader()
                baca.Read()
                txtjumlahHadir.Text = baca.Item("alamat_Rumah").ToString

                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Gaji WHERE Jabatan = '" + txtJabatan.Text + "'", con)
                nilaigaji()

                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT * from tbl_Penggajian WHERE kodTransaksi ='" + txtkodeGaji.Text + "'", con)
                cmd.ExecuteNonQuery()
                baca = cmd.ExecuteReader()
                baca.Read()
                txtjumlahHadir.Text = baca.Item("jumlahHadir").ToString
                txtJbiasa.Text = baca.Item("jumlahLemburBiasa").ToString
                txtJLibur.Text = baca.Item("jumlahLemburLibur").ToString
            End If
        End With
    End Sub

    Private Sub txtNoKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txtNoKaryawan.TextChanged
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * from tbl_Karyawan WHERE no_Karyawan ='" + txtNoKaryawan.Text + "'", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        baca.Read()
        txtAlamat.Text = baca.Item("alamat_Rumah").ToString
    End Sub

    Private Sub dtvPengajian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvPengajian.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtNoKaryawan.Text = "" Or txtjumlahHadir.Text = "" Or txtJbiasa.Text = "" Or txtJLibur.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            hapus()
            bersih()
        End If
    End Sub

    Private Sub txtTanggal_ValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.ValueChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtNoKaryawan.Text = "" Or txtjumlahHadir.Text = "" Or txtJbiasa.Text = "" Or txtJLibur.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            edit()
            bersih()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtcariGaji.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            carigajiKaryawan()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox4.Enabled = True
        Button4.Enabled = True
        Button6.Enabled = True
        Button8.Enabled = True
        bersih()
    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If txtNoKaryawan.Text = "" Or txtjumlahHadir.Text = "" Or txtJbiasa.Text = "" Or txtJLibur.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM View_TransaksiGaji WHERE (kodTransaksi ='" + txtkodeGaji.Text + "')", con)
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                frm_Slip.MdiParent = frm_Home
                frm_Slip.Show()
                frm_Slip.SlipTableAdapter.Fill(frm_Slip.DataSetLaporan.Slip, txtkodeGaji.Text)
                frm_Slip.ReportViewer1.RefreshReport()
                bersih()
            Else
                MessageBox.Show("Simpan data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                simpan()
                frm_Slip.MdiParent = frm_Home
                frm_Slip.Show()
                frm_Slip.SlipTableAdapter.Fill(frm_Slip.DataSetLaporan.Slip, Me.txtkodeGaji.Text)
                frm_Slip.ReportViewer1.RefreshReport()
                bersih()
            End If
        End If
    End Sub
End Class