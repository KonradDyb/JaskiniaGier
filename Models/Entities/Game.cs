﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Models.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string GameDescription { get; set; }
        public string ImagePath { get; set; }
        public string Price { get; set; }
        public SubGenre SubGenre { get; set; }
    }
}