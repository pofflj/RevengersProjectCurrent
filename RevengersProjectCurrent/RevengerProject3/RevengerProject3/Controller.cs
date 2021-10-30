using System;
using System.Collections.Generic;
using System.Text;

namespace RevengerProject3
{
    public class Controller
    {
        public int NumberOfPlayers { get; set; }
        public Player player1, player2, player3, player4;

        public Controller()
        {
            
        }

        public Controller(int p, string pName1, string pName2)
        {
            NumberOfPlayers = p;
            Player player1 = new Player(pName1);
            Player player2 = new Player(pName2);
            player1.control = true;
        }

        public Controller(int p, string pName1, string pName2, string pName3)
        {
            NumberOfPlayers = p;
            Player player1 = new Player(pName1);
            Player player2 = new Player(pName2);
            Player player3 = new Player(pName3);
            player1.control = true;
        }

        public Controller(int p, string pName1, string pName2, string pName3, string pName4)
        {
            NumberOfPlayers = p;
            Player player1 = new Player(pName1);
            Player player2 = new Player(pName2);
            Player player3 = new Player(pName3);
            Player player4 = new Player(pName4);
            player1.control = true;
        }

        public void ChangeControl()
        {
            if (player1.control)
            {
                player1.control = false;
                player2.control = true;
            }
            else if (player2.control)
            {
                if (Program.c.NumberOfPlayers >2)
                {
                    player2.control = false;
                    player3.control = true;
                }
                else
                {
                    player2.control = false;
                    player1.control = true;
                }
            }
            else if (player3.control)
            {
                if (Program.c.NumberOfPlayers > 3)
                {
                    player3.control = false;
                    player4.control = true;
                }
                else
                {
                    player3.control = false;
                    player1.control = true;
                }
            }
            else if (player4.control)
            {
                player4.control = false;
                player1.control = true;
            }
        }
    }
}
