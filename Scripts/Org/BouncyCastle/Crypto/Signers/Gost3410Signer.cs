using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class Gost3410Signer : IDsa
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters key;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual string get_AlgorithmName()
        {
            return "GOST3410";
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Security.SecureRandom val_3;
            string val_5;
            val_3 = forSigning;
            if(val_3 == false)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Security.SecureRandom val_1 = null;
            val_3 = val_1;
            val_1 = new Org.BouncyCastle.Security.SecureRandom();
            this.random = val_3;
            if(parameters == null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_1:
            if(parameters == null)
            {
                goto label_11;
            }
            
            this.key = parameters;
            return;
            label_8:
            val_5 = "GOST3410 private key required for signing";
            goto label_13;
            label_11:
            val_5 = "GOST3410 public key required for signing";
            label_13:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_5);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
        {
            var val_16;
            byte[] val_1 = new byte[0];
            val_16 = 0;
            goto label_2;
            label_6:
            val_16 = 1;
            val_1[0] = message[136111552];
            label_2:
            if(val_16 != val_1.Length)
            {
                goto label_6;
            }
            
            do
            {
                Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  this.key.parameters.q.BitLength, random:  this.random);
            }
            while(((val_4.CompareTo(value:  this.key.parameters.q)) & 2147483648) == 0);
            
            Org.BouncyCastle.Math.BigInteger val_7 = this.key.parameters.a.ModPow(e:  val_4, m:  this.key.parameters.p).Mod(m:  this.key.parameters.q);
            Org.BouncyCastle.Math.BigInteger[] val_15 = new Org.BouncyCastle.Math.BigInteger[2];
            val_15[0] = val_7;
            val_15[1] = val_4.Multiply(val:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1)).Add(value:  this.key.Multiply(val:  val_7)).Mod(m:  this.key.parameters.q);
            return val_15;
        }
        public virtual bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            Org.BouncyCastle.Math.BigInteger val_22;
            var val_23;
            Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters val_24;
            var val_25;
            var val_26;
            val_22 = s;
            byte[] val_1 = new byte[0];
            val_23 = 0;
            goto label_2;
            label_6:
            val_23 = 1;
            val_1[0] = message[136111552];
            label_2:
            if(val_23 != val_1.Length)
            {
                goto label_6;
            }
            
            val_24 = this.key;
            if((r.SignValue & 2147483648) != 0)
            {
                goto label_16;
            }
            
            val_24 = this.key.parameters.q;
            if(((val_24.CompareTo(value:  r)) < 1) || ((val_22.SignValue & 2147483648) != 0))
            {
                goto label_16;
            }
            
            val_24 = this.key.parameters.q;
            if((val_24.CompareTo(value:  val_22)) < 1)
            {
                goto label_16;
            }
            
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Math.BigInteger val_8 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1).ModPow(e:  this.key.parameters.q.Subtract(n:  Org.BouncyCastle.Math.BigInteger.Two), m:  this.key.parameters.q);
            val_24 = this.key.parameters.p;
            val_22 = this.key.parameters.a.ModPow(e:  val_22.Multiply(val:  val_8).Mod(m:  this.key.parameters.q), m:  this.key.parameters.p).Multiply(val:  this.key.ModPow(e:  this.key.parameters.q.Subtract(n:  r).Multiply(val:  val_8).Mod(m:  this.key.parameters.q), m:  val_24)).Mod(m:  this.key.parameters.p);
            val_26 = val_22.Mod(m:  this.key.parameters.q);
            goto label_37;
            label_16:
            val_26 = 0;
            label_37:
            val_26 = val_26 & 1;
            return (bool)val_26;
        }
        public Gost3410Signer()
        {
        
        }
    
    }

}
