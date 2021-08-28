using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabradogApp.Models
{
    public class ReviewBlog:BaseEntity
    {
        public int BlogId { get; set; }
        public string UserId { get; set; }

        public int Rate { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public Blog Blog { get; set; }
        public User User { get; set; }
    }
}
