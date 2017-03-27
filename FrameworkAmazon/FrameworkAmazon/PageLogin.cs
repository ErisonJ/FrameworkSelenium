using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace FrameworkAmazon
{
    public class PageLogin
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://www.amazon.com");
            Utilities.Click("nav-link-accountList", "Id");
        }

        public static void LoginAs(string user, string pass)
        {
            Utilities.EnterText("email", user, "Name");
            Utilities.EnterText("password", pass, "Name");
            Utilities.Click("signInSubmit", "Id");
        }
    }
}
