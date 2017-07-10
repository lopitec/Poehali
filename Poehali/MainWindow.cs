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
        IStorageService storageService = new Storagestriming();
        IStorageService datacontracting = new DataContracting();

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
            storageService.WriteData(listBox1.Items, "C:/TestProjects/workers.xml");
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
            var workers = storageService.ReadData("C:/TestProjects/workers.xml");
            foreach (var worker in workers)
            {
                listBox1.Items.Add(worker); 
            }
             
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            datacontracting.WriteData(listBox1.Items, "C:/TestProjects/workerdatacontract.xml");
        }

        
        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            var workers = datacontracting.ReadData("C:/TestProjects/workerdatacontract.xml");
            foreach (var worker in workers)
            {
                listBox1.Items.Add(worker);
            }
        }
    }
}
    