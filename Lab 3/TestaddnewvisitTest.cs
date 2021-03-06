// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TestaddnewvisitTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testaddnewvisit() {
    driver.Navigate().GoToUrl("http://20.82.57.125:8080/");
    driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    driver.FindElement(By.CssSelector(".petOwner:nth-child(467) a")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.CssSelector(".addNewVisit")).Click();
    driver.FindElement(By.Name("date")).Click();
    driver.FindElement(By.Name("date")).SendKeys("2021/11/14");
    driver.FindElement(By.Id("description")).Click();
    driver.FindElement(By.Id("description")).Click();
    driver.FindElement(By.Id("description")).SendKeys("visit");
    driver.FindElement(By.CssSelector(".addVisit")).Click();
  }
}
