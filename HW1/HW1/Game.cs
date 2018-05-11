using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Game
    {
        int size;
        int[][] field;

        public Game(int s)
        {
            size = s;
            field = new int[size][];
            for (int i = 0; i < size; i++)
            {
                field[i] = new int[size];
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    field[i][j] = -1;
                }
            }
        }

        public void add(int x, int y, int num)
        {
            if (field[x][y] == -1)
            {
                field[x][y] = num;
            }
        }

        public bool check()
        {
            bool g = false, v = false, dg = false,dp=false;
            for(int i = 0; i < size-1; i++)
            {
                for(int j = 0; j < size-1; j++)
                {
                    if (field[i][j] != -1)
                    {
                        if (field[i][j] != field[i + 1][j])
                        {
                            g = false;
                        }
                        else g = true;
                        if (field[i][j] != field[i][j + 1])
                        {
                            v = false;
                        }
                        else v = true;
                    }
                    if (field[i][i] != -1)
                    {
                        if (field[i][i] != field[i + 1][i + 1])
                        {
                            dg = false;
                        }
                        else dg = true;
                    }
                    if (field[size - 1 - i][i] != -1)
                    {
                        if (field[size - 1 - i][i] != field[size-2-i][i+1])
                        {
                            dp = false;
                        }
                        else dp = true;
                    }
                }
            }
            if (g == true || v == true || dg == true || dp == true) return true;
            return false;
        }

        public string gameFild()
        {
            string str = "";
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    str += field[i][j] + " ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
