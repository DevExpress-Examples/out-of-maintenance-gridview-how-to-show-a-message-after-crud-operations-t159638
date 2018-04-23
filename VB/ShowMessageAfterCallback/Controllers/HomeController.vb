Imports System
Imports System.Web.Mvc

Namespace ShowMessageAfterCallback.Controllers
	Public Class HomeController
		Inherits Controller

		Public Const EditResultKey As String = "EditResult"
		Public Const EditErrorKey As String = "EditError"

		Private repository As New Repository()

		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView(repository.GetItems())
		End Function
		Public Function GridViewPartialAddNew(ByVal entry As DataEntry) As ActionResult
			If ModelState.IsValid Then
				Try
					repository.Add(entry)
					ViewData(EditResultKey) = String.Format("ADDED WITH KEY: '{0}'", entry.ID)
				Catch e As Exception
					ViewData(EditErrorKey) = e.Message
				End Try
			Else
				ViewData(EditErrorKey) = "Please, correct all errors."
			End If
			Return PartialView("GridViewPartial", repository.GetItems())
		End Function
		Public Function GridViewPartialUpdate(ByVal entry As DataEntry) As ActionResult
			If ModelState.IsValid Then
				Try
					repository.Update(entry)
					ViewData(EditResultKey) = String.Format("UPDATED WITH KEY: '{0}'", entry.ID)
				Catch e As Exception
					ViewData(EditErrorKey) = e.Message
				End Try
			Else
				ViewData(EditErrorKey) = "Please, correct all errors."
			End If
			Return PartialView("GridViewPartial", repository.GetItems())
		End Function
		Public Function GridViewPartialDelete(ByVal id As Integer) As ActionResult
			If id >= 0 Then
				Try
					repository.Delete(id)
					ViewData(EditResultKey) = String.Format("DELETED WITH KEY: '{0}'", id)
				Catch e As Exception
					ViewData(EditErrorKey) = e.Message
				End Try
			End If
			Return PartialView("GridViewPartial", repository.GetItems())
		End Function
	End Class
End Namespace