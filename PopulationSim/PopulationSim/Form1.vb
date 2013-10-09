Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim curYear As Integer = 2012
        Dim population As Double = 7000000000.0

        Do While population > 6000000.0
            population /= 2
            curYear -= 50
        Loop

        MessageBox.Show("Population was 6M in year " & CStr(curYear))

    End Sub
End Class
