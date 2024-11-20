using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Configure the XML Writer settings
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;

        // Create the XML file
        using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("GPS_Log");

            // Add Position element with attributes and sub-elements
            writer.WriteStartElement("Position");
            writer.WriteAttributeString("DateTime", DateTime.Now.ToString());

            writer.WriteElementString("x", "65.8973342");
            writer.WriteElementString("y", "72.3452346");

            writer.WriteStartElement("SatteliteInfo");
            writer.WriteElementString("Speed", "40");
            writer.WriteElementString("NoSatt", "7");
            writer.WriteEndElement(); // End SatteliteInfo

            writer.WriteEndElement(); // End Position

            // Add Image element with attributes and sub-elements
            writer.WriteStartElement("Image");
            writer.WriteAttributeString("Resolution", "1024x800");
            writer.WriteElementString("Path", @"images\1.jpg");
            writer.WriteEndElement(); // End Image

            writer.WriteEndDocument();
        }

        Console.WriteLine("XML File 'GPS.xml' created successfully!");
    }
}
