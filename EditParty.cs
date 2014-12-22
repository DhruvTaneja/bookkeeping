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
            xmlDoc.Load("C:\\ck book keeping\\data\\p.xml");
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
            xmlDoc.Load("C:\\ck book keeping\\data\\p.xml");
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
                xmlDoc.Save("C:\\ck book keeping\\data\\p.xml");
            }
        }

        private void changeDirectory(string oldName, string newName)
        {
            string oldPath = @"C:\ck book keeping\parties\" + oldName;
            string newPath = @"C:\ck book keeping\parties\" + newName;
            System.IO.Directory.Move(oldPath, newPath);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
