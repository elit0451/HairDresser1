using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HairDresser
{
    class HairDresser
    {
        int Id;
        private int _left;
        private int _right;
        private Tools _tools;
        private const int _periods = 10;
        public HairDresser()
        {

        }
        public HairDresser(int id, int left, int right, Tools tools)
        {
            Id = id;
            _left = left;
            _right = right;
            _tools = tools;
        }

        public void Start()
        {
            new Thread(new ThreadStart(Work)).Start();
        }



        public void Work()
        {
            for (int i = 0; i < _periods; i ++)
            {
                //Get comb ?
                _tools.Get(_left, _right);
                Console.WriteLine($"HairDresser {Id} is cutting hair.");
                // cut hair for a while
                Thread.Sleep(Tools.GetDelay());
            }

        }
    }
}
