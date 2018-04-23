Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Data
Namespace PubsClasses
	Public Class AuthorClass
		Private dsAuthors As DataSet = New System.Data.DataSet("ds1")
		Private filePath As String = HttpContext.Current.Server.MapPath ("~/App_Data/Authors.xml")
		Public Sub New()
			dsAuthors.ReadXml(filePath, System.Data.XmlReadMode.ReadSchema)
		End Sub

		Public Function GetAuthors() As DataSet
			Return dsAuthors
		End Function
	End Class
End Namespace
