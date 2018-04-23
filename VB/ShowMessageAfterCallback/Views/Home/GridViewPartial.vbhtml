@Imports ShowMessageAfterCallback.Controllers

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
    
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialAddNew"}
            settings.SettingsEditing.UpdateRowRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialUpdate"}
            settings.SettingsEditing.DeleteRowRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialDelete"}
            
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowNewButton = True
            settings.CommandColumn.ShowEditButton = True
            settings.CommandColumn.ShowDeleteButton = True

            settings.KeyFieldName = "ID"
            settings.Columns.Add("Text")

            settings.CustomJSProperties = _
                Sub(s, e)
                        If (ViewData(HomeController.EditResultKey) IsNot Nothing) Then
                            e.Properties("cpMessage") = ViewData(HomeController.EditResultKey).ToString()
                        End If
                End Sub

            settings.ClientSideEvents.EndCallback = "OnEndCallback"
    
    End Sub).SetEditErrorText(ViewData(HomeController.EditErrorKey)).Bind(Model).GetHtml()