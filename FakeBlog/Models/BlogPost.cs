using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostId { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }  
              
        public DateTime CreationDate { get; set; } //Required by default
        public DateTime PublishedDate { get; set; }
        public string Content { get; set; }
        public bool IsDraft { get; set; }
        public bool Edited { get; set; }
        public string URL { get; set; }


    }
}