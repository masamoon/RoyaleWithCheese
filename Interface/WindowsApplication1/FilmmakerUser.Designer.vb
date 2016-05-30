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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilmmakerUser))
        Me.Location_box = New System.Windows.Forms.TextBox()
        Me.Username_box = New System.Windows.Forms.TextBox()
        Me.Fullname_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Reviews = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Birthdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bio = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Reviews.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Location_box
        '
        Me.Location_box.Enabled = False
        Me.Location_box.Location = New System.Drawing.Point(251, 129)
        Me.Location_box.Name = "Location_box"
        Me.Location_box.Size = New System.Drawing.Size(100, 20)
        Me.Location_box.TabIndex = 16
        '
        'Username_box
        '
        Me.Username_box.Enabled = False
        Me.Username_box.Location = New System.Drawing.Point(251, 88)
        Me.Username_box.Name = "Username_box"
        Me.Username_box.Size = New System.Drawing.Size(100, 20)
        Me.Username_box.TabIndex = 15
        '
        'Fullname_box
        '
        Me.Fullname_box.Enabled = False
        Me.Fullname_box.Location = New System.Drawing.Point(251, 51)
        Me.Fullname_box.Name = "Fullname_box"
        Me.Fullname_box.Size = New System.Drawing.Size(100, 20)
        Me.Fullname_box.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Full name "
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(0, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(274, 121)
        Me.ListBox3.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Reviews)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(43, 302)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(282, 146)
        Me.TabControl1.TabIndex = 13
        '
        'Reviews
        '
        Me.Reviews.Controls.Add(Me.ListBox1)
        Me.Reviews.Location = New System.Drawing.Point(4, 22)
        Me.Reviews.Name = "Reviews"
        Me.Reviews.Padding = New System.Windows.Forms.Padding(3)
        Me.Reviews.Size = New System.Drawing.Size(274, 120)
        Me.Reviews.TabIndex = 0
        Me.Reviews.Text = "Reviews"
        Me.Reviews.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(278, 121)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(274, 120)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lists"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(-4, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(278, 121)
        Me.ListBox2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(274, 120)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Subscriptions"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Birthdate
        '
        Me.Birthdate.Enabled = False
        Me.Birthdate.Location = New System.Drawing.Point(251, 167)
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Size = New System.Drawing.Size(100, 20)
        Me.Birthdate.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Birthdate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Bio"
        '
        'Bio
        '
        Me.Bio.Enabled = False
        Me.Bio.Location = New System.Drawing.Point(43, 228)
        Me.Bio.Multiline = True
        Me.Bio.Name = "Bio"
        Me.Bio.Size = New System.Drawing.Size(282, 61)
        Me.Bio.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(274, 120)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Movies"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(-2, 0)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(278, 121)
        Me.ListBox4.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(274, 120)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Roles"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(-2, 0)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(278, 121)
        Me.ListBox5.TabIndex = 2
        '
        'FilmmakerUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 460)
        Me.Controls.Add(Me.Bio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Birthdate)
        Me.Controls.Add(Me.Location_box)
        Me.Controls.Add(Me.Username_box)
        Me.Controls.Add(Me.Fullname_box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FilmmakerUser"
        Me.Text = "FilmmakerUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Reviews.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Location_box As TextBox
    Friend WithEvents Username_box As TextBox
    Friend WithEvents Fullname_box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Reviews As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Birthdate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Bio As TextBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListBox5 As ListBox
End Class
