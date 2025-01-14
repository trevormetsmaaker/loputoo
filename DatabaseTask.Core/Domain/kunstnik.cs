using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class kunstnik
    {
        [Key]
        public string EesNimi { get; set; }
        public string PereNimi { get; set; }

        public int Telnr { get; set; }
        public string Email { get; set; }
        public string Aadress { get; set; }
    }
}
