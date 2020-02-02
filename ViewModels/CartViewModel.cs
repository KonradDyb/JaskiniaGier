using JaskiniaGier.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal CartTotal { get; set; }
    }
}
