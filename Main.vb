Public Class main

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Library_Management_System.Admin.Show()
        Me.Hide()
    End Sub
End Class
