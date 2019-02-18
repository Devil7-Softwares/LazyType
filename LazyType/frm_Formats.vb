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