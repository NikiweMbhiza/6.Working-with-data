Public Class Form1
    Dim Yourmessage As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblAge.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Yourmessage = "enter your birth year"
        MessageBox.Show(Yourmessage)

        ' Get the birth year from the user
        Dim BirthYear As String = InputBox("Enter your birth year:")
        ' Check if the input is a valid number
        If IsNumeric(BirthYear) Then
            ' Convert the input to an integer
            Dim YearOfBirth As Integer = Val(BirthYear)

            ' Calculate age
            Dim Age As Integer = DateTime.Now.Year - YearOfBirth

            ' Display the age
            lblAge.Text = "Your age is: " & Age.ToString()
        Else
            MessageBox.Show("Invalid input. Please enter a valid number for the birth year.")
        End If


    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblAge.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
