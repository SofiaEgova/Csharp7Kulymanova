using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public interface IGame
    {
        void add(int x, int y, int num);
        bool check();
        string getGameFild();
        int changePlayer(int pl);
    }
}
