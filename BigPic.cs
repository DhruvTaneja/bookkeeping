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
    public partial class BigPic : Form
    {
        public BigPic()
        {
            InitializeComponent();
        }

        private List<String> initParties()
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

        private void initMonths()
        {
            var months = monthCheckList.Items;
            string[] all = {"January", "February", "March", "April",
                           "May", "June", "July", "August",
                           "September", "October", "November", "December"};
            months.AddRange(all);
        }

        private void BigPic_Load(object sender, EventArgs e)
        {
            var partyItems = partyCheckList.Items;
            List<String> parties = initParties();
            foreach (string party in parties)
                partyItems.Add(party);

            var itemItems = itemCheckList.Items;
            List<String> items = initItems();
            foreach (string item in items)
                itemItems.Add(item);

            initMonths();
        }

        private void allParty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < partyCheckList.Items.Count; i++)
                partyCheckList.SetItemChecked(i, true);
            anyCheckChanged();
        }

        private void noneParty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < partyCheckList.Items.Count; i++)
                partyCheckList.SetItemChecked(i, false);
            anyCheckChanged();
        }

        private void allMonth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < monthCheckList.Items.Count; i++)
                monthCheckList.SetItemChecked(i, true);
            anyCheckChanged();
        }

        private void noneMonth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < monthCheckList.Items.Count; i++)
                monthCheckList.SetItemChecked(i, false);
            anyCheckChanged();
        }

        private void allItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < itemCheckList.Items.Count; i++)
                itemCheckList.SetItemChecked(i, true);
            anyCheckChanged();
        }

        private void noneItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < itemCheckList.Items.Count; i++)
                itemCheckList.SetItemChecked(i, false);
            anyCheckChanged();
        }

        private void anyCheckChanged()
        {
            bigDataGrid.Rows.Clear();

            if (!((partyCheckList.CheckedItems.Count == 0) && (monthCheckList.CheckedItems.Count == 0)
                && (itemCheckList.CheckedItems.Count == 0)))
            {
                string year = DateTime.Today.Year.ToString();
                var checkedParties = partyCheckList.CheckedItems;
                var checkedMonths = monthCheckList.CheckedIndices;
                var checkedItems = itemCheckList.CheckedItems;

                string dataRoot = @"parties\";

                if (partyCheckList.CheckedItems.Count != 0)
                {
                    foreach (string party in checkedParties)
                    {
                        string partyRoot = dataRoot + party + "\\" + year;
                        if (Directory.Exists(partyRoot))
                        {
                            if (monthCheckList.CheckedIndices.Count != 0)
                            {
                                foreach (int month in checkedMonths)
                                {
                                    string fileDir = partyRoot + "\\" + (month + 1).ToString();
                                    if (Directory.Exists(fileDir))
                                    {
                                        string[] files = Directory.GetFiles(fileDir);
                                        foreach (string file in files)
                                        {
                                            using (StreamReader sr = File.OpenText(file))
                                            {
                                                string s = "";
                                                string[] array = new string[10];
                                                int l = 0;
                                                while ((s = sr.ReadLine()) != null)
                                                {
                                                    //  creating an array of lines
                                                    array[l++] = s;
                                                }
                                                if (itemCheckList.CheckedItems.Count != 0)
                                                {
                                                    if (checkedItems.IndexOf(array[2]) > -1)
                                                    {
                                                        string[] row = {array[1], 
                                                           array[0], array[2]};
                                                        bigDataGrid.Rows.Add(row);
                                                    }
                                                }
                                                else
                                                {
                                                    string[] row = {array[1], 
                                                           array[0], array[2]};
                                                    bigDataGrid.Rows.Add(row);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                string[] monthDirs = Directory.GetDirectories(partyRoot);
                                foreach (string monthDir in monthDirs)
                                {
                                    string[] files = Directory.GetFiles(monthDir);
                                    foreach (string file in files)
                                    {
                                        using (StreamReader sr = File.OpenText(file))
                                        {
                                            string s = "";
                                            string[] array = new string[10];
                                            int l = 0;
                                            while ((s = sr.ReadLine()) != null)
                                            {
                                                //  creating an array of lines
                                                array[l++] = s;
                                            }
                                            if (itemCheckList.CheckedItems.Count != 0)
                                            {
                                                if (checkedItems.IndexOf(array[2]) > -1)
                                                {
                                                    string[] row = {array[1], 
                                                           array[0], array[2]};
                                                    bigDataGrid.Rows.Add(row);
                                                }
                                            }
                                            else
                                            {
                                                string[] row = {array[1], 
                                                           array[0], array[2]};
                                                bigDataGrid.Rows.Add(row);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    dataRoot = @"parties";
                    string[] parties = Directory.GetDirectories(dataRoot);
                    foreach (string party in parties)
                    {
                        string partyRoot = party + "\\" + year;
                        if (Directory.Exists(partyRoot))
                        {
                            if (monthCheckList.CheckedIndices.Count != 0)
                            {
                                foreach (int month in checkedMonths)
                                {
                                    string fileDir = partyRoot + "\\" + (month + 1).ToString();
                                    if (Directory.Exists(fileDir))
                                    {
                                        string[] files = Directory.GetFiles(fileDir);
                                        foreach (string file in files)
                                        {
                                            using (StreamReader sr = File.OpenText(file))
                                            {
                                                string s = "";
                                                string[] array = new string[10];
                                                int l = 0;
                                                while ((s = sr.ReadLine()) != null)
                                                {
                                                    //  creating an array of lines
                                                    array[l++] = s;
                                                }
                                                if (itemCheckList.CheckedItems.Count != 0)
                                                {
                                                    if (checkedItems.IndexOf(array[2]) > -1)
                                                    {
                                                        string[] row = {array[1], 
                                                           array[0], array[2]};
                                                        bigDataGrid.Rows.Add(row);
                                                    }
                                                }
                                                else
                                                {
                                                    string[] row = {array[1], 
                                                           array[0], array[2]};
                                                    bigDataGrid.Rows.Add(row);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                string[] monthDirs = Directory.GetDirectories(partyRoot);
                                foreach (string monthDir in monthDirs)
                                {
                                    string[] files = Directory.GetFiles(monthDir);
                                    foreach (string file in files)
                                    {
                                        using (StreamReader sr = File.OpenText(file))
                                        {
                                            string s = "";
                                            string[] array = new string[10];
                                            int l = 0;
                                            while ((s = sr.ReadLine()) != null)
                                            {
                                                //  creating an array of lines
                                                array[l++] = s;
                                            }
                                            if (itemCheckList.CheckedItems.Count != 0)
                                            {
                                                if (checkedItems.IndexOf(array[2]) > -1)
                                                {
                                                    string[] row = {array[1], 
                                                           array[0], array[2]};
                                                    bigDataGrid.Rows.Add(row);
                                                }
                                            }
                                            else
                                            {
                                                string[] row = {array[1], 
                                                           array[0], array[2]};
                                                bigDataGrid.Rows.Add(row);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void partyCheckList_Click(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void monthCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void itemCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void monthCheckList_Click(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void itemCheckList_Click(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void partyCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            anyCheckChanged();
        }

        private void partyCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void BigPic_Click(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void BigPic_DoubleClick(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void partyCheckList_DoubleClick(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void monthCheckList_DoubleClick(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void itemCheckList_DoubleClick(object sender, EventArgs e)
        {
            anyCheckChanged();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            int selectedIntdex = bigDataGrid.SelectedCells[0].RowIndex;
            string partyName = bigDataGrid.Rows[selectedIntdex].Cells[0].Value.ToString();
            string date = bigDataGrid.Rows[selectedIntdex].Cells[1].Value.ToString();
            int first = date.IndexOf(' ');
            int last = date.LastIndexOf(' ');
            string day = date.Substring(0, first);
            string month = date.Substring(first + 1, last - first - 1);
            string year = date.Substring(last + 1);
            string filePath = @"parties\";
            filePath += partyName + "\\" + year + "\\"
                + month + "\\" + day + ".ck";
            OpenFileForm openFileForm = new OpenFileForm(filePath);
            openFileForm.ShowDialog();
            anyCheckChanged();
        }
    }
}
