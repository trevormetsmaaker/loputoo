using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class galerii
    {
        [Key]
        public string Nimi { get; set; }
        public string Aadress { get; set; }

        public int Lahtiolek { get; set; }
        public string Omanik { get; set; }
        public string Töötajad { get; set; }
        
    }
}
