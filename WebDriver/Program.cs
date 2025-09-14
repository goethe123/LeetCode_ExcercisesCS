using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
 
IWebDriver driver = new ChromeDriver();
 
try
{
    driver.Url = "https://www.epam.com";
 
    var searchIcon = driver.FindElement(By.ClassName("dark-iconheader-search__search-icon"));
 
    searchIcon.Click();
 
    var searchPanelWait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
    {
        PollingInterval = TimeSpan.FromSeconds(0.25),
        Message = "Search panel has not been found"
    };
 
    var searchPanel = searchPanelWait.Until(driver => driver.FindElement(By.ClassName("header-search__panel")));
    var searchInput = searchPanel.FindElement(By.Name("q"));
 
    var clickAndSendKeysActions = new Actions(driver);
 
    clickAndSendKeysActions.Click(searchInput)
        .Pause(TimeSpan.FromSeconds(1))
        .SendKeys("Automation")
        .Perform();
 
    var findButton = searchPanel.FindElement(By.XPath(".//*[@class='search-results__input-holder']/following-sibling::button"));
    findButton.Click();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    driver.Quit();
}
 