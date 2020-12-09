using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoreTz.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public IList<Category> Category { get; set; }
        public byte[] Images { get; set; }
        public DateTime? Time { get; set; }
    }
}
