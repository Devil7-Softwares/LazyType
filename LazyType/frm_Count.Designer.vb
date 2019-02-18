<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Count
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_Value = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Value
        '
        Me.lbl_Value.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Value.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Value.Name = "lbl_Value"
        Me.lbl_Value.Size = New System.Drawing.Size(120, 120)
        Me.lbl_Value.TabIndex = 0
        Me.lbl_Value.Text = "5"
        Me.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Count
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(120, 120)
        Me.Controls.Add(Me.lbl_Value)
        Me.Font = New System.Drawing.Font("Myriad Pro", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(25, 27, 25, 27)
        Me.Name = "frm_Count"
        Me.Opacity = 0.7R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Count"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Value As Label
End Class
