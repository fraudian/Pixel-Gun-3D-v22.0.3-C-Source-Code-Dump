using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class BufferedBlockCipher : BufferedCipherBase
    {
        // Fields
        internal byte[] buf;
        internal int bufOff;
        internal bool forEncryption;
        internal Org.BouncyCastle.Crypto.IBlockCipher cipher;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        protected BufferedBlockCipher()
        {
            this = new System.Object();
        }
        public BufferedBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            this = new System.Object();
            if(cipher != null)
            {
                    this.cipher = cipher;
                var val_6 = 0;
                val_6 = val_6 + 1;
                int val_3 = cipher.GetBlockSize();
                this.buf = new byte[0];
                this.bufOff = 0;
                return;
            }
            
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  "cipher");
        }
        public override string get_AlgorithmName()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.AlgorithmName;
        }
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_5 = parameters;
            this.forEncryption = forEncryption;
            if(val_5 != null)
            {
                    val_5 = val_5.Parameters;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.cipher.Init(forEncryption:  forEncryption, parameters:  val_5);
        }
        public override int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetBlockSize();
        }
        public override int GetUpdateOutputSize(int length)
        {
            return (int)((this.bufOff + length) / this.buf.Length) * this.buf.Length;
        }
        public override int GetOutputSize(int length)
        {
            return (int)this.bufOff + length;
        }
        public override int ProcessByte(byte input, byte[] output, int outOff)
        {
            this.bufOff = this.bufOff + 1;
            this.buf[this.bufOff] = input;
            if(this.bufOff != this.buf.Length)
            {
                    return 0;
            }
            
            if(this.buf == null)
            {
                goto label_5;
            }
            
            label_14:
            int val_4 = this.buf.Length;
            val_4 = val_4 + outOff;
            if(val_4 > output.Length)
            {
                goto label_7;
            }
            
            this.bufOff = 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            return this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  output, outOff:  outOff);
            label_5:
            if(output != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_7:
            Org.BouncyCastle.Crypto.DataLengthException val_3 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "output buffer too short");
        }
        public override byte[] ProcessByte(byte input)
        {
            System.Array val_3;
            if(this >= 1)
            {
                    val_3 = new byte[-118404592];
            }
            else
            {
                    val_3 = 0;
            }
            
            if(this < 1)
            {
                    return (System.Byte[])val_3;
            }
            
            if(this >= this)
            {
                    return (System.Byte[])val_3;
            }
            
            byte[] val_2 = new byte[-118404592];
            System.Array.Copy(sourceArray:  val_3, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -118404592);
            val_3 = val_2;
            return (System.Byte[])val_3;
        }
        public override byte[] ProcessBytes(byte[] input, int inOff, int length)
        {
            var val_4;
            System.Array val_5;
            val_4 = length;
            if(input == null)
            {
                goto label_1;
            }
            
            if(val_4 < 1)
            {
                goto label_2;
            }
            
            if(this < 1)
            {
                goto label_3;
            }
            
            val_5 = new byte[-118250544];
            goto label_4;
            label_2:
            val_5 = 0;
            return (System.Byte[])val_5;
            label_3:
            val_5 = 0;
            label_4:
            val_4 = this;
            if(this < 1)
            {
                    return (System.Byte[])val_5;
            }
            
            if(val_4 >= this)
            {
                    return (System.Byte[])val_5;
            }
            
            byte[] val_2 = new byte[-118250544];
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -118250544);
            val_5 = val_2;
            return (System.Byte[])val_5;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "input");
        }
        public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            var val_13;
            int val_14;
            System.Byte[] val_16;
            val_7 = outOff;
            val_8 = length;
            val_9 = inOff;
            if(val_8 <= 0)
            {
                goto label_1;
            }
            
            if(this >= 1)
            {
                    Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  val_7, len:  -117748176, msg:  "output buffer too short");
            }
            
            val_10 = this.bufOff;
            val_11 = this.buf.Length - val_10;
            if(val_11 >= val_8)
            {
                goto label_4;
            }
            
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_9, destinationArray:  this.buf, destinationIndex:  val_10, length:  val_11);
            System.Byte[] val_9 = this.buf;
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_9;
            label_1:
            if(val_8 != 0)
            {
                goto label_10;
            }
            
            val_13 = 0;
            return (int)val_13;
            label_4:
            val_13 = 0;
            goto label_12;
            label_9:
            val_13 = this.cipher.ProcessBlock(inBuf:  val_9, inOff:  0, outBuf:  output, outOff:  val_7);
            this.bufOff = 0;
            val_8 = val_8 - val_11;
            val_14 = val_11 + val_9;
            goto label_13;
            label_20:
            val_9 = val_13 + val_7;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = (this.cipher.ProcessBlock(inBuf:  input, inOff:  val_14, outBuf:  output, outOff:  val_9)) + val_13;
            val_8 = val_8 - this;
            val_14 = val_14 + this;
            label_13:
            val_11 = this.buf;
            if(val_8 > this.buf.Length)
            {
                goto label_20;
            }
            
            val_10 = this.bufOff;
            label_12:
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_14, destinationArray:  this.buf, destinationIndex:  val_10, length:  val_8);
            val_16 = this.buf;
            val_8 = this.bufOff + val_8;
            this.bufOff = val_8;
            if(val_8 != this.buf.Length)
            {
                    return (int)val_13;
            }
            
            val_16 = this.buf;
            val_7 = val_13 + val_7;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = (this.cipher.ProcessBlock(inBuf:  val_16, inOff:  0, outBuf:  output, outOff:  val_7)) + val_13;
            this.bufOff = 0;
            return (int)val_13;
            label_10:
            System.ArgumentException val_7 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public override byte[] DoFinal()
        {
            var val_3;
            var val_4;
            System.Byte[] val_5;
            val_3 = this;
            val_4 = null;
            val_4 = null;
            val_5 = Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
            if(val_3 < 1)
            {
                    return val_5;
            }
            
            byte[] val_1 = new byte[-117287936];
            val_5 = val_1;
            val_3 = val_3;
            if(val_3 >= val_1.Length)
            {
                    return val_5;
            }
            
            byte[] val_2 = new byte[-117287936];
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -117287936);
            val_5 = val_2;
            return val_5;
        }
        public override byte[] DoFinal(byte[] input, int inOff, int inLen)
        {
            System.Array val_4;
            var val_5;
            System.Byte[] val_6;
            val_4 = inLen;
            val_5 = this;
            if(input == null)
            {
                goto label_1;
            }
            
            if(val_5 < 1)
            {
                goto label_4;
            }
            
            byte[] val_1 = new byte[-117133888];
            val_6 = val_1;
            if(val_4 < 1)
            {
                goto label_5;
            }
            
            val_4 = val_5;
            goto label_6;
            label_4:
            val_6 = Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
            return (System.Byte[])val_6;
            label_5:
            val_4 = 0;
            label_6:
            if(null >= val_1.Length)
            {
                    return (System.Byte[])val_6;
            }
            
            byte[] val_2 = new byte[915013632];
            val_4 = val_2;
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  915013632);
            val_6 = val_4;
            return (System.Byte[])val_6;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "input");
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            var val_4;
            int val_5;
            if(this.bufOff == 0)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_6;
            label_1:
            val_4 = 0;
            val_5 = 0;
            goto label_7;
            label_6:
            bool val_2 = this.cipher.IsPartialBlockOkay;
            val_2 = (~val_2) & 1;
            Org.BouncyCastle.Crypto.Check.DataLength(condition:  val_2, msg:  "data not block size aligned");
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  this.bufOff, msg:  "output buffer too short for DoFinal()");
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_4 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.buf, outOff:  0);
            System.Array.Copy(sourceArray:  this.buf, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  this.bufOff);
            val_5 = this.bufOff;
            val_4 = 0;
            label_7:
            if((1 & 1) != 0)
            {
                    return val_5;
            }
            
            if((1 & 1) != 0)
            {
                    return val_5;
            }
            
            return val_5;
        }
        public override void Reset()
        {
            System.Array.Clear(array:  this.buf, index:  0, length:  this.buf.Length);
            this.bufOff = 0;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
