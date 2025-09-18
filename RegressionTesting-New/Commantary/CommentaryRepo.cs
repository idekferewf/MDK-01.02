using System.Collections.Generic;

namespace Commantary
{
    public class CommentaryRepo : ICommentaryRepository
    {
        /// <summary>
        ///  ключ - логин пользователя, значение - комментарии
        /// </summary>
        private Dictionary<string, List<string>> comments_ = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> GetAllCommentaries()
        {
            return comments_;
        }

        public void SaveComment(string login, string text)
        {       
            if (comments_.ContainsKey(login))
            {
                comments_[login].Add(text);
            }
            else
            {
                comments_.Add(login, new List<string>() { text});
            }
        }


    }
}
