using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class DsaSigner : IDsa
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator;
        protected Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters key;
        protected Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public DsaSigner()
        {
            this.kCalculator = new Org.BouncyCastle.Crypto.Signers.RandomDsaKCalculator();
        }
        public DsaSigner(Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator)
        {
            this.kCalculator = kCalculator;
        }
        public virtual string get_AlgorithmName()
        {
            return "DSA";
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_5;
            var val_7;
            var val_8;
            string val_10;
            if(forSigning == false)
            {
                goto label_1;
            }
            
            if(parameters == null)
            {
                goto label_19;
            }
            
            val_5 = 0;
            this.key = parameters;
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_11;
            label_1:
            if(parameters == null)
            {
                goto label_14;
            }
            
            val_7 = 0;
            val_5 = 0;
            this.key = parameters;
            var val_2 = (this == 0) ? 1 : 0;
            goto label_17;
            label_11:
            val_7 = (~this.kCalculator.IsDeterministic) & 1;
            if(this != null)
            {
                    val_8 = 0;
            }
            else
            {
                    val_8 = 1;
            }
            
            label_17:
            this.random = this;
            return;
            label_14:
            val_10 = "DSA public key required for verification";
            goto label_21;
            label_19:
            val_10 = "DSA private key required for signing";
            label_21:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_10);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
        {
            Org.BouncyCastle.Math.BigInteger val_20;
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(this.kCalculator.IsDeterministic == false)
            {
                goto label_13;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_18;
            label_13:
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_23;
            label_18:
            this.kCalculator.Init(n:  this.key.parameters.q, d:  this.key, message:  message);
            goto label_24;
            label_23:
            this.kCalculator.Init(n:  this.key.parameters.q, random:  this.random);
            label_24:
            var val_21 = 0;
            val_21 = val_21 + 1;
            Org.BouncyCastle.Math.BigInteger val_9 = this.kCalculator.NextK();
            if(this.key.parameters != null)
            {
                    val_20 = this.key.parameters.g;
            }
            else
            {
                    val_20 = 64;
            }
            
            Org.BouncyCastle.Math.BigInteger val_11 = val_20.ModPow(e:  val_9, m:  this.key.parameters.p).Mod(m:  this.key.parameters.q);
            Org.BouncyCastle.Math.BigInteger val_13 = this.key.Multiply(val:  val_11);
            Org.BouncyCastle.Math.BigInteger[] val_17 = new Org.BouncyCastle.Math.BigInteger[2];
            val_17[0] = val_11;
            val_17[1] = val_9.ModInverse(m:  this.key.parameters.q).Multiply(val:  val_13.Add(value:  val_13)).Mod(m:  this.key.parameters.q);
            return val_17;
        }
        public virtual bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            var val_18;
            Org.BouncyCastle.Math.BigInteger val_19;
            var val_20;
            val_18 = this;
            val_19 = val_18;
            if((((r.SignValue >= 1) && ((this.key.parameters.q.CompareTo(value:  r)) >= 1)) && (s.SignValue >= 1)) && ((this.key.parameters.q.CompareTo(value:  s)) >= 1))
            {
                    Org.BouncyCastle.Math.BigInteger val_5 = s.ModInverse(m:  this.key.parameters.q);
                val_19 = r.Multiply(val:  val_5).Mod(m:  this.key.parameters.q);
                val_18 = this.key.parameters.g.ModPow(e:  val_5.Multiply(val:  val_5).Mod(m:  this.key.parameters.q), m:  this.key.parameters.p).Multiply(val:  this.key.ModPow(e:  val_19, m:  this.key.parameters.p)).Mod(m:  this.key.parameters.p);
                val_20 = val_18.Mod(m:  this.key.parameters.q);
            }
            else
            {
                    val_20 = 0;
            }
            
            val_20 = val_20 & 1;
            return (bool)val_20;
        }
        protected virtual Org.BouncyCastle.Math.BigInteger CalculateE(Org.BouncyCastle.Math.BigInteger n, byte[] message)
        {
            if(message == null)
            {
                goto label_1;
            }
            
            label_7:
            int val_1 = n.BitLength;
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  message, offset:  0, length:  System.Math.Min(val1:  message.Length, val2:  ((val_1 < 0) ? (val_1 + 7) : (val_1)) >> 3));
            label_1:
            if(n != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        protected virtual Org.BouncyCastle.Security.SecureRandom InitSecureRandom(bool needed, Org.BouncyCastle.Security.SecureRandom provided)
        {
            Org.BouncyCastle.Security.SecureRandom val_2 = provided;
            if(needed != false)
            {
                    if(val_2 != null)
            {
                    return (Org.BouncyCastle.Security.SecureRandom)val_2;
            }
            
                Org.BouncyCastle.Security.SecureRandom val_1 = null;
                val_2 = val_1;
                val_1 = new Org.BouncyCastle.Security.SecureRandom();
                return (Org.BouncyCastle.Security.SecureRandom)val_2;
            }
            
            val_2 = 0;
            return (Org.BouncyCastle.Security.SecureRandom)val_2;
        }
    
    }

}
