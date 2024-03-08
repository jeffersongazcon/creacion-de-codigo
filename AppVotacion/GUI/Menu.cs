using AppVotacion.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.GUI
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            int op;
            do
            {
                System.Console.BackgroundColor = ConsoleColor.Gray;
                System.Console.ForegroundColor = ConsoleColor.Black;

                Console.Clear();
                Console.SetCursorPosition(20, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Gestion de votantes");
                Console.SetCursorPosition(18, 11); Console.Write("2. Gestion lugar de votacion");
                Console.SetCursorPosition(18, 15); Console.Write("3. Salir digite opcion : ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        GestionVotantes();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        GestionLugarVotacion();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 3);
        }

        public void GestionVotantes()
        {
            System.Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.ForegroundColor = ConsoleColor.Black;

            VotanteGUI votanteGUI = new VotanteGUI();
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 7); Console.Write("MENU VOTANTES");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar Votante");
                Console.SetCursorPosition(18, 11); Console.Write("2. Consulta General");
                Console.SetCursorPosition(18, 13); Console.Write("3. Eliminar por Cedula ");
                Console.SetCursorPosition(18, 15); Console.Write("4. Actualizar votante ");
                Console.SetCursorPosition(18, 16); Console.Write("5. agregar lugar de votacion");
                Console.SetCursorPosition(18, 17); Console.Write("6. salir");

                Console.SetCursorPosition(18, 19); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        votanteGUI.ViewAdd();
                        Console.ReadKey();
                        break;
                    case 2:
                        votanteGUI.GetAll();
                        break;
                    case 3:
                        Console.Clear();
                        votanteGUI.ViewDelete();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        votanteGUI.ViewUpdate();
                        Console.ReadKey();
                        break;
                    case 5:
                        // Nueva opción para agregar lugar de votación
                        Console.Clear();
                        votanteGUI.AddVotingLocation();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }

        public void GestionLugarVotacion()
        {
            System.Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.ForegroundColor = ConsoleColor.Black;

            LugarVotacionGUI lugarGUI = new LugarVotacionGUI(); 
            int op;
            do
            {
                Console.Clear();//
                Console.SetCursorPosition(20, 7); Console.Write("MENU LUGAR DE VOTACION");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar Lugar de votacion");
                Console.SetCursorPosition(18, 11); Console.Write("2. Consulta General");
                Console.SetCursorPosition(18, 13); Console.Write("3. Eliminar por Id ");
                Console.SetCursorPosition(18, 15); Console.Write("4. Actualizar lugar de votacion ");
                Console.SetCursorPosition(18, 17); Console.Write("5. Cargar datos de prueba ");
                Console.SetCursorPosition(18, 19); Console.Write("9. salir");

                Console.SetCursorPosition(27, 19); Console.Write("digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        lugarGUI.ViewAdd();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        lugarGUI.GetAll();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        lugarGUI.ViewDelete();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        lugarGUI.ViewUpdate();
                        Console.ReadKey();
                        break;
                    case 5:
                        lugarGUI.Load();
                        break;
                }
            } while (op != 9);
        }
    }
}
