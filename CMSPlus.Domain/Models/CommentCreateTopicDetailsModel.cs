using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Domain.Models.TopicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models
{
    public class CommentCreateTopicDetailsModel
    {
        public TopicDetailsModel TopicDetails { get; set; }
        public CommentCreateModel CommentCreateModel { get; set; }
    }
}
