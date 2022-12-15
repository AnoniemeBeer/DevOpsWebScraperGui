using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevOpsWebScraperGui
{
    public partial class SearchForm : Form
    {
        private string choice = "";
        private List<List<string>> stringToWrite = new List<List<string>>();
        private string exportType;
        public SearchForm(string choice, string exportChoice)
        {
            InitializeComponent();
            this.choice = choice;
            this.exportType = exportChoice;

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonScrapeData_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case "YoutubeSearch":
                    stringToWrite = DataScraper.YoutubeSearch(InputSearchWord.Text);
                    break;
                case "JobSearch":
                    stringToWrite = DataScraper.SearchJob(InputSearchWord.Text);
                    break;
            }
            string path = "nope";
            switch (exportType)
            {
                case "CSV":
                    path = WriteToFile.WriteToCsv(stringToWrite);
                    break;
                case "JSON":
                    path = WriteToFile.WriteToJson(stringToWrite);
                    break;
                case "XML":
                    path = WriteToFile.WriteToXml(stringToWrite);
                    break;
                case "HTML":
                    path = WriteToFile.WriteToHtml(stringToWrite);
                    break;
                case "SQL":
                    path = WriteToFile.GenerateSql(stringToWrite);
                    break;
                default:
                    MessageBox.Show("You must select a export type", "error");
                    break;
            }
            if (path != "" & path != "nope")
            {
                MessageBox.Show($"File is saved at: {path}", "Succes");
            }
            Close();
        }
    }
}
