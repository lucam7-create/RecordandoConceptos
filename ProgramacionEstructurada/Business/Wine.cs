using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructurada.Business
{
    public class Wine : Drink
    {
        private const string Categoria = "Vino";
        public Wine(int Cantidad) : base(Cantidad)
        {
        }
        public override string GetCantegoria()//Un metodo que esta en Drink y que necesita todas las clases que hereden
        {
            return Categoria;
        }
        /// <summary>
        /// Tambien puedo usar 
        /// public override string GetInfo()=> return Categoria;
        /// </summary>
    }
}
