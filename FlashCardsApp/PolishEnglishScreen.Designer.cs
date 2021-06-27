namespace FlashCardsApp
{
    partial class PolishEnglishScreen
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
            this.skipButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.polishWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skipButton
            // 
            this.skipButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.Location = new System.Drawing.Point(269, 378);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(87, 36);
            this.skipButton.TabIndex = 11;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Crimson;
            this.resultLabel.Location = new System.Drawing.Point(426, 37);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 33);
            this.resultLabel.TabIndex = 9;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(48, 405);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(0, 25);
            this.counterLabel.TabIndex = 8;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(269, 310);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(87, 20);
            this.answerBox.TabIndex = 7;
            this.answerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerBox_KeyDown);
            // 
            // polishWord
            // 
            this.polishWord.AutoSize = true;
            this.polishWord.BackColor = System.Drawing.Color.Transparent;
            this.polishWord.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polishWord.Location = new System.Drawing.Point(209, 98);
            this.polishWord.Name = "polishWord";
            this.polishWord.Size = new System.Drawing.Size(0, 30);
            this.polishWord.TabIndex = 6;
            // 
            // PolishEnglishScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlashCardsApp.Properties.Resources.quiz640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 473);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.polishWord);
            this.Name = "PolishEnglishScreen";
            this.Text = "PolishEnglishScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PolishEnglishScreen_FormClosing);
            this.Load += new System.EventHandler(this.PolishEnglishScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label polishWord;
    }
}