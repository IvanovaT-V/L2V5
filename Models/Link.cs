using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace L2V5.Models
{
    public class Link
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

    }
}
