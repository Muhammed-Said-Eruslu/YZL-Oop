using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_GenericLab
{
    internal class BaseService : IBaseService<Base>
    {
        private List<Base> person;
        public BaseService()
        {
            person = new List<Base>();
        }
        public void Create(Base item)
        {
            person.Add(item);
        }

        public void Delete(Base item)
        {
            person.Remove(item);
        }

        public List<Base> GetAll()
        {
            return person;
        }

        public void Update(Base item, int index)
        {
            person[index] = item;
        }
    }
}
