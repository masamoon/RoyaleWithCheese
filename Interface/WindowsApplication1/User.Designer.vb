<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fullname_box = New System.Windows.Forms.TextBox()
        Me.Username_box = New System.Windows.Forms.TextBox()
        Me.Location_box = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Reviews = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Lists = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Subscriptions = New System.Windows.Forms.TabPage()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Reviews.SuspendLayout()
        Me.Lists.SuspendLayout()
        Me.Subscriptions.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Fullname_box
        '
        Me.Fullname_box.Enabled = False
        Me.Fullname_box.Location = New System.Drawing.Point(333, 34)
        Me.Fullname_box.Name = "Fullname_box"
        Me.Fullname_box.Size = New System.Drawing.Size(100, 20)
        Me.Fullname_box.TabIndex = 1
        '
        'Username_box
        '
        Me.Username_box.Enabled = False
        Me.Username_box.Location = New System.Drawing.Point(333, 60)
        Me.Username_box.Name = "Username_box"
        Me.Username_box.Size = New System.Drawing.Size(100, 20)
        Me.Username_box.TabIndex = 2
        '
        'Location_box
        '
        Me.Location_box.Enabled = False
        Me.Location_box.Location = New System.Drawing.Point(333, 86)
        Me.Location_box.Name = "Location_box"
        Me.Location_box.Size = New System.Drawing.Size(100, 20)
        Me.Location_box.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Reviews)
        Me.TabControl1.Controls.Add(Me.Lists)
        Me.TabControl1.Controls.Add(Me.Subscriptions)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(76, 219)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 203)
        Me.TabControl1.TabIndex = 4
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
        Me.TabPage4.Text = "TabPage4"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 434)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Location_box)
        Me.Controls.Add(Me.Username_box)
        Me.Controls.Add(Me.Fullname_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "User"
        Me.Text = "User"
        Me.TabControl1.ResumeLayout(False)
        Me.Reviews.ResumeLayout(False)
        Me.Lists.ResumeLayout(False)
        Me.Subscriptions.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Fullname_box As TextBox
    Friend WithEvents Username_box As TextBox
    Friend WithEvents Location_box As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Reviews As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Lists As TabPage
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Subscriptions As TabPage
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
