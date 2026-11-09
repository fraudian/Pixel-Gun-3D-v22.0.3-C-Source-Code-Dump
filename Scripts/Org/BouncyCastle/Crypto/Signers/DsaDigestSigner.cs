using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner : ISigner
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private readonly Org.BouncyCastle.Crypto.IDsa dsaSigner;
        private bool forSigning;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public DsaDigestSigner(Org.BouncyCastle.Crypto.IDsa signer, Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.digest = digest;
            this.dsaSigner = signer;
        }
        public virtual string get_AlgorithmName()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            return this.digest.AlgorithmName + "with" + this.dsaSigner.AlgorithmName;
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_11;
            string val_13;
            this.forSigning = forSigning;
            if(parameters != null)
            {
                    val_11 = parameters;
            }
            
            val_11 = 0;
            if(forSigning == false)
            {
                goto label_8;
            }
            
            if(val_11.IsPrivate == true)
            {
                goto label_10;
            }
            
            val_13 = "Signing Requires Private Key.";
            goto label_11;
            label_8:
            if(val_11.IsPrivate == true)
            {
                goto label_13;
            }
            
            label_10:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.dsaSigner.Init(forSigning:  forSigning, parameters:  parameters);
            return;
            label_13:
            val_13 = "Verification Requires Public Key.";
            label_11:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_13);
        }
        public virtual void Update(byte input)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  inOff, length:  length);
        }
        public virtual byte[] GenerateSignature()
        {
            var val_8;
            int val_10;
            if(this.forSigning != false)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                int val_2 = this.digest.GetDigestSize();
                byte[] val_3 = new byte[0];
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_8 = 0;
                int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_8 = 2;
                Org.BouncyCastle.Math.BigInteger[] val_7 = this.dsaSigner.GenerateSignature(message:  val_3);
                val_10 = val_7.Length;
                if(val_10 != 0)
            {
                    return val_7.DerEncode(r:  val_7[0], s:  val_7[1]);
            }
            
                val_10 = val_7.Length;
                return val_7.DerEncode(r:  val_7[0], s:  val_7[1]);
            }
            
            System.InvalidOperationException val_8 = new System.InvalidOperationException(message:  "DSADigestSigner not initialised for signature generation.");
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            int val_9;
            var val_11;
            if(this.forSigning != true)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                int val_2 = this.digest.GetDigestSize();
                byte[] val_3 = new byte[0];
                var val_12 = 0;
                val_12 = val_12 + 1;
                Org.BouncyCastle.Math.BigInteger[] val_6 = this.digest.DoFinal(output:  val_3, outOff:  0).DerDecode(encoding:  signature);
                val_9 = val_6.Length;
                if(val_9 == 0)
            {
                    val_9 = val_6.Length;
            }
            
                var val_15 = 0;
                val_15 = val_15 + 1;
                return (bool)this.dsaSigner.VerifySignature(message:  val_3, r:  val_6[0], s:  val_6[1]);
            }
            
            val_11 = new System.InvalidOperationException(message:  "DSADigestSigner not initialised for verification");
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    return (bool)this.dsaSigner.VerifySignature(message:  val_3, r:  val_6[0], s:  val_6[1]);
            }
            
                mem[8] = null;
                val_11 = 8;
            }
        
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
        }
        private byte[] DerEncode(Org.BouncyCastle.Math.BigInteger r, Org.BouncyCastle.Math.BigInteger s)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            Org.BouncyCastle.Asn1.DerInteger val_2 = new Org.BouncyCastle.Asn1.DerInteger(value:  r);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new Org.BouncyCastle.Asn1.DerInteger(value:  s);
            Org.BouncyCastle.Asn1.DerSequence val_4 = new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
            if(val_4 != null)
            {
                    return val_4.GetDerEncoded();
            }
            
            return val_4.GetDerEncoded();
        }
        private Org.BouncyCastle.Math.BigInteger[] DerDecode(byte[] encoding)
        {
            var val_12;
            var val_13;
            var val_14;
            Org.BouncyCastle.Asn1.Asn1Object val_1 = Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  encoding);
            Org.BouncyCastle.Math.BigInteger[] val_4 = new Org.BouncyCastle.Math.BigInteger[2];
            val_12 = mem[282584257677167];
            val_13 = 0;
            if(val_13 != 0)
            {
                    val_12 = 0;
                val_12 = 0;
                val_13 = 0;
            }
            
            Org.BouncyCastle.Math.BigInteger val_7 = val_13.Value;
            if((val_7 != null) && (val_7 == null))
            {
                    val_12 = 0;
            }
            
            if(val_4.Length == 0)
            {
                    val_12 = 0;
            }
            
            val_4[0] = val_7;
            val_14 = 0;
            if(val_14 != 0)
            {
                    val_14 = 0;
            }
            
            val_4[1] = val_14.Value;
            return val_4;
        }
    
    }

}
