<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.notelp = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.nonmember = New System.Windows.Forms.CheckBox()
        Me.member = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.carimember = New System.Windows.Forms.Button()
        Me.nama_team = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kode_book = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tanggal_book = New System.Windows.Forms.TextBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.berdasarkan = New System.Windows.Forms.ComboBox()
        Me.tanggal_sewa = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cek = New System.Windows.Forms.Button()
        Me.carilapangan = New System.Windows.Forms.Button()
        Me.kode_lpgn = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.idptgs = New System.Windows.Forms.TextBox()
        Me.kode_member = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uang_muka = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jam_masuk = New System.Windows.Forms.DateTimePicker()
        Me.jam_keluar = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lama_sewa = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.harga_sewa_total = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.harga_awal = New System.Windows.Forms.TextBox()
        Me.ToolStripStatus1 = New System.Windows.Forms.StatusStrip()
        Me.LabelTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama_ptgs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStripStatus1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Btn3)
        Me.GroupBox1.Controls.Add(Me.Btn2)
        Me.GroupBox1.Controls.Add(Me.notelp)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.nonmember)
        Me.GroupBox1.Controls.Add(Me.member)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.carimember)
        Me.GroupBox1.Controls.Add(Me.nama_team)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Btn1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.kode_book)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tanggal_book)
        Me.GroupBox1.Controls.Add(Me.Btn4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(367, 225)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking Lapangan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(56, 160)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 17)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "No. Telp"
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn3.Image = CType(resources.GetObject("Btn3.Image"), System.Drawing.Image)
        Me.Btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn3.Location = New System.Drawing.Point(249, 189)
        Me.Btn3.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(93, 30)
        Me.Btn3.TabIndex = 44
        Me.Btn3.Text = "Button3"
        Me.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn2.Image = CType(resources.GetObject("Btn2.Image"), System.Drawing.Image)
        Me.Btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn2.Location = New System.Drawing.Point(139, 188)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(102, 30)
        Me.Btn2.TabIndex = 45
        Me.Btn2.Text = "Button2"
        Me.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'notelp
        '
        Me.notelp.Location = New System.Drawing.Point(139, 157)
        Me.notelp.Margin = New System.Windows.Forms.Padding(4)
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(203, 25)
        Me.notelp.TabIndex = 64
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(250, 106)
        Me.status.Margin = New System.Windows.Forms.Padding(4)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(93, 25)
        Me.status.TabIndex = 63
        Me.status.Visible = False
        '
        'nonmember
        '
        Me.nonmember.AutoSize = True
        Me.nonmember.Location = New System.Drawing.Point(235, 134)
        Me.nonmember.Margin = New System.Windows.Forms.Padding(4)
        Me.nonmember.Name = "nonmember"
        Me.nonmember.Size = New System.Drawing.Size(108, 21)
        Me.nonmember.TabIndex = 62
        Me.nonmember.Text = "Non Member"
        Me.nonmember.UseVisualStyleBackColor = True
        '
        'member
        '
        Me.member.AutoSize = True
        Me.member.Location = New System.Drawing.Point(140, 134)
        Me.member.Margin = New System.Windows.Forms.Padding(4)
        Me.member.Name = "member"
        Me.member.Size = New System.Drawing.Size(78, 21)
        Me.member.TabIndex = 61
        Me.member.Text = "Member"
        Me.member.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Tanggal Booking"
        '
        'carimember
        '
        Me.carimember.Image = CType(resources.GetObject("carimember.Image"), System.Drawing.Image)
        Me.carimember.Location = New System.Drawing.Point(304, 77)
        Me.carimember.Margin = New System.Windows.Forms.Padding(4)
        Me.carimember.Name = "carimember"
        Me.carimember.Size = New System.Drawing.Size(39, 27)
        Me.carimember.TabIndex = 46
        Me.carimember.UseVisualStyleBackColor = True
        '
        'nama_team
        '
        Me.nama_team.Location = New System.Drawing.Point(140, 106)
        Me.nama_team.Margin = New System.Windows.Forms.Padding(4)
        Me.nama_team.Name = "nama_team"
        Me.nama_team.Size = New System.Drawing.Size(203, 25)
        Me.nama_team.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status"
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn1.Location = New System.Drawing.Point(8, 188)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(119, 30)
        Me.Btn1.TabIndex = 43
        Me.Btn1.Text = "Button1"
        Me.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Team"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(140, 78)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(161, 25)
        Me.nama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Atas Nama"
        '
        'kode_book
        '
        Me.kode_book.Location = New System.Drawing.Point(140, 21)
        Me.kode_book.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_book.Name = "kode_book"
        Me.kode_book.Size = New System.Drawing.Size(95, 25)
        Me.kode_book.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Booking"
        '
        'tanggal_book
        '
        Me.tanggal_book.Location = New System.Drawing.Point(140, 50)
        Me.tanggal_book.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggal_book.Name = "tanggal_book"
        Me.tanggal_book.Size = New System.Drawing.Size(202, 25)
        Me.tanggal_book.TabIndex = 60
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Image = CType(resources.GetObject("Btn4.Image"), System.Drawing.Image)
        Me.Btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn4.Location = New System.Drawing.Point(249, 188)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(93, 30)
        Me.Btn4.TabIndex = 66
        Me.Btn4.Text = "Button4"
        Me.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Berdasarkan"
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(243, 21)
        Me.Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(257, 25)
        Me.Cari.TabIndex = 8
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(11, 341)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(740, 223)
        Me.dgv1.TabIndex = 49
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BtnCari)
        Me.GroupBox2.Controls.Add(Me.Cari)
        Me.GroupBox2.Controls.Add(Me.berdasarkan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 281)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(619, 52)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(578, 19)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 27)
        Me.Button3.TabIndex = 82
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(509, 19)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(61, 27)
        Me.BtnCari.TabIndex = 81
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'berdasarkan
        '
        Me.berdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.berdasarkan.FormattingEnabled = True
        Me.berdasarkan.Location = New System.Drawing.Point(97, 21)
        Me.berdasarkan.Margin = New System.Windows.Forms.Padding(4)
        Me.berdasarkan.Name = "berdasarkan"
        Me.berdasarkan.Size = New System.Drawing.Size(138, 25)
        Me.berdasarkan.TabIndex = 8
        '
        'tanggal_sewa
        '
        Me.tanggal_sewa.CustomFormat = "yyyy-MM-dd"
        Me.tanggal_sewa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggal_sewa.Location = New System.Drawing.Point(244, 16)
        Me.tanggal_sewa.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggal_sewa.Name = "tanggal_sewa"
        Me.tanggal_sewa.Size = New System.Drawing.Size(104, 25)
        Me.tanggal_sewa.TabIndex = 64
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cek)
        Me.GroupBox3.Controls.Add(Me.carilapangan)
        Me.GroupBox3.Controls.Add(Me.kode_lpgn)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lama_sewa)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.harga_sewa_total)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.harga_awal)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(385, 57)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(365, 225)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilihan Lapangan"
        '
        'cek
        '
        Me.cek.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek.Location = New System.Drawing.Point(304, 76)
        Me.cek.Margin = New System.Windows.Forms.Padding(4)
        Me.cek.Name = "cek"
        Me.cek.Size = New System.Drawing.Size(39, 27)
        Me.cek.TabIndex = 80
        Me.cek.Text = "Cek"
        Me.cek.UseVisualStyleBackColor = True
        '
        'carilapangan
        '
        Me.carilapangan.Image = CType(resources.GetObject("carilapangan.Image"), System.Drawing.Image)
        Me.carilapangan.Location = New System.Drawing.Point(304, 20)
        Me.carilapangan.Margin = New System.Windows.Forms.Padding(4)
        Me.carilapangan.Name = "carilapangan"
        Me.carilapangan.Size = New System.Drawing.Size(39, 27)
        Me.carilapangan.TabIndex = 80
        Me.carilapangan.UseVisualStyleBackColor = True
        '
        'kode_lpgn
        '
        Me.kode_lpgn.Location = New System.Drawing.Point(140, 21)
        Me.kode_lpgn.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_lpgn.Name = "kode_lpgn"
        Me.kode_lpgn.Size = New System.Drawing.Size(161, 25)
        Me.kode_lpgn.TabIndex = 79
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.idptgs)
        Me.GroupBox4.Controls.Add(Me.kode_member)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.uang_muka)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tanggal_sewa)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.jam_masuk)
        Me.GroupBox4.Controls.Add(Me.jam_keluar)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(365, 118)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Waktu"
        '
        'idptgs
        '
        Me.idptgs.Location = New System.Drawing.Point(231, 82)
        Me.idptgs.Margin = New System.Windows.Forms.Padding(4)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(117, 25)
        Me.idptgs.TabIndex = 82
        '
        'kode_member
        '
        Me.kode_member.Location = New System.Drawing.Point(105, 82)
        Me.kode_member.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_member.Name = "kode_member"
        Me.kode_member.Size = New System.Drawing.Size(118, 25)
        Me.kode_member.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Kode Member"
        '
        'uang_muka
        '
        Me.uang_muka.Location = New System.Drawing.Point(105, 49)
        Me.uang_muka.Margin = New System.Windows.Forms.Padding(4)
        Me.uang_muka.Name = "uang_muka"
        Me.uang_muka.Size = New System.Drawing.Size(243, 25)
        Me.uang_muka.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Uang Muka"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(176, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Tgl Sewa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Jam Masuk"
        '
        'jam_masuk
        '
        Me.jam_masuk.CustomFormat = "HH:mm"
        Me.jam_masuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.jam_masuk.Location = New System.Drawing.Point(105, 16)
        Me.jam_masuk.Margin = New System.Windows.Forms.Padding(4)
        Me.jam_masuk.Name = "jam_masuk"
        Me.jam_masuk.ShowUpDown = True
        Me.jam_masuk.Size = New System.Drawing.Size(63, 25)
        Me.jam_masuk.TabIndex = 69
        Me.jam_masuk.Value = New Date(2017, 7, 30, 12, 0, 0, 0)
        '
        'jam_keluar
        '
        Me.jam_keluar.CustomFormat = "HH:mm"
        Me.jam_keluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.jam_keluar.Location = New System.Drawing.Point(105, 16)
        Me.jam_keluar.Margin = New System.Windows.Forms.Padding(4)
        Me.jam_keluar.Name = "jam_keluar"
        Me.jam_keluar.ShowUpDown = True
        Me.jam_keluar.Size = New System.Drawing.Size(63, 25)
        Me.jam_keluar.TabIndex = 79
        Me.jam_keluar.Value = New Date(2017, 7, 30, 12, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 17)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Harga Sewa Total"
        '
        'lama_sewa
        '
        Me.lama_sewa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lama_sewa.FormattingEnabled = True
        Me.lama_sewa.Location = New System.Drawing.Point(140, 49)
        Me.lama_sewa.Margin = New System.Windows.Forms.Padding(4)
        Me.lama_sewa.Name = "lama_sewa"
        Me.lama_sewa.Size = New System.Drawing.Size(161, 25)
        Me.lama_sewa.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 17)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Lama Sewa / Jam"
        '
        'harga_sewa_total
        '
        Me.harga_sewa_total.Location = New System.Drawing.Point(140, 77)
        Me.harga_sewa_total.Margin = New System.Windows.Forms.Padding(4)
        Me.harga_sewa_total.Name = "harga_sewa_total"
        Me.harga_sewa_total.Size = New System.Drawing.Size(161, 25)
        Me.harga_sewa_total.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 17)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Kode Lapangan"
        '
        'harga_awal
        '
        Me.harga_awal.Location = New System.Drawing.Point(184, 77)
        Me.harga_awal.Margin = New System.Windows.Forms.Padding(4)
        Me.harga_awal.Name = "harga_awal"
        Me.harga_awal.Size = New System.Drawing.Size(117, 25)
        Me.harga_awal.TabIndex = 81
        '
        'ToolStripStatus1
        '
        Me.ToolStripStatus1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelTgl, Me.LabelJam, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.userid, Me.ToolStripStatusLabel2, Me.nama_ptgs})
        Me.ToolStripStatus1.Location = New System.Drawing.Point(0, 569)
        Me.ToolStripStatus1.Name = "ToolStripStatus1"
        Me.ToolStripStatus1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ToolStripStatus1.Size = New System.Drawing.Size(763, 25)
        Me.ToolStripStatus1.TabIndex = 65
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 60)
        Me.Panel1.TabIndex = 68
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(173, 36)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(441, 17)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Jl. Ki Hajar Dewantara No. 40,Karang Asih , Cikarang Utara, Kab. Bekasi. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(169, 3)
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
        'BtnMenu
        '
        Me.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMenu.Location = New System.Drawing.Point(638, 289)
        Me.BtnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(113, 44)
        Me.BtnMenu.TabIndex = 83
        Me.BtnMenu.Text = "Menu Awal"
        Me.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 594)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripStatus1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStripStatus1.ResumeLayout(False)
        Me.ToolStripStatus1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nama_team As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents kode_book As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents berdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents carimember As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents uang_muka As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tanggal_sewa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents jam_masuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents nonmember As System.Windows.Forms.CheckBox
    Friend WithEvents member As System.Windows.Forms.CheckBox
    Friend WithEvents lama_sewa As System.Windows.Forms.ComboBox
    Friend WithEvents harga_sewa_total As System.Windows.Forms.TextBox
    Friend WithEvents jam_keluar As System.Windows.Forms.DateTimePicker
    Friend WithEvents cek As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents notelp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents carilapangan As System.Windows.Forms.Button
    Friend WithEvents kode_lpgn As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatus1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelTgl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents userid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents idptgs As System.Windows.Forms.TextBox
    Friend WithEvents kode_member As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tanggal_book As System.Windows.Forms.TextBox
    Friend WithEvents BtnMenu As System.Windows.Forms.Button
    Friend WithEvents harga_awal As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama_ptgs As System.Windows.Forms.ToolStripStatusLabel
End Class
