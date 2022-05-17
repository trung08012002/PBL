using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public interface user
    {
        void Add(inforuser user);
        void Edit(inforuser user);
        void Delete(string userid);
        IEnumerable<inforuser> GetAll();

        IEnumerable<inforuser> GetByValue();//Searchs
    }
}