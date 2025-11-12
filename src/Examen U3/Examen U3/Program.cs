using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Texto textoEditable = new TextoEditable();
            ColorAdapter adaptadorColor = null;
            string cadena;

            Console.WriteLine("Bienvenido al editor de Texto - Examen Unidad 3");
            Console.Write("Ingrese su texto para comenzar: ");
            cadena = Console.ReadLine();
            Console.Clear();

            ((TextoEditable)textoEditable).text = cadena;

            string continuar = "si";

            while (continuar == "si")
            {
                Console.WriteLine("Seleccione el estilo que desea aplicar:");
                Console.WriteLine("1. Negrita");
                Console.WriteLine("2. Cursiva");
                Console.WriteLine("3. Subrayada");
                Console.WriteLine("4. Reestablecer estilos");
                Console.WriteLine("5. Cambiar color");
                Console.Write("Opción: ");

                int opc;
                while (!int.TryParse(Console.ReadLine(), out opc) || opc < 1 || opc > 5)
                {
                    Console.Write("Opción inválida. Intente de nuevo: ");
                }

                Console.Clear();

                switch (opc)
                {
                    case 1:
                        textoEditable = new Negrita(textoEditable);
                        break;

                    case 2:
                        textoEditable = new Cursiva(textoEditable);
                        break;

                    case 3:
                        textoEditable = new Subrayada(textoEditable);
                        break;

                    case 4:
                        textoEditable = new Reestablecer(textoEditable);
                        break;

                    case 5:
                        Console.WriteLine("Seleccione un color:");
                        Console.WriteLine("1. Rojo");
                        Console.WriteLine("2. Verde");
                        Console.WriteLine("3. Azul");
                        Console.WriteLine("4. Amarillo");
                        Console.WriteLine("5. Morado");
                        Console.WriteLine("6. Reestablecer color");
                        Console.Write("Opción: ");

                        int colorOpc;
                        while (!int.TryParse(Console.ReadLine(), out colorOpc) || colorOpc < 1 || colorOpc > 6)
                        {
                            Console.Write("Opción inválida. Intente de nuevo: ");
                        }

                        ConsoleColor colorSeleccionado = ConsoleColor.White;

                        switch (colorOpc)
                        {
                            case 1: colorSeleccionado = ConsoleColor.Red; break;
                            case 2: colorSeleccionado = ConsoleColor.Green; break;
                            case 3: colorSeleccionado = ConsoleColor.Blue; break;
                            case 4: colorSeleccionado = ConsoleColor.Yellow; break;
                            case 5: colorSeleccionado = ConsoleColor.Magenta; break;
                            case 6: colorSeleccionado = ConsoleColor.White; break;
                        }

                        Console.Clear();

                        if (adaptadorColor == null)
                        {
                            adaptadorColor = new ColorAdapter(textoEditable, colorSeleccionado);
                            textoEditable = adaptadorColor;
                        }
                        else
                        {
                            adaptadorColor.CambiarColor(colorSeleccionado);
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine("Texto con estilos aplicados:");
                Console.WriteLine(textoEditable.texto);

                Console.WriteLine();
                Console.Write("¿Desea agregar otro estilo? (si/no): ");
                continuar = Console.ReadLine().Trim().ToLower();
                Console.Clear();
            }

            Console.WriteLine("Resultado final:");
            Console.WriteLine(textoEditable.texto);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
