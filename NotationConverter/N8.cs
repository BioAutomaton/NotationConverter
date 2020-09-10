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
            string output = "";
            foreach (char c in this.Number)
            {
                output += N2.triadas[Convert.ToInt32(c.ToString())];
            }
            return new N2(output);
        }

        public N8 ToN8()
        {
            throw new NotImplementedException();
        }

        public N10 ToN10()
        {

            ulong sum = 0;
            for (int i = 0; i < number.Length; i++) // position of digit in the number
            {
                for (int a = 0; a < ALPHABET.Length; a++)
                {
                    if (number[i] == ALPHABET[a]) // value on position i
                    {
                        ulong P = 1;
                        for (int power = 1; power < number.Length - i; power++)
                        {
                            P *= BASE;
                        }
                        sum += (ulong)a * P;
                        break;
                    }
                }
            }
            return new N10(sum.ToString());
        }

        public N16 ToN16()
        {
            N2 n2 = this.ToN2();
            return n2.ToN16();
        }
    }
}
