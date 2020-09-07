using System;

namespace NotationConverter
{
    internal class N2 : Notation, INotation
    {
        public const string ALPHABET = "01";
        private string number = "";
        public const int BASE = 2;

        public string Number { get => number; private set => number = value; }

        public override string ToString()
        {
            return this.Number;
        }

        public N2(string number)
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
            return this;
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
            /*TODO*/
            throw new NotImplementedException();
        }
    }
}