Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class DataEntry
	Public Property ID() As Integer
	Public Property Text() As String
End Class

Public Class Repository
	Public Function GetItems() As List(Of DataEntry)
		If HttpContext.Current.Session("Items") Is Nothing Then
			Dim list As List(Of DataEntry) = Enumerable.Range(0, 100).Select(Function(i) New DataEntry With {.ID = i, .Text = "Text - " & i}).ToList()
			HttpContext.Current.Session("Items") = list
		End If
		Return DirectCast(HttpContext.Current.Session("Items"), List(Of DataEntry))
	End Function

	Public Sub Add(ByVal entry As DataEntry)
		Dim list As List(Of DataEntry) = GetItems()
		entry.ID = list.Count + 1
		list.Add(entry)
	End Sub

	Public Sub Update(ByVal entryInfo As DataEntry)
		Dim editedEntry As DataEntry = GetItems().Where(Function(m) m.ID = entryInfo.ID).First()
		editedEntry.Text = entryInfo.Text
	End Sub

	Public Sub Delete(ByVal id As Integer)
		Dim list As List(Of DataEntry) = GetItems()
		list.Remove(list.Where(Function(m) m.ID = id).First())
	End Sub
End Class