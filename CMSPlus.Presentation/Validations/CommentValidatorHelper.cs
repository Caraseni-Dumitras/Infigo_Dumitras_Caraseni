using CMSPlus.Services.Interfaces;
using CMSPlus.Services.Services;

namespace CMSPlus.Presentation.Validations
{
    public class CommentValidatorHelper
    {
        private readonly ICommentService _commentService;

        public CommentValidatorHelper(ICommentService commentService)
        {
            _commentService = commentService;
        }
    }
}
