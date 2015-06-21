using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mochachino
{
    public class Combat
    {

        Dictionary<String, Character> characters;
        Boolean PartyAlive = true;
        Boolean EnemyAlive = true;
        int currentPlayer = 1;
        //int numberPlayers = checkNumPlayers();
           
            
        public Combat()
        {
            characters = new Dictionary<String, Character>();
            loadCharacters();
            gameState();
        }
        
        void loadCharacters()
        {
            String name = "TheGainsMan";
            characters.Add(name, new Character(this, name));
            name = "BrycesBitchAss";
            characters.Add(name, new Character(this, name));
        }

        void gameState()
        {
            for (int i = 0; i < 10; i++) {
                foreach (Character element in characters.Values) {
                    element.performTurn();
                    foreach (Character element1 in characters.Values) {
                        Console.WriteLine(element1.characterName);
                        Console.WriteLine(element1.getAttributes().health);
                    }
                }
            }
            //while (PartyAlive == true && EnemyAlive == true) //Continues until victory/defeat
            //{
            //    takeTurn(currentPlayer);
            //    PartyAlive = checkPartyAlive();
            //    EnemyAlive = checkEnemyAlive();
            //    //next round
            //    //numberPlayers = checkNumPlayers();
            //    currentPlayer++;
            //    //if (currentPlayer > numberPlayers)
            //    {
            //        currentPlayer = 1;
            //    }
            //}
            //if (PartyAlive == true && EnemyAlive == false) {
            //    //partyWon();
            //}
            //else if (PartyAlive == false && EnemyAlive == true) {
            //    //partyLost();
            //}
            //else if (PartyAlive == true && EnemyAlive == true) {
            //    //partyFled();
            //}
            //else {
            //    //errorFound();
            //}
        }
        
        bool checkPartyAlive()
        {
            //checks if party is alive
            return true;
        }

        bool checkEnemyAlive()
        {
            //checks if enemies are alive
            return true;
        }

        int checkNumPlayers()
        {
            //checks for number of Players
            return 5;
        }

        bool checkActive(int player)
        {
            Boolean active = true; //Checks the status page for current status
            return active;
        }

        void takeTurn(int player)
        {
            Boolean active = checkActive(player);
            if (active == false)
            {
                return;
            }

            //insert a timer
            int timer = 0;
            while (timer > 0)
            {
                //chooseResponse();
            }
            //performResponse();
        }

        public Dictionary<String, Character> getCharacters()
        {
            return characters;
        }

        public Character getCharacterByName(String name)
        {
            Character foundCharacter;
            characters.TryGetValue(name, out foundCharacter);
            return foundCharacter;
        }

    }
}
