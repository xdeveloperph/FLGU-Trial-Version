Public Class SubInformationRepository

    Dim conn As New Connection
    Dim logs As New SystemLogsRepository
#Region "Occupation"
    Public Function InsertToOccupation(ByVal name As String) As occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New occupation
            With insertdata
                .name = name
            End With
            dbconn.AddTooccupations(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Occupation", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function CheckOccupationByName(ByVal name As String) As occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.occupations
                         Where data.name.ToUpper = name.ToUpper
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToOccupation(name)
            End If
        End Using
    End Function
    Public Function UpdateOccupationByID(ByVal Occupationid As Integer, ByVal Occupationname As String) As occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.occupations
                         Where data.id = Occupationid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = Occupationname
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Occupation", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function UpdateOccupationByName(ByVal Occupationnameold As String, ByVal Occupationnamenew As String) As occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.occupations
                         Where data.name = Occupationnameold
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = Occupationnamenew
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Occupation", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofOccupation() As List(Of occupation)
        Dim listbrgy As New List(Of occupation)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.occupations
                         Order By data.name
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetOccupationDatabyID(ByVal Occupationid As Integer) As occupation
        Dim item As New occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.occupations
                         Where data.remove = False And data.id = Occupationid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveOccupation(ByVal Occupationid As Integer) As occupation
        Dim item As New occupation
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.occupations
                         Where data.remove = False And data.id = Occupationid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("Occupation", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region
#Region "Disease"
    Public Function InsertToDisease(ByVal name As String) As disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New disease
            With insertdata
                .name = name
            End With
            dbconn.AddTodiseases(insertdata)
            dbconn.SaveChanges()
            Return insertdata
            logs.InsertSystemLogs("Disease", insertdata.id, "Add new record.", My.Settings.loginid)
        End Using
    End Function
    Public Function CheckDiseaseByName(ByVal name As String) As disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.diseases
                         Where data.name.ToUpper = name.ToUpper
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToDisease(name)
            End If
        End Using
    End Function
    Public Function UpdateDiseaseByID(ByVal Diseaseid As Integer, ByVal Diseasename As String) As disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.diseases
                         Where data.id = Diseaseid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = Diseasename
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Disease", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function UpdateDiseaseByName(ByVal Diseaseold As String, ByVal Diseasenew As String) As disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.diseases
                         Where data.name = Diseaseold
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = Diseasenew
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Disease", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofDiseases() As List(Of disease)
        Dim listbrgy As New List(Of disease)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.diseases
                          Order By data.name
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetDiseaseDatabyID(ByVal Diseaseid As Integer) As disease
        Dim item As New disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.diseases
                         Where data.remove = False And data.id = Diseaseid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveDisease(ByVal Diseaseid As Integer) As disease
        Dim item As New disease
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.diseases
                         Where data.remove = False And data.id = Diseaseid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("Disease", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region
#Region "Socail Status"
    Public Function InsertToSocialStatus(ByVal name As String, ByVal description As String) As socialstatu
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New socialstatu
            With insertdata
                .name = name
                .description = description
                .remove = False
            End With
            dbconn.AddTosocialstatus(insertdata)
            dbconn.SaveChanges()
            Return insertdata
            logs.InsertSystemLogs("Socail Status", insertdata.id, "Add new record.", My.Settings.loginid)
        End Using
    End Function
    Public Function CheckSocialStatus(ByVal name As String) As socialstatu
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.socialstatus
                         Where data.name.ToUpper = name.ToUpper
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToSocialStatus(name, "")
            End If
        End Using
    End Function
    Public Function UpdateSocialStatus(ByVal socialstatusid As Integer, ByVal scname As String) As socialstatu
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.socialstatus
                         Where data.id = socialstatusid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = scname
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Socail Status", result.id, "Modify old record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofSocialStatus() As List(Of socialstatu)
        Dim listbrgy As New List(Of socialstatu)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.socialstatus
                         Order By data.name
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetSocialStatusDatabyID(ByVal socialstatusid As Integer) As socialstatu
        Dim item As New socialstatu
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.socialstatus
                         Where data.remove = False And data.id = socialstatusid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveSocialStatus(ByVal socialstatusid As Integer) As socialstatu
        Dim item As New socialstatu
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.socialstatus
                         Where data.remove = False And data.id = socialstatusid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Socail Status", result.id, "Remove old record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region


End Class
