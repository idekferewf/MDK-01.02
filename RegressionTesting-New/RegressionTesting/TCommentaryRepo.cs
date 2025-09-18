using Commantary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RegressionTesting
{
    [TestClass]
    public class TCommentaryRepo
    {
        [TestMethod]
        public void TestSaveComment()
        {
            var repo = new CommentaryRepo();

            List<string> vasyaComments = 
                new List<string>() { "Привет, я Вася!" ,
                                     "Привет, я не хочу быть Васей!"};

            List<string> marinaComments =
                        new List<string>() { "Все отлично, я ухожу!"};

            repo.SaveComment("Вася", vasyaComments[0]);
            repo.SaveComment("Вася", vasyaComments[1]);
            repo.SaveComment("Марина", marinaComments[0]);

            var data = repo.GetAllCommentaries();

            Dictionary<string, List<string>> expected = 
                new Dictionary<string, List<string>>()
                 { { "Вася", vasyaComments }, { "Марина", marinaComments } };

            CollectionAssert.AreEqual(expected.Keys, data.Keys);

            foreach(string key in  expected.Keys)
            {
                List<string> expectedValue = expected[key];
                List<string> actualValue = data[key];

                CollectionAssert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
