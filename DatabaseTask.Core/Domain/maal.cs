using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class maal
    {
        [Key]
        public string Nimi { get; set; }
        public int Hind { get; set; }

        public string Tuup { get; set; }
        public string Autor { get; set; }
        public int Aasta { get; set; }
        public string Paritolu { get; set; }
    }
}
