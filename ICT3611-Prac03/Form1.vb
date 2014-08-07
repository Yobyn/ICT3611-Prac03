Public Class Prac03

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim upperBoundNumber As Integer

        lsbPrimeNumbers.Items.Clear()

        upperBoundNumber = Integer.Parse(txtUBN.Text)

        Dim primes() As Integer

        primes = calcPrimeNumbers(upperBoundNumber)

        For i As Integer = 0 To primes.Length - 1
            lsbPrimeNumbers.Items.Add(primes(i))
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
