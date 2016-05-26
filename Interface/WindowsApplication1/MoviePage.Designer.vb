<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoviePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoviePage))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.synbioTextBox = New System.Windows.Forms.TextBox()
        Me.PosterBox = New System.Windows.Forms.PictureBox()
        Me.UpdateReviewButton = New System.Windows.Forms.Button()
        Me.OverallRatingLabel = New System.Windows.Forms.Label()
        Me.MyRatingLabel = New System.Windows.Forms.Label()
        Me.MyRatingTextBox = New System.Windows.Forms.TextBox()
        Me.OverallRatingTextBox = New System.Windows.Forms.TextBox()
        Me.RuntimeLabel = New System.Windows.Forms.Label()
        Me.RuntimeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.genresLabel = New System.Windows.Forms.Label()
        Me.SeeReviewButton = New System.Windows.Forms.Button()
        Me.myreviewTextBox = New System.Windows.Forms.TextBox()
        Me.my_review = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.reviewsFromFriends = New System.Windows.Forms.Label()
        Me.FriendsReviewsListBox = New System.Windows.Forms.ListBox()
        Me.castLabel = New System.Windows.Forms.Label()
        Me.castAndCrewListBox = New System.Windows.Forms.ListBox()
        Me.filmmakerNameLabel = New System.Windows.Forms.Label()
        Me.filmmakerNameTextBox = New System.Windows.Forms.TextBox()
        Me.filmmakerRoleTextBox = New System.Windows.Forms.TextBox()
        Me.filmmakerRoleLabel = New System.Windows.Forms.Label()
        Me.SeeProfileButton = New System.Windows.Forms.Button()
        Me.hasAccountLabel = New System.Windows.Forms.Label()
        CType(Me.PosterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(12, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(353, 52)
        Me.nameLabel.TabIndex = 5
        Me.nameLabel.Text = "Name Label"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(387, 14)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(41, 19)
        Me.yearLabel.TabIndex = 6
        Me.yearLabel.Text = "Year"
        '
        'synbioTextBox
        '
        Me.synbioTextBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.synbioTextBox.Location = New System.Drawing.Point(186, 64)
        Me.synbioTextBox.Multiline = True
        Me.synbioTextBox.Name = "synbioTextBox"
        Me.synbioTextBox.ReadOnly = True
        Me.synbioTextBox.Size = New System.Drawing.Size(242, 102)
        Me.synbioTextBox.TabIndex = 7
        Me.synbioTextBox.Text = "Synopsis"
        '
        'PosterBox
        '
        Me.PosterBox.Image = CType(resources.GetObject("PosterBox.Image"), System.Drawing.Image)
        Me.PosterBox.Location = New System.Drawing.Point(33, 64)
        Me.PosterBox.Name = "PosterBox"
        Me.PosterBox.Size = New System.Drawing.Size(100, 134)
        Me.PosterBox.TabIndex = 8
        Me.PosterBox.TabStop = False
        '
        'UpdateReviewButton
        '
        Me.UpdateReviewButton.Location = New System.Drawing.Point(375, 249)
        Me.UpdateReviewButton.Name = "UpdateReviewButton"
        Me.UpdateReviewButton.Size = New System.Drawing.Size(53, 31)
        Me.UpdateReviewButton.TabIndex = 37
        Me.UpdateReviewButton.Text = "Update"
        Me.UpdateReviewButton.UseVisualStyleBackColor = True
        '
        'OverallRatingLabel
        '
        Me.OverallRatingLabel.AutoSize = True
        Me.OverallRatingLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallRatingLabel.Location = New System.Drawing.Point(236, 221)
        Me.OverallRatingLabel.Name = "OverallRatingLabel"
        Me.OverallRatingLabel.Size = New System.Drawing.Size(88, 16)
        Me.OverallRatingLabel.TabIndex = 36
        Me.OverallRatingLabel.Text = "Overall Rating"
        '
        'MyRatingLabel
        '
        Me.MyRatingLabel.AutoSize = True
        Me.MyRatingLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRatingLabel.Location = New System.Drawing.Point(255, 256)
        Me.MyRatingLabel.Name = "MyRatingLabel"
        Me.MyRatingLabel.Size = New System.Drawing.Size(64, 16)
        Me.MyRatingLabel.TabIndex = 35
        Me.MyRatingLabel.Text = "My Rating"
        '
        'MyRatingTextBox
        '
        Me.MyRatingTextBox.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRatingTextBox.Location = New System.Drawing.Point(333, 249)
        Me.MyRatingTextBox.Multiline = True
        Me.MyRatingTextBox.Name = "MyRatingTextBox"
        Me.MyRatingTextBox.Size = New System.Drawing.Size(36, 31)
        Me.MyRatingTextBox.TabIndex = 34
        '
        'OverallRatingTextBox
        '
        Me.OverallRatingTextBox.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallRatingTextBox.Location = New System.Drawing.Point(333, 212)
        Me.OverallRatingTextBox.Multiline = True
        Me.OverallRatingTextBox.Name = "OverallRatingTextBox"
        Me.OverallRatingTextBox.ReadOnly = True
        Me.OverallRatingTextBox.Size = New System.Drawing.Size(36, 31)
        Me.OverallRatingTextBox.TabIndex = 33
        '
        'RuntimeLabel
        '
        Me.RuntimeLabel.AutoSize = True
        Me.RuntimeLabel.Location = New System.Drawing.Point(14, 217)
        Me.RuntimeLabel.Name = "RuntimeLabel"
        Me.RuntimeLabel.Size = New System.Drawing.Size(49, 13)
        Me.RuntimeLabel.TabIndex = 30
        Me.RuntimeLabel.Text = "Runtime:"
        '
        'RuntimeTextBox
        '
        Me.RuntimeTextBox.Location = New System.Drawing.Point(66, 217)
        Me.RuntimeTextBox.Name = "RuntimeTextBox"
        Me.RuntimeTextBox.ReadOnly = True
        Me.RuntimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RuntimeTextBox.TabIndex = 29
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(66, 243)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.ReadOnly = True
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 28
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(14, 243)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(46, 13)
        Me.countryLabel.TabIndex = 27
        Me.countryLabel.Text = "Country:"
        '
        'genresLabel
        '
        Me.genresLabel.AutoSize = True
        Me.genresLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genresLabel.Location = New System.Drawing.Point(183, 182)
        Me.genresLabel.Name = "genresLabel"
        Me.genresLabel.Size = New System.Drawing.Size(48, 16)
        Me.genresLabel.TabIndex = 38
        Me.genresLabel.Text = "Genres"
        '
        'SeeReviewButton
        '
        Me.SeeReviewButton.Location = New System.Drawing.Point(234, 524)
        Me.SeeReviewButton.Name = "SeeReviewButton"
        Me.SeeReviewButton.Size = New System.Drawing.Size(194, 39)
        Me.SeeReviewButton.TabIndex = 39
        Me.SeeReviewButton.Text = "See Review"
        Me.SeeReviewButton.UseVisualStyleBackColor = True
        '
        'myreviewTextBox
        '
        Me.myreviewTextBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myreviewTextBox.Location = New System.Drawing.Point(12, 332)
        Me.myreviewTextBox.Multiline = True
        Me.myreviewTextBox.Name = "myreviewTextBox"
        Me.myreviewTextBox.Size = New System.Drawing.Size(185, 186)
        Me.myreviewTextBox.TabIndex = 40
        Me.myreviewTextBox.Text = "MyReviewTextBox"
        '
        'my_review
        '
        Me.my_review.AutoSize = True
        Me.my_review.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.my_review.Location = New System.Drawing.Point(14, 313)
        Me.my_review.Name = "my_review"
        Me.my_review.Size = New System.Drawing.Size(69, 16)
        Me.my_review.TabIndex = 41
        Me.my_review.Text = "My Review"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 31)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'reviewsFromFriends
        '
        Me.reviewsFromFriends.AutoSize = True
        Me.reviewsFromFriends.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewsFromFriends.Location = New System.Drawing.Point(236, 313)
        Me.reviewsFromFriends.Name = "reviewsFromFriends"
        Me.reviewsFromFriends.Size = New System.Drawing.Size(104, 16)
        Me.reviewsFromFriends.TabIndex = 44
        Me.reviewsFromFriends.Text = "Friend's Reviews"
        '
        'FriendsReviewsListBox
        '
        Me.FriendsReviewsListBox.FormattingEnabled = True
        Me.FriendsReviewsListBox.Location = New System.Drawing.Point(234, 332)
        Me.FriendsReviewsListBox.Name = "FriendsReviewsListBox"
        Me.FriendsReviewsListBox.Size = New System.Drawing.Size(194, 186)
        Me.FriendsReviewsListBox.TabIndex = 45
        '
        'castLabel
        '
        Me.castLabel.AutoSize = True
        Me.castLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.castLabel.Location = New System.Drawing.Point(448, 42)
        Me.castLabel.Name = "castLabel"
        Me.castLabel.Size = New System.Drawing.Size(111, 19)
        Me.castLabel.TabIndex = 46
        Me.castLabel.Text = "Cast and Crew"
        '
        'castAndCrewListBox
        '
        Me.castAndCrewListBox.FormattingEnabled = True
        Me.castAndCrewListBox.Location = New System.Drawing.Point(452, 64)
        Me.castAndCrewListBox.Name = "castAndCrewListBox"
        Me.castAndCrewListBox.Size = New System.Drawing.Size(289, 160)
        Me.castAndCrewListBox.TabIndex = 47
        '
        'filmmakerNameLabel
        '
        Me.filmmakerNameLabel.AutoSize = True
        Me.filmmakerNameLabel.Location = New System.Drawing.Point(452, 242)
        Me.filmmakerNameLabel.Name = "filmmakerNameLabel"
        Me.filmmakerNameLabel.Size = New System.Drawing.Size(38, 13)
        Me.filmmakerNameLabel.TabIndex = 48
        Me.filmmakerNameLabel.Text = "Name:"
        '
        'filmmakerNameTextBox
        '
        Me.filmmakerNameTextBox.Location = New System.Drawing.Point(496, 240)
        Me.filmmakerNameTextBox.Name = "filmmakerNameTextBox"
        Me.filmmakerNameTextBox.ReadOnly = True
        Me.filmmakerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.filmmakerNameTextBox.TabIndex = 49
        '
        'filmmakerRoleTextBox
        '
        Me.filmmakerRoleTextBox.Location = New System.Drawing.Point(496, 269)
        Me.filmmakerRoleTextBox.Name = "filmmakerRoleTextBox"
        Me.filmmakerRoleTextBox.ReadOnly = True
        Me.filmmakerRoleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.filmmakerRoleTextBox.TabIndex = 50
        '
        'filmmakerRoleLabel
        '
        Me.filmmakerRoleLabel.AutoSize = True
        Me.filmmakerRoleLabel.Location = New System.Drawing.Point(452, 269)
        Me.filmmakerRoleLabel.Name = "filmmakerRoleLabel"
        Me.filmmakerRoleLabel.Size = New System.Drawing.Size(32, 13)
        Me.filmmakerRoleLabel.TabIndex = 51
        Me.filmmakerRoleLabel.Text = "Role:"
        '
        'SeeProfileButton
        '
        Me.SeeProfileButton.Location = New System.Drawing.Point(621, 240)
        Me.SeeProfileButton.Name = "SeeProfileButton"
        Me.SeeProfileButton.Size = New System.Drawing.Size(120, 49)
        Me.SeeProfileButton.TabIndex = 52
        Me.SeeProfileButton.Text = "See Profile"
        Me.SeeProfileButton.UseVisualStyleBackColor = True
        '
        'hasAccountLabel
        '
        Me.hasAccountLabel.AutoSize = True
        Me.hasAccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasAccountLabel.Location = New System.Drawing.Point(493, 302)
        Me.hasAccountLabel.Name = "hasAccountLabel"
        Me.hasAccountLabel.Size = New System.Drawing.Size(211, 15)
        Me.hasAccountLabel.TabIndex = 53
        Me.hasAccountLabel.Text = "This Filmmaker has an account!"
        '
        'MoviePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 610)
        Me.Controls.Add(Me.hasAccountLabel)
        Me.Controls.Add(Me.SeeProfileButton)
        Me.Controls.Add(Me.filmmakerRoleLabel)
        Me.Controls.Add(Me.filmmakerRoleTextBox)
        Me.Controls.Add(Me.filmmakerNameTextBox)
        Me.Controls.Add(Me.filmmakerNameLabel)
        Me.Controls.Add(Me.castAndCrewListBox)
        Me.Controls.Add(Me.castLabel)
        Me.Controls.Add(Me.FriendsReviewsListBox)
        Me.Controls.Add(Me.reviewsFromFriends)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.my_review)
        Me.Controls.Add(Me.myreviewTextBox)
        Me.Controls.Add(Me.SeeReviewButton)
        Me.Controls.Add(Me.genresLabel)
        Me.Controls.Add(Me.UpdateReviewButton)
        Me.Controls.Add(Me.OverallRatingLabel)
        Me.Controls.Add(Me.MyRatingLabel)
        Me.Controls.Add(Me.MyRatingTextBox)
        Me.Controls.Add(Me.OverallRatingTextBox)
        Me.Controls.Add(Me.RuntimeLabel)
        Me.Controls.Add(Me.RuntimeTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.countryLabel)
        Me.Controls.Add(Me.PosterBox)
        Me.Controls.Add(Me.synbioTextBox)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "MoviePage"
        Me.Text = "MoviePage"
        CType(Me.PosterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents synbioTextBox As TextBox
    Friend WithEvents PosterBox As PictureBox
    Friend WithEvents UpdateReviewButton As Button
    Friend WithEvents OverallRatingLabel As Label
    Friend WithEvents MyRatingLabel As Label
    Friend WithEvents MyRatingTextBox As TextBox
    Friend WithEvents OverallRatingTextBox As TextBox
    Friend WithEvents RuntimeLabel As Label
    Friend WithEvents RuntimeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents countryLabel As Label
    Friend WithEvents genresLabel As Label
    Friend WithEvents SeeReviewButton As Button
    Friend WithEvents myreviewTextBox As TextBox
    Friend WithEvents my_review As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents reviewsFromFriends As Label
    Friend WithEvents FriendsReviewsListBox As ListBox
    Friend WithEvents castLabel As Label
    Friend WithEvents castAndCrewListBox As ListBox
    Friend WithEvents filmmakerNameLabel As Label
    Friend WithEvents filmmakerNameTextBox As TextBox
    Friend WithEvents filmmakerRoleTextBox As TextBox
    Friend WithEvents filmmakerRoleLabel As Label
    Friend WithEvents SeeProfileButton As Button
    Friend WithEvents hasAccountLabel As Label
End Class
