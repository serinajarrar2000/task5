using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication64
{
    public class employee
    {
        [Key]
            public int id { get; set; }
        public string name { get; set; } = String.Empty;
            public int age { get; set; }
            [ForeignKey ("company")]
            public int ? countryid { get; set; }
            public company? company { get; set; }

        }

    
}

