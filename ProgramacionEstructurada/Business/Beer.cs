

namespace ProgramacionEstructurada.Business
{

    public class Beer : Drink, ISalable, ISend
    {
        private const string Categoria = "Cerveza";
        private decimal _alcohol;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Alcohol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }
        public string SAlcohol
        {
            get
            {
                return "Alcohol: " + _alcohol.ToString();
            }
        }
        public Beer(string name, decimal price, decimal alcohol, int Cantidad)
            : base(Cantidad)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }
        public virtual string GetInfo()
        {
            return "Nombre: " + Name + "; Precio: $" + Price + "; Alcohol: " + Alcohol + "%";
        }
        /// <summary>
        /// Sobrecarga de metodos, es decir, tener dos o mas metodos con el mismo 
        /// nombre pero con diferentes parametros, esto es posible gracias a la sobrecarga de metodos, 
        /// que permite tener varios metodos con el mismo nombre pero con diferentes parametros, lo que 
        /// permite tener una mayor flexibilidad a la hora de llamar a los metodos, ya que se pueden llamar 
        /// con diferentes parametros dependiendo de la necesidad del momento.
        /// </summary
        public virtual string GetInfo(string message)
        {
            return message + " - " + GetInfo();
        }
        public string GetInfo(int num)
        {
            return num + " - " + GetInfo();
        }
        public override string GetCantegoria()
        {
            return Categoria;
        }

        public decimal GetPrice()
        {
            return Price;
        }
        public void Send()
        {
            Console.WriteLine("Enviando cerveza..." + GetInfo());
        }
    }
}
