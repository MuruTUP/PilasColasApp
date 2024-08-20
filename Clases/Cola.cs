using PilasColasApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp.Clases
{

    public class Cola : IColeccionAbstracta
    {
        public Cola(int size) : base(size)
        {

        }

        public override object extraer()
        {
            object e = null;

            if (!estaVacia())
            {
                for (int i = 0; i < next && array[i] == null; i++)
                    e = array[i];

            }

            return e;
        }
    }
}
