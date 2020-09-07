using System;

namespace NotationConverter
{
    class N16 : Notation, INotation
    {
        public const string ALPHABET = "0123456789ABCDEF";
        private string number = "";
        public const int BASE = 16;

        public string Number { get => number; private set => number = value; }

        public N16(string number)
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
            string output = "";
            foreach (char c in this.Number)
            {
                output += N2.tetradas[N16.ALPHABET.IndexOf(c)];
            }
            return new N2(output);
        }

        public N8 ToN8()
        {
            N2 n2 = this.ToN2();
            return n2.ToN8();
        }

        public N10 ToN10()
        {
            // FORMULA: SUM = A[i] * P^i
            ulong sum = 0;
            for (int i = number.Length - 1; i >= 0; i--) // position of digit in the number, start at the end
            {
                for (int a = 0; a < ALPHABET.Length; a++)
                {
                    if (number[i] == ALPHABET[a]) // value on position i
                    {
                        ulong P = 1;
                        for (int power = 1; power <= number.Length - 1 - i; power++)
                        {
                            P *= BASE;
                        }
                        sum += (ulong)a * P;
                    }
                }
            }
            return new N10(sum.ToString());
        }

        public N16 ToN16()
        {
            return this;
        }
    }
}