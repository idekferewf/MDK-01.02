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
        [DataRow("pavel", "1234")]
        [DataRow("sasha", "sasha1#$2")]
        [DataRow("admin", "admin123")]
        public void TestLoginUserr_Valid_Credentials(string username, string password)
        {
            var mock = new Mock<IUserRepository>();

            mock
                .Setup(r => r.LoginUser(username, password))
                .Returns(new User { username = username, password = password });

            var service = new AuthService(mock.Object);

            bool isLogin = service.LoginUser(username, password);

            Assert.IsTrue(isLogin);

            mock.Verify(r => r.LoginUser(username, password), Times.Once);
        }

        [TestMethod]
        [DataRow("pavel", "invalid")]
        [DataRow("invalid", "1234")]
        [DataRow("", "")]
        [DataRow(null, "1234")]
        [DataRow(null, null)]
        [DataRow("1234", null)]
        public void TestLoginUser_Invalid_Credentials(string username, string password)
        {
            var mock = new Mock<IUserRepository>();

            mock
                .Setup(r => r.LoginUser(username, password))
                .Returns((User)null);

            var service = new AuthService(mock.Object);

            bool isLogin = service.LoginUser(username, password);

            Assert.IsFalse(isLogin);

            mock.Verify(r => r.LoginUser(username, password), Times.Once);
        }
    }
}
