Imports System.IO
Imports System.Linq

Public Class Class22

    Public Sub Solve()

        Dim sumOfNames As Long = 0

        Dim names As List(Of String) = File.ReadAllText("p022_names.txt").
            Split(",").
            Select(Function(name) name.Trim("""")).
            ToList()

        names.Sort()

        For index = 0 To names.Count() - 1

            Dim nameScore = 0

            For Each letter In names(index)

                nameScore += Asc(letter) - 64

            Next

            sumOfNames += nameScore * (index + 1)

        Next

        Console.WriteLine(sumOfNames)

    End Sub

End Class
