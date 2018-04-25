using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501Project1_EB
{
    /// <summary>
    /// main class to handle startup, arguments,
    /// and continued operation of the rest of the sales system
    /// </summary>
    class Program
    {
        /// <summary>
        /// SalesManager class that will run the sales system
        /// </summary>
        private static SalesManager SalesManager = new SalesManager();
        /// <summary>
        /// main startup method handles startup and continued operation of the sales system
        /// </summary>
        /// <param name="args">startup args</param>
        static void Main(string[] args)
        {
            //SalesManager SalesManager = new SalesManager();
            while (true) { SalesManager.Sale(); }
            
        }
    }
}
