Imports Dataaccess
Public Class LoginPresenter
    Dim accrepo As New AccountRepository
    Dim con As New Connection

    Public Function LoginVerification(ByVal username As String, ByVal password As String)
        Dim pass = 0
        Dim logval = accrepo.CheckUserCredentials(username, password)
        If logval.accountid <> "" Then
            pass = 1
        End If
        Return pass
    End Function
    Public Function LoginAccountCredentials() As account
        Return accrepo.LoginAccountCredentials()
    End Function
    Public Sub Logout()
        accrepo.Logoutaccount()
    End Sub
    Public Function InsertToAccount(ByVal useraccount As account) As account
        Return accrepo.InsertToAccount(useraccount)
    End Function

    Public Function UpdateAccountByID(ByVal useraccount As account) As account
        Return accrepo.UpdateAccountByID(useraccount)
    End Function
    Public Function GetListofAccount() As List(Of account)
        Return accrepo.GetListofAccount()
    End Function
    Public Function GetAccountbyID(ByVal accounid As Integer) As account
        Return accrepo.GetAccountbyID(accounid)
    End Function
    Public Function RemoveAccount(ByVal accounid As Integer) As account
        Return accrepo.RemoveAccount(accounid)
    End Function

    Public Sub MySQLSettings(ByVal dbhost As String, ByVal dbpass As String, ByVal dbusername As String)
        con.MySQLSettings(dbhost, dbpass, dbusername)
    End Sub
    Public Function MySQLSettingsData() As Connection.MySQLData
        Return con.MySQLSettingsData
    End Function
End Class
