Imports [Interface]
Public Class CitizensRepository
    Dim conn As New Connection
    Dim logs As New SystemLogsRepository
    Dim LCRepo As New LocationRepository
    Dim SIRepo As New SubInformationRepository
#Region "Citizen"
    Public Function InsertToCitizen(ByVal hid As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal birth As Date, ByVal contactnum As String, ByVal tin As String, ByVal philhealth As String, ByVal bloodtype As String, ByVal occupation As Integer, ByVal osyisy As String, ByVal pwe As String, ByVal diseased As Integer, ByVal category As Integer, ByVal philheaexp As Date, ByVal philhealthtype As Integer, ByVal income As String, ByVal gender As String) As citizen
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New citizen
            With insertdata
                .hid = hid
                .fname = fname
                .birthdate = birth
                .bloodtypeid = bloodtype
                .category = category
                .contactnum = contactnum
                .diseased = diseased
                .lname = lname
                .mname = mname
                .occupation = occupation
                .osyisy = osyisy
                .philhealth = philhealth
                .philhealthexp = philheaexp
                .philhealthtype = philhealthtype
                .pwe = pwe
                .income = income
                .remove = False
                .tin = tin
                .Gender = gender
            End With
            dbconn.AddTocitizens(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Citizen", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function UpdateCitizensByID(ByVal citizenid As Integer, ByVal hid As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal birth As Date, ByVal contactnum As String, ByVal tin As String, ByVal philhealth As String, ByVal bloodtype As String, ByVal occupation As Integer, ByVal osyisy As String, ByVal pwe As String, ByVal diseased As Integer, ByVal category As Integer, ByVal philheaexp As Date, ByVal philhealthtype As Integer, ByVal income As String, ByVal gender As String) As citizen
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizens
                         Where data.id = citizenid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                With result
                    .hid = hid
                    .fname = fname
                    .birthdate = birth
                    .bloodtypeid = bloodtype
                    .category = category
                    .contactnum = contactnum
                    .diseased = diseased
                    .lname = lname
                    .mname = mname
                    .occupation = occupation
                    .osyisy = osyisy
                    .philhealth = philhealth
                    .philhealthexp = philheaexp
                    .philhealthtype = philhealthtype
                    .pwe = pwe
                    .income = income
                    .remove = False
                    .tin = tin
                    .Gender = gender
                End With
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Citizen", result.id, "Update old record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofcitizensByHousehold(ByVal householdid As Integer) As List(Of citizen)
        Dim ListCitizen As New List(Of citizen)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.citizens
                         Where data.remove = False And data.hid = householdid
                         Select data
            If result IsNot Nothing Then
                ListCitizen.AddRange(result.Take(10))
            End If
        End Using
        Return ListCitizen
    End Function
    Public Function GetListofcitizens() As List(Of citizen)
        Dim listbrgy As New List(Of citizen)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.citizens
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetcitizensDatabyID(ByVal citizenid As Integer) As citizen
        Dim item As New citizen
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizens
                         Where data.remove = False And data.id = citizenid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function Removecitizens(ByVal citizenid As Integer) As citizen
        Dim item As New citizen
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizens
                         Where data.remove = False And data.id = citizenid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                logs.InsertSystemLogs("Citizen", result.id, "Remove old record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region

#Region "Category"

    Public Function InsertToCCategory(ByVal name As String) As citizencategory
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New citizencategory
            With insertdata
                .name = name
            End With
            dbconn.AddTocitizencategories(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Citizen Category", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function CheckCCategoryByName(ByVal name As String) As citizencategory
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizencategories
                         Where data.name.ToUpper = name.ToUpper
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToCCategory(name)
            End If
        End Using
    End Function
    Public Function UpdateCCategoryByID(ByVal CCategoryid As Integer, ByVal CCategoryname As String) As citizencategory
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizencategories
                         Where data.id = CCategoryid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = CCategoryname
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Citizen Category", result.id, "Modify old record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofCCategory() As List(Of citizencategory)
        Dim listbrgy As New List(Of citizencategory)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.citizencategories
                         Order By data.name
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetCCategoryDatabyID(ByVal CCategoryid As Integer) As citizencategory
        Dim item As New citizencategory
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizencategories
                         Where data.remove = False And data.id = CCategoryid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveCategory(ByVal CCategoryid As Integer) As citizencategory
        Dim item As New citizencategory
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.citizencategories
                         Where data.remove = False And data.id = CCategoryid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Citizen Category", result.id, "Remove old record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region

#Region "Households"
    Public Function InsertToHousehold(ByVal hnumber As Integer, ByVal SocialCommunity As Integer, ByVal familyname As String, ByVal purokid As Integer, ByVal barangayid As Integer, ByVal categoryid As Integer, ByVal cityid As Integer, ByVal famid As Integer) As household
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New household
            With insertdata
                .familyname = familyname
                .hnumber = hnumber
                .purokid = purokid
                .SocialCommunity = SocialCommunity
                .barangayid = barangayid
                .categoryid = categoryid
                .cityid = cityid
                .famid = famid
            End With
            dbconn.AddTohouseholds(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Household", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function UpdateHouseholdByID(ByVal hid As Integer, ByVal hnumber As Integer, ByVal SocialCommunity As Integer, ByVal familyname As String, ByVal purokid As Integer, ByVal barangayid As Integer, ByVal categoryid As Integer, ByVal cityid As Integer, ByVal famid As Integer) As household
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.households
                         Where data.id = hid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                With result
                    .familyname = familyname
                    .hnumber = hnumber
                    .purokid = purokid
                    .SocialCommunity = SocialCommunity
                    .barangayid = barangayid
                    .categoryid = categoryid
                    .cityid = cityid
                    .famid = famid
                End With
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Household", result.id, "Update old record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofHouseholdByHousehold(ByVal householdid As Integer) As List(Of household)
        Dim listbrgy As New List(Of household)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.citizens
                         Where data.remove = False And data.hid = householdid
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetListofHousehold() As List(Of household)
        Dim listbrgy As New List(Of household)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.households
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetListofHouseholdMods() As List(Of HouseholdLibrary)
        Dim listbrgy As New List(Of HouseholdLibrary)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.households
                         Where data.remove = False
                         From city In dbconn.cities
                         Where city.id = data.cityid
                         From barangay In dbconn.barangays
                         Where barangay.id = data.barangayid
                         From purok In dbconn.puroks
                         Where purok.id = data.purokid
                         From sc In dbconn.socialstatus
                         Where sc.id = data.SocialCommunity
                         From group In dbconn.citizencategories
                         Where group.id = data.categoryid
                         Select New HouseholdLibrary With { _
                            .Barangay = barangay.name,
                            .Category = group.name,
                            .City = city.name,
                            .DateCreated = data.datecreated,
                            .FamilyMemberCount = (From member In dbconn.citizens Where member.hid = data.id Select member).Count,
                            .FamilyName = data.familyname,
                            .FamilyNumber = data.famid,
                            .Householdnumber = data.hnumber,
                            .Purok = purok.name,
                            .Record = data.id,
                            .SocialComunity = sc.name}
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetHouseholdDatabyID(ByVal householdid As Integer) As household
        Dim item As New household
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.households
                         Where data.remove = False And data.id = householdid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveHousehold(ByVal citizenid As Integer) As household
        Dim item As New household
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.households
                         Where data.remove = False And data.id = citizenid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                Dim result2 = From data In dbconn.citizens
                                 Where data.remove = False And data.hid = result.id
                                 Select data
                For Each items As citizen In result2
                    items.remove = True
                Next
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Household", result.id, "Remove old record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region

#Region "Search Algorythm"

    Public Function SearchHousehold(ByVal SearchList As SearchLibrary, ByVal rows As Integer, ByVal skipcount As Integer) As List(Of HouseholdLibrary)
        Dim request As New List(Of HouseholdLibrary)
        Dim temphs As New List(Of household)
        Using dbconn As New flguEntities(conn.MySQLCon)

            Dim resultdata = From data In dbconn.households
                         Where data.remove = False
                         Select data
            If resultdata IsNot Nothing Then
                With SearchList
                    If .HouseholdNumber > 0 Then
                        resultdata = resultdata.Where(Function(x) x.hnumber = .HouseholdNumber)
                    End If
                    If .FamilyNumber > 0 Then
                        resultdata = resultdata.Where(Function(x) x.famid = .FamilyNumber)
                    End If
                    If .SocailComunityID > 0 Then
                        resultdata = resultdata.Where(Function(x) x.SocialCommunity = .SocailComunityID)
                    End If
                    If .CityID > 0 Then
                        resultdata = resultdata.Where(Function(x) x.cityid = .CityID)
                        If .BarangayID > 0 Then
                            resultdata = resultdata.Where(Function(x) x.barangayid = .BarangayID)
                            If .PurokID > 0 Then
                                resultdata = resultdata.Where(Function(x) x.purokid = .PurokID)
                            End If
                        End If
                    End If
                    If .CategoryID > 0 Then
                        resultdata = resultdata.Where(Function(x) x.categoryid = .CategoryID)
                    End If
                    If .FamilyName.Trim <> "" Then
                        resultdata = resultdata.Where(Function(x) x.familyname = .FamilyName)
                    End If
                    If resultdata IsNot Nothing Then
                        temphs = resultdata.ToList()
                    End If

                End With
                If resultdata IsNot Nothing Then
                    Dim finalresult = temphs.Select(Function(x) New HouseholdLibrary With {
                                        .Barangay = LCRepo.GetBarangayDatabyID(x.barangayid).name,
                                        .City = LCRepo.GetCityDatabyID(x.cityid).name,
                                        .DateCreated = x.datecreated,
                                        .FamilyMemberCount = GetListofcitizensByHousehold(x.id).Count,
                                        .FamilyName = x.familyname,
                                        .FamilyNumber = x.famid,
                                        .Householdnumber = x.hnumber,
                                        .Purok = LCRepo.GetPurokDatabyID(x.purokid).name,
                                        .Category = GetCCategoryDatabyID(x.categoryid).name,
                                        .Record = x.id,
                                        .SocialComunity = SIRepo.GetSocialStatusDatabyID(x.SocialCommunity).name})
                    If finalresult IsNot Nothing Then
                        If (skipcount > 0) Then
                            request = finalresult.Skip(skipcount).Take(rows).ToList()
                        Else
                            request = finalresult.Take(rows).ToList()
                        End If
                    End If
                End If
            End If
            Return request
        End Using
    End Function
    Public Function SearchCitizen(ByVal SearchList As SearchLibrary, ByVal rows As Integer, ByVal skipcount As Integer) As List(Of CitizenInformation)
        Dim tmpcresult As New List(Of citizen)
        Dim tmphousehold As New List(Of household)
        Dim requestedresult As New List(Of CitizenInformation)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim hsresult = From data In dbconn.households
                         Where data.remove = False
                         Select data
            If hsresult IsNot Nothing Then

                With SearchList
                    If .HouseholdNumber > 0 And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.hnumber = .HouseholdNumber)
                    End If
                    If .FamilyNumber > 0 And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.famid = .FamilyNumber)
                    End If
                    If .SocailComunityID > 0 And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.SocialCommunity = .SocailComunityID)
                    End If
                    If .CityID > 0 And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.cityid = .CityID)
                        If .BarangayID > 0 And tmphousehold IsNot Nothing Then
                            hsresult = hsresult.Where(Function(x) x.barangayid = .BarangayID)
                            If .PurokID > 0 And hsresult IsNot Nothing Then
                                hsresult = hsresult.Where(Function(x) x.purokid = .PurokID)
                            End If
                        End If
                    End If
                    If .CategoryID > 0 And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.categoryid = .CategoryID)
                    End If
                    If .FamilyName.Trim <> "" And hsresult IsNot Nothing Then
                        hsresult = hsresult.Where(Function(x) x.familyname.ToUpper = .FamilyName.ToUpper)
                    End If
                    If hsresult IsNot Nothing Then
                        tmphousehold = hsresult.ToList()
                    End If
                End With

                If tmphousehold IsNot Nothing Then
                    Dim getcitizen = From data In dbconn.citizens
                                     Where data.remove = False
                                     Select data

                    If getcitizen IsNot Nothing Then
                        tmpcresult = getcitizen.ToList()
                        Dim cresult = From data In tmpcresult
                                      From house In tmphousehold
                                      Where data.hid = house.id
                                      Select data
                        With SearchList
                            If .Philhealth <> "" And cresult IsNot Nothing Then
                                If .Philhealth = "R" Then
                                    cresult = cresult.Where(Function(x) x.philhealth <> "0")
                                ElseIf .Philhealth = "U" Then
                                    cresult = cresult.Where(Function(x) x.philhealth = "0")
                                End If
                            End If
                            If .BIR <> "" And cresult IsNot Nothing Then
                                If .BIR = "R" Then
                                    cresult = cresult.Where(Function(x) x.tin <> 0)
                                ElseIf .BIR = "U" Then
                                    cresult = cresult.Where(Function(x) x.tin = 0)
                                End If
                            End If
                            If .PhilhealthTypeID > -1 And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.philhealthtype = .PhilhealthTypeID)
                            End If
                            If .BloodType.Trim <> "" And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.bloodtypeid = .BloodType.Trim)
                            End If
                            If .OccupationID > -1 And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.occupation = .OccupationID)
                            End If
                            If .OSYISY.Trim <> "" And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.osyisy = .OSYISY.Trim)
                            End If
                            If .DiseasedID > -1 And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.diseased = .DiseasedID)
                            End If
                            If .pwd.Trim <> "" And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.pwe = .pwd.Trim)
                            End If
                            If .Gender.Trim <> "" And cresult IsNot Nothing Then
                                cresult = cresult.Where(Function(x) x.Gender = .Gender.Trim)
                            End If
                            If .KeyString.Trim <> "" And cresult IsNot Nothing Then
                                Dim data = .KeyString.Trim.Split(" ")

                                For Each dataitems As String In data
                                    cresult = cresult.Where(Function(x) x.fname.ToUpper = dataitems.ToUpper Or x.mname.ToUpper = dataitems.ToUpper Or x.lname.ToUpper = dataitems.ToUpper)
                                Next


                            End If
                            If cresult IsNot Nothing Then
                                Dim modified = From data In cresult
                                                From hs In tmphousehold
                                                Where hs.id = data.hid
                                                Select New CitizenInformation With {
                                                .Barangay = LCRepo.GetBarangayDatabyID(hs.barangayid).name,
                                                .Category = SIRepo.GetSocialStatusDatabyID(hs.categoryid).name,
                                                .City = LCRepo.GetCityDatabyID(hs.cityid).name,
                                                .Purok = LCRepo.GetPurokDatabyID(hs.purokid).name,
                                                .SocialStatus = SIRepo.GetSocialStatusDatabyID(hs.SocialCommunity).name,
                                                .Housholdnum = hs.hnumber,
                                                .FamilyNum = hs.famid,
                                                .Firstname = data.fname,
                                                .mi = data.mname,
                                                .lastname = data.lname,
                                                .birth = data.birthdate,
                                                .age = CalculateAge(data.birthdate),
                                                .bloodtype = data.bloodtypeid,
                                                .contact = data.contactnum,
                                                .Gender = data.Gender,
                                                .income = data.income,
                                                .occupation = SIRepo.GetOccupationDatabyID(data.occupation).name,
                                                .osy = data.osyisy,
                                                .philhealth = data.philhealth,
                                                .philhealthexp = data.philhealthexp.Date,
                                                .philhealthtype = data.philhealthtype,
                                                .recordid = data.id
                                                }
                                If modified IsNot Nothing Then
                                    If (skipcount > 0) Then
                                        Return modified.Skip(skipcount).Take(rows).ToList()
                                    Else
                                        Return modified.Take(rows).ToList()
                                    End If

                                Else
                                    Return requestedresult
                                End If
                            Else
                                Return requestedresult
                            End If

                        End With
                    Else
                        Return requestedresult
                    End If
                Else
                    Return requestedresult
                End If
            Else
                Return requestedresult
            End If

        End Using

    End Function
    Public Function CalculateAge(ByVal StartDate As DateTime) As Integer
        Dim dt As Long = DateDiff(DateInterval.Month, StartDate, Now.Date)
        Dim years As Integer = dt \ 12
        Return years
    End Function




#End Region
End Class
