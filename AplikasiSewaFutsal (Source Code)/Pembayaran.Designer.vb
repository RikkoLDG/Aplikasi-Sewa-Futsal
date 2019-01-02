<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembayaran))
        Me.berdasarkan = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnCetakTrans = New System.Windows.Forms.Button()
        Me.uang_muka = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.uang_bayar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.total_biaya = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gratis = New System.Windows.Forms.Label()
        Me.biaya_sewa_barang = New System.Windows.Forms.TextBox()
        Me.loker = New System.Windows.Forms.CheckBox()
        Me.kaos = New System.Windows.Forms.CheckBox()
        Me.sepatu = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.barang_sewa = New System.Windows.Forms.TextBox()
        Me.biaya_sewa_lapangan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idptgs = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tgl_pembayaran = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.caribooking = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.no_trans = New System.Windows.Forms.TextBox()
        Me.nama_lpgn = New System.Windows.Forms.TextBox()
        Me.kode_lpgn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nama_team = New System.Windows.Forms.TextBox()
        Me.kode_book = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolStripStatus1 = New System.Windows.Forms.StatusStrip()
        Me.LabelTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama_ptgs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripStatus1.SuspendLayout()
        Me.SuspendLayout()
        '
        'berdasarkan
        '
        Me.berdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.berdasarkan.FormattingEnabled = True
        Me.berdasarkan.Location = New System.Drawing.Point(99, 26)
        Me.berdasarkan.Margin = New System.Windows.Forms.Padding(4)
        Me.berdasarkan.Name = "berdasarkan"
        Me.berdasarkan.Size = New System.Drawing.Size(179, 25)
        Me.berdasarkan.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.BtnCetakTrans)
        Me.GroupBox3.Controls.Add(Me.uang_muka)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.kembalian)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.uang_bayar)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.total_biaya)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.biaya_sewa_lapangan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.idptgs)
        Me.GroupBox3.Location = New System.Drawing.Point(814, 187)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(305, 387)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Biaya Sewa"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(106, 237)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 30)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Hitung"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 145)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Uang Muka"
        '
        'BtnCetakTrans
        '
        Me.BtnCetakTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCetakTrans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCetakTrans.Image = CType(resources.GetObject("BtnCetakTrans.Image"), System.Drawing.Image)
        Me.BtnCetakTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetakTrans.Location = New System.Drawing.Point(15, 333)
        Me.BtnCetakTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCetakTrans.Name = "BtnCetakTrans"
        Me.BtnCetakTrans.Size = New System.Drawing.Size(275, 54)
        Me.BtnCetakTrans.TabIndex = 83
        Me.BtnCetakTrans.Text = "Cetak Bukti Pembayaran"
        Me.BtnCetakTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCetakTrans.UseVisualStyleBackColor = True
        '
        'uang_muka
        '
        Me.uang_muka.Location = New System.Drawing.Point(106, 142)
        Me.uang_muka.Margin = New System.Windows.Forms.Padding(4)
        Me.uang_muka.Name = "uang_muka"
        Me.uang_muka.Size = New System.Drawing.Size(182, 25)
        Me.uang_muka.TabIndex = 97
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 303)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Kembalian"
        '
        'kembalian
        '
        Me.kembalian.ForeColor = System.Drawing.Color.DarkRed
        Me.kembalian.Location = New System.Drawing.Point(106, 300)
        Me.kembalian.Margin = New System.Windows.Forms.Padding(4)
        Me.kembalian.Name = "kembalian"
        Me.kembalian.ReadOnly = True
        Me.kembalian.Size = New System.Drawing.Size(182, 25)
        Me.kembalian.TabIndex = 95
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 270)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 17)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Uang Bayar"
        '
        'uang_bayar
        '
        Me.uang_bayar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.uang_bayar.Location = New System.Drawing.Point(106, 270)
        Me.uang_bayar.Margin = New System.Windows.Forms.Padding(4)
        Me.uang_bayar.Name = "uang_bayar"
        Me.uang_bayar.Size = New System.Drawing.Size(182, 25)
        Me.uang_bayar.TabIndex = 93
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(114, 169)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Total Biaya"
        '
        'total_biaya
        '
        Me.total_biaya.BackColor = System.Drawing.SystemColors.Info
        Me.total_biaya.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_biaya.ForeColor = System.Drawing.Color.DarkRed
        Me.total_biaya.Location = New System.Drawing.Point(8, 190)
        Me.total_biaya.Margin = New System.Windows.Forms.Padding(4)
        Me.total_biaya.Name = "total_biaya"
        Me.total_biaya.ReadOnly = True
        Me.total_biaya.Size = New System.Drawing.Size(280, 39)
        Me.total_biaya.TabIndex = 91
        Me.total_biaya.Text = "TOTAL BIAYA"
        Me.total_biaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gratis)
        Me.GroupBox4.Controls.Add(Me.biaya_sewa_barang)
        Me.GroupBox4.Controls.Add(Me.loker)
        Me.GroupBox4.Controls.Add(Me.kaos)
        Me.GroupBox4.Controls.Add(Me.sepatu)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.barang_sewa)
        Me.GroupBox4.Location = New System.Drawing.Point(1, 54)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(368, 78)
        Me.GroupBox4.TabIndex = 85
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Penyewaan Tambahan"
        '
        'gratis
        '
        Me.gratis.AutoSize = True
        Me.gratis.BackColor = System.Drawing.Color.White
        Me.gratis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gratis.Location = New System.Drawing.Point(153, 49)
        Me.gratis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gratis.Name = "gratis"
        Me.gratis.Size = New System.Drawing.Size(52, 17)
        Me.gratis.TabIndex = 84
        Me.gratis.Text = "GRATIS"
        Me.gratis.Visible = False
        '
        'biaya_sewa_barang
        '
        Me.biaya_sewa_barang.Location = New System.Drawing.Point(149, 45)
        Me.biaya_sewa_barang.Margin = New System.Windows.Forms.Padding(4)
        Me.biaya_sewa_barang.Name = "biaya_sewa_barang"
        Me.biaya_sewa_barang.Size = New System.Drawing.Size(138, 25)
        Me.biaya_sewa_barang.TabIndex = 65
        '
        'loker
        '
        Me.loker.AutoSize = True
        Me.loker.Location = New System.Drawing.Point(49, 22)
        Me.loker.Margin = New System.Windows.Forms.Padding(4)
        Me.loker.Name = "loker"
        Me.loker.Size = New System.Drawing.Size(61, 21)
        Me.loker.TabIndex = 63
        Me.loker.Text = "Loker"
        Me.loker.UseVisualStyleBackColor = True
        '
        'kaos
        '
        Me.kaos.AutoSize = True
        Me.kaos.Location = New System.Drawing.Point(118, 22)
        Me.kaos.Margin = New System.Windows.Forms.Padding(4)
        Me.kaos.Name = "kaos"
        Me.kaos.Size = New System.Drawing.Size(102, 21)
        Me.kaos.TabIndex = 64
        Me.kaos.Text = "Jersey Team"
        Me.kaos.UseVisualStyleBackColor = True
        '
        'sepatu
        '
        Me.sepatu.AutoSize = True
        Me.sepatu.Location = New System.Drawing.Point(220, 22)
        Me.sepatu.Margin = New System.Windows.Forms.Padding(4)
        Me.sepatu.Name = "sepatu"
        Me.sepatu.Size = New System.Drawing.Size(69, 21)
        Me.sepatu.TabIndex = 65
        Me.sepatu.Text = "Sepatu"
        Me.sepatu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Biaya Sewa Barang"
        '
        'barang_sewa
        '
        Me.barang_sewa.Location = New System.Drawing.Point(149, 45)
        Me.barang_sewa.Margin = New System.Windows.Forms.Padding(4)
        Me.barang_sewa.Name = "barang_sewa"
        Me.barang_sewa.Size = New System.Drawing.Size(135, 25)
        Me.barang_sewa.TabIndex = 83
        Me.barang_sewa.Visible = False
        '
        'biaya_sewa_lapangan
        '
        Me.biaya_sewa_lapangan.Location = New System.Drawing.Point(150, 21)
        Me.biaya_sewa_lapangan.Margin = New System.Windows.Forms.Padding(4)
        Me.biaya_sewa_lapangan.Name = "biaya_sewa_lapangan"
        Me.biaya_sewa_lapangan.Size = New System.Drawing.Size(138, 25)
        Me.biaya_sewa_lapangan.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Biaya Sewa Lapangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 78
        '
        'idptgs
        '
        Me.idptgs.Location = New System.Drawing.Point(50, 349)
        Me.idptgs.Margin = New System.Windows.Forms.Padding(4)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(198, 25)
        Me.idptgs.TabIndex = 98
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn2.Location = New System.Drawing.Point(815, 127)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(88, 30)
        Me.Btn2.TabIndex = 45
        Me.Btn2.Text = "Button2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn3.Location = New System.Drawing.Point(908, 127)
        Me.Btn3.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(85, 30)
        Me.Btn3.TabIndex = 44
        Me.Btn3.Text = "Button3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(642, 1)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Status"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(675, 74)
        Me.status.Margin = New System.Windows.Forms.Padding(4)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(111, 25)
        Me.status.TabIndex = 79
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn1.Location = New System.Drawing.Point(815, 92)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(178, 30)
        Me.Btn1.TabIndex = 43
        Me.Btn1.Text = "Button1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tgl_pembayaran)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.caribooking)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.no_trans)
        Me.GroupBox1.Controls.Add(Me.nama_lpgn)
        Me.GroupBox1.Controls.Add(Me.kode_lpgn)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.nama_team)
        Me.GroupBox1.Controls.Add(Me.kode_book)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(794, 158)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Pembayaran"
        '
        'tgl_pembayaran
        '
        Me.tgl_pembayaran.Location = New System.Drawing.Point(635, 125)
        Me.tgl_pembayaran.Margin = New System.Windows.Forms.Padding(4)
        Me.tgl_pembayaran.Name = "tgl_pembayaran"
        Me.tgl_pembayaran.Size = New System.Drawing.Size(151, 25)
        Me.tgl_pembayaran.TabIndex = 83
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(635, 103)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 17)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Tanggal Pembayaran"
        '
        'caribooking
        '
        Me.caribooking.Image = CType(resources.GetObject("caribooking.Image"), System.Drawing.Image)
        Me.caribooking.Location = New System.Drawing.Point(139, 73)
        Me.caribooking.Margin = New System.Windows.Forms.Padding(4)
        Me.caribooking.Name = "caribooking"
        Me.caribooking.Size = New System.Drawing.Size(29, 26)
        Me.caribooking.TabIndex = 80
        Me.caribooking.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BtnCari)
        Me.GroupBox2.Controls.Add(Me.Cari)
        Me.GroupBox2.Controls.Add(Me.berdasarkan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 99)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(627, 59)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(590, 24)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 27)
        Me.Button2.TabIndex = 86
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(520, 24)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(61, 27)
        Me.BtnCari.TabIndex = 82
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(287, 26)
        Me.Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(228, 25)
        Me.Cari.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Berdasarkan"
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(520, 24)
        Me.dgv2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(61, 27)
        Me.dgv2.TabIndex = 85
        '
        'no_trans
        '
        Me.no_trans.Location = New System.Drawing.Point(140, 22)
        Me.no_trans.Margin = New System.Windows.Forms.Padding(4)
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Size = New System.Drawing.Size(216, 25)
        Me.no_trans.TabIndex = 77
        '
        'nama_lpgn
        '
        Me.nama_lpgn.Location = New System.Drawing.Point(499, 74)
        Me.nama_lpgn.Margin = New System.Windows.Forms.Padding(4)
        Me.nama_lpgn.Name = "nama_lpgn"
        Me.nama_lpgn.Size = New System.Drawing.Size(169, 25)
        Me.nama_lpgn.TabIndex = 74
        '
        'kode_lpgn
        '
        Me.kode_lpgn.Location = New System.Drawing.Point(365, 74)
        Me.kode_lpgn.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_lpgn.Name = "kode_lpgn"
        Me.kode_lpgn.Size = New System.Drawing.Size(127, 25)
        Me.kode_lpgn.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "No. Transaksi"
        '
        'nama_team
        '
        Me.nama_team.Location = New System.Drawing.Point(183, 74)
        Me.nama_team.Margin = New System.Windows.Forms.Padding(4)
        Me.nama_team.Name = "nama_team"
        Me.nama_team.Size = New System.Drawing.Size(174, 25)
        Me.nama_team.TabIndex = 18
        '
        'kode_book
        '
        Me.kode_book.Location = New System.Drawing.Point(31, 74)
        Me.kode_book.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_book.Name = "kode_book"
        Me.kode_book.Size = New System.Drawing.Size(107, 25)
        Me.kode_book.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(31, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 20)
        Me.Panel2.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(336, 1)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Kode Lapangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Booking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Team"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(469, 1)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 17)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Nama Lapangan"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(13, 254)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(793, 320)
        Me.dgv1.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 80)
        Me.Panel1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(615, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "No. Telp. (021) XXXX XXXX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(173, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(441, 17)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Jl. Ki Hajar Dewantara No. 40,Karang Asih , Cikarang Utara, Kab. Bekasi. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(169, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 30)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "VENY FUTSAL"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(161, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 63
        Me.PictureBox3.TabStop = False
        '
        'ToolStripStatus1
        '
        Me.ToolStripStatus1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelTgl, Me.LabelJam, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.userid, Me.ToolStripStatusLabel2, Me.nama_ptgs})
        Me.ToolStripStatus1.Location = New System.Drawing.Point(0, 578)
        Me.ToolStripStatus1.Name = "ToolStripStatus1"
        Me.ToolStripStatus1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ToolStripStatus1.Size = New System.Drawing.Size(1129, 25)
        Me.ToolStripStatus1.TabIndex = 84
        Me.ToolStripStatus1.Text = "Tanggal"
        '
        'LabelTgl
        '
        Me.LabelTgl.Image = CType(resources.GetObject("LabelTgl.Image"), System.Drawing.Image)
        Me.LabelTgl.Name = "LabelTgl"
        Me.LabelTgl.Size = New System.Drawing.Size(66, 20)
        Me.LabelTgl.Text = "Tanggal"
        '
        'LabelJam
        '
        Me.LabelJam.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LabelJam.Image = CType(resources.GetObject("LabelJam.Image"), System.Drawing.Image)
        Me.LabelJam.Name = "LabelJam"
        Me.LabelJam.Size = New System.Drawing.Size(48, 20)
        Me.LabelJam.Text = "Jam"
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
        'Timer1
        '
        '
        'BtnMenu
        '
        Me.BtnMenu.BackgroundImage = CType(resources.GetObject("BtnMenu.BackgroundImage"), System.Drawing.Image)
        Me.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnMenu.Location = New System.Drawing.Point(1000, 92)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(119, 76)
        Me.BtnMenu.TabIndex = 83
        Me.BtnMenu.Text = "Menu Awal"
        Me.BtnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 603)
        Me.Controls.Add(Me.ToolStripStatus1)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripStatus1.ResumeLayout(False)
        Me.ToolStripStatus1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents berdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nama_team As System.Windows.Forms.TextBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kode_book As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sepatu As System.Windows.Forms.CheckBox
    Friend WithEvents kaos As System.Windows.Forms.CheckBox
    Friend WithEvents loker As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents biaya_sewa_barang As System.Windows.Forms.TextBox
    Friend WithEvents no_trans As System.Windows.Forms.TextBox
    Friend WithEvents nama_lpgn As System.Windows.Forms.TextBox
    Friend WithEvents kode_lpgn As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents barang_sewa As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents biaya_sewa_lapangan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents kembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents uang_bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents total_biaya As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents gratis As System.Windows.Forms.Label
    Friend WithEvents caribooking As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents BtnCetakTrans As System.Windows.Forms.Button
    Friend WithEvents BtnMenu As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents uang_muka As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatus1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelTgl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents userid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama_ptgs As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents idptgs As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tgl_pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label



    
End Class
