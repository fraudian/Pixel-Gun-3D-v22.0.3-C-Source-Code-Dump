using UnityEngine;

namespace Org.BouncyCastle.Crypto.Paddings
{
    public class PaddedBufferedBlockCipher : BufferedBlockCipher
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;
        
        // Methods
        public PaddedBufferedBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher, Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
        {
            mem[1152921551374467664] = cipher;
            this.padding = padding;
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_2 = cipher.GetBlockSize();
            mem[1152921551374467648] = new byte[0];
            mem[1152921551374467656] = 0;
        }
        public PaddedBufferedBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            Org.BouncyCastle.Crypto.Paddings.Pkcs7Padding val_1 = new Org.BouncyCastle.Crypto.Paddings.Pkcs7Padding();
        }
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            mem[1152921551374736764] = forEncryption;
            this.Reset();
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.padding.Init(random:  0);
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.Init(forEncryption:  forEncryption, parameters:  parameters);
        }
        public override int GetOutputSize(int length)
        {
            var val_4;
            var val_6;
            var val_7;
            val_4 = W8 + length;
            int val_2 = val_4 - ((val_4 / (X21 + 24)) * (X21 + 24));
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            val_6 = val_4 - val_2;
            goto label_3;
            label_1:
            if((X21 + 24) == 0)
            {
                    return (int)val_7;
            }
            
            if(this == null)
            {
                goto label_5;
            }
            
            label_3:
            val_7 = val_4 + (X21 + 24);
            return (int)val_7;
            label_5:
        }
        public override int GetUpdateOutputSize(int length)
        {
            var val_4;
            var val_5;
            val_4 = this;
            int val_1 = W8 + length;
            val_5 = val_1 - ((val_1 / (X21 + 24)) * (X21 + 24));
            return (int)val_1 - val_5;
        }
        public override int ProcessByte(byte input, byte[] output, int outOff)
        {
            var val_2;
            var val_3;
            var val_4;
            if(137150464 != (X24 + 24))
            {
                goto label_2;
            }
            
            var val_6 = mem[137150464];
            if((mem[137150464] + 286) == 0)
            {
                goto label_7;
            }
            
            var val_3 = mem[137150464] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[137150464] + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[137150464] + 286))
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            val_4 = 0;
            goto label_8;
            label_5:
            var val_5 = val_3;
            val_5 = val_5 + 4;
            val_6 = val_6 + val_5;
            val_2 = val_6 + 296;
            label_7:
            val_4 = ProcessBlock(inBuf:  X24, inOff:  0, outBuf:  output, outOff:  outOff);
            val_3 = 0;
            mem[1152921551375126056] = 0;
            label_8:
            mem[1152921551375126056] = val_3 + 1;
            output[0] = input;
            return (int)val_4;
        }
        public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            int val_7;
            int val_8;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = length;
            val_8 = inOff;
            if((val_7 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            int val_1 = this.GetBlockSize();
            if(this >= 1)
            {
                    Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  -476133440, msg:  "output buffer too short");
            }
            
            val_10 = (X26 + 24) - "output buffer too short";
            if(val_10 >= val_7)
            {
                goto label_4;
            }
            
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_8, destinationArray:  this, destinationIndex:  -118734304, length:  val_10);
            var val_9 = X26;
            if((X26 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_6 = X26 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_8:
            if(((X26 + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (X26 + 286))
            {
                goto label_8;
            }
            
            goto label_9;
            label_4:
            val_12 = 0;
            goto label_10;
            label_7:
            var val_8 = val_6;
            val_8 = val_8 + 4;
            val_9 = val_9 + val_8;
            val_11 = val_9 + 296;
            label_9:
            val_12 = X26.ProcessBlock(inBuf:  X28, inOff:  0, outBuf:  output, outOff:  outOff);
            mem[1152921551375353816] = 0;
            val_7 = val_7 - val_10;
            val_8 = val_10 + val_8;
            goto label_11;
            label_18:
            var val_13 = val_10;
            if(((X26 + 24 - "output buffer too short") + 286) == 0)
            {
                goto label_16;
            }
            
            var val_10 = (X26 + 24 - "output buffer too short") + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_15:
            if((((X26 + 24 - "output buffer too short") + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < ((X26 + 24 - "output buffer too short") + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            var val_12 = val_10;
            val_12 = val_12 + 4;
            val_13 = val_13 + val_12;
            val_13 = val_13 + 296;
            label_16:
            val_12 = (val_10.ProcessBlock(inBuf:  input, inOff:  val_8, outBuf:  output, outOff:  val_12 + outOff)) + val_12;
            val_7 = val_7 - val_1;
            val_8 = val_8 + val_1;
            label_11:
            int val_14 = (X26 + 24 - "output buffer too short") + 24;
            if(val_7 > val_14)
            {
                goto label_18;
            }
            
            label_10:
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_8, destinationArray:  val_8, destinationIndex:  output, length:  val_7);
            val_14 = val_14 + val_7;
            mem[1152921551375353816] = val_14;
            return (int)val_12;
            label_1:
            System.ArgumentException val_5 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            int val_17;
            int val_18;
            var val_19;
            var val_21;
            string val_23;
            var val_15 = mem[137150464];
            if((mem[137150464] + 286) == 0)
            {
                goto label_5;
            }
            
            var val_12 = mem[137150464] + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_4:
            if(((mem[137150464] + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[137150464] + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_14 = val_12;
            val_14 = val_14 + 2;
            val_15 = val_15 + val_14;
            val_10 = val_15 + 296;
            label_5:
            int val_1 = GetBlockSize();
            if((public System.Int32 Org.BouncyCastle.Crypto.IBlockCipher::GetBlockSize()) == 0)
            {
                goto label_6;
            }
            
            if(W23 != val_1)
            {
                goto label_7;
            }
            
            if((outOff + (val_1 << 1)) > output.Length)
            {
                goto label_9;
            }
            
            var val_24 = val_1;
            if((val_1 + 286) == 0)
            {
                goto label_14;
            }
            
            var val_16 = val_1 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_13:
            if(((val_1 + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (val_1 + 286))
            {
                goto label_13;
            }
            
            goto label_14;
            label_6:
            if(W23 != val_1)
            {
                goto label_15;
            }
            
            var val_21 = X23;
            if((X23 + 286) == 0)
            {
                goto label_20;
            }
            
            var val_18 = X23 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_19:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X23 + 286))
            {
                goto label_19;
            }
            
            goto label_20;
            label_7:
            val_14 = 0;
            goto label_21;
            label_18:
            var val_20 = val_18;
            val_20 = val_20 + 4;
            val_21 = val_21 + val_20;
            val_13 = val_21 + 296;
            label_20:
            val_15 = 0;
            mem[1152921551375598184] = 0;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_15 = 3;
            val_17 = (X23.ProcessBlock(inBuf:  val_1, inOff:  0, outBuf:  val_1, outOff:  0)) - (this.padding.PadCount(input:  X24));
            System.Array.Copy(sourceArray:  public System.Int32 Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding::PadCount(byte[] input), sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  val_17);
            val_18 = 1;
            val_19 = 1;
            label_43:
            this.Reset();
            if((val_18 & 1) != 0)
            {
                    return (int)val_17;
            }
            
            if((val_19 & 1) != 0)
            {
                    return (int)val_17;
            }
            
            return (int)val_17;
            label_12:
            var val_23 = val_16;
            val_23 = val_23 + 4;
            val_24 = val_24 + val_23;
            val_12 = val_24 + 296;
            label_14:
            val_14 = val_1.ProcessBlock(inBuf:  X23, inOff:  0, outBuf:  output, outOff:  outOff);
            val_11 = 0;
            mem[1152921551375598184] = 0;
            label_21:
            var val_25 = 0;
            val_25 = val_25 + 1;
            int val_8 = this.padding.AddPadding(input:  X25, inOff:  0);
            var val_29 = 1179403647;
            val_18 = val_14 + outOff;
            if(mem[282584257676957] == 0)
            {
                goto label_39;
            }
            
            var val_26 = mem[282584257676847];
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_38:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < mem[282584257676957])
            {
                goto label_38;
            }
            
            goto label_39;
            label_37:
            var val_28 = val_26;
            val_28 = val_28 + 4;
            val_29 = val_29 + val_28;
            val_21 = val_29 + 296;
            label_39:
            val_17 = (val_11.ProcessBlock(inBuf:  this.padding, inOff:  0, outBuf:  output, outOff:  val_18)) + val_14;
            this.Reset();
            return (int)val_17;
            label_15:
            this.Reset();
            val_23 = "last block incomplete in decryption";
            goto label_40;
            label_9:
            this.Reset();
            val_23 = "output buffer too short";
            label_40:
            null = new Org.BouncyCastle.Crypto.OutputLengthException(message:  val_23);
            if(0 != 1)
            {
                goto label_42;
            }
            
            var val_11 = (null == 0) ? 1 : 0;
            goto label_43;
            label_42:
        }
    
    }

}
