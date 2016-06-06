<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.ratingTextBox = New System.Windows.Forms.TextBox()
        Me.reviewTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateRatingButton = New System.Windows.Forms.Button()
        Me.UpdateReviewButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteReviewButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(12, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(367, 52)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.Text = "Name Label"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(385, 14)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(41, 19)
        Me.yearLabel.TabIndex = 7
        Me.yearLabel.Text = "Year"
        '
        'ratingTextBox
        '
        Me.ratingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratingTextBox.Location = New System.Drawing.Point(332, 255)
        Me.ratingTextBox.MaxLength = 2
        Me.ratingTextBox.Multiline = True
        Me.ratingTextBox.Name = "ratingTextBox"
        Me.ratingTextBox.ReadOnly = True
        Me.ratingTextBox.Size = New System.Drawing.Size(36, 31)
        Me.ratingTextBox.TabIndex = 8
        '
        'reviewTextBox
        '
        Me.reviewTextBox.Location = New System.Drawing.Point(12, 64)
        Me.reviewTextBox.Multiline = True
        Me.reviewTextBox.Name = "reviewTextBox"
        Me.reviewTextBox.ReadOnly = True
        Me.reviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.reviewTextBox.Size = New System.Drawing.Size(414, 185)
        Me.reviewTextBox.TabIndex = 9
        '
        'UpdateRatingButton
        '
        Me.UpdateRatingButton.Location = New System.Drawing.Point(374, 253)
        Me.UpdateRatingButton.Name = "UpdateRatingButton"
        Me.UpdateRatingButton.Size = New System.Drawing.Size(52, 33)
        Me.UpdateRatingButton.TabIndex = 10
        Me.UpdateRatingButton.Text = "Update"
        Me.UpdateRatingButton.UseVisualStyleBackColor = True
        '
        'UpdateReviewButton
        '
        Me.UpdateReviewButton.Location = New System.Drawing.Point(12, 261)
        Me.UpdateReviewButton.Name = "UpdateReviewButton"
        Me.UpdateReviewButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateReviewButton.TabIndex = 11
        Me.UpdateReviewButton.Text = "Update"
        Me.UpdateReviewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rating:"
        '
        'DeleteReviewButton
        '
        Me.DeleteReviewButton.Location = New System.Drawing.Point(151, 261)
        Me.DeleteReviewButton.Name = "DeleteReviewButton"
        Me.DeleteReviewButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteReviewButton.TabIndex = 13
        Me.DeleteReviewButton.Text = "Delete Review"
        Me.DeleteReviewButton.UseVisualStyleBackColor = True
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 318)
        Me.Controls.Add(Me.DeleteReviewButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateReviewButton)
        Me.Controls.Add(Me.UpdateRatingButton)
        Me.Controls.Add(Me.reviewTextBox)
        Me.Controls.Add(Me.ratingTextBox)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Review"
        Me.Text = "Review"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents ratingTextBox As TextBox
    Friend WithEvents reviewTextBox As TextBox
    Friend WithEvents UpdateRatingButton As Button
    Friend WithEvents UpdateReviewButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteReviewButton As Button
End Class
