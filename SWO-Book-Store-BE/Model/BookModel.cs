using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO_Book_Store_BE.Model
{
    public class BookModel
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string category { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string item { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string unit { get; set; }
        public int price { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string image { get; set; }
    }
}
