Imports System.Numerics

Public Class Class29

    Public Sub Solve()

        Dim allList As New List(Of BigInteger)

        For a = 2 To 100

            For b = 2 To 100

                allList.Add(BigInteger.Pow(a, b))

            Next

        Next

        Dim count = allList.Distinct().Count

        Console.WriteLine(count)

    End Sub

End Class
