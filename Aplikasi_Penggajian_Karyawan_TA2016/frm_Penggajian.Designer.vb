<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Penggajian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtJLibur = New System.Windows.Forms.TextBox()
        Me.txtJumlahBersih = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtJumlahPotongan = New System.Windows.Forms.TextBox()
        Me.txtJumlahKotor = New System.Windows.Forms.TextBox()
        Me.txtJbiasa = New System.Windows.Forms.TextBox()
        Me.txtupahBulan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtjumlahHadir = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtlemburBiasa = New System.Windows.Forms.TextBox()
        Me.txtLemburlibur = New System.Windows.Forms.TextBox()
        Me.txtBPJSpegawai = New System.Windows.Forms.TextBox()
        Me.txtBPJSperusahaan = New System.Windows.Forms.TextBox()
        Me.txtUpah = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btncarikaryawan = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.txtkodeGaji = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtcariGaji = New System.Windows.Forms.TextBox()
        Me.tglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.tglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtvPengajian = New System.Windows.Forms.DataGridView()
        Me.txtCariKaryawan = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dtvKaryawan = New System.Windows.Forms.DataGridView()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.txtNoKaryawan = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dtvPengajian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtTanggal)
        Me.GroupBox1.Controls.Add(Me.btncarikaryawan)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtJabatan)
        Me.GroupBox1.Controls.Add(Me.txtNamaKaryawan)
        Me.GroupBox1.Controls.Add(Me.txtkodeGaji)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "..:: Gaji Karyawan ::.."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtJLibur)
        Me.GroupBox3.Controls.Add(Me.txtJumlahBersih)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtJumlahPotongan)
        Me.GroupBox3.Controls.Add(Me.txtJumlahKotor)
        Me.GroupBox3.Controls.Add(Me.txtJbiasa)
        Me.GroupBox3.Controls.Add(Me.txtupahBulan)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtjumlahHadir)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtlemburBiasa)
        Me.GroupBox3.Controls.Add(Me.txtLemburlibur)
        Me.GroupBox3.Controls.Add(Me.txtBPJSpegawai)
        Me.GroupBox3.Controls.Add(Me.txtBPJSperusahaan)
        Me.GroupBox3.Controls.Add(Me.txtUpah)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 244)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "..:: Detail Gaji ::.."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(457, 33)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 17)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "Hari"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(457, 124)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 17)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Jam"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(267, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 17)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Lembur Libur"
        '
        'txtJLibur
        '
        Me.txtJLibur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJLibur.Location = New System.Drawing.Point(391, 90)
        Me.txtJLibur.Name = "txtJLibur"
        Me.txtJLibur.Size = New System.Drawing.Size(60, 21)
        Me.txtJLibur.TabIndex = 27
        '
        'txtJumlahBersih
        '
        Me.txtJumlahBersih.Enabled = False
        Me.txtJumlahBersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahBersih.Location = New System.Drawing.Point(391, 205)
        Me.txtJumlahBersih.Name = "txtJumlahBersih"
        Me.txtJumlahBersih.Size = New System.Drawing.Size(103, 21)
        Me.txtJumlahBersih.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(267, 124)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 17)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Lembur Biasa"
        '
        'txtJumlahPotongan
        '
        Me.txtJumlahPotongan.Enabled = False
        Me.txtJumlahPotongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahPotongan.Location = New System.Drawing.Point(391, 178)
        Me.txtJumlahPotongan.Name = "txtJumlahPotongan"
        Me.txtJumlahPotongan.Size = New System.Drawing.Size(103, 21)
        Me.txtJumlahPotongan.TabIndex = 24
        '
        'txtJumlahKotor
        '
        Me.txtJumlahKotor.Enabled = False
        Me.txtJumlahKotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahKotor.Location = New System.Drawing.Point(391, 151)
        Me.txtJumlahKotor.Name = "txtJumlahKotor"
        Me.txtJumlahKotor.Size = New System.Drawing.Size(103, 21)
        Me.txtJumlahKotor.TabIndex = 23
        '
        'txtJbiasa
        '
        Me.txtJbiasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJbiasa.Location = New System.Drawing.Point(391, 121)
        Me.txtJbiasa.Name = "txtJbiasa"
        Me.txtJbiasa.Size = New System.Drawing.Size(60, 21)
        Me.txtJbiasa.TabIndex = 22
        '
        'txtupahBulan
        '
        Me.txtupahBulan.Enabled = False
        Me.txtupahBulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupahBulan.Location = New System.Drawing.Point(391, 62)
        Me.txtupahBulan.Name = "txtupahBulan"
        Me.txtupahBulan.Size = New System.Drawing.Size(103, 21)
        Me.txtupahBulan.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(267, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 17)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Jumlah Bersih"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(267, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Jumlah Kotor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(267, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Jumlah Potongan"
        '
        'txtjumlahHadir
        '
        Me.txtjumlahHadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahHadir.Location = New System.Drawing.Point(391, 34)
        Me.txtjumlahHadir.Name = "txtjumlahHadir"
        Me.txtjumlahHadir.Size = New System.Drawing.Size(60, 21)
        Me.txtjumlahHadir.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(267, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Upah satu Bulan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(267, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Jumlah Hadir"
        '
        'txtlemburBiasa
        '
        Me.txtlemburBiasa.Enabled = False
        Me.txtlemburBiasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlemburBiasa.Location = New System.Drawing.Point(130, 194)
        Me.txtlemburBiasa.Name = "txtlemburBiasa"
        Me.txtlemburBiasa.Size = New System.Drawing.Size(103, 21)
        Me.txtlemburBiasa.TabIndex = 14
        '
        'txtLemburlibur
        '
        Me.txtLemburlibur.Enabled = False
        Me.txtLemburlibur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLemburlibur.Location = New System.Drawing.Point(130, 163)
        Me.txtLemburlibur.Name = "txtLemburlibur"
        Me.txtLemburlibur.Size = New System.Drawing.Size(103, 21)
        Me.txtLemburlibur.TabIndex = 13
        '
        'txtBPJSpegawai
        '
        Me.txtBPJSpegawai.Enabled = False
        Me.txtBPJSpegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPJSpegawai.Location = New System.Drawing.Point(130, 112)
        Me.txtBPJSpegawai.Name = "txtBPJSpegawai"
        Me.txtBPJSpegawai.Size = New System.Drawing.Size(103, 21)
        Me.txtBPJSpegawai.TabIndex = 12
        '
        'txtBPJSperusahaan
        '
        Me.txtBPJSperusahaan.Enabled = False
        Me.txtBPJSperusahaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPJSperusahaan.Location = New System.Drawing.Point(130, 81)
        Me.txtBPJSperusahaan.Name = "txtBPJSperusahaan"
        Me.txtBPJSperusahaan.Size = New System.Drawing.Size(103, 21)
        Me.txtBPJSperusahaan.TabIndex = 11
        '
        'txtUpah
        '
        Me.txtUpah.Enabled = False
        Me.txtUpah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpah.Location = New System.Drawing.Point(130, 33)
        Me.txtUpah.Name = "txtUpah"
        Me.txtUpah.Size = New System.Drawing.Size(103, 21)
        Me.txtUpah.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Hari Biasa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hari Libur"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Lembur"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pegawai"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Perusahaan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Iuaran BPJS Tanggungan "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Upah per Hari"
        '
        'txtTanggal
        '
        Me.txtTanggal.CustomFormat = "dd-MMM-yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(389, 37)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(111, 20)
        Me.txtTanggal.TabIndex = 12
        Me.txtTanggal.Value = New Date(2016, 9, 2, 0, 0, 0, 0)
        '
        'btncarikaryawan
        '
        Me.btncarikaryawan.Location = New System.Drawing.Point(417, 63)
        Me.btncarikaryawan.Name = "btncarikaryawan"
        Me.btncarikaryawan.Size = New System.Drawing.Size(83, 23)
        Me.btncarikaryawan.TabIndex = 11
        Me.btncarikaryawan.Text = "......."
        Me.btncarikaryawan.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(162, 120)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(249, 66)
        Me.txtAlamat.TabIndex = 10
        '
        'txtJabatan
        '
        Me.txtJabatan.Enabled = False
        Me.txtJabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJabatan.Location = New System.Drawing.Point(162, 93)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(249, 21)
        Me.txtJabatan.TabIndex = 9
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Enabled = False
        Me.txtNamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(162, 63)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(249, 21)
        Me.txtNamaKaryawan.TabIndex = 8
        '
        'txtkodeGaji
        '
        Me.txtkodeGaji.Enabled = False
        Me.txtkodeGaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodeGaji.Location = New System.Drawing.Point(162, 34)
        Me.txtkodeGaji.Name = "txtkodeGaji"
        Me.txtkodeGaji.Size = New System.Drawing.Size(123, 21)
        Me.txtkodeGaji.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Gaji"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Gaji"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.dtvPengajian)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(545, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 545)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "..:: Data Gaji ::.."
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtcariGaji)
        Me.GroupBox7.Controls.Add(Me.tglAkhir)
        Me.GroupBox7.Controls.Add(Me.tglAwal)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(542, 100)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'txtcariGaji
        '
        Me.txtcariGaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcariGaji.Location = New System.Drawing.Point(169, 39)
        Me.txtcariGaji.Name = "txtcariGaji"
        Me.txtcariGaji.Size = New System.Drawing.Size(262, 21)
        Me.txtcariGaji.TabIndex = 21
        '
        'tglAkhir
        '
        Me.tglAkhir.CustomFormat = "dd-MMM-yyyy"
        Me.tglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglAkhir.Location = New System.Drawing.Point(331, 63)
        Me.tglAkhir.Name = "tglAkhir"
        Me.tglAkhir.Size = New System.Drawing.Size(100, 20)
        Me.tglAkhir.TabIndex = 19
        Me.tglAkhir.Value = New Date(2016, 7, 31, 19, 6, 1, 0)
        '
        'tglAwal
        '
        Me.tglAwal.CustomFormat = "dd-MMM-yyyy"
        Me.tglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglAwal.Location = New System.Drawing.Point(169, 63)
        Me.tglAwal.Name = "tglAwal"
        Me.tglAwal.Size = New System.Drawing.Size(100, 20)
        Me.tglAwal.TabIndex = 13
        Me.tglAwal.Value = New Date(2016, 7, 31, 19, 6, 1, 0)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(437, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(275, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 17)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Sampai"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(35, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 17)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Tanggal Awal"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 17)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Cari"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 17)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Nama Karyawan"
        '
        'dtvPengajian
        '
        Me.dtvPengajian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvPengajian.Location = New System.Drawing.Point(6, 157)
        Me.dtvPengajian.Name = "dtvPengajian"
        Me.dtvPengajian.Size = New System.Drawing.Size(542, 382)
        Me.dtvPengajian.TabIndex = 0
        '
        'txtCariKaryawan
        '
        Me.txtCariKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariKaryawan.Location = New System.Drawing.Point(123, 13)
        Me.txtCariKaryawan.Name = "txtCariKaryawan"
        Me.txtCariKaryawan.Size = New System.Drawing.Size(229, 21)
        Me.txtCariKaryawan.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(11, 456)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(131, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(31, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 61)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Location = New System.Drawing.Point(148, 458)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 100)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(124, 57)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 36)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Cetak"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(291, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 78)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(28, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 36)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Baru"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(124, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(28, 57)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 36)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Edit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(475, 297)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 17)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Jam"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtvKaryawan)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.txtCariKaryawan)
        Me.GroupBox6.Location = New System.Drawing.Point(430, 97)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 201)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'dtvKaryawan
        '
        Me.dtvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvKaryawan.Location = New System.Drawing.Point(9, 40)
        Me.dtvKaryawan.Name = "dtvKaryawan"
        Me.dtvKaryawan.Size = New System.Drawing.Size(343, 154)
        Me.dtvKaryawan.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 17)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Nama Karyawan"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(1, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(10, 21)
        Me.ID.TabIndex = 13
        Me.ID.Visible = False
        '
        'txtNoKaryawan
        '
        Me.txtNoKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKaryawan.Location = New System.Drawing.Point(1, 27)
        Me.txtNoKaryawan.Name = "txtNoKaryawan"
        Me.txtNoKaryawan.Size = New System.Drawing.Size(10, 21)
        Me.txtNoKaryawan.TabIndex = 30
        Me.txtNoKaryawan.Visible = False
        '
        'frm_Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1115, 567)
        Me.Controls.Add(Me.txtNoKaryawan)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frm_Penggajian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penggajian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dtvPengajian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeGaji As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncarikaryawan As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlahHadir As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtlemburBiasa As System.Windows.Forms.TextBox
    Friend WithEvents txtLemburlibur As System.Windows.Forms.TextBox
    Friend WithEvents txtBPJSpegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtBPJSperusahaan As System.Windows.Forms.TextBox
    Friend WithEvents txtUpah As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahBersih As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahPotongan As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahKotor As System.Windows.Forms.TextBox
    Friend WithEvents txtJbiasa As System.Windows.Forms.TextBox
    Friend WithEvents txtupahBulan As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtvPengajian As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCariKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtJLibur As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents tglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dtvKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtcariGaji As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents txtNoKaryawan As System.Windows.Forms.TextBox
End Class
