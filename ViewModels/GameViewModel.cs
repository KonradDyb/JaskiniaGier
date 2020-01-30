using JaskiniaGier.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.ViewModels
{
    public class GameViewModel
    {
        public IEnumerable<Game> Games { get; set; }
    }
}
