﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */

        public int Top { get; set; }

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos =  new list<Disco>();
        }

        public void push(Disco d)
        {
            
        }

        public Disco pop()
        {
            return null;
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}
