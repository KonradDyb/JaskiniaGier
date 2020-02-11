using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string OrderPlaced { get; set; }
        public decimal Total { get; set; }
    }
}
