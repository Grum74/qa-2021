using OpenQA.Selenium;
using System.Drawing;
using System.Threading;

namespace TestProject1
{
    public static class Helpers
    {
        public static void ClearAndType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void Wait()
        {
            Thread.Sleep(5000);
        }

        public static Size SetSize()
        {
            return new System.Drawing.Size(1920, 1040);
        }
    }
}
