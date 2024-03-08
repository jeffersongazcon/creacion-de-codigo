using AppVotacion.BLL;
using AppVotacion.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.GUI
{
    public class VotanteGUI
    {
        ServicioVotante servicioVotante = null;
        public VotanteGUI()
        {
            servicioVotante = new ServicioVotante();
        }
        public void ViewAdd()
        {
            Votante votante = new Votante();

            Console.Write("Cedula: ");
            votante.Cedula = Console.ReadLine();
            Console.Write("Nombres: ");
            votante.Nombre = Console.ReadLine();
            Console.Write("Telefono: ");
            votante.Telefono = Console.ReadLine();
            Console.Write("Sexo: ");
            votante.Sexo = Console.ReadLine();
            Console.Write("Edad: ");
            votante.Edad = Convert.ToInt16(Console.ReadLine());

            Console.Write("ID del lugar de votación: ");
            votante.LugarVotacionId = Console.ReadLine();

            var mensaje = servicioVotante.Add(votante);

            Console.WriteLine(mensaje);
        }

        public void AddVotingLocation()
        {
            Console.WriteLine("Agregar lugar de votación al votante:");
            Console.Write("Cédula del votante: ");
            string cedula = Console.ReadLine();

            
            var votante = servicioVotante.GetByCedula(cedula);

            if (votante != null)
            {
                Console.Write("ID del lugar de votación: ");
                string lugarVotacionId = Console.ReadLine();

                // Asociar el ID del lugar de votación con el votante
                votante.LugarVotacionId = lugarVotacionId;

                // Actualizar el votante con el nuevo lugar de votación
                var mensaje = servicioVotante.Update(votante);

                Console.WriteLine(mensaje);
            }
            else
            {
                Console.WriteLine("Votante no encontrado.");
            }
        }



        public void ViewUpdate()
        {

            string cedula;

            Console.SetCursorPosition(3, 5); Console.Write("Cedula: ");
            Console.SetCursorPosition(11, 5); cedula = Console.ReadLine();
            var votante = servicioVotante.GetByCedula(cedula);
            if (votante != null)
            {
                Console.SetCursorPosition(3, 7); Console.Write($"Nombres: {votante.Nombre}");
                //votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(3, 9); Console.Write($"Telefono: {votante.Telefono}");
                //votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(3, 11); Console.Write($"Sexo: {votante.Sexo}");
                //votante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(3, 13); Console.Write($"Edad: {votante.Edad}");
                //votante.Edad = Convert.ToInt16(Console.ReadLine());

                Console.SetCursorPosition(12, 7); votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(13, 9); votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(9, 11); votante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(9, 13); votante.Edad = int.Parse(Console.ReadLine());

                var mensaje = servicioVotante.Update(votante);
                Console.WriteLine(mensaje);
            }
        }

        public void ViewDelete()
        {
            Votante votante;
            string cedula;
            Console.Write("Cedula: ");
            cedula = Console.ReadLine();
            votante= servicioVotante.GetByCedula(cedula);
            if (votante != null)
            {
                Console.WriteLine($"Nombres: {votante.Nombre}");
                Console.WriteLine($"Telefono: {votante.Telefono}");
                Console.WriteLine($"Sexo: {votante.Sexo}");
                Console.WriteLine($"Edad: {votante.Edad}");

                //validacion de confirmacion estas seguro ??
                Console.ReadKey();
                var mensaje = servicioVotante.Delete(votante);

                Console.WriteLine(mensaje);
                return;
            }
            Console.WriteLine("Lista sin votantes");
        }
        public void GetWoman()
        {
            Visualizer(servicioVotante.GetWoman());
        }

        // lopez es un tonto(baka)
        public void GetAll()
        {
            var listaVotantes = servicioVotante.GetAll();
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("Cedula");
            Console.SetCursorPosition(15, 7); Console.Write("Nombres");
            Console.SetCursorPosition(28, 7); Console.Write("Telefono");
            Console.SetCursorPosition(38, 7); Console.Write("Sexo");
            Console.SetCursorPosition(45, 7); Console.Write("Edad");
            Console.SetCursorPosition(60, 7); Console.Write("Lugar de votacion");
            Console.SetCursorPosition(5, 8); Console.Write("----------------------------------------------------------------");

            int i = 0;
            foreach (var votante in listaVotantes)
            {
                string lugarVotacionInfo = string.Empty;

                if (!string.IsNullOrEmpty(votante.LugarVotacionId))
                {
                    var servicioLugarVotacion = new ServicioLugarVotacion();
                    var lugarVotacion = servicioLugarVotacion.GetById(votante.LugarVotacionId);

                    if (lugarVotacion != null)
                    {
                        lugarVotacionInfo = $"{lugarVotacion.Descripcion} ({lugarVotacion.Ubicacion})";
                    }
                }

                Console.SetCursorPosition(5, 9 + i); Console.Write(votante.Cedula);
                Console.SetCursorPosition(15, 9 + i); Console.Write(votante.Nombre);
                Console.SetCursorPosition(28, 9 + i); Console.Write(votante.Telefono);
                Console.SetCursorPosition(38, 9 + i); Console.Write(votante.Sexo);
                Console.SetCursorPosition(45, 9 + i); Console.Write(votante.Edad);
                Console.SetCursorPosition(60, 9 + i); Console.Write(lugarVotacionInfo);
                i++;
            }

            Console.SetCursorPosition(5, 12 + i); Console.Write("----------------------------------------------------------------");
            Console.ReadKey();
        }




        private void Visualizer(List<Votante> lista)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("cedula");
            Console.SetCursorPosition(15, 7); Console.Write("Nombres");
            Console.SetCursorPosition(28, 7); Console.Write("Telefono");
            Console.SetCursorPosition(38, 7); Console.Write("Sexo");
            Console.SetCursorPosition(45, 7); Console.Write("Edad");
            Console.SetCursorPosition(52, 7); Console.Write("Lugar de votacion");
            Console.SetCursorPosition(5, 8); Console.Write("----------------------------------------------------------------");
            int i = 0;
            foreach (var item in lista)
            {
                    Console.SetCursorPosition(5, 9 + i); Console.Write(item.Cedula);
                    Console.SetCursorPosition(15, 9 + i); Console.Write(item.Nombre);
                    Console.SetCursorPosition(28, 9 + i); Console.Write(item.Telefono);
                    Console.SetCursorPosition(38, 9 + i); Console.Write(item.Sexo);
                    Console.SetCursorPosition(45, 9 + i); Console.Write(item.Edad);
                    //Console.SetCursorPosition(5, 10+i); Console.Write("----------------------------------------------------------------");
                    i++;                
            }
            //foreach (var item in lista2)
            //{
            //    Console.SetCursorPosition(52, 9 + i); Console.Write(item.Descripcion);
            //}
            Console.SetCursorPosition(5, 12+i); Console.Write("----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
