using AppVotacion.BLL;
using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.GUI
{
    public class LugarVotacionGUI
    {
        ServicioLugarVotacion ServicioLugarVotacion = new ServicioLugarVotacion();
        public LugarVotacionGUI()
        {
            //ServicioLugarVotacion = 
        }

        public void Agregar()
        {
            ServicioLugarVotacion.loadData();
        }
        public void ViewAdd()
        {
            LugarVotacion lugar = new LugarVotacion();

            Console.Write("Agregar ID: ");
            lugar.Id = Console.ReadLine();
            Console.Write("Descripcion: ");
            lugar.Descripcion = Console.ReadLine();
            Console.Write("Ubicacion: ");
            lugar.Ubicacion = Console.ReadLine();

            var mensaje = ServicioLugarVotacion.Add(lugar);

            Console.WriteLine(mensaje);
        }

        public void ViewUpdate()
        {

            string Id;

            Console.SetCursorPosition(3, 5); Console.Write("Id: ");
            Console.SetCursorPosition(11, 5); Id = Console.ReadLine();
            var lugar = ServicioLugarVotacion.GetById(Id);
            if (lugar != null)
            {
                Console.SetCursorPosition(3, 7); Console.Write($"ID: {lugar.Id}");
                //votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(3, 9); Console.Write($"Ubicacion: {lugar.Ubicacion}");
                //votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(3, 11); Console.Write($"Descripcion: {lugar.Descripcion}");
                //votante.Sexo = Console.ReadLine();

                Console.SetCursorPosition(7, 7); lugar.Id = Console.ReadLine();
                Console.SetCursorPosition(14, 9); lugar.Ubicacion = Console.ReadLine();
                Console.SetCursorPosition(16, 11); lugar.Descripcion = Console.ReadLine();

                var mensaje = ServicioLugarVotacion.Update(lugar);

                Console.WriteLine(mensaje);
            }
        }

        public void ViewDelete()
        {
            LugarVotacion lugar;
            string Id;
            Console.Write("Id: ");
            Id = Console.ReadLine();
            lugar = ServicioLugarVotacion.GetById(Id);
            if (lugar != null)
            {
                Console.WriteLine($"ID: {lugar.Id}");
                Console.WriteLine($"Ubicacion: {lugar.Ubicacion}");
                Console.WriteLine($"Descripcion: {lugar.Descripcion}");
                //validacion de confirmacion estas seguro ??
                Console.ReadKey();
                var mensaje = ServicioLugarVotacion.Delete(lugar);

                Console.WriteLine(mensaje);
                return;
            }
            Console.WriteLine("Lista sin Lugares");
        }

        public void GetAll()
        {
            Visualizer(ServicioLugarVotacion.GetAll());
        }
        public void GetUbicacion()
        {
            Visualizer(ServicioLugarVotacion.GetUbicacion());
        }

        private void Visualizer(List<LugarVotacion> lista)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("Id");
            Console.SetCursorPosition(15, 7); Console.Write("Ubicacion");
            Console.SetCursorPosition(28, 7); Console.Write("Descripcion");
            Console.SetCursorPosition(5, 8); Console.Write("--------------------------------------------------------");

            int i = 0;
            foreach (var item in lista)
            {
                Console.SetCursorPosition(5, 9 + i); Console.Write(item.Id);
                Console.SetCursorPosition(15, 9 + i); Console.Write(item.Ubicacion);
                Console.SetCursorPosition(28, 9 + i); Console.Write(item.Descripcion);
                //Console.SetCursorPosition(5, 10+i); Console.Write("----------------------------------------------------------------");
                i++;
            }
            //foreach (var item in lista2)
            //{
            //    Console.SetCursorPosition(52, 9 + i); Console.Write(item.Descripcion);
            //}
            Console.SetCursorPosition(5, 12 + i); Console.Write("--------------------------------------------------------");
            Console.ReadKey();
        }

        public void Load()
        {
            ServicioLugarVotacion.loadData();
        }
    }
}
