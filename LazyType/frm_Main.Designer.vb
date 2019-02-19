<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Start = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_Stop = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.txt_Interval = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.txt_Wait = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.btn_IgnoreSpaces = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_PasteExcel = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_EditFormats = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.prog_Status = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_Text = New DevExpress.XtraEditors.MemoEdit()
        Me.TypeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WaitTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Start, Me.btn_Stop, Me.txt_Interval, Me.txt_Wait, Me.prog_Status, Me.btn_IgnoreSpaces, Me.btn_PasteExcel, Me.btn_EditFormats})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemSpinEdit2, Me.RepositoryItemProgressBar1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Start), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Interval, True), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Wait), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_IgnoreSpaces, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_PasteExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_EditFormats)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_Start
        '
        Me.btn_Start.Caption = "Start"
        Me.btn_Start.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.btn_Start.Enabled = False
        Me.btn_Start.Id = 1
        Me.btn_Start.ImageOptions.Image = CType(resources.GetObject("btn_Start.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem5.Text = "Start"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Start the Typing Process"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btn_Start.SuperTip = SuperToolTip5
        '
        'btn_Stop
        '
        Me.btn_Stop.Caption = "Stop"
        Me.btn_Stop.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.btn_Stop.Enabled = False
        Me.btn_Stop.Id = 2
        Me.btn_Stop.ImageOptions.Image = CType(resources.GetObject("btn_Stop.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem6.Text = "Stop"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Stop the Typing Process"
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.btn_Stop.SuperTip = SuperToolTip6
        '
        'txt_Interval
        '
        Me.txt_Interval.Caption = "Interval"
        Me.txt_Interval.Edit = Me.RepositoryItemSpinEdit1
        Me.txt_Interval.EditValue = 100
        Me.txt_Interval.Id = 4
        Me.txt_Interval.Name = "txt_Interval"
        Me.txt_Interval.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem7.Text = "Interval"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "The Interval Between Entering Charecters in Milliseconds (1000 Milliseconds = 1 S" &
    "econd)"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.txt_Interval.SuperTip = SuperToolTip7
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'txt_Wait
        '
        Me.txt_Wait.Caption = "Initial Wait"
        Me.txt_Wait.Edit = Me.RepositoryItemSpinEdit2
        Me.txt_Wait.EditValue = 5
        Me.txt_Wait.Id = 6
        Me.txt_Wait.Name = "txt_Wait"
        Me.txt_Wait.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem3.Text = "Initial Wait"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Seconds to Wait After Clicking the Start Button"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txt_Wait.SuperTip = SuperToolTip3
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {60, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'btn_IgnoreSpaces
        '
        Me.btn_IgnoreSpaces.Caption = "Ignore Spaces"
        Me.btn_IgnoreSpaces.Id = 9
        Me.btn_IgnoreSpaces.Name = "btn_IgnoreSpaces"
        '
        'btn_PasteExcel
        '
        Me.btn_PasteExcel.Caption = "Paste Excel Data"
        Me.btn_PasteExcel.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.btn_PasteExcel.Id = 11
        Me.btn_PasteExcel.ImageOptions.Image = CType(resources.GetObject("btn_PasteExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_PasteExcel.Name = "btn_PasteExcel"
        Me.btn_PasteExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_EditFormats
        '
        Me.btn_EditFormats.Caption = "Edit Formats"
        Me.btn_EditFormats.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.btn_EditFormats.Id = 12
        Me.btn_EditFormats.ImageOptions.Image = CType(resources.GetObject("btn_EditFormats.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_EditFormats.Name = "btn_EditFormats"
        Me.btn_EditFormats.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.prog_Status)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'prog_Status
        '
        Me.prog_Status.AutoFillWidth = True
        Me.prog_Status.Caption = "Progress"
        Me.prog_Status.Edit = Me.RepositoryItemProgressBar1
        Me.prog_Status.Id = 8
        Me.prog_Status.Name = "prog_Status"
        Me.prog_Status.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(890, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 243)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(890, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 203)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(890, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 203)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'txt_Text
        '
        Me.txt_Text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Text.Location = New System.Drawing.Point(0, 40)
        Me.txt_Text.MenuManager = Me.BarManager1
        Me.txt_Text.Name = "txt_Text"
        Me.txt_Text.Size = New System.Drawing.Size(890, 203)
        Me.txt_Text.TabIndex = 4
        '
        'TypeTimer
        '
        '
        'WaitTimer
        '
        Me.WaitTimer.Interval = 1000
        '
        'frm_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(890, 268)
        Me.Controls.Add(Me.txt_Text)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Text = "LazyType"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Start As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_Stop As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents txt_Interval As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txt_Wait As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents prog_Status As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents txt_Text As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TypeTimer As Timer
    Friend WithEvents WaitTimer As Timer
    Friend WithEvents btn_IgnoreSpaces As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_PasteExcel As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_EditFormats As DevExpress.XtraBars.BarLargeButtonItem
End Class
