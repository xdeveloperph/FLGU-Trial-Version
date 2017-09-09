Imports [Interface]
Public Class LocationRepository
    Dim conn As New Connection
#Region "Barangay"
    Public Class BarangayDatalist
        Public Property bid As Integer
        Public Property cityname As String
        Public Property bname As String
        Public Property cityid As Integer
    End Class
    Public Class CityCombobox
        Public cityid As Integer
        Public cityname As String
    End Class
    Dim logs As New SystemLogsRepository
    Public Function InsertToBarangay(ByVal bname As String, ByVal cityid As Integer) As barangay
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New barangay
            With insertdata
                .name = bname
                .cityid = cityid
            End With
            dbconn.AddTobarangays(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Barangay", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function CheckBarangayByName(ByVal bname As String) As barangay
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.barangays
                         Where data.name.ToUpper = bname.ToUpper
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToBarangay(bname, 1)
            End If
        End Using
    End Function
    Public Function UpdateBarangayByID(ByVal barangayid As Integer, ByVal barangayname As String, ByVal cityid As Integer) As barangay
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.barangays
                         Where data.id = barangayid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = barangayname
                result.cityid = cityid
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Barangay", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofBarangay() As List(Of BarangayDatalist)
        Dim listbrgy As New List(Of BarangayDatalist)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.barangays
                         Where data.remove = False
                        From data1 In dbconn.cities
                        Where data1.id = data.cityid()
                        Select New BarangayDatalist With {
                            .bid = data.id,
                            .bname = data.name,
                            .cityid = data1.id,
                            .cityname = data1.name
                            }
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetListofBarangayOrig() As List(Of barangay)
        Dim listbrgy As New List(Of barangay)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.barangays
                         Where data.remove = False
                        Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetBarangayDatabyID(ByVal barangayid As Integer) As barangay
        Dim item As New barangay
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.barangays
                         Where data.remove = False And data.id = barangayid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function GetBarangayListbyCityID(ByVal cityid As Integer) As List(Of barangay)
        Dim item As New List(Of barangay)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.barangays
                          Order By data.name
                         Where data.remove = False And data.cityid = cityid
                         Select data
            If result IsNot Nothing Then
                item.AddRange(result.Take(10))
            End If
            Return item
        End Using
    End Function
    Public Function RemoveBarangay(ByVal barangayid As Integer) As barangay
        Dim item As New barangay
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.barangays
                         Where data.remove = False And data.id = barangayid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("Barangay", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function


#End Region

#Region "City"
    Public Function InsertToCity(ByVal name As String) As city
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New city
            With insertdata
                .name = name
            End With
            dbconn.AddTocities(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("City", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function UpdateCity(ByVal cityid As Integer, ByVal cityname As String) As city
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.cities
                         Where data.id = cityid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = cityname
                dbconn.SaveChanges()
                logs.InsertSystemLogs("City", result.id, "Modiy new record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofCity() As List(Of city)
        Dim listbrgy As New List(Of city)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.cities
                          Order By data.name
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetCityDatabyID(ByVal cityid As Integer) As city
        Dim item As New city
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.cities
                         Where data.remove = False And data.id = cityid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemoveCity(ByVal cityid As Integer) As city
        Dim item As New city
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.cities
                         Where data.remove = False And data.id = cityid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("City", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
#End Region

#Region "Zone"
    Public Function InsertToPurok(ByVal name, ByVal barangayid) As purok
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim insertdata As New purok
            With insertdata
                .name = name
                .barangayid = barangayid
            End With
            dbconn.AddTopuroks(insertdata)
            dbconn.SaveChanges()
            logs.InsertSystemLogs("Purok", insertdata.id, "Add new record.", My.Settings.loginid)
            Return insertdata
        End Using
    End Function
    Public Function CheckPurokByName(ByVal name As String, ByVal barangayid As String) As purok
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.puroks
                         Where data.name.ToUpper = name.ToUpper And data.barangayid = barangayid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                Return result
            Else
                Return InsertToPurok(name, barangayid)
            End If
        End Using
    End Function
    Public Function UpdatePurok(ByVal purokid As Integer, ByVal purokname As String, ByVal barangayid As Integer) As purok
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.puroks
                         Where data.id = purokid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                result.name = purokname
                result.barangayid = barangayid
                dbconn.SaveChanges()
                logs.InsertSystemLogs("Purok", result.id, "Modify a record.", My.Settings.loginid)
            End If
            Return result
        End Using
    End Function
    Public Function GetListofPurok() As List(Of purok)
        Dim listbrgy As New List(Of purok)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.puroks
                         Where data.remove = False
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetListofPurokByBarangayID(ByVal barangayid As Integer) As List(Of purok)
        Dim listbrgy As New List(Of purok)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.puroks
                         Order By data.name
                         Where data.remove = False And data.barangayid = barangayid
                         Select data
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(10))
            End If
            Return listbrgy
        End Using
    End Function
    Public Function GetPurokDatabyID(ByVal purokid As Integer) As purok
        Dim item As New purok
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.puroks
                         Where data.remove = False And data.id = purokid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                item = result
            End If
            Return item
        End Using
    End Function
    Public Function RemovePurok(ByVal purokid As Integer) As purok
        Dim item As New purok
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = (From data In dbconn.puroks
                         Where data.remove = False And data.id = purokid
                         Select data).FirstOrDefault()

            If result IsNot Nothing Then
                result.remove = True
                dbconn.SaveChanges()
                item = result
                logs.InsertSystemLogs("Purok", result.id, "Delete a record.", My.Settings.loginid)
            End If
            Return item
        End Using
    End Function
    Public Function GetListofPurokCInfo() As List(Of PurokInformation)
        Dim listbrgy As New List(Of PurokInformation)
        Using dbconn As New flguEntities(conn.MySQLCon)
            Dim result = From data In dbconn.puroks
                         Where data.remove = False
                         From brg In dbconn.barangays
                         Where brg.id = data.barangayid
                         Select New PurokInformation With {
                            .recorid = data.id, .datecreated = data.datecreated, .name = data.name, .barangayname = brg.name
                        }
            If result IsNot Nothing Then
                listbrgy.AddRange(result.Take(5))
            End If
            Return listbrgy
        End Using
    End Function

#End Region
End Class
