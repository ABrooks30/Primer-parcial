using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialAlihaBrooks
{

    static class Menu
    {

        static Menu() { }
        static string[] Marca = new string[5];//creamos las variables, de acuaerdo a las necesiades del mismo...si son palabras/letras
        static string[] Modelo = new string[5];
        static int[] Codigo = new int[5];
        static int[] indice = 0;//inicializa el indice del vecor en 0
        static float[] Costo = new float[5];
        public static void Principal()
        {

            byte opcion = 1;
            do
            {

                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*********** Menu Principal ********");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("1- ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vehículos");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("2- ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ventas");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("3- ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Reportes");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("4- ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Salir");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********************************");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite una opcion: ");
                    opcion = byte.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1: SubMenuConsultar(); break;
                        case 2: SubMenuModificar(); break;
                        case 3: break;
                        case 4: SubMenuAgregar(); break;

                        default:
                            break;
                    }
                } while (opcion != 4) ;
            }}


        public static void SubMenuAgregar()//Clase responsable de almacenar los datos ingresados por el usuario
        {

            Console.WriteLine("Ingrese un codigo"); Codigo[indice] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una Marca"); Marca[indice] = Console.ReadLine();
            Console.WriteLine("Ingrese un Modelo"); Modelo[indice] = Console.ReadLine();
            Console.WriteLine("Ingrese el costo"); Costo[indice] = float.Parse(Console.ReadLine());
            indice++;//ayuda a que el proximo valor sea guardado en otro espacio y no se sobrescriban los datos

        }
        public static void SubMenuModificar()
        {
            int codigo;
            Boolean Existe = false;
            Console.WriteLine("Cual codigo desea consultar?"); codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (codigo == Codigo[i])
                {
                    Console.WriteLine($"Ingrese la marca del vehiculo: "); Marca[i] = Console.ReadLine();
                    Console.WriteLine($"Ingrese el modelo del vehiculo: "); Modelo[i] = Console.ReadLine();
                    Console.WriteLine($"Ingrese el precio del vehiculo: "); Costo[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                }
            }
            if (!Existe) Console.WriteLine("No se han encontrado datos relacionasos a ese codigo");
        } }

            public static void SubMenuConsultar()//Clase elaborada con un condicional para comprobar la existencia de datos en el sistema
        {
            int codigo;
            Boolean Existe = false;
            Console.WriteLine("Cual codigo desea consultar?"); codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (codigo == Codigo[i])
                {
                    Console.WriteLine($"Marca: {Marca[i]}");
                    Console.WriteLine($"Marca: {Costo[i]}");
                    Console.WriteLine($"Modelo: {Modelo[i]}");
                    Existe = true;
                }
            }
            if (!Existe) Console.WriteLine("No se han encontrado datos relacionasos a ese codigo");
            {

            }

        }
             internal class Tipo//polimorfirmo aplicado en una clase con una funci[on de boolean que examina la lista y determina si existe o no el tipo de vehiculo
    {
        List<String> tipos = new List<String>() { "Motocicleta", "Automovil", "Dron" };
        int x = 0;

        public Tipo()
        {

        }
        public Boolean BuscarTipo(string valor)
        {
            Boolean Existe = tipos.Contains(valor);
            return Existe;
        }
    }
}}}

            
