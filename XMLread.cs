using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load and read the XML file
        using (XmlReader reader = XmlReader.Create("GPS.xml"))
        {
            while (reader.Read())
            {
                // Process each node type
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write($"<{reader.Name}");
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                Console.Write($" {reader.Name}=\"{reader.Value}\"");
                            }
                        }
                        Console.WriteLine(">");
                        break;

                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;

                    case XmlNodeType.EndElement:
                        Console.WriteLine($"</{reader.Name}>");
                        break;
                }
            }
        }
    }
}
