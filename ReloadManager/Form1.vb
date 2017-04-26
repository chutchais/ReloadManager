Public Class Form1
    Dim pAuto As Process
    Dim objInI As clsINI
    Dim vExeFile As String
    Dim vInterval As Integer

    Private Sub timerLoad_Tick(sender As Object, e As EventArgs) Handles timerLoad.Tick
        Timer1.Enabled = False
        pAuto = Process.Start(vExeFile)
        lblLastExe.Text = Now()
        lblNext.Text = Now().AddMinutes(vInterval)
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblNext.Text = Now().AddMinutes(vInterval)
        timerLoad.Enabled = True
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        objInI = New clsINI(Application.StartupPath & "\setting.ini")
        vExeFile = objInI.GetString("exe", "file", "")
        vInterval = Val(objInI.GetString("exe", "interval", "3"))

        timerLoad.Interval = vInterval * (60 * 1000)


        lblFile.Text = vExeFile

        Me.Text = Me.Text + " version : " + Application.ProductVersion.Trim()
    End Sub

    Public Function Print_Remaining_Time(EndTime As DateTime)
        'If EndTime.ToString = "01/01/0001 0:00:00" Then
        '    EndTime = Now
        '    EndTime = EndTime.AddMilliseconds(Time_Out - 1000)
        'End If
        Dim RemainingTime As TimeSpan
        RemainingTime = Now().Subtract(EndTime)
        Return String.Format("{0:00}:{1:00}:{2:00}", CInt(Math.Floor(RemainingTime.TotalHours)) Mod 60, CInt(Math.Floor(RemainingTime.TotalMinutes)) Mod 60, CInt(Math.Floor(RemainingTime.TotalSeconds)) Mod 60).Replace("-", "")
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblNextRun.Text = "Next run (remaining time) -->" & Print_Remaining_Time(CDate(lblNext.Text))
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
