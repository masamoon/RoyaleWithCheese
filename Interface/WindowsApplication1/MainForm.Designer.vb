<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.heyLabel = New System.Windows.Forms.Label()
        Me.PosterBox = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.synbioTextBox = New System.Windows.Forms.TextBox()
        Me.GenresLabel = New System.Windows.Forms.Label()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.RuntimeTextBox = New System.Windows.Forms.TextBox()
        Me.RuntimeLabel = New System.Windows.Forms.Label()
        Me.OverallRatingTextBox = New System.Windows.Forms.TextBox()
        Me.MyRatingTextBox = New System.Windows.Forms.TextBox()
        Me.MyRatingLabel = New System.Windows.Forms.Label()
        Me.OverallRatingLabel = New System.Windows.Forms.Label()
        Me.SeeReviewButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UpdateReviewButton = New System.Windows.Forms.Button()
        Me.searchFilterBox = New System.Windows.Forms.TextBox()
        Me.filterbutton = New System.Windows.Forms.Button()
        Me.clearFilterButton = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.FriendsRatingLabel = New System.Windows.Forms.Label()
        Me.FriendsRatingBox = New System.Windows.Forms.TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.SeeProfileButton = New System.Windows.Forms.Button()
        Me.SeeFriendsProfileButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyProfileButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PosterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-4, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 368)
        Me.ListBox1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(252, 387)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(244, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Movies"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(244, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Friends"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(-4, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(248, 368)
        Me.ListBox2.TabIndex = 0
        '
        'heyLabel
        '
        Me.heyLabel.AutoSize = True
        Me.heyLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heyLabel.Location = New System.Drawing.Point(8, 32)
        Me.heyLabel.Name = "heyLabel"
        Me.heyLabel.Size = New System.Drawing.Size(171, 23)
        Me.heyLabel.TabIndex = 2
        Me.heyLabel.Text = "Hey, <username>!"
        '
        'PosterBox
        '
        Me.PosterBox.Image = CType(resources.GetObject("PosterBox.Image"), System.Drawing.Image)
        Me.PosterBox.Location = New System.Drawing.Point(278, 133)
        Me.PosterBox.Name = "PosterBox"
        Me.PosterBox.Size = New System.Drawing.Size(100, 134)
        Me.PosterBox.TabIndex = 3
        Me.PosterBox.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(270, 78)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(353, 52)
        Me.nameLabel.TabIndex = 4
        Me.nameLabel.Text = "Name Label"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(629, 83)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(41, 19)
        Me.yearLabel.TabIndex = 5
        Me.yearLabel.Text = "Year"
        '
        'synbioTextBox
        '
        Me.synbioTextBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.synbioTextBox.Location = New System.Drawing.Point(395, 133)
        Me.synbioTextBox.Multiline = True
        Me.synbioTextBox.Name = "synbioTextBox"
        Me.synbioTextBox.ReadOnly = True
        Me.synbioTextBox.Size = New System.Drawing.Size(275, 102)
        Me.synbioTextBox.TabIndex = 6
        Me.synbioTextBox.Text = "Synopsis"
        '
        'GenresLabel
        '
        Me.GenresLabel.AutoSize = True
        Me.GenresLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenresLabel.Location = New System.Drawing.Point(392, 242)
        Me.GenresLabel.Name = "GenresLabel"
        Me.GenresLabel.Size = New System.Drawing.Size(48, 16)
        Me.GenresLabel.TabIndex = 7
        Me.GenresLabel.Text = "Genres"
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(276, 378)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(46, 13)
        Me.countryLabel.TabIndex = 8
        Me.countryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(328, 378)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.ReadOnly = True
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 9
        '
        'RuntimeTextBox
        '
        Me.RuntimeTextBox.Location = New System.Drawing.Point(328, 352)
        Me.RuntimeTextBox.Name = "RuntimeTextBox"
        Me.RuntimeTextBox.ReadOnly = True
        Me.RuntimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RuntimeTextBox.TabIndex = 10
        '
        'RuntimeLabel
        '
        Me.RuntimeLabel.AutoSize = True
        Me.RuntimeLabel.Location = New System.Drawing.Point(276, 352)
        Me.RuntimeLabel.Name = "RuntimeLabel"
        Me.RuntimeLabel.Size = New System.Drawing.Size(49, 13)
        Me.RuntimeLabel.TabIndex = 11
        Me.RuntimeLabel.Text = "Runtime:"
        '
        'OverallRatingTextBox
        '
        Me.OverallRatingTextBox.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallRatingTextBox.Location = New System.Drawing.Point(587, 338)
        Me.OverallRatingTextBox.Multiline = True
        Me.OverallRatingTextBox.Name = "OverallRatingTextBox"
        Me.OverallRatingTextBox.ReadOnly = True
        Me.OverallRatingTextBox.Size = New System.Drawing.Size(36, 31)
        Me.OverallRatingTextBox.TabIndex = 16
        '
        'MyRatingTextBox
        '
        Me.MyRatingTextBox.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRatingTextBox.Location = New System.Drawing.Point(587, 375)
        Me.MyRatingTextBox.MaxLength = 2
        Me.MyRatingTextBox.Multiline = True
        Me.MyRatingTextBox.Name = "MyRatingTextBox"
        Me.MyRatingTextBox.Size = New System.Drawing.Size(36, 31)
        Me.MyRatingTextBox.TabIndex = 17
        '
        'MyRatingLabel
        '
        Me.MyRatingLabel.AutoSize = True
        Me.MyRatingLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRatingLabel.Location = New System.Drawing.Point(519, 383)
        Me.MyRatingLabel.Name = "MyRatingLabel"
        Me.MyRatingLabel.Size = New System.Drawing.Size(64, 16)
        Me.MyRatingLabel.TabIndex = 18
        Me.MyRatingLabel.Text = "My Rating"
        '
        'OverallRatingLabel
        '
        Me.OverallRatingLabel.AutoSize = True
        Me.OverallRatingLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallRatingLabel.Location = New System.Drawing.Point(495, 349)
        Me.OverallRatingLabel.Name = "OverallRatingLabel"
        Me.OverallRatingLabel.Size = New System.Drawing.Size(88, 16)
        Me.OverallRatingLabel.TabIndex = 19
        Me.OverallRatingLabel.Text = "Overall Rating"
        '
        'SeeReviewButton
        '
        Me.SeeReviewButton.Location = New System.Drawing.Point(548, 455)
        Me.SeeReviewButton.Name = "SeeReviewButton"
        Me.SeeReviewButton.Size = New System.Drawing.Size(75, 39)
        Me.SeeReviewButton.TabIndex = 20
        Me.SeeReviewButton.Text = "See Review"
        Me.SeeReviewButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Movie Page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(620, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 34)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UpdateReviewButton
        '
        Me.UpdateReviewButton.Location = New System.Drawing.Point(630, 376)
        Me.UpdateReviewButton.Name = "UpdateReviewButton"
        Me.UpdateReviewButton.Size = New System.Drawing.Size(53, 31)
        Me.UpdateReviewButton.TabIndex = 26
        Me.UpdateReviewButton.Text = "Update"
        Me.UpdateReviewButton.UseVisualStyleBackColor = True
        '
        'searchFilterBox
        '
        Me.searchFilterBox.Location = New System.Drawing.Point(17, 474)
        Me.searchFilterBox.Name = "searchFilterBox"
        Me.searchFilterBox.Size = New System.Drawing.Size(100, 20)
        Me.searchFilterBox.TabIndex = 27
        Me.searchFilterBox.Tag = " "
        '
        'filterbutton
        '
        Me.filterbutton.Location = New System.Drawing.Point(119, 471)
        Me.filterbutton.Name = "filterbutton"
        Me.filterbutton.Size = New System.Drawing.Size(75, 23)
        Me.filterbutton.TabIndex = 28
        Me.filterbutton.Text = "Filter"
        Me.filterbutton.UseVisualStyleBackColor = True
        '
        'clearFilterButton
        '
        Me.clearFilterButton.Location = New System.Drawing.Point(200, 471)
        Me.clearFilterButton.Name = "clearFilterButton"
        Me.clearFilterButton.Size = New System.Drawing.Size(75, 23)
        Me.clearFilterButton.TabIndex = 29
        Me.clearFilterButton.Text = "Clear Filter"
        Me.clearFilterButton.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(275, 178)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(400, 152)
        Me.TabControl2.TabIndex = 30
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(392, 126)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Movies"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(-4, -3)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(395, 134)
        Me.ListBox4.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ListBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(392, 126)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Friends"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(-4, 0)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(395, 134)
        Me.ListBox5.TabIndex = 0
        '
        'FriendsRatingLabel
        '
        Me.FriendsRatingLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FriendsRatingLabel.Location = New System.Drawing.Point(434, 424)
        Me.FriendsRatingLabel.Name = "FriendsRatingLabel"
        Me.FriendsRatingLabel.Size = New System.Drawing.Size(149, 19)
        Me.FriendsRatingLabel.TabIndex = 31
        Me.FriendsRatingLabel.Text = "<username Rating>"
        Me.FriendsRatingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FriendsRatingBox
        '
        Me.FriendsRatingBox.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FriendsRatingBox.Location = New System.Drawing.Point(587, 418)
        Me.FriendsRatingBox.Multiline = True
        Me.FriendsRatingBox.Name = "FriendsRatingBox"
        Me.FriendsRatingBox.ReadOnly = True
        Me.FriendsRatingBox.Size = New System.Drawing.Size(36, 31)
        Me.FriendsRatingBox.TabIndex = 32
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(361, 136)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(38, 13)
        Me.UserNameLabel.TabIndex = 33
        Me.UserNameLabel.Text = "Name:"
        '
        'NameBox
        '
        Me.NameBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.NameBox.Location = New System.Drawing.Point(395, 133)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(118, 20)
        Me.NameBox.TabIndex = 34
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(519, 136)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(51, 13)
        Me.LocationLabel.TabIndex = 35
        Me.LocationLabel.Text = "Location:"
        '
        'LocationBox
        '
        Me.LocationBox.Location = New System.Drawing.Point(570, 133)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.ReadOnly = True
        Me.LocationBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationBox.TabIndex = 36
        '
        'SeeProfileButton
        '
        Me.SeeProfileButton.Location = New System.Drawing.Point(279, 125)
        Me.SeeProfileButton.Name = "SeeProfileButton"
        Me.SeeProfileButton.Size = New System.Drawing.Size(64, 35)
        Me.SeeProfileButton.TabIndex = 37
        Me.SeeProfileButton.Text = "See Profile"
        Me.SeeProfileButton.UseVisualStyleBackColor = True
        '
        'SeeFriendsProfileButton
        '
        Me.SeeFriendsProfileButton.Location = New System.Drawing.Point(410, 368)
        Me.SeeFriendsProfileButton.Name = "SeeFriendsProfileButton"
        Me.SeeFriendsProfileButton.Size = New System.Drawing.Size(118, 56)
        Me.SeeFriendsProfileButton.TabIndex = 38
        Me.SeeFriendsProfileButton.Text = "See Friend's Profile"
        Me.SeeFriendsProfileButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(278, 37)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(222, 20)
        Me.SearchTextBox.TabIndex = 39
        '
        'SearchComboBox
        '
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Location = New System.Drawing.Point(521, 37)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(79, 21)
        Me.SearchComboBox.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyProfileButton
        '
        Me.MyProfileButton.Location = New System.Drawing.Point(172, 64)
        Me.MyProfileButton.Name = "MyProfileButton"
        Me.MyProfileButton.Size = New System.Drawing.Size(88, 23)
        Me.MyProfileButton.TabIndex = 42
        Me.MyProfileButton.Text = "See My Profile"
        Me.MyProfileButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 517)
        Me.Controls.Add(Me.MyProfileButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchComboBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SeeFriendsProfileButton)
        Me.Controls.Add(Me.SeeProfileButton)
        Me.Controls.Add(Me.LocationBox)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.FriendsRatingBox)
        Me.Controls.Add(Me.FriendsRatingLabel)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.clearFilterButton)
        Me.Controls.Add(Me.filterbutton)
        Me.Controls.Add(Me.searchFilterBox)
        Me.Controls.Add(Me.UpdateReviewButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SeeReviewButton)
        Me.Controls.Add(Me.OverallRatingLabel)
        Me.Controls.Add(Me.MyRatingLabel)
        Me.Controls.Add(Me.MyRatingTextBox)
        Me.Controls.Add(Me.OverallRatingTextBox)
        Me.Controls.Add(Me.RuntimeLabel)
        Me.Controls.Add(Me.RuntimeTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.countryLabel)
        Me.Controls.Add(Me.GenresLabel)
        Me.Controls.Add(Me.synbioTextBox)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.PosterBox)
        Me.Controls.Add(Me.heyLabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "Royale With Cheese"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PosterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents heyLabel As Label
    Friend WithEvents PosterBox As PictureBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents synbioTextBox As TextBox
    Friend WithEvents GenresLabel As Label
    Friend WithEvents countryLabel As Label
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents RuntimeTextBox As TextBox
    Friend WithEvents RuntimeLabel As Label
    Friend WithEvents OverallRatingTextBox As TextBox
    Friend WithEvents MyRatingTextBox As TextBox
    Friend WithEvents MyRatingLabel As Label
    Friend WithEvents OverallRatingLabel As Label
    Friend WithEvents SeeReviewButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents UpdateReviewButton As Button
    Friend WithEvents searchFilterBox As TextBox
    Friend WithEvents filterbutton As Button
    Friend WithEvents clearFilterButton As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents FriendsRatingLabel As Label
    Friend WithEvents FriendsRatingBox As TextBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents LocationLabel As Label
    Friend WithEvents LocationBox As TextBox
    Friend WithEvents SeeProfileButton As Button
    Friend WithEvents SeeFriendsProfileButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MyProfileButton As Button
End Class
