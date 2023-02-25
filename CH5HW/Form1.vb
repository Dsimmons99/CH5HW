Public Class Form1

    Dim Registrations As Int32
    Dim AttendeePrice As Int32
    Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
        Registrations = Val(NumOfRegTXT.Text)
        AttendeePrice = Val(AttendeeTXT.Text)

        If Not IsNumeric(NumOfRegTXT.Text) Then
            AttendeeTXT.Text = "Please enter numeric value"
            Return
        End If

        If Registrations <= 0 Then
            AttendeeTXT.Text = "Error amount too low"
        ElseIf Registrations = 1 Then
            AttendeePrice = 795
        ElseIf Registrations >= 2 And Registrations <= 4 Then
            AttendeePrice = 645
        ElseIf Registrations >= 5 And Registrations <= 7 Then
            AttendeePrice = 475
        ElseIf Registrations >= 8 And Registrations <= 15 Then
            AttendeePrice = 385
        ElseIf Registrations >= 17 Then
            AttendeeTXT.Text = "Error amount too high"
        End If

        If AttendeePrice > 0 Then
            AttendeeTXT.Text = "$" & AttendeePrice
        End If
    End Sub

    Private Sub ResetBTN_Click(sender As Object, e As EventArgs) Handles ResetBTN.Click
        AttendeeTXT.Text = ""
        NumOfRegTXT.Text = ""
    End Sub
End Class