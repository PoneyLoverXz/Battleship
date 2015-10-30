using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Client
{
    public enum ShipOrientation{
        Vertical, Horizontal
    };

    public class Ships
    {
        string Name;
        string Code;
        int Length;

        public Ships(string name, int length, string code)
        {
            Name = name;
            Length = length;
            Code = code;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetCode()
        {
            return Code;
        }

        public int GetLength()
        {
            return Length;
        }
    }

}
