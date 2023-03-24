using CMSPlus.Domain.Models.TopicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModels
{
    public class CommentCreateModel: BaseCommentModel
    {
        [Required(ErrorMessage = "Comment is required.")]
        [MaxLength(500, ErrorMessage = "Your comments is too long.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Full name is required.")]
        [MaxLength(50, ErrorMessage = "Your name is too long.")]
        public string FullName { get; set; }
        [Required]
        public int TopicId { get; set; }

    }
}
