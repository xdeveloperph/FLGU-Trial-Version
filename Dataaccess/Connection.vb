Imports System.Configuration
Imports System.Data.EntityClient

Public Class Connection

    Public Class MySQLData
        Public host
        Public username
        Public password
    End Class

    Public Class AccountData
        Public accountid
        Public username
        Public password
        Public priveledge
        Public name
    End Class
    Dim logs As New SystemLogsRepository
    Public Function MySQLCon() As String
        Dim dbset = MySQLSettingsData()
        Dim entityBuilder = New EntityConnectionStringBuilder()
        entityBuilder.ProviderConnectionString = "server=" + dbset.host + ";User Id=" + dbset.username + ";database=flgu;password=" + dbset.password + ";allowzerodatetime=true;Convert Zero Datetime=True;"
        entityBuilder.Provider = "MySql.Data.MySqlClient"
        entityBuilder.Metadata = "res://*/FLGUDB.csdl|res://*/FLGUDB.ssdl|res://*/FLGUDB.msl"
        Return entityBuilder.ToString()
    End Function

    Public Sub MySQLSettings(ByVal dbhost As String, ByVal dbpass As String, ByVal dbusername As String)
        With My.Settings
            .dbhost = dbhost
            .dbpassord = dbpass
            .dbusername = dbusername
            .Save()
        End With
    End Sub
    Public Function MySQLSettingsData() As MySQLData
        Dim conn = New MySQLData
        With My.Settings
            conn.host = .dbhost
            conn.password = .dbpassord
            conn.username = .dbusername
        End With
        Return conn
    End Function
    Public Function LoginAccount() As AccountData
        Dim data = New AccountData
        With My.Settings
            data.accountid = .loginid
            data.password = .loginpassword
            data.priveledge = .loginpriveledge
            data.username = .loginusername
            data.name = .loginname
        End With
        Return data
    End Function
    Public Sub LoginSession(ByVal username As String, ByVal password As String, ByVal accountid As String, ByVal priveledge As String, ByVal fullname As String)
        With My.Settings
            .loginid = accountid
            .loginpassword = password
            .loginpriveledge = priveledge
            .loginusername = username
            .loginname = fullname
            .Save()
        End With
        logs.InsertSystemLogs("Account", accountid, "User has login.", accountid)
    End Sub

    Public Sub ResetLoginSession()
        If My.Settings.loginid <> "" Then
            logs.InsertSystemLogs("Account", My.Settings.loginid, "User has logout.", My.Settings.loginid)
        End If
        With My.Settings
            .loginid = ""
            .loginpassword = ""
            .loginpriveledge = ""
            .loginusername = ""
            .loginname = ""
            .Save()
        End With

    End Sub

End Class
