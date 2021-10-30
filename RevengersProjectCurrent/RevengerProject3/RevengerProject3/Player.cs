using System;
using System.Collections.Generic;
using System.Text;

namespace RevengerProject3
{
    public class Player
    {
        public int OfficeWorkers { get; set; }
        public string Name { get; set; }
        public bool control = false;

        public Player(string name)
        {
            Name = name;            
        }
    }
}
