Imports Dataaccess
Imports [Interface]

Public Class UserInformationPresenter
    Public Class HouseholdDataset
        Property cityid As String
        Property barangayid As String
        Property purokid As String
        Property familyname As String
        Property householdnum As String
        Property familynum As String
        Property soccomid As String
        Property categoryid As String
        Property Member As New List(Of FamilyMembersDataset)
    End Class
    Public Class FamilyMembersDataset
        Property fname As String
        Property mname As String
        Property lanme As String
        Property birth As New Date
        Property contactnum As String
        Property bloodtype As String
        Property gender As String
        Property osy As String
        Property pwd As String
        Property occupation As String
        Property disease As String
        Property tin As String
        Property philhealthnum As String
        Property philhealthtype As String
        Property philhealthexp As New Date
        Property income As String
        Property occupationid As Integer
        Property diseaseid As Integer
        Property philtypeid As Integer
        Property osyid As String
        Property tempid As String
    End Class
    Dim DACR As New CitizensRepository
    Public Sub InsertHouseholdandMembers(ByVal data As HouseholdDataset)
        Dim househould = DACR.InsertToHousehold(int(data.householdnum), int(data.soccomid), str(data.familyname), int(data.purokid), int(data.barangayid), int(data.categoryid), int(data.cityid), int(data.familynum))
        For Each member As FamilyMembersDataset In data.Member
            With member
                DACR.InsertToCitizen(househould.id, .fname, .mname, .lanme, .birth, .contactnum, int(.tin), int(.philhealthnum), .bloodtype, int(.occupationid), .osyid, .pwd, int(.diseaseid), int(househould.SocialCommunity), .philhealthexp, int(.philhealthtype), .income, .gender)
            End With
        Next
    End Sub
    Public Sub UpdateHouseholdandMembers(ByVal referenceid As Integer, ByVal recordid As Integer, ByVal data As HouseholdDataset)
        Dim hid As Integer
        If referenceid = 0 Then
            hid = recordid
        ElseIf referenceid = 1 Then
            Dim temp = DACR.GetcitizensDatabyID(recordid)
            hid = temp.hid
        End If
        Dim househould = DACR.UpdateHouseholdByID(hid, int(data.householdnum), int(data.soccomid), str(data.familyname), int(data.purokid), int(data.barangayid), int(data.categoryid), int(data.cityid), int(data.familynum))
        For Each member As FamilyMembersDataset In data.Member
            With member
                DACR.UpdateCitizensByID(.tempid, househould.id, .fname, .mname, .lanme, .birth, .contactnum, int(.tin), int(.philhealthnum), .bloodtype, int(.occupationid), .osyid, .pwd, int(.diseaseid), int(househould.SocialCommunity), .philhealthexp, int(.philhealthtype), .income, .gender)
            End With
        Next
    End Sub
    Public Function GetHouseholdDataset(ByVal referenceid As Integer, ByVal recordid As Integer) As HouseholdDataset
        Dim hid As Integer
        If referenceid = 0 Then
            hid = recordid
        ElseIf referenceid = 1 Then
            Dim temp = DACR.GetcitizensDatabyID(recordid)
            hid = temp.hid
        End If
        Dim houeshold = DACR.GetHouseholdDatabyID(hid)
        Dim Member = DACR.GetListofcitizensByHousehold(hid)
        Dim result As New HouseholdDataset
        If houeshold IsNot Nothing Then
            With result
                .barangayid = houeshold.barangayid
                .categoryid = houeshold.categoryid
                .cityid = houeshold.cityid
                .familyname = houeshold.familyname
                .familynum = houeshold.famid
                .householdnum = .householdnum
                .purokid = houeshold.purokid
                .soccomid = houeshold.SocialCommunity
                For Each person As Dataaccess.citizen In Member
                    Dim personinfo As New FamilyMembersDataset
                    With personinfo
                        .birth = person.birthdate
                        .bloodtype = person.bloodtypeid
                        .contactnum = person.contactnum
                        .diseaseid = person.diseased
                        .fname = person.fname
                        .gender = person.Gender
                        .income = person.income
                        .lanme = person.lname
                        .mname = person.mname
                        .occupationid = person.occupation
                        .osyid = person.osyisy
                        .philhealthexp = person.philhealthexp.Date
                        .philhealthnum = person.philhealth
                        .philhealthtype = person.philhealthtype
                        .pwd = person.pwe
                        .tin = person.tin
                        .tempid = person.id
                    End With
                    .Member.Add(personinfo)
                Next
            End With
        End If
        Return result
    End Function

    Private Function int(ByVal data As String) As Integer
        Dim num As Integer = 0
        If Integer.TryParse(data, num) Then
            num = data
        End If
        Return num
    End Function
    Private Function str(ByVal data As String) As String
        Dim stri As String = ""
        If (data IsNot Nothing) Then
            stri = data.Trim.Replace("_", "")
        Else
            Return stri
        End If
        Return stri
    End Function

    Public Function SearchHousehold(ByVal SearchList As SearchLibrary, ByVal rows As Integer, ByVal skipcount As Integer) As List(Of HouseholdLibrary)
        Return UIP.SearchHousehold(SearchList, rows, skipcount)
    End Function
    Public Function GetListofHouseholdMods() As List(Of HouseholdLibrary)
        Return UIP.GetListofHouseholdMods()
    End Function
    Public Function SearchCitizen(ByVal SearchList As SearchLibrary, ByVal rows As Integer, ByVal skipcount As Integer) As List(Of CitizenInformation)
        Return UIP.SearchCitizen(SearchList, rows, skipcount)
    End Function
    Public Function RemoveHousehold(ByVal citizenid As Integer) As household
        Return UIP.RemoveHousehold(citizenid)
    End Function
#Region "Category"
    Dim UIP As New CitizensRepository
    Public Function InsertToCCategory(ByVal name As String) As citizencategory
        Return UIP.InsertToCCategory(name)
    End Function
    Public Function CheckCCategoryByName(ByVal name As String) As citizencategory
        Return UIP.CheckCCategoryByName(name)
    End Function
    Public Function UpdateCCategoryByID(ByVal CCategoryid As Integer, ByVal CCategoryname As String) As citizencategory
        Return UIP.UpdateCCategoryByID(CCategoryid, CCategoryname)
    End Function
    Public Function GetListofCCategory() As List(Of citizencategory)
        Return UIP.GetListofCCategory()
    End Function
    Public Function GetCCategoryDatabyID(ByVal CCategoryid As Integer) As citizencategory
        Return UIP.GetCCategoryDatabyID(CCategoryid)
    End Function
    Public Function RemoveCategory(ByVal CCategoryid As Integer) As citizencategory
        Return UIP.RemoveCategory(CCategoryid)
    End Function
#End Region
End Class
