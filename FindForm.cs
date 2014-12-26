using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Diwas_Taneja
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
            initData();
        }

        private List<String> initItems()
        {
            List<String> itemList = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\i.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//items/item");
            foreach (XmlNode partyNode in xmlNodeList)
            {
                string name = partyNode.FirstChild.Value;
                itemList.Add(name);
                itemList.Sort();
            }
            return itemList;
        }

        private List<String> getPartyList()
        {
            List<String> partyList = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\p.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//parties/party/name");
            foreach (XmlNode partyNode in xmlNodeList)
            {
                string name = partyNode.FirstChild.Value;
                partyList.Add(name);
                partyList.Sort();
            }
            return partyList;
        }

        private void initData()
        {
            wrong1.Visible = false;
            itemList.DataSource = initItems();
            partyList.DataSource = getPartyList();
            partyList.ResetText();
            itemList.ResetText();
            dayBox.Text = "";
            monthBox.Text = "";
            yearBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            partyList.ResetText();
            itemList.ResetText();
            dayBox.Text = "";
            monthBox.Text = "";
            yearBox.Text = "";
            partyList.Focus();
        }

        private bool validateDate(string value, int min, int max)
        {
            if (value == "")
                return true;
            try
            {
                float date = float.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                if (date < min || date > max)
                    return false;
                else
                    return true;
            }
            catch (FormatException exc)
            {
                return false;
            }
        }

        private bool validateDate(string value)
        {
            if (value == "")
                return true;
            try
            {
                float date = float.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (FormatException exc)
            {
                return false;
            }
        }

        private bool noDate()
        {
            if (dayBox.Text == "" && monthBox.Text == ""
                && yearBox.Text == "")
                return true;
            else
                return false;
        }

        private bool incompleteDate()
        {
            return (dayBox.Text == "" || monthBox.Text == ""
                || yearBox.Text == "");
        }

        private void FindForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (partyList.Text == "" && itemList.Text == "" && noDate())
            {
                findButton.Enabled = false;
            }
            else
            {
                if (!noDate())
                {
                    if (validateDate(dayBox.Text, 1, 31) && validateDate(monthBox.Text, 1, 12)
                        && validateDate(yearBox.Text))
                    {
                        wrong1.Visible = false;
                        findButton.Enabled = true;
                    }
                    else
                    {
                        wrong1.Visible = true;
                        findButton.Enabled = false;
                    }
                }
                else
                {
                    wrong1.Visible = false;
                    findButton.Enabled = true;
                }
            }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if(allEmpty())
                MessageBox.Show("Invalid Entries!");
            else if (!noDate() && incompleteDate())
            {
                MessageBox.Show("Invalid Date!");
            }
            else
            {
                FindResult findResult = new FindResult(partyList.Text,
                    dayBox.Text, monthBox.Text, yearBox.Text, itemList.Text);
                findResult.ShowDialog();
            }
        }

        private bool allEmpty()
        {
            if (partyList.Text == "" && noDate() && itemList.Text == "")
                return true;
            else
                return false;
        }
    }
}
