using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DevOpsWebScraperGui
{
    public class DataScraper
    {
        public static List<List<string>> YoutubeChannel()
        {
            String urlDearmoon = "https://www.youtube.com/@dearmoon2023/videos";

            // Setting up the driver manager that automatically handles all drivers(drivers don't need to be installed)
            new DriverManager().SetUpDriver(new ChromeConfig());
            // Starting the google chrome driver
            IWebDriver driver = new ChromeDriver();

            // Navigating the chrome page to the desired link
            driver.Navigate().GoToUrl(urlDearmoon);

            // Accept cookies
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[@aria-label='Accept all']"));
            cookieButton.Click();

            System.Threading.Thread.Sleep(1000);

            // Get all titles from videos
            ReadOnlyCollection<IWebElement> videos = driver.FindElements(By.CssSelector("#contents > ytd-rich-item-renderer"));

            // Create empty dicrionary list where all the videos will be added to.
            List<List<string>> videoData = new List<List<string>>();

            // Create an empty list where the starting data is going toz
            List<string> headerlist = new List<string>
            {
                "Title", "Url", "Uploader", "Views"
            };
            videoData.Add(headerlist);

            // Add all data to the dictionary list
            // Every video gets its own dictionary in the list
            foreach (IWebElement video in videos)
            {
                // Create an empty list where all data is going to
                List<string> list = new List<string>();

                // Defining the variable where the data will be stored in
                string str_videoTitle, str_videoUrl, str_uploader, str_views;

                // Getting the web elements from the from the page
                IWebElement elem_videoTitle = video.FindElement(By.CssSelector("#video-title"));
                IWebElement elem_videoUrl = video.FindElement(By.CssSelector("#video-title-link"));
                //IWebElement elem_uploader = video.FindElement(By.CssSelector(""));
                IWebElement elem_views = video.FindElement(By.CssSelector("#metadata-line > span:nth-child(3)"));

                // Extracting the data from the web elements
                str_videoTitle = elem_videoTitle.Text;
                str_videoUrl = "https://www.youtube.com" + elem_videoUrl.GetAttribute("href");
                str_uploader = "DearMoon";
                str_views = elem_views.Text;

                // Adding the extracted data to the dictionary.
                list.Add(str_videoTitle);
                list.Add(str_videoUrl);
                list.Add(str_uploader);
                list.Add(str_views);

                videoData.Add(list);
            }

            driver.Quit();

            return videoData;
        }

        public static List<List<string>> YoutubeSearch(string searchTerm)
        {
            String urlSearch = "https://www.youtube.com/results?search_query={0}&sp=CAISAhAB";

            // Setting up the driver manager that automatically handles all drivers (drivers don't need to be installed)
            new DriverManager().SetUpDriver(new ChromeConfig());
            // Starting the google chrome driver
            IWebDriver driver = new ChromeDriver();

            // Navigating the chrome page to the desired link
            driver.Navigate().GoToUrl(String.Format(urlSearch, searchTerm.Replace(' ', '+')));

            System.Threading.Thread.Sleep(4000);

            //https://www.youtube.com/results?search_query=Rick+Astley&sp=CAISAhAB
            // Accept cookies
            try
            {
                IWebElement cookieButton = driver.FindElement(By.CssSelector("#content > div.body.style-scope.ytd-consent-bump-v2-lightbox > div.eom-buttons.style-scope.ytd-consent-bump-v2-lightbox > div:nth-child(1) > ytd-button-renderer:nth-child(2) > yt-button-shape > button"));
                cookieButton.Click();
                System.Threading.Thread.Sleep(4000);
            }
            finally { }

            // Get all videos from the page in a collection
            ReadOnlyCollection<IWebElement> videos = driver.FindElements(By.CssSelector("#contents > ytd-video-renderer"));

            // Create empty dicrionary list where all the videos will be added to.
            List<List<string>> videoData = new List<List<string>>();

            // Create an empty list where the starting data is going to
            List<string> headerList = new List<string>
            {
                "Title", "Url", "Uploader", "Views", "UploadDate"
            };
            videoData.Add(headerList);

            // Every video gets its own dictionary in the list
            for (int i = 0; i < 5; i++)
            {
                // Create an empty list where all data is going to
                List<string> list = new List<string>();

                // Defining the variable where the data will be stored in
                string str_videoTitle, str_videoUrl, str_uploader, str_views, str_uploadDate;

                // Getting the web elements from the from the page
                IWebElement elem_videoTitle = videos[i].FindElement(By.CssSelector("#video-title > yt-formatted-string"));
                IWebElement elem_videoUrl = videos[i].FindElement(By.CssSelector("#video-title"));
                IWebElement elem_uploader = videos[i].FindElement(By.XPath("div[1]/div/div[2]/ytd-channel-name/div/div/yt-formatted-string/a"));
                IWebElement elem_views = videos[i].FindElement(By.CssSelector("#metadata-line > span:nth-child(3)"));
                IWebElement elem_uploadDate = videos[i].FindElement(By.CssSelector("#metadata-line > span:nth-child(4)"));

                // Extracting the data from the web elements
                str_videoTitle = elem_videoTitle.Text;
                str_videoUrl = elem_videoUrl.GetAttribute("href");
                str_uploader = elem_uploader.Text;
                str_views = elem_views.Text;
                str_uploadDate = elem_uploadDate.Text;

                // Adding the extracted data to the dictionary.
                list.Add(str_videoTitle);
                list.Add(str_videoUrl);
                list.Add(str_uploader);
                list.Add(str_views);
                list.Add(str_uploadDate);

                videoData.Add(list);
            }

            System.Threading.Thread.Sleep(5000);

            driver.Quit();

            return videoData;
        }

        public static List<List<string>> SearchJob(string searchTerm)
        {
            String urlSearch = "https://www.ictjob.be/en/search-it-jobs?keywords={0}";

            // Setting up the driver manager that automatically handles all drivers(drivers don't need to be installed)
            new DriverManager().SetUpDriver(new ChromeConfig());
            // Starting the google chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(String.Format(urlSearch, searchTerm.Replace(' ', '+')));
            System.Threading.Thread.Sleep(5000);

            //click the button to sort on date
            IWebElement dateButton = driver.FindElement(By.CssSelector("#sort-by-date"));
            dateButton.Click();
            System.Threading.Thread.Sleep(2500);

            IWebElement allWordsButton = driver.FindElement(By.XPath("//*[@id=\"column-keywords-options\"]/label[2]/span"));
            allWordsButton.Click();
            System.Threading.Thread.Sleep(10000);

            ReadOnlyCollection<IWebElement> jobs = driver.FindElements(By.CssSelector("#search-result-body > div > ul > li"));

            List<List<string>> jobData = new List<List<string>>();

            List<string> headerList = new List<string>
            {
                "JobTitle", "Company", "Location", "Keywords", "Url"
            };
            jobData.Add(headerList);

            int max = 5;

            for (int i = 0; i < max & i < jobs.Count; i++)
            {
                try
                {
                    // Create an empty list where all data is going to
                    List<string> list = new List<string>();

                    // Defining the variable where the data will be stored in
                    string str_jobTitle, str_company, str_location, str_keywords, str_url;

                    // Getting the web elements from the from the page
                    IWebElement elem_jobTitle = jobs[i].FindElement(By.CssSelector("span.job-info > a > h2"));
                    IWebElement elem_company = jobs[i].FindElement(By.CssSelector("span.job-info > span.job-company"));
                    IWebElement elem_location = jobs[i].FindElement(By.CssSelector("span.job-info > span.job-details > span.job-location > span > span"));
                    IWebElement elem_keywords = jobs[i].FindElement(By.CssSelector("span.job-info > span.job-keywords"));
                    IWebElement elem_url = jobs[i].FindElement(By.CssSelector("span.job-info > a"));

                    // Extracting the data from the web elements
                    str_jobTitle = elem_jobTitle.Text;
                    str_company = elem_company.Text;
                    str_location = elem_location.Text;
                    str_keywords = elem_keywords.Text;
                    str_url = elem_url.GetAttribute("href");

                    // Adding the extracted data to the dictionary.
                    list.Add(str_jobTitle);
                    list.Add(str_company);
                    list.Add(str_location);
                    list.Add(str_keywords);
                    list.Add(str_url);

                    jobData.Add(list);
                }
                catch
                {
                    max++;
                }

            }

            driver.Close();
            return jobData;
        }

        public static List<List<string>> ScrapeF1Data(string categoryChoice, string yearChoice)
        {
            string url = "https://www.formula1.com/en/results.html/{0}/{1}.html";

            // Setting up the driver manager that automatically handles all drivers(drivers don't need to be installed)
            new DriverManager().SetUpDriver(new ChromeConfig());
            // Starting the google chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(String.Format(url, yearChoice, categoryChoice));

            IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[3]/div[2]/button[2]"));
            acceptCookies.Click();

            IWebElement dataTable = driver.FindElement(By.CssSelector("body > div.site-wrapper > main > article > div > div.ResultArchiveContainer > div.resultsarchive-wrapper > div.resultsarchive-content > div > table"));

            List<List<string>> jobData = new List<List<string>>();

            ReadOnlyCollection<IWebElement> columnNames = dataTable.FindElements(By.CssSelector("thead > tr > th"));
            ReadOnlyCollection<IWebElement> columnData = dataTable.FindElements(By.CssSelector("tbody > tr"));

            List<string> headerList = new List<string>();
            foreach (IWebElement columnName in columnNames)
            {
                if (!columnName.GetAttribute("class").Equals("limiter"))
                {
                    if (columnName.GetAttribute("class").Equals("header"))
                    {
                        headerList.Add(columnName.FindElement(By.TagName("abbr")).GetAttribute("title"));
                    }
                    else
                    {
                        headerList.Add(columnName.Text);
                    }
                }
            }
            jobData.Add(headerList);

            foreach (IWebElement row in columnData)
            {
                List<string> list = new List<string>();
                ReadOnlyCollection<IWebElement> rowData = row.FindElements(By.CssSelector("td"));
                foreach (IWebElement data in rowData)
                {
                    if (!data.GetAttribute("class").Equals("limiter"))
                    {
                        if (data.GetAttribute("class").Equals(""))
                        {
                            if (data.FindElement(By.TagName("a")).Text.Equals(""))
                            {
                                string name = "";
                                ReadOnlyCollection<IWebElement> span = data.FindElement(By.TagName("a")).FindElements(By.TagName("span"));
                                for (int i = 0; i < 2; i++)
                                {
                                    name += (span[i].Text);
                                }
                                list.Add(name);
                            }
                            else
                            {
                                list.Add(data.FindElement(By.TagName("a")).Text);
                            }
                        }
                        else
                        {
                            list.Add(data.Text);
                        }
                    }
                }
                jobData.Add(list);
            }
            driver.Close();
            return jobData;
        }

        public static List<List<string>> TestMethod()
        {
            List<List<string>> myList = new List<List<string>>();

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();

            list1.Add("title");
            list1.Add("author");
            list1.Add("link");

            list2.Add("Shakira - Whenever, Wherever (Official HD Video)");
            list2.Add("Shakira");
            list2.Add("https://www.youtube.com/watch?v=weRHyjj34ZE");

            list3.Add("Shakira - Waka Waka (This Time for Africa) (The Official 2010 FIFA World Cup™ Song)");
            list3.Add("Shakira");
            list3.Add("https://www.youtube.com/watch?v=pRpeEdMmmQ0");

            myList.Add(list1);
            myList.Add(list2);
            myList.Add(list3);

            return myList;
        }
    }
}