Public Class frm_Home

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs) Handles TopToolStripPanel.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        KaryawanToolStripMenuItem.Enabled = False
        GajiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False
        frm_Login.MdiParent = Me
        frm_Login.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = FormatDateTime(Now, DateFormat.LongDate)
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        frm_Karyawan.MdiParent = Me
        frm_Karyawan.Show()

        frm_About.Close()
        frm_dataGaji.Close()
        frm_dataUser.Close()
        frm_Laporan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()

    End Sub

    Private Sub AbsensiKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GajiKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GajiKaryawanToolStripMenuItem.Click
        frm_Penggajian.MdiParent = Me
        frm_Penggajian.Show()

        frm_About.Close()
        frm_dataGaji.Close()
        frm_dataUser.Close()
        frm_Laporan.Close()
        frm_Karyawan.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
    End Sub

    Private Sub DataGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGajiToolStripMenuItem.Click
        frm_dataGaji.MdiParent = Me
        frm_dataGaji.Show()

        frm_Laporan.Close()
        frm_dataUser.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
        frm_About.Close()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        frm_dataUser.MdiParent = Me
        frm_dataUser.Show()

        frm_Laporan.Close()
        frm_dataGaji.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
        frm_About.Close()
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        frm_About.MdiParent = Me
        frm_About.Show()

        frm_Laporan.Close()
        frm_dataUser.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
        frm_dataGaji.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        KaryawanToolStripMenuItem.Enabled = False
        GajiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False
        LogInToolStripMenuItem.Enabled = True
        MessageBox.Show("Logout Sukses !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        frm_Login.MdiParent = Me
        frm_Login.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ToolStripButton1.Enabled = False
        LogInToolStripMenuItem.Enabled = True
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        KaryawanToolStripMenuItem.Enabled = False
        GajiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False
        MessageBox.Show("Logout Sukses !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LaporanGajiKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanGajiKaryawanToolStripMenuItem.Click
        frm_Laporan.MdiParent = Me
        frm_Laporan.Show()

        frm_About.Close()
        frm_dataGaji.Close()
        frm_dataUser.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
    End Sub

    Private Sub RekapitulasiGajiKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekapitulasiGajiKaryawanToolStripMenuItem.Click
        frm_Rekapitulasi.MdiParent = Me
        frm_Rekapitulasi.Show()

        frm_About.Close()
        frm_dataGaji.Close()
        frm_dataUser.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Laporan.Close()
        frm_Slip.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frm_About.MdiParent = Me
        frm_About.Show()

        frm_Laporan.Close()
        frm_dataUser.Close()
        frm_Karyawan.Close()
        frm_Penggajian.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
        frm_dataGaji.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm_Penggajian.MdiParent = Me
        frm_Penggajian.Show()

        frm_About.Close()
        frm_dataGaji.Close()
        frm_dataUser.Close()
        frm_Laporan.Close()
        frm_Karyawan.Close()
        frm_Rekapitulasi.Close()
        frm_Slip.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class
