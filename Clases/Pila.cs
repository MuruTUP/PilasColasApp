using PilasColasApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp.Clases
{

    internal class Pila : IColleccion
    {
        protected Object[] array;
        protected int contador;

        public Pila(int size)
        {
            array = new Object[size];
            contador = -1;
        }

        public bool añadir(object elemento)
        {
            
        }

        public bool estaVacia(Collection<object> coleccion)
        {
            return coleccion.Any();
        }

        public object extraer()
        {
            throw new NotImplementedException();
        }

        public object primero(Collection<object> coleccion)
        {
            if (!coleccion.Any())
            {
                return "No existe" ;
            }
            return coleccion[0];
        }
    }
}
