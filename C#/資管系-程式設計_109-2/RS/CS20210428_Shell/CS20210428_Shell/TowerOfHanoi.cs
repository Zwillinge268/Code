using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20210428_Shell
{
    class TowerOfHanoi
    {
        public int step;
        public string Demo;
        public void Initialize()
        {
            step = 0;
            Demo = null;
        }
        public string HanoiTower(int n , string Source, string Destination, string Via)
        {
            if (n == 1)
            {
                step++;
                Demo += step + ". Move Disk " + n + " From " + Source + " To " + Destination + "\r\n";
            }
            else
            {
                HanoiTower(n - 1, Source, Via, Destination);
                step++;
                Demo += step + ". Move Disk " + n + " From " + Source + " To " + Destination + "\r\n";
                HanoiTower(n - 1, Via, Destination, Source);
            }
            return Demo;
        }
    }
}
