Imports Dataaccess
Public Class ImportPresenter
    Public Class IPHousehold
        Property Barangay As String = ""
        Property Purok As String = ""
        Property HouseholdNo As String = ""
        Property FaliyNo As String = ""
        Property SocialStatus As String = ""
        Property Group As String = ""
        Property Members As New List(Of IPFamilyMembers)
    End Class
    Public Class IPFamilyMembers
        Property FirstName As String = ""
        Property MI As String = ""
        Property LastName As String = ""
        Property Birth As Date
        Property Age As String = ""
        Property Contactnum As String = ""
        Property TinNum As String = ""
        Property Philhealth As String = ""
        Property Philhealthtype As Integer
        Property Philhealthexp As Date
        Property BloodType As String = ""
        Property Occupation As String = ""
        Property OSIOSY As String = ""
        Property PWD As String = ""
        Property Diseased As String = ""
        Property Description As String = ""
        Property Gender As String = ""
    End Class
    Dim DASR As New SubInformationRepository
    Dim DALR As New LocationRepository
    Dim DACR As New CitizensRepository
    Public Sub ImportDataFromExcel(ByVal data As IPHousehold)

        If data.Barangay IsNot Nothing And data.Purok IsNot Nothing And data.Members.Count > 0 Then
            Dim SocialStatusid As Integer = 0
            Dim purokid As Integer = 0
            Dim familyname As String = ""
            Dim barangay = DALR.CheckBarangayByName(str(data.Barangay))
            If (data.Purok IsNot Nothing) Then
                Dim purok = DALR.CheckPurokByName(data.Purok, barangay.id)
                purokid = purok.id
            End If
            If (data.SocialStatus IsNot Nothing) Then
                If (data.SocialStatus.Trim() <> "") Then
                    Dim SocialStatus = DASR.CheckSocialStatus(str(data.SocialStatus))
                    SocialStatusid = SocialStatus.id
                End If
            End If
            Dim Group = DACR.CheckCCategoryByName(str(data.Group))
            If (data.Members.Count > 0) Then
                familyname = data.Members(0).LastName.ToString
            End If
            Dim househould = DACR.InsertToHousehold(int(data.HouseholdNo), SocialStatusid, familyname, purokid, barangay.id, Group.id, 1, 0)
            For Each DataSet As IPFamilyMembers In data.Members
                Dim diseasid As Integer = 0
                Dim occuppationid As Integer = 0
                If (DataSet.Diseased IsNot Nothing) Then
                    Dim diseas = DASR.CheckDiseaseByName(DataSet.Diseased)
                    diseasid = diseas.id
                End If
                If (DataSet.Occupation IsNot Nothing) Then
                    Dim occupation = DASR.CheckOccupationByName(DataSet.Occupation)
                    occuppationid = occupation.id
                End If
                DACR.InsertToCitizen(househould.id, str(DataSet.FirstName), str(DataSet.MI), str(DataSet.LastName), DataSet.Birth, str(DataSet.Contactnum), str(DataSet.TinNum), str(DataSet.Philhealth), str(DataSet.BloodType), occuppationid, str(DataSet.OSIOSY), str(DataSet.PWD), diseasid, Group.id, DataSet.Philhealthexp, DataSet.Philhealthtype, "", DataSet.Gender)
            Next
        End If

    End Sub
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
End Class
