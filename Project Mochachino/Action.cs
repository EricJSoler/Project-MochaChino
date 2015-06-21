using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mochachino
{
    public class Action : IAction
    {
        public Action()
        {
            damage = 10;
        }
        public bool performActionOn(Character toBeActedUpon)
        {
            if (toBeActedUpon.update(this)) {
                return true; //Or False depending on if the action was successful
            }
            else
                return false;
        }

        String actionName;

        public int damage;
        
        
        
       void actionAnimation()
        {
           //Perform the animation on the character who called this
        }

       void updatedAnimation(Character toBeActedUpon)
        {
           //perform action on toBeActedUpun
        }
        
        
       
        public String getActionName(){
            return actionName;
        }
    }
}
