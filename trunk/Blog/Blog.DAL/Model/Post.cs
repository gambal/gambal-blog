using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Blog.DAL.Model
{
    public class Post
    {
        [Key]
        public long Id { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
