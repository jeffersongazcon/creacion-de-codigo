using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.BLL
{
    public class ServicioLugarVotacion : ICrudLugarVotacion
    {
        static List<LugarVotacion> LugarVotacions = new List<LugarVotacion>();
        static bool flag=false;
        public ServicioLugarVotacion()
        {
            //LugarVotacions  = new List<LugarVotacion>();
            //loadData();
        }
        public void loadData()
        {
            if (!flag)
            {
                LugarVotacions.Add(new LugarVotacion()
                {
                    Id = "1",
                    Descripcion = "garupal",
                    Ubicacion = "calle unica"
                });
                LugarVotacions.Add(new LugarVotacion()
                {
                    Id = "2",
                    Descripcion = "nevada",
                    Ubicacion = "calle dos"
                });
                flag = true;
            }
        }
        public string Add(LugarVotacion lugar)
        {


            try
            {
                //validaciones pertienetes
                LugarVotacions.Add(lugar);
                return $"Lugar de votacion registrado {lugar.Descripcion}";
            }
            catch (Exception)
            {

                return "error al agregar el lugar de votacion";
            }
            //return "datos cargados";
        }

        public string Delete(LugarVotacion lugar)
        {
            if (LugarVotacions.Count == 0 || LugarVotacions == null)
            {
                return "no hay lugar de votacion para eliminar";
            }

            if (GetById(lugar.Id) != null)
            {
                LugarVotacions.Remove(lugar);
                return "eliminado";
            }

            return "no existe el lugar de votacion";
        }

        public LugarVotacion GetById(string Id)
        {
            foreach (var item in LugarVotacions)
            {
                if (item.Id == Id)
                {
                    return item;
                }   
            }
            return null;
        }

        public  List<LugarVotacion> GetAll()
        {
            if (LugarVotacions != null || LugarVotacions.Count != 0)
            {
                return LugarVotacions;
            }
            return null;
        }

        public string Update(LugarVotacion lugar)
        {
            var lugarX = GetById(lugar.Id);
            if (lugarX == null)
            {
                return "no hay Lugar para actualizar";
            }
            lugarX = lugar;
            return "ok, Lugar actualizado";
        }

        public List<LugarVotacion> GetUbicacion()
        {
            List<LugarVotacion> lista = new List<LugarVotacion>();
            foreach (var item in LugarVotacions)
            {
                if (item.Ubicacion.ToUpper() == "calle")
                {
                    lista.Add(item);
                }
                if (item.Ubicacion.ToUpper() == "carrera")
                {
                    lista.Add(item);
                }
            }

            return lista;
        }
    }
}
