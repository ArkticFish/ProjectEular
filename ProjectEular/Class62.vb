Imports System.Numerics

Public Class Class62

    Public Sub Solve()

        Dim listOfCubes As New List(Of (Integer, String))

        For index = 0 To 9000
            listOfCubes.Add((index, SortString(BigInteger.Pow(index, 3).ToString())))
        Next

        
        For index = 0 To 9000
            Dim i = index
            If listOfCubes.Where(Function(val) val.Item2 = listOfCubes(i).Item2).Count() = 5
                Console.WriteLine(BigInteger.Pow(listOfCubes(i).Item1, 3))
            End If
        Next


        Console.WriteLine("Done")

    End Sub

    Public Function SortString(Source As String) As String
        'Convert string to char array.
        Dim Chars() As Char = Source.ToCharArray()
        'Sort the char array
        Array.Sort(Chars)
        'Return sorted string
        Return New String(Chars)
    End Function

End Class
