using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace FrameworkAmazon
{
    public class FormPage
    {

        public static void GoToCheckOut()
        {
            //Thread.Sleep(1000);
            Utilities.Click("nav-cart","Id");
            //Thread.Sleep(1000);
            Utilities.Click("proceedToCheckout","Name");
            
        }

        public static void PersonalData(string name, string phone)
        {            
            Utilities.EnterText("enterAddressFullName",name,"Name");            
           Utilities.EnterText("enterAddressPhoneNumber",phone,"Name");           
        }

        public static void AddressData(string address, string zipcode)
        {
            
            Utilities.EnterText("enterAddressPostalCode",zipcode, "Name");
            Utilities.EnterText("enterAddressAddressLine1",address, "Name");
        }

        public static void LocationData(string city, string state, string country)
        {
            Utilities.EnterText("enterAddressCity",city, "Name");
            Utilities.EnterText("enterAddressStateOrRegion",state, "Name");
            Utilities.DropDown("enterAddressCountryCode", "Name", country);

        }

        public static void SendData()
        {
            Utilities.wait(10);
            Utilities.Click("shipToThisAddress", "Name");
        }
    }
}
