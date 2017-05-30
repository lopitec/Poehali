

namespace Poehali
{
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;

    internal class StorageService
    {
        public void WriteData(ListBox listBox1, string filename)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(filename))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("workers");

                foreach (object workerobj in listBox1.Items)
                {
                    Worker worker = (Worker)workerobj;
                    if (worker == null)
                        continue;

                    xmlWriter.WriteStartElement("worker");
                    xmlWriter.WriteAttributeString("name", worker.Name);
                    xmlWriter.WriteAttributeString("age", worker.Age.ToString());
                    xmlWriter.WriteAttributeString("weight", worker.Weight.ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }

        public void ReadData(ListBox listBox1, string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }

            using (XmlReader reader = XmlReader.Create(filename))
            { 
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.HasAttributes)
                        {
                            int weight = int.Parse(reader.GetAttribute("weight"));
                            int age = int.Parse(reader.GetAttribute("age"));
                            string name = reader.GetAttribute("name");
                            var worker = new Worker(name, weight, age);
                            listBox1.Items.Add(worker);
                        }
                    }
                }
            }
        } 
    }
}

