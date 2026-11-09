using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class RsaBlindedEngine : IAsymmetricBlockCipher
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Engines.RsaCoreEngine core;
        private Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual string get_AlgorithmName()
        {
            return "RSA";
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters param)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_7 = param;
            forEncryption = forEncryption;
            if(val_7 != null)
            {
                    val_7 = 0;
            }
            
            this.key = val_7;
            this.random = new Org.BouncyCastle.Security.SecureRandom();
        }
        public virtual int GetInputBlockSize()
        {
            if(this.core == null)
            {
                
            }
        
        }
        public virtual int GetOutputBlockSize()
        {
            if(this.core == null)
            {
                
            }
        
        }
        public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
        {
            Org.BouncyCastle.Crypto.Engines.RsaCoreEngine val_14;
            string val_17;
            if(this.key != null)
            {
                    val_14 = this.core;
                if(val_14 == null)
            {
                    val_14 = 0;
            }
            
                if(this.core != null)
            {
                    return (System.Byte[])this.core;
            }
            
                return (System.Byte[])this.core;
            }
            
            val_17 = "RSA engine not initialised";
            null = new System.InvalidOperationException(message:  val_17);
        }
        public RsaBlindedEngine()
        {
            this.core = new Org.BouncyCastle.Crypto.Engines.RsaCoreEngine();
        }
    
    }

}
