using System;
using System.IO;
using System.Xml;

namespace GenesisCraftCLI
{
	class MainClass
	{
		[STAThread]
		public static void Main (string[] args)
		{
			Console.WriteLine ("Starting Server...");
			if (File.Exists ("config.xml")) {
				Console.WriteLine ("Configuration File Found, Loading...");
				parseXML ();
			} else {
				Console.WriteLine ("Configuration File Missing");
			}
		}

		public static void parseXML()
		{
			XmlReader xmlReader = XmlReader.Create ("config.xml");
			while (xmlReader.Read()) 
			{
				if((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Setting"))
				{
					if(xmlReader.HasAttributes)
						Console.WriteLine(xmlReader.GetAttribute("playerCap") + ": " + xmlReader.GetAttribute("value"));                    
				}
			}
		}
	}
}
