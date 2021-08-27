<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550560/14.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T159638)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/ShowMessageAfterCallback/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/ShowMessageAfterCallback/Controllers/HomeController.vb))
* [Model.cs](./CS/ShowMessageAfterCallback/Models/Model.cs) (VB: [Model.vb](./VB/ShowMessageAfterCallback/Models/Model.vb))
* **[GridViewPartial.cshtml](./CS/ShowMessageAfterCallback/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/ShowMessageAfterCallback/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to show a message after CRUD operations
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t159638/)**
<!-- run online end -->


This example illustrates how to show a custom message after performing CRUD operations:<br />- Handle a particular <strong>Action</strong> method on the Controller side and save the related data/message via a custom ViewData key.<br />- Handle the <strong>GridViewSettings.CustomJSProperties</strong> event in the GridView's PartialView and check if a custom ViewData key exists. If so, store it as a custom JS Property.<br />- Handle the client-side <strong>ASPxClientGridView.EndCallback</strong> event and check if a custom JS Property exists. If so, visualize its value in the required manner and remove it.

<br/>


