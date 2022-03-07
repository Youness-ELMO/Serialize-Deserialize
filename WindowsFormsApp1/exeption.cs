using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class exeptionage:Exception
    {
        public exeptionage(string mess):base(mess)//la class de base c'est la class mère
        {
            
        }
    }
}
