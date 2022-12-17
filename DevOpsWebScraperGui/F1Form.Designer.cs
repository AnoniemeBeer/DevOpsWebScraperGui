namespace DevOpsWebScraperGui
{
    partial class F1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1Form));
            this.QuitButton = new System.Windows.Forms.Button();
            this.ButtonScrapeData = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitButton.Location = new System.Drawing.Point(12, 206);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(240, 23);
            this.QuitButton.TabIndex = 13;
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
            this.ButtonScrapeData.TabIndex = 12;
            this.ButtonScrapeData.Text = "Scrape Data";
            this.ButtonScrapeData.UseVisualStyleBackColor = true;
            this.ButtonScrapeData.Click += new System.EventHandler(this.ButtonScrapeData_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(12, 36);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(86, 13);
            this.Year.TabIndex = 11;
            this.Year.Text = "Year: 1950-2022";
            // 
            // TBCategory
            // 
            this.TBCategory.Location = new System.Drawing.Point(12, 103);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(237, 20);
            this.TBCategory.TabIndex = 16;
            this.TBCategory.TextChanged += new System.EventHandler(this.TBCategory_TextChanged);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 87);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(206, 13);
            this.Type.TabIndex = 15;
            this.Type.Text = "Category: races, drivers, team, fastest-laps";
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(12, 52);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(237, 20);
            this.TBYear.TabIndex = 17;
            // 
            // F1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBCategory);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ButtonScrapeData);
            this.Controls.Add(this.Year);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F1Form";
            this.Text = "F1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button ButtonScrapeData;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox TBYear;
    }
}