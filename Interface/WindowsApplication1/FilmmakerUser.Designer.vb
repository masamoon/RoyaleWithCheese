<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilmmakerUser
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Reviews = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Lists = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Subscriptions = New System.Windows.Forms.TabPage()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Roles = New System.Windows.Forms.TabPage()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Location_box = New System.Windows.Forms.TextBox()
        Me.Username_box = New System.Windows.Forms.TextBox()
        Me.Fullname_box = New System.Windows.Forms.TextBox()
        Me.Bio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Birthdate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubscribeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rewardTextBox = New System.Windows.Forms.TextBox()
        Me.RewardLabel = New System.Windows.Forms.Label()
        Me.UpdateRewardButton = New System.Windows.Forms.Button()
        Me.UnsubscribeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.Reviews.SuspendLayout()
        Me.Lists.SuspendLayout()
        Me.Subscriptions.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Roles.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Reviews)
        Me.TabControl1.Controls.Add(Me.Lists)
        Me.TabControl1.Controls.Add(Me.Subscriptions)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.Roles)
        Me.TabControl1.Location = New System.Drawing.Point(83, 343)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 203)
        Me.TabControl1.TabIndex = 5
        '
        'Reviews
        '
        Me.Reviews.Controls.Add(Me.ListBox1)
        Me.Reviews.Location = New System.Drawing.Point(4, 22)
        Me.Reviews.Name = "Reviews"
        Me.Reviews.Padding = New System.Windows.Forms.Padding(3)
        Me.Reviews.Size = New System.Drawing.Size(358, 177)
        Me.Reviews.TabIndex = 0
        Me.Reviews.Text = "Reviews"
        Me.Reviews.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-4, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(359, 173)
        Me.ListBox1.TabIndex = 0
        '
        'Lists
        '
        Me.Lists.Controls.Add(Me.ListBox2)
        Me.Lists.Location = New System.Drawing.Point(4, 22)
        Me.Lists.Name = "Lists"
        Me.Lists.Padding = New System.Windows.Forms.Padding(3)
        Me.Lists.Size = New System.Drawing.Size(358, 177)
        Me.Lists.TabIndex = 1
        Me.Lists.Text = "Lists"
        Me.Lists.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(0, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(359, 173)
        Me.ListBox2.TabIndex = 1
        '
        'Subscriptions
        '
        Me.Subscriptions.Controls.Add(Me.ListBox3)
        Me.Subscriptions.Location = New System.Drawing.Point(4, 22)
        Me.Subscriptions.Name = "Subscriptions"
        Me.Subscriptions.Padding = New System.Windows.Forms.Padding(3)
        Me.Subscriptions.Size = New System.Drawing.Size(358, 177)
        Me.Subscriptions.TabIndex = 2
        Me.Subscriptions.Text = "Subscriptions"
        Me.Subscriptions.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(0, 2)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(359, 173)
        Me.ListBox3.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(358, 177)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Participations"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(0, 2)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(359, 173)
        Me.ListBox4.TabIndex = 1
        '
        'Roles
        '
        Me.Roles.Controls.Add(Me.ListBox5)
        Me.Roles.Location = New System.Drawing.Point(4, 22)
        Me.Roles.Name = "Roles"
        Me.Roles.Padding = New System.Windows.Forms.Padding(3)
        Me.Roles.Size = New System.Drawing.Size(358, 177)
        Me.Roles.TabIndex = 4
        Me.Roles.Text = "Roles"
        Me.Roles.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(0, 2)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(359, 173)
        Me.ListBox5.TabIndex = 2
        '
        'Location_box
        '
        Me.Location_box.Enabled = False
        Me.Location_box.Location = New System.Drawing.Point(349, 149)
        Me.Location_box.Name = "Location_box"
        Me.Location_box.Size = New System.Drawing.Size(100, 20)
        Me.Location_box.TabIndex = 8
        '
        'Username_box
        '
        Me.Username_box.Enabled = False
        Me.Username_box.Location = New System.Drawing.Point(349, 123)
        Me.Username_box.Name = "Username_box"
        Me.Username_box.Size = New System.Drawing.Size(100, 20)
        Me.Username_box.TabIndex = 7
        '
        'Fullname_box
        '
        Me.Fullname_box.Enabled = False
        Me.Fullname_box.Location = New System.Drawing.Point(349, 97)
        Me.Fullname_box.Name = "Fullname_box"
        Me.Fullname_box.Size = New System.Drawing.Size(100, 20)
        Me.Fullname_box.TabIndex = 6
        '
        'Bio
        '
        Me.Bio.Location = New System.Drawing.Point(83, 220)
        Me.Bio.Multiline = True
        Me.Bio.Name = "Bio"
        Me.Bio.ReadOnly = True
        Me.Bio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Bio.Size = New System.Drawing.Size(359, 117)
        Me.Bio.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bio"
        '
        'Birthdate
        '
        Me.Birthdate.Enabled = False
        Me.Birthdate.Location = New System.Drawing.Point(349, 175)
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Size = New System.Drawing.Size(100, 20)
        Me.Birthdate.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Birthdate"
        '
        'SubscribeButton
        '
        Me.SubscribeButton.Location = New System.Drawing.Point(489, 32)
        Me.SubscribeButton.Name = "SubscribeButton"
        Me.SubscribeButton.Size = New System.Drawing.Size(81, 51)
        Me.SubscribeButton.TabIndex = 16
        Me.SubscribeButton.Text = "Subscribe"
        Me.SubscribeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Movie Page"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rewardTextBox
        '
        Me.rewardTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rewardTextBox.Location = New System.Drawing.Point(366, 35)
        Me.rewardTextBox.MaxLength = 2
        Me.rewardTextBox.Multiline = True
        Me.rewardTextBox.Name = "rewardTextBox"
        Me.rewardTextBox.Size = New System.Drawing.Size(36, 31)
        Me.rewardTextBox.TabIndex = 18
        '
        'RewardLabel
        '
        Me.RewardLabel.AutoSize = True
        Me.RewardLabel.Location = New System.Drawing.Point(313, 46)
        Me.RewardLabel.Name = "RewardLabel"
        Me.RewardLabel.Size = New System.Drawing.Size(47, 13)
        Me.RewardLabel.TabIndex = 19
        Me.RewardLabel.Text = "Reward:"
        '
        'UpdateRewardButton
        '
        Me.UpdateRewardButton.Location = New System.Drawing.Point(408, 41)
        Me.UpdateRewardButton.Name = "UpdateRewardButton"
        Me.UpdateRewardButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateRewardButton.TabIndex = 20
        Me.UpdateRewardButton.Text = "Update"
        Me.UpdateRewardButton.UseVisualStyleBackColor = True
        '
        'UnsubscribeButton
        '
        Me.UnsubscribeButton.Location = New System.Drawing.Point(489, 32)
        Me.UnsubscribeButton.Name = "UnsubscribeButton"
        Me.UnsubscribeButton.Size = New System.Drawing.Size(81, 51)
        Me.UnsubscribeButton.TabIndex = 21
        Me.UnsubscribeButton.Text = "Unsubscribe"
        Me.UnsubscribeButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.usr_jpg
        Me.PictureBox1.Location = New System.Drawing.Point(124, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'FilmmakerUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UnsubscribeButton)
        Me.Controls.Add(Me.UpdateRewardButton)
        Me.Controls.Add(Me.RewardLabel)
        Me.Controls.Add(Me.rewardTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SubscribeButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Birthdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bio)
        Me.Controls.Add(Me.Location_box)
        Me.Controls.Add(Me.Username_box)
        Me.Controls.Add(Me.Fullname_box)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FilmmakerUser"
        Me.Text = "FilmmakerUser"
        Me.TabControl1.ResumeLayout(False)
        Me.Reviews.ResumeLayout(False)
        Me.Lists.ResumeLayout(False)
        Me.Subscriptions.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Roles.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Reviews As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Lists As TabPage
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Subscriptions As TabPage
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Location_box As TextBox
    Friend WithEvents Username_box As TextBox
    Friend WithEvents Fullname_box As TextBox
    Friend WithEvents Bio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Birthdate As TextBox
    Friend WithEvents Roles As TabPage
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SubscribeButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rewardTextBox As TextBox
    Friend WithEvents RewardLabel As Label
    Friend WithEvents UpdateRewardButton As Button
    Friend WithEvents UnsubscribeButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
