using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionEstructurada.Business
{
    public class Collection<T> 
    {
        private T[] _element;
        private int _index;
        private int _limit;
        public Collection(int limit)
        {
            _index = 0;
            _limit = limit;
            _element = new T[limit];
        }
        public void Add(T element)
        {
            if (_index < _limit)
            {
                _element[_index] = element;
                _index++;
            }
           
        }
        public T[] Get()=> _element;
    }
}
