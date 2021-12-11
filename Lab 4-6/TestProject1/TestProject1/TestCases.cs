using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Attributes;
using System;

namespace TestProject1
{
    public class TestCases : Base
    {
        [Test, Description("This test checks the opening of the main page by clicking on the logo")]
        [AllureSuite("Main page")]
        public void Mainpage()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".navbar-brand > span")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/"));
        }

        [Test, Description("This test checks the new owner adding")]
        [AllureSuite("Owner")]
        public void Addnewowner()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("0675060600").AddOwner();
            Helpers.Wait(1000);
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners"));
        }

        [Test, Description("This test checks create owners form validation")]
        [AllureSuite("Owner")]
        public void Addnewownerwithemptyfield()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("").TypeTelephone("0675060600").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("").TypeCity("Zhytomyr").TypeTelephone("0675060600").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("0675060600").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("0675060600").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
        }

        [Test, Description("This test checks create owners form validation")]
        [AllureSuite("Owner")]
        public void Addnewownerwithwrongformat()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("dsfdsfgdfgh").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("ds131313").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone("#######").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("Anatolii").TypeLastname("Kyiashenko").TypeAddress("Street").TypeCity("Zhytomyr").TypeTelephone(" ").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
        }

        [Test, Description("This test checks create owners form validation")]
        [AllureSuite("Owner")]
        public void Addnewownerwithjsinjection()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenCreateOwnerPage().TypeFirstname("alert(\"foo\");").TypeLastname("\\`-alert(\"foo\")-\\`;").TypeAddress("\\\\`-alert(\"foo\")//\\`;").TypeCity("alert(\"foo\");").TypeTelephone("0675060600").AddOwner();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners"));
        }

        [Test, Description("This test checks the new pet adding")]
        [AllureSuite("Pet")]
        public void Addnewpet()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenOwnerList();
            Helpers.Wait();
            OwnerDetailsPage ownerDetailsPage = Pages.OwnerList.OpenOwnerPage("Анатолий Кияшенко");
            string url = driver.Url;
            ownerDetailsPage.AddNewPet().TypeName("Cat").TypeBitrhDate("11.12.2021").SelectType("cat").SavePet();
            Assert.That(driver.Url.Equals(url));
        }

        [Test, Description("This test checks create pet form validation")]
        [AllureSuite("Pet")]
        public void Addnewpetwithemptyfield()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenOwnerList();
            Helpers.Wait();
            PetCreatePage petCreatePage = Pages.OwnerList.OpenOwnerPage("Анатолий Кияшенко").AddNewPet();
            string url = driver.Url;
            petCreatePage.TypeName("Cat").TypeBitrhDate("11.12.2021").SavePet();
            Assert.That(driver.Url.Equals(url));
            petCreatePage.TypeName("Cat").TypeBitrhDate("").SelectType("cat").SavePet();
            Assert.That(driver.Url.Equals(url));
            petCreatePage.TypeName("").TypeBitrhDate("11.12.2021").SelectType("cat").SavePet();
            Assert.That(driver.Url.Equals(url));
        }

        [Test, Description("This test checks create pet form validation")]
        [AllureSuite("Pet")]
        public void Birthdatefieldvalidationonaddnewpetform()
        {
            driver.Manage().Window.Size = Helpers.SetSize();
            Pages.NavBar.OpenOwnerList();
            Helpers.Wait();
            PetCreatePage petCreatePage = Pages.OwnerList.OpenOwnerPage("Анатолий Кияшенко").AddNewPet();
            string url = driver.Url;
            petCreatePage.TypeName("Cat").TypeBitrhDate("2021/11/31").SelectType("cat").SavePet();
            Assert.That(driver.Url.Equals(url));
            petCreatePage.TypeName("Cat").TypeBitrhDate("2021.11.31").SelectType("cat").SavePet();
            Assert.That(driver.Url.Equals(url));
            petCreatePage.TypeName("Cat").TypeBitrhDate("2021.11.30").SelectType("cat").SavePet();
            Assert.That(!driver.Url.Equals(url));
        }

        [Test, Description("This test checks the new visit adding")]
        [AllureSuite("Pet")]
        public void Testaddnewvisit()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector(".petOwner:nth-child(467) a")).Click();
            string url = driver.Url;
            js.ExecuteScript("window.scrollTo(0,0)");
            driver.FindElement(By.CssSelector(".addNewVisit")).Click();
            driver.FindElement(By.Name("date")).Click();
            driver.FindElement(By.Name("date")).SendKeys("2021/11/14");
            driver.FindElement(By.Id("description")).Click();
            driver.FindElement(By.Id("description")).Click();
            driver.FindElement(By.Id("description")).SendKeys("visit");
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            Assert.That(!driver.Url.Equals(url));
        }

        [Test, Description("This test checks create visit form validation")]
        [AllureSuite("Pet")]
        public void Testaddnewvisitformvalidation()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.Close();
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector(".petOwner:nth-child(467) a")).Click();
            js.ExecuteScript("window.scrollTo(0,0)");
            driver.FindElement(By.CssSelector(".addNewVisit")).Click();
            string url = driver.Url;
            driver.FindElement(By.CssSelector("path")).Click();
            driver.FindElement(By.CssSelector(".mat-calendar-body-today")).Click();
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Id("description")).Click();
            driver.FindElement(By.Id("description")).SendKeys("yyjkjlkl");
            driver.FindElement(By.Name("date")).Click();
            driver.FindElement(By.Name("date")).SendKeys("2021/11/31");
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Name("date")).Click();
            driver.FindElement(By.Name("date")).SendKeys("2021/11/30");
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            Assert.That(!driver.Url.Equals(url));
        }
    }
}
