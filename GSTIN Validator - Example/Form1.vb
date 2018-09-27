Public Class frm_Main

    Private Sub txt_GSTIN_TextChanged(sender As Object, e As EventArgs) Handles txt_GSTIN.TextChanged
        Try
            If GSTINValidator.IsValid(txt_GSTIN.Text) Then
                lbl_Result.ForeColor = Color.Green
                lbl_Result.Text = "Valid GSTIN."
            Else
                lbl_Result.ForeColor = Color.Red
                lbl_Result.Text = "Invalid GSTIN!"
            End If
        Catch ex As Exception
            lbl_Result.ForeColor = Color.Red
            lbl_Result.Text = ex.Message
        End Try
    End Sub

End Class
