<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelanggan
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
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(10, 40)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(529, 214)
        Me.dgv1.TabIndex = 7
        '
        'Batal
        '
        Me.Batal.Location = New System.Drawing.Point(464, 11)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(75, 23)
        Me.Batal.TabIndex = 6
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(383, 11)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 23)
        Me.BtnCari.TabIndex = 5
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(258, 13)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(119, 20)
        Me.Cari.TabIndex = 4
        '
        'FrmPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 263)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Cari)
        Me.Name = "FrmPelanggan"
        Me.Text = "FrmPelanggan"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Batal As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents Cari As System.Windows.Forms.TextBox
End Class
