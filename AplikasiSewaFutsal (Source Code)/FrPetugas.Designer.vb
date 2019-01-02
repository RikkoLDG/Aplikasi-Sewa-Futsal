<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrPetugas))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenkel = New System.Windows.Forms.ComboBox()
        Me.berdasarkan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idptgs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.hak = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.notelp_ptgs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.divisi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn1.Location = New System.Drawing.Point(14, 458)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(107, 38)
        Me.Btn1.TabIndex = 25
        Me.Btn1.Text = "Button1"
        Me.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'alamat
        '
        Me.alamat.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(122, 145)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(178, 71)
        Me.alamat.TabIndex = 7
        Me.alamat.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Location = New System.Drawing.Point(15, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat"
        '
        'jenkel
        '
        Me.jenkel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jenkel.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenkel.FormattingEnabled = True
        Me.jenkel.Location = New System.Drawing.Point(122, 106)
        Me.jenkel.Name = "jenkel"
        Me.jenkel.Size = New System.Drawing.Size(178, 31)
        Me.jenkel.TabIndex = 5
        '
        'berdasarkan
        '
        Me.berdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.berdasarkan.FormattingEnabled = True
        Me.berdasarkan.Location = New System.Drawing.Point(263, 24)
        Me.berdasarkan.Name = "berdasarkan"
        Me.berdasarkan.Size = New System.Drawing.Size(157, 33)
        Me.berdasarkan.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SAO UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(169, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Berdasarkan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(15, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Kelamin"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(122, 67)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(178, 30)
        Me.nama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Petugas"
        '
        'idptgs
        '
        Me.idptgs.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idptgs.Location = New System.Drawing.Point(160, 25)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(140, 30)
        Me.idptgs.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Petugas"
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(173, 64)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(301, 33)
        Me.Cari.TabIndex = 8
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(480, 64)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(56, 32)
        Me.BtnCari.TabIndex = 9
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(345, 122)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(589, 421)
        Me.dgv1.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRefresh)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Cari)
        Me.GroupBox2.Controls.Add(Me.BtnCari)
        Me.GroupBox2.Controls.Add(Me.berdasarkan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("SAO UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(345, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(590, 104)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.notelp_ptgs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.divisi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.jenkel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.idptgs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("SAO UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 436)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Petugas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.hak)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.password)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.username)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("SAO UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 138)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data User"
        '
        'hak
        '
        Me.hak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hak.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hak.FormattingEnabled = True
        Me.hak.Location = New System.Drawing.Point(122, 97)
        Me.hak.Name = "hak"
        Me.hak.Size = New System.Drawing.Size(178, 31)
        Me.hak.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Location = New System.Drawing.Point(15, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Hak Akses"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(122, 61)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(178, 30)
        Me.password.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label12.Location = New System.Drawing.Point(15, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 23)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Password"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(122, 25)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(178, 30)
        Me.username.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label13.Location = New System.Drawing.Point(15, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Username"
        '
        'notelp_ptgs
        '
        Me.notelp_ptgs.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notelp_ptgs.Location = New System.Drawing.Point(122, 262)
        Me.notelp_ptgs.Name = "notelp_ptgs"
        Me.notelp_ptgs.Size = New System.Drawing.Size(178, 30)
        Me.notelp_ptgs.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(15, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. Telepon"
        '
        'divisi
        '
        Me.divisi.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisi.Location = New System.Drawing.Point(122, 223)
        Me.divisi.Name = "divisi"
        Me.divisi.Size = New System.Drawing.Size(178, 30)
        Me.divisi.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(15, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Divisi"
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Image = CType(resources.GetObject("Btn2.Image"), System.Drawing.Image)
        Me.Btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn2.Location = New System.Drawing.Point(127, 458)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(102, 38)
        Me.Btn2.TabIndex = 33
        Me.Btn2.Text = "Button2"
        Me.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Image = CType(resources.GetObject("Btn3.Image"), System.Drawing.Image)
        Me.Btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn3.Location = New System.Drawing.Point(235, 458)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(104, 38)
        Me.Btn3.TabIndex = 34
        Me.Btn3.Text = "Button3"
        Me.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(157, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Image = CType(resources.GetObject("Btn4.Image"), System.Drawing.Image)
        Me.Btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn4.Location = New System.Drawing.Point(236, 458)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(104, 38)
        Me.Btn4.TabIndex = 37
        Me.Btn4.Text = "Button4"
        Me.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.BackgroundImage = CType(resources.GetObject("BtnMenu.BackgroundImage"), System.Drawing.Image)
        Me.BtnMenu.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!)
        Me.BtnMenu.Location = New System.Drawing.Point(152, 502)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(187, 45)
        Me.BtnMenu.TabIndex = 38
        Me.BtnMenu.Text = "Menu Utama"
        Me.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 502)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(544, 64)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(38, 33)
        Me.BtnRefresh.TabIndex = 69
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'FrPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrPetugas"
        Me.Text = "Data Petugas"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jenkel As System.Windows.Forms.ComboBox
    Friend WithEvents berdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idptgs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents notelp_ptgs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents divisi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents hak As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnMenu As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
End Class
