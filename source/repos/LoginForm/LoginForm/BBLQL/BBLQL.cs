using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.BBLQL
{
    public class BBLQL
    {
        private static BBLQL _Instance;
        public static BBLQL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BBLQL();
                return _Instance;
            }
            private set { }

        }
        public List<>
    }
}
