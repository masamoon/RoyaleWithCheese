<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilmmakerUnregisterd
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Birthdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bio = New System.Windows.Forms.TextBox()
        Me.Fullname_box = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Participations = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Participations.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Birthdate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'Birthdate
        '
        Me.Birthdate.Enabled = False
        Me.Birthdate.Location = New System.Drawing.Point(281, 110)
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Size = New System.Drawing.Size(100, 20)
        Me.Birthdate.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Bio"
        '
        'Bio
        '
        Me.Bio.Location = New System.Drawing.Point(18, 183)
        Me.Bio.Multiline = True
        Me.Bio.Name = "Bio"
        Me.Bio.ReadOnly = True
        Me.Bio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Bio.Size = New System.Drawing.Size(359, 117)
        Me.Bio.TabIndex = 21
        '
        'Fullname_box
        '
        Me.Fullname_box.Enabled = False
        Me.Fullname_box.Location = New System.Drawing.Point(281, 81)
        Me.Fullname_box.Name = "Fullname_box"
        Me.Fullname_box.Size = New System.Drawing.Size(100, 20)
        Me.Fullname_box.TabIndex = 18
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Participations)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 327)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 203)
        Me.TabControl1.TabIndex = 17
        '
        'Participations
        '
        Me.Participations.Controls.Add(Me.ListBox4)
        Me.Participations.Location = New System.Drawing.Point(4, 22)
        Me.Participations.Name = "Participations"
        Me.Participations.Padding = New System.Windows.Forms.Padding(3)
        Me.Participations.Size = New System.Drawing.Size(358, 177)
        Me.Participations.TabIndex = 3
        Me.Participations.Text = "Participations"
        Me.Participations.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(0, 2)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(359, 173)
        Me.ListBox4.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(358, 177)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Roles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(0, 2)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(359, 173)
        Me.ListBox5.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "See Details ->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FilmmakerUnregisterd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Birthdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bio)
        Me.Controls.Add(Me.Fullname_box)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FilmmakerUnregisterd"
        Me.Text = "FilmmakerUnregisterd"
        Me.TabControl1.ResumeLayout(False)
        Me.Participations.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Birthdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Bio As TextBox
    Friend WithEvents Fullname_box As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Participations As TabPage
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Button1 As Button
End Class
