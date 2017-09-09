Imports Dataaccess
Imports [Interface]
Public Class LocationPresenter
    Private locationrepo As New LocationRepository

    Public Function InsertToCity(ByVal name) As city
        Return locationrepo.InsertToCity(name)
    End Function
    Public Function UpdateCity(ByVal cityid, ByVal cityname) As city
        Return locationrepo.UpdateCity(cityid, cityname)
    End Function
    Public Function GetListofCity() As List(Of city)
        Return locationrepo.GetListofCity()
    End Function
    Public Function GetCityDatabyID(ByVal cityid As Integer) As city
        Return locationrepo.GetCityDatabyID(cityid)
    End Function
    Public Function GetPurokDatabyID(ByVal purokid) As purok
        Return locationrepo.GetPurokDatabyID(purokid)
    End Function
    Public Function RemoveCity(ByVal cityid) As city
        Return locationrepo.RemoveCity(cityid)
    End Function
    Public Function InsertToBarangay(ByVal bname As String, ByVal cityid As Integer) As barangay
        Return locationrepo.InsertToBarangay(bname, cityid)
    End Function
    Public Function UpdateBarangayByID(ByVal barangayid As Integer, ByVal barangayname As String, ByVal cityid As Integer) As barangay
        Return locationrepo.UpdateBarangayByID(barangayid, barangayname, cityid)
    End Function
    Public Function GetListofBarangay() As List(Of LocationRepository.BarangayDatalist)
        Return locationrepo.GetListofBarangay()
    End Function
    Public Function GetListofBarangayOrig() As List(Of barangay)
        Return locationrepo.GetListofBarangayOrig()
    End Function
    Public Function GetBarangayListbyCityID(ByVal cityid As Integer) As List(Of barangay)
        Return locationrepo.GetBarangayListbyCityID(cityid)
    End Function
    Public Function GetBarangayDatabyID(ByVal barangayid As Integer) As barangay
        Return locationrepo.GetBarangayDatabyID(barangayid)
    End Function
    Public Function RemoveBarangay(ByVal barangayid As Integer) As barangay
        Return locationrepo.RemoveBarangay(barangayid)
    End Function
    Public Function GetListofPurokByBarangayID(ByVal barangayid As Integer) As List(Of purok)
        Return locationrepo.GetListofPurokByBarangayID(barangayid)
    End Function

    Public Function InsertToPurok(ByVal name As String, ByVal barangayid As Integer) As purok
        Return locationrepo.InsertToPurok(name, barangayid)
    End Function
    Public Function CheckPurokByName(ByVal name As String, ByVal barangayid As String) As purok
        Return locationrepo.CheckPurokByName(name, barangayid)
    End Function
    Public Function UpdatePurok(ByVal purokid As Integer, ByVal purokname As String, ByVal barangayid As Integer) As purok
        Return locationrepo.UpdatePurok(purokid, purokname, barangayid)
    End Function
    Public Function GetListofPurok() As List(Of purok)
        Return locationrepo.GetListofPurok()
    End Function

    Public Function GetPurokDatabyID(ByVal purokid As Integer) As purok
        Return locationrepo.GetPurokDatabyID(purokid)
    End Function
    Public Function RemovePurok(ByVal purokid As Integer) As purok
        Return locationrepo.RemovePurok(purokid)
    End Function
    Public Function GetListofPurokCInfo() As List(Of PurokInformation)
        Return locationrepo.GetListofPurokCInfo()
    End Function
End Class
