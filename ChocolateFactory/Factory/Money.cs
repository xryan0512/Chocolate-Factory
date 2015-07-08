using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Factory
{
    public class Money
    {
        public Money()
        {
            mount = 0;
            oweMoney = 0;
            Date = DateTime.Today;
        }
        
        [Key]
        public int id { get; set; }
        [ForeignKey("IdMoney")]
        private PersonProfile person { get; set; }
        public int IdMoney { get; set; }

        public int mount { get; set; }
        public int oweMoney { get; set; }
        public DateTime Date { get; set; }
    }
}
