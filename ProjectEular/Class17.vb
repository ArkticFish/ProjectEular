Imports System.Text

Public Class Class17

    Public Sub Solve()

        Dim allNumbers As New StringBuilder()

        For index = 1 To 1000

            allNumbers.Append(NumberToWords(index).Replace(" ", "").Replace("-", ""))

        Next

        Console.WriteLine($"{allNumbers.Length}")

    End Sub

    Public Shared Function NumberToWords(ByVal number As Integer) As String
        If number = 0 Then Return "zero"
        If number < 0 Then Return "minus " & NumberToWords(Math.Abs(number))
        Dim words As String = ""

        If (Math.Floor(number / 1000000)) > 0 Then
            words += NumberToWords(Math.Floor(number / 1000000)) & " million "
            number = number Mod 1000000
        End If

        If (Math.Floor(number / 1000)) > 0 Then
            words += NumberToWords(Math.Floor(number / 1000)) & " thousand "
            number = number Mod 1000
        End If

        If (Math.Floor(number / 100)) > 0 Then
            words += NumberToWords(Math.Floor(number / 100)) & " hundred "
            number = number Mod 100
        End If

        If number > 0 Then
            If words <> "" Then words += "and "
            Dim unitsMap = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"}
            Dim tensMap = {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}

            If number < 20 Then
                words += unitsMap(number)
            Else
                words += tensMap(Math.Floor(number / 10))
                If (number Mod 10) > 0 Then words += "-" & unitsMap(number Mod 10)
            End If
        End If

        Return words
    End Function

End Class
