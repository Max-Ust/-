using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР16
{
    class Class1
    {
        private int x;

        public Class1()
        {
            x = 0;
        }

        public Class1(string x)
        {
            this.x = int.Parse(x);
        }

        public string Get2
        {
            get
            {
                return Convert.ToString(x, 2);
            }
            set
            {
                x = int.Parse(value);
            }
        }
        public string Get8
        {
            get
            {
                return Convert.ToString(x, 8);
            }
            set
            {
                x = int.Parse(value);
            }
        }
        public string Get16
        {
            get
            {
                return Convert.ToString(x, 16);
            }
            set
            {
                x = int.Parse(value);
            }
        }
    }
}
