using FrameworkAmazon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPage
{

    [TestClass]
    public class shipping
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void FillOutInfo()
        {
            PageLogin.GoTo();
            PageLogin.LoginAs(Inputs.email, Inputs.pass);

            //Go To Check Out Page and fill Out the Form
            FormPage.GoToCheckOut();
            FormPage.PersonalData(Inputs.name, Inputs.phone);
            FormPage.AddressData(Inputs.address, Inputs.zipcode);
            FormPage.LocationData(Inputs.city, Inputs.state, Inputs.country);
            //FormPage.SendData();

        }
    }
}
