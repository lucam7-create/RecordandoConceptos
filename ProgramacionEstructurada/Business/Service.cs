using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructurada.Business
{
    public class Service : ISalable, ISend
    {
       private decimal _amount;
        private decimal _tax;
        public Service(decimal amount, decimal tax)
        {
            _amount = amount;
            _tax = tax;
        }
        public string GetInfo()
        {
            return "Monto: $" + _amount + "; Impuesto: " + _tax+"%";
        }
        public void Send()
        {
            Console.WriteLine("El costo del servicio es..." + GetInfo());
        }
    }
}
