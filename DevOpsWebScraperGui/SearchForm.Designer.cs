namespace DevOpsWebScraperGui
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchWord = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ButtonScrapeData = new System.Windows.Forms.Button();
            this.InputSearchWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchWord
            // 
            this.SearchWord.AutoSize = true;
            this.SearchWord.Location = new System.Drawing.Point(12, 84);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(44, 13);
            this.SearchWord.TabIndex = 0;
            this.SearchWord.Text = "Search:";
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitButton.Location = new System.Drawing.Point(12, 206);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(240, 23);
            this.QuitButton.TabIndex = 9;
            this.QuitButton.Text = "Exit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ButtonScrapeData
            // 
            this.ButtonScrapeData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonScrapeData.Location = new System.Drawing.Point(12, 177);
            this.ButtonScrapeData.Name = "ButtonScrapeData";
            this.ButtonScrapeData.Size = new System.Drawing.Size(240, 23);
            this.ButtonScrapeData.TabIndex = 8;
            this.ButtonScrapeData.Text = "Scrape Data";
            this.ButtonScrapeData.UseVisualStyleBackColor = true;
            this.ButtonScrapeData.Click += new System.EventHandler(this.ButtonScrapeData_Click);
            // 
            // InputSearchWord
            // 
            this.InputSearchWord.Location = new System.Drawing.Point(62, 81);
            this.InputSearchWord.Name = "InputSearchWord";
            this.InputSearchWord.Size = new System.Drawing.Size(190, 20);
            this.InputSearchWord.TabIndex = 10;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.InputSearchWord);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ButtonScrapeData);
            this.Controls.Add(this.SearchWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchWord;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button ButtonScrapeData;
        private System.Windows.Forms.TextBox InputSearchWord;
    }
}