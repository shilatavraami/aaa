using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date  { get; set; }
        public int userId { get; set; }
        [ForeignKey("userId")]
        public virtual User user { get; set; }
    }
}
