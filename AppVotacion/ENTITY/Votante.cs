using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.ENTITY
{
    public class Votante : Persona
    {
        public Votante() : base() { }

        public string LugarVotacionId { get; set; }
    }
}

