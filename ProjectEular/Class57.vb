Imports System.Numerics
Imports System.Runtime.Remoting.Messaging

Public Class Class57

    Public Sub Solve()

        Dim one = New Fraction(1, 1)

        Dim count = 0

        For i = 0 To 1000

            Dim fr = one + FractionRecur(i)

            If fr.Numerator.ToString().Length > fr.Denominator.ToString().Length Then
                Console.WriteLine(fr.ToString())
                count += 1
            End If

        Next

        Console.WriteLine(count)
        Console.WriteLine("Done")

    End Sub

    Private Shared Function FractionRecur(level As Integer) As Fraction

        If level = 0 Then
            Return New Fraction(1, 2)
        Else
            Return New Fraction(1, 1) / (New Fraction(2, 1) + FractionRecur(level - 1))
        End If

    End Function

End Class
