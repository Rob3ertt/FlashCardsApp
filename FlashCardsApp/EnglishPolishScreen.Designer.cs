namespace FlashCardsApp
{
    partial class EnglishPolishScreen
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
            this.englishWord = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showWordButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // englishWord
            // 
            this.englishWord.AutoSize = true;
            this.englishWord.BackColor = System.Drawing.Color.Transparent;
            this.englishWord.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishWord.Location = new System.Drawing.Point(42, 64);
            this.englishWord.Name = "englishWord";
            this.englishWord.Size = new System.Drawing.Size(0, 30);
            this.englishWord.TabIndex = 0;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(242, 311);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(126, 20);
            this.answerBox.TabIndex = 1;
            this.answerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerBox_KeyDown);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(250, 268);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(0, 25);
            this.tipLabel.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Crimson;
            this.resultLabel.Location = new System.Drawing.Point(426, 38);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 33);
            this.resultLabel.TabIndex = 3;
            // 
            // skipButton
            // 
            this.skipButton.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.Location = new System.Drawing.Point(242, 379);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(63, 36);
            this.skipButton.TabIndex = 5;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.englishWord);
            this.panel1.Location = new System.Drawing.Point(195, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 177);
            this.panel1.TabIndex = 6;
            // 
            // showWordButton
            // 
            this.showWordButton.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showWordButton.Location = new System.Drawing.Point(305, 379);
            this.showWordButton.Name = "showWordButton";
            this.showWordButton.Size = new System.Drawing.Size(63, 36);
            this.showWordButton.TabIndex = 7;
            this.showWordButton.Text = "Show";
            this.showWordButton.UseVisualStyleBackColor = true;
            this.showWordButton.Click += new System.EventHandler(this.showWordButton_Click);
            // 
            // EnglishPolishScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlashCardsApp.Properties.Resources.quiz640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 473);
            this.Controls.Add(this.showWordButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.answerBox);
            this.Name = "EnglishPolishScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishPolishScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAppEvent);
            this.Load += new System.EventHandler(this.EnglishPolishScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label englishWord;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showWordButton;
    }
}