using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandungeon
{
    class Entity
    {
        int life;
        bool near = false;


        protected void walk ()
        {
            if (near == false)
            {
                near = true;
            } else
            {
                near = false;
            }
        }
    }
}
