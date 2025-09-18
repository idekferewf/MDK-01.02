using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Commantary
{
    public class CommentaryManager
    {
        private ICommentaryRepository repo_;
        public CommentaryManager(ICommentaryRepository repo) 
        {
            repo_ = repo;
        }

        public List<string> GetUserComments(string login)
        {
            var data = repo_.GetAllCommentaries();
            if(data.ContainsKey(login))
            {
                return data[login];
            }

            return new List<string>();
        }

        public void AddComment(string login, string comment)
        {
            List<string> userComments = GetUserComments(login);
            if (userComments.Count == 0)
            {
                repo_.SaveComment(login, comment);
                return;
            }


            int index = userComments.IndexOf(comment);
            if (index == -1)
            {
                repo_.SaveComment(login, comment);
            }
        }

        public List<string> SearchUserCommentsByTemplate(string login, string template)
        {
            List<string> userComments = GetUserComments(login);
            List<string> result = new List<string>();

            foreach (string comment in userComments)
            {
                if (comment.Contains(template))
                {
                    result.Add(comment);
                }
            }

            return result;
        }
    }
}
