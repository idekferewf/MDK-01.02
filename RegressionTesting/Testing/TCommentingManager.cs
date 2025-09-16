using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegressionTesting;

namespace Testing
{
    [TestClass]
    public class TCommentingManager
    {
        [TestMethod]
        public void TestAddComment_Valid()
        {
            var mock = new Mock<ICommentingRepository>();

            User user = new User { Id = 1, Username = "Slava" };

            mock
                .Setup(r => r.AddComment("Привет!", user))
                .Returns("Привет!");

            var manager = new CommentingManager(mock.Object);

            string actual = manager.AddComment("Привет!", user);

            Assert.AreEqual("Привет!", actual);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void TestAddComment_Invalid(string text)
        {
            var mock = new Mock<ICommentingRepository>();

            User user = new User { Id = 1, Username = "Pavel" };

            mock
                .Setup(r => r.AddComment(text, user))
                .Returns((string)null);

            var manager = new CommentingManager(mock.Object);

            string actual = manager.AddComment(text, user);

            Assert.AreEqual(null, actual);
        }
    }
}
