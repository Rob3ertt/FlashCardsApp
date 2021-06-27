using FlashCardsApp.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace FlashCardsApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\Resources\Avatar\";
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            //setting window langugage
            if (Settings.Default.TranslationType == "ENG")
            {
                EnglishTranslation("ENG");
            }
            else
            {
                PolishTranslation("PL");
            }

            //setting account
            if (String.IsNullOrWhiteSpace(Settings.Default.AccountName))
            {
                accountNameLabel.Text = "Default";
            }
            else
            {
                accountNameLabel.Text = Settings.Default.AccountName;

                //setting avatar
                var fileName = Settings.Default.AccountName + ".png";
                if (File.Exists(Path.Combine(filePath,fileName)))
                {
                    pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\Resources\Avatar\" + accountNameLabel.Text + ".png");
                }
              

            }

            Settings.Default.Save();

        }
        private void LoadApp(object sender, EventArgs e)
        {
            //setting position
            EnglishPolishScreen appScreenPageOne = new EnglishPolishScreen
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };

            WordSetsScreen wordSetsScreen = new WordSetsScreen
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };
            //hiding the main menu
            this.Hide();

            //displaying a window
            wordSetsScreen.Show();
        }

        private void LoadWordSets(object sender, EventArgs e)
        {
            WordSetsScreen wordSetsScreen = new WordSetsScreen
            {

                //setting position
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };

            //hiding the main menu
            this.Hide();

            //displaying a window
            wordSetsScreen.Show();
        }

        private void LoadAccount(object sender, EventArgs e)
        {
            AccountScreen loadAccount = new AccountScreen
            {

                //setting position
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };

            //hiding the main menu
            this.Hide();

            //displaying a window
            loadAccount.Show();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen
            {

                //setting same height and width of new window
                Height = this.Height,
                Width = this.Width,

                //setting position
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X, this.Location.Y)
            };

            //hiding the main menu
            this.Hide();

            //displaying a window
            helpScreen.Show();
        }

        private void Quit(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Application.Exit();
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
        private void LanguageChanger(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string languageType = pictureBox.Name;

            switch (languageType)
            {
                case "ENG":
                    EnglishTranslation(languageType);
                    //saving last used language to app setting 
                    Settings.Default.TranslationType = "ENG";
                    break;
                case "PL":
                    PolishTranslation(languageType);
                    //saving last used language to app setting 
                    Settings.Default.TranslationType = "PL";
                    break;
                default:
                    break;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen
            {
                Location = new Point(this.Location.X, this.Location.Y)
            };
            logInScreen.Show();
            this.Hide();
        }

        //methods to translate application
        private void PolishTranslation(string languageType)
        {
            if (languageType == null || languageType == " ")
            {
                throw new ArgumentNullException("No type of language.");
            }
            buttonStart.Text = "Rozpocznij";
            buttonWordSets.Text = "Zestawy Słów";
            buttonAccount.Text = "Konto";
            buttonHelp.Text = "Pomoc";
            buttonQuit.Text = "Wyjście";
        }
        private void EnglishTranslation(string languageType)
        {
            if (languageType == null || languageType == " ")
            {
                throw new ArgumentNullException("No type of language.");
            }
            buttonStart.Text = "Start";

            buttonWordSets.Text = "Word Sets";
            buttonAccount.Text = "Account";
            buttonHelp.Text = "Help";
            buttonQuit.Text = "Quit";
        }
    }
}
