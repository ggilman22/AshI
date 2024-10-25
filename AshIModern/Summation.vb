Public Class Summation
    Public oddsNum As UInteger
    Public oddsDenom As UInteger
    Public oddsSig As UInteger
    Public oddsNumProg() As UInt16
    Public oddsDemonProg() As UInt16
    Public numer As Double
    Public denom As Double
    Public Function calcOddsStatic(ByVal encounters As UInteger) As (oddsOfSucc As Double, oddsOfFail As Double)
        Dim percent As Double
        numer = Convert.ToDouble(oddsNum)
        denom = Convert.ToDouble(oddsDenom)
        Dim oddsSucc As Double
        Dim oddsFail As Double
        If encounters > 0 Then

            percent = Math.Pow(1 - (numer / denom), Convert.ToDouble(encounters))

        Else
            oddsSucc = 0
            oddsFail = 100
            Return (oddsSucc, oddsFail)
            Exit Function
        End If
        oddsSig = Convert.ToUInt64((percent) * 1000)
        oddsFail = Convert.ToDouble(oddsSig) / 10
        oddsSucc = Convert.ToDouble(1000 - oddsSig) / 10

        Return (oddsSucc, oddsFail)

    End Function

    Public Function calcOddsProgressive(ByVal encounters As UInt32, ByVal stages As UInt16, ByVal oddsProg As UInt16()) As (oddsOfSucc As Double, oddsOfFail As Double)
        Dim percent As Double
        Dim oddsSucc As Double
        Dim oddsFail As Double
        numer = Convert.ToDouble(oddsNumProg(0))
        denom = Convert.ToDouble(oddsDemonProg(0))
        If encounters > 0 Then
            For i As Int16 = 0 To stages - 1
                numer = Convert.ToDouble(oddsNumProg(i))
                denom = Convert.ToDouble(oddsDemonProg(i))
                If encounters <= oddsProg(i) Then
                    If i = 0 Then
                        percent = Math.Pow(1 - (numer / denom), Convert.ToDouble(encounters))
                        Exit For
                    Else
                        percent *= Math.Pow(1 - (numer / denom), Convert.ToDouble(encounters - oddsProg(i - 1)))
                        Exit For
                    End If
                Else
                    If i = 0 Then
                        percent = Math.Pow(1 - (numer / denom), Convert.ToDouble(oddsProg(i)))
                    Else
                        percent *= Math.Pow(1 - (numer / denom), Convert.ToDouble(oddsProg(i) - oddsProg(i - 1)))
                    End If
                End If
            Next i

            If encounters >= oddsProg(stages - 1) Then
                percent *= Math.Pow(1 - (numer / denom), Convert.ToDouble(encounters - oddsProg(stages - 1)))
            End If
        Else
            oddsSucc = 0
            oddsFail = 100
            Return (oddsSucc, oddsFail)
            Exit Function
        End If

        oddsSig = Convert.ToUInt64((percent) * 1000)
        oddsFail = Convert.ToDouble(oddsSig) / 10
        oddsSucc = Convert.ToDouble(1000 - oddsSig) / 10

        Return (oddsSucc, oddsFail)

    End Function
End Class