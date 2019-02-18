<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Formats
    Inherits XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Formats))
        Me.lbl_DateFormat = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_NumberFormat = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DateFormat = New DevExpress.XtraEditors.TextEdit()
        Me.txt_NumberFormat = New DevExpress.XtraEditors.TextEdit()
        Me.panel_Footer = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_DateFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumberFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_DateFormat
        '
        Me.lbl_DateFormat.Location = New System.Drawing.Point(33, 15)
        Me.lbl_DateFormat.Name = "lbl_DateFormat"
        Me.lbl_DateFormat.Size = New System.Drawing.Size(67, 13)
        Me.lbl_DateFormat.TabIndex = 0
        Me.lbl_DateFormat.Text = "Date Format :"
        '
        'lbl_NumberFormat
        '
        Me.lbl_NumberFormat.Location = New System.Drawing.Point(19, 41)
        Me.lbl_NumberFormat.Name = "lbl_NumberFormat"
        Me.lbl_NumberFormat.Size = New System.Drawing.Size(81, 13)
        Me.lbl_NumberFormat.TabIndex = 1
        Me.lbl_NumberFormat.Text = "Number Format :"
        '
        'txt_DateFormat
        '
        Me.txt_DateFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DateFormat.Location = New System.Drawing.Point(106, 12)
        Me.txt_DateFormat.Name = "txt_DateFormat"
        Me.txt_DateFormat.Size = New System.Drawing.Size(164, 20)
        Me.txt_DateFormat.TabIndex = 2
        '
        'txt_NumberFormat
        '
        Me.txt_NumberFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NumberFormat.Location = New System.Drawing.Point(106, 38)
        Me.txt_NumberFormat.Name = "txt_NumberFormat"
        Me.txt_NumberFormat.Size = New System.Drawing.Size(164, 20)
        Me.txt_NumberFormat.TabIndex = 3
        '
        'panel_Footer
        '
        Me.panel_Footer.Controls.Add(Me.btn_Done)
        Me.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_Footer.Location = New System.Drawing.Point(0, 72)
        Me.panel_Footer.Name = "panel_Footer"
        Me.panel_Footer.Size = New System.Drawing.Size(282, 36)
        Me.panel_Footer.TabIndex = 4
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.Location = New System.Drawing.Point(202, 5)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(75, 26)
        Me.btn_Done.TabIndex = 0
        Me.btn_Done.Text = "Done"
        '
        'frm_Formats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 108)
        Me.Controls.Add(Me.panel_Footer)
        Me.Controls.Add(Me.txt_NumberFormat)
        Me.Controls.Add(Me.txt_DateFormat)
        Me.Controls.Add(Me.lbl_NumberFormat)
        Me.Controls.Add(Me.lbl_DateFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Formats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Formats"
        CType(Me.txt_DateFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumberFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Footer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_DateFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_NumberFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DateFormat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_NumberFormat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents panel_Footer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
End Class
