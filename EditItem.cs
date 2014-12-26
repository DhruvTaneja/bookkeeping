using System;
using System.Windows.Forms;
using System.Xml;

namespace Diwas_Taneja
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
            initGrid();
        }

        private void initGrid()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\i.xml");
            XmlNode rootNode = xmlDoc.DocumentElement;
            XmlNodeList itemList = rootNode.ChildNodes;
            foreach (XmlNode item in itemList)
            {
                string name = item.InnerText;
                String[] row = new string[] { name };
                itemGrid.Rows.Add(row);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data\\i.xml");
            XmlNode rootNode = xmlDoc.DocumentElement;
            XmlNodeList itemList = rootNode.ChildNodes;
            if (e.RowIndex != -1)
            {
                itemList[e.RowIndex].InnerText = itemGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                xmlDoc.Save("data\\i.xml");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteIndex = itemGrid.CurrentCell.RowIndex;
                if (deleteIndex > -1)
                {
                    DialogResult confirmDelete =
                        MessageBox.Show("Are you sure you want to delete this item?",
                        "Confirm Delete", MessageBoxButtons.YesNoCancel);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        itemGrid.Rows.RemoveAt(deleteIndex);
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load("data\\i.xml");
                        XmlNode rootNode = xmlDoc.DocumentElement;
                        XmlNodeList itemList = rootNode.ChildNodes;
                        rootNode.RemoveChild(itemList[deleteIndex]);
                        xmlDoc.Save("data\\i.xml");
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
