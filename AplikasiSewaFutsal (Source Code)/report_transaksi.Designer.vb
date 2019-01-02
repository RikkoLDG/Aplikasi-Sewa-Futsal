<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_transaksi
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.futsal2DataSet1 = New AplikasiSewaFutsal.futsal2DataSet1()
        Me.View_transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_transaksiTableAdapter = New AplikasiSewaFutsal.futsal2DataSet1TableAdapters.View_transaksiTableAdapter()
        CType(Me.futsal2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.View_transaksiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplikasiSewaFutsal.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'futsal2DataSet1
        '
        Me.futsal2DataSet1.DataSetName = "futsal2DataSet1"
        Me.futsal2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_transaksiBindingSource
        '
        Me.View_transaksiBindingSource.DataMember = "View_transaksi"
        Me.View_transaksiBindingSource.DataSource = Me.futsal2DataSet1
        '
        'View_transaksiTableAdapter
        '
        Me.View_transaksiTableAdapter.ClearBeforeFill = True
        '
        'report_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "report_transaksi"
        Me.Text = "Report Penyewaan"
        CType(Me.futsal2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents futsal2DataSet1 As AplikasiSewaFutsal.futsal2DataSet1
    Friend WithEvents View_transaksiTableAdapter As AplikasiSewaFutsal.futsal2DataSet1TableAdapters.View_transaksiTableAdapter
End Class
