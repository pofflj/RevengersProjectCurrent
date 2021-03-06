using System;
using System.Collections.Generic;
using System.Text;

namespace RevengerProject3
{
    public class Player
    {
        //max number of office workers
        public int MaxOfficeWorkers { get; set; }
        public int OfficeWorkers { get; set; }
        public string Name { get; set; }
        public bool control = false;
        public bool outOfWorkers = false;
        public int WorkersAtResearchLab { get; set; }
        public int WorkersAtPeerProgramming { get; set; }
        public int WorkersAtGroupConference { get; set; }
        public int WorkersAtBreakRoom { get; set; }
        public int WorkersAtGuestPresentation { get; set; }
        public int WorkersAtArchives { get; set; }
        public int Research { get; set; }
        public int Classes { get; set; }
        public int Morale { get; set; }
        public int Rest { get; set; }

        public Player(string name)
        {
            Name = name;
            MaxOfficeWorkers = 5;
            OfficeWorkers = MaxOfficeWorkers;

        }

        public void checkWorkers()
        {
            if (OfficeWorkers == 0)
                outOfWorkers = true;
        }

        public void roundReset()
        {
            OfficeWorkers = MaxOfficeWorkers;
            control = false;
            outOfWorkers = false;
            WorkersAtArchives = 0;
            WorkersAtBreakRoom = 0;
            WorkersAtGroupConference = 0;
            WorkersAtGuestPresentation = 0;
            WorkersAtPeerProgramming = 0;
            WorkersAtResearchLab = 0;
        }
    }
}
