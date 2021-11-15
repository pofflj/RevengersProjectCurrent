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
                      (Program.c.NumberOfPlayers == 3 && player1.outOfWorkers && player2.outOfWorkers && player3.outOfWorkers) |
                      (Program.c.NumberOfPlayers == 2 && player1.outOfWorkers && player2.outOfWorkers))
            {
                roundEnded = true;
                EndRound();
            }
        }

        public void EndRound()
        {
            if (NumberOfPlayers == 2)
            {
                player1.Research += ResearchResource(player1);
                player2.Research += ResearchResource(player2);
                player1.Classes += ClassResource(player1);
                player2.Classes += ClassResource(player2);
                player1.Morale += MoraleResource(player1);
                player2.Morale += MoraleResource(player2);
                player1.Rest += RestResource(player1);
                player2.Rest += RestResource(player2);
                player1.MaxOfficeWorkers += NewWorker(player1);
                player2.MaxOfficeWorkers += NewWorker(player2);
                player1.roundReset();
                player2.roundReset();
            }
            else if (NumberOfPlayers == 3)
            {
                player1.Research += ResearchResource(player1);
                player2.Research += ResearchResource(player2);
                player3.Research += ResearchResource(player3);
                player1.Classes += ClassResource(player1);
                player2.Classes += ClassResource(player2);
                player3.Classes += ClassResource(player3);
                player1.Morale += MoraleResource(player1);
                player2.Morale += MoraleResource(player2);
                player3.Morale += MoraleResource(player3);
                player1.Rest += RestResource(player1);
                player2.Rest += RestResource(player2);
                player3.Rest += RestResource(player3);
                player1.roundReset();
                player2.roundReset();
                player3.roundReset();
            }
            else if (NumberOfPlayers == 4)
            {
                player1.Research += ResearchResource(player1);
                player2.Research += ResearchResource(player2);
                player3.Research += ResearchResource(player3);
                player4.Research += ResearchResource(player4);
                player1.Classes += ClassResource(player1);
                player2.Classes += ClassResource(player2);
                player3.Classes += ClassResource(player3);
                player4.Classes += ClassResource(player4);
                player1.Morale += MoraleResource(player1);
                player2.Morale += MoraleResource(player2);
                player3.Morale += MoraleResource(player3);
                player4.Morale += MoraleResource(player4);
                player1.Rest += RestResource(player1);
                player2.Rest += RestResource(player2);
                player3.Rest += RestResource(player3);
                player4.Rest += RestResource(player4);
                player1.roundReset();
                player2.roundReset();
                player3.roundReset();
                player4.roundReset();
            }
            player1.control = true;
        }

        public int ResearchResource(Player p)
        {
            int Research = 0;
            Random r = new Random();
            int roll = r.Next(1, 7);
            Research = p.WorkersAtResearchLab * roll;
            return Research;
        }
        public int ClassResource(Player p)
        {
            int Classes = 0;
            Random r = new Random();
            int roll = r.Next(1, 7);
            Classes = p.WorkersAtPeerProgramming * roll;
            return Classes;
        }
        public int MoraleResource(Player p)
        {
            int Morale = 0;
            Random r = new Random();
            int roll = r.Next(1, 7);
            Morale = p.WorkersAtGroupConference * roll;
            return Morale;
        }
        public int RestResource(Player p)
        {
            int Rest = 0;
            Random r = new Random();
            int roll = r.Next(1, 7);
            Rest = p.WorkersAtBreakRoom * roll * 2;
            return Rest;
        }
        public int NewWorker(Player p)
        {
            int Workers = 0;
            Random r = new Random();
            int roll = r.Next(1, 7);
            if (roll > 3)
            {
                Workers = p.WorkersAtGuestPresentation;
            }
            return Workers;
        }
    }
}
