Imports System.IO

Public Class Class42

    Public Sub Solve()

        Dim count = 0

        Dim triangles = New List(Of Integer)

        For n = 1 To 50

            triangles.Add(0.5 * n * (n + 1))

        Next

        Dim words = File.ReadAllText("p042_words.txt").Split(",").Select(Function(word) word.Trim(""""))

        For Each word In words

            Dim wordSum = 0

            For Each chars In word

                wordSum += Convert.ToByte(chars) - 64

            Next

            If triangles.Contains(wordSum) Then
                count += 1
            End If

        Next

        Console.Clear()
        Console.WriteLine($"Ans = {count}")

    End Sub

End Class
