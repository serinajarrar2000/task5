using System.ComponentModel.DataAnnotations;
namespace WebApplication64
{   public class company
        {
        [Key]
            public int id { get; set; }
            public string location { get; set; }= String.Empty;
            public string name { get; set; }

        public ICollection<employee>? employee { get; set; }
        }
    }

