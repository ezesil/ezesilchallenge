using ChallengeEzesilva.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEzesilva.Strategy
{
    public class ShuffleAlgorithmStrategy : ISecurityElement
    {
        private int _shuffleCount = 3;

        public string Decrypt(string text)
        {
            var operatedText = text.ToList();

            return Shuffle(operatedText, -_shuffleCount);
        }

        public string Encrypt(string text)
        {
            var operatedText = text.ToList();

            return Shuffle(operatedText, _shuffleCount);
        }

        private string Shuffle(List<char> chars, int count)
        {
            if (count == 0)
                return new(chars.ToArray());

            char tempChar;

            if (count > 0)
            {
                tempChar = chars.Last();
                chars.RemoveAt(chars.IndexOf(chars.Last()));
                chars.Insert(0, tempChar);

                return Shuffle(chars, count - 1);
            }
            else
            {
                tempChar = chars.First();
                chars.RemoveAt(chars.IndexOf(chars.First()));
                chars.Add(tempChar);

                return Shuffle(chars, count + 1);
            }
        }
    }
}
