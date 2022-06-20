using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;
using ProjectSRPG2nd.data;

using static DxLibDLL.DX;

namespace ProjectSRPG2nd
{
    public class Program
    {
        static int Main(string[] args)
        {
            ChangeWindowMode(TRUE);
            if (DxLib_Init() == -1) return -1;
            WaitKey();
            DxLib_End();
            return 0;
        }
    }
}
