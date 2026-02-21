using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructurada.Business
{
    /// <summary>
    /// La clase abstracta es una clase que no se puede instanciar, es decir, no se pueden 
    /// crear objetos de esa clase, pero si se pueden crear objetos de las clases hijas que hereden de 
    /// esa clase abstracta, esto es posible gracias a la herencia, que permite crear una nueva clase a partir 
    /// de una clase existente, y la nueva clase hereda los atributos y metodos de la clase existente, pero 
    /// tambien puede agregar nuevos atributos y metodos o modificar los existentes, lo que permite tener una 
    /// mayor flexibilidad a la hora de crear nuevas clases y reutilizar codigo. En este caso, la clase Drink es 
    /// una clase abstracta que tiene un atributo Cantidad y un metodo GetCantidad(), y un metodo abstracto
    /// GetCantegoria() que debe ser implementado por las clases hijas que hereden de esta clase abstracta.
    /// </summary>
    public abstract class Drink
    {
        public int Cantidad { get; set; }
        public Drink(int cantidad)
        {
            Cantidad = cantidad;
        }
        public string GetCantidad()
        {
            return Cantidad + " ml";
        }
        public abstract string GetCantegoria();
    }

}
