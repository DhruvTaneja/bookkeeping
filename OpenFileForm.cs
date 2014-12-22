using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diwas_Taneja
{
    public partial class OpenFileForm : Form
    {

        public string filePath = "";

        public OpenFileForm(string file)
        {
            InitializeComponent();
            closeButton.Visible = false;
            filePath = file;
            initLabels();
        }

        private void initLabels()
        {
            //  get the file and manipulate content
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                string[] array = new string[10];
                int i = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    //  creating an array of 
                    array[i++] = s;
                }
                i = 0;
                valueDate.Text = array[0];
                valueParty.Text = array[1];
                valueItem.Text = array[2];
                valuePacket.Text = array[3];
                valueRate.Text = array[4];
                valueTotal.Text = array[5];
                valueReceived.Text = array[6];
                valueNet.Text = array[7];
                this.Text = valueParty.Text + " - " + valueDate.Text;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setFilePath(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
