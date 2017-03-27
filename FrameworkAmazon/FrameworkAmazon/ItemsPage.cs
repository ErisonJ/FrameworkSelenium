using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FrameworkAmazon
{
    public class ItemsPage
    {
        public static void SearchItem(string article)
        {
            Utilities.wait(10);
            Utilities.EnterText("twotabsearchtextbox", article, "Id");
            Utilities.Click("nav-input", "Class");
        }

        public static void SelectItem()
        {
        
            var elem = Utilities.FindElements("cfMarker", "Class", 3);
            elem.Click();
            Utilities.DropDown("native_dropdown_selected_size_name", "Id", "Medium");
            Utilities.DropDown("quantity", "Id", "2");
            Utilities.wait(10);
           
        }

        public static void AddingToCart()
        {
            
            Utilities.Click("add-to-cart-button", "Id");
            Utilities.wait(10);
           
           
        }

       
    }
}
