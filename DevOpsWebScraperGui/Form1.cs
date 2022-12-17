using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevOpsWebScraperGui
{
    public partial class Form1 : Form
    {
        private List<List<string>> stringToWrite = new List<List<string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonScrapeData_Click(object sender, EventArgs e)
        {
            string exportChoice = string.Empty;
            if (CBCSV.Checked)
            {
                exportChoice = "CSV";
            }
            else if (CBJSON.Checked)
            {
                exportChoice = "JSON";
            }
            else if (CBXML.Checked)
            {
                exportChoice = "XML";
            }
            else if (CBHTML.Checked)
            {
                exportChoice = "HTML";

            }
            else if (CBSQL.Checked)
            {
                exportChoice = "SQL";
            }

            if (CBSearchYoutube.Checked)
            {
                SearchForm searchForm = new SearchForm("YoutubeSearch", exportChoice);
                searchForm.Show();
            }
            else if (CBJobSearch.Checked)
            {
                SearchForm searchForm = new SearchForm("JobSearch", exportChoice);
                searchForm.Show();
            }
            else if (CBF1Standings.Checked)
            {
                F1Form f1Form = new F1Form(exportChoice);
                f1Form.Show(); 
            }
        }
    }
}