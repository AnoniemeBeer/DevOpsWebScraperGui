using OpenQA.Selenium.DevTools.V106.Debugger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsWebScraperGui
{
    public partial class F1Form : Form
    {
        private string exportType;
        public F1Form(string exportType)
        {
            InitializeComponent();
            this.exportType = exportType;
        }

        private void ButtonScrapeData_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for(int i = 1950; i < 2023; i++)
            {
                if (TBYear.Text == i.ToString())
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Please enter a year starting from 1950 up to 2022.", "error");
            }

            if (!(TBCategory.Text == "races" | TBCategory.Text == "drivers" | TBCategory.Text == "team" | TBCategory.Text == "fastest-laps") & flag)
            {
                MessageBox.Show("Please enter a valid category", "error");
                flag = false;
            }

            if (flag)
            {
                List<List<string>> stringToWrite = DataScraper.ScrapeF1Data(TBCategory.Text, TBYear.Text);
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

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
