using FlashCardsApp.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FlashCardsApp
{

    public partial class TheHome : Form
    {
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();
        public TheHome()
        {
            InitializeComponent();
        }
        //adding data(word set) to window
        private void TheHome_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            dataSet.ReadXml(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\theHomeCollection.xml");
            dataGridViewTable.DataSource = dataSet.Tables[0];
            
            ////exporting DataGridViewTabke to xml file
            //var dataTable = GetDataTable(dataGridViewTable);
            //DataSet data = new DataSet();
            //data.Tables.Add(dataTable);
            //data.WriteXml(File.Create(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\theHomeCollection.xml"));


            //string[] lines = File.ReadAllLines(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\TheHomeCollection.txt");
            //string[] values;

            //char[] delimeter = { ',' };
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    values = lines[i].ToString().Split(delimeter, 2);
            //    string[] row = new string[values.Length];

            //    for (int j = 0; j < values.Length; j++)
            //    {
            //        row[j] = values[j];
            //    }
            //    table.Rows.Add(row);
            //}
            Settings.Default.Save();
        }
        private void CloseAppEvent(object sender, FormClosingEventArgs e)
        {
            // saving window location to app settings
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Location = Settings.Default.WindowLocation;
            }
            else
            {
                Settings.Default.WindowLocation = this.Location;
            }

            Settings.Default.Save();
            Application.Exit();
        }

        private void LoadAppEnglish(object sender, EventArgs e)
        {
            new EnglishPolishScreen
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(Location.X, Location.Y),
                Height = this.Height,
                Width = this.Width
            }.Show();

        }

        private void LoadAppPolish(object sender, EventArgs e)
        {
            new PolishEnglishScreen()
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y),
            }.Show();

        }
        private DataTable GetDataTable(DataGridView dataGridView)
        {
            var dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible)
                {
                    dataTable.Columns.Add();
                }
            }
            object[] Values = new object[dataGridView.Columns.Count];
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    Values[i] = row.Cells[i].Value;
                }
                dataTable.Rows.Add(Values);
            }

            return dataTable;
        }

      
    }
}
