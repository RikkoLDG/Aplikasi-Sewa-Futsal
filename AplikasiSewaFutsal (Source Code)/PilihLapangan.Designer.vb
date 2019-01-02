<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PilihLapangan
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Batal = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(13, 74)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(577, 288)
        Me.dgv1.TabIndex = 11
        '
        'Batal
        '
        Me.Batal.Location = New System.Drawing.Point(482, 41)
        Me.Batal.Margin = New System.Windows.Forms.Padding(4)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(75, 25)
        Me.Batal.TabIndex = 10
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(402, 41)
        Me.BtnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(72, 25)
        Me.BtnCari.TabIndex = 9
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(90, 42)
        Me.Cari.Margin = New System.Windows.Forms.Padding(4)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(304, 25)
        Me.Cari.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(171, 9)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(272, 30)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "PILIH LAPANGAN FUTSAL"
        '
        'PilihLapangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 368)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Cari)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PilihLapangan"
        Me.Text = "Pilih Lapangan"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Batal As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
