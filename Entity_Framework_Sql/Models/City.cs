using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Sql.Models
{
    internal class City:BaseEntity
    {
        [MaxLength]
        [Required]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }




    }
}
