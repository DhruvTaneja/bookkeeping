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
    public partial class AddParty : Form
    {
        public AddParty()
        {
            InitializeComponent();
            balanceBox.Text = "0";
        }

        private bool validateData()
        {
            if(nameBox.Text == "" || balanceBox.Text == "")
                return false;
            try
            {
                int balance = int.Parse(balanceBox.Text);
            }
            catch (FormatException e)
            {
                return false;
            }
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("C:\\ck book keeping\\data\\p.xml");
                XmlNode rootNode = xmlDoc.DocumentElement;
                XmlNodeList partyList = rootNode.ChildNodes;
                XmlElement newParty = xmlDoc.CreateElement("party");
                XmlElement name = xmlDoc.CreateElement("name");
                name.InnerText = nameBox.Text;
                XmlElement balance = xmlDoc.CreateElement("balance");
                balance.InnerText = balanceBox.Text;
                newParty.AppendChild(name);
                newParty.AppendChild(balance);
                xmlDoc.DocumentElement.InsertAfter(newParty, xmlDoc.DocumentElement.LastChild);
                xmlDoc.Save("C:\\ck book keeping\\data\\p.xml");
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
