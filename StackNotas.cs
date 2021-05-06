using System;
using System.Collections.Generic;

namespace  Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();

        //agregar elemento
        //ver elemento de arriba
        //pop -> ver + quitar
        //saber cuantos elemenos tiene dentro

        public int Count 
        {
            get => this.notas.Count;
        }

        //imprimir stack

        public void push(string nota)
        {
            //la parte de arriba del stack es el final de la lista
            this.notas.Add(nota); 
        }

        public string Pop()
        {
            //1. devolver valor
            //2. borrar

            // ... Excepto cuando no hay nada que borrar
            if(this.notas.Count == 0)
            {
                return null;
            }

            //respaldar valor
            string value = this.notas[this.notas.Count -1];

            //Borrar de la lista
            this.notas.RemoveAt(this.notas.Count - 1);

            //devolver el valor
            return value;
            
        }

        public string peek()
        {
            if(this.notas.Count == 0)
            {
                Console.WriteLine("no hay elementos en el stack");
                return null;
            }
            else
            {
                return this.notas[this.notas.Count - 1];
            }
        }

        public void PrintStack()
        {
            for(int i = this.notas.Count- 1; i >=0; i--)
            {
                Console.WriteLine(notas[i]);
            }
        }
    }
}