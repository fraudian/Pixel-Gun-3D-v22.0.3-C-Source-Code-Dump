using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : ICipherParameters
    {
        // Fields
        private readonly byte[] associatedText;
        private readonly byte[] nonce;
        private readonly Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
        private readonly int macSize;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Parameters.KeyParameter Key { get; }
        public virtual int MacSize { get; }
        
        // Methods
        public AeadParameters(Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int macSize, byte[] nonce)
        {
            this.nonce = nonce;
            this.key = key;
            this.associatedText = 0;
            this.macSize = macSize;
        }
        public AeadParameters(Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
        {
            this.nonce = nonce;
            this.key = key;
            this.associatedText = associatedText;
            this.macSize = macSize;
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.KeyParameter get_Key()
        {
            return (Org.BouncyCastle.Crypto.Parameters.KeyParameter)this.key;
        }
        public virtual int get_MacSize()
        {
            return (int)this.macSize;
        }
        public virtual byte[] GetAssociatedText()
        {
            return (System.Byte[])this.associatedText;
        }
        public virtual byte[] GetNonce()
        {
            return (System.Byte[])this.nonce;
        }
    
    }

}
