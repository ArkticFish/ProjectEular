Imports System.Numerics
Imports System.Runtime.CompilerServices

Public Class SharedMethods

    Public Shared Function IsPrime(number As Long) As Boolean

        If number <= 1 Then Return False
        If number = 2 Then Return True
        If number Mod 2 = 0 Then Return False

        Dim max = Math.Sqrt(number)
        Dim index = 3

        While index <= max
            If number Mod index = 0 Then Return False
            index += 1
        End While

        Return True

    End Function

    Public Shared Function IsPalindrome(number As Long) As Boolean

        Dim val = number.ToString()

        For index = 0 To val.Length / 2

            If val(index) <> val(val.Length - 1 - index) Then
                Return False
            End If

        Next

        Return True

    End Function

    Public Shared Function IsPalindrome(number As String) As Boolean

        For index = 0 To number.Length / 2

            If number(index) <> number(number.Length - 1 - index) Then
                Return False
            End If

        Next

        Return True

    End Function

    Public Shared Function GetFactors(number As Long) As List(Of Long)

        Dim max = Math.Floor(Math.Sqrt(number))

        Dim factors As New List(Of Long)

        For i As Long = 1 To max

            If number Mod i = 0 Then
                factors.Add(i)
                If (i <> number / i) Then
                    factors.Add(number / i)
                End If
            End If

        Next

        Return factors

    End Function

    Public Shared Function GetProperFactors(number As Long) As List(Of Long)

        Dim max = Math.Floor(Math.Sqrt(number))

        Dim factors As New List(Of Long)

        For i As Long = 1 To max

            If number Mod i = 0 Then
                factors.Add(i)
                If (i <> number / i) Then
                    factors.Add(number / i)
                End If
            End If

        Next

        Return factors.Where(Function(val) val <> number).ToList()

    End Function

    Public Shared Function Reverse(value As String) As String

        If value.Length <= 1 Then
            Return value
        Else
            Return value.Last + Reverse(value.Substring(0, value.Length - 1))
        End If

    End Function

    Public Shared Function GCD(num1 As BigInteger, num2 As BigInteger) As BigInteger
        Dim Remainder As BigInteger

        While num2 <> 0
            Remainder = num1 Mod num2
            num1 = num2
            num2 = Remainder
        End While

        Return num1
    End Function

    Public Shared Function GetLcd(numberList As List(Of Long)) As Long

        Dim max = numberList.Max()
        Dim number = 0

NextNumber:
        number += max
        For index = 0 To numberList.Count() - 1
            If number Mod numberList(index) <> 0 Then
                GoTo NextNumber
            End If
        Next
        Return number

    End Function

    Public Shared Function Factorial(number As Long) As Long
        For i = number - 1 To 1 Step -1
            number *= i
        Next
        Return number
    End Function

End Class

Module StringExtensions

    <Extension()>
    Function ContainsAllItems(Of T)(a As IEnumerable(Of T), b As IEnumerable(Of T)) As Boolean
        Return Not b.Except(a).Any()
    End Function

End Module

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
