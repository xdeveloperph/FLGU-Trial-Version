Imports [Interface]
Public Class DashboardRepository
    Dim conn As New Connection
    Public Function GetPopulation() As DSItems.population
        Dim result As New DSItems.population
        Using dbconn As New flguEntities(conn.MySQLCon)
            With result
                .female = (From data In dbconn.citizens
                          Where data.remove = False And data.Gender = "F"
                          Select data).Count()
                .male = (From data In dbconn.citizens
                         Where data.remove = False And data.Gender = "M"
                         Select data).Count()
                .total = (From data In dbconn.citizens
                         Where data.remove = False
                         Select data).Count()
            End With
            Return result
        End Using
    End Function
    Public Function GetPhilmember(ByVal philtype As Integer) As DSItems.PhilMembers
        Dim result As New DSItems.PhilMembers
        Using dbconn As New flguEntities(conn.MySQLCon)
            With result
                .registered = (From data In dbconn.citizens
                          Where data.remove = False And data.philhealthtype = philtype
                          Select data).Count()
                .unregisted = (From data In dbconn.citizens
                         Where data.remove = False And data.philhealthtype = 0
                         Select data).Count()
            End With
            Return result
        End Using
    End Function
    Public Function GetBirmember() As DSItems.PhilMembers
        Dim result As New DSItems.PhilMembers
        Using dbconn As New flguEntities(conn.MySQLCon)
            With result
                .registered = (From data In dbconn.citizens
                          Where data.remove = False And data.tin <> "0" And data.tin <> ""
                          Select data).Count()
                .unregisted = (From data In dbconn.citizens
                         Where data.remove = False And data.tin = "0" Or data.tin = ""
                         Select data).Count()
            End With
            Return result
        End Using
    End Function

    Public Function GetHousehold(ByVal barangayid As Integer, ByVal purok As Integer) As Integer
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim registered = From data In dbconn.households
                              Where data.remove = False
                              Select data

            If (barangayid > 0 And registered IsNot Nothing) Then
                registered = From data In registered
                             Where data.barangayid = barangayid
                            Select data
            End If
            If (purok > 0 And registered IsNot Nothing) Then
                registered = From data In registered
                             Where data.purokid = purok
                            Select data
            End If
            Return registered.Count()
        End Using
    End Function

    Public Function GetSocialStat(ByVal socialstat As Integer) As DSItems.Famlily
        Dim resut As New DSItems.Famlily
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim registered = From data In dbconn.households
                              Where data.remove = False
                              Select data

            If (socialstat > 0 And registered IsNot Nothing) Then
                registered = From data In registered
                              Where data.SocialCommunity = socialstat
                              Select data
            End If
            Dim housholdcount = (From data In dbconn.households
                             Where data.remove = False
                             Select data).Count()

            resut.Famlilycount = registered.Count()
            resut.percentage = (resut.Famlilycount / housholdcount) * 100

            Return resut
        End Using
    End Function

    Public Function GetGroups(ByVal groupid As Integer) As DSItems.Famlily
        Dim resut As New DSItems.Famlily
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim registered = From data In dbconn.households
                              Where data.remove = False
                              Select data

            If (groupid > 0 And registered IsNot Nothing) Then

                registered = From data In registered
                              Where data.categoryid = groupid
                              Select data
            End If
            Dim housholdcount = (From data In dbconn.households
                             Where data.remove = False
                             Select data).Count()

            resut.Famlilycount = registered.Count()
            resut.percentage = (resut.Famlilycount / housholdcount) * 100

            Return resut
        End Using
    End Function
End Class
