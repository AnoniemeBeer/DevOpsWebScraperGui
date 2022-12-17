<h1>DevOpsWebScraperGui</h1>

# 1. Table Of Contents
- [1. Table Of Contents](#1-table-of-contents)
- [2. Introduction](#2-introduction)
- [3. Code](#3-code)
  - [3.1. Scrapers](#31-scrapers)
    - [3.1.1. Youtube Search](#311-youtube-search)
    - [3.1.2. Search Job](#312-search-job)
    - [3.1.3. F1 Standings](#313-f1-standings)
  - [3.2. Exporters](#32-exporters)
- [4. Conclusion](#4-conclusion)
- [5. Sources](#5-sources)

# 2. Introduction
This project is made for the DevOps & Security course on thomasmore geel. The goal is to make a console based webscraper application. This must be done with selenium browser automation tool and c#. The project description says that there need to be three scrapable websites: [youtube](https://www.youtube.com/), [ictjob](https://www.ictjob.be/) and a self chosen one. I chose for [F1 standings](https://www.formula1.com/en/results.html/2022/drivers.html). When the data is scraped from the web, it needs to be exported of course. It needed to be exportable to csv and json files, but I made the options to export to XML, HTML and sql.

# 3. Code
The project is build with two main classes: a class for the scraping part and a class for the export part. Besides that, there are 3 windows forms screens. A main screen and two scraper specific screens. You can find screenshots of the screens below. The windows forms screens where optional and a fun addition I added to the project.

<img src="Assets/Images/MainScreen.png" alt="Screenshot of main page" width="33%">
<img src="Assets/Images/YoutubeIctjobScreen.png" alt="Screenshot of youtube/ictjob page" width="33%">
<img src="Assets/Images/F1Screen.png" alt="Screenshot of F1 page" width="33%">

## 3.1. Scrapers
The class is writen in the file: DataScraper.cs. It contains 5 methods, two of which are meant for development and testing. I will be focussing on the three methods used in the program. Communication between the data scrapers and the exporters are handled via a universal type. This is done by a two dimentional string list: List\<List\<string>>. This way, all scrapers can use all exporters and all exporters can convert data from all scrapers.

### 3.1.1. Youtube Search
The youtube search method takes one parameter, the search term. The user can input this in on of the screens. 

### 3.1.2. Search Job

### 3.1.3. F1 Standings

## 3.2. Exporters

# 4. Conclusion
The project was very fun to make. I enjoyed getting back into c#. I learned alot about how big companies design their site and I will take this knowledge and try to build better, more effecient websites.

The source code for the project can be found on [my github repository](https://github.com/AnoniemeBeer/DevOpsWebScraperGui). The installer to the project is located in the Releases tab in the latest release.

# 5. Sources

- [Selinum Webscraper](https://www.selenium.dev/documentation/)
- [Microsoft .net Documentation](https://learn.microsoft.com/en-us/dotnet/)