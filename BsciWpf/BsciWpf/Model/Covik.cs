using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsciWpf.Model
{
    public class Covik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public Covik()
        {
            Id = 1;
            Ime = "Rota";
        }
    }
}
