using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.BLL
{
    public interface ICrud
    {
        string Add(Votante votante);
        string  Update(Votante votante);
        string Delete(Votante votante);
        List<Votante> GetAll();
    }
}
