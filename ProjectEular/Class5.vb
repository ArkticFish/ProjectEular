Imports System.Numerics

Public Class Class5

    Public Sub Solve()

        Dim numberList As New List(Of Long)

        For index = 1 To 20
            numberList.Add(index)
        Next

        Console.WriteLine(SharedMethods.GetLCD(numberList))

    End Sub

    '    Public Sub Solve()

    '        Dim number = 20

    '        While True

    '            For index = 1 To 20
    '                If number Mod index <> 0 Then
    '                    GoTo NextNumber
    '                End If
    '            Next
    '            Console.WriteLine(number)
    '            Return

    'NextNumber:
    '            number += 20
    '        End While

    '    End Sub

End Class
