using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace FrameworkAmazon
{
    public class Utilities
    {
        public static void wait(int time)
        {
           Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(time));
            //Thread.Sleep(time);
        }

        public static void EnterText(string element, string value, string ElementType)
        {
            if (ElementType == "Class")
            {
                Driver.Instance.FindElement(By.ClassName(element)).SendKeys(value);
            }
            else if (ElementType == "Id")
            {
                Driver.Instance.FindElement(By.Id(element)).SendKeys(value);

            }
            else if (ElementType == "Name")
            {
                Driver.Instance.FindElement(By.Name(element)).SendKeys(value);


            }
        }

        public static void Click(string element, string ElementType)
        {
            if (ElementType == "Class")
            {
                Driver.Instance.FindElement(By.ClassName(element)).Click();
            }
            else if (ElementType == "Id")
            {
                Driver.Instance.FindElement(By.Id(element)).Click();

            }
            else if (ElementType == "Name")
            {
                Driver.Instance.FindElement(By.Name(element)).Click();
            }
            else if (ElementType == "LinkText")
            {
                Driver.Instance.FindElement(By.LinkText(element)).Click();
            }
        }

        public static void DropDown(string element, string ElementType,string value)
        {
            if (ElementType == "Class")
            {
                new SelectElement(Driver.Instance.FindElement(By.ClassName(element))).SelectByText(value);
            }
            else if (ElementType == "Id")
            {
                new SelectElement(Driver.Instance.FindElement(By.Id(element))).SelectByText(value);

            }
            else if (ElementType == "Name")
            {
                new SelectElement(Driver.Instance.FindElement(By.Name(element))).SelectByText(value);
            }
            else if (ElementType == "LinkText")
            {
                new SelectElement(Driver.Instance.FindElement(By.LinkText(element))).SelectByText(value);
            }
        }



        public static IWebElement FindElements(string element, string ElementType,int pos)
        {
            IWebElement ele = null;

            if (ElementType == "Class")
            {
               ele = Driver.Instance.FindElements(By.ClassName(element))[pos];
            }
            else if (ElementType == "Id")
            {
                ele = Driver.Instance.FindElements(By.Id(element))[pos];

            }
            else if (ElementType == "Name")
            {
               ele=  Driver.Instance.FindElements(By.Name(element))[pos];
            }
            else if (ElementType == "LinkText")
            {
               ele =  Driver.Instance.FindElements(By.LinkText(element))[pos];
            }
            return ele;
        }
    }
}