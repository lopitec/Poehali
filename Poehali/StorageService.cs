

namespace Poehali
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;
    

    internal class Storagestriming: IStorageService
      
    {
        public void WriteData(ICollection workers, string filename)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(filename))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("workers");

                foreach (object workerobj in workers)
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

        public ICollection ReadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return null;
            }
            var workers = new ArrayList();

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
                            workers.Add(worker);
                        }
                    }
                }
            }

            return workers;
        } 
    }
}

