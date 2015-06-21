using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mochachino
{
    public class Attributes
    {
        String name;
        public int health;
        int magicBonus;
        int attackDamageBonus;

        public Attributes()
        {
            //Load the attributes for the specific character
            health = 100;
        }
        public void loseHealth(int amount)
        {
            health -= amount;
        }
        
        public void gainHealth(int amount)
        {
            health += amount;
        }
    }
}
