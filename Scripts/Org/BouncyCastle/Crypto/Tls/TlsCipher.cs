using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public interface TlsCipher
    {
        // Methods
        public abstract int GetPlaintextLimit(int ciphertextLimit); // 0
        public abstract byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len); // 0
        public abstract byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len); // 0
    
    }

}
