using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class ECGost3410Signer : IDsa
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual string get_AlgorithmName()
        {
            return "ECGOST3410";
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
            val_5 = "EC private key required for signing";
            goto label_13;
            label_11:
            val_5 = "EC public key required for verification";
            label_13:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_5);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
        {
            var val_18;
            byte[] val_1 = new byte[0];
            val_18 = 0;
            goto label_2;
            label_6:
            val_18 = 1;
            val_1[0] = message[136111552];
            label_2:
            if(val_18 != val_1.Length)
            {
                goto label_6;
            }
            
            do
            {
                Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  this.key.parameters.n.BitLength, random:  this.random);
            }
            while(val_7.SignValue == 0);
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            Org.BouncyCastle.Math.BigInteger val_11 = this.Multiply(p:  this.key.parameters.g, k:  val_7).Mod(m:  this.key.parameters.n);
            if(val_11.SignValue != 0)
            {
                    Org.BouncyCastle.Math.BigInteger val_16 = val_7.Multiply(val:  new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1)).Add(value:  Multiply(val:  val_11)).Mod(m:  this.key.parameters.n);
                if(val_16.SignValue != 0)
            {
                    Org.BouncyCastle.Math.BigInteger[] val_18 = new Org.BouncyCastle.Math.BigInteger[2];
                val_18[0] = val_11;
                val_18[1] = val_16;
                return val_18;
            }
            
            }
        
        }
        public virtual bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            var val_19;
            var val_20;
            var val_21;
            byte[] val_1 = new byte[0];
            val_19 = 0;
            goto label_2;
            label_6:
            val_19 = 1;
            val_1[0] = message[136111552];
            label_2:
            if(val_19 != val_1.Length)
            {
                goto label_6;
            }
            
            val_20 = null;
            val_20 = null;
            if(((r.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.One)) & 2147483648) == 0)
            {
                    if(((r.CompareTo(value:  this.key.parameters.n)) & 2147483648) != 0)
            {
                goto label_14;
            }
            
            }
            
            label_36:
            var val_20 = 0;
            label_41:
            val_20 = val_20 & 1;
            return (bool)val_20;
            label_14:
            val_21 = null;
            val_21 = null;
            if((((s.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.One)) & 2147483648) != 0) || (((s.CompareTo(value:  this.key.parameters.n)) & 2147483648) == 0))
            {
                goto label_36;
            }
            
            Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1).ModInverse(m:  this.key.parameters.n);
            Org.BouncyCastle.Math.EC.ECPoint val_16 = Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(P:  this.key.parameters.g, a:  s.Multiply(val:  val_7).Mod(m:  this.key.parameters.n), Q:  0, b:  this.key.parameters.n.Subtract(n:  r).Multiply(val:  val_7).Mod(m:  this.key.parameters.n));
            if(val_16.IsInfinity == true)
            {
                goto label_36;
            }
            
            if((val_16.Mod(m:  this.key.parameters.n)) != null)
            {
                goto label_41;
            }
            
            goto label_41;
        }
        protected virtual Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
        {
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
        }
        public ECGost3410Signer()
        {
        
        }
    
    }

}
