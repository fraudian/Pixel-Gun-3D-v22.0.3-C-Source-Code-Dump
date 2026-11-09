using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class Ssl3Mac : IMac
    {
        // Fields
        private const byte IPAD_BYTE = 54;
        private const byte OPAD_BYTE = 92;
        internal static readonly byte[] IPAD;
        internal static readonly byte[] OPAD;
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private readonly int padLength;
        private byte[] secret;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public Ssl3Mac(Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.digest = digest;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.padLength = (digest.GetDigestSize() == 20) ? 40 : 48;
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.digest.AlgorithmName + "/SSL3MAC"("/SSL3MAC");
        }
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_6 = parameters;
            if(val_6 != null)
            {
                    val_6 = 0;
            }
            
            this.secret = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_6.GetKey());
        }
        public virtual int GetMacSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.digest.GetDigestSize();
        }
        public virtual void Update(byte input)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int len)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  inOff, length:  len);
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            var val_11;
            var val_11 = 0;
            val_11 = val_11 + 1;
            int val_2 = this.digest.GetDigestSize();
            byte[] val_3 = new byte[0];
            var val_12 = 0;
            val_12 = val_12 + 1;
            int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
            if(this.secret == null)
            {
                goto label_11;
            }
            
            label_18:
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_16;
            label_11:
            if(this.digest != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_16:
            this.digest.BlockUpdate(input:  this.secret, inOff:  0, length:  this.secret.Length);
            val_11 = null;
            val_11 = null;
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.digest.BlockUpdate(input:  Org.BouncyCastle.Crypto.Tls.Ssl3Mac.OPAD, inOff:  0, length:  this.padLength);
            if(val_3 == null)
            {
                goto label_26;
            }
            
            label_33:
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_31;
            label_26:
            if(this.digest != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_31:
            this.digest.BlockUpdate(input:  val_3, inOff:  0, length:  val_3.Length);
            var val_16 = 0;
            val_16 = val_16 + 1;
            return (int)this.digest.DoFinal(output:  output, outOff:  outOff);
        }
        public virtual void Reset()
        {
            var val_6;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.digest.Reset();
            if(this.secret == null)
            {
                goto label_6;
            }
            
            label_13:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_11;
            label_6:
            if(this.digest != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_11:
            this.digest.BlockUpdate(input:  this.secret, inOff:  0, length:  this.secret.Length);
            val_6 = null;
            val_6 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.digest.BlockUpdate(input:  Org.BouncyCastle.Crypto.Tls.Ssl3Mac.IPAD, inOff:  0, length:  this.padLength);
        }
        private static byte[] GenPad(byte b, int count)
        {
            byte[] val_1 = new byte[0];
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  val_1, b:  b);
            return (System.Byte[])val_1;
        }
        private static Ssl3Mac()
        {
            Org.BouncyCastle.Crypto.Tls.Ssl3Mac.IPAD = Org.BouncyCastle.Crypto.Tls.Ssl3Mac.GenPad(b:  54, count:  48);
            Org.BouncyCastle.Crypto.Tls.Ssl3Mac.OPAD = Org.BouncyCastle.Crypto.Tls.Ssl3Mac.GenPad(b:  92, count:  48);
        }
    
    }

}
