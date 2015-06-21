using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mochachino
{
    public class Character : ICharacter
    {
        public String characterName;
        int indexInGameState;
        Attributes characterType;
        List<Action> availableActions;
        Combat involvedCombatScene;

        public Character(Combat recieved, String name) //Probably send the type of character here so attributes knows what to load
        {
            availableActions = new List<Action>();
            involvedCombatScene = recieved;
            characterName = name;
            characterType = new Attributes();
            availableActions.Add(new Action());
        }

        public void performTurn()
        {
            Console.WriteLine("Choose Action: ");
            int i = 0;
            foreach (Action element in availableActions) {
                Console.Write(i++);
                Console.WriteLine(element.getActionName());
            }
            Console.WriteLine("Press the number for the Action You Want");
            int actionNumber;
            actionNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Who do you want to perform the action on");
            
            i = 0;
            List<Character> potentialAttacks = new List<Character>();
            foreach( Character element in involvedCombatScene.getCharacters().Values){
                Console.Write(i++);
                Console.WriteLine(element.getCharacterName());
                potentialAttacks.Add(element);
            }
            int characterNumber = Convert.ToInt32(Console.ReadLine());
            Character toBeActedUpon = potentialAttacks[characterNumber];//involvedCombatScene.getCharacterByName(characterNumber);
            availableActions[actionNumber].performActionOn(toBeActedUpon);
        }
        
        public bool update(Action recievedAction)
        {
            //Check Stats and take health or whatever
            characterType.loseHealth(recievedAction.damage);
            return false;
        }

        public String getCharacterName()
        {
            return characterName;
        }

        public Attributes getAttributes()
        {
            return characterType;
        }
    }
}
