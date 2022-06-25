using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEAV_1.Models.Entities
{
    public class EntityAttribute:BaseEntity
    {
        public string Title { get; set; }

        //Relational Properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }

    }
}
