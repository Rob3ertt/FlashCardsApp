using FlashCardsApp.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FlashCardsApp
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }
        private void LogInScreen_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }


            //setting  account 
            if (string.IsNullOrEmpty(accountListsBox.Text))
            {
                Settings.Default.AccountName = "Default";

            }
            else
            {
                accountListsBox.Text = Settings.Default.AccountName;

            }
            Display();
            Settings.Default.Save();
        }
        private void LogInScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
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
        //adding new account
        private void creatButton_Click(object sender, EventArgs e)
        {

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\bin\Debug\AccountList.txt", true);
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("You need to add account name!");
            }
            else
            {
                streamWriter.WriteLine(nameBox.Text);
                accountListsBox.Items.Add(nameBox.Text);
                nameBox.Text = "";
            }
            streamWriter.Close();
            streamWriter.Dispose();
        }
        //adding new account by pressing enter
        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.creatButton_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //logging by useing mouse (double click)
        private void accountListsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.loginButton_Click(this, new EventArgs());
        }
        //setting avatar of an account
        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Setting profile picture";
            openFileDialog.InitialDirectory = @"C:\Users\robka\Documents\VS2017\FlashCardsApp\Avatar";
            openFileDialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(openFileDialog.FileName);
                try
                {
                    string fileName = accountListsBox.SelectedItem.ToString();
                    string appPath = @"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\Resources\Avatar\";
                    pictureBox1.BackgroundImage.Save(appPath + fileName + ".png", ImageFormat.Png);
                }
                catch (Exception)
                {
                    MessageBox.Show("The image have not been saved!");
                }
            }

        }
        //logging account 
        private void loginButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Location = new Point(this.Location.X, this.Location.Y);

            if (String.IsNullOrWhiteSpace(accountListsBox.Text.ToString()))
            {
                MessageBox.Show("You need to add new account.");
            }
            else
            {
                Settings.Default.AccountName = accountListsBox.Text;
                this.Hide();
                mainMenu.Show();
            }
            Settings.Default.Save();
        }
        //deleting account
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string tempFile = Path.GetTempFileName();


            StreamReader streamReader = new StreamReader(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\bin\Debug\AccountList.txt");
            StreamWriter streamWriter = new StreamWriter(tempFile);

            //deleting profile picture 
            try
            {
                var appPath = @"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\Resources\Avatar\";
                var fileName = accountListsBox.Text + ".png";
                File.Delete(Path.Combine(appPath, fileName));
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
            }
            //deleting account from text file
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line != accountListsBox.Text)
                {
                    streamWriter.WriteLine(line);
                }
            }
            //deleting account from listBox
            for (int i = 0; i < accountListsBox.Items.Count; i++)
            {
                string item = (string)accountListsBox.Items[i];
                if (item.StartsWith(accountListsBox.Text))
                {
                    accountListsBox.Items.RemoveAt(i);
                }
            }


            streamReader.Close();
            streamWriter.Close();

            File.Delete(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\bin\Debug\AccountList.txt");
            File.Move(tempFile, @"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\bin\Debug\AccountList.txt");
        }
        //reading list of accounts from txt and showing in listBox
        private void Display()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\robka\Documents\VS2017\FlashCardsApp\FlashCardsApp\bin\Debug\AccountList.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                accountListsBox.Items.Add(line);
            }

            streamReader.Close();
            streamReader.Dispose();
        }


    }
}
