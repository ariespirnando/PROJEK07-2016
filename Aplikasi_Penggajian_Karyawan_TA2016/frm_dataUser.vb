Public Class frm_dataUser
    Sub user()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_User", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        baca.Read()
        txtUs.Text = baca.Item("Username")
        txtPas.Text = baca.Item("Password")
        txtEm.Text = baca.Item("Email")
    End Sub
    Sub simpan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbl_User SET Username=@1, Password=@2, Email=@3  WHERE id = 1", con)
        cmd.Parameters.Add("@1", SqlDbType.VarChar).Value = txtUs.Text
        cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtPas.Text
        cmd.Parameters.Add("@3", SqlDbType.VarChar).Value = txtEm.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        user()
    End Sub
    Sub bersih()
        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Lengkapi Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            bersih()
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_User WHERE Username ='" & txtUsername.Text & "'  AND Password = '" & txtPassword.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                GroupBox2.Visible = False
                user()
                bersih()
                Button1.Visible = True
                Button5.Visible = True
            Else
                MessageBox.Show("Username dan Password Tidak Cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bersih()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Visible = True
        Button1.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
        Button2.Visible = True
        Button1.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub frm_dataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        user()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtUs.Text = "" Or txtPas.Text = "" Or txtEm.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            simpan()
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
            Button2.Visible = False
            Button1.Visible = True
            Button5.Visible = True
            user()
        End If
    End Sub
End Class