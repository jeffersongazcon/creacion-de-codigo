using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.BLL
{
        public interface ICrudLugarVotacion
        {
            string Add(LugarVotacion lugar);
            string Update(LugarVotacion lugar);
            string Delete(LugarVotacion lugar);
            List<LugarVotacion> GetAll();
        }
 }

