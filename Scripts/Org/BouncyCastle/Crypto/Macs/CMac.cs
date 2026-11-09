using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class CMac : IMac
    {
        // Fields
        private const byte CONSTANT_128 = 135;
        private const byte CONSTANT_64 = 27;
        private byte[] ZEROES;
        private byte[] mac;
        private byte[] buf;
        private int bufOff;
        private Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private int macSize;
        private byte[] L;
        private byte[] Lu;
        private byte[] Lu2;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public CMac(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_3 = cipher.GetBlockSize() << 3;
        }
        public CMac(Org.BouncyCastle.Crypto.IBlockCipher cipher, int macSizeInBits)
        {
            string val_25;
            var val_26;
            var val_27;
            if((macSizeInBits & 7) != 0)
            {
                goto label_1;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            int val_25 = cipher.GetBlockSize();
            val_25 = val_25 << 3;
            var val_26 = 0;
            val_26 = val_26 + 1;
            int val_5 = cipher.GetBlockSize();
            if(val_25 < macSizeInBits)
            {
                goto label_12;
            }
            
            if(val_5 == 8)
            {
                goto label_13;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(cipher.GetBlockSize() != 16)
            {
                goto label_19;
            }
            
            label_13:
            int val_10 = (macSizeInBits < 0) ? (macSizeInBits + 7) : macSizeInBits;
            val_10 = val_10 >> 3;
            this.cipher = new Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(cipher:  cipher);
            this.macSize = val_10;
            var val_28 = 0;
            val_28 = val_28 + 1;
            int val_12 = cipher.GetBlockSize();
            this.mac = new byte[0];
            var val_29 = 0;
            val_29 = val_29 + 1;
            int val_15 = cipher.GetBlockSize();
            this.buf = new byte[0];
            var val_30 = 0;
            val_30 = val_30 + 1;
            int val_18 = cipher.GetBlockSize();
            this.ZEROES = new byte[0];
            this.bufOff = 0;
            return;
            label_1:
            val_25 = "MAC size must be multiple of 8";
            goto label_35;
            label_12:
            val_26 = 1152921551437589968;
            val_27 = new System.ArgumentException(message:  "MAC size must be less or equal to " + val_5 << 3(val_5 << 3));
            goto label_36;
            label_19:
            System.ArgumentException val_23 = null;
            val_25 = "Block size must be either 64 or 128 bits";
            label_35:
            val_23 = new System.ArgumentException(message:  val_25);
            val_26 = 1152921551437589968;
            val_27 = val_23;
            label_36:
        }
        public string get_AlgorithmName()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.AlgorithmName;
        }
        private static int ShiftLeft(byte[] block, byte[] output)
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            int val_1 = block.Length - 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            val_7 = block.Length & 4294967295;
            val_8 = (long)val_1 + 32;
            val_9 = block.Length - 2;
            goto label_2;
            label_6:
            val_7 = block.Length;
            val_8 = val_8 - 1;
            val_9 = val_9 - 1;
            label_2:
            var val_2 = val_8 - 32;
            val_6 = val_6 | 2230126464;
            mem2[0] = val_6;
            val_6 = 0;
            if((val_9 & 2147483648) == 0)
            {
                goto label_6;
            }
            
            return (int)val_6;
        }
        private static byte[] DoubleLu(byte[] input)
        {
            byte[] val_1 = new byte[0];
            if(input == null)
            {
                goto label_2;
            }
            
            if(val_1 != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            int val_5 = input.Length;
            val_5 = val_5 - 1;
            byte val_6 = val_1[(long)val_5];
            var val_7 = 1;
            val_7 = val_7 - (Org.BouncyCastle.Crypto.Macs.CMac.ShiftLeft(block:  input, output:  val_1));
            val_7 = ((input.Length == 16) ? 135 : 27) >> val_7;
            val_6 = val_7 ^ val_6;
            val_1[(long)val_5] = val_6;
            return (System.Byte[])val_1;
            label_2:
            var val_4 = (input.Length == 16) ? 135 : 27;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.IBlockCipher val_7;
            if(parameters != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.cipher.Init(forEncryption:  true, parameters:  parameters);
                byte[] val_2 = new byte[0];
                val_7 = this.cipher;
                this.L = val_2;
                var val_9 = 0;
                val_9 = val_9 + 1;
                int val_4 = val_7.ProcessBlock(inBuf:  this.ZEROES, inOff:  0, outBuf:  val_2, outOff:  0);
                System.Byte[] val_5 = Org.BouncyCastle.Crypto.Macs.CMac.DoubleLu(input:  this.L);
                this.Lu = val_5;
                this.Lu2 = Org.BouncyCastle.Crypto.Macs.CMac.DoubleLu(input:  val_5);
            }
            
            this.Reset();
        }
        public int GetMacSize()
        {
            return (int)this.macSize;
        }
        public void Update(byte input)
        {
            int val_3;
            if(this.bufOff != this.buf.Length)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_7;
            label_2:
            val_3 = this.bufOff;
            goto label_8;
            label_7:
            int val_2 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
            val_3 = 0;
            this.bufOff = 0;
            label_8:
            this.bufOff = val_3 + 1;
            this.buf[0] = input;
        }
        public void BlockUpdate(byte[] inBytes, int inOff, int len)
        {
            int val_6;
            int val_7;
            int val_9;
            Org.BouncyCastle.Crypto.IBlockCipher val_10;
            val_6 = len;
            val_7 = inOff;
            if((val_6 & 2147483648) == 0)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                int val_2 = this.cipher.GetBlockSize();
                val_9 = this.bufOff;
                int val_3 = val_2 - val_9;
                if(val_3 < val_6)
            {
                    System.Array.Copy(sourceArray:  inBytes, sourceIndex:  val_7, destinationArray:  this.buf, destinationIndex:  val_9, length:  val_3);
                val_10 = this.cipher;
                var val_10 = 0;
                val_10 = val_10 + 1;
                int val_5 = val_10.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
                val_6 = val_6 - val_3;
                val_7 = val_3 + val_7;
                this.bufOff = 0;
                if(val_6 > val_2)
            {
                    do
            {
                val_10 = this.cipher;
                var val_11 = 0;
                val_11 = val_11 + 1;
                int val_7 = val_10.ProcessBlock(inBuf:  inBytes, inOff:  val_7, outBuf:  this.mac, outOff:  0);
                val_6 = val_6 - val_2;
                val_7 = val_7 + val_2;
            }
            while(val_6 > val_2);
            
                val_9 = this.bufOff;
            }
            else
            {
                    val_9 = 0;
            }
            
            }
            
                System.Array.Copy(sourceArray:  inBytes, sourceIndex:  val_7, destinationArray:  this.buf, destinationIndex:  0, length:  val_6);
                int val_12 = this.bufOff;
                val_12 = val_12 + val_6;
                this.bufOff = val_12;
                return;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public int DoFinal(byte[] outBytes, int outOff)
        {
            System.Byte[] val_7;
            var val_8;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(this.bufOff == this.cipher.GetBlockSize())
            {
                    val_7 = this.Lu;
            }
            else
            {
                    Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding val_3 = new Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding();
                int val_4 = 0.AddPadding(input:  this.buf, inOff:  this.bufOff);
                val_7 = this.Lu2;
            }
            
            val_8 = 0;
            goto label_9;
            label_15:
            var val_5 = mem[this.Lu2] + 0;
            var val_9 = (mem[this.Lu2] + 0) + 32;
            val_8 = 1;
            val_9 = val_9 ^ (mem[this.buf + 32]);
            mem2[0] = val_9;
            label_9:
            if(val_8 < this.mac.Length)
            {
                goto label_15;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            int val_7 = this.cipher.ProcessBlock(inBuf:  this.buf, inOff:  0, outBuf:  this.mac, outOff:  0);
            System.Array.Copy(sourceArray:  this.mac, sourceIndex:  0, destinationArray:  outBytes, destinationIndex:  outOff, length:  this.macSize);
            this.Reset();
            return (int)this.macSize;
        }
        public void Reset()
        {
            System.Array.Clear(array:  this.buf, index:  0, length:  this.buf.Length);
            this.bufOff = 0;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
