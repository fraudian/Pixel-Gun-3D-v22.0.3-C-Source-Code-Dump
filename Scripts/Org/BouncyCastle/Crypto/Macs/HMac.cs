using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class HMac : IMac
    {
        // Fields
        private const byte IPAD = 54;
        private const byte OPAD = 92;
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private readonly int digestSize;
        private readonly int blockLength;
        private Org.BouncyCastle.Utilities.IMemoable ipadState;
        private Org.BouncyCastle.Utilities.IMemoable opadState;
        private readonly byte[] inputPad;
        private readonly byte[] outputBuf;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public HMac(Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.digest = digest;
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.digestSize = digest.GetDigestSize();
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.blockLength = digest.GetByteLength();
            this.inputPad = new byte[0];
            int val_6 = this.digestSize + this.blockLength;
            this.outputBuf = new byte[0];
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.digest.AlgorithmName + "/HMAC"("/HMAC");
        }
        public virtual Org.BouncyCastle.Crypto.IDigest GetUnderlyingDigest()
        {
            return (Org.BouncyCastle.Crypto.IDigest)this.digest;
        }
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_13;
            int val_15;
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            Org.BouncyCastle.Crypto.IDigest val_26;
            var val_28;
            var val_30;
            val_13 = parameters;
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.digest.Reset();
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            System.Byte[] val_5 = val_13.GetKey();
            val_15 = val_5.Length;
            if(this.blockLength >= val_15)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_18;
            label_13:
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  0, destinationArray:  this.inputPad, destinationIndex:  0, length:  val_15);
            goto label_19;
            label_18:
            this.digest.BlockUpdate(input:  val_5, inOff:  0, length:  val_15);
            var val_16 = 0;
            val_16 = val_16 + 1;
            int val_8 = this.digest.DoFinal(output:  this.inputPad, outOff:  0);
            val_15 = this.digestSize;
            label_19:
            System.Array.Clear(array:  this.inputPad, index:  val_15, length:  this.blockLength - val_15);
            val_18 = this.blockLength;
            System.Array.Copy(sourceArray:  this.inputPad, sourceIndex:  0, destinationArray:  this.outputBuf, destinationIndex:  0, length:  val_18);
            Org.BouncyCastle.Crypto.Macs.HMac.XorPad(pad:  this.inputPad, len:  this.blockLength, n:  54);
            Org.BouncyCastle.Crypto.Macs.HMac.XorPad(pad:  this.outputBuf, len:  this.blockLength, n:  92);
            val_19 = null;
            if(this.digest == null)
            {
                goto label_25;
            }
            
            if(this.digest == null)
            {
                goto label_26;
            }
            
            val_20 = null;
            val_19 = val_20;
            val_21 = this.digest;
            if(val_21 != null)
            {
                goto label_28;
            }
            
            val_19 = 0;
            goto label_29;
            label_26:
            val_20 = null;
            label_29:
            val_21 = 0;
            label_28:
            if(mem[282584257676957] == 0)
            {
                goto label_30;
            }
            
            var val_17 = mem[282584257676847];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_32:
            if(((mem[282584257676847] + 8) + -8) == val_20)
            {
                goto label_31;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < mem[282584257676957])
            {
                goto label_32;
            }
            
            label_30:
            val_19 = val_20;
            goto label_33;
            label_31:
            val_21 = val_21 + (((mem[282584257676847] + 8)) << 4);
            val_22 = val_21 + 296;
            label_33:
            Org.BouncyCastle.Utilities.IMemoable val_10 = val_21.Copy();
            this.opadState = val_10;
            if(val_10 == null)
            {
                goto label_34;
            }
            
            val_23 = null;
            val_24 = val_10;
            if(val_24 != null)
            {
                goto label_36;
            }
            
            goto label_37;
            label_34:
            val_23 = null;
            label_37:
            val_24 = 0;
            label_36:
            if(mem[282584257676957] == 0)
            {
                goto label_41;
            }
            
            var val_19 = mem[282584257676847];
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_40:
            if(((mem[282584257676847] + 8) + -8) == val_23)
            {
                goto label_39;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < mem[282584257676957])
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            var val_21 = val_19;
            val_21 = val_21 + 4;
            val_24 = val_24 + val_21;
            val_25 = val_24 + 296;
            label_41:
            val_18 = public System.Void Org.BouncyCastle.Crypto.IDigest::BlockUpdate(byte[] input, int inOff, int length);
            val_24.BlockUpdate(input:  this.outputBuf, inOff:  0, length:  this.blockLength);
            label_25:
            val_26 = this.digest;
            if(this.inputPad == null)
            {
                goto label_42;
            }
            
            label_49:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_47;
            label_42:
            if(val_26 != null)
            {
                goto label_49;
            }
            
            goto label_49;
            label_47:
            val_26.BlockUpdate(input:  this.inputPad, inOff:  0, length:  this.inputPad.Length);
            if(this.digest == null)
            {
                    return;
            }
            
            if(this.digest != null)
            {
                    if(this.digest != null)
            {
                goto label_52;
            }
            
            }
            
            label_52:
            val_28 = null;
            val_26 = this.digest;
            if(val_26 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_28 = null;
                this.ipadState = val_26.Copy();
                return;
            }
            
            val_30 = X0;
        }
        public virtual int GetMacSize()
        {
            return (int)this.digestSize;
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
            int val_12;
            var val_13;
            var val_14;
            var val_16;
            var val_19;
            int val_20;
            int val_22;
            var val_23;
            var val_24;
            System.Byte[] val_25;
            var val_28;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = this.blockLength;
            int val_2 = this.digest.DoFinal(output:  this.outputBuf, outOff:  val_12);
            if(this.opadState == null)
            {
                goto label_6;
            }
            
            if(this.digest == null)
            {
                goto label_7;
            }
            
            if(this.digest == null)
            {
                    val_12 = 0;
            }
            
            val_13 = null;
            val_14 = this.digest;
            if(val_14 != null)
            {
                goto label_9;
            }
            
            val_12 = 0;
            goto label_10;
            label_6:
            if(this.outputBuf == null)
            {
                goto label_11;
            }
            
            label_33:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_16;
            label_7:
            val_13 = null;
            label_10:
            val_14 = 0;
            label_9:
            if(mem[282584257676957] == 0)
            {
                goto label_17;
            }
            
            var val_15 = mem[282584257676847];
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_19:
            if(((mem[282584257676847] + 8) + -8) == val_13)
            {
                goto label_18;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < mem[282584257676957])
            {
                goto label_19;
            }
            
            label_17:
            val_12 = 1;
            goto label_20;
            label_18:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_14 = val_14 + val_17;
            val_16 = val_14 + 296;
            label_20:
            val_14.Reset(other:  this.opadState);
            var val_18 = 0;
            val_18 = val_18 + 1;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_19 = public System.Void Org.BouncyCastle.Crypto.IDigest::BlockUpdate(byte[] input, int inOff, int length);
            val_20 = this.digest.GetDigestSize();
            goto label_31;
            label_11:
            if(this.digest != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_16:
            val_19 = public System.Void Org.BouncyCastle.Crypto.IDigest::BlockUpdate(byte[] input, int inOff, int length);
            val_20 = this.outputBuf.Length;
            label_31:
            this.digest.BlockUpdate(input:  this.outputBuf, inOff:  0, length:  val_20);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_22 = this.digestSize;
            val_23 = this.digest.DoFinal(output:  output, outOff:  outOff);
            System.Array.Clear(array:  this.outputBuf, index:  this.blockLength, length:  val_22);
            if(this.ipadState == null)
            {
                goto label_39;
            }
            
            if(this.digest == null)
            {
                goto label_40;
            }
            
            if(this.digest != null)
            {
                goto label_41;
            }
            
            val_22 = 0;
            label_40:
            label_41:
            val_24 = null;
            val_25 = this.digest;
            if(val_25 == null)
            {
                goto label_56;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = 1;
            goto label_46;
            label_39:
            val_25 = this.inputPad;
            if(val_25 == null)
            {
                goto label_47;
            }
            
            label_55:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_52;
            label_46:
            val_25.Reset(other:  this.ipadState);
            return (int)val_23;
            label_47:
            if(this.digest != null)
            {
                goto label_55;
            }
            
            goto label_55;
            label_52:
            this.digest.BlockUpdate(input:  val_25, inOff:  0, length:  this.inputPad.Length);
            val_23 = (this.ipadState == 0) ? (val_23) : 0;
            return (int)val_23;
            label_56:
            val_28 = X0;
        }
        public virtual void Reset()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.digest.Reset();
            if(this.inputPad == null)
            {
                goto label_6;
            }
            
            if(this.digest != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_11;
            label_6:
            if(this.digest != null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            this.digest.BlockUpdate(input:  this.inputPad, inOff:  0, length:  this.inputPad.Length);
        }
        private static void XorPad(byte[] pad, int len, byte n)
        {
            if(len < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                mem2[0] = 1152921505721910208 ^ n;
                val_2 = val_2 + 1;
            }
            while(len != val_2);
        
        }
    
    }

}
