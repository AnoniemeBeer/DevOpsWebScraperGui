namespace DevOpsWebScraperGui
{
    partial class Form1
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
            this.ButtonScrapeData = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSearchYoutube = new System.Windows.Forms.CheckBox();
            this.CBJobSearch = new System.Windows.Forms.CheckBox();
            this.CBF1Standings = new System.Windows.Forms.CheckBox();
            this.CBCSV = new System.Windows.Forms.CheckBox();
            this.CBJSON = new System.Windows.Forms.CheckBox();
            this.CBXML = new System.Windows.Forms.CheckBox();
            this.CBHTML = new System.Windows.Forms.CheckBox();
            this.CBSQL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonScrapeData
            // 
            this.ButtonScrapeData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonScrapeData.Location = new System.Drawing.Point(12, 177);
            this.ButtonScrapeData.Name = "ButtonScrapeData";
            this.ButtonScrapeData.Size = new System.Drawing.Size(240, 23);
            this.ButtonScrapeData.TabIndex = 0;
            this.ButtonScrapeData.Text = "Scrape Data";
            this.ButtonScrapeData.UseVisualStyleBackColor = true;
            this.ButtonScrapeData.Click += new System.EventHandler(this.ButtonScrapeData_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitButton.Location = new System.Drawing.Point(12, 206);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(240, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Exit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Selector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "File Type";
            // 
            // CBSearchYoutube
            // 
            this.CBSearchYoutube.AutoSize = true;
            this.CBSearchYoutube.Location = new System.Drawing.Point(35, 39);
            this.CBSearchYoutube.Name = "CBSearchYoutube";
            this.CBSearchYoutube.Size = new System.Drawing.Size(103, 17);
            this.CBSearchYoutube.TabIndex = 13;
            this.CBSearchYoutube.Text = "Search Youtube";
            this.CBSearchYoutube.UseVisualStyleBackColor = true;
            // 
            // CBJobSearch
            // 
            this.CBJobSearch.AutoSize = true;
            this.CBJobSearch.Location = new System.Drawing.Point(35, 63);
            this.CBJobSearch.Name = "CBJobSearch";
            this.CBJobSearch.Size = new System.Drawing.Size(80, 17);
            this.CBJobSearch.TabIndex = 14;
            this.CBJobSearch.Text = "Job Search";
            this.CBJobSearch.UseVisualStyleBackColor = true;
            // 
            // CBF1Standings
            // 
            this.CBF1Standings.AutoSize = true;
            this.CBF1Standings.Location = new System.Drawing.Point(35, 87);
            this.CBF1Standings.Name = "CBF1Standings";
            this.CBF1Standings.Size = new System.Drawing.Size(88, 17);
            this.CBF1Standings.TabIndex = 15;
            this.CBF1Standings.Text = "F1 Standings";
            this.CBF1Standings.UseVisualStyleBackColor = true;
            // 
            // CBCSV
            // 
            this.CBCSV.AutoSize = true;
            this.CBCSV.Location = new System.Drawing.Point(174, 39);
            this.CBCSV.Name = "CBCSV";
            this.CBCSV.Size = new System.Drawing.Size(47, 17);
            this.CBCSV.TabIndex = 16;
            this.CBCSV.Text = "CSV";
            this.CBCSV.UseVisualStyleBackColor = true;
            // 
            // CBJSON
            // 
            this.CBJSON.AutoSize = true;
            this.CBJSON.Location = new System.Drawing.Point(174, 63);
            this.CBJSON.Name = "CBJSON";
            this.CBJSON.Size = new System.Drawing.Size(54, 17);
            this.CBJSON.TabIndex = 17;
            this.CBJSON.Text = "JSON";
            this.CBJSON.UseVisualStyleBackColor = true;
            // 
            // CBXML
            // 
            this.CBXML.AutoSize = true;
            this.CBXML.Location = new System.Drawing.Point(174, 87);
            this.CBXML.Name = "CBXML";
            this.CBXML.Size = new System.Drawing.Size(48, 17);
            this.CBXML.TabIndex = 18;
            this.CBXML.Text = "XML";
            this.CBXML.UseVisualStyleBackColor = true;
            // 
            // CBHTML
            // 
            this.CBHTML.AutoSize = true;
            this.CBHTML.Location = new System.Drawing.Point(174, 110);
            this.CBHTML.Name = "CBHTML";
            this.CBHTML.Size = new System.Drawing.Size(56, 17);
            this.CBHTML.TabIndex = 19;
            this.CBHTML.Text = "HTML";
            this.CBHTML.UseVisualStyleBackColor = true;
            // 
            // CBSQL
            // 
            this.CBSQL.AutoSize = true;
            this.CBSQL.Location = new System.Drawing.Point(174, 133);
            this.CBSQL.Name = "CBSQL";
            this.CBSQL.Size = new System.Drawing.Size(47, 17);
            this.CBSQL.TabIndex = 20;
            this.CBSQL.Text = "SQL";
            this.CBSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonScrapeData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.CBSQL);
            this.Controls.Add(this.CBHTML);
            this.Controls.Add(this.CBXML);
            this.Controls.Add(this.CBJSON);
            this.Controls.Add(this.CBCSV);
            this.Controls.Add(this.CBF1Standings);
            this.Controls.Add(this.CBJobSearch);
            this.Controls.Add(this.CBSearchYoutube);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ButtonScrapeData);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonScrapeData;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBSearchYoutube;
        private System.Windows.Forms.CheckBox CBJobSearch;
        private System.Windows.Forms.CheckBox CBF1Standings;
        private System.Windows.Forms.CheckBox CBCSV;
        private System.Windows.Forms.CheckBox CBJSON;
        private System.Windows.Forms.CheckBox CBXML;
        private System.Windows.Forms.CheckBox CBHTML;
        private System.Windows.Forms.CheckBox CBSQL;
    }
}

