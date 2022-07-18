Imports System.Numerics

Public Class Class45

    Public Sub Solve()

        Dim tN As BigInteger = 1
        Dim pN As BigInteger = 1
        Dim hN As BigInteger = 1

        Dim tCur As BigInteger = tN * (tN + 1) / 2
        Dim pCur As BigInteger = pN * (3 * pN - 1) / 2
        Dim hCur As BigInteger = hN * (2 * hN - 1)

        Dim nFound = 0

        While nFound < 5

            If tCur = pCur And pCur = hCur Then
                Console.WriteLine($"T{tN} = P{pN} = H{hN} = {tCur}")

                nFound += 1

                tN += 1
                tCur = tN * (tN + 1) / 2
            End If

            If tCur < pCur Or tCur < hCur Then
                tN += 1
                tCur = tN * (tN + 1) / 2
            End If

            If pCur < tCur Or pCur < hCur Then
                pN += 1
                pCur = pN * (3 * pN - 1) / 2
            End If

            If hCur < tCur Or hCur < pCur Then
                hN += 1
                hCur = hN * (2 * hN - 1)
            End If

        End While

    End Sub

End Class
