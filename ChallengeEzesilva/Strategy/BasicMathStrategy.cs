using ChallengeEzesilva.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEzesilva.Strategy
{
    public class BasicMathStrategy : ISecurityElement
    {
        private Func<int,int> _encryptFunction;
        private Func<int,int> _decryptFunction;

        public BasicMathStrategy(Func<int, int> encryptFunction, Func<int, int> decryptFunction)
        {
            _encryptFunction = encryptFunction;
            _decryptFunction = decryptFunction;
        }

        public string? Decrypt(string text)
        {
            return new (text.ToCharArray()
                .Select(c => (char)_decryptFunction.Invoke(c))
                .ToArray());                   
        }

        public string Encrypt(string text)
        {
            return new(text.ToCharArray()
                .Select(c => (char)_encryptFunction.Invoke(c))
                .ToArray());
        }

    }
}
