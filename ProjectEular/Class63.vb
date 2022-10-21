Imports System.Numerics

Public Class Class63
    
    Public Sub Solve()
        
        Dim sum = 0

        For base = 1 To 100

            Console.Write($"{base}{vbCr}")

            For power = 1 To 1000

                if BigInteger.Pow(base, power).ToString().Count() = power
                    sum += 1
                End If

            Next

        Next

        Console.WriteLine()
        Console.WriteLine(sum)
        Console.WriteLine("Done")

    End Sub

End Class
