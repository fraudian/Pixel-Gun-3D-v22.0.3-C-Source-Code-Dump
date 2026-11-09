using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class ECDsaSigner : IDsa
    {
        // Fields
        private static readonly Org.BouncyCastle.Math.BigInteger Eight;
        protected readonly Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator;
        protected Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;
        protected Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public ECDsaSigner()
        {
            this.kCalculator = new Org.BouncyCastle.Crypto.Signers.RandomDsaKCalculator();
        }
        public ECDsaSigner(Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator)
        {
            this.kCalculator = kCalculator;
        }
        public virtual string get_AlgorithmName()
        {
            return "ECDSA";
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
            val_10 = "EC public key required for verification";
            goto label_21;
            label_19:
            val_10 = "EC private key required for signing";
            label_21:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_10);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
        {
            Org.BouncyCastle.Math.BigInteger val_21;
            System.Byte[] val_22;
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_25;
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(this.kCalculator.IsDeterministic == false)
            {
                goto label_13;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_18;
            label_13:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_23;
            label_18:
            val_21 = this.key.parameters.n;
            val_22 = message;
            this.kCalculator.Init(n:  val_21, d:  this.key, message:  val_22);
            goto label_24;
            label_23:
            val_22 = public System.Void Org.BouncyCastle.Crypto.Signers.IDsaKCalculator::Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Security.SecureRandom random);
            val_21 = this.key.parameters.n;
            this.kCalculator.Init(n:  val_21, random:  this.random);
            label_24:
            do
            {
                var val_24 = 0;
                val_24 = val_24 + 1;
                Org.BouncyCastle.Math.BigInteger val_9 = this.kCalculator.NextK();
                var val_25 = 0;
                val_25 = val_25 + 1;
                Org.BouncyCastle.Math.BigInteger val_12 = this.Multiply(p:  this.key.parameters.g, k:  val_9).Mod(m:  this.key.parameters.n);
            }
            while(val_12.SignValue == 0);
            
            Org.BouncyCastle.Math.BigInteger val_15 = this.key.Multiply(val:  val_12);
            val_25 = this;
            if(this == null)
            {
                    val_25 = this;
            }
            
            Org.BouncyCastle.Math.BigInteger val_18 = val_9.ModInverse(m:  this.key.parameters.n).Multiply(val:  val_15.Add(value:  val_15)).Mod(m:  this.key.parameters.n);
            if(val_18.SignValue != 0)
            {
                    Org.BouncyCastle.Math.BigInteger[] val_20 = new Org.BouncyCastle.Math.BigInteger[2];
                val_20[0] = val_12;
                val_20[1] = val_18;
                return val_20;
            }
        
        }
        public virtual bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            var val_18;
            var val_19;
            val_18 = message;
            if((((r.SignValue < 1) || (s.SignValue < 1)) || (((r.CompareTo(value:  this.key.parameters.n)) & 2147483648) == 0)) || (((s.CompareTo(value:  this.key.parameters.n)) & 2147483648) == 0))
            {
                goto label_38;
            }
            
            Org.BouncyCastle.Math.BigInteger val_5 = s.ModInverse(m:  this.key.parameters.n);
            val_18 = Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(P:  this.key.parameters.g, a:  val_5.Multiply(val:  val_5).Mod(m:  this.key.parameters.n), Q:  0, b:  r.Multiply(val:  val_5).Mod(m:  this.key.parameters.n));
            if(val_18.IsInfinity == false)
            {
                goto label_24;
            }
            
            label_38:
            var val_18 = 0;
            label_45:
            val_18 = val_18 & 1;
            return (bool)val_18;
            label_24:
            if((val_18 == null) || (val_18 == null))
            {
                goto label_37;
            }
            
            val_19 = null;
            val_19 = null;
            if((val_18.CompareTo(value:  Org.BouncyCastle.Crypto.Signers.ECDsaSigner.Eight)) <= 0)
            {
                goto label_30;
            }
            
            label_37:
            if((val_18.Mod(m:  this.key.parameters.n)) != null)
            {
                goto label_45;
            }
            
            goto label_45;
            label_30:
            if((this == null) || ((this & 1) != 0))
            {
                goto label_37;
            }
            
            if((val_18 & 1) == 0)
            {
                goto label_38;
            }
            
            do
            {
                if((val_18 & 1) != 0)
            {
                goto label_45;
            }
            
                Org.BouncyCastle.Math.BigInteger val_17 = r.Add(value:  this.key.parameters.n);
            }
            while((val_18 & 1) != 0);
            
            goto label_45;
        }
        protected virtual Org.BouncyCastle.Math.BigInteger CalculateE(Org.BouncyCastle.Math.BigInteger n, byte[] message)
        {
            int val_1 = message.Length << 3;
            Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  message);
            if(n.BitLength >= val_1)
            {
                    return val_2;
            }
            
            return val_2.ShiftRight(n:  val_1 - n.BitLength);
        }
        protected virtual Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
        {
            return (Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier)new Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
        }
        protected virtual Org.BouncyCastle.Math.EC.ECFieldElement GetDenominator(int coordinateSystem, Org.BouncyCastle.Math.EC.ECPoint p)
        {
            if(coordinateSystem > 7)
            {
                    return 0;
            }
            
            var val_8 = 1;
            val_8 = val_8 << coordinateSystem;
            if((val_8 & 194) == 0)
            {
                    val_8 = val_8 & 28;
                if(val_8 == 0)
            {
                    return 0;
            }
            
                p = ???;
            }
            else
            {
                    if(p != 0)
            {
                goto val_8 + 520;
            }
            
            }
        
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
        private static ECDsaSigner()
        {
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner.Eight = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  8);
        }
    
    }

}
