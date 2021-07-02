using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookieShop.Backend.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string CommentContent { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public virtual User  User { get; set; }
        public virtual Product Product { get; set; }

    }
}
