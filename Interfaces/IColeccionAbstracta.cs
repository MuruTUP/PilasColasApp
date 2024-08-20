using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp.Interfaces
{
    public abstract class IColeccionAbstracta : IColleccion
    {
        protected Object[] array;
        protected int next;

        public IColeccionAbstracta(int size)
        {
            array = new Object[size];
            next = -1;
        }

        public virtual bool añadir(object elemento)
        {
            bool añadido = false;

            if (next < array.Length)
            {
                array[++next] = elemento;
                añadido = true;
            }

            return añadido;

        }

        public virtual bool estaVacia()
        {
            return next == -1;
        }


        public abstract object extraer()
        {
            object e = null;

            if (!estaVacia()) 
            {
                for (int i = 0; i < next && array[i] == null; i++)
                    e = array[i];

            }

            return e;
        }

        public virtual object primero()
        {
            return array[0];
        }
    }
}
