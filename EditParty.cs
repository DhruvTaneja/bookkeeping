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
    public partial class EditParty : Form
    {
        public EditParty()
        {
            InitializeComponent();
            initGrid();
        }

        private void initGrid()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\p.xml");
            XmlNode rootNode = xmlDoc.DocumentElement;
            XmlNodeList partyList = rootNode.ChildNodes;
            foreach (XmlNode party in partyList)
            {
                string name = party.FirstChild.InnerText;
                string balance = party.LastChild.InnerText;
                String[] row = new string[] { name, balance };
                partyGrid.Rows.Add(row);
            }
        }

        private void partyGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\p.xml");
            XmlNode rootNode = xmlDoc.DocumentElement;
            XmlNodeList partyList = rootNode.ChildNodes;

            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    changeDirectory(partyList[e.RowIndex].FirstChild.InnerText,
                        partyGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    partyList[e.RowIndex].FirstChild.InnerText =
                        partyGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                else if (e.ColumnIndex == 1)
                {
                    partyList[e.RowIndex].LastChild.InnerText =
                        partyGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                xmlDoc.Save("data\\p.xml");
            }
        }

        private void changeDirectory(string oldName, string newName)
        {
            string oldPath = @"parties\" + oldName;
            string newPath = @"parties\" + newName;
            System.IO.Directory.Move(oldPath, newPath);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteIndex = partyGrid.CurrentCell.RowIndex;
                if (deleteIndex > -1)
                {
                    DialogResult confirmDelete =
                        MessageBox.Show("Are you sure you want to delete this item?",
                        "Confirm Delete", MessageBoxButtons.YesNoCancel);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        //  removing folder if exists
                        string partyName = partyGrid.Rows[deleteIndex].Cells[0].Value.ToString();
                        if(Directory.Exists("parties\\" + partyName))
                            Directory.Delete("parties\\" + partyName);

                        //  removing from grid
                        partyGrid.Rows.RemoveAt(deleteIndex);

                        //  removing from xml document
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load("data\\p.xml");
                        XmlNode rootNode = xmlDoc.DocumentElement;
                        XmlNodeList itemList = rootNode.ChildNodes;
                        rootNode.RemoveChild(itemList[deleteIndex]);
                        xmlDoc.Save("data\\p.xml");
                    }

                }
                else
                {
                    MessageBox.Show("Selece at least one item",
                        "Invalid Selection");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time",
                    "Deletion Error");
            }
        }
    }
}
