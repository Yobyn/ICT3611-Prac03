Module TestAlgorithm

    Public Sub main()
        testAlg()
    End Sub

    Public Sub testAlg()
        Dim primes() As Integer

        Try
            primes = calcPrimeNumbers(0)
            Debug.Fail("Exception not thrown when upper bound number < 2")
        Catch ex As Exception
            MsgBox("Exception caught")
        End Try

        Try
            primes = calcPrimeNumbers(201)
            Debug.Fail("Exception not throws when upper bound number > 200")
        Catch aex As ArithmeticException
            MsgBox("ArithmeticException caught")
        Catch ex As Exception
            Debug.Fail("Wrong Exception caught")
        End Try

        primes = calcPrimeNumbers(10)

        Dim test_primes() As Integer = {2, 3, 5, 7}
        Debug.Assert(test_primes.SequenceEqual(primes), "Prime numbers returned for upper bound number = 10 is incorrect")

        primes = calcPrimeNumbers(20)

        test_primes = {2, 3, 5, 7, 11, 13, 17, 19}
        Debug.Assert(test_primes.SequenceEqual(primes), "Prime numbers returned for upper bound number = 20 is incorrect")

    End Sub

End Module
