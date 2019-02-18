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