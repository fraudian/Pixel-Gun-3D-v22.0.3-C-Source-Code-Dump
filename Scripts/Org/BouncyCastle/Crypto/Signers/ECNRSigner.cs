using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class ECNRSigner : IDsa
    {
        // Fields
        private bool forSigning;
        private Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;
        private Org.BouncyCastle.Security.SecureRandom random;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual string get_AlgorithmName()
        {
            return "ECNR";
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            bool val_4;
            string val_6;
            val_4 = forSigning;
            this.forSigning = val_4;
            if(val_4 == false)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Security.SecureRandom val_2 = null;
            val_4 = val_2;
            val_2 = new Org.BouncyCastle.Security.SecureRandom();
            this.random = val_4;
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
            val_6 = "EC private key required for signing";
            goto label_13;
            label_11:
            val_6 = "EC public key required for verification";
            label_13:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_6);
        }
        public virtual Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
        {
            Org.BouncyCastle.Crypto.Parameters.ECKeyParameters val_27;
            var val_28;
            var val_29;
            if(this.forSigning == false)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  message);
            val_27 = this.key;
            if(val_27 != null)
            {
                    val_27 = 0;
            }
            
            if(val_5.BitLength > this.key.parameters.n.BitLength)
            {
                goto label_13;
            }
            
            do
            {
                Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator val_8 = new Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator();
                Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters val_9 = new Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(domainParameters:  64, random:  this.random);
                if(val_8 != null)
            {
                    val_8.Init(parameters:  val_9);
            }
            else
            {
                    val_8.Init(parameters:  val_9);
            }
            
                Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair val_10 = val_8.GenerateKeyPair();
                Org.BouncyCastle.Math.BigInteger val_15 = val_10.Public.Add(value:  val_5).Mod(m:  this.key.parameters.n);
            }
            while(val_15.SignValue == 0);
            
            Org.BouncyCastle.Math.BigInteger[] val_23 = new Org.BouncyCastle.Math.BigInteger[2];
            val_23[0] = val_15;
            val_23[1] = val_10.Private.Subtract(n:  val_15.Multiply(val:  0)).Mod(m:  this.key.parameters.n);
            return val_23;
            label_47:
            goto label_47;
            label_1:
            System.InvalidOperationException val_24 = null;
            val_29 = val_24;
            val_24 = new System.InvalidOperationException(message:  "not initialised for signing");
            goto label_46;
            label_13:
            Org.BouncyCastle.Crypto.DataLengthException val_25 = null;
            val_29 = val_25;
            val_25 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input too large for ECNR key.");
            label_46:
            val_28 = 1152921549877904640;
            goto label_47;
        }
        public virtual bool VerifySignature(byte[] message, Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            Org.BouncyCastle.Crypto.Parameters.ECKeyParameters val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this.forSigning == true)
            {
                goto label_1;
            }
            
            val_16 = this.key;
            val_16 = 0;
            if((new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  message).BitLength) > 123372880.BitLength)
            {
                goto label_8;
            }
            
            val_17 = null;
            val_17 = null;
            if(((r.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.One)) & 2147483648) == 0)
            {
                    if(((r.CompareTo(value:  123372880)) & 2147483648) != 0)
            {
                goto label_14;
            }
            
            }
            
            label_24:
            var val_16 = 0;
            label_30:
            val_16 = val_16 & 1;
            return (bool)val_16;
            label_14:
            val_18 = null;
            val_18 = null;
            if((((s.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.Zero)) & 2147483648) != 0) || (((s.CompareTo(value:  123372880)) & 2147483648) == 0))
            {
                goto label_24;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_10 = Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(P:  123372880, a:  s, Q:  0, b:  r);
            if(val_10.IsInfinity == true)
            {
                goto label_24;
            }
            
            if((r.Subtract(n:  val_10).Mod(m:  123372880)) != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_1:
            System.InvalidOperationException val_14 = null;
            val_19 = val_14;
            val_14 = new System.InvalidOperationException(message:  "not initialised for verifying");
            goto label_32;
            label_8:
            Org.BouncyCastle.Crypto.DataLengthException val_15 = null;
            val_19 = val_15;
            val_15 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input too large for ECNR key.");
            label_32:
        }
        public ECNRSigner()
        {
        
        }
    
    }

}
