using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMB_Desktop.ViewModel;

namespace testOMB.Desktop
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginFallidoSinUsuario()
        {   
            LoginViewModel lvm = new LoginViewModel();
            bool evento=false;
            lvm.Password = "123456";
            lvm.LoginID = "";
            
            lvm.FaltanDatos.Raised += (s,a) => 
            {
                evento = true;
            };
            lvm.LoginCommand.Execute(null);
            Assert.IsTrue(evento);
        }
        /*
        public void LoginFallidoSinPassword()
        {
            LoginViewModel lvm = new LoginViewModel();
            bool evento = false;
            lvm.Password = null;
            lvm.LoginID = "ethedy";
            lvm.LoginCommand.Execute(null);
            lvm.FaltanDatos.Raised += (s, a) =>
            {
                evento = true;
            };

            Assert.IsTrue(evento);
        }
        */
    }
}
