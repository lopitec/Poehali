namespace Poehali
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Add = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReadXml = new System.Windows.Forms.Button();
            this.buttonSaveList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(655, 71);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 44);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 91);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(232, 33);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.LostFocus += new System.EventHandler(this.TextBoxNameTextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(766, 452);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(292, 92);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAge.TabIndex = 5;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(456, 92);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWeight.TabIndex = 6;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(845, 71);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(185, 44);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
            // 
            // buttonReadXml
            // 
            this.buttonReadXml.Location = new System.Drawing.Point(845, 278);
            this.buttonReadXml.Name = "buttonReadXml";
            this.buttonReadXml.Size = new System.Drawing.Size(185, 50);
            this.buttonReadXml.TabIndex = 9;
            this.buttonReadXml.Text = "Read Xml";
            this.buttonReadXml.UseVisualStyleBackColor = true;
            this.buttonReadXml.Click += new System.EventHandler(this.buttonReadXml_Click);
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.AllowDrop = true;
            this.buttonSaveList.Location = new System.Drawing.Point(845, 162);
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Size = new System.Drawing.Size(185, 56);
            this.buttonSaveList.TabIndex = 10;
            this.buttonSaveList.Text = "Save List to .xml";
            this.buttonSaveList.UseVisualStyleBackColor = true;
            this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 679);
            this.Controls.Add(this.buttonSaveList);
            this.Controls.Add(this.buttonReadXml);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.Add);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.IO.Ports.SerialPort serialPort1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonReadXml;
        private System.Windows.Forms.Button buttonSaveList;
    }
}

