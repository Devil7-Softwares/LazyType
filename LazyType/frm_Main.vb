'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.IO
Imports System.Xml

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

#Region "Functions"
    Private Function ReadXMLSpreadSheet() As String
        Dim R As String = ""
        Using MS As MemoryStream = CType(Clipboard.GetData("XML Spreadsheet"), MemoryStream)
            If MS IsNot Nothing Then
                Dim Document As New XmlDocument
                Document.Load(MS)

                For Each Row As XmlNode In Document.GetElementsByTagName("Row")
                    Dim RowString As String = ""
                    For Each Cell As XmlNode In Row.ChildNodes
                        If Cell.Name = "Cell" Then
                            For Each Data As XmlNode In Cell.ChildNodes
                                If Data.Name = "Data" Then
                                    Dim Type As String = Data.Attributes.GetNamedItem("ss:Type").Value
                                    Dim Value As String = Nothing
                                    If Type = "String" Then
                                        Value = Data.InnerText
                                    ElseIf Type = "DateTime" Then
                                        Value = Date.Parse(Data.InnerText).ToString(My.Settings.DateFormat)
                                    ElseIf Type = "Number" Then
                                        Value = CDbl(Data.InnerText).ToString(My.Settings.NumberFormat)
                                    End If

                                    If Value IsNot Nothing Then RowString &= If(RowString = "", "", vbTab) & Value
                                End If
                            Next
                        End If
                    Next
                    R &= If(R = "", "", vbNewLine) & RowString
                Next
            End If
        End Using
        Return R
    End Function
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_Interval.EditValue = My.Settings.Interval
        txt_Wait.EditValue = My.Settings.Wait
        btn_IgnoreSpaces.Checked = My.Settings.IgnoreSpaces
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
    Private Sub btn_PasteExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PasteExcel.ItemClick
        If My.Computer.Keyboard.CtrlKeyDown Then
            Using MS As MemoryStream = CType(Clipboard.GetData("XML Spreadsheet"), MemoryStream)
                If MS IsNot Nothing Then txt_Text.Text = System.Text.Encoding.UTF8.GetString(MS.ToArray)
            End Using
        Else
            txt_Text.Text = ReadXMLSpreadSheet()
        End If
    End Sub

    Private Sub btn_EditFormats_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditFormats.ItemClick
        Dim D As New frm_Formats
        D.ShowDialog()
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
            If Not (My.Settings.IgnoreSpaces And Chars2Type(0) = " ") Then
                SendKeys.SendWait(Chars2Type(0))
            End If
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

    Private Sub btn_IgnoreSpaces_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_IgnoreSpaces.CheckedChanged
        My.Settings.IgnoreSpaces = btn_IgnoreSpaces.Checked
        My.Settings.Save()
    End Sub
#End Region

End Class