<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.idptgs = New System.Windows.Forms.TextBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.hak = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Minimize = New System.Windows.Forms.PictureBox()
        Me.CloseApp = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'idptgs
        '
        Me.idptgs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idptgs.Location = New System.Drawing.Point(559, 254)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(104, 29)
        Me.idptgs.TabIndex = 22
        Me.idptgs.Visible = False
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(338, 208)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(86, 37)
        Me.dgv2.TabIndex = 23
        '
        'hak
        '
        Me.hak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hak.FormattingEnabled = True
        Me.hak.Location = New System.Drawing.Point(276, 285)
        Me.hak.Name = "hak"
        Me.hak.Size = New System.Drawing.Size(228, 29)
        Me.hak.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(154, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Hak Akses"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(559, 289)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(104, 29)
        Me.nama.TabIndex = 30
        Me.nama.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Minimize)
        Me.Panel1.Controls.Add(Me.CloseApp)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 45)
        Me.Panel1.TabIndex = 31
        '
        'Minimize
        '
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.Image = Global.AplikasiSewaFutsal.My.Resources.Resources.gem_cancel_2
        Me.Minimize.Location = New System.Drawing.Point(601, 17)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(16, 16)
        Me.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Minimize.TabIndex = 35
        Me.Minimize.TabStop = False
        '
        'CloseApp
        '
        Me.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseApp.Image = Global.AplikasiSewaFutsal.My.Resources.Resources.cancel_normal
        Me.CloseApp.Location = New System.Drawing.Point(623, 3)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(37, 39)
        Me.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseApp.TabIndex = 34
        Me.CloseApp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplikasiSewaFutsal.My.Resources.Resources.soccer
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.Window
        Me.title.Location = New System.Drawing.Point(38, 12)
        Me.title.Margin = New System.Windows.Forms.Padding(3)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(211, 21)
        Me.title.TabIndex = 0
        Me.title.Text = "Aplikasi Sewa Lapangan Futsal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 18)
        Me.Panel2.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Keluar)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.BtnLogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(149, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 199)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log_In :"
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Keluar.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Keluar.ForeColor = System.Drawing.Color.White
        Me.Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Keluar.Location = New System.Drawing.Point(245, 148)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(110, 38)
        Me.Keluar.TabIndex = 17
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(127, 115)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(194, 29)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username"
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(127, 35)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(228, 29)
        Me.user.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(127, 79)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(228, 29)
        Me.password.TabIndex = 15
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLogin.Location = New System.Drawing.Point(127, 148)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(110, 38)
        Me.BtnLogin.TabIndex = 16
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 392)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.idptgs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Sewa Futsal"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idptgs As System.Windows.Forms.TextBox
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents hak As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseApp As System.Windows.Forms.PictureBox
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents Minimize As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button

End Class
