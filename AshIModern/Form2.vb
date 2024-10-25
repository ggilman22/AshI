Public Class Form2

    Public path As String
    Public fileName As String
    Public incrementOnly As Boolean = My.Settings.incrementOnlyMode
    Public firstPath As System.Collections.Specialized.StringCollection

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim save As DialogResult = MessageBox.Show("Save settings?", "Settings", MessageBoxButtons.YesNoCancel)
        If save = DialogResult.Yes Then
            fileName = fileNameTextbox.Text
            My.Settings.textFileName = fileName
            My.Settings.textNameExt = fileName + txtExt.Text

            If incrementOnly = True Then
                Form1.displayButton.Enabled = False
            Else
                Form1.displayButton.Enabled = True
            End If
            My.Settings.incrementOnlyMode = incrementOnly
            My.Settings.Save()
            Dispose()
        ElseIf save = DialogResult.No Then
            Dispose()
        End If
    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        FolderBrowserDialog1.ShowDialog()
        path = FolderBrowserDialog1.SelectedPath
        textFilePath.Text = path
        My.Settings.filePath = path
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayMethOBS.Checked = My.Settings.methodIsDisplayed
        textFilePath.Text = My.Settings.filePath
        fileNameTextbox.Text = My.Settings.textFileName
        txtExt.Text = ".txt"
        incrementOnlyMode.Checked = incrementOnly
        Dim pathIndex As Int16 = 0
        If My.Settings.methodPaths IsNot Nothing Then
            Do Until methodPathsList.Items.Count = My.Settings.methodPaths.Count
                methodPathsList.Items.Add(My.Settings.methodPaths(pathIndex))
                pathIndex += 1
            Loop
        End If
    End Sub

    Private Sub incrementOnlyMode_CheckedChanged(sender As Object, e As EventArgs) Handles incrementOnlyMode.CheckedChanged
        If incrementOnlyMode.Checked = True Then
            incrementOnly = True
        Else
            incrementOnly = False
        End If
        My.Settings.incrementOnlyMode = incrementOnly
    End Sub

    Private Sub addPath_Click(sender As Object, e As EventArgs) Handles addPath.Click
        FolderBrowserDialog1.ShowDialog()
        methodPathsList.Items.Add(FolderBrowserDialog1.SelectedPath)
        My.Settings.methodPaths.Add(FolderBrowserDialog1.SelectedPath)
    End Sub

    Private Sub removePath_Click(sender As Object, e As EventArgs) Handles removePath.Click
        For Each item In My.Settings.methodPaths
            If item = methodPathsList.SelectedItem Then
                My.Settings.methodPaths.Remove(item)
                Exit For
            End If
        Next item
        methodPathsList.Items.Remove(methodPathsList.SelectedItem)
    End Sub

    Private Sub displayMethOBS_CheckedChanged(sender As Object, e As EventArgs) Handles displayMethOBS.CheckedChanged
        If displayMethOBS.Checked = True Then
            My.Settings.methodIsDisplayed = True
        Else
            My.Settings.methodIsDisplayed = False
        End If
    End Sub
End Class