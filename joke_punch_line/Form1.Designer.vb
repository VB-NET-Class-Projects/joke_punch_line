<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblJokeDisplay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(549, 221)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 0
        Me.btnPunchLine.Text = "punch line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(164, 221)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblJokeDisplay
        '
        Me.lblJokeDisplay.AutoSize = True
        Me.lblJokeDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJokeDisplay.Location = New System.Drawing.Point(283, 144)
        Me.lblJokeDisplay.Name = "lblJokeDisplay"
        Me.lblJokeDisplay.Size = New System.Drawing.Size(0, 20)
        Me.lblJokeDisplay.TabIndex = 3
        Me.lblJokeDisplay.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(427, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ready for a joke? Press ""setup"" to start"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblJokeDisplay)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPunchLine As Button
    Friend WithEvents btnSetup As Button
    Friend WithEvents lblJokeDisplay As Label
    Friend WithEvents Label3 As Label
End Class
