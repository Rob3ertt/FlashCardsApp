using FlashCardsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardsApp
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
        }
        private void HelpScreen_Load(object sender, EventArgs e)
        {
            //setting window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }
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


    }
}
