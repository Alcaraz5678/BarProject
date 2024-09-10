using System;

namespace Bar.Src.View
{
    public class MenuAdminBar : MenuManager
    {
        public override void ShowOptions()
        {
            try
            {
                Console.WriteLine("Opciones del administrador:");
                Console.WriteLine("1. Agregar mesero");
                Console.WriteLine("2. Agregar administrador");
                Console.WriteLine("3. Ver resumen del mesero");
                Console.WriteLine("4. Ver resumen de las mesas");
                Console.WriteLine("5. Salir");

                int option = ReadOption();
                ProcessOption(option);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private int ReadOption()
        {
            Console.Write("Ingrese una opción: ");
            string input = Console.ReadLine();
            int option;

            while (!int.TryParse(input, out option))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                Console.Write("Ingrese una opción: ");
                input = Console.ReadLine();
            }

            return option;
        }

        private void ProcessOption(int option)
        {
            switch (option)
            {
                case 1:
                    // Agregar mesero
                    break;
                case 2:
                    // Agregar administrador
                    break;
                case 3:
                    // Ver resumen del mesero
                    break;
                case 4:
                    // Ver resumen de las mesas
                    break;
                case 5:
                    // Salir
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}