using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HairDresser
{
    class Tools
    {
        private Object getLock = new Object();
        private Object putLock = new Object();
        private bool[] _scissors = { false, false, false, false, false, false };
        private static Random random = new Random();

        public void Get(int left, int right)
        {
            lock (getLock)
            {
                while (_scissors[left] || _scissors[right])
                {
                    Thread.Sleep(10);
                }
                _scissors[left] = true;
                _scissors[right] = true;
            }
        }

        public void Put(int left, int right)
        {
            // no need 
            lock (putLock)
            {
                _scissors[left] = false;
                _scissors[right] = false;
            }
        }

        public static int GetDelay()
        {
            int floor = 100;
            int celling = 400;
            return random.Next(floor, celling);
        }
    }
}
