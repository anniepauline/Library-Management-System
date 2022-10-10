Public Class change_password

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        If ComboBoxUtype.Text = "Admin" Then
            Dim OPassword As String
            Dim NPassword As String
            OPassword = Admin.password
            NPassword = txtNewPwd.Text

            If OPassword <> NPassword Then
                MsgBox("Passwords do not match")
            Else
                Admin.password = NPassword
                MsgBox("Changed successfully!")
            End If
        Else
            MsgBox("Librarian")
        End If




    End Sub
End Class