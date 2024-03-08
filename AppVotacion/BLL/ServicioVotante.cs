using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.BLL
{
    public class ServicioVotante : ICrud
    {
         List<Votante> votantes;
        public ServicioVotante()
        {
                votantes = new List<Votante>();
        }
        public string Add(Votante votante)
        {
            try
            {
                //validaciones pertienetes
                votantes.Add(votante);
                return $"votante registrado {votante.Nombre}";
            }
            catch (Exception)
            {

                return "error al agregar el votante";
            }
        }

        //public string AddLugar(LugarVotacion Lugar)
        //{
        //    try
        //    {
        //        LugarVotante.Add(Lugar);
        //        return $"votante registrado en :{Lugar.Descripcion}";
        //    }
        //    catch (Exception)
        //    {

        //        return "error al agregar el Lugar de votacion";
        //    }
        //}

        //public List<LugarVotacion> GetLugar()
        //{
        //    if (LugarVotante != null || LugarVotante.Count != 0)
        //    {
        //        return LugarVotante;
        //    }
        //    return null;
        //}


        public Votante GetByCedula(string cedula)
        {
           foreach (var item in votantes)
            {
                if (item.Cedula ==cedula )                 
                {
                    return item;
                }
            }
           return null;
        }
        public string Delete(Votante votante)
        {
            if (votantes.Count == 0 || votante==null)
            {
                return "no hay votantes para eliminar";
            }

            if (GetByCedula(votante.Cedula) != null)
            {
                votantes.Remove(votante);
                return "eliminado";
            }
            
            return "no existe el votante";
        }

        public List<Votante> GetAll()
        {
            if (votantes != null || votantes.Count!=0)
            {
                return votantes;
            }
            return null;
        }

        public string Update(Votante votante)
        {
            var votanteX= GetByCedula(votante.Cedula);
            if (votanteX == null)
            {
                return "no hay Votante para actualizar";
            }
            votanteX = votante;
            return "ok, actualizado";

        }
        public List <Votante> GetWoman() 
        {
            List<Votante> lista= new List<Votante>();
            foreach (var item in votantes)
            {
                if ( item.Sexo.ToUpper()=="F")
                {
                    lista.Add(item);
                }
            }

            return lista;
        }
    }
}
