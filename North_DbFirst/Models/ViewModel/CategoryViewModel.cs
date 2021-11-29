using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DbFirst.Models.ViewModel
{
    public class CategoryViewModel
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public int ProductionCount { get; set; } = 0;
    }
}
