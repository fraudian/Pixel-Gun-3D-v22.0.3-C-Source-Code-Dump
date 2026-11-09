using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter;
        private readonly Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateParameter;
        
        // Properties
        public Org.BouncyCastle.Crypto.AsymmetricKeyParameter Public { get; }
        public Org.BouncyCastle.Crypto.AsymmetricKeyParameter Private { get; }
        
        // Methods
        public AsymmetricCipherKeyPair(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateParameter)
        {
            string val_4;
            string val_5;
            val_1 = new System.Object();
            if(publicParameter.privateKey == true)
            {
                goto label_2;
            }
            
            if(privateParameter.privateKey == false)
            {
                goto label_4;
            }
            
            this.publicParameter = publicParameter;
            this.privateParameter = val_1;
            return;
            label_2:
            val_4 = "Expected a public key";
            val_5 = "publicParameter";
            goto label_5;
            label_4:
            val_4 = "Expected a private key";
            val_5 = "privateParameter";
            label_5:
            null = new System.ArgumentException(message:  val_4, paramName:  val_5);
        }
        public Org.BouncyCastle.Crypto.AsymmetricKeyParameter get_Public()
        {
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)this.publicParameter;
        }
        public Org.BouncyCastle.Crypto.AsymmetricKeyParameter get_Private()
        {
            return (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)this.privateParameter;
        }
    
    }

}
