using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public int Position { get; set; }
        public string CreatedAt { get; set; }

        public Category()
        {

        }

        public Category(int catId, string name, string description, string image, int status, int position, string createdat)
        {
            CatId = catId;
            Name = name;
            Description = description;
            Image = image;
            Status = status;
            Position = position;
            CreatedAt = createdat;
        }
    }
}