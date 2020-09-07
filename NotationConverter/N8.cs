using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotationConverter
{
    class N8 : Notation, INotation
    {
        public const string ALPHABET = "01234567";
        private string number = "";
        public const int BASE = 8;

        public string Number { get => number; private set => number = value; }

        public override string ToString()
        {
            return this.Number;
        }

        public N8(string number)
        {
            if (IsCorrect(number, ALPHABET))
            {
                this.Number = number;
            }
            else
            {
                throw new Exception("Wrong entering");
            }
        }

        public N2 ToN2()
        {
            /*TODO*/
            throw new NotImplementedException();
        }

        public N8 ToN8()
        {
            throw new NotImplementedException();
        }

        public N10 ToN10()
        {
            throw new NotImplementedException();
        }

        public N16 ToN16()
        {
            throw new NotImplementedException();
        }
    }
}
