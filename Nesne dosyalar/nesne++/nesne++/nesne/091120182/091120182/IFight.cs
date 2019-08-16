using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091120182
{
    interface IFight
    {
        bool ThrowBomb(ushort count);
        bool SendMissile(ushort count);
        bool Lock(int x,int y);

    }
}
