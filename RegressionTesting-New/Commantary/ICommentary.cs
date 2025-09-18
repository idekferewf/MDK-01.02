using System.Collections.Generic;

namespace Commantary
{
    public interface ICommentaryRepository
    {

        void SaveComment(string login, string text);

        Dictionary<string, List<string>> GetAllCommentaries();
    }
}
