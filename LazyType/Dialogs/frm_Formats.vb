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

Public Class frm_Formats

#Region "Form Events"
    Private Sub frm_Formats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_DateFormat.Text = My.Settings.DateFormat
        txt_NumberFormat.Text = My.Settings.NumberFormat
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        My.Settings.DateFormat = txt_DateFormat.Text
        My.Settings.NumberFormat = txt_NumberFormat.Text
        My.Settings.Save()
    End Sub
#End Region

End Class