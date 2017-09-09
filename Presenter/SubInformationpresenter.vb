Imports Dataaccess
Public Class SubInformationpresenter
    Dim subinforepo As New SubInformationRepository
    Public Function InsertToOccupation(ByVal name) As occupation
        Return subinforepo.InsertToOccupation(name)
    End Function
    Public Function UpdateOccupationByID(ByVal Occupationid, ByVal Occupationname) As occupation
        Return subinforepo.UpdateOccupationByID(Occupationid, Occupationname)
    End Function
    Public Function UpdateOccupationByName(ByVal Occupationnameold, ByVal Occupationnamenew) As occupation
        Return subinforepo.UpdateOccupationByName(Occupationnameold, Occupationnamenew)
    End Function
    Public Function GetListofOccupation() As List(Of occupation)
        Return subinforepo.GetListofOccupation()
    End Function
    Public Function GetOccupationDatabyID(ByVal Occupationid) As occupation
        Return subinforepo.GetOccupationDatabyID(Occupationid)
    End Function
    Public Function RemoveOccupation(ByVal Occupationid) As occupation
        Return subinforepo.RemoveOccupation(Occupationid)
    End Function

    Public Function InsertToDisease(ByVal name) As disease
        Return subinforepo.InsertToDisease(name)
    End Function
    Public Function UpdateDiseaseByID(ByVal Diseaseid, ByVal Diseasename) As disease
        Return subinforepo.UpdateDiseaseByID(Diseaseid, Diseasename)
    End Function
    Public Function UpdateDiseaseByName(ByVal Diseaseold, ByVal Diseasenew) As disease
        Return subinforepo.UpdateDiseaseByName(Diseaseold, Diseasenew)
    End Function
    Public Function GetListofDiseases() As List(Of disease)
        Return subinforepo.GetListofDiseases()
    End Function
    Public Function GetDiseaseDatabyID(ByVal Diseaseid) As disease
        Return subinforepo.GetDiseaseDatabyID(Diseaseid)
    End Function
    Public Function RemoveDisease(ByVal Diseaseid) As disease
        Return subinforepo.RemoveDisease(Diseaseid)
    End Function
    Public Function UpdateSocialStatus(ByVal socialstatusid As Integer, ByVal scname As String) As socialstatu
        Return subinforepo.UpdateSocialStatus(socialstatusid, scname)
    End Function

    Public Function GetListofSocialStatus() As List(Of socialstatu)
        Return subinforepo.GetListofSocialStatus()
    End Function

    Public Function GetSocialStatusDatabyID(ByVal socialstatusid As Integer) As socialstatu
        Return subinforepo.GetSocialStatusDatabyID(socialstatusid)
    End Function

    Public Function RemoveSocialStatus(ByVal socialstatusid As Integer) As socialstatu
        Return subinforepo.RemoveSocialStatus(socialstatusid)
    End Function
    Public Function InsertToSocialStatus(ByVal name As String, ByVal description As String) As socialstatu
        Return subinforepo.InsertToSocialStatus(name, description)
    End Function
End Class
