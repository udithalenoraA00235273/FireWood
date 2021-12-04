using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FireWood.Models
{
    public class Services
    {
        [Key]
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }

    }
}
