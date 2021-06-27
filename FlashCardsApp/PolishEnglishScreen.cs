using FlashCardsApp.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FlashCardsApp
{
    public partial class PolishEnglishScreen : Form
    {
        private List<TheHomeCollection> ListOfWords = new List<TheHomeCollection>();

        private int elements;
        private int index = 0;

        Thread threadOne;
        Thread threadTwo;

        public PolishEnglishScreen()
        {
            InitializeComponent();
        }

        private void PolishEnglishScreen_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            threadTwo = new Thread(ReadFromTxtFile);
            threadTwo.Start();

            elements = ListOfWords.Count();
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadOne = new Thread(Display);
            threadOne.Start();
        }

        //display elements of TheHomeCollection object in Label
        private void Display()
        {
            polishWord.Text = ListOfWords[index++].SecondLanguage;



            //if (answerBox.Text.Equals(words[element]))
            //{
            //    polishWord.Text = wordB[++element];
            //    resultLabel.ForeColor = Color.Green;
            //    resultLabel.Text = "Good answer!";
            //    answerBox.Text = "";
            //}
            //else
            //{
            //    resultLabel.ForeColor = Color.Crimson;
            //    resultLabel.Text = "Bad answer. \n Try again!";
            //}
        }

        private void answerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            //polishWord.Text = wordB[++element];
            //polishWord.Text = words[++element];
            //if (element == wordB.Count())
            //    element = 0;
        }
        private void PolishEnglishScreen_FormClosing(object sender, FormClosingEventArgs e)
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

        // reading data from txt file in to List of TheHomeCollection objects
        private void ReadFromTxtFile()
        {
            try
            {
                string[] textFromFile = File.ReadAllLines(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\TheHomeCollection.txt");
                char[] delimeter = { ',' };

                foreach (var element in textFromFile)
                {
                    string[] temporary = element.Split(delimeter, 2);
                    var theHomeCollection = new TheHomeCollection { FirstLanguage = temporary[0], SecondLanguage = temporary[1] };
                    ListOfWords.Add(theHomeCollection);
                }
                polishWord.Text = ListOfWords[index].SecondLanguage;
                index++;
            }
            catch (Exception ex)
            {

                MessageBox.Show("{0} Could not open or finde file!", ex.ToString());
            }
        }
    }
}

