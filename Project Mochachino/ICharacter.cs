using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mochachino
{
    interface ICharacter
    {
        void performTurn();
        bool update(Action action);
    }
}
