<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        TextBox2 = New MaterialSkin.Controls.MaterialTextBox2()
        TextBox1 = New MaterialSkin.Controls.MaterialTextBox2()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(303, 13)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(167, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(317, 384)
        MaterialButton1.Margin = New Padding(5, 8, 5, 8)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(102, 36)
        MaterialButton1.TabIndex = 7
        MaterialButton1.Text = "Login Now"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.AnimateReadOnly = False
        TextBox2.BackgroundImageLayout = ImageLayout.None
        TextBox2.CharacterCasing = CharacterCasing.Normal
        TextBox2.Depth = 0
        TextBox2.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TextBox2.HideSelection = True
        TextBox2.Hint = "enter your password"
        TextBox2.LeadingIcon = Nothing
        TextBox2.Location = New Point(227, 312)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.MaxLength = 10
        TextBox2.MouseState = MaterialSkin.MouseState.OUT
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PrefixSuffixText = Nothing
        TextBox2.ReadOnly = False
        TextBox2.RightToLeft = RightToLeft.No
        TextBox2.SelectedText = ""
        TextBox2.SelectionLength = 0
        TextBox2.SelectionStart = 0
        TextBox2.ShortcutsEnabled = True
        TextBox2.Size = New Size(293, 48)
        TextBox2.TabIndex = 5
        TextBox2.TabStop = False
        TextBox2.TextAlign = HorizontalAlignment.Left
        TextBox2.TrailingIcon = Nothing
        TextBox2.UseSystemPasswordChar = False
        ' 
        ' TextBox1
        ' 
        TextBox1.AnimateReadOnly = False
        TextBox1.BackgroundImageLayout = ImageLayout.None
        TextBox1.CharacterCasing = CharacterCasing.Normal
        TextBox1.Depth = 0
        TextBox1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TextBox1.HideSelection = True
        TextBox1.Hint = "enter your username"
        TextBox1.LeadingIcon = Nothing
        TextBox1.Location = New Point(227, 236)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.MaxLength = 100
        TextBox1.MouseState = MaterialSkin.MouseState.OUT
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = ChrW(0)
        TextBox1.PrefixSuffixText = Nothing
        TextBox1.ReadOnly = False
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.SelectedText = ""
        TextBox1.SelectionLength = 0
        TextBox1.SelectionStart = 0
        TextBox1.ShortcutsEnabled = True
        TextBox1.Size = New Size(293, 48)
        TextBox1.TabIndex = 6
        TextBox1.TabStop = False
        TextBox1.TextAlign = HorizontalAlignment.Left
        TextBox1.TrailingIcon = Nothing
        TextBox1.UseSystemPasswordChar = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialButton1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "login"
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialTextBox2
End Class
