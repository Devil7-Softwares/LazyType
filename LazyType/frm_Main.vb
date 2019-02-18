Public Class frm_Main

#Region "Variables"
    Dim WaitSeconds As Integer = 0
    Dim Chars2Type As New List(Of Char)
    Dim MaxChars As Integer
    Dim OldSize As Size
    Dim OldLocation As Point
    Dim FocusedPID As Integer
#End Region

#Region "Subs"
    Sub EnableControls()
        btn_Start.Enabled = True
        btn_Stop.Enabled = False
        txt_Text.Enabled = True
        txt_Interval.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        txt_Wait.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        ControlBox = True
        Size = OldSize
        TopMost = False
        Location = OldLocation
        FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Sub DisableControls()
        OldLocation = Location
        OldSize = Size
        btn_Start.Enabled = False
        btn_Stop.Enabled = True
        txt_Text.Enabled = False
        txt_Interval.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        txt_Wait.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        ControlBox = False
        Size = New Size(180, 98)
        TopMost = True
        Location = New Point(My.Computer.Screen.WorkingArea.Width - Size.Width, My.Computer.Screen.WorkingArea.Height - Size.Height)
        FormBorderStyle = FormBorderStyle.FixedDialog
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_Interval.EditValue = My.Settings.Interval
        txt_Wait.EditValue = My.Settings.Wait
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Start_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Start.ItemClick
        If txt_Text.Text <> "" Then
            WaitSeconds = txt_Wait.EditValue
            Chars2Type.Clear()
            Chars2Type.AddRange(txt_Text.Text.ToCharArray)
            MaxChars = Chars2Type.Count
            DisableControls()

            WaitTimer.Start()
        End If
    End Sub

    Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
        TypeTimer.Stop()
        WaitTimer.Stop()
        EnableControls()
        frm_Count.Close()
    End Sub
#End Region

#Region "Timer Events"
    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        If WaitSeconds >= 0 Then
            frm_Count.Show()
            frm_Count.Value = WaitSeconds
            WaitSeconds -= 1
        Else
            frm_Count.Close()
            WaitTimer.Stop()

            FocusedPID = Native.GetFocusedProcessID
            TypeTimer.Start()
        End If
    End Sub

    Private Sub TypeTimer_Tick(sender As Object, e As EventArgs) Handles TypeTimer.Tick
        If Chars2Type.Count > 0 AndAlso FocusedPID = Native.GetFocusedProcessID Then
            SendKeys.SendWait(Chars2Type(0))
            Chars2Type.RemoveAt(0)
            prog_Status.EditValue = (((MaxChars - Chars2Type.Count) / MaxChars) * 100)
        Else
            EnableControls()
            TypeTimer.Stop()
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub txt_Interval_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Interval.EditValueChanged
        My.Settings.Interval = txt_Interval.EditValue
        My.Settings.Save()

        TypeTimer.Interval = txt_Interval.EditValue
    End Sub

    Private Sub txt_Text_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Text.EditValueChanged
        btn_Start.Enabled = txt_Text.Text <> ""
    End Sub
#End Region

End Class