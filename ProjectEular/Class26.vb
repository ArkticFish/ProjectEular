Imports System.Numerics

Public Class Class26

    Public Sub Solve()

        Dim maxRemainders = 0
        Dim maxNum = 0

        For num = 1 To 999

            Console.WriteLine(num)

            Dim remainders As New List(Of Integer)

            Dim value = 1

            While True

                Dim remainder As Integer = value Mod num

                If remainders.Contains(remainder) Then
                    Exit While
                Else
                    remainders.Add(remainder)
                    value = remainder * 10
                End If

            End While

            If remainders.Count() > maxRemainders Then
                maxRemainders = remainders.Count()
                maxNum = num
            End If

        Next

        Console.Clear()
        Console.WriteLine(maxNum)
        Console.WriteLine(maxRemainders)

    End Sub

End Class
