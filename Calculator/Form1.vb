Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click

        'Declare variables and initialise them
        Dim Number1, Number2, Result As Decimal

        'Save the user input from the text boxes
        Number1 = TBNumber1.Text
        Number2 = TBNumber2.Text

        'Calculate the result
        Result = Number1 + Number2

        'Output the result
        TBResult.Text = Result
    End Sub

    Private Sub BTNSub_Click(sender As Object, e As EventArgs) Handles BTNSub.Click

        'Declare variables and initialise them
        Dim Number1, Number2, Result As Decimal

        'Save the user input from the text boxes
        Number1 = TBNumber1.Text
        Number2 = TBNumber2.Text

        'Calculate the result
        Result = Number1 - Number2

        'Output the result
        TBResult.Text = Result
    End Sub

    Private Sub BTNMult_Click(sender As Object, e As EventArgs) Handles BTNMult.Click

        'Declare variables and initialise them
        Dim Number1, Number2, Result As Decimal

        'Save the user input from the text boxes
        Number1 = TBNumber1.Text
        Number2 = TBNumber2.Text

        'Calculate the result
        Result = Number1 * Number2

        'Output the result
        TBResult.Text = Result
    End Sub

    Private Sub BTNDiv_Click(sender As Object, e As EventArgs) Handles BTNDiv.Click

        'Declare variables and initialise them
        Dim Number1, Number2, Result As Decimal

        'Save the user input from the text boxes
        Number1 = TBNumber1.Text
        Number2 = TBNumber2.Text

        'Calculate the result
        Result = Number1 / Number2

        'Output the result
        TBResult.Text = Result
    End Sub
End Class
