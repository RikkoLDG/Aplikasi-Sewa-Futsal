<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrPelanggan))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.berdasarkan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.notelp = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.nama_team = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kode_member = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Cetak = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.ToolStripStatus1 = New System.Windows.Forms.StatusStrip()
        Me.LabelTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama_ptgs = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripStatus1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label5.Location = New System.Drawing.Point(17, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. Telepon"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(379, 84)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(582, 359)
        Me.dgv1.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cari)
        Me.GroupBox2.Controls.Add(Me.BtnCari)
        Me.GroupBox2.Controls.Add(Me.berdasarkan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(482, -1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(479, 80)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'Cari
        '
        Me.Cari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cari.Location = New System.Drawing.Point(39, 48)
        Me.Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(266, 25)
        Me.Cari.TabIndex = 15
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(313, 48)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(77, 25)
        Me.BtnCari.TabIndex = 9
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'berdasarkan
        '
        Me.berdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.berdasarkan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berdasarkan.FormattingEnabled = True
        Me.berdasarkan.Location = New System.Drawing.Point(126, 14)
        Me.berdasarkan.Margin = New System.Windows.Forms.Padding(4)
        Me.berdasarkan.Name = "berdasarkan"
        Me.berdasarkan.Size = New System.Drawing.Size(179, 25)
        Me.berdasarkan.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label6.Location = New System.Drawing.Point(35, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Berdasarkan"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.notelp)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.nama_team)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.kode_member)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 272)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambahkan Member"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'notelp
        '
        Me.notelp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notelp.Location = New System.Drawing.Point(140, 235)
        Me.notelp.Margin = New System.Windows.Forms.Padding(4)
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(203, 25)
        Me.notelp.TabIndex = 14
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(140, 202)
        Me.status.Margin = New System.Windows.Forms.Padding(4)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(95, 25)
        Me.status.TabIndex = 13
        '
        'alamat
        '
        Me.alamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(140, 117)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(203, 78)
        Me.alamat.TabIndex = 12
        Me.alamat.Text = ""
        '
        'nama_team
        '
        Me.nama_team.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_team.Location = New System.Drawing.Point(140, 85)
        Me.nama_team.Margin = New System.Windows.Forms.Padding(4)
        Me.nama_team.Name = "nama_team"
        Me.nama_team.Size = New System.Drawing.Size(203, 25)
        Me.nama_team.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Location = New System.Drawing.Point(17, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label7.Location = New System.Drawing.Point(17, 120)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Location = New System.Drawing.Point(17, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Team"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(140, 56)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(203, 25)
        Me.nama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'kode_member
        '
        Me.kode_member.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_member.Location = New System.Drawing.Point(183, 26)
        Me.kode_member.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_member.Name = "kode_member"
        Me.kode_member.Size = New System.Drawing.Size(160, 25)
        Me.kode_member.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Member"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(379, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 70)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Menu Awal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(358, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'Cetak
        '
        Me.Cetak.BackgroundImage = CType(resources.GetObject("Cetak.BackgroundImage"), System.Drawing.Image)
        Me.Cetak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cetak.Location = New System.Drawing.Point(12, 398)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(176, 45)
        Me.Cetak.TabIndex = 50
        Me.Cetak.Text = "Cetak Kartu Member"
        Me.Cetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(194, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 45)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Booking Lapangan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Image = CType(resources.GetObject("Btn3.Image"), System.Drawing.Image)
        Me.Btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn3.Location = New System.Drawing.Point(268, 354)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(104, 38)
        Me.Btn3.TabIndex = 46
        Me.Btn3.Text = "Button3"
        Me.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Image = CType(resources.GetObject("Btn2.Image"), System.Drawing.Image)
        Me.Btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn2.Location = New System.Drawing.Point(153, 354)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(109, 38)
        Me.Btn2.TabIndex = 45
        Me.Btn2.Text = "Button2"
        Me.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn1.Location = New System.Drawing.Point(13, 354)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(134, 38)
        Me.Btn1.TabIndex = 44
        Me.Btn1.Text = "Button1"
        Me.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Image = CType(resources.GetObject("Btn4.Image"), System.Drawing.Image)
        Me.Btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn4.Location = New System.Drawing.Point(268, 354)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(104, 38)
        Me.Btn4.TabIndex = 47
        Me.Btn4.Text = "Button4"
        Me.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'ToolStripStatus1
        '
        Me.ToolStripStatus1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelTgl, Me.LabelJam, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.userid, Me.ToolStripStatusLabel2, Me.nama_ptgs})
        Me.ToolStripStatus1.Location = New System.Drawing.Point(0, 447)
        Me.ToolStripStatus1.Name = "ToolStripStatus1"
        Me.ToolStripStatus1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ToolStripStatus1.Size = New System.Drawing.Size(974, 25)
        Me.ToolStripStatus1.TabIndex = 67
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
        'FrPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStripStatus1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Cetak)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambahkan Member"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripStatus1.ResumeLayout(False)
        Me.ToolStripStatus1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents berdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents kode_member As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents notelp As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents nama_team As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatus1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelTgl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents userid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama_ptgs As System.Windows.Forms.ToolStripStatusLabel
End Class
