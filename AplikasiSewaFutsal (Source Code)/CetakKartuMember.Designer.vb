<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakKartuMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CetakKartuMember))
        Me.nama_team = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.kode_member = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.notelp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'nama_team
        '
        Me.nama_team.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_team.Location = New System.Drawing.Point(160, 127)
        Me.nama_team.Margin = New System.Windows.Forms.Padding(4)
        Me.nama_team.Name = "nama_team"
        Me.nama_team.Size = New System.Drawing.Size(246, 30)
        Me.nama_team.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(75, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nama Team :"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(160, 87)
        Me.nama.Margin = New System.Windows.Forms.Padding(4)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(246, 30)
        Me.nama.TabIndex = 48
        '
        'kode_member
        '
        Me.kode_member.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_member.Location = New System.Drawing.Point(122, 49)
        Me.kode_member.Margin = New System.Windows.Forms.Padding(4)
        Me.kode_member.Name = "kode_member"
        Me.kode_member.Size = New System.Drawing.Size(166, 30)
        Me.kode_member.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(24, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Kode Member :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(110, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nama :"
        '
        'notelp
        '
        Me.notelp.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notelp.Location = New System.Drawing.Point(160, 165)
        Me.notelp.Margin = New System.Windows.Forms.Padding(4)
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(246, 30)
        Me.notelp.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("SAO Welcome TT", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(73, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "No. Telepon :"
        '
        'BtnCetak
        '
        Me.BtnCetak.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetak.Location = New System.Drawing.Point(160, 202)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(102, 38)
        Me.BtnCetak.TabIndex = 60
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("SAO Welcome TT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Image = CType(resources.GetObject("BtnKembali.Image"), System.Drawing.Image)
        Me.BtnKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKembali.Location = New System.Drawing.Point(302, 202)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(104, 38)
        Me.BtnKembali.TabIndex = 61
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'CetakKartuMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(517, 272)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.notelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nama_team)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.kode_member)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CetakKartuMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Kartu Member"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nama_team As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents kode_member As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents notelp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents BtnKembali As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
