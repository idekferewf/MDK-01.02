namespace RegressionTesting
{
    public class CommentingManager
    {
        private readonly ICommentingRepository commentingRepository_;

        public CommentingManager(ICommentingRepository commentingRepository)
        {
            commentingRepository_ = commentingRepository;
        }

        public string AddComment(string text, User user)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }
            string comment = commentingRepository_.AddComment(text, user);
            return comment;
        }
    }
}
