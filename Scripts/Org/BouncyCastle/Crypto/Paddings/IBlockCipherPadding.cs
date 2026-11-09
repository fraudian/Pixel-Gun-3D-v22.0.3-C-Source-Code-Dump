using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public interface IBlockCipherPadding
    {
        // Properties
        public abstract string PaddingName { get; }
        
        // Methods
        public abstract void Init(Org.BouncyCastle.Security.SecureRandom random); // 0
        public abstract string get_PaddingName(); // 0
        public abstract int AddPadding(byte[] input, int inOff); // 0
        public abstract int PadCount(byte[] input); // 0
    
    }

}
