using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public interface IGame
    {
        void add(int x, int y, int num);
        bool check(int pl);
        string getGameFild();
        int changePlayer(int pl);
    }
}
