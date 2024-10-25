Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim succOdds As Double
    Dim failOdds As Double
    Dim nearly As Boolean
    Dim ashM As New ashMFunctions
    Dim odds(,) As UInt16
    Dim encounterStages() As UInt16
    Dim methodName As String
    Dim isShinyCharm As Boolean
    Dim isProgressive As Boolean
    Dim stages As UInt16
    Dim oddsCalc As New Summation()


    Public Sub loadMethod(ByVal methodFile As String)
        ashM.readAshM(methodFile)
        methodName = ashM.methodName
        isShinyCharm = ashM.isShinyCharm
        isProgressive = ashM.isProgressive
        stages = ashM.stages
        odds = ashM.odds
        Dim encountersAtEachStage(stages - 1) As UInt16
        oddsCalc.oddsNum = ashM.odds(0, 0)
        oddsCalc.oddsDenom = ashM.odds(0, 1)


        If isProgressive = True Then
            For i As Integer = 0 To stages - 1
                encountersAtEachStage(i) = odds(i, 2)
            Next i
            encounterStages = encountersAtEachStage
        End If
    End Sub

    Private Sub oddsCalcDisp()

        Dim strFile As String = My.Settings.filePath + "\" + My.Settings.textNameExt
        If Convert.ToUInt32(numericUpDownValue.Value) > 0 Then
            If isProgressive = False Then
                oddsCalc.oddsNum = odds(0, 0)
                oddsCalc.oddsDenom = odds(0, 1)
                Dim calcOfOdds = oddsCalc.calcOddsStatic(Convert.ToUInt32(numericUpDownValue.Value))
                failOdds = calcOfOdds.oddsOfFail
                succOdds = calcOfOdds.oddsOfSucc


            Else
                Dim oddsNumProg(stages - 1) As UInt16
                Dim oddsDenomProg(stages - 1) As UInt16
                For i As Int16 = 0 To stages - 1
                    oddsNumProg(i) = odds(i, 0)
                    oddsDenomProg(i) = odds(i, 1)
                Next
                oddsCalc.oddsNumProg = oddsNumProg
                oddsCalc.oddsDemonProg = oddsDenomProg
                Dim calcOfOdds = oddsCalc.calcOddsProgressive(Convert.ToUInt32(numericUpDownValue.Value), stages, encounterStages)
                failOdds = calcOfOdds.oddsOfFail
                succOdds = calcOfOdds.oddsOfSucc

            End If
        Else
            Dim calcOfOdds = oddsCalc.calcOddsStatic(Convert.ToUInt32(numericUpDownValue.Value))
            failOdds = calcOfOdds.oddsOfFail
            succOdds = calcOfOdds.oddsOfSucc
        End If


        oddsLabel.Text = Convert.ToString(oddsCalc.numer) + "/" + Convert.ToString(oddsCalc.denom)
        methodLabel.Text = methodName
        If succOdds <> 100 Then
            nearly = False
        Else
            nearly = True
        End If

        If nearly = False Then
            oddsOfSuccLable.Text = Convert.ToString(succOdds) + "% odds of success by " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) + " encounrters."
            oddsOfFailLabel.Text = Convert.ToString(failOdds) + "% odds of no success by " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) + " encounrters."
            Using sw As New StreamWriter(strFile)
                sw.Write("Encounters = " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) +
             vbCrLf +
            "Odds of Shiny = " + Convert.ToString(succOdds) + "%" +
            vbCrLf +
            "Odds of No Shiny = " + Convert.ToString(failOdds) + "%"
            )


            End Using
        Else
            Using sw As New StreamWriter(strFile)
                sw.Write("Encounters = " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) +
             vbCrLf +
            "Odds of Shiny = Nearly " + Convert.ToString(succOdds) + "%" +
            vbCrLf +
            "Odds of No Shiny = Nearly " + Convert.ToString(failOdds) + "%"
            )


            End Using
            oddsOfSuccLable.Text = "Nearly " + Convert.ToString(succOdds) + "% odds of success by " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) + " encounrters."
            oddsOfFailLabel.Text = "Nearly " + Convert.ToString(failOdds) + "% odds of no success by " + Convert.ToString(Convert.ToUInt32(numericUpDownValue.Value)) + " encounrters."
        End If
        If My.Settings.methodIsDisplayed = True Then
            Using sw As StreamWriter = File.AppendText(strFile)
                sw.WriteLine(vbCrLf)
                sw.WriteLine(methodName)
                sw.WriteLine("Shiny odds " + Convert.ToString(oddsCalc.numer) + "/" + Convert.ToString(oddsCalc.denom))
            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If progressiveMethodCheck.Checked = False Then

            addNewButton.Enabled = False
            oddsList.Enabled = False
            encountersTextbox.Enabled = False
        Else
            addNewButton.Enabled = True
            oddsList.Enabled = True
            encountersTextbox.Enabled = True
        End If

        methodsList.Items.Clear()
        For Each methodPath As String In My.Settings.methodPaths
            For Each ashMFile As String In My.Computer.FileSystem.GetFiles(methodPath)
                If ashMFile.EndsWith(".ashm") Then
                    methodsList.Items.Add(ashMFile)
                End If
            Next
        Next
        If My.Settings.incrementOnlyMode = True Then
            displayButton.Enabled = False
        Else
            displayButton.Enabled = True
        End If
    End Sub

    Private Sub PoisonButton1_Click(sender As Object, e As EventArgs) Handles settingsButton.Click
        Form2.Show()
    End Sub

    Private Sub numericUp_Click(sender As Object, e As EventArgs) Handles numericUp.Click
        numericUpDownValue.Value += 1
        If My.Settings.incrementOnlyMode = True Then
            oddsCalcDisp()
        End If
    End Sub

    Private Sub numericDown_Click(sender As Object, e As EventArgs) Handles numericDown.Click
        numericUpDownValue.Value -= 1
        If My.Settings.incrementOnlyMode = True Then
            oddsCalcDisp()
        End If

    End Sub

    Private Sub methodRefresh_Click(sender As Object, e As EventArgs) Handles methodRefresh.Click
        methodsList.Items.Clear()

        For Each methodPath As String In My.Settings.methodPaths
            For Each ashMFile As String In My.Computer.FileSystem.GetFiles(methodPath)
                If ashMFile.EndsWith(".ashm") Then
                    methodsList.Items.Add(ashMFile)
                End If
            Next
        Next
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        If My.Settings.incrementOnlyMode = False Then
            oddsCalcDisp()
        End If
    End Sub

    Private Sub methodsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles methodsList.SelectedIndexChanged
        If methodsList.SelectedItem IsNot Nothing Then
            loadMethod(methodsList.SelectedItem.ToString)
            oddsCalcDisp()
        End If
    End Sub

    Private Sub numericUpDownValue_TextChanged(sender As Object, e As EventArgs) Handles numericUpDownValue.TextChanged
        If My.Settings.incrementOnlyMode = True Then
            oddsCalcDisp()
        End If
    End Sub

    Private Sub NightButton1_Click(sender As Object, e As EventArgs) Handles NightButton1.Click
        SaveFileDialog1.Filter = "AshM Files (*.ashm*)|*.ashm"
        Dim count As UInt16 = 1
        Dim oddsArray As UInt16(,)
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If progressiveMethodCheck.Checked = True Then
                count = oddsList.Items.Count
                Dim odds(count - 1, 2) As UInt16
                For i As Int16 = 0 To count - 1
                    oddsList.SelectedIndex = i
                    Dim oddsString As String() = oddsList.SelectedItem.ToString.Split(",")
                    For j As Int16 = 0 To 2
                        odds(i, j) = Convert.ToUInt16(oddsString(j))
                    Next j


                Next i
                oddsArray = odds
            Else
                Dim odds(0, 2) As UInt16
                odds(0, 0) = oddsNumTextbox.Value
                odds(0, 1) = oddsDenomTextbox.Value
                odds(0, 2) = 0
                oddsArray = odds
            End If
            ashM.createAshMAndWrite(methodNameText.Text, progressiveMethodCheck.Checked, shinyCharmCheck.Checked, oddsArray, count, SaveFileDialog1.FileName)
            oddsList.Items.Clear()
            shinyCharmCheck.Checked = False
            progressiveMethodCheck.Checked = False
            methodNameText.Text = "Name"
            oddsNumTextbox.Value = 1
            oddsDenomTextbox.Value = 1
            encountersTextbox.Value = 1
        End If
    End Sub

    Private Sub progressiveMethodCheck_CheckedChanged(sender As Object, e As EventArgs) Handles progressiveMethodCheck.CheckedChanged
        If progressiveMethodCheck.Checked = False Then

            addNewButton.Enabled = False
            oddsList.Enabled = False
            encountersTextbox.Enabled = False
            removeStage.Enabled = False
        Else
            addNewButton.Enabled = True
            oddsList.Enabled = True
            encountersTextbox.Enabled = True
            removeStage.Enabled = True
        End If
    End Sub

    Private Sub addNewButton_Click(sender As Object, e As EventArgs) Handles addNewButton.Click
        If progressiveMethodCheck.Checked = True Then
            Dim odds(2) As UShort
            odds(0) = Convert.ToUInt16(oddsNumTextbox.Value)
            odds(1) = Convert.ToUInt16(oddsDenomTextbox.Value)
            odds(2) = Convert.ToUInt16(encountersTextbox.Value)
            Dim oddsString As String
            For Each item In odds
                oddsString += Convert.ToString(item) + ","
            Next
            oddsList.Items.Add(oddsString)
        End If

    End Sub

    Private Sub removeStage_Click(sender As Object, e As EventArgs) Handles removeStage.Click

        oddsList.Items.Remove(oddsList.SelectedItem)

    End Sub
End Class
