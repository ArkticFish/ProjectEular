Public Class Class37

    Public Sub Solve()

        Dim sum As Long = 0

        For i = 10 To 1000000

            If SharedMethods.IsPrime(i) Then

                If TestSmallerPrime(i, True) AndAlso TestSmallerPrime(i, False) Then

                    sum += i

                End If

            End If

        Next

        Console.WriteLine()
        Console.WriteLine(sum)

    End Sub

    Private Function TestSmallerPrime(number As String, left As Boolean) As Boolean

        Dim val = Convert.ToInt64(number)

        If number.Length = 1 Then
            Return SharedMethods.IsPrime(val)
        Else

            Dim smaller As String

            If left Then
                smaller = number.Substring(0, number.Length - 1)
            Else
                smaller = number.Substring(1, number.Length - 1)
            End If

            Return SharedMethods.IsPrime(val) AndAlso TestSmallerPrime(smaller, left)

        End If

    End Function


End Class
