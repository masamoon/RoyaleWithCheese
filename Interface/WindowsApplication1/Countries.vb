Imports System.Collections.Generic
Imports System.Globalization

Public Class Countries
    Public Shared Function GetCounties() As SortedDictionary(Of String, String)

        Dim countryList As New SortedDictionary(Of String, String)
        ' Iterate the Framework Cultures...
        For Each ci As CultureInfo In CultureInfo.GetCultures(CultureTypes.NeutralCultures)
            Dim ri As RegionInfo
            Try
                ri = New RegionInfo(ci.Name)
            Catch
                ' If a RegionInfo object could not be created we don't want to use the CultureInfo
                '    for the country list.
                Continue For
            End Try
            ' Create new country dictionary entry.
            Dim newKeyValuePair As New KeyValuePair(Of String, String)(ri.EnglishName, ri.ThreeLetterISORegionName)

            ' If the country is not alreayd in the countryList add it...
            If Not countryList.ContainsKey(ri.EnglishName) Then
                countryList.Add(newKeyValuePair.Key, newKeyValuePair.Value)
            End If
        Next

        Return countryList
    End Function
End Class