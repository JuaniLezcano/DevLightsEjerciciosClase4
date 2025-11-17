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
                Console.Write("Ingresá un número (1-11): ");
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
                            Ejercicio7();
                            break;
                        case 8:
                            Ejercicio8();
                            break;
                        case 9:
                            Ejercicio9();
                            break;
                        case 10:
                            Ejercicio10();
                            break;
                        case 11:
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
            List<int> resultadosAlumno = new List<int> { 8, 2, 5, 7, 10, 4, 7, 9, 6, 8 };
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
                }
                else
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
                    }
                    else
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
            int[,] matriz = new int[5, 7];
            Random generadorRandom = new Random();
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            int contadorDias = 1;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (contadorDias > 31)
                    {
                        break;
                    }
                    int numeroRandom = generadorRandom.Next(7, 39);
                    matriz[i, j] = numeroRandom;
                    contadorDias++;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                RecorrerSemana(i);
            }
            temperaturaMasAlta();


            void RecorrerSemana(int semana)
            {
                int diaMayor = 0, diaMenor = 0;
                int menorTemperatura = 39;
                int mayorTemperatura = 0;
                int acumuladorTemperaturaSemana = 0;
                int contadorDiasSemana = 0;
                Console.WriteLine($"\nSemana {semana + 1}:");
                contadorDiasSemana = 0;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[semana, j] != 0)
                    {
                        if (matriz[semana, j] > mayorTemperatura)
                        {
                            mayorTemperatura = matriz[semana, j];
                            diaMayor = j;
                        }
                        if (matriz[semana, j] < menorTemperatura)
                        {
                            menorTemperatura = matriz[semana, j];
                            diaMenor = j;
                        }
                        contadorDiasSemana++;
                        acumuladorTemperaturaSemana += matriz[semana, j];
                    }
                }
                int promedio = (contadorDiasSemana > 0) ? acumuladorTemperaturaSemana / contadorDiasSemana : 0;

                Console.WriteLine($"El promedio de temperatura de la semana {semana + 1} es: {promedio} ");
                Console.WriteLine($"La mayor temperatura de la semana {semana + 1} es: {mayorTemperatura}°C y fue el dia {diasSemana[diaMayor]}");
                Console.WriteLine($"La menor temperatura de la semana {semana + 1} es: {menorTemperatura}°C y fue el dia {diasSemana[diaMenor]}");
            }

            void temperaturaMasAlta()
            {
                int mayorTemperaturaMensual = 0;
                int diaMayorMensual = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] > mayorTemperaturaMensual)
                        {
                            mayorTemperaturaMensual = matriz[i, j];
                            diaMayorMensual = j;
                        }
                    }
                }
                Console.WriteLine($"\nLa temperatura más alta del mes fue de {mayorTemperaturaMensual}°C y fue el dia {diasSemana[diaMayorMensual]}");
            }
        }

        static void Ejercicio7()
        {
            Section("Ejercicio 7");
            int[,] tabla = new int[10, 10];
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    tabla[i, j] = (i + 1) * (j);
                }
            }

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.Write($"{tabla[i, j], 3}");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio8()
        {
            Section("Ejercicio 8");
            char[,] matriz = new char[10, 10];
            int cantidadX = 0;
            Random generadorRandom = new Random();
            int contadorIntentos = 0, contadorFalla = 0;

            while (cantidadX < 35)
            {
                int fila = generadorRandom.Next(0, 10);
                int columna = generadorRandom.Next(0, 10);

                if (matriz[fila, columna] != 'X')
                {
                    matriz[fila, columna] = 'X';
                    cantidadX++;
                }
            }

            do
            {
                if ( contadorIntentos <= 35) {
                    contadorIntentos++;
                    Console.WriteLine("Encontra las 'X' escondidas.");
                    Console.WriteLine("Ingrese el numero de la fila (1-10)");
                    bool isValidFila = int.TryParse(Console.ReadLine(), out int colFila);
                    Console.WriteLine("Ingrese el numero de la columna (1-10)");
                    bool isValidCol = int.TryParse(Console.ReadLine(), out int colNum);

                    if (matriz[colFila-1, colNum-1] == 'X')
                    {
                        Console.WriteLine("X acertada exitosamente!");
                    }
                    else
                    {
                        contadorFalla++;
                        Console.WriteLine($"No acertaste a ninguna X, te quedan {4 - contadorFalla} intentos");
                    }
                }
            } while (contadorFalla <= 3);


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 'X') { 
                        Console.Write(matriz[i, j] + "  ");
                    } else
                    {
                        Console.Write('*' + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Ejercicio9()
        {
            Section("Ejercicio 9");
            Dictionary<string, double> calificaciones = new Dictionary<string, double>();
            bool finishMenu = false;
            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Agregar calificación");
                Console.WriteLine("2 - Ver promedio del curso");
                Console.WriteLine("3 - Ver alumno con mejor y peor nota");
                Console.WriteLine("4 - Finalizar");
                bool isValidOpt = int.TryParse(Console.ReadLine(), out int opt);

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del alumno:");
                        string? nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la calificación del alumno:");
                        bool isValidCal = double.TryParse(Console.ReadLine(), out double calificacion);
                        if (nombre != null && isValidCal)
                        {
                            calificaciones[nombre] = calificacion;
                            Console.WriteLine("Calificación agregada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case 2:
                        if (calificaciones.Count > 0)
                        {
                            double suma = 0;
                            foreach (var c in calificaciones)
                            {
                                suma += c.Value;
                            }

                            double promedio = suma / calificaciones.Count;
                            Console.WriteLine($"El promedio del curso es: {promedio}");
                        }
                        else
                        {
                            Console.WriteLine("No hay calificaciones registradas.");
                        }
                        break;
                    case 3:
                        if (calificaciones.Count > 0)
                        {
                            string alumnoMejor = "";
                            string alumnoPeor = "";
                            double mejorNota = double.MinValue;
                            double peorNota = double.MaxValue;

                            foreach (var c in calificaciones)
                            {
                                if (c.Value > mejorNota)
                                {
                                    mejorNota = c.Value;
                                    alumnoMejor = c.Key;
                                }

                                if (c.Value < peorNota)
                                {
                                    peorNota = c.Value;
                                    alumnoPeor = c.Key;
                                }
                            }

                            Console.WriteLine($"Mejor alumno: {alumnoMejor} con {mejorNota}");
                            Console.WriteLine($"Peor alumno: {alumnoPeor} con {peorNota}");
                        }
                        else
                        {
                            Console.WriteLine("No hay calificaciones registradas.");
                        }
                        break;
                    case 4:
                        finishMenu = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            while (finishMenu == false);
        }
        static void Ejercicio10() 
        {
            Section("Ejercicio 10");
            Queue<string> cola = new Queue<string>();
            bool finishMenu = false;
            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Encolar nombres de clientes");
                Console.WriteLine("2 - Atender (desencolar) uno por uno hasta que no queden");
                Console.WriteLine("3 - Mostrar en pantalla quien esta siendo atendido y cuantos quedan en la fila");
                Console.WriteLine("4 - Finalizar");
                bool isValidOpt = int.TryParse(Console.ReadLine(), out int opt);
                string nombreAtendiendo;
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de un cliente");
                        string? nombre = Console.ReadLine();
                        cola.Enqueue(nombre);
                        break;
                    case 2:
                        if (cola.Count > 0)
                        {
                            nombreAtendiendo = cola.Dequeue();
                            Console.WriteLine($"Atendiendo a: {nombreAtendiendo}");
                        }
                        else
                        {
                            nombreAtendiendo = null;
                            Console.WriteLine("No hay clientes en la fila.");
                        }
                        break;
                    case 3:
                        if (cola.Count > 0)
                        {
                            Console.WriteLine($"Siguiente cliente: {cola.Peek()}");
                            Console.WriteLine($"Quedan {cola.Count} en la fila.");
                        }
                        else
                        {
                            Console.WriteLine("No hay nadie esperando.");
                        }
                        break;
                    case 4:
                        finishMenu = true;
                        break;
                }
            } while (finishMenu == false);
        }
    }
}