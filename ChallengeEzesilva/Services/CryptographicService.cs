using ChallengeEzesilva.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEzesilva.Services
{
    public class CryptographicService
    {
        private List<ISecurityElement> strategies { get; set; }

        public CryptographicService()
        {

        }

        public void Add(ISecurityElement strategy)
        {
            if (strategies == null)
                strategies = new List<ISecurityElement>();

            strategies.Add(strategy);
        }

        public string Encrypt(string text)
        {
            if (strategies == null || strategies.Count == 0)
                return text;


            string temptext = "";
            bool firstStrategy = true;
            for (int i = 0; i < strategies.Count; i++)
            {
                if (firstStrategy)
                {
                    temptext = strategies[i].Encrypt(text);
                    firstStrategy = false;
                }
                else
                    temptext = strategies[i].Encrypt(temptext);

                Console.WriteLine($"{strategies[i].GetType().Name} encrypt result: {temptext}");
            }

            return temptext;
        }

        public string Decrypt(string text)
        {
            if (strategies == null || strategies.Count == 0)
                return text;


            string temptext = "";
            bool firstStrategy = true;
            for (int i = strategies.Count - 1; i >= 0; i--)
            {
                if (firstStrategy)
                {
                    temptext = strategies[i].Decrypt(text);
                    firstStrategy = false;
                }
                else
                    temptext = strategies[i].Decrypt(temptext);

                Console.WriteLine($"{strategies[i].GetType().Name} decrypt result: {temptext}");
            }

            return temptext;
        }

    }
}
