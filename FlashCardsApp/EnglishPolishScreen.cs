using FlashCardsApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FlashCardsApp
{
    public partial class EnglishPolishScreen : Form
    {

        List<TheHomeCollection> ListOfWords = new List<TheHomeCollection>();

        private int index = 0;
        private int elements;
        private int chances = 0;

        Thread threadOne;
        Thread threadTwo;

        public EnglishPolishScreen()
        {
            InitializeComponent();
        }
        private void EnglishPolishScreen_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }
            threadTwo = new Thread(ReadFromTxtFile);
            threadTwo.Start();

            Settings.Default.Save();
            englishWord.Text = ListOfWords[index].FirstLanguage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            threadOne = new Thread(Display);
            threadOne.Start();
        }

        //display elements of TheHomeCollection object in Label and compering it to  answer
        private void Display()
        {
            if (answerBox.Text.Contains(ListOfWords[index].SecondLanguage))
            {
                englishWord.Text = ListOfWords[++index].FirstLanguage;
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = "Good Answer!";
                answerBox.Text = "";
                tipLabel.Text = "";
                chances = 0;
            }
            else
            {
                chances++;
                resultLabel.ForeColor = Color.Yellow;
                resultLabel.Text = "Bad Answer.\n Try again!";
                if(chances==3)
                {
                    tipLabel.Text = ListOfWords[index].SecondLanguage;
                    chances = 0;
                }
            }
            if (index == elements)
            {
                index = 0;
            }
        }

        // reading data from txt file in to List of TheHomeCollection objects
        private void ReadFromTxtFile()
        {
            try
            {
                string[] allText = File.ReadAllLines(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\wordTxt\TheHomeCollection.txt");
                char[] delimeter = { ',' };

                foreach (var element in allText)
                {
                    string[] temporary = element.Split(delimeter, 2);
                    TheHomeCollection theHomeCollection = new TheHomeCollection { FirstLanguage = temporary[0], SecondLanguage = temporary[1] };
                    ListOfWords.Add(theHomeCollection);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Could not open or finde file!");
            }
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
            //    if (element == words.Count())
            //        element = 0;
            //    else
            //        englishWord.Text = words[++element];

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

        private void showWordButton_Click(object sender, EventArgs e)
        {
            tipLabel.Text = ListOfWords[index].SecondLanguage;
        }
    }

}


