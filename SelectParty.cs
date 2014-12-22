using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Diwas_Taneja
{
    public partial class SelectParty : Form
    {
        public SelectParty()
        {
            InitializeComponent();
            partyList.DataSource = getPartyList();
        }

        public string partyName = "";

        private List<String> getPartyList()
        {
            List<String> partyList = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\ck book keeping\\data\\p.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//parties/party/name");
            foreach (XmlNode partyNode in xmlNodeList)
            {
                string name = partyNode.FirstChild.Value;
                partyList.Add(name);
                partyList.Sort();
            }
            return partyList;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            partyName = "";
            Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string getPartyName()
        {
            return partyName;
        }

        private void partyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = partyList.SelectedIndex;
            partyName = getPartyList().ElementAt(index);
        }
    }
}
