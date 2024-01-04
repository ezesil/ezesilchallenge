using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEzesilva.Interfaces
{
    public interface ISecurityElement
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}
