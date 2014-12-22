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
            xmlDoc.Load("C:\\ck book keeping\\data\\i.xml");
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
            xmlDoc.Load("C:\\ck book keeping\\data\\i.xml");
            XmlNode rootNode = xmlDoc.DocumentElement;
            XmlNodeList itemList = rootNode.ChildNodes;
            if (e.RowIndex != -1)
            {
                itemList[e.RowIndex].InnerText = itemGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                xmlDoc.Save("C:\\ck book keeping\\data\\i.xml");
            }
        }
    }
}
