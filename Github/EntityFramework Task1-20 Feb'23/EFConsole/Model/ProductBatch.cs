using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFConsole.Model
{
    internal class ProductBatch
    {
        [Key]
        public int BatchID { get; set; }
        [StringLength(50)]
        public string ?Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [ForeignKey("ProductFK")]
        public Product ?product { get; set; }
    }
}
