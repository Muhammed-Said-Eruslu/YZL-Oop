using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_GenericLab
{
    internal interface IBaseService<T> where T : Base
    {
        void Create(T item);
        void Update(T item,int index);
        void Delete(T item);
        List<T> GetAll();
    }
}
