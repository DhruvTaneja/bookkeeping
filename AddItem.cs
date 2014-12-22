using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Diwas_Taneja
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (nameLabel.Text == "")
                return false;
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("C:\\ck book keeping\\data\\i.xml");
                XmlNode rootNode = xmlDoc.DocumentElement;
                XmlNodeList itemList = rootNode.ChildNodes;
                XmlElement newItem = xmlDoc.CreateElement("item");
                newItem.InnerText = nameBox.Text;
                rootNode.InsertAfter(newItem, rootNode.LastChild);
                xmlDoc.Save("C:\\ck book keeping\\data\\i.xml");
                Close();
            }
            else
                MessageBox.Show("Please verify the data you have entered");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
