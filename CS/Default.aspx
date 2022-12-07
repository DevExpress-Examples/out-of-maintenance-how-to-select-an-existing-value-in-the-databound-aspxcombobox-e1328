<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="TestPage" %>

<%@ register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
	<table>
	  <tr>
	  <td>
          DevExpress.Web.ASPxEditors.ASPxComboBox(ObjectDataSource):
	  </td>
	   <td>
		   <dxe:aspxcombobox ID="ASPxComboBox1" runat="server" DataSourceID="ObjectDataSource1" TextField="au_fname" ValueField="au_id" ValueType="System.String">
		   </dxe:aspxcombobox> 
	   </td>
	  </tr>
	<tr>
	  <td>
          System.Web.UI.WebControls.DropDownList(ObjectDataSource):</td>
	  <td>
		  <asp:dropdownlist ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="au_fname" DataValueField="au_id">
		  </asp:dropdownlist> 
	  </td>
	</tr>
	<tr>
	  <td>
          DevExpress.Web.ASPxEditors.ASPxComboBox(SqDataSource):</td>
	  <td>
          <dxe:ASPxComboBox ID="ASPxComboBox2" runat="server" DataSourceID="SqlDataSource1"
              Height="6px" TextField="ProductName" ValueField="ProductID" 
              ValueType="System.String">
          </dxe:ASPxComboBox>
		  
	  </td>
	</tr>
	</table>
	</div>
		<asp:objectdatasource ID="ObjectDataSource1" runat="server" SelectMethod="GetAuthors"
			TypeName="PubsClasses.AuthorClass"></asp:objectdatasource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
            SelectCommand="SELECT [ProductID], [ProductName] FROM [Products]"></asp:SqlDataSource>
	</form>
</body>
</html>
