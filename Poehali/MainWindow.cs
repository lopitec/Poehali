namespace Poehali
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Xml;

    public partial class MainWindow : Form
    {
        #region Constructors and Finalizers

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void AddClick(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            int weigth = (int)numericUpDownWeight.Value;
            int age = (int)numericUpDownAge.Value;

            var child = new Worker(name, weigth, age);

            listBox1.Items.Add(child);
        }

        private void ButtonRemoveClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void buttonSaveList_Click(object sender, EventArgs e)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create("C:/TestProjects/workers.xml"))
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

        private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            Worker worker = (Worker)listBox1.SelectedItem;
            this.TextBoxName.Text = worker.Name;
            this.numericUpDownWeight.Value = worker.Weight;
            this.numericUpDownAge.Value = worker.Age;
        }

        private void TextBoxNameTextChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            Worker worker = (Worker)listBox1.SelectedItem;
            worker.Name = TextBoxName.Text;
            listBox1.SelectedItem = worker;
        }

        #endregion

        private void buttonReadXml_Click(object sender, EventArgs e)
        {
            using (XmlReader reader = XmlReader.Create("C:/TestProjects/workers.xml"))
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
    