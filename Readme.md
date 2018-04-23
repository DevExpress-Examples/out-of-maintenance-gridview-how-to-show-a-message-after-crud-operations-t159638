# GridView - How to show a message after CRUD operations


This example illustrates how to show a custom message after performing CRUD operations:<br />- Handle a particular <strong>Action</strong> method on the Controller side and save the related data/message via a custom ViewData key.<br />- Handle the <strong>GridViewSettings.CustomJSProperties</strong> event in the GridView's PartialView and check if a custom ViewData key exists. If so, store it as a custom JS Property.<br />- Handle the client-side <strong>ASPxClientGridView.EndCallback</strong> event and check if a custom JS Property exists. If so, visualize its value in the required manner and remove it.

<br/>


