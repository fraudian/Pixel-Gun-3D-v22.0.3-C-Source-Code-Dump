using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class RC5Parameters : KeyParameter
    {
        // Fields
        private readonly int rounds;
        
        // Properties
        public int Rounds { get; }
        
        // Methods
        public RC5Parameters(byte[] key, int rounds)
        {
            if(key.Length < 256)
            {
                    this.rounds = rounds;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "RC5 key length can be no greater than 255");
        }
        public int get_Rounds()
        {
            return (int)this.rounds;
        }
    
    }

}
