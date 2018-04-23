using System;
using System.Web;
using System.Data;
namespace PubsClasses
{
	public class AuthorClass
	{
		private DataSet dsAuthors = new System.Data.DataSet("ds1");
		private string filePath = HttpContext.Current.Server.MapPath ("~/App_Data/Authors.xml");
		public AuthorClass()
		{
			dsAuthors.ReadXml(filePath, System.Data.XmlReadMode.ReadSchema);
		}

		public DataSet GetAuthors()
		{
			return dsAuthors;
		}
	}
}
