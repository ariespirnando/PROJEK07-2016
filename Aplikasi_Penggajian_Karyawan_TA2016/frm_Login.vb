Public Class frm_Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Sub bersih()
        txtPassword.Clear()
        TxtUsername.Clear()
        TxtUsername.Focus()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If TxtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Lengkapi Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            bersih()
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_User WHERE Username ='" & TxtUsername.Text & "'  AND Password = '" & txtPassword.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Selamat, Anda Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_Home.ToolStripButton1.Enabled = True
                frm_Home.ToolStripButton2.Enabled = True
                frm_Home.LogOutToolStripMenuItem.Enabled = True
                frm_Home.LogInToolStripMenuItem.Enabled = False
                frm_Home.KaryawanToolStripMenuItem.Enabled = True
                frm_Home.GajiToolStripMenuItem.Enabled = True
                frm_Home.LaporanToolStripMenuItem.Enabled = True
                frm_Home.PengaturanToolStripMenuItem.Enabled = True
                bersih()
                Me.Close()
            Else
                MessageBox.Show("Username dan Password Tidak Cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bersih()
            End If
        End If
    End Sub

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
    End Sub
End Class