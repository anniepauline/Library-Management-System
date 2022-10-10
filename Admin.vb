
Public Class Admin
    Public password As String = "Admin"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPwd.Text = password Then
            Librarian_details.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        change_password.Show()
        Me.Hide()


    End Sub
End Class