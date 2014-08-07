Module SieveOfEratothenes
    Public Function calcPrimeNumbers(ByVal upperBoundNumber As Integer) As Integer()

        If upperBoundNumber < 2 Then
            Throw New Exception("Number too low")
        End If
        If upperBoundNumber > 200 Then
            Throw New ArithmeticException("Number too high")
        End If

        Dim r(upperBoundNumber - 1) As Integer
        Dim i, j As Integer

        For i = 2 To upperBoundNumber - 1
            r(i) = i
        Next

        For i = 2 To Math.Sqrt(upperBoundNumber - 1)
            If r(i) <> 0 Then
                j = 0
                Dim q As Integer = Math.Pow(i, 2)
                While q + j * i < upperBoundNumber
                    r(q + j * i) = 0
                    j += 1
                End While
            End If
        Next

        j = 0

        For k = 2 To upperBoundNumber - 1
            If r(k) <> 0 Then
                r(j) = r(k)
                j += 1
            End If
        Next

        ReDim Preserve r(j - 1)

        Return r

    End Function

End Module
