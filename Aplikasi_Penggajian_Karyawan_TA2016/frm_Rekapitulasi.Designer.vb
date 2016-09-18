<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rekapitulasi
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TotalRekapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLaporan = New Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporan()
        Me.PramuRekapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SatpamRekapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TotalRekapTableAdapter = New Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.TotalRekapTableAdapter()
        Me.PramuRekapTableAdapter = New Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.PramuRekapTableAdapter()
        Me.SatpamRekapTableAdapter = New Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.SatpamRekapTableAdapter()
        CType(Me.TotalRekapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PramuRekapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatpamRekapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalRekapBindingSource
        '
        Me.TotalRekapBindingSource.DataMember = "TotalRekap"
        Me.TotalRekapBindingSource.DataSource = Me.DataSetLaporan
        '
        'DataSetLaporan
        '
        Me.DataSetLaporan.DataSetName = "DataSetLaporan"
        Me.DataSetLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PramuRekapBindingSource
        '
        Me.PramuRekapBindingSource.DataMember = "PramuRekap"
        Me.PramuRekapBindingSource.DataSource = Me.DataSetLaporan
        '
        'SatpamRekapBindingSource
        '
        Me.SatpamRekapBindingSource.DataMember = "SatpamRekap"
        Me.SatpamRekapBindingSource.DataSource = Me.DataSetLaporan
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 96)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(772, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 62)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 62)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTanggal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 67)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'txtTanggal
        '
        Me.txtTanggal.CustomFormat = "MMMM -  yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(124, 28)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(188, 20)
        Me.txtTanggal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(470, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Bulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Total"
        ReportDataSource1.Value = Me.TotalRekapBindingSource
        ReportDataSource2.Name = "Pramu"
        ReportDataSource2.Value = Me.PramuRekapBindingSource
        ReportDataSource3.Name = "Satpam"
        ReportDataSource3.Value = Me.SatpamRekapBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_Penggajian_Karyawan_TA2016.Rekapitulasi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 102)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(888, 416)
        Me.ReportViewer1.TabIndex = 4
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'TotalRekapTableAdapter
        '
        Me.TotalRekapTableAdapter.ClearBeforeFill = True
        '
        'PramuRekapTableAdapter
        '
        Me.PramuRekapTableAdapter.ClearBeforeFill = True
        '
        'SatpamRekapTableAdapter
        '
        Me.SatpamRekapTableAdapter.ClearBeforeFill = True
        '
        'frm_Rekapitulasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frm_Rekapitulasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekapitulasi"
        CType(Me.TotalRekapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PramuRekapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatpamRekapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TotalRekapBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetLaporan As Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporan
    Friend WithEvents PramuRekapBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SatpamRekapBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalRekapTableAdapter As Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.TotalRekapTableAdapter
    Friend WithEvents PramuRekapTableAdapter As Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.PramuRekapTableAdapter
    Friend WithEvents SatpamRekapTableAdapter As Aplikasi_Penggajian_Karyawan_TA2016.DataSetLaporanTableAdapters.SatpamRekapTableAdapter
End Class
