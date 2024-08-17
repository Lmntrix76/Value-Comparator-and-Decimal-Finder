Public Class Form1
    Dim strStudentName As String
    Dim intAmountSubjects As Integer
    Dim intAmountOwed As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program 
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the feilds
        txtAmount.Clear()
        txtStudentName.Clear()
        lblAnswer.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        strStudentName = txtStudentName.Text
        intAmountSubjects = CInt(txtAmount.Text)
        'Check which level was checked. 'Check for Level 2
        If chkLevel2.Checked = True Then
            intAmountOwed = 2300 + (intAmountSubjects * 50)
        End If
        'Check for Level 3
        If chkLevel3.Checked = True Then
            intAmountOwed = 2500 + (intAmountSubjects * 55)
        End If
        'Check for Level 4
        If chkLevel4.Checked = True Then
            intAmountOwed = 2500 + (intAmountSubjects * 60)
        End If
        'The Coumpound If statement for Level 2 & 3 
        If chkLevel2.Checked = True And chkLevel3.Checked = True Then
            If chkLevel3.Checked = True Then
                intAmountOwed = intAmountOwed + 20
            End If
            'The Compound If statements for Level 3 & 4
            If chkLevel3.Checked = True And chkLevel4.Checked = True Then
                intAmountOwed = intAmountOwed + 20
            End If
        End If
        'Place the answer in the lblAnswer text property
        lblAnswer.Text = strStudentName & " has an outstanding amount of " & intAmountOwed.ToString("C")

    End Sub
End Class
