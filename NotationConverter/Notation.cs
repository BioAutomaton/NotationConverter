namespace NotationConverter
{
    abstract class Notation : INotation
    {
        private const string ALPHABET = "";
        private string number = "";

        public bool IsCorrect(string number, string ALPHABET)
        {
            bool isCorrect = true;

            foreach (char c in number)
            {
                bool isAlpha = false;
                /*check if char is in notation's alphabet to determine if it fits*/
                foreach (char alpha in ALPHABET)
                {
                    if (c == alpha)
                    {
                        isAlpha = true;
                        break;
                    }
                }

                /*if char doesn't fit, break and return false*/
                if (!isAlpha)
                {
                    isCorrect = false;
                    break;
                }
            }

            /*if all chars do fit, return true*/
            return isCorrect;
        }

        public N10 ToN10()
        {
            throw new System.NotImplementedException();
        }

        public N16 ToN16()
        {
            throw new System.NotImplementedException();
        }

        public N2 ToN2()
        {
            throw new System.NotImplementedException();
        }

        public N8 ToN8()
        {
            throw new System.NotImplementedException();
        }
    }
}