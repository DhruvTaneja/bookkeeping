using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Diwas_Taneja
{
    public partial class Main : Form
    {

        public bool itemValidate = false;
        public bool packetValidate = false;
        public bool rateValidate = false;

        public string partyName = "";

        public Main()
        {
            InitializeComponent();
            createNewPanel.Visible = false;
            initWrong();
            initDate();
            itemBox.DataSource = initItems();
        }

        /*
         * Function to hide wrong input messages
        */
        private void initWrong()
        {
            wrong1.Visible = false;
            wrong3.Visible = false;
            wrong4.Visible = false;
        }

        /*
         * Function to initialize the values of the date fields with today's date
        */
        private void initDate()
        {
            DateTime date = DateTime.Now.Date;
            dayBox.Text = date.Day.ToString();
            monthBox.Text = date.Month.ToString();
            yearBox.Text = date.Year.ToString();
        }

        /*
         * Function to initialize the items list
        */
        private List<String> initItems()
        {
            List<String> itemList = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\ck book keeping\\data\\i.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//items/item");
            foreach (XmlNode partyNode in xmlNodeList)
            {
                string name = partyNode.FirstChild.Value;
                itemList.Add(name);
                itemList.Sort();
            }
            return itemList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectParty partyForm = new SelectParty();
            partyForm.ShowDialog(this);
            if (!(partyForm.getPartyName() == ""))
            {
                partyName = partyForm.getPartyName();
                partyLabel.Text = partyName;
                createNewPanel.Visible = true;
                dayBox.Focus();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (packetBox.Text == "")
            {
            }
            else
                packetValidate = true;
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

        private bool noneEmpty()
        {
            if ((dayBox.Text == "") || (monthBox.Text == "") || (yearBox.Text == "")
                || (itemBox.Text == "") || (packetBox.Text == "") || (rateBox.Text == ""))
                return false;
            else
                return true;
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
                submitButton.Enabled = true;
            else
                submitButton.Enabled = false;
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddParty addParty = new AddParty();
            addParty.Show();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItem editItem = new EditItem();
            editItem.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditParty editParty = new EditParty();
            editParty.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*
             * Setting up of login form and opening on validating 
             */
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            if (login.getSuccess())
                this.Show();
            else
                this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm?", "Confirmation Box", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                //  add the data to a file now
                //  check everything first
                //  and change folder names if party names are edited
                string partyName = partyLabel.Text;
                string date = dayBox.Text;
                string yearFolder = yearBox.Text;
                string monthFolder = monthBox.Text;
                string root = @"C:\ck book keeping\parties\";
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

                //  hiding the panel and bringing up the main
                //  and clearing up the fields
                createNewPanel.Visible = false;
                clearBoxes();
                newEntry.Focus();
            }
        }

        private void receivedBox_KeyUp(object sender, KeyEventArgs e)
        {
            int received;
            if (receivedBox.Text.Equals(""))
                receivedBox.Text = "0";
            try
            {
                float rate = float.Parse(rateBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                int packets = int.Parse(packetBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                received = int.Parse(receivedBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                float total = rate * packets;
                float net = total - received;
                netValue.Text = net.ToString();
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.ToString());
            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("Values too large. Please check them once",
                    "Large Value Error");
            }
        }

        private void clearBoxes()
        {
            initDate();
            itemBox.Text = "";
            packetBox.Text = "";
            rateBox.Text = "";
            valueLabel.Text = "#";
            netValue.Text = "#";
        }

        private void readLines(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                    MessageBox.Show(s, "Line Reader");
            }
        }

        private void openRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult openDialogResult = openFileDialog.ShowDialog();
            openFileDialog.InitialDirectory = @"C:\ck book keeping\parties";
            if (openDialogResult == DialogResult.OK)
            {
                OpenFileForm openFileForm = new OpenFileForm(openFileDialog.FileName);
                openFileForm.ShowDialog();
            }
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
