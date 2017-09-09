
Public Class AccountRepository
    Dim conn As New Connection
    Dim logs As New SystemLogsRepository
    Public Function CheckUserCredentials(ByVal username As String, ByVal password As String) As Connection.AccountData
        Dim result As New Connection.AccountData
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim query = (From dbaccount In dbconn.accounts
                        Where dbaccount.username = username And dbaccount.password = password
                        Select dbaccount).FirstOrDefault
            If query Is Nothing Then
                conn.ResetLoginSession()
            Else
                conn.LoginSession(query.username, query.password, query.id, query.level, query.fname + " " + query.lname)
            End If
        End Using
        Return conn.LoginAccount
    End Function
    Public Function LoginAccountCredentials() As account
        Dim item As New account
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.accounts
                         Where data.remove = False And data.id = My.Settings.loginid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Sub Logoutaccount()
        conn.ResetLoginSession()
    End Sub
    Public Function InsertToAccount(ByVal useraccount As account) As account
        Using dbconn As New flguEntities(conn.MySQLCon)
            dbconn.AddToaccounts(useraccount)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Account", useraccount.id, "Add new record.", My.Settings.loginid)
            Return useraccount
        End Using
    End Function

    Public Function UpdateAccountByID(ByVal useraccount As account) As account
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.accounts
                         Where data.id = useraccount.id
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                With result
                    .fname = useraccount.fname
                    .mname = useraccount.mname
                    .lname = useraccount.lname
                    .username = useraccount.username
                    .password = useraccount.password
                    .create = useraccount.create
                    .import = useraccount.import
                    .export = useraccount.export
                    .edit = useraccount.edit
                    .delete = useraccount.delete
                End With
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Account", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofAccount() As List(Of account)
        Dim listbrgy As New List(Of account)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.accounts
                         Where data.remove = False
                        Select data

            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetAccountbyID(ByVal accounid As Integer) As account
        Dim item As New account
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.accounts
                         Where data.remove = False And data.id = accounid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveAccount(ByVal accounid As Integer) As account
        Dim item As New account
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.accounts
                         Where data.remove = False And data.id = accounid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("Account", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
End Class
