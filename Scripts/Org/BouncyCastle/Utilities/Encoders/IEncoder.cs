using UnityEngine;

namespace Org.BouncyCastle.Utilities.Encoders
{
    public interface IEncoder
    {
        // Methods
        public abstract int Encode(byte[] data, int off, int length, System.IO.Stream outStream); // 0
        public abstract int Decode(byte[] data, int off, int length, System.IO.Stream outStream); // 0
        public abstract int DecodeString(string data, System.IO.Stream outStream); // 0
    
    }

}
