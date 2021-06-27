using FlashCardsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlashCardsApp
{
    public partial class WordSetsScreen : Form
    {
        XmlSerializer theHomeCollection = new XmlSerializer(typeof(List<TheHomeCollection>));
        List<TheHomeCollection> list = new List<TheHomeCollection>();

        Thread threadOne;

        public WordSetsScreen()
        {
            InitializeComponent();
        }
        private void WordSetsScreen_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            { 
                this.Location = Settings.Default.WindowLocation;
            }

            threadOne = new Thread(AddCollection);
            threadOne.Start();

            Settings.Default.Save();
        }

        // loading TheHome collection 
        private void LoadApp(object sender, EventArgs e)
        {
            TheHome theHome = new TheHome
            {

                //setting same posittion of new window
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };

            // hiding current window and opening new one
            this.Hide();
            theHome.Show();
        }

        private void CloseAppEvent(object sender, FormClosingEventArgs e)
        {
            //saving window location to app settings
            if(this.WindowState == FormWindowState.Minimized)
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


        //adding new colletion to Word Sets Window
        private void importCollection(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Label title = new Label()
            {
                Font = new Font("Microsoft Tai Le", 12),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkBlue,
                Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y),
            };
            
            pictureBox1.Hide();
            this.Controls.Add(title);

        }
        private void importCollectionFromFile(PictureBox pictureBox,string wordSetTitle)
        {
            Label title = new Label()
            {
                Location = new Point(pictureBox.Location.X, pictureBox.Location.Y),
                Text = wordSetTitle
            };
            

        }
        //converting txt file to xml
        private void AddCollection()
        {
            
                string[] wordTxt = File.ReadAllLines(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\TheHomeCollection.txt");
                char[] delimeter = { ',' };
                foreach (var word in wordTxt)
                {
                    string[] temp = word.Split(delimeter, 2);
                    var theHome = new TheHomeCollection { FirstLanguage = temp[0], SecondLanguage = temp[1] };
                    list.Add(theHome);
                }
                FileStream fileStream = new FileStream(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\theHomeCollection.xml", FileMode.Create);
                theHomeCollection.Serialize(fileStream, list);
                fileStream.Close();
                fileStream.Dispose();
            
        }

    }
}
