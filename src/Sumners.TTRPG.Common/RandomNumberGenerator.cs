using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumners.TTRPG.Common
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _globalRandom = new Random(Guid.NewGuid().GetHashCode());
        private static readonly object globalLock = new object();

        private static readonly ThreadLocal<Random> threadRandom = new ThreadLocal<Random>(NewRandom);

        public static Random NewRandom()
        {
            lock (globalLock)
            {
                return new Random(_globalRandom.Next());
            }
        }

        public static Random Instance { get { return threadRandom?.Value ?? throw new ApplicationException("Somethign went wrong with generating a new random bumber generator."); } }

        public static int Next()
        {
            return Instance.Next();
        }
    }
}
