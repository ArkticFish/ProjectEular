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

Class Fraction

    Public Numerator As BigInteger
    Public Denominator As BigInteger

    Public Sub New(numerator As BigInteger, denominator As BigInteger)
        Me.Numerator = numerator
        Me.Denominator = denominator
    End Sub

    Public Function ToDouble() As Double
        Return Numerator / Denominator
    End Function

    Public Shared Operator +(f1 As Fraction, f2 As Fraction) As Fraction
        Dim newDenominator = Lcm(f1.Denominator, f2.Denominator)
        Dim f1Multiplier = newDenominator / f1.Denominator
        Dim f2Multiplier = newDenominator / f2.Denominator
        Dim newNumerator = f1.Numerator * f1Multiplier + f2.Numerator * f2Multiplier
        Dim lcd = Gcf(newNumerator, newDenominator)
        Return New Fraction(newNumerator / lcd, newDenominator / lcd)
    End Operator

    Public Shared Operator -(f1 As Fraction, f2 As Fraction) As Fraction
        Dim f3 As New Fraction(-f2.Numerator, f2.Denominator)
        Return f1 + f3
    End Operator

    Public Shared Operator *(f1 As Fraction, f2 As Fraction) As Fraction
        Dim newNumerator = f1.Numerator * f2.Numerator
        Dim newDenominator = f1.Denominator * f2.Denominator
        Dim lcd = Gcf(newNumerator, newDenominator)
        Return New Fraction(newNumerator / lcd, newDenominator / lcd)
    End Operator

    Public Shared Operator /(f1 As Fraction, f2 As Fraction) As Fraction
        Dim f3 = New Fraction(f2.Denominator, f2.Numerator)
        Return f1 * f3
    End Operator

    Private Shared Function Gcf(a As BigInteger, b As BigInteger) As BigInteger
        While b <> 0
            Dim temp As BigInteger = b
            b = a Mod b
            a = temp
        End While
        Return a
    End Function

    Private Shared Function Lcm(a As BigInteger, b As BigInteger) As BigInteger
        Return (a / Gcf(a, b)) * b
    End Function

    Public Overloads Function ToString() As String
        Return $"{Numerator} / {Denominator}"
    End Function

End Class
