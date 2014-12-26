using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diwas_Taneja
{
    public partial class FindResult : Form
    {

        public string partyValue = "";
        public string itemValue = "";
        public string dayValue = "";
        public string monthValue = "";
        public string yearValue = "";

        private string path = @"parties\";

        public FindResult(string party, string day, string month,
            string year, string item)
        {
            InitializeComponent();
            partyValue = party;
            itemValue = item;
            dayValue = day;
            monthValue = month;
            yearValue = year;
            initGrid();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initGrid()
        {
            //  if the user did not give any party name
            //  search all the folders for other given fields
            if (partyValue == "")
            {
                if (dayValue == "") //  means only item is provided
                {
                    string[] parties = Directory.GetDirectories(path);
                    foreach (string party in parties)
                    {
                        string[] years = Directory.GetDirectories(party);
                        foreach (string year in years)
                        {
                            string[] months = Directory.GetDirectories(year);
                            foreach (string month in months)
                            {
                                string[] files = Directory.GetFiles(month);
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
                                        if (itemValue.Equals(array[2]))
                                        {
                                            string[] row = {array[1], 
                                                           array[0], array[2]};
                                            resultGrid.Rows.Add(row);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else    //  date is provided
                {
                    string[] parties = Directory.GetDirectories(path);
                    foreach (string party in parties)
                    {
                        string file = party + "\\" + yearValue
                            + "\\" + monthValue + "\\" + dayValue + ".ck";
                        if (File.Exists(file))
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
                                string[] row = { array[1], array[0], array[2] };
                                if (itemValue == "")
                                    resultGrid.Rows.Add(row);
                                else if (itemValue.Equals(array[2]))
                                {
                                    resultGrid.Rows.Add(row);
                                }
                            }
                        }
                    }
                }
            }
            else    //  else go the folder of that party only
            {
                path += partyValue;
                if(Directory.Exists(path))
                {
                    //  if the date is not provided
                    //  return data from all the files
                    if (dayValue == "")
                    {
                        if (itemValue == "")    //  and the itemvalue is also not provided
                        {
                            String[] subDirs = Directory.GetDirectories(path);
                            for (int i = 0; i < subDirs.Length; i++)
                            {
                                String[] subSubDirs = Directory.GetDirectories(
                                    subDirs[i]);
                                for (int j = 0; j < subSubDirs.Length; j++)
                                {
                                    String[] files = Directory.GetFiles(
                                        subSubDirs[j]);
                                    for (int k = 0; k < files.Length; k++)
                                    {
                                        using (StreamReader sr = File.OpenText(files[k]))
                                        {
                                            string s = "";
                                            string[] array = new string[10];
                                            int l = 0;
                                            while ((s = sr.ReadLine()) != null)
                                            {
                                                //  creating an array of lines
                                                array[l++] = s;
                                            }
                                            string[] row = {array[1], 
                                                           array[0], array[2]};
                                            resultGrid.Rows.Add(row);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            String[] subDirs = Directory.GetDirectories(path);
                            for (int i = 0; i < subDirs.Length; i++)
                            {
                                String[] subSubDirs = Directory.GetDirectories(
                                    subDirs[i]);
                                for (int j = 0; j < subSubDirs.Length; j++)
                                {
                                    String[] files = Directory.GetFiles(
                                        subSubDirs[j]);
                                    for (int k = 0; k < files.Length; k++)
                                    {
                                        using (StreamReader sr = File.OpenText(files[k]))
                                        {
                                            string s = "";
                                            string[] array = new string[10];
                                            int l = 0;
                                            while ((s = sr.ReadLine()) != null)
                                            {
                                                //  creating an array of lines
                                                array[l++] = s;
                                            }
                                            if (itemValue.Equals(array[2]))
                                            {
                                                string[] row = {array[1], 
                                                           array[0], array[2]};
                                                resultGrid.Rows.Add(row);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else    //  the date was providied
                    {
                        try
                        {
                            path += "\\" + yearValue +
                                 "\\" + monthValue +
                                 "\\" + dayValue + ".ck";  //  looks like just one file
                            using (StreamReader sr = File.OpenText(path))
                            {
                                string s = "";
                                string[] array = new string[10];
                                int l = 0;
                                while ((s = sr.ReadLine()) != null)
                                {
                                    //  creating an array of lines
                                    array[l++] = s;
                                }
                                string[] row = { array[1], array[0], array[2] };
                                resultGrid.Rows.Add(row);
                            }
                        }
                        catch (DirectoryNotFoundException ex)
                        {
                            MessageBox.Show("The data for this request has not been made yet");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No record has been created for this party.");
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (resultGrid.Rows.Count != 1)
            {
                var cells = resultGrid.SelectedCells;
                int row = cells[0].RowIndex;
                string partySelected = resultGrid.Rows[row].Cells[0].Value.ToString();
                string date = resultGrid.Rows[row].Cells[1].Value.ToString();
                int first = date.IndexOf(' ');
                int last = date.LastIndexOf(' ');
                string day = date.Substring(0, first);
                string month = date.Substring(first + 1, last - first - 1);
                string year = date.Substring(last + 1);
                string filePath = @"parties\";
                filePath += partySelected + "\\" + year + "\\" + month + "\\" + day + ".ck";
                OpenFileForm openFileForm = new OpenFileForm(filePath);
                openFileForm.ShowDialog();
            }
        }
    }
}
