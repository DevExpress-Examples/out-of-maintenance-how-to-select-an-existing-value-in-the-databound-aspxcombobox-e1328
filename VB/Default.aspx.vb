Imports Microsoft.VisualBasic
Imports System
Partial Public Class TestPage 
    Inherits System.Web.UI.Page
	Protected Overrides Sub OnInit(ByVal e As EventArgs)
		MyBase.OnInit(e)
		AddHandler ASPxComboBox1.DataBound, AddressOf ASPxComboBox1_DataBound
		AddHandler ASPxComboBox2.DataBound, AddressOf ASPxComboBox2_DataBound
		AddHandler DropDownList1.DataBound, AddressOf DropDownList1_DataBound
	End Sub
	Private Sub ASPxComboBox2_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		'By value
		ASPxComboBox2.SelectedItem = ASPxComboBox2.Items.FindByValue("17")
		'OR by display text
		ASPxComboBox2.SelectedItem = ASPxComboBox2.Items.FindByText("Chai")
	End Sub
	Private Sub DropDownList1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim someText As String = "213-46-8915" ' the ID for Chris
		DropDownList1.SelectedValue = someText
	End Sub
	Protected Sub ASPxComboBox1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs)
		'By value
		Dim iterator As Integer = 0
		For iterator = 0 To ASPxComboBox1.Items.Count - 1
			Dim currentItem As DevExpress.Web.ASPxEditors.ListEditItem = ASPxComboBox1.Items(iterator)
			If currentItem.Value.ToString() = "213-46-8915" Then
				ASPxComboBox1.SelectedItem = currentItem
			End If
		Next iterator
		'OR by display text
		'ASPxComboBox1.SelectedIndex = ASPxComboBox1.Items.IndexOfText("Chris");
	End Sub
End Class