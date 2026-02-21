using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructurada.Business
{
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        /// <summary>
        /// Hay reglas que se deben seguir a la hora de crear una clase hij@, como 
        /// por ejemplo, que el constructor de la clase hija debe llamar al constructor de la clase padre.
        /// El proposito de la herencia es reutilizar codigo, por lo que el constructor de la clase hija debe llamar al 
        /// constructor de la clase padre para reutilizar el codigo que ya se ha escrito 
        /// en el constructor de la clase padre pero a la vez puede crear una nueva funcionalida como en este caso 
        /// "public DateTime Expiration {get; set;}".
        /// </summary
        public ExpiringBeer(String name, decimal price, decimal alcohol, DateTime expiration, int Cantidad)
            : base(name, price, alcohol, Cantidad)
        {
            Expiration = expiration;
        }
        public override string GetInfo()
        {
            return "Cerveza con caducidad: " + Name + ", "+
                "Precio: $" + Price + ", " +
                "Alcohol: " + Alcohol + "%, " +
                "Caducidad: " + Expiration.ToShortDateString();
        }
        public override string GetInfo(string message)
        {
            return message;
        }

    }
}
