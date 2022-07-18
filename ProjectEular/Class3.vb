Imports System.Numerics

Public Class Class3

    Public Sub Solve()

        Dim bigNumber As Double = 600851475143

        Dim numberList As New List(Of Long)

        For Each number In SharedMethods.GetFactors(bigNumber)
            If SharedMethods.IsPrime(number) Then
                numberList.Add(number)
            End If
        Next

        Console.WriteLine()
        Console.WriteLine(numberList.LastOrDefault())

    End Sub

End Class
