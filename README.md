Web Api Crud Operations WinForms

This sample has two solutions

APITest: Winforms application Visual Studio 2019, .Net 4.7.2

API: Test Controller, Visual Studio 2019, .Net 4.7.2

Check following for more details: 
http://itplate.blogspot.com/2018/07/webapi-crud-calls-from-winforms.html

First run the API Application and then the WinForms APITest application to test.

API solution Test.Helpers is referenced inside APITest solution. Test.Helpers has the centralized CRUD calls which are used by the WinForms APITest application.

Also check that the API solution ==> Test.Helpers DLL is inside the WinForms \Asset folders and referenced in the Winforms application. 