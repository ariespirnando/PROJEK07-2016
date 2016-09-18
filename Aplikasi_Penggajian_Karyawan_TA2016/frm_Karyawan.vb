Public Class frm_Karyawan
    Sub bersih()
        txtalamat.Clear()
        txtCariKaryawan.Clear()
        txtHp.Clear()
        txtNomor.Clear()
        txtnamaKaryawan.Clear()
        cmbJabatan.Text = "..:: Jabatan ::.."
        txtNomor.Focus()
    End Sub
    Sub simpan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("INSERT INTO tbl_Karyawan VALUES(@1,@2,@3,@4,@5)", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtNomor.Text
        cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtNamaKaryawan.Text
        cmd.Parameters.Add("@3", SqlDbType.VarChar).Value = cmbJabatan.Text
        cmd.Parameters.Add("@4", SqlDbType.Text).Value = txtAlamat.Text
        cmd.Parameters.Add("@5", SqlDbType.VarChar).Value = txtHp.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        karyawan()
        bersih()
    End Sub
    Sub edit()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbl_Karyawan SET nama_Karyawan = @2, Jabatan = @3, alamat_Rumah = @4, no_Handphone = @5 WHERE no_Karyawan = @1", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtNomor.Text
        cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtNamaKaryawan.Text
        cmd.Parameters.Add("@3", SqlDbType.VarChar).Value = cmbJabatan.Text
        cmd.Parameters.Add("@4", SqlDbType.Text).Value = txtAlamat.Text
        cmd.Parameters.Add("@5", SqlDbType.VarChar).Value = txtHp.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        karyawan()
        bersih()
    End Sub
    Sub hapus()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("DELETE FROM tbl_Karyawan WHERE no_Karyawan ='" & txtNomor.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        karyawan()
        bersih()
    End Sub
    Sub karyawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT no_Karyawan as No_Karyawan, nama_Karyawan as Nama_Karyawan,Jabatan, alamat_Rumah as Alamat_Rumah," +
                                       "no_Handphone from tbl_Karyawan", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbl_Karyawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbl_Karyawan"
        dtvKaryawan.Columns(0).Width = 40
        dtvKaryawan.Columns(1).Width = 100
        dtvKaryawan.Columns(2).Width = 60
        dtvKaryawan.Columns(3).Width = 160
        dtvKaryawan.Columns(4).Width = 100
    End Sub
    Sub Carikaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT no_Karyawan as No_Karyawan, nama_Karyawan as Nama_Karyawan,Jabatan, alamat_Rumah as Alamat_Rumah," +
                                       "no_Handphone from tbl_Karyawan WHERE nama_Karyawan like '%" + txtCariKaryawan.Text + "%'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbl_Karyawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbl_Karyawan"
        dtvKaryawan.Columns(0).Width = 40
        dtvKaryawan.Columns(1).Width = 100
        dtvKaryawan.Columns(2).Width = 60
        dtvKaryawan.Columns(3).Width = 160
        dtvKaryawan.Columns(4).Width = 100
    End Sub
    Private Sub frm_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        karyawan()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtCariKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txtCariKaryawan.TextChanged
        Carikaryawan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNomor.Text = "" Or txtNamaKaryawan.Text = "" Or txtAlamat.Text = "" Or cmbJabatan.Text = "..:: Jabatan ::.." Or
        txtHp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_Karyawan WHERE no_Karyawan ='" & txtNomor.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Nomor Karyawan Sudah Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNomor.Focus()
            Else
                simpan()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNomor.Text = "" Or txtNamaKaryawan.Text = "" Or txtAlamat.Text = "" Or cmbJabatan.Text = "..:: Jabatan ::.." Or
        txtHp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            edit()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtNomor.Text = "" Or txtNamaKaryawan.Text = "" Or txtAlamat.Text = "" Or cmbJabatan.Text = "..:: Jabatan ::.." Or
        txtHp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                hapus()
            End If
        End If
    End Sub

    Private Sub dtvKaryawan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellDoubleClick
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Enabled = True
        GroupBox5.Enabled = True
        GroupBox3.Enabled = True
        GroupBox2.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = True
        bersih()
    End Sub

    Private Sub dtvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellClick

    End Sub

    Private Sub dtvKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellContentClick

    End Sub

    Private Sub dtvKaryawan_MouseClick(sender As Object, e As MouseEventArgs) Handles dtvKaryawan.MouseClick
        Dim i As Integer
        i = Me.dtvKaryawan.CurrentRow.Index
        With dtvKaryawan.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtNomor.Text = .Cells(0).Value
                txtNamaKaryawan.Text = .Cells(1).Value
                cmbJabatan.Text = .Cells(2).Value
                txtAlamat.Text = .Cells(3).Value
                txtHp.Text = .Cells(4).Value
            End If
        End With
    End Sub
End Class