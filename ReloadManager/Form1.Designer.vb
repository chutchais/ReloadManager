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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.timerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.lblFile = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastExe = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNextRun = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timerLoad
        '
        Me.timerLoad.Interval = 60000
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(12, 9)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(71, 17)
        Me.lblFile.TabIndex = 1
        Me.lblFile.Text = "File Name"
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Last Execute :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastExe
        '
        Me.lblLastExe.AutoSize = True
        Me.lblLastExe.Location = New System.Drawing.Point(104, 92)
        Me.lblLastExe.Name = "lblLastExe"
        Me.lblLastExe.Size = New System.Drawing.Size(20, 17)
        Me.lblLastExe.TabIndex = 3
        Me.lblLastExe.Text = "..."
        Me.lblLastExe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Next Execute :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNextRun
        '
        Me.lblNextRun.AutoSize = True
        Me.lblNextRun.Location = New System.Drawing.Point(104, 126)
        Me.lblNextRun.Name = "lblNextRun"
        Me.lblNextRun.Size = New System.Drawing.Size(20, 17)
        Me.lblNextRun.TabIndex = 5
        Me.lblNextRun.Text = "..."
        Me.lblNextRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Next Execute :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Location = New System.Drawing.Point(424, 92)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(20, 17)
        Me.lblNext.TabIndex = 7
        Me.lblNext.Text = "..."
        Me.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 152)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNextRun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLastExe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Reload Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents timerLoad As System.Windows.Forms.Timer
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastExe As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNextRun As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label

End Class
