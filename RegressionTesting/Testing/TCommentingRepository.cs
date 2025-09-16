using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegressionTesting;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class TCommentingRepository
    {
        [TestMethod]
        public void TestAddComment()
        {
            var repository = new CommentingRepository();

            User user_1 = new User { Id = 1, Username = "Pavel" };
            repository.AddComment("Привет!", user_1);
            repository.AddComment("Как дела?", user_1);

            User user_2 = new User { Id = 2, Username = "Sasha" };
            repository.AddComment("Невероятно.", user_2);
            repository.AddComment("Отлично!", user_2);
            repository.AddComment("Привет!", user_2);

            User user_3 = new User { Id = 3, Username = "Vlad" };
            repository.AddComment("Круто!", user_3);
            repository.AddComment("Интересно.", user_3);
            repository.AddComment("Спасибо!", user_3);

            var actual = repository.GetComments();

            Dictionary<User, List<string>> expected = new Dictionary<User, List<string>>
            {
                {
                    user_1,
                    new List<string> { "Привет!", "Как дела?" }
                },
                {
                    user_2,
                    new List<string> { "Невероятно.", "Отлично!", "Привет!" }
                },
                {
                    user_3,
                    new List<string> { "Круто!", "Интересно.", "Спасибо!" }
                }
            };

            Assert.AreEqual(expected.Count, actual.Count, "Количество пользователей не совпадает.");

            CollectionAssert.AreEqual(expected.Keys, actual.Keys, "Списки пользователей не совпадают.");

            foreach (var user in expected.Keys)
            {
                CollectionAssert.AreEqual(expected[user], actual[user], $"Комментарии пользователя {user.Username} не совпадают.");
            }
        }

        [TestMethod]
        public void TestGetCommentsByUser()
        {
            var repository = new CommentingRepository();

            User user_1 = new User { Id = 1, Username = "Max" };
            repository.AddComment("Пока.", user_1);
            repository.AddComment("Удачи!", user_1);
            repository.AddComment("", user_1);

            User user_2 = new User { Id = 2, Username = "Alex" };
            repository.AddComment("Великолепно!", user_2);
            repository.AddComment("Замечательно.", user_2);
            repository.AddComment(null, user_2);
            repository.AddComment("Привет.", user_2);

            var actual_1 = repository.GetCommentsByUser(user_1);
            List<string> expected_1 = new List<string> { "Пока.", "Удачи!" };
            CollectionAssert.AreEqual(expected_1, actual_1, "Список комментариев пользователя Max не совпадает.");

            var actual_2 = repository.GetCommentsByUser(user_2);
            List<string> expected_2 = new List<string> { "Великолепно!", "Замечательно.", "Привет." };
            CollectionAssert.AreEqual(expected_1, actual_1, "Список комментариев пользователя Alex не совпадает.");
        }
    }
}
    