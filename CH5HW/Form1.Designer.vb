<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.ResetBTN = New System.Windows.Forms.Button()
        Me.AttendeeTXT = New System.Windows.Forms.TextBox()
        Me.AttendeeLBL = New System.Windows.Forms.Label()
        Me.NumOfRegLBL = New System.Windows.Forms.Label()
        Me.CalculateBTN = New System.Windows.Forms.Button()
        Me.NumOfRegTXT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ResetBTN
        '
        Me.ResetBTN.Location = New System.Drawing.Point(205, 97)
        Me.ResetBTN.Name = "ResetBTN"
        Me.ResetBTN.Size = New System.Drawing.Size(189, 34)
        Me.ResetBTN.TabIndex = 11
        Me.ResetBTN.Text = "Reset Values"
        Me.ResetBTN.UseVisualStyleBackColor = True
        '
        'AttendeeTXT
        '
        Me.AttendeeTXT.Enabled = False
        Me.AttendeeTXT.Location = New System.Drawing.Point(400, 47)
        Me.AttendeeTXT.Name = "AttendeeTXT"
        Me.AttendeeTXT.Size = New System.Drawing.Size(254, 31)
        Me.AttendeeTXT.TabIndex = 10
        Me.AttendeeTXT.Text = "0"
        '
        'AttendeeLBL
        '
        Me.AttendeeLBL.AutoSize = True
        Me.AttendeeLBL.Location = New System.Drawing.Point(400, 19)
        Me.AttendeeLBL.Name = "AttendeeLBL"
        Me.AttendeeLBL.Size = New System.Drawing.Size(153, 25)
        Me.AttendeeLBL.TabIndex = 9
        Me.AttendeeLBL.Text = "Cost per attendee"
        '
        'NumOfRegLBL
        '
        Me.NumOfRegLBL.AutoSize = True
        Me.NumOfRegLBL.Location = New System.Drawing.Point(49, 16)
        Me.NumOfRegLBL.Name = "NumOfRegLBL"
        Me.NumOfRegLBL.Size = New System.Drawing.Size(293, 25)
        Me.NumOfRegLBL.TabIndex = 8
        Me.NumOfRegLBL.Text = "Number of conference registrations"
        '
        'CalculateBTN
        '
        Me.CalculateBTN.Location = New System.Drawing.Point(205, 44)
        Me.CalculateBTN.Name = "CalculateBTN"
        Me.CalculateBTN.Size = New System.Drawing.Size(189, 34)
        Me.CalculateBTN.TabIndex = 7
        Me.CalculateBTN.Text = "Calculate"
        Me.CalculateBTN.UseVisualStyleBackColor = True
        '
        'NumOfRegTXT
        '
        Me.NumOfRegTXT.Location = New System.Drawing.Point(49, 44)
        Me.NumOfRegTXT.Name = "NumOfRegTXT"
        Me.NumOfRegTXT.Size = New System.Drawing.Size(150, 31)
        Me.NumOfRegTXT.TabIndex = 6
        Me.NumOfRegTXT.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 140)
        Me.Controls.Add(Me.ResetBTN)
        Me.Controls.Add(Me.AttendeeTXT)
        Me.Controls.Add(Me.AttendeeLBL)
        Me.Controls.Add(Me.NumOfRegLBL)
        Me.Controls.Add(Me.CalculateBTN)
        Me.Controls.Add(Me.NumOfRegTXT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResetBTN As Button
    Friend WithEvents AttendeeTXT As TextBox
    Friend WithEvents AttendeeLBL As Label
    Friend WithEvents NumOfRegLBL As Label
    Friend WithEvents CalculateBTN As Button
    Friend WithEvents NumOfRegTXT As TextBox
End Class
