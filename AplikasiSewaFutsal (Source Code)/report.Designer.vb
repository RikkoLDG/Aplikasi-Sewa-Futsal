﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.futsal2DataSet = New AplikasiSewaFutsal.futsal2DataSet()
        Me.msmemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.msmemberTableAdapter = New AplikasiSewaFutsal.futsal2DataSetTableAdapters.msmemberTableAdapter()
        CType(Me.futsal2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msmemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.msmemberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplikasiSewaFutsal.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'futsal2DataSet
        '
        Me.futsal2DataSet.DataSetName = "futsal2DataSet"
        Me.futsal2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'msmemberBindingSource
        '
        Me.msmemberBindingSource.DataMember = "msmember"
        Me.msmemberBindingSource.DataSource = Me.futsal2DataSet
        '
        'msmemberTableAdapter
        '
        Me.msmemberTableAdapter.ClearBeforeFill = True
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "report"
        Me.Text = "report"
        CType(Me.futsal2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msmemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents msmemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents futsal2DataSet As AplikasiSewaFutsal.futsal2DataSet
    Friend WithEvents msmemberTableAdapter As AplikasiSewaFutsal.futsal2DataSetTableAdapters.msmemberTableAdapter
End Class
