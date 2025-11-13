// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;

namespace EjerciciosClase4
{
    class Program
    {
        static void Main()
        {
            Title("Ejercicios Clase 4");
            Console.WriteLine("¿Qué ejercicio querés seleccionar?");

            string[] ejercicios =
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11 (extra)",
                "Finalizar Proceso"
            };

            var index = 1;
            string? input = "";
            bool finishProcess = false;

            while (!finishProcess)
            {
                foreach (var e in ejercicios)
                {
                    Console.WriteLine($"{index} - {e}");
                    index++;
                }
                Console.Write("Ingresá un número (1-12): ");
                input = Console.ReadLine();
                index = 1;

                if (int.TryParse(input, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Ejercicio1();
                            break;
                        case 2:
                            Ejercicio2();
                            break;
                        case 3:
                            Ejercicio3();
                            break;
                        case 4:
                            Ejercicio4();
                            break;
                        case 5:
                            Ejercicio5();
                            break;
                        case 6:
                            Ejercicio6();
                            break;
                        case 7:
                            ///Ejercicio7();
                            break;
                        case 8:
                            //Ejercicio8();
                            break;
                        case 9:
                            //Ejercicio9();
                            break;
                        case 10:
                            //Ejercicio10();
                            break;
                        case 11:
                            //Ejercicio11();
                            break;
                        case 12:
                            finishProcess = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                }
                if (finishProcess)
                {
                    Console.WriteLine("\nFin. Presioná cualquier tecla para salir...");
                    Console.ReadKey();
                    continue;
                }
            }
        }
        static void Title(string text)
        {
            Console.WriteLine($"═══{text}═══");
        }
        static void Section(string text)
        {
            Console.WriteLine();
            Console.WriteLine($"--- {text} ---");
        }

        static void Ejercicio1()
        {
            Section("Ejercicio 1");
            List<int> resultadosAlumno = new List<int>{ 8, 2, 5, 7, 10, 4, 7, 9, 6, 8};
            double promedio = resultadosAlumno.Sum() / resultadosAlumno.Count();
            Console.WriteLine($"Las notas de los ultimos 10 examenes del alumno son: {string.Join(", ", resultadosAlumno)}");
            Console.WriteLine($"El promedio de las notas es: {promedio}");
        }

        static void Ejercicio2()
        {
            Section("Ejercicio 2");
            List<int> edades = new List<int> { 85, 12, 4, 39, 77, 91, 28, 55, 6, 19, 98, 43, 60, 31, 74, 5, 88, 50, 24, 69 };
            int countMenor = 0, countMayor = 0;
            foreach (int i in edades)
            {
                if (i < 18)
                {
                    countMenor++;
                } else
                {
                    countMayor++;
                }
            }
            Console.WriteLine($"La cantidad de menores en la lista es de: {countMenor}");
            Console.WriteLine($"La cantidad de mayores en la lista es de: {countMayor}");
        }

        static void Ejercicio3()
        {
            Section("Ejercicio 3");
            List<string> nombresEstudiantes = new List<string> { "Sofía", "Javier", "Valentina", "Daniel", "Camila", "Alejandro", "Lucía", "Ricardo", "Sol" };
            string nombreLargo = nombresEstudiantes[0];
            string nombreCorto = nombresEstudiantes[0];
            int tam1 = nombresEstudiantes[0].Length, tam2 = nombresEstudiantes[0].Length;

            foreach (string nombre in nombresEstudiantes)
            {
                if (tam1 < nombre.Length)
                {
                    tam1 = nombre.Length;
                    nombreLargo = nombre;
                }

                if (nombre.Length < tam2)
                {
                    tam2 = nombre.Length;
                    nombreCorto = nombre;
                }
            }

            Console.WriteLine($"El nombre que tiene la mayor cantidad de letras es {nombreLargo}");
            Console.WriteLine($"El nombre que tiene la menor cantidad de letras es {nombreCorto}");

        }

        static void Ejercicio4()
        {
            Section("Ejercicio 4");

            List<string> listaSuper = new()
            {
                "Pan",
                "Leche",
                "Huevos",
                "Arroz",
                "Azúcar"
            };
            List<string> listaSuperActualizada = new()
            {
                "Pan",
                "Leche",
                "Huevos",
                "Arroz",
                "Azúcar"
            };
            List<string> listaCompraInesperada = new();
            List<string> listaCompra = new();

            string[] opciones =
            {
                "Ingresa el nombre del producto que vas a comprar",
                "Ver resumen de compra",
                "Finalizar proceso"
            };

            var index = 1;
            string? input = "";
            bool finishProcess = false;

            while (!finishProcess)
            {
                foreach (var o in opciones)
                {
                    Console.WriteLine($"{index} - {o}");
                    index++;
                }
                Console.Write("Ingresá un número (1-3) o 'fin' para salir: ");
                input = Console.ReadLine();
                index = 1;
                if (input == "fin")
                {
                    break;
                }
                if (int.TryParse(input, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            nombreProducto();
                            break;
                        case 2:
                            resumenCompra();
                            break;
                        case 3:
                            finishProcess = true;
                            break;
                        default:
                            Console.WriteLine("Error al ingresar el numero");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                }
                if (finishProcess)
                {
                    Console.WriteLine("\nFin. Presioná cualquier tecla para salir...");
                    Console.ReadKey();
                    continue;
                }
            }
            
            void nombreProducto()
            {
                
                Console.WriteLine("Ingresa el nombre del producto que vas a comprar");
                string? producto = Console.ReadLine();
                string? productoEnLista = listaSuper.Find(x => x == producto);

                if (productoEnLista == null)
                {
                    listaCompraInesperada.Add(producto);
                    listaCompra.Add(producto);
                    listaSuperActualizada.Add(producto);
                    Console.WriteLine("El producto no se encontraba en la lista, pero fue agregado satisfactoriamente");
                }
                else
                {
                    listaCompra.Add(producto);
                    listaSuper.Remove(producto);
                    listaSuperActualizada.Remove(producto);
                    Console.WriteLine("El producto se encontraba en la lista y fue quitado correctamente");
                }

            }

            void resumenCompra()
            {
                Console.WriteLine($"Los productos que NO compro fueron: {string.Join(", ", listaSuper)}");
                Console.WriteLine($"Los productos comprados que no estaban en la lista del super fueron: {string.Join(", ", listaCompraInesperada)}");
                Console.WriteLine($"Los productos comprados fueron: {string.Join(", ", listaCompra)}");
            }
        }

        static void Ejercicio5()
        {
            Section("Ejercicio 5");
            char[,] matriz = new char[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j + 1) % 2 == 0)
                    {
                        matriz[i, j] = 'P';
                    } else
                    {
                        matriz[i, j] = 'I';
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio6()
        {
            Section("Ejercicio 6");

        }
    }
}