Imports System.IO

Public Class Class59

    Private key() As Byte = New Byte() {97, 97, 97}

    Public Sub Solve()

        Dim cipherBytes As Byte() = File.ReadAllText("p059_cipher.txt").Split(",").Select(Function(val) Byte.Parse(val)).ToArray()

        For index = 1 To 26 * 26 * 26

            Dim originalSum As Long = 0
            Dim originalBytes As Byte() = New Byte(cipherBytes.Length) {}

            Dim keyIndex = 0

            For i = 0 To cipherBytes.Count() - 1

                Dim thisByte = cipherBytes(i) Xor key(keyIndex)
                If thisByte < 32 Or thisByte > 125 Then
                    GoTo NextKey
                End If

                originalBytes(i) = thisByte

                originalSum += originalBytes(i)

                keyIndex += 1
                If keyIndex = key.Length Then
                    keyIndex = 0
                End If

            Next

            Console.WriteLine($"{key(0)},{key(1)},{key(2)}")

            Dim originalText = String.Concat(originalBytes.Select(Function(val) Chr(val)))

            File.AppendAllText("originalText.txt", originalSum & vbNewLine & originalText & vbNewLine)

NextKey:

            AddToKey()

        Next

        Console.WriteLine("Done")

    End Sub

    Public Sub AddToKey()

        key(2) += 1
        If (key(2) = 123) Then
            key(1) += 1
            key(2) = 97
        End If

        If (key(1) = 123) Then
            key(0) += 1
            key(1) = 97
        End If

        If (key(0) = 123) Then
            key(0) = 97
            key(1) = 97
            key(2) = 97
        End If

    End Sub

End Class
