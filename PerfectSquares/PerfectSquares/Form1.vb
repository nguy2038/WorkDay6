Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim int As Integer = 1
        Dim perfectsquare As Integer

        Do While int <= 10
            perfectsquare = int ^ 2
            lstResult.Items.Add(perfectsquare)
            int += 1
        Loop

    End Sub
End Class
