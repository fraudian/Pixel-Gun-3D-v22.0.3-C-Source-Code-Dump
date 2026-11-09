using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class Gost28147Mac : IMac
    {
        // Fields
        private const int blockSize = 8;
        private const int macSize = 4;
        private int bufOff;
        private byte[] buf;
        private byte[] mac;
        private bool firstStep;
        private int[] workingKey;
        private byte[] S;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public Gost28147Mac()
        {
            this.firstStep = true;
            this.S = new byte[128] {9, 6, 3, 2, 8, 11, 1, 7, 10, 4, 14, 15, 12, 0, 13, 5, 3, 7, 14, 9, 8, 10, 15, 0, 5, 2, 6, 12, 11, 4, 13, 1, 14, 4, 6, 2, 11, 3, 13, 8, 12, 15, 5, 10, 0, 7, 1, 9, 14, 7, 10, 12, 13, 1, 3, 9, 0, 2, 11, 4, 15, 8, 5, 6, 11, 5, 1, 9, 8, 13, 15, 0, 14, 4, 2, 3, 12, 7, 10, 6, 3, 10, 13, 12, 1, 2, 0, 11, 7, 5, 9, 4, 8, 15, 14, 6, 1, 13, 2, 9, 7, 10, 6, 0, 8, 12, 4, 5, 15, 3, 11, 14, 11, 10, 15, 5, 0, 12, 14, 8, 6, 2, 3, 9, 1, 7, 13, 4};
            this.mac = new byte[8];
            this.buf = new byte[8];
            this.bufOff = 0;
        }
        private static int[] generateWorkingKey(byte[] userKey)
        {
            if(userKey.Length == 32)
            {
                    int[] val_1 = new int[8];
                var val_5 = 0;
                var val_4 = 0;
                do
            {
                val_4 = val_4 + 1;
                mem2[0] = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(input:  userKey, inOff:  0);
                val_5 = val_5 + 4;
            }
            while(val_4 != 8);
            
                return (System.Int32[])val_1;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Key length invalid. Key needs to be 32 byte - 256 bit!!!");
        }
        public void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_14;
            this.Reset();
            this.buf = new byte[8];
            if(parameters != null)
            {
                    this.workingKey = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.generateWorkingKey(userKey:  parameters.GetKey());
                return;
            }
            
            val_14 = new System.ArgumentException(message:  "invalid parameter passed to Gost28147 init - "("invalid parameter passed to Gost28147 init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public string get_AlgorithmName()
        {
            return "Gost28147Mac";
        }
        public int GetMacSize()
        {
            return 4;
        }
        private int gost28147_mainStep(int n1, int key)
        {
            byte val_3 = (this.S[(key + n1) & 15]) + (this.S[16] << 4);
            val_3 = val_3 + (this.S[32] << 8);
            val_3 = val_3 + (this.S[48] << 12);
            byte val_12 = this.S[112];
            val_3 = val_3 + (this.S[64] << 16);
            val_3 = val_3 + (this.S[80] << 20);
            val_3 = val_3 + (this.S[96] << 24);
            val_12 = val_3 + (val_12 << 28);
            return (int)val_12 >> 21;
        }
        private void gost28147MacFunc(int[] workingKey, byte[] input, int inOff, byte[] output, int outOff)
        {
            int val_7 = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(input:  input, inOff:  inOff);
            var val_8 = 0;
            do
            {
                var val_6 = 0;
                do
            {
                val_6 = val_6 + 1;
                val_7 = (this.gost28147_mainStep(n1:  val_7, key:  1118264816)) ^ (Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(input:  input, inOff:  inOff + 4));
            }
            while(val_6 != 8);
            
                val_8 = val_8 + 1;
            }
            while(val_8 != 2);
            
            Org.BouncyCastle.Crypto.Macs.Gost28147Mac.intTobytes(num:  val_7, output:  output, outOff:  outOff);
            Org.BouncyCastle.Crypto.Macs.Gost28147Mac.intTobytes(num:  val_7, output:  output, outOff:  outOff + 4);
        }
        private static int bytesToint(byte[] input, int inOff)
        {
            int val_5 = input.Length;
            int val_1 = inOff + 3;
            if(val_1 >= val_5)
            {
                    val_5 = input.Length;
            }
            
            int val_2 = inOff + 2;
            if(val_2 >= val_5)
            {
                    val_5 = input.Length;
            }
            
            byte val_6 = input[(long)val_2];
            int val_3 = inOff + 1;
            if(val_3 >= val_5)
            {
                    val_5 = input.Length;
            }
            
            byte val_7 = input[(long)val_3];
            input = (input[(long)val_1] << 24) | input[(long)inOff];
            return (int)input;
        }
        private static void intTobytes(int num, byte[] output, int outOff)
        {
            output[(long)outOff + 3] = num >> 24;
            output[(long)outOff + 2] = num >> 16;
            output[(long)outOff + 1] = num >> 8;
            output[(long)outOff] = num;
        }
        private static byte[] CM5func(byte[] buf, int bufOff, byte[] mac)
        {
            int val_2 = bufOff;
            bufOff = buf.Length - val_2;
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  buf, sourceIndex:  val_2 = bufOff, destinationArray:  val_1, destinationIndex:  0, length:  mac.Length);
            if(mac.Length == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            do
            {
                long val_4 = 0;
                val_4 = mac[val_4] ^ val_1[val_4];
                mem2[0] = val_4;
                val_2 = 0 + 1;
            }
            while(val_2 != mac.Length);
            
            return (System.Byte[])val_1;
        }
        public void Update(byte input)
        {
            System.Array val_3;
            int val_4;
            if(this.bufOff != this.buf.Length)
            {
                goto label_2;
            }
            
            byte[] val_1 = new byte[0];
            val_3 = val_1;
            System.Array.Copy(sourceArray:  this.buf, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  this.mac.Length);
            if(this.firstStep == false)
            {
                goto label_5;
            }
            
            this.firstStep = false;
            goto label_6;
            label_2:
            val_4 = this.bufOff;
            goto label_7;
            label_5:
            val_3 = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(buf:  this.buf, bufOff:  0, mac:  this.mac);
            label_6:
            this.gost28147MacFunc(workingKey:  this.workingKey, input:  val_3, inOff:  0, output:  this.mac, outOff:  0);
            val_4 = 0;
            this.bufOff = 0;
            label_7:
            this.bufOff = val_4 + 1;
            this.buf[0] = input;
        }
        public void BlockUpdate(byte[] input, int inOff, int len)
        {
            int val_10;
            int val_11;
            int val_12;
            System.Array val_13;
            var val_14;
            val_10 = len;
            val_11 = inOff;
            if((val_10 & 2147483648) == 0)
            {
                    val_12 = this.bufOff;
                int val_1 = 8 - val_12;
                if(val_1 < val_10)
            {
                    System.Array.Copy(sourceArray:  input, sourceIndex:  val_11, destinationArray:  this.buf, destinationIndex:  val_12, length:  val_1);
                byte[] val_2 = new byte[0];
                val_13 = val_2;
                System.Array.Copy(sourceArray:  this.buf, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.mac.Length);
                if(this.firstStep != false)
            {
                    this.firstStep = false;
            }
            else
            {
                    val_13 = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(buf:  this.buf, bufOff:  0, mac:  this.mac);
            }
            
                this.gost28147MacFunc(workingKey:  this.workingKey, input:  val_13, inOff:  0, output:  this.mac, outOff:  0);
                val_14 = val_10 - val_1;
                val_1 = val_1 + val_11;
                this.bufOff = 0;
                if(val_14 < 9)
            {
                    val_12 = 0;
                val_10 = val_14;
                val_11 = val_1;
            }
            else
            {
                    val_10 = val_12 + val_10;
                int val_4 = val_10 - 17;
                int val_5 = val_4 & 4294967288;
                val_4 = val_5 + val_11;
                val_11 = val_4 + 16;
                do
            {
                this.gost28147MacFunc(workingKey:  this.workingKey, input:  Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(buf:  input, bufOff:  val_1, mac:  this.mac), inOff:  0, output:  this.mac, outOff:  0);
                val_14 = val_14 - 8;
                val_1 = val_1 + 8;
            }
            while(val_14 > 8);
            
                val_11 = val_11 - val_12;
                val_12 = this.bufOff;
                val_10 = (val_10 - 16) - val_5;
            }
            
            }
            
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_11, destinationArray:  this.buf, destinationIndex:  val_12, length:  val_10);
                int val_9 = this.bufOff;
                val_9 = val_9 + val_10;
                this.bufOff = val_9;
                return;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Can\'t have a negative input length!");
        }
        public int DoFinal(byte[] output, int outOff)
        {
            System.Byte[] val_6;
            System.Array val_7;
            val_6 = this.buf;
            if(this.bufOff <= 7)
            {
                    do
            {
                this.bufOff = this.bufOff + 1;
                val_6[(long)this.bufOff] = 0;
                val_6 = this.buf;
            }
            while(this.bufOff < 8);
            
            }
            
            byte[] val_2 = new byte[0];
            val_7 = val_2;
            System.Array.Copy(sourceArray:  this.buf, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.mac.Length);
            if(this.firstStep != false)
            {
                    this.firstStep = false;
            }
            else
            {
                    val_7 = Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(buf:  this.buf, bufOff:  0, mac:  this.mac);
            }
            
            this.gost28147MacFunc(workingKey:  this.workingKey, input:  val_7, inOff:  0, output:  this.mac, outOff:  0);
            var val_4 = (this.mac.Length < 0) ? (this.mac.Length + 1) : this.mac.Length;
            val_4 = val_4 >> 1;
            System.Array.Copy(sourceArray:  this.mac, sourceIndex:  val_4 - 4, destinationArray:  output, destinationIndex:  outOff, length:  4);
            this.Reset();
            return 4;
        }
        public void Reset()
        {
            System.Array.Clear(array:  this.buf, index:  0, length:  this.buf.Length);
            this.bufOff = 0;
            this.firstStep = true;
        }
    
    }

}
