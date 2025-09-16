using System.Collections.Generic;

namespace RegressionTesting
{
    public class CommentingRepository : ICommentingRepository
    {
        private Dictionary<User, List<string>> comments_ = new Dictionary<User, List<string>>();

        public string AddComment(string text, User user)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            if (!comments_.ContainsKey(user))
            {
                comments_[user] = new List<string>();
            }
            comments_[user].Add(text);

            return comments_[user][comments_[user].Count - 1];
        }
        
        public List<string> GetCommentsByUser(User user)
        {
            if (comments_.ContainsKey(user))
            {
                return comments_[user];
            }
            return null;
        }

        public Dictionary<User, List<string>> GetComments()
        {
            return comments_;
        }
    }
}
