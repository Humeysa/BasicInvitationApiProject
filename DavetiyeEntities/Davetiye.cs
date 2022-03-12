using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeEntities
{
    public class Davetiye
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool KatilmaDurumu { get; set; }

    }
}
