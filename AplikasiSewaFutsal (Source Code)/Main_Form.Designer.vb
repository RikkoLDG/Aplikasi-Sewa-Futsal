<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiSewaFutsalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanJadwalBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("SAO UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.label, Me.userid, Me.username})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(885, 37)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'label
        '
        Me.label.Font = New System.Drawing.Font("SAO UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(145, 32)
        Me.label.Text = "Welcome User :"
        '
        'userid
        '
        Me.userid.Font = New System.Drawing.Font("SAO UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(218, 32)
        Me.userid.Text = "ToolStripStatusLabel1"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("SAO UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(218, 32)
        Me.username.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Font = New System.Drawing.Font("SAO UI TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.TransaksiSewaFutsalToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 34)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPetugasToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataBookingToolStripMenuItem, Me.PengaturanUserToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Image = CType(resources.GetObject("MasterDataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(120, 30)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataPetugasToolStripMenuItem
        '
        Me.DataPetugasToolStripMenuItem.Image = CType(resources.GetObject("DataPetugasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataPetugasToolStripMenuItem.Name = "DataPetugasToolStripMenuItem"
        Me.DataPetugasToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.DataPetugasToolStripMenuItem.Text = "Data Petugas"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Image = CType(resources.GetObject("DataPelangganToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.DataPelangganToolStripMenuItem.Text = "Data Member Futsal"
        '
        'DataBookingToolStripMenuItem
        '
        Me.DataBookingToolStripMenuItem.Image = CType(resources.GetObject("DataBookingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataBookingToolStripMenuItem.Name = "DataBookingToolStripMenuItem"
        Me.DataBookingToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.DataBookingToolStripMenuItem.Text = "Data Booking"
        '
        'PengaturanUserToolStripMenuItem
        '
        Me.PengaturanUserToolStripMenuItem.Image = CType(resources.GetObject("PengaturanUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PengaturanUserToolStripMenuItem.Name = "PengaturanUserToolStripMenuItem"
        Me.PengaturanUserToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.PengaturanUserToolStripMenuItem.Text = "Pengaturan User"
        '
        'TransaksiSewaFutsalToolStripMenuItem
        '
        Me.TransaksiSewaFutsalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPembayaranToolStripMenuItem})
        Me.TransaksiSewaFutsalToolStripMenuItem.Image = CType(resources.GetObject("TransaksiSewaFutsalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiSewaFutsalToolStripMenuItem.Name = "TransaksiSewaFutsalToolStripMenuItem"
        Me.TransaksiSewaFutsalToolStripMenuItem.Size = New System.Drawing.Size(186, 30)
        Me.TransaksiSewaFutsalToolStripMenuItem.Text = "Transaksi Sewa Futsal"
        '
        'TransaksiPembayaranToolStripMenuItem
        '
        Me.TransaksiPembayaranToolStripMenuItem.Image = CType(resources.GetObject("TransaksiPembayaranToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiPembayaranToolStripMenuItem.Name = "TransaksiPembayaranToolStripMenuItem"
        Me.TransaksiPembayaranToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.TransaksiPembayaranToolStripMenuItem.Text = "Transaksi Pembayaran"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanJadwalBookingToolStripMenuItem, Me.LaporanPenyewaanToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Image = CType(resources.GetObject("ReportingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(102, 30)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'LaporanJadwalBookingToolStripMenuItem
        '
        Me.LaporanJadwalBookingToolStripMenuItem.Name = "LaporanJadwalBookingToolStripMenuItem"
        Me.LaporanJadwalBookingToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.LaporanJadwalBookingToolStripMenuItem.Text = "Laporan Jadwal Booking"
        '
        'LaporanPenyewaanToolStripMenuItem
        '
        Me.LaporanPenyewaanToolStripMenuItem.Name = "LaporanPenyewaanToolStripMenuItem"
        Me.LaporanPenyewaanToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.LaporanPenyewaanToolStripMenuItem.Text = "Laporan Penyewaan"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 30)
        Me.AboutToolStripMenuItem.Text = "Tentang Aplikasi"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(90, 30)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 81)
        Me.Panel1.TabIndex = 0
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 499)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM UTAMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents userid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents username As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiSewaFutsalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiPembayaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengaturanUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanJadwalBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenyewaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
