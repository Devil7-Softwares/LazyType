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

Public Class frm_Count

#Region "Variables"
    Dim InitialStyle As Integer
#End Region

#Region "Properties"
    Property Value As Integer
        Get
            Return CInt(lbl_Value.Text)
        End Get
        Set(value As Integer)
            lbl_Value.Text = value
        End Set
    End Property
#End Region

#Region "Form Events"
    Private Sub frm_Count_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitialStyle = Native.GetWindowLong(Me.Handle, -20)
        Native.SetWindowLong(Me.Handle, -20, InitialStyle Or &H80000 Or &H20)
        Native.SetLayeredWindowAttributes(Me.Handle, 0, 255 * Opacity, &H2)
        Me.TopMost = True
    End Sub
#End Region

End Class