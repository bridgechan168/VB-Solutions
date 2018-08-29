Imports System.Net
Imports System.Web.Http

<RoutePrefix("api")>
Public Class ProductController
    Inherits ApiController

    ' GET api/products
    <Route("products")>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"Orange", "Apple"}
    End Function

    ' GET api/products/5
    <Route("products/{id}")>
    Public Function GetValue(ByVal id As Integer) As String
        Return "Apple"
    End Function

    ' POST api/products
    <Route("products/go")>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/products/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
