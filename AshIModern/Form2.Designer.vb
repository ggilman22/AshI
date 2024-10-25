<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits ReaLTaiizor.Forms.PoisonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PoisonTabControl1 = New ReaLTaiizor.Controls.PoisonTabControl()
        TabPage1 = New TabPage()
        displayMethOBS = New ReaLTaiizor.Controls.PoisonCheckBox()
        incrementOnlyMode = New ReaLTaiizor.Controls.PoisonCheckBox()
        TabPage2 = New TabPage()
        removePath = New ReaLTaiizor.Controls.PoisonButton()
        addPath = New ReaLTaiizor.Controls.PoisonButton()
        browse = New ReaLTaiizor.Controls.PoisonButton()
        methodPathLabel = New ReaLTaiizor.Controls.PoisonLabel()
        txtExt = New ReaLTaiizor.Controls.PoisonLabel()
        fileNameTextbox = New ReaLTaiizor.Controls.PoisonTextBox()
        fileNameLabel = New ReaLTaiizor.Controls.PoisonLabel()
        textFilePath = New ReaLTaiizor.Controls.PoisonTextBox()
        textPathLabel = New ReaLTaiizor.Controls.PoisonLabel()
        methodPathsList = New ListBox()
        saveButton = New ReaLTaiizor.Controls.PoisonButton()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        PoisonTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PoisonTabControl1
        ' 
        PoisonTabControl1.Controls.Add(TabPage1)
        PoisonTabControl1.Controls.Add(TabPage2)
        PoisonTabControl1.Location = New Point(20, 60)
        PoisonTabControl1.Name = "PoisonTabControl1"
        PoisonTabControl1.Padding = New Point(6, 8)
        PoisonTabControl1.SelectedIndex = 0
        PoisonTabControl1.Size = New Size(305, 346)
        PoisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        PoisonTabControl1.TabIndex = 0
        PoisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        PoisonTabControl1.UseSelectable = True
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(displayMethOBS)
        TabPage1.Controls.Add(incrementOnlyMode)
        TabPage1.Location = New Point(4, 38)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(297, 304)
        TabPage1.TabIndex = 0
        TabPage1.Text = "General"
        ' 
        ' displayMethOBS
        ' 
        displayMethOBS.AutoSize = True
        displayMethOBS.Location = New Point(6, 27)
        displayMethOBS.Name = "displayMethOBS"
        displayMethOBS.Size = New Size(144, 15)
        displayMethOBS.TabIndex = 1
        displayMethOBS.Text = "Display Method in OBS"
        displayMethOBS.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        displayMethOBS.UseSelectable = True
        ' 
        ' incrementOnlyMode
        ' 
        incrementOnlyMode.AutoSize = True
        incrementOnlyMode.Location = New Point(6, 6)
        incrementOnlyMode.Name = "incrementOnlyMode"
        incrementOnlyMode.Size = New Size(139, 15)
        incrementOnlyMode.TabIndex = 0
        incrementOnlyMode.Text = "Increment Only Mode"
        incrementOnlyMode.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        incrementOnlyMode.UseSelectable = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.Controls.Add(removePath)
        TabPage2.Controls.Add(addPath)
        TabPage2.Controls.Add(browse)
        TabPage2.Controls.Add(methodPathLabel)
        TabPage2.Controls.Add(txtExt)
        TabPage2.Controls.Add(fileNameTextbox)
        TabPage2.Controls.Add(fileNameLabel)
        TabPage2.Controls.Add(textFilePath)
        TabPage2.Controls.Add(textPathLabel)
        TabPage2.Controls.Add(methodPathsList)
        TabPage2.Location = New Point(4, 38)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(297, 304)
        TabPage2.TabIndex = 1
        TabPage2.Text = "File Paths"
        ' 
        ' removePath
        ' 
        removePath.ForeColor = SystemColors.Control
        removePath.Location = New Point(150, 260)
        removePath.Name = "removePath"
        removePath.Size = New Size(62, 20)
        removePath.TabIndex = 9
        removePath.Text = "Remove"
        removePath.UseCustomBackColor = True
        removePath.UseCustomForeColor = True
        removePath.UseSelectable = True
        ' 
        ' addPath
        ' 
        addPath.ForeColor = SystemColors.Control
        addPath.Location = New Point(218, 260)
        addPath.Name = "addPath"
        addPath.Size = New Size(62, 20)
        addPath.TabIndex = 8
        addPath.Text = "Add"
        addPath.UseCustomBackColor = True
        addPath.UseCustomForeColor = True
        addPath.UseSelectable = True
        ' 
        ' browse
        ' 
        browse.ForeColor = SystemColors.Control
        browse.Location = New Point(229, 54)
        browse.Name = "browse"
        browse.Size = New Size(62, 20)
        browse.TabIndex = 2
        browse.Text = "Browse"
        browse.UseCustomBackColor = True
        browse.UseCustomForeColor = True
        browse.UseSelectable = True
        ' 
        ' methodPathLabel
        ' 
        methodPathLabel.AutoSize = True
        methodPathLabel.Location = New Point(6, 160)
        methodPathLabel.Name = "methodPathLabel"
        methodPathLabel.Size = New Size(139, 19)
        methodPathLabel.TabIndex = 6
        methodPathLabel.Text = "File Paths for Methods"
        methodPathLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' txtExt
        ' 
        txtExt.AutoSize = True
        txtExt.Location = New Point(265, 119)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(26, 19)
        txtExt.TabIndex = 5
        txtExt.Text = ".txt"
        txtExt.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' fileNameTextbox
        ' 
        ' 
        ' 
        ' 
        fileNameTextbox.CustomButton.Image = Nothing
        fileNameTextbox.CustomButton.Location = New Point(231, 1)
        fileNameTextbox.CustomButton.Name = ""
        fileNameTextbox.CustomButton.Size = New Size(21, 21)
        fileNameTextbox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        fileNameTextbox.CustomButton.TabIndex = 1
        fileNameTextbox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        fileNameTextbox.CustomButton.UseSelectable = True
        fileNameTextbox.CustomButton.Visible = False
        fileNameTextbox.Location = New Point(6, 115)
        fileNameTextbox.MaxLength = 32767
        fileNameTextbox.Name = "fileNameTextbox"
        fileNameTextbox.PasswordChar = ChrW(0)
        fileNameTextbox.ScrollBars = ScrollBars.None
        fileNameTextbox.SelectedText = ""
        fileNameTextbox.SelectionLength = 0
        fileNameTextbox.SelectionStart = 0
        fileNameTextbox.ShortcutsEnabled = True
        fileNameTextbox.Size = New Size(253, 23)
        fileNameTextbox.TabIndex = 4
        fileNameTextbox.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        fileNameTextbox.UseSelectable = True
        fileNameTextbox.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        fileNameTextbox.WaterMarkFont = New Font("Segoe UI", 12.0F, FontStyle.Italic, GraphicsUnit.Pixel)
        ' 
        ' fileNameLabel
        ' 
        fileNameLabel.AutoSize = True
        fileNameLabel.Location = New Point(6, 93)
        fileNameLabel.Name = "fileNameLabel"
        fileNameLabel.Size = New Size(95, 19)
        fileNameLabel.TabIndex = 3
        fileNameLabel.Text = "Text File Name"
        fileNameLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' textFilePath
        ' 
        ' 
        ' 
        ' 
        textFilePath.CustomButton.Image = Nothing
        textFilePath.CustomButton.Location = New Point(263, 1)
        textFilePath.CustomButton.Name = ""
        textFilePath.CustomButton.Size = New Size(21, 21)
        textFilePath.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        textFilePath.CustomButton.TabIndex = 1
        textFilePath.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        textFilePath.CustomButton.UseSelectable = True
        textFilePath.CustomButton.Visible = False
        textFilePath.Location = New Point(6, 25)
        textFilePath.MaxLength = 32767
        textFilePath.Name = "textFilePath"
        textFilePath.PasswordChar = ChrW(0)
        textFilePath.ScrollBars = ScrollBars.None
        textFilePath.SelectedText = ""
        textFilePath.SelectionLength = 0
        textFilePath.SelectionStart = 0
        textFilePath.ShortcutsEnabled = True
        textFilePath.Size = New Size(285, 23)
        textFilePath.TabIndex = 1
        textFilePath.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        textFilePath.UseSelectable = True
        textFilePath.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        textFilePath.WaterMarkFont = New Font("Segoe UI", 12.0F, FontStyle.Italic, GraphicsUnit.Pixel)
        ' 
        ' textPathLabel
        ' 
        textPathLabel.AutoSize = True
        textPathLabel.Location = New Point(6, 3)
        textPathLabel.Name = "textPathLabel"
        textPathLabel.Size = New Size(84, 19)
        textPathLabel.TabIndex = 0
        textPathLabel.Text = "Text File Path"
        textPathLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' methodPathsList
        ' 
        methodPathsList.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        methodPathsList.BorderStyle = BorderStyle.FixedSingle
        methodPathsList.ForeColor = SystemColors.Menu
        methodPathsList.FormattingEnabled = True
        methodPathsList.ItemHeight = 15
        methodPathsList.Location = New Point(6, 182)
        methodPathsList.Name = "methodPathsList"
        methodPathsList.Size = New Size(285, 107)
        methodPathsList.TabIndex = 10
        ' 
        ' saveButton
        ' 
        saveButton.ForeColor = SystemColors.Control
        saveButton.Location = New Point(223, 412)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(92, 23)
        saveButton.TabIndex = 1
        saveButton.Text = "Save and Close"
        saveButton.UseCustomBackColor = True
        saveButton.UseCustomForeColor = True
        saveButton.UseSelectable = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 450)
        Controls.Add(saveButton)
        Controls.Add(PoisonTabControl1)
        MaximizeBox = False
        MaximumSize = New Size(1920, 1032)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form2"
        Resizable = False
        RightToLeftLayout = True
        ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.DropShadow
        Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        Text = "Settings"
        Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        TransparencyKey = Color.Fuchsia
        PoisonTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PoisonTabControl1 As ReaLTaiizor.Controls.PoisonTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents incrementOnlyMode As ReaLTaiizor.Controls.PoisonCheckBox
    Friend WithEvents displayMethOBS As ReaLTaiizor.Controls.PoisonCheckBox
    Friend WithEvents saveButton As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents textPathLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents textFilePath As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents fileNameLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtExt As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents fileNameTextbox As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents methodPathLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents browse As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents removePath As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents addPath As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents methodPathsList As ListBox
End Class
