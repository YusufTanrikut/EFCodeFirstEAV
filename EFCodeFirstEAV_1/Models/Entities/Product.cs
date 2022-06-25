using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEAV_1.Models.Entities
{
    public class Product:BaseEntity
    {
        //List olan yapılar her zaman veri gönderen taraftır... Tekil olan taraf da veriyi alan taraftır...


        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Category Category { get; set; }


    }
}
