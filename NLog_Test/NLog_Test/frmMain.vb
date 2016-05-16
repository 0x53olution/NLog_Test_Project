Imports NLog

Public Class frmMain

    Dim x As Integer = 8
    Dim y As Integer = 0
    Dim result As String = Nothing

    Dim TestOfLogger As CLoggingTest
    Dim MyLogger As Logger

    Public Sub New()

        InitializeComponent()
        MyLogger = LogManager.GetCurrentClassLogger
        TestOfLogger = New NLog_Test.CLoggingTest
        MyLogger.Info("NLog_Test Tool started")
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnInfo.Click, btnDebug.Click, bntTrace.Click, bntWarn.Click, btnError.Click, btnFatal.Click, btnExeption.Click
        Dim cmd As Button = CType(sender, Button)
        Select Case cmd.Text
            Case "Info"
                TestOfLogger.logText = "A Info - We got no problems"
            Case "Debug"
                TestOfLogger.logText = "This is a debug message"
            Case "Trace"
                TestOfLogger.logText = "This is a trace message"
            Case "Warn"
                TestOfLogger.logText = "!! WARNING !!"
            Case "Error"
                TestOfLogger.logText = "An error without an exception"
            Case "Fatal"
                TestOfLogger.logText = "Fatal - blue screen ;-)"
            Case "Exception"
                TestOfLogger.logText = "Error with exception!!!!!!"
                result = TestOfLogger.DivisionZero(x, y)
        End Select
        TestOfLogger.ShowLogLevel(cmd.Text)
        txtResult.AppendText(String.Format("Button: {0} gedrückt.{1}", cmd.Text, Environment.NewLine))
        txtResult.ScrollToCaret()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Clear()
    End Sub
End Class
