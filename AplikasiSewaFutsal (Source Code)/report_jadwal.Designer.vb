<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_jadwal
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.futsal2DataSet2 = New AplikasiSewaFutsal.futsal2DataSet2()
        Me.View_JadwalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_JadwalTableAdapter = New AplikasiSewaFutsal.futsal2DataSet2TableAdapters.View_JadwalTableAdapter()
        CType(Me.futsal2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_JadwalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.View_JadwalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplikasiSewaFutsal.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'futsal2DataSet2
        '
        Me.futsal2DataSet2.DataSetName = "futsal2DataSet2"
        Me.futsal2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_JadwalBindingSource
        '
        Me.View_JadwalBindingSource.DataMember = "View_Jadwal"
        Me.View_JadwalBindingSource.DataSource = Me.futsal2DataSet2
        '
        'View_JadwalTableAdapter
        '
        Me.View_JadwalTableAdapter.ClearBeforeFill = True
        '
        'report_jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "report_jadwal"
        Me.Text = "JADWAL SEWA"
        CType(Me.futsal2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_JadwalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_JadwalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents futsal2DataSet2 As AplikasiSewaFutsal.futsal2DataSet2
    Friend WithEvents View_JadwalTableAdapter As AplikasiSewaFutsal.futsal2DataSet2TableAdapters.View_JadwalTableAdapter
End Class
