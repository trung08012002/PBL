using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace LoginForm
{
    public class CreateDB: CreateDatabaseIfNotExists<QL>
    {
        protected override void Seed(QL context)
        {
            
        }
    }
}
