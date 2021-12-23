using OpenQA.Selenium;
using NUnit.Framework;

namespace TestProject1
{
    public class TestCases : Base
    {
        [Test]
        public void Mainpage()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".navbar-brand > span")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/"));
        }

        [Test]
        public void Addnewowner()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Anatolii");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Kyiashenko");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(4)")).Click();
            driver.FindElement(By.Id("address")).SendKeys("street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Zhytomyr");
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("0675060600");
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners"));
        }

        [Test]
        public void Addnewownerwithemptyfield()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Анатолий");
            driver.FindElement(By.Id("lastName")).SendKeys("Кияшенко");
            driver.FindElement(By.Id("address")).SendKeys("Князей Острожских 1, 166");
            driver.FindElement(By.Id("city")).SendKeys("Житомир");
            driver.FindElement(By.Id("telephone")).SendKeys("0675060694");
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("0675060694");
            driver.FindElement(By.CssSelector(".xd-container")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(5)")).Click();
            driver.FindElement(By.Id("city")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".xd-container")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Житомир");
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.Id("address")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".form-horizontal")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("Князей Острожских 1, 166");
            driver.FindElement(By.CssSelector(".xd-container")).Click();
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".form-horizontal")).Click();
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Кияшенко");
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(2)")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Анатолий");
            driver.FindElement(By.CssSelector("app-owner-add > .container-fluid")).Click();
        }

        [Test]
        public void Addnewownerwithwrongformat()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Анатолий");
            driver.FindElement(By.Id("lastName")).SendKeys("Кияшенко");
            driver.FindElement(By.Id("address")).SendKeys("Князей Острожских 1, 166");
            driver.FindElement(By.Id("city")).SendKeys("Житомир");
            driver.FindElement(By.Id("telephone")).SendKeys("0675060694");
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(6)")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("dfgfgjhghj");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("df43434");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.CssSelector(".has-error")).Click();
            driver.FindElement(By.CssSelector(".has-error")).Click();
            driver.FindElement(By.CssSelector(".has-error")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("####");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.CssSelector(".has-error")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys(" ");
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners/add"));
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
        }

        [Test]
        public void Addnewownerwithjsinjection()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("alert(\"foo\");");
            driver.FindElement(By.Id("lastName")).SendKeys("alert(\"foo\");");
            driver.FindElement(By.Id("address")).SendKeys("alert(\"foo\");");
            driver.FindElement(By.Id("city")).SendKeys("alert(\"foo\");");
            driver.FindElement(By.Id("telephone")).SendKeys("0675060694");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("\\`-alert(\"foo\")-\\`;");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector(".form-group:nth-child(4) > .col-sm-10")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("\\\\`-alert(\"foo\")//\\`;");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.CssSelector(".col-sm-offset-2")).Click();
            driver.FindElement(By.Id("telephone")).Click();
            driver.FindElement(By.Id("telephone")).SendKeys("0675060600");
            driver.FindElement(By.CssSelector(".xd-container")).Click();
            driver.FindElement(By.CssSelector(".addOwner")).Click();
            Assert.That(driver.Url.Equals("http://20.50.171.10:8080/petclinic/owners"));
        }

        [Test]
        public void Addnewpet()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector(".petOwner:nth-child(470) a")).Click();
            string url = driver.Url;
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
            Assert.That(driver.Url.Equals(url));
        }

        [Test]
        public void Addnewpetwithemptyfield()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector(".petOwner:nth-child(467) a")).Click();
            driver.FindElement(By.CssSelector(".addNewPet")).Click();
            string url = driver.Url;
            driver.FindElement(By.CssSelector(".savePet")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("gdfsdfsd");
            driver.FindElement(By.CssSelector(".savePet")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Id("type")).Click();
            {
                var dropdown = driver.FindElement(By.Id("type"));
                dropdown.FindElement(By.XPath("//option[. = 'cat']")).Click();
            }
            driver.FindElement(By.CssSelector(".savePet")).Click();
            driver.FindElement(By.CssSelector("path")).Click();
            driver.FindElement(By.CssSelector(".cdk-overlay-backdrop")).Click();
            Assert.That(driver.Url.Equals(url));
        }

        [Test]
        public void Birthdatefieldvalidationonaddnewpetform()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
            driver.FindElement(By.CssSelector(".petOwner:nth-child(467) a")).Click();
            driver.FindElement(By.CssSelector(".addNewPet")).Click();
            string url = driver.Url;
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("Cat");
            driver.FindElement(By.Id("type")).Click();
            {
                var dropdown = driver.FindElement(By.Id("type"));
                dropdown.FindElement(By.XPath("//option[. = 'cat']")).Click();
            }
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).SendKeys("2021/11/31");
            driver.FindElement(By.CssSelector("app-pet-add > .container-fluid")).Click();
            driver.FindElement(By.CssSelector(".savePet")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).SendKeys("2021.11.31");
            driver.FindElement(By.CssSelector("body")).Click();
            driver.FindElement(By.CssSelector(".savePet")).Click();
            Assert.That(driver.Url.Equals(url));
            driver.FindElement(By.Name("birthDate")).Click();
            driver.FindElement(By.Name("birthDate")).SendKeys("2021.11.30");
            driver.FindElement(By.CssSelector(".savePet")).Click();
            Assert.That(!driver.Url.Equals(url));
        }

        [Test]
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

        [Test]
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
