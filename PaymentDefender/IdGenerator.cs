using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class IdGenerator
    {
        private static Dictionary<int, bool> _usedIds = new Dictionary<int, bool>();
        private static int _currentId = 0;

        public static int GenerateUniqueId()
        {
            while (true)
            {
                int candidateId = _currentId++;
                if (!_usedIds.ContainsKey(candidateId))
                {
                    _usedIds.Add(candidateId, false);
                    return candidateId;
                }
            }
        }
    }
}
