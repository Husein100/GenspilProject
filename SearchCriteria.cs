using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    internal class SearchCriteria
    {

        private string? name { get; set; }
        private string? genre { get; set; }
        private int? minPlayers { get; set; }
        private int? maxPlayers { get; set; }
        private string? condition { get; set; }
        private double? minPrice { get; set; }
        private double? maxPrice { get; set; }
        private bool? inquiry { get; set; }
    }
}
