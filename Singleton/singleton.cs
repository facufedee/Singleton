using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class singleton
    {
        private static singleton instance = null;
        public string mensaje {  get; set; }

        private singleton()
        {
            mensaje = "Hola desde singleton";
        } 
        public static singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new singleton();
            }
            return instance;
        }
    }
}
