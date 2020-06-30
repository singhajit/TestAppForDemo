using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace TestDemoWebApiCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDemoController : Controller
    {
        [HttpGet]
        public List<Person> Get(string input)
        {
            XmlDocument doc = new XmlDocument();
            List<Person> objListPer = new List<Person>();
            if(!string.IsNullOrWhiteSpace(input))
            {
                doc.LoadXml(input);
                var nodes = doc.GetElementsByTagName("T2");
                foreach(XmlNode item in nodes)
                {
                    Person objperson = new Person();
                    objperson.name = item.SelectSingleNode("./name").InnerText;
                    objperson.phno = item.SelectSingleNode("./phno").InnerText;
                    objListPer.Add(objperson);
                }
            }
           return objListPer;
            
        }
    }
}

public class Person
{
    public string name { get; set; }
    public string phno { get; set; }
}