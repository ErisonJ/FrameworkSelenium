using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameworkAmazon;

namespace TestPage
{
    [TestClass]
   public class SearchingItem
    {

            [TestInitialize]
            public void Init()
            {
                Driver.Initialize();
            }

            [TestMethod]
            public void Find_Out_Items()
            {
                PageLogin.GoTo();
                PageLogin.LoginAs(Inputs.email, Inputs.pass);

                ItemsPage.SearchItem(Inputs.article);
                ItemsPage.SelectItem();
                ItemsPage.AddingToCart();
                

            }



        }
 }

