using System;
using System.Collections.Generic;
using System.Text;

namespace RevengerProject3
{
    public class Controller
    {
        public int NumberOfPlayers { get; set; }
        public Player player1, player2, player3, player4;
        public bool roundEnded = false;

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
            if (Program.c.NumberOfPlayers == 2 && !(player1.outOfWorkers && player2.outOfWorkers))
            {
                player1.checkWorkers();
                player2.checkWorkers();
                if (player1.control)
                {
                    player1.control = false;
                    player2.control = true;
                    if (player2.outOfWorkers)
                        ChangeControl();
                }
                else if (player2.control)
                {
                        player2.control = false;
                        player1.control = true;
                        if (player1.outOfWorkers)
                            ChangeControl();
                }
            }
            else if (Program.c.NumberOfPlayers == 3 && !(player1.outOfWorkers && player2.outOfWorkers && player3.outOfWorkers))
            {
                player1.checkWorkers();
                player2.checkWorkers();
                player3.checkWorkers();
                if (player1.control)
                {
                    player1.control = false;
                    player2.control = true;
                    if (player2.outOfWorkers)
                        ChangeControl();
                }
                else if (player2.control)
                {
                    player2.control = false;
                    player3.control = true;
                    if (player3.outOfWorkers)
                        ChangeControl();
                }
                else if (player3.control)
                {
                    player3.control = false;
                    player1.control = true;
                    if (player1.outOfWorkers)
                        ChangeControl();
                }
            }
            else if (Program.c.NumberOfPlayers == 4 && !(player1.outOfWorkers && player2.outOfWorkers && player3.outOfWorkers && player4.outOfWorkers))
            {
                player1.checkWorkers();
                player2.checkWorkers();
                player3.checkWorkers();
                player4.checkWorkers();
                if (player1.control)
                {
                    player1.control = false;
                    player2.control = true;
                    if (player2.outOfWorkers)
                        ChangeControl();
                }
                else if (player2.control)
                {
                    player2.control = false;
                    player3.control = true;
                    if (player3.outOfWorkers)
                        ChangeControl();
                }
                else if (player3.control)
                {
                    player3.control = false;
                    player4.control = true;
                    if (player4.outOfWorkers)
                        ChangeControl();
                }
                else if (player4.control)
                {
                    player4.control = false;
                    player1.control = true;
                    if (player1.outOfWorkers)
                        ChangeControl();
                }
            }
            else if ((Program.c.NumberOfPlayers == 4 && player1.outOfWorkers && player2.outOfWorkers && player3.outOfWorkers && player4.outOfWorkers) |
                      Program.c.NumberOfPlayers == 3 && player1.outOfWorkers && player2.outOfWorkers && player3.outOfWorkers |
                      Program.c.NumberOfPlayers == 2 && player1.outOfWorkers && player2.outOfWorkers)
            {
                roundEnded = true;
                EndRound();
            }
        }

        public void EndRound()
        {
            if (NumberOfPlayers == 2)
            {
                player1.roundReset();
                player2.roundReset();
            }
            else if (NumberOfPlayers == 3)
            {
                player1.roundReset();
                player2.roundReset();
                player3.roundReset();
            }
            else if (NumberOfPlayers == 4)
            {
                player1.roundReset();
                player2.roundReset();
                player3.roundReset();
                player4.roundReset();
            }
            player1.control = true;
        }
    }
}
