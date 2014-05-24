Imports System.Web.Mvc

Public Class HelloWorldController
    Inherits Controller

    ' GET: /HelloWorld
    Function Index() As ActionResult
        Return View()
    End Function

    'GET: /HelloWorld/Welcome/
    Function Welcome(name As String, Optional ID As Integer = 1) As String
        Return HttpUtility.HtmlEncode("Hello " & name & ", ID: " & ID)
    End Function
End Class