using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using Logic.Classes;
using UnitTest.DALTest;
using Interface.DTO;

namespace UnitTest.Container
{
    [TestClass]
    public class UserContainerTest
    {
        [TestMethod]
        public void attemptLogin_Test()
        {
            UserContainer userContainer = new UserContainer(new user());
            UserDTO userdto = new UserDTO() { Naam = "test", Wachtwoord = "123" };
            User user = new User(userdto);
            Assert.AreEqual(userContainer.attemptLogin(user), true);
            
        }
    }
}
