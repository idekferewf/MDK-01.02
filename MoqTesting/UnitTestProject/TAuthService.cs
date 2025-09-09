using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TAuthService
    {
        [TestMethod]
        public void TestLoginUser_Valid_Credentials()
        {
            var mock = new Mock<IUserRepository>();

            mock
                .Setup(r => r.LoginUser("pavel", "1234"))
                .Returns(new User { username = "pavel", password = "1234"});

            mock
                .Setup(r => r.LoginUser("sasha", "sasha1#$2"))
                .Returns(new User { username = "sasha", password = "sasha1#$2" });

            var service = new AuthService(mock.Object);

            bool isLogin = service.LoginUser("pavel", "1234");

            Assert.IsTrue(isLogin);

            mock.Verify(r => r.LoginUser("pavel", "1234"), Times.Once);
        }
    }
}
