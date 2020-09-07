using System;
using System.Linq;

namespace NotationConverter
{
    class N10 : Notation, INotation
    {
        public const string ALPHABET = "0123456789";
        private string number;
        public const int BASE = 10;

        public string Number { get => number; private set => number = value; }

        public N10(string number)
        {
            number = number.ToUpper();
            if (IsCorrect(number, ALPHABET))
            {
                this.Number = number;
            }
            else
            {
                throw new Exception("Wrong entering");
            }
        }

        public override string ToString()
        {
            return this.Number;
        }

        public N2 ToN2()
        {
            ulong input = Convert.ToUInt64(this.Number);
            string output = "";
            while (input >= N2.BASE)
            {
                output += (input % N2.BASE).ToString();
                input /= N2.BASE;
            }
            output += input.ToString();
            char[] toReverse = output.ToCharArray();
            Array.Reverse(toReverse);
            return new N2(new string(toReverse));
        }

        public N8 ToN8()
        {
            ulong input = Convert.ToUInt64(this.Number);
            string output = "";
            while (input >= N8.BASE)
            {
                output += (input % N8.BASE).ToString();
                input /= N8.BASE;
            }
            output += input.ToString();
            char[] reversedOutput = output.ToCharArray();
            Array.Reverse(reversedOutput);
            return new N8(new string(reversedOutput));
        }

        public N10 ToN10()
        {
            return this;
        }

        public N16 ToN16()
        {
            ulong input = Convert.ToUInt64(this.Number);
            string output = "";
            while (input >= N16.BASE)
            {
                output += N16.ALPHABET[(int)(input % N16.BASE)];
                input /= N16.BASE;
            }
            output += N16.ALPHABET[(int)input];
            char[] toReverse = output.ToCharArray();
            Array.Reverse(toReverse);
            return new N16(new string(toReverse));
        }

    }
}