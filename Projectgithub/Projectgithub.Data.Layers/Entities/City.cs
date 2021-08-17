using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgithub.Data.Layers.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
