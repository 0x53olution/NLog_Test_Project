Public Class CLoggingTest
    Implements ILoggingTest

    Dim MyLogger As Logger = LogManager.GetCurrentClassLogger
    Private _logText As String = "An error has occured"

    Public Property logText As String Implements ILoggingTest.logText
        Get
            Return _logText
        End Get
        Set(value As String)
            _logText = value
        End Set
    End Property

    Public Function DivisionZero(ByRef a As Integer, ByRef b As Integer) As Object Implements ILoggingTest.DivisionZero
        Dim resultDivision As Integer = 0
        Try
            resultDivision = a / b
        Catch ex As Exception
            MyLogger.Error(ex, logText)
        End Try
        Return resultDivision
    End Function

    Sub ShowLogLevel(ByRef logLevel As String) Implements ILoggingTest.ShowLogLevel
        Select Case logLevel
            Case "Info"
                MyLogger.Info(logLevel & " " & _logText)
            Case "Trace"
                MyLogger.Trace(logLevel & " " & _logText)
            Case "Debug"
                MyLogger.Debug(logLevel & " " & _logText)
            Case "Warn"
                MyLogger.Warn(logLevel & " " & _logText & " (it differ from Error message with exception)")
            Case "Error"
                MyLogger.Error(logLevel & " " & _logText)
            Case "Fatal"
                MyLogger.Fatal(logLevel & " " & _logText)
        End Select
    End Sub
End Class
