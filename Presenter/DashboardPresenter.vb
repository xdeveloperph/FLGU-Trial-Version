Imports Dataaccess
Imports [Interface]
Public Class DashboardPresenter
    Dim DDrepo As New DashboardRepository
    Public Function GetPopulation() As DSItems.population
        Return DDrepo.GetPopulation()
    End Function
    Public Function GetPhilmember(ByVal philtype As Integer) As DSItems.PhilMembers
        Return DDrepo.GetPhilmember(philtype)
    End Function
    Public Function GetBirmember() As DSItems.PhilMembers
        Return DDrepo.GetBirmember()
    End Function

    Public Function GetHousehold(ByVal barangayid As Integer, ByVal purok As Integer) As Integer
        Return DDrepo.GetHousehold(barangayid, purok)
    End Function

    Public Function GetSocialStat(ByVal socialstat As Integer) As DSItems.Famlily
        Return DDrepo.GetSocialStat(socialstat)
    End Function

    Public Function GetGroups(ByVal groupid As Integer) As DSItems.Famlily
        Return DDrepo.GetGroups(groupid)
    End Function
End Class
