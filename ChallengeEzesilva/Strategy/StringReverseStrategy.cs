using ChallengeEzesilva.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEzesilva.Strategy
{
    public class StringReverseStrategy : ISecurityElement
    {
        public string Decrypt(string text)
        {
            return new (text.ToCharArray().Reverse().ToArray());
        }

        public string Encrypt(string text)
        {
            return new(text.ToCharArray().Reverse().ToArray());
        }
    }
}
