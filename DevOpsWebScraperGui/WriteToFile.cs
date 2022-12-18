using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DevOpsWebScraperGui
{
    public class WriteToFile
    {
        public static string WriteToCsv(List<List<string>> data)
        {
            string csvString = "";
            foreach (List<string> entry in data)
            {
                string line = "";
                foreach (string s in entry)
                {
                    line += s + ", ";
                }
                csvString += line.Remove(line.Length - 2) + System.Environment.NewLine;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv file (*.csv)|*.csv|All files (*.*)|*.*";
            string path = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(csvString);
                writer.Close();
            }
            return path;
        }

        public static string WriteToJson(List<List<string>> data)
        {
            List<string> jsonNames = data[0];

            string jsonString = "[" + System.Environment.NewLine;

            for (int j = 0; j < data.Count; j++)
            {
                if (data[j] != jsonNames)
                {
                    string jsonDocument = "\t" + "{" + System.Environment.NewLine;
                    for (int i = 0; i < data[j].Count; i++)
                    {
                        if (i == data[j].Count - 1)
                        {
                            jsonDocument += "\t" + "\t" + '"' + jsonNames[i] + '"' + ":" + '"' + data[j][i].Replace('"', ' ') + '"' + System.Environment.NewLine;
                        }
                        else
                        {
                            jsonDocument += "\t" + "\t" + '"' + jsonNames[i] + '"' + ":" + '"' + data[j][i].Replace('"', ' ') + '"' + "," + System.Environment.NewLine;
                        }
                    }
                    if (j == data.Count - 1)
                    {
                        jsonDocument = jsonDocument.Remove(jsonDocument.Length - 1) + System.Environment.NewLine + "\t" + "}" + System.Environment.NewLine;
                    }
                    else
                    {
                        jsonDocument = jsonDocument.Remove(jsonDocument.Length - 1) + System.Environment.NewLine + "\t" + "}," + System.Environment.NewLine;
                    }

                    jsonString += jsonDocument;
                }
            }
            jsonString = jsonString.Remove(jsonString.Length - 1) + System.Environment.NewLine + "]";


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "json file (*.json)|*.json|All files (*.*)|*.*";
            string path = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(jsonString);
                writer.Close();
            }
            return path;
        }

        private static string XmlTag(string word, bool endTag = false, int id = -1)
        {
            if (endTag)
            {
                return "</" + word + ">";
            }
            else
            {
                if (id != -1)
                {
                    return "<" + word + " id=\"" + id + "\">";
                }
                return "<" + word + ">";
            }

        }

        public static string WriteToXml(List<List<string>> data)
        {
            List<string> xmlNames = data[0];

            string xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + System.Environment.NewLine;
            xmlString += XmlTag("Data") + System.Environment.NewLine;

            for (int j = 0; j < data.Count; j++)
            {
                if (data[j] != xmlNames)
                {
                    string xmlDocument = "\t" + XmlTag("Data", false, j) + System.Environment.NewLine;
                    for (int i = 0; i < data[j].Count; i++)
                    {
                        xmlDocument += "\t\t" + XmlTag(xmlNames[i]) + data[j][i] + XmlTag(xmlNames[i], true) + System.Environment.NewLine;
                    }
                    xmlDocument += "\t" + XmlTag("Data", true) + System.Environment.NewLine;

                    xmlString += xmlDocument;
                }
            }
            xmlString += XmlTag("Data", true);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml file (*.xml)|*.xml|All files (*.*)|*.*";
            string path = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(xmlString);
                writer.Close();
            }
            return path;
        }

        public static string WriteToHtml(List<List<string>> data)
        {
            List<string> tableHeaders = data[0];

            string xmlString = "<!DOCTYPE html>" + System.Environment.NewLine + "<html>" + System.Environment.NewLine + "<head>" + System.Environment.NewLine + "\t<title>" + "Test" + "</title>" + System.Environment.NewLine + "</head>" + System.Environment.NewLine + "<body>" + System.Environment.NewLine;
            xmlString += "\t" + XmlTag("table") + System.Environment.NewLine;
            xmlString += "\t\t" + XmlTag("tr") + System.Environment.NewLine;
            for (int i = 0; i < tableHeaders.Count; i++)
            {
                xmlString += "\t\t\t" + XmlTag("th") + tableHeaders[i] + XmlTag("th", true) + System.Environment.NewLine;
            }
            xmlString += "\t\t" + XmlTag("tr", true) + System.Environment.NewLine;

            for (int j = 0; j < data.Count; j++)
            {
                if (data[j] != tableHeaders)
                {
                    string xmlDocument = "\t\t" + XmlTag("tr", false) + System.Environment.NewLine;
                    for (int i = 0; i < data[j].Count; i++)
                    {
                        xmlDocument += "\t\t\t" + XmlTag("td") + data[j][i] + XmlTag("td", true) + System.Environment.NewLine;
                    }
                    xmlDocument += "\t\t" + XmlTag("tr", true) + System.Environment.NewLine;

                    xmlString += xmlDocument;
                }
            }
            xmlString += "\t" + XmlTag("table", true);
            xmlString += System.Environment.NewLine + "</body>" + System.Environment.NewLine + "</html>";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "html file (*.html)|*.html|All files (*.*)|*.*";
            string path = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(xmlString);
                writer.Close();
            }
            return path;
        }

        public static string GenerateSql(List<List<string>> data)
        {
            string sqlString = "CREATE TABLE Data(" + System.Environment.NewLine + "\tdataId int AUTO_INCREMENT PRIMARY KEY," + System.Environment.NewLine;
            List<string> sqlNames = data[0];

            // In this part of the code, the CREATE TABLE querry will be made
            foreach (string name in sqlNames)
            {
                sqlString += "\t" + name + " varchar(250)," + System.Environment.NewLine;
            }
            sqlString = sqlString.Remove(sqlString.Length - 2) + System.Environment.NewLine + ");" + System.Environment.NewLine;

            // In this part of the code, the insert querry will be made
            sqlString += "INSERT INTO Data(";
            foreach (string name in sqlNames)
            {
                sqlString += name + ", ";
            }
            sqlString = sqlString.Remove(sqlString.Length - 2) + ") VALUES" + System.Environment.NewLine;

            for (int i = 1; i < data.Count; i++)
            {
                sqlString += "\t(";
                foreach (string value in data[i])
                {
                    sqlString += "\"" + value + "\"" + ", ";
                }
                sqlString = sqlString.Remove(sqlString.Length - 2) + ")," + System.Environment.NewLine;
            }
            sqlString = sqlString.Remove(sqlString.Length - 2) + ";";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "sql file (*.sql)|*.sql|All files (*.*)|*.*";
            string path = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(sqlString);
                writer.Close();
            }
            return path;
        }
    }
}