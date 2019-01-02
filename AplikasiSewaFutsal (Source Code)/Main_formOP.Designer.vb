<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_formOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_formOP))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.berdasarkan = New System.Windows.Forms.ComboBox()
        Me.tanggal_sewa = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.ToolStripStatus1 = New System.Windows.Forms.StatusStrip()
        Me.LabelTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama_ptgs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupAlarm = New System.Windows.Forms.GroupBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Detik = New System.Windows.Forms.NumericUpDown()
        Me.Jam = New System.Windows.Forms.NumericUpDown()
        Me.Menit = New System.Windows.Forms.NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtJudul = New System.Windows.Forms.TextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtAktif = New System.Windows.Forms.Label()
        Me.MenuAdmin = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MenuAlarm = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTime = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.MenuLaporan = New System.Windows.Forms.Button()
        Me.MenuLapangan = New System.Windows.Forms.Button()
        Me.MenuMember = New System.Windows.Forms.Button()
        Me.MenuBooking = New System.Windows.Forms.Button()
        Me.MenuTransaksi = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStripStatus1.SuspendLayout()
        Me.GroupAlarm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Detik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(327, 182)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(550, 203)
        Me.dgv1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRefresh)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.berdasarkan)
        Me.GroupBox1.Controls.Add(Me.tanggal_sewa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Cari)
        Me.GroupBox1.Controls.Add(Me.BtnCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(327, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 86)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jadwal Sewa Lapangan"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(342, 52)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(38, 27)
        Me.BtnRefresh.TabIndex = 68
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 17)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Berdasarkan"
        '
        'berdasarkan
        '
        Me.berdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.berdasarkan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berdasarkan.FormattingEnabled = True
        Me.berdasarkan.Location = New System.Drawing.Point(96, 21)
        Me.berdasarkan.Margin = New System.Windows.Forms.Padding(4)
        Me.berdasarkan.Name = "berdasarkan"
        Me.berdasarkan.Size = New System.Drawing.Size(163, 25)
        Me.berdasarkan.TabIndex = 66
        '
        'tanggal_sewa
        '
        Me.tanggal_sewa.CustomFormat = "yyyy-MM-dd"
        Me.tanggal_sewa.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tanggal_sewa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggal_sewa.Location = New System.Drawing.Point(392, 18)
        Me.tanggal_sewa.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggal_sewa.Name = "tanggal_sewa"
        Me.tanggal_sewa.Size = New System.Drawing.Size(123, 25)
        Me.tanggal_sewa.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pilih Tanggal"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(383, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 27)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cetak Jadwal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Cari
        '
        Me.Cari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cari.Location = New System.Drawing.Point(7, 53)
        Me.Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(252, 25)
        Me.Cari.TabIndex = 17
        '
        'BtnCari
        '
        Me.BtnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(262, 52)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(77, 27)
        Me.BtnCari.TabIndex = 16
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'ToolStripStatus1
        '
        Me.ToolStripStatus1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ToolStripStatus1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelTgl, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.userid, Me.ToolStripStatusLabel2, Me.nama_ptgs})
        Me.ToolStripStatus1.Location = New System.Drawing.Point(0, 525)
        Me.ToolStripStatus1.Name = "ToolStripStatus1"
        Me.ToolStripStatus1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ToolStripStatus1.Size = New System.Drawing.Size(892, 25)
        Me.ToolStripStatus1.TabIndex = 66
        Me.ToolStripStatus1.Text = "Tanggal"
        '
        'LabelTgl
        '
        Me.LabelTgl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LabelTgl.Image = CType(resources.GetObject("LabelTgl.Image"), System.Drawing.Image)
        Me.LabelTgl.Name = "LabelTgl"
        Me.LabelTgl.Size = New System.Drawing.Size(70, 20)
        Me.LabelTgl.Text = "Tanggal"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripStatusLabel1.Text = "User ID :"
        '
        'userid
        '
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(50, 20)
        Me.userid.Text = "*idptgs*"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripStatusLabel2.Text = "Operator :"
        '
        'nama_ptgs
        '
        Me.nama_ptgs.Name = "nama_ptgs"
        Me.nama_ptgs.Size = New System.Drawing.Size(75, 20)
        Me.nama_ptgs.Text = "*nama_ptgs*"
        '
        'GroupAlarm
        '
        Me.GroupAlarm.Controls.Add(Me.lblstatus)
        Me.GroupAlarm.Controls.Add(Me.TabControl1)
        Me.GroupAlarm.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAlarm.Location = New System.Drawing.Point(157, 169)
        Me.GroupAlarm.Name = "GroupAlarm"
        Me.GroupAlarm.Size = New System.Drawing.Size(164, 213)
        Me.GroupAlarm.TabIndex = 15
        Me.GroupAlarm.TabStop = False
        Me.GroupAlarm.Text = "Pasang Alarm"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblstatus.Location = New System.Drawing.Point(104, 21)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(54, 13)
        Me.lblstatus.TabIndex = 7
        Me.lblstatus.Text = "ON/OFF"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TabControl1.Location = New System.Drawing.Point(7, 39)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(151, 174)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(143, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Time"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(6, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 29)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "TUTUP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(6, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "SET ALARM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(48, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Set Alarm"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Detik)
        Me.GroupBox3.Controls.Add(Me.Jam)
        Me.GroupBox3.Controls.Add(Me.Menit)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 53)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(83, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Detik"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Menit"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Jam"
        '
        'Detik
        '
        Me.Detik.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detik.Location = New System.Drawing.Point(84, 12)
        Me.Detik.Name = "Detik"
        Me.Detik.Size = New System.Drawing.Size(34, 25)
        Me.Detik.TabIndex = 2
        '
        'Jam
        '
        Me.Jam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam.Location = New System.Drawing.Point(6, 12)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(34, 25)
        Me.Jam.TabIndex = 0
        '
        'Menit
        '
        Me.Menit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menit.Location = New System.Drawing.Point(45, 12)
        Me.Menit.Name = "Menit"
        Me.Menit.Size = New System.Drawing.Size(34, 25)
        Me.Menit.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.BtnPlay)
        Me.TabPage2.Controls.Add(Me.TxtLocation)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.TxtJudul)
        Me.TabPage2.Controls.Add(Me.BtnOpen)
        Me.TabPage2.Controls.Add(Me.BtnSimpan)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(143, 144)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sound"
        '
        'BtnPlay
        '
        Me.BtnPlay.ForeColor = System.Drawing.Color.Black
        Me.BtnPlay.Image = CType(resources.GetObject("BtnPlay.Image"), System.Drawing.Image)
        Me.BtnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPlay.Location = New System.Drawing.Point(8, 91)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(129, 24)
        Me.BtnPlay.TabIndex = 9
        Me.BtnPlay.Text = "Test Sound"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'TxtLocation
        '
        Me.TxtLocation.Location = New System.Drawing.Point(9, 62)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.ReadOnly = True
        Me.TxtLocation.Size = New System.Drawing.Size(97, 25)
        Me.TxtLocation.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Location"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Name"
        '
        'TxtJudul
        '
        Me.TxtJudul.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtJudul.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJudul.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtJudul.Location = New System.Drawing.Point(9, 21)
        Me.TxtJudul.Multiline = True
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(128, 20)
        Me.TxtJudul.TabIndex = 1
        Me.TxtJudul.Text = """"""
        '
        'BtnOpen
        '
        Me.BtnOpen.ForeColor = System.Drawing.Color.Black
        Me.BtnOpen.Location = New System.Drawing.Point(112, 62)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(25, 23)
        Me.BtnOpen.TabIndex = 0
        Me.BtnOpen.Text = "..."
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.ForeColor = System.Drawing.Color.Black
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(8, 116)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(129, 24)
        Me.BtnSimpan.TabIndex = 2
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(275, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Booking Lapangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(425, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tambah Member"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(555, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lihat Laporan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(151, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Data Lapangan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(671, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Log Out"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(154, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 91)
        Me.Panel2.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(207, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "No. Telp. (021) XXXX XXXX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(207, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(420, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Jl. Inspeksi Kalimalang, Cikarang Pusat, Jawa Barat, Kode Pos : 17530"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(205, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PELITA FUTSAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtAktif)
        Me.GroupBox4.Controls.Add(Me.MenuAdmin)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.MenuAlarm)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.TxtTime)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox4.Location = New System.Drawing.Point(157, 90)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 292)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "JAM"
        '
        'TxtAktif
        '
        Me.TxtAktif.AutoSize = True
        Me.TxtAktif.BackColor = System.Drawing.Color.Transparent
        Me.TxtAktif.ForeColor = System.Drawing.Color.Black
        Me.TxtAktif.Location = New System.Drawing.Point(76, 59)
        Me.TxtAktif.Name = "TxtAktif"
        Me.TxtAktif.Size = New System.Drawing.Size(20, 17)
        Me.TxtAktif.TabIndex = 20
        Me.TxtAktif.Text = """"""
        '
        'MenuAdmin
        '
        Me.MenuAdmin.BackgroundImage = CType(resources.GetObject("MenuAdmin.BackgroundImage"), System.Drawing.Image)
        Me.MenuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MenuAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAdmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuAdmin.Location = New System.Drawing.Point(8, 118)
        Me.MenuAdmin.Name = "MenuAdmin"
        Me.MenuAdmin.Size = New System.Drawing.Size(150, 65)
        Me.MenuAdmin.TabIndex = 18
        Me.MenuAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuAdmin.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(47, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Data Petugas"
        '
        'MenuAlarm
        '
        Me.MenuAlarm.BackgroundImage = CType(resources.GetObject("MenuAlarm.BackgroundImage"), System.Drawing.Image)
        Me.MenuAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuAlarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MenuAlarm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAlarm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuAlarm.Location = New System.Drawing.Point(8, 206)
        Me.MenuAlarm.Name = "MenuAlarm"
        Me.MenuAlarm.Size = New System.Drawing.Size(150, 65)
        Me.MenuAlarm.TabIndex = 18
        Me.MenuAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuAlarm.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(28, 275)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pasang Alarm Pengingat"
        '
        'TxtTime
        '
        Me.TxtTime.AutoSize = True
        Me.TxtTime.BackColor = System.Drawing.Color.Transparent
        Me.TxtTime.Font = New System.Drawing.Font("SAO Welcome Another TT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTime.Location = New System.Drawing.Point(20, 18)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.Size = New System.Drawing.Size(131, 38)
        Me.TxtTime.TabIndex = 4
        Me.TxtTime.Text = "00 : 00 : 00"
        Me.TxtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 525)
        Me.Panel1.TabIndex = 67
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.LogOut)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.MenuLaporan)
        Me.Panel3.Controls.Add(Me.MenuLapangan)
        Me.Panel3.Controls.Add(Me.MenuMember)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.MenuBooking)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.MenuTransaksi)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(154, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(738, 121)
        Me.Panel3.TabIndex = 68
        '
        'LogOut
        '
        Me.LogOut.BackgroundImage = CType(resources.GetObject("LogOut.BackgroundImage"), System.Drawing.Image)
        Me.LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LogOut.Location = New System.Drawing.Point(663, 3)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(72, 65)
        Me.LogOut.TabIndex = 18
        Me.LogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LogOut.UseVisualStyleBackColor = True
        '
        'MenuLaporan
        '
        Me.MenuLaporan.BackgroundImage = CType(resources.GetObject("MenuLaporan.BackgroundImage"), System.Drawing.Image)
        Me.MenuLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuLaporan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLaporan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuLaporan.Location = New System.Drawing.Point(532, 3)
        Me.MenuLaporan.Name = "MenuLaporan"
        Me.MenuLaporan.Size = New System.Drawing.Size(125, 65)
        Me.MenuLaporan.TabIndex = 10
        Me.MenuLaporan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuLaporan.UseVisualStyleBackColor = True
        '
        'MenuLapangan
        '
        Me.MenuLapangan.BackgroundImage = CType(resources.GetObject("MenuLapangan.BackgroundImage"), System.Drawing.Image)
        Me.MenuLapangan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuLapangan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuLapangan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLapangan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuLapangan.Location = New System.Drawing.Point(135, 3)
        Me.MenuLapangan.Name = "MenuLapangan"
        Me.MenuLapangan.Size = New System.Drawing.Size(123, 65)
        Me.MenuLapangan.TabIndex = 16
        Me.MenuLapangan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuLapangan.UseVisualStyleBackColor = True
        '
        'MenuMember
        '
        Me.MenuMember.BackgroundImage = CType(resources.GetObject("MenuMember.BackgroundImage"), System.Drawing.Image)
        Me.MenuMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuMember.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMember.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuMember.Location = New System.Drawing.Point(6, 3)
        Me.MenuMember.Name = "MenuMember"
        Me.MenuMember.Size = New System.Drawing.Size(123, 65)
        Me.MenuMember.TabIndex = 2
        Me.MenuMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuMember.UseVisualStyleBackColor = True
        '
        'MenuBooking
        '
        Me.MenuBooking.BackgroundImage = CType(resources.GetObject("MenuBooking.BackgroundImage"), System.Drawing.Image)
        Me.MenuBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuBooking.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBooking.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuBooking.Location = New System.Drawing.Point(264, 3)
        Me.MenuBooking.Name = "MenuBooking"
        Me.MenuBooking.Size = New System.Drawing.Size(128, 65)
        Me.MenuBooking.TabIndex = 3
        Me.MenuBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuBooking.UseVisualStyleBackColor = True
        '
        'MenuTransaksi
        '
        Me.MenuTransaksi.BackgroundImage = CType(resources.GetObject("MenuTransaksi.BackgroundImage"), System.Drawing.Image)
        Me.MenuTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuTransaksi.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTransaksi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuTransaksi.Location = New System.Drawing.Point(398, 3)
        Me.MenuTransaksi.Name = "MenuTransaksi"
        Me.MenuTransaksi.Size = New System.Drawing.Size(128, 65)
        Me.MenuTransaksi.TabIndex = 7
        Me.MenuTransaksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuTransaksi.UseVisualStyleBackColor = True
        '
        'Main_formOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 550)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripStatus1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupAlarm)
        Me.Name = "Main_formOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStripStatus1.ResumeLayout(False)
        Me.ToolStripStatus1.PerformLayout()
        Me.GroupAlarm.ResumeLayout(False)
        Me.GroupAlarm.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Detik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tanggal_sewa As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripStatus1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelTgl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents userid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama_ptgs As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupAlarm As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Detik As System.Windows.Forms.NumericUpDown
    Friend WithEvents Jam As System.Windows.Forms.NumericUpDown
    Friend WithEvents Menit As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TxtJudul As System.Windows.Forms.TextBox
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuTransaksi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuBooking As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuMember As System.Windows.Forms.Button
    Friend WithEvents MenuLapangan As System.Windows.Forms.Button
    Friend WithEvents MenuLaporan As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTime As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents MenuAdmin As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MenuAlarm As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TxtAktif As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LogOut As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents berdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
