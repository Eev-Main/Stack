using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Decir "Imprimir Stack"
            // 2) Decir "Hola [nombre]!"
            // 9) Salir

            StackNotas stackNotas = new StackNotas();
            stackNotas.push("Primer nota");
            stackNotas.push("Segunda nota");
            stackNotas.push("Tercer nota");

            string opcion = "";
            while (opcion != "9")
            {
                //pedir opcion al usuario
                opcion ="";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                {

                    Console.WriteLine("1) imprimir notas (PrintStack)");
                    Console.WriteLine("2) Agregar nota (push)");
                    Console.WriteLine("3) quitar nota (Pop)");
                    Console.WriteLine("4)consultar un elemento (peek)");
                    Console.WriteLine("9) salir");

                    Console.WriteLine("Porfavor selecciona un opción: ");
                    opcion = Console.ReadLine();

                    //Validar opcion ingresada

                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                    {
                        Console.WriteLine("La opcion seleccionada no es correcta.");
                    }

                }

            

            //if (opcion == "1")
            //{
            //    Console.WriteLine("Hola Mundo!");
            //}
            //else if (opcion == "2")
            //{
            //    Console.WriteLine("Introducce tu nombre:");
            //    string nombre = Console.ReadLine();
            //    Console.WriteLine("Hola " + nombre + "!");
            //}
            //else if (opcion == "9")
            //{
            //    Console.WriteLine("Hasta pronto! ");
            //}

            switch(opcion)
            {
                case "1":
                    stackNotas.PrintStack();
                break;
                case "2":
                    //Push
                    Console.WriteLine("Agregar nota: ");
                    string nota = Console.ReadLine();
                    stackNotas.push(nota);
                break;
                case "3":
                    //Pop
                    nota = stackNotas.Pop();
                    Console.WriteLine("nota removida: ");
                    Console.WriteLine(nota);
                break;
                case "4":
                    //Peek
                    nota = stackNotas.peek();
                    Console.WriteLine("nota Removida");
                    Console.WriteLine(nota);
                break;
                case "9":
                    Console.WriteLine("Hasta pronto! ");
                break;
                default:
                    //hacer algo en caso contrario o que ninguna se cumpla
                break;
            }

            }
        }
    }
}
