using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Diwas_Taneja
{
    public partial class EditForm : Form
    {

        public string date, day, month, year, item, packets, rate, total, net, received, party;
        public string oldNetValue, newNetValue;

        public EditForm()
        {
            InitializeComponent();
            initWrong();
        }

        private void initOldValues()
        {
            int first = date.IndexOf(' ');
            int last = date.LastIndexOf(' ');
            day = date.Substring(0, first);
            month = date.Substring(first + 1, last - first - 1);
            year = date.Substring(last + 1);

            itemBox.DataSource = initItems();

            dayBox.Text = day;
            monthBox.Text = month;
            yearBox.Text = year;
            itemBox.Text = item;
            packetBox.Text = packets;
            rateBox.Text = rate;
            receivedBox.Text = received;
            valueLabel.Text = total;
            netValue.Text = net;
            oldNetValue = net;
            partyLabel.Text = party;
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

        private bool validateRate(string value)
        {
            if (value == "")
                return true;
            try
            {
                float rate = float.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (FormatException exc)
            {
                return false;
            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("Values too large. Please check them once",
                    "Large Value Error");
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

        private bool validatePacket(string value)
        {
            if (value == "")
                return true;
            try
            {
                float packet = float.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (FormatException exc)
            {
                return false;
            }
        }

        private bool noneEmpty()
        {
            if ((dayBox.Text == "") || (monthBox.Text == "") || (yearBox.Text == "")
                || (itemBox.Text == "") || (packetBox.Text == "") || (rateBox.Text == ""))
                return false;
            else
                return true;
        }

        private void EditForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (validateDate(dayBox.Text) && validateDate(monthBox.Text) && validateDate(yearBox.Text))
                wrong1.Visible = false;
            else
                wrong1.Visible = true;

            if (validateDate(dayBox.Text, 1, 31) && validateDate(monthBox.Text, 1, 12))
                wrong1.Visible = false;
            else
                wrong1.Visible = true;

            if (validateRate(rateBox.Text))
                wrong4.Visible = false;
            else
                wrong4.Visible = true;

            if (validatePacket(packetBox.Text))
                wrong3.Visible = false;
            else
                wrong3.Visible = true;

            if (validateDate(dayBox.Text) && validateDate(monthBox.Text) && validateDate(yearBox.Text)
                && validatePacket(packetBox.Text) && validateRate(rateBox.Text) && noneEmpty())
                saveButton.Enabled = true;
            else
                saveButton.Enabled = false;
        }

        private void initWrong()
        {
            wrong1.Visible = false;
            wrong3.Visible = false;
            wrong4.Visible = false;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            initOldValues();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmSave = MessageBox.Show("Are you sure you want to save it this way?",
                "Confirm Edit", MessageBoxButtons.YesNoCancel);
            if (confirmSave == DialogResult.Yes)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(@"data\p.xml");
                    XmlNodeList parties = xmlDoc.SelectNodes("//parties/party");
                    foreach (XmlNode party in parties)
                    {
                        if (party.FirstChild.InnerText.Equals(partyLabel.Text))
                        {
                            int oldNet = int.Parse(oldNetValue,
                                    System.Globalization.CultureInfo.InvariantCulture);
                            int newNet = int.Parse(netValue.Text,
                                    System.Globalization.CultureInfo.InvariantCulture);
                            party.LastChild.InnerText = (int.Parse(party.LastChild.InnerText)
                            + newNet - oldNet).ToString();
                            break;
                        }
                        xmlDoc.Save(@"data\p.xml");
                    }

                    //  add the data to a file now
                    string partyName = partyLabel.Text;
                    string date = dayBox.Text;
                    string yearFolder = yearBox.Text;
                    string monthFolder = monthBox.Text;
                    string root = @"parties\";
                    string path = root + partyName + '\\' + yearFolder + '\\' + monthFolder;
                    Directory.CreateDirectory(path);

                    //  creating the file
                    string fileName = path + '\\' + date + ".ck";
                    string data = date + ' ' + monthFolder + ' ' + yearFolder + Environment.NewLine;
                    data += partyName + Environment.NewLine;
                    data += itemBox.Text + Environment.NewLine;
                    data += packetBox.Text + Environment.NewLine;
                    data += rateBox.Text + Environment.NewLine;
                    data += valueLabel.Text + Environment.NewLine;
                    data += receivedBox.Text + Environment.NewLine;
                    data += netValue.Text;
                    using (FileStream fs = File.Create(fileName))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(data);
                        fs.Write(info, 0, info.Length);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Updation error. Try again. Also check if the values are too big.");
                }
                Close();
            }
        }

        private void rateBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                float rate = float.Parse(rateBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int packets = int.Parse(packetBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int recieved = int.Parse(receivedBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (rateBox.Text == "")
                    rate = 0;
                float total = rate * packets;
                float net = total - recieved;
                valueLabel.Text = total.ToString();
                netValue.Text = net.ToString();
            }
            catch (FormatException exception)
            {

            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("Values too large. Please check them once",
                    "Large Value Error");
                rateBox.Text = "";
            }
        }

        private void packetBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                float rate = float.Parse(rateBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int packets = int.Parse(packetBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int recieved = int.Parse(receivedBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (rateBox.Text == "")
                    rate = 0;
                float total = rate * packets;
                float net = total - recieved;
                valueLabel.Text = total.ToString();
                netValue.Text = net.ToString();
            }
            catch (FormatException exception)
            {

            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("Values too large. Please check them once",
                    "Large Value Error");
                rateBox.Text = "";
            }
        }

    }
}
