using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TConsoleApp
{
    internal class ADisp : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DoSmth()
        {
            
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose object's members");
                }

                // Free any unmanaged objects here. 
                //

                Console.WriteLine("Object disposing");
                _disposed = true;
            }
     
        }

        private bool _disposed = false;

        //~ADisp()
        //{
        //    Console.WriteLine("Finalize");
        //    Dispose(false);
        //}
    }
}
