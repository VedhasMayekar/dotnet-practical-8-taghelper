# Practical 8 — HTML Helpers in ASP.NET Core MVC

**Aim:** Use HTML Helpers for creating interactive forms.

Demonstrates TextBox, TextArea, DropDownList, CheckBox, Password, RadioButton, ListBox, HiddenField, and dynamic links using ActionLink and RouteLink.

## Run
Open `pract8.csproj` in Visual Studio 2026 with the .NET 8 SDK and run. The default route opens `/Emp/Create`.

## Note about the journal sample
The country dropdown is populated in the controller with India, Canada, and Japan; the journal does not include database-fetching code. Employee submissions are kept in a static in-memory list here, not a database, and will reset when the app restarts.
