using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameworkAmazon;


namespace TestPage
{
    [TestClass]
    public class TestLog
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Login()
        {
            //go to the login page and log In

            PageLogin.GoTo();
            PageLogin.LoginAs(Inputs.email, Inputs.pass);            
        }
       

    }
}
