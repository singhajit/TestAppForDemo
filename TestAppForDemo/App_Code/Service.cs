using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public List<Person> PostData(string value)
	{
		List<Person> lstPerson = new List<Person>();
		if (value != null)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(value);
			if (value != null)
			{
				doc = new XmlDocument();

				doc.LoadXml(value);
				var empNodes = doc.SelectNodes(@"//emp");
				foreach (XmlNode item in empNodes)
				{
					Person objPerson = new Person();
					objPerson.PersonName = item.SelectSingleNode("./name").InnerText;
					objPerson.Phno = item.SelectSingleNode("./phno").InnerText;
					lstPerson.Add(objPerson);
				}
			}
		}
		return lstPerson;

	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
