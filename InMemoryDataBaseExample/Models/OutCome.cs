using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDataBaseExample.Models
{
    public class OutCome
    {
        [Key]
        public int OutComeId { get; set; }
        public int Value { get; set; }
        [ForeignKey]
        public int UserId;

    }
}
