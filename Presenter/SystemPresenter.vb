Imports Dataaccess
Public Class SystemPresenter
    Dim syslog As New SystemLogsRepository

    Public Function GetSystemLogs() As List(Of SystemLogsRepository.UserActivitylogs)
        Return syslog.GetSystemLogs()
    End Function
    Public Function SearchLogst(ByVal fromdate As Date, ByVal todate As Date) As List(Of SystemLogsRepository.UserActivitylogs)
        Return syslog.SearchLogst(fromdate, todate)
    End Function
End Class
