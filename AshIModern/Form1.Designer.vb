<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits ReaLTaiizor.Forms.PoisonForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PoisonTabControl1 = New ReaLTaiizor.Controls.PoisonTabControl()
        TabPage1 = New TabPage()
        oddsOfFailLabel = New ReaLTaiizor.Controls.PoisonLabel()
        oddsOfSuccLable = New ReaLTaiizor.Controls.PoisonLabel()
        oddsLabel = New ReaLTaiizor.Controls.PoisonLabel()
        methodLabel = New ReaLTaiizor.Controls.PoisonLabel()
        numericUpDown = New ReaLTaiizor.Controls.PoisonPanel()
        displayButton = New ReaLTaiizor.Controls.PoisonButton()
        numericUp = New ReaLTaiizor.Controls.PoisonButton()
        numericDown = New ReaLTaiizor.Controls.PoisonButton()
        numericUpDownValue = New Syncfusion.WinForms.Input.SfNumericTextBox()
        methodRefresh = New ReaLTaiizor.Controls.PoisonButton()
        PoisonLabel4 = New ReaLTaiizor.Controls.PoisonLabel()
        methodsList = New ListBox()
        TabPage2 = New TabPage()
        oddsList = New ListBox()
        PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        encountersTextbox = New Syncfusion.WinForms.Input.SfNumericTextBox()
        addNewButton = New ReaLTaiizor.Controls.PoisonButton()
        PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        oddsDenomTextbox = New Syncfusion.WinForms.Input.SfNumericTextBox()
        oddsNumTextbox = New Syncfusion.WinForms.Input.SfNumericTextBox()
        PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        NightButton1 = New ReaLTaiizor.Controls.NightButton()
        progressiveMethodCheck = New ReaLTaiizor.Controls.PoisonCheckBox()
        shinyCharmCheck = New ReaLTaiizor.Controls.PoisonCheckBox()
        methodNameText = New ReaLTaiizor.Controls.PoisonTextBox()
        settingsButton = New ReaLTaiizor.Controls.PoisonButton()
        helpButton = New ReaLTaiizor.Controls.PoisonButton()
        SaveFileDialog1 = New SaveFileDialog()
        removeStage = New ReaLTaiizor.Controls.PoisonButton()
        PoisonTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        numericUpDown.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PoisonTabControl1
        ' 
        PoisonTabControl1.Controls.Add(TabPage1)
        PoisonTabControl1.Controls.Add(TabPage2)
        PoisonTabControl1.Location = New Point(8, 68)
        PoisonTabControl1.Multiline = True
        PoisonTabControl1.Name = "PoisonTabControl1"
        PoisonTabControl1.Padding = New Point(6, 8)
        PoisonTabControl1.SelectedIndex = 0
        PoisonTabControl1.Size = New Size(618, 449)
        PoisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        PoisonTabControl1.TabIndex = 0
        PoisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        PoisonTabControl1.UseSelectable = True
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(oddsOfFailLabel)
        TabPage1.Controls.Add(oddsOfSuccLable)
        TabPage1.Controls.Add(oddsLabel)
        TabPage1.Controls.Add(methodLabel)
        TabPage1.Controls.Add(numericUpDown)
        TabPage1.Controls.Add(methodRefresh)
        TabPage1.Controls.Add(PoisonLabel4)
        TabPage1.Controls.Add(methodsList)
        TabPage1.Location = New Point(4, 38)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(610, 407)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Incrementor"
        ' 
        ' oddsOfFailLabel
        ' 
        oddsOfFailLabel.AutoSize = True
        oddsOfFailLabel.Location = New Point(203, 82)
        oddsOfFailLabel.Name = "oddsOfFailLabel"
        oddsOfFailLabel.Size = New Size(126, 19)
        oddsOfFailLabel.TabIndex = 8
        oddsOfFailLabel.Text = "Odds of No Success"
        oddsOfFailLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' oddsOfSuccLable
        ' 
        oddsOfSuccLable.AutoSize = True
        oddsOfSuccLable.Location = New Point(203, 63)
        oddsOfSuccLable.Name = "oddsOfSuccLable"
        oddsOfSuccLable.Size = New Size(104, 19)
        oddsOfSuccLable.TabIndex = 7
        oddsOfSuccLable.Text = "Odds of Success"
        oddsOfSuccLable.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' oddsLabel
        ' 
        oddsLabel.AutoSize = True
        oddsLabel.Location = New Point(203, 44)
        oddsLabel.Name = "oddsLabel"
        oddsLabel.Size = New Size(75, 19)
        oddsLabel.TabIndex = 6
        oddsLabel.Text = "Shiny Odds"
        oddsLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' methodLabel
        ' 
        methodLabel.AutoSize = True
        methodLabel.Location = New Point(203, 25)
        methodLabel.Name = "methodLabel"
        methodLabel.Size = New Size(55, 19)
        methodLabel.TabIndex = 5
        methodLabel.Text = "Method"
        methodLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' numericUpDown
        ' 
        numericUpDown.Controls.Add(displayButton)
        numericUpDown.Controls.Add(numericUp)
        numericUpDown.Controls.Add(numericDown)
        numericUpDown.Controls.Add(numericUpDownValue)
        numericUpDown.HorizontalScrollbarBarColor = True
        numericUpDown.HorizontalScrollbarHighlightOnWheel = False
        numericUpDown.HorizontalScrollbarSize = 10
        numericUpDown.Location = New Point(411, 314)
        numericUpDown.Name = "numericUpDown"
        numericUpDown.Size = New Size(200, 90)
        numericUpDown.TabIndex = 4
        numericUpDown.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        numericUpDown.VerticalScrollbarBarColor = True
        numericUpDown.VerticalScrollbarHighlightOnWheel = False
        numericUpDown.VerticalScrollbarSize = 10
        ' 
        ' displayButton
        ' 
        displayButton.BackColor = Color.Transparent
        displayButton.BackgroundImageLayout = ImageLayout.Center
        displayButton.ForeColor = SystemColors.Control
        displayButton.Location = New Point(3, 61)
        displayButton.Name = "displayButton"
        displayButton.Size = New Size(194, 23)
        displayButton.TabIndex = 5
        displayButton.Text = "Display"
        displayButton.UseCustomBackColor = True
        displayButton.UseCustomForeColor = True
        displayButton.UseSelectable = True
        displayButton.UseVisualStyleBackColor = False
        ' 
        ' numericUp
        ' 
        numericUp.BackColor = Color.Transparent
        numericUp.BackgroundImage = CType(resources.GetObject("numericUp.BackgroundImage"), Image)
        numericUp.BackgroundImageLayout = ImageLayout.Center
        numericUp.Location = New Point(137, 32)
        numericUp.Name = "numericUp"
        numericUp.Size = New Size(60, 23)
        numericUp.TabIndex = 4
        numericUp.UseSelectable = True
        numericUp.UseVisualStyleBackColor = False
        ' 
        ' numericDown
        ' 
        numericDown.BackColor = Color.Transparent
        numericDown.BackgroundImage = CType(resources.GetObject("numericDown.BackgroundImage"), Image)
        numericDown.BackgroundImageLayout = ImageLayout.Center
        numericDown.Location = New Point(3, 32)
        numericDown.Name = "numericDown"
        numericDown.Size = New Size(60, 23)
        numericDown.TabIndex = 3
        numericDown.UseSelectable = True
        numericDown.UseVisualStyleBackColor = False
        ' 
        ' numericUpDownValue
        ' 
        numericUpDownValue.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        numericUpDownValue.ForeColor = SystemColors.Menu
        numericUpDownValue.HideTrailingZeros = True
        numericUpDownValue.Location = New Point(3, 3)
        numericUpDownValue.MinValue = 0R
        numericUpDownValue.Name = "numericUpDownValue"
        numericUpDownValue.Size = New Size(194, 23)
        numericUpDownValue.Style.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        numericUpDownValue.Style.FocusBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        numericUpDownValue.Style.Font = New Font("Microsoft Sans Serif", 8.25F)
        numericUpDownValue.Style.NegativeForeColor = SystemColors.Menu
        numericUpDownValue.Style.PositiveForeColor = SystemColors.Menu
        numericUpDownValue.Style.ZeroForeColor = SystemColors.Menu
        numericUpDownValue.TabIndex = 2
        numericUpDownValue.Text = "0"
        ' 
        ' methodRefresh
        ' 
        methodRefresh.BackColor = Color.Transparent
        methodRefresh.BackgroundImage = CType(resources.GetObject("methodRefresh.BackgroundImage"), Image)
        methodRefresh.BackgroundImageLayout = ImageLayout.Center
        methodRefresh.Location = New Point(163, 356)
        methodRefresh.Name = "methodRefresh"
        methodRefresh.Size = New Size(26, 23)
        methodRefresh.TabIndex = 3
        methodRefresh.UseSelectable = True
        methodRefresh.UseVisualStyleBackColor = False
        ' 
        ' PoisonLabel4
        ' 
        PoisonLabel4.AutoSize = True
        PoisonLabel4.Location = New Point(6, 3)
        PoisonLabel4.Name = "PoisonLabel4"
        PoisonLabel4.Size = New Size(60, 19)
        PoisonLabel4.TabIndex = 0
        PoisonLabel4.Text = "Methods"
        PoisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' methodsList
        ' 
        methodsList.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        methodsList.BorderStyle = BorderStyle.FixedSingle
        methodsList.ForeColor = SystemColors.Menu
        methodsList.FormattingEnabled = True
        methodsList.ItemHeight = 15
        methodsList.Location = New Point(6, 25)
        methodsList.Name = "methodsList"
        methodsList.Size = New Size(191, 362)
        methodsList.TabIndex = 9
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.Controls.Add(removeStage)
        TabPage2.Controls.Add(oddsList)
        TabPage2.Controls.Add(PoisonLabel5)
        TabPage2.Controls.Add(encountersTextbox)
        TabPage2.Controls.Add(addNewButton)
        TabPage2.Controls.Add(PoisonLabel3)
        TabPage2.Controls.Add(oddsDenomTextbox)
        TabPage2.Controls.Add(oddsNumTextbox)
        TabPage2.Controls.Add(PoisonLabel2)
        TabPage2.Controls.Add(PoisonLabel1)
        TabPage2.Controls.Add(NightButton1)
        TabPage2.Controls.Add(progressiveMethodCheck)
        TabPage2.Controls.Add(shinyCharmCheck)
        TabPage2.Controls.Add(methodNameText)
        TabPage2.Location = New Point(4, 38)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(610, 407)
        TabPage2.TabIndex = 1
        TabPage2.Text = "New Method"
        ' 
        ' oddsList
        ' 
        oddsList.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        oddsList.BorderStyle = BorderStyle.FixedSingle
        oddsList.ForeColor = SystemColors.Menu
        oddsList.FormattingEnabled = True
        oddsList.ItemHeight = 15
        oddsList.Location = New Point(6, 209)
        oddsList.Name = "oddsList"
        oddsList.Size = New Size(598, 137)
        oddsList.TabIndex = 19
        ' 
        ' PoisonLabel5
        ' 
        PoisonLabel5.AutoSize = True
        PoisonLabel5.Location = New Point(362, 120)
        PoisonLabel5.Name = "PoisonLabel5"
        PoisonLabel5.Size = New Size(72, 19)
        PoisonLabel5.TabIndex = 18
        PoisonLabel5.Text = "Encounters"
        PoisonLabel5.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' encountersTextbox
        ' 
        encountersTextbox.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        encountersTextbox.BorderStyle = BorderStyle.FixedSingle
        encountersTextbox.ForeColor = SystemColors.Window
        encountersTextbox.HideTrailingZeros = True
        encountersTextbox.Location = New Point(362, 142)
        encountersTextbox.MinValue = 1R
        encountersTextbox.Name = "encountersTextbox"
        encountersTextbox.Size = New Size(242, 23)
        encountersTextbox.Style.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        encountersTextbox.Style.FocusBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        encountersTextbox.Style.Font = New Font("Microsoft Sans Serif", 8.25F)
        encountersTextbox.Style.NegativeForeColor = SystemColors.Window
        encountersTextbox.Style.PositiveForeColor = SystemColors.Window
        encountersTextbox.Style.ZeroForeColor = SystemColors.Window
        encountersTextbox.TabIndex = 17
        encountersTextbox.Text = "1"
        encountersTextbox.Value = 1R
        ' 
        ' addNewButton
        ' 
        addNewButton.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        addNewButton.ForeColor = SystemColors.Control
        addNewButton.Location = New Point(513, 182)
        addNewButton.Name = "addNewButton"
        addNewButton.Size = New Size(91, 21)
        addNewButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        addNewButton.TabIndex = 16
        addNewButton.Text = "Add New Stage"
        addNewButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        addNewButton.UseCustomBackColor = True
        addNewButton.UseCustomForeColor = True
        addNewButton.UseSelectable = True
        addNewButton.UseVisualStyleBackColor = False
        ' 
        ' PoisonLabel3
        ' 
        PoisonLabel3.AutoSize = True
        PoisonLabel3.Location = New Point(3, 187)
        PoisonLabel3.Name = "PoisonLabel3"
        PoisonLabel3.Size = New Size(63, 19)
        PoisonLabel3.TabIndex = 15
        PoisonLabel3.Text = "Odds List"
        PoisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' oddsDenomTextbox
        ' 
        oddsDenomTextbox.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        oddsDenomTextbox.BorderStyle = BorderStyle.FixedSingle
        oddsDenomTextbox.ForeColor = SystemColors.Window
        oddsDenomTextbox.HideTrailingZeros = True
        oddsDenomTextbox.Location = New Point(177, 142)
        oddsDenomTextbox.MinValue = 1R
        oddsDenomTextbox.Name = "oddsDenomTextbox"
        oddsDenomTextbox.Size = New Size(145, 23)
        oddsDenomTextbox.Style.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        oddsDenomTextbox.Style.FocusBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        oddsDenomTextbox.Style.Font = New Font("Microsoft Sans Serif", 8.25F)
        oddsDenomTextbox.Style.NegativeForeColor = SystemColors.Window
        oddsDenomTextbox.Style.PositiveForeColor = SystemColors.Window
        oddsDenomTextbox.Style.ZeroForeColor = SystemColors.Window
        oddsDenomTextbox.TabIndex = 13
        oddsDenomTextbox.Text = "1"
        oddsDenomTextbox.Value = 1R
        ' 
        ' oddsNumTextbox
        ' 
        oddsNumTextbox.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        oddsNumTextbox.BorderStyle = BorderStyle.FixedSingle
        oddsNumTextbox.ForeColor = SystemColors.Window
        oddsNumTextbox.HideTrailingZeros = True
        oddsNumTextbox.Location = New Point(6, 142)
        oddsNumTextbox.MinValue = 1R
        oddsNumTextbox.Name = "oddsNumTextbox"
        oddsNumTextbox.Size = New Size(145, 23)
        oddsNumTextbox.Style.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        oddsNumTextbox.Style.FocusBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        oddsNumTextbox.Style.Font = New Font("Microsoft Sans Serif", 8.25F)
        oddsNumTextbox.Style.NegativeForeColor = SystemColors.Window
        oddsNumTextbox.Style.PositiveForeColor = SystemColors.Window
        oddsNumTextbox.Style.ZeroForeColor = SystemColors.Window
        oddsNumTextbox.TabIndex = 12
        oddsNumTextbox.Text = "1"
        oddsNumTextbox.Value = 1R
        ' 
        ' PoisonLabel2
        ' 
        PoisonLabel2.AutoSize = True
        PoisonLabel2.Location = New Point(157, 146)
        PoisonLabel2.Name = "PoisonLabel2"
        PoisonLabel2.Size = New Size(14, 19)
        PoisonLabel2.TabIndex = 11
        PoisonLabel2.Text = "/"
        PoisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' PoisonLabel1
        ' 
        PoisonLabel1.AutoSize = True
        PoisonLabel1.Location = New Point(3, 120)
        PoisonLabel1.Name = "PoisonLabel1"
        PoisonLabel1.Size = New Size(41, 19)
        PoisonLabel1.TabIndex = 8
        PoisonLabel1.Text = "Odds"
        PoisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        ' 
        ' NightButton1
        ' 
        NightButton1.BackColor = Color.Transparent
        NightButton1.DialogResult = DialogResult.None
        NightButton1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NightButton1.ForeColor = Color.FromArgb(CByte(124), CByte(65), CByte(153))
        NightButton1.HoverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        NightButton1.HoverForeColor = Color.White
        NightButton1.InterpolationType = Drawing2D.InterpolationMode.HighQualityBicubic
        NightButton1.Location = New Point(466, 360)
        NightButton1.MinimumSize = New Size(144, 47)
        NightButton1.Name = "NightButton1"
        NightButton1.NormalBackColor = Color.FromArgb(CByte(124), CByte(65), CByte(153))
        NightButton1.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        NightButton1.PressedBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        NightButton1.PressedForeColor = Color.White
        NightButton1.Radius = 20
        NightButton1.Size = New Size(144, 47)
        NightButton1.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        NightButton1.TabIndex = 7
        NightButton1.Text = "Create Method"
        ' 
        ' progressiveMethodCheck
        ' 
        progressiveMethodCheck.AutoSize = True
        progressiveMethodCheck.Location = New Point(6, 82)
        progressiveMethodCheck.Name = "progressiveMethodCheck"
        progressiveMethodCheck.Size = New Size(148, 15)
        progressiveMethodCheck.TabIndex = 6
        progressiveMethodCheck.Text = "Is a Progressive Method"
        progressiveMethodCheck.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        progressiveMethodCheck.UseSelectable = True
        ' 
        ' shinyCharmCheck
        ' 
        shinyCharmCheck.AutoSize = True
        shinyCharmCheck.Location = New Point(6, 61)
        shinyCharmCheck.Name = "shinyCharmCheck"
        shinyCharmCheck.Size = New Size(114, 15)
        shinyCharmCheck.TabIndex = 5
        shinyCharmCheck.Text = "Has Shiny Charm"
        shinyCharmCheck.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        shinyCharmCheck.UseSelectable = True
        ' 
        ' methodNameText
        ' 
        ' 
        ' 
        ' 
        methodNameText.CustomButton.Image = Nothing
        methodNameText.CustomButton.Location = New Point(576, 2)
        methodNameText.CustomButton.Name = ""
        methodNameText.CustomButton.Size = New Size(19, 19)
        methodNameText.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        methodNameText.CustomButton.TabIndex = 1
        methodNameText.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        methodNameText.CustomButton.UseSelectable = True
        methodNameText.CustomButton.Visible = False
        methodNameText.Lines = New String() {"Name"}
        methodNameText.Location = New Point(6, 17)
        methodNameText.MaxLength = 32767
        methodNameText.Name = "methodNameText"
        methodNameText.PasswordChar = ChrW(0)
        methodNameText.ScrollBars = ScrollBars.None
        methodNameText.SelectedText = ""
        methodNameText.SelectionLength = 0
        methodNameText.SelectionStart = 0
        methodNameText.ShortcutsEnabled = True
        methodNameText.Size = New Size(598, 24)
        methodNameText.TabIndex = 4
        methodNameText.Text = "Name"
        methodNameText.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        methodNameText.UseSelectable = True
        methodNameText.WaterMarkColor = Color.FromArgb(CByte(109), CByte(109), CByte(109))
        methodNameText.WaterMarkFont = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel)
        ' 
        ' settingsButton
        ' 
        settingsButton.BackColor = Color.Transparent
        settingsButton.BackgroundImage = CType(resources.GetObject("settingsButton.BackgroundImage"), Image)
        settingsButton.BackgroundImageLayout = ImageLayout.Center
        settingsButton.Location = New Point(596, 525)
        settingsButton.Name = "settingsButton"
        settingsButton.Size = New Size(26, 23)
        settingsButton.TabIndex = 1
        settingsButton.UseSelectable = True
        settingsButton.UseVisualStyleBackColor = False
        ' 
        ' helpButton
        ' 
        helpButton.BackColor = Color.Transparent
        helpButton.BackgroundImage = CType(resources.GetObject("helpButton.BackgroundImage"), Image)
        helpButton.BackgroundImageLayout = ImageLayout.Center
        helpButton.Location = New Point(564, 525)
        helpButton.Name = "helpButton"
        helpButton.Size = New Size(26, 23)
        helpButton.TabIndex = 2
        helpButton.UseSelectable = True
        helpButton.UseVisualStyleBackColor = False
        ' 
        ' removeStage
        ' 
        removeStage.BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        removeStage.ForeColor = SystemColors.Control
        removeStage.Location = New Point(416, 182)
        removeStage.Name = "removeStage"
        removeStage.Size = New Size(91, 21)
        removeStage.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        removeStage.TabIndex = 20
        removeStage.Text = "Remove Stage"
        removeStage.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        removeStage.UseCustomBackColor = True
        removeStage.UseCustomForeColor = True
        removeStage.UseSelectable = True
        removeStage.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        BackColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        ClientSize = New Size(634, 560)
        Controls.Add(helpButton)
        Controls.Add(settingsButton)
        Controls.Add(PoisonTabControl1)
        Margin = New Padding(1, 2, 1, 2)
        MaximizeBox = False
        MaximumSize = New Size(1920, 1032)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form1"
        Padding = New Padding(8, 68, 8, 9)
        Resizable = False
        ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.DropShadow
        Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple
        Text = "Another Shiny Hunting Incrementor"
        Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark
        TransparencyKey = Color.Fuchsia
        PoisonTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        numericUpDown.ResumeLayout(False)
        numericUpDown.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PoisonTabControl1 As ReaLTaiizor.Controls.PoisonTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents settingsButton As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents helpButton As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents progressiveMethodCheck As ReaLTaiizor.Controls.PoisonCheckBox
    Friend WithEvents shinyCharmCheck As ReaLTaiizor.Controls.PoisonCheckBox
    Friend WithEvents methodNameText As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents NightButton1 As ReaLTaiizor.Controls.NightButton
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents oddsNumTextbox As Syncfusion.WinForms.Input.SfNumericTextBox
    Friend WithEvents oddsDenomTextbox As Syncfusion.WinForms.Input.SfNumericTextBox
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents addNewButton As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PoisonLabel4 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents methodRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents numericUpDown As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents numericUp As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents numericDown As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents numericUpDownValue As Syncfusion.WinForms.Input.SfNumericTextBox
    Friend WithEvents displayButton As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents methodLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents oddsLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents oddsOfFailLabel As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents oddsOfSuccLable As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents methodsList As ListBox
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents encountersTextbox As Syncfusion.WinForms.Input.SfNumericTextBox
    Friend WithEvents oddsList As ListBox
    Friend WithEvents removeStage As ReaLTaiizor.Controls.PoisonButton

End Class
