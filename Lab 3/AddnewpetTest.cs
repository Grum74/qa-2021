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
public class AddnewpetTest {
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
  public void addnewpet() {
    driver.Navigate().GoToUrl("http://20.82.57.125:8080/");
    driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    driver.FindElement(By.CssSelector(".petOwner:nth-child(470) a")).Click();
    driver.FindElement(By.CssSelector(".addNewPet")).Click();
    driver.FindElement(By.Id("name")).Click();
    driver.FindElement(By.Id("name")).SendKeys("Cat");
    driver.FindElement(By.Name("birthDate")).Click();
    driver.FindElement(By.CssSelector(".mat-datepicker-toggle-default-icon")).Click();
    driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(2) > .mat-calendar-body-cell:nth-child(2) > .mat-calendar-body-cell-content")).Click();
    driver.FindElement(By.Id("type")).Click();
    {
      var dropdown = driver.FindElement(By.Id("type"));
      dropdown.FindElement(By.XPath("//option[. = 'cat']")).Click();
    }
    driver.FindElement(By.CssSelector(".savePet")).Click();
    driver.FindElement(By.CssSelector(".dl-horizontal")).Click();
    driver.FindElement(By.CssSelector(".petType")).Click();
  }
}
