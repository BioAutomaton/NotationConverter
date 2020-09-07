using System;

namespace NotationConverter
{
    class N2 : Notation, INotation
    {
        public const string ALPHABET = "01";
        public static string[] triadas = {"000", "001", "010", "011", "100", "101", "110", "111"};
        public static string[] tetradas = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
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

        public new N8 ToN8()
        {
            string output = "";
            while (Number.Length > 2)
            {
                string temp = Number.Substring(Number.Length - 3);
                Number = Number.Remove(Number.Length -3);
                for (int i = 0; i < N8.BASE; i++)
                {
                    if (temp == N2.triadas[i])
                    {
                        output += i.ToString();
                        break;
                    }
                }
            }

            if (Number.Length > 0) // if there is anything left, add zeros and convert
            {
                while (Number.Length > 0 && Number.Length < 3)
                {
                    Number = Number.Insert(0, "0");
                }
                for (int i = 0; i < N8.BASE; i++)
                {
                    if (Number == N2.triadas[i])
                    {
                        output += i.ToString();
                        break;
                    }
                }
            }

            char[] reversedOutput = output.ToCharArray();
            Array.Reverse(reversedOutput);

            return new N8(new string(reversedOutput));
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
            /*TODO*/
            string output = "";
            while (Number.Length > 3)
            {
                string temp = Number.Substring(Number.Length - 4);
                Number = Number.Remove(Number.Length - 4);
                for (int i = 0; i < N16.BASE; i++)
                {
                    if (temp == N2.tetradas[i])
                    {
                        output += N16.ALPHABET[i];
                        break;
                    }
                }
            }

            if (Number.Length > 0) // if there is anything left, add zeros and convert
            {
                while (Number.Length < 4)
                {
                    Number = Number.Insert(0, "0");
                }
                for (int i = 0; i < N16.BASE; i++)
                {
                    if (Number == N2.tetradas[i])
                    {
                        output += N16.ALPHABET[i];
                        break;
                    }
                }
            }

            char[] reversedOutput = output.ToCharArray();
            Array.Reverse(reversedOutput);

            return new N16(new string(reversedOutput));
        }
    }
}