using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp.Interfaces
{
    public interface IColleccion
    {
        bool estaVacia();
        Object extraer();
        Object primero(object elemento);
        bool añadir(object elemento);

    }
}
