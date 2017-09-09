Imports System.Data.Objects
Public Class SystemLogsRepository
    Public Class UserActivitylogs
        Property Name As String
        Property Activity As String
        Property Tablename As String
        Property recorddate As Date
        Property recordid As Integer
    End Class

    Public Function InsertSystemLogs(ByVal tablename As String, ByVal recordid As Integer, ByVal action As String, ByVal userid As Integer) As log
        Dim conn As New Connection
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New log
            With insertdata
                .TableName = tablename
                .RecordId = recordid
                .Action = action
                .userid = userid
            End With
            dbconn.AddTologs(insertdata)
            dbconn.SaveChanges()
            Return insertdata
        End Using
    End Function

    Public Function GetSystemLogs() As List(Of UserActivitylogs)
        Dim conn As New Connection
        Dim logresult As New List(Of UserActivitylogs)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.logs
                         From acc In dbconn.accounts
                         Where acc.id = data.userid
                         Select New UserActivitylogs With { _
                            .Activity = data.Action,
                            .Name = acc.fname + " " + acc.lname,
                            .recordid = data.RecordId,
                            .recorddate = data.datecreated,
                            .Tablename = data.TableName}).OrderByDescending(Function(x) x.recorddate)
            If result IsNot Nothing Then
                logresult.AddRange(result.Take(10))
            End If
            Return logresult
        End Using
    End Function
    Public Function SearchLogst(ByVal fromdate As Date, ByVal todate As Date) As List(Of UserActivitylogs)
        Dim conn As New Connection
        Dim logresult As New List(Of UserActivitylogs)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.logs.ToList
                          Where data.datecreated.Date >= fromdate.Date And data.datecreated.Date <= todate.Date
                         From acc In dbconn.accounts
                         Where acc.id = data.userid
                         Select New UserActivitylogs With { _
                            .Activity = data.Action,
                            .Name = acc.fname + " " + acc.lname,
                            .recordid = data.RecordId,
                            .recorddate = data.datecreated,
                            .Tablename = data.TableName}).OrderByDescending(Function(x) x.recorddate)
            If result IsNot Nothing Then
                logresult.AddRange(result.Take(10))
            End If
            Return logresult
        End Using
    End Function
End Class
