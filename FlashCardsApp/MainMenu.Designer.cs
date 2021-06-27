namespace FlashCardsApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonWordSets = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.ENG = new System.Windows.Forms.PictureBox();
            this.PL = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(206, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(198, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "FlashCards";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Silver;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.buttonStart.Location = new System.Drawing.Point(226, 113);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 44);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.LoadApp);
            // 
            // buttonWordSets
            // 
            this.buttonWordSets.BackColor = System.Drawing.Color.Silver;
            this.buttonWordSets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWordSets.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.buttonWordSets.Location = new System.Drawing.Point(226, 172);
            this.buttonWordSets.Name = "buttonWordSets";
            this.buttonWordSets.Size = new System.Drawing.Size(135, 44);
            this.buttonWordSets.TabIndex = 2;
            this.buttonWordSets.Text = "Word Sets";
            this.buttonWordSets.UseVisualStyleBackColor = false;
            this.buttonWordSets.Click += new System.EventHandler(this.LoadWordSets);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Silver;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.buttonAccount.Location = new System.Drawing.Point(226, 232);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(135, 44);
            this.buttonAccount.TabIndex = 1;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.LoadAccount);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Silver;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.buttonHelp.Location = new System.Drawing.Point(226, 291);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(135, 44);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.LoadHelp);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Silver;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.buttonQuit.Location = new System.Drawing.Point(226, 351);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(135, 44);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.Quit);
            // 
            // ENG
            // 
            this.ENG.BackColor = System.Drawing.Color.Transparent;
            this.ENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ENG.Image = global::FlashCardsApp.Properties.Resources.UKIcon;
            this.ENG.Location = new System.Drawing.Point(523, 18);
            this.ENG.Name = "ENG";
            this.ENG.Size = new System.Drawing.Size(33, 33);
            this.ENG.TabIndex = 4;
            this.ENG.TabStop = false;
            this.ENG.Click += new System.EventHandler(this.LanguageChanger);
            // 
            // PL
            // 
            this.PL.BackColor = System.Drawing.Color.Transparent;
            this.PL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PL.Image = global::FlashCardsApp.Properties.Resources.PolandIcon;
            this.PL.Location = new System.Drawing.Point(562, 18);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(33, 33);
            this.PL.TabIndex = 5;
            this.PL.TabStop = false;
            this.PL.Click += new System.EventHandler(this.LanguageChanger);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::FlashCardsApp.Properties.Resources.defult_profile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountNameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accountNameLabel.Location = new System.Drawing.Point(24, 84);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(71, 28);
            this.accountNameLabel.TabIndex = 7;
            this.accountNameLabel.Text = "Default";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::FlashCardsApp.Properties.Resources.add_icon11;
            this.pictureBox3.Location = new System.Drawing.Point(68, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlashCardsApp.Properties.Resources.notebook_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 473);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.ENG);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.buttonWordSets);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAppEvent);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonWordSets;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.PictureBox ENG;
        private System.Windows.Forms.PictureBox PL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}